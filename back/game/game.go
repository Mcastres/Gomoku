package game

import (
	"sync"

	"github.com/Salibert/Gomoku/back/board"
	"github.com/Salibert/Gomoku/back/player"
	"github.com/Salibert/Gomoku/back/rules"
	pb "github.com/Salibert/Gomoku/back/server/pb"
)

// Game contains all the meta data of a part
type Game struct {
	rwmux   sync.RWMutex
	board   board.Board
	players map[int32]*player.Player
}

// New create new instance of Game
func New() *Game {
	game := &Game{
		board:   board.New(),
		players: make(map[int32]*player.Player),
	}
	game.players[1] = &player.Player{
		Index: 1,
		Rules: rules.New(1, 2, pb.ConfigRules{FreeThree: true, NbCaptureForWin: 10}),
	}
	game.players[2] = &player.Player{
		Index: 2,
		Rules: rules.New(2, 1, pb.ConfigRules{FreeThree: true, NbCaptureForWin: 10}),
	}
	return game
}

// ProccessRules ...
func (game *Game) ProccessRules(initialStone *pb.Node) (*pb.CheckRulesResponse, error) {
	game.rwmux.Lock()
	res := &pb.CheckRulesResponse{}
	if game.board[initialStone.X][initialStone.Y] != 0 {
		res.IsPossible = false
		return res, nil
	}
	currentPlayer := game.players[initialStone.Player]
	defer func() {
		go currentPlayer.Rules.Report.Reset()
		game.rwmux.Unlock()
	}()
	game.board.CheckRules(*initialStone, currentPlayer.Rules)
	if currentPlayer.Rules.Report.ItIsAValidMove == true {
		lenListCapture := int32(len(currentPlayer.Rules.Report.ListCapturedStone))
		if lenListCapture != 0 {
			currentPlayer.Score += lenListCapture
			res.NbStonedCaptured = lenListCapture
			res.Captured = currentPlayer.Rules.Report.ListCapturedStone
			if currentPlayer.Score == 10 {
				res.PartyFinish = true
				res.WinIs = currentPlayer.Index
				return res, nil
			}
		} else {
			res.PartyFinish = currentPlayer.Rules.Report.PartyFinish
		}
		if len(currentPlayer.NextMovesOrLose) != 0 {
			if res.PartyFinish = currentPlayer.CheckIfThisMoveBlockLose(initialStone); res.PartyFinish == true {
				res.WinIs = player.GetOpposentPlayer(currentPlayer.Index)
			}
		}
		if currentPlayer.Rules.Report.PartyFinish == false &&
			len(currentPlayer.Rules.Report.WinOrLose) != 0 {
			opposentPlayer := game.players[player.GetOpposentPlayer(initialStone.Player)]
			opposentPlayer.NextMovesOrLose = currentPlayer.Rules.Report.WinOrLose
		}
		game.board.UpdateBoard(*initialStone)
		res.IsPossible = true
	}
	return res, nil
}
