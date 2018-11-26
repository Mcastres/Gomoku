// Code generated by protoc-gen-go. DO NOT EDIT.
// source: buffer.proto

package gomokuBuffer

import (
	context "context"
	fmt "fmt"
	proto "github.com/golang/protobuf/proto"
	grpc "google.golang.org/grpc"
	math "math"
)

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

// This is a compile-time assertion to ensure that this generated file
// is compatible with the proto package it is being compiled against.
// A compilation error at this line likely means your copy of the
// proto package needs to be updated.
const _ = proto.ProtoPackageIsVersion2 // please upgrade the proto package

type Node struct {
	X                    int32    `protobuf:"varint,1,opt,name=X,proto3" json:"X,omitempty"`
	Y                    int32    `protobuf:"varint,2,opt,name=Y,proto3" json:"Y,omitempty"`
	Player               int32    `protobuf:"varint,3,opt,name=Player,proto3" json:"Player,omitempty"`
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *Node) Reset()         { *m = Node{} }
func (m *Node) String() string { return proto.CompactTextString(m) }
func (*Node) ProtoMessage()    {}
func (*Node) Descriptor() ([]byte, []int) {
	return fileDescriptor_1e21993b51421452, []int{0}
}

func (m *Node) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_Node.Unmarshal(m, b)
}
func (m *Node) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_Node.Marshal(b, m, deterministic)
}
func (m *Node) XXX_Merge(src proto.Message) {
	xxx_messageInfo_Node.Merge(m, src)
}
func (m *Node) XXX_Size() int {
	return xxx_messageInfo_Node.Size(m)
}
func (m *Node) XXX_DiscardUnknown() {
	xxx_messageInfo_Node.DiscardUnknown(m)
}

var xxx_messageInfo_Node proto.InternalMessageInfo

func (m *Node) GetX() int32 {
	if m != nil {
		return m.X
	}
	return 0
}

func (m *Node) GetY() int32 {
	if m != nil {
		return m.Y
	}
	return 0
}

func (m *Node) GetPlayer() int32 {
	if m != nil {
		return m.Player
	}
	return 0
}

type CDGameRequest struct {
	GameID               string   `protobuf:"bytes,1,opt,name=GameID,proto3" json:"GameID,omitempty"`
	Delete               bool     `protobuf:"varint,2,opt,name=Delete,proto3" json:"Delete,omitempty"`
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *CDGameRequest) Reset()         { *m = CDGameRequest{} }
func (m *CDGameRequest) String() string { return proto.CompactTextString(m) }
func (*CDGameRequest) ProtoMessage()    {}
func (*CDGameRequest) Descriptor() ([]byte, []int) {
	return fileDescriptor_1e21993b51421452, []int{1}
}

func (m *CDGameRequest) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_CDGameRequest.Unmarshal(m, b)
}
func (m *CDGameRequest) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_CDGameRequest.Marshal(b, m, deterministic)
}
func (m *CDGameRequest) XXX_Merge(src proto.Message) {
	xxx_messageInfo_CDGameRequest.Merge(m, src)
}
func (m *CDGameRequest) XXX_Size() int {
	return xxx_messageInfo_CDGameRequest.Size(m)
}
func (m *CDGameRequest) XXX_DiscardUnknown() {
	xxx_messageInfo_CDGameRequest.DiscardUnknown(m)
}

var xxx_messageInfo_CDGameRequest proto.InternalMessageInfo

func (m *CDGameRequest) GetGameID() string {
	if m != nil {
		return m.GameID
	}
	return ""
}

func (m *CDGameRequest) GetDelete() bool {
	if m != nil {
		return m.Delete
	}
	return false
}

type CheckRulesResponse struct {
	IsPossible           bool     `protobuf:"varint,1,opt,name=IsPossible,proto3" json:"IsPossible,omitempty"`
	Captered             []*Node  `protobuf:"bytes,2,rep,name=Captered,proto3" json:"Captered,omitempty"`
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *CheckRulesResponse) Reset()         { *m = CheckRulesResponse{} }
func (m *CheckRulesResponse) String() string { return proto.CompactTextString(m) }
func (*CheckRulesResponse) ProtoMessage()    {}
func (*CheckRulesResponse) Descriptor() ([]byte, []int) {
	return fileDescriptor_1e21993b51421452, []int{2}
}

func (m *CheckRulesResponse) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_CheckRulesResponse.Unmarshal(m, b)
}
func (m *CheckRulesResponse) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_CheckRulesResponse.Marshal(b, m, deterministic)
}
func (m *CheckRulesResponse) XXX_Merge(src proto.Message) {
	xxx_messageInfo_CheckRulesResponse.Merge(m, src)
}
func (m *CheckRulesResponse) XXX_Size() int {
	return xxx_messageInfo_CheckRulesResponse.Size(m)
}
func (m *CheckRulesResponse) XXX_DiscardUnknown() {
	xxx_messageInfo_CheckRulesResponse.DiscardUnknown(m)
}

var xxx_messageInfo_CheckRulesResponse proto.InternalMessageInfo

func (m *CheckRulesResponse) GetIsPossible() bool {
	if m != nil {
		return m.IsPossible
	}
	return false
}

func (m *CheckRulesResponse) GetCaptered() []*Node {
	if m != nil {
		return m.Captered
	}
	return nil
}

type CDGameResponse struct {
	IsSuccess            bool     `protobuf:"varint,1,opt,name=IsSuccess,proto3" json:"IsSuccess,omitempty"`
	Message              string   `protobuf:"bytes,2,opt,name=Message,proto3" json:"Message,omitempty"`
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *CDGameResponse) Reset()         { *m = CDGameResponse{} }
func (m *CDGameResponse) String() string { return proto.CompactTextString(m) }
func (*CDGameResponse) ProtoMessage()    {}
func (*CDGameResponse) Descriptor() ([]byte, []int) {
	return fileDescriptor_1e21993b51421452, []int{3}
}

func (m *CDGameResponse) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_CDGameResponse.Unmarshal(m, b)
}
func (m *CDGameResponse) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_CDGameResponse.Marshal(b, m, deterministic)
}
func (m *CDGameResponse) XXX_Merge(src proto.Message) {
	xxx_messageInfo_CDGameResponse.Merge(m, src)
}
func (m *CDGameResponse) XXX_Size() int {
	return xxx_messageInfo_CDGameResponse.Size(m)
}
func (m *CDGameResponse) XXX_DiscardUnknown() {
	xxx_messageInfo_CDGameResponse.DiscardUnknown(m)
}

var xxx_messageInfo_CDGameResponse proto.InternalMessageInfo

func (m *CDGameResponse) GetIsSuccess() bool {
	if m != nil {
		return m.IsSuccess
	}
	return false
}

func (m *CDGameResponse) GetMessage() string {
	if m != nil {
		return m.Message
	}
	return ""
}

type StonePlayed struct {
	CurrentPlayerMove    *Node    `protobuf:"bytes,1,opt,name=CurrentPlayerMove,proto3" json:"CurrentPlayerMove,omitempty"`
	GameID               string   `protobuf:"bytes,2,opt,name=GameID,proto3" json:"GameID,omitempty"`
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *StonePlayed) Reset()         { *m = StonePlayed{} }
func (m *StonePlayed) String() string { return proto.CompactTextString(m) }
func (*StonePlayed) ProtoMessage()    {}
func (*StonePlayed) Descriptor() ([]byte, []int) {
	return fileDescriptor_1e21993b51421452, []int{4}
}

func (m *StonePlayed) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_StonePlayed.Unmarshal(m, b)
}
func (m *StonePlayed) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_StonePlayed.Marshal(b, m, deterministic)
}
func (m *StonePlayed) XXX_Merge(src proto.Message) {
	xxx_messageInfo_StonePlayed.Merge(m, src)
}
func (m *StonePlayed) XXX_Size() int {
	return xxx_messageInfo_StonePlayed.Size(m)
}
func (m *StonePlayed) XXX_DiscardUnknown() {
	xxx_messageInfo_StonePlayed.DiscardUnknown(m)
}

var xxx_messageInfo_StonePlayed proto.InternalMessageInfo

func (m *StonePlayed) GetCurrentPlayerMove() *Node {
	if m != nil {
		return m.CurrentPlayerMove
	}
	return nil
}

func (m *StonePlayed) GetGameID() string {
	if m != nil {
		return m.GameID
	}
	return ""
}

func init() {
	proto.RegisterType((*Node)(nil), "gomokuBuffer.Node")
	proto.RegisterType((*CDGameRequest)(nil), "gomokuBuffer.CDGameRequest")
	proto.RegisterType((*CheckRulesResponse)(nil), "gomokuBuffer.CheckRulesResponse")
	proto.RegisterType((*CDGameResponse)(nil), "gomokuBuffer.CDGameResponse")
	proto.RegisterType((*StonePlayed)(nil), "gomokuBuffer.StonePlayed")
}

func init() { proto.RegisterFile("buffer.proto", fileDescriptor_1e21993b51421452) }

var fileDescriptor_1e21993b51421452 = []byte{
	// 338 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0xff, 0x7c, 0x52, 0x41, 0x4f, 0xf2, 0x40,
	0x10, 0xa5, 0xc0, 0xc7, 0x07, 0x03, 0x9a, 0x38, 0x07, 0x53, 0x91, 0x18, 0xb2, 0x27, 0x4e, 0x3d,
	0xe0, 0xcd, 0x8b, 0xc4, 0x62, 0x94, 0x18, 0x0c, 0x59, 0x2e, 0x70, 0x2c, 0x74, 0x40, 0x43, 0x61,
	0xb1, 0xd3, 0x9a, 0xf8, 0x5f, 0xfd, 0x31, 0xa6, 0xdb, 0x45, 0x5a, 0x41, 0x6f, 0x7d, 0x6f, 0x27,
	0x6f, 0xde, 0x7b, 0x53, 0x68, 0xcc, 0xe2, 0xc5, 0x82, 0x42, 0x67, 0x1b, 0xaa, 0x48, 0x61, 0x63,
	0xa9, 0xd6, 0x6a, 0x15, 0xdf, 0x69, 0x4e, 0xdc, 0x40, 0xf9, 0x59, 0xf9, 0x84, 0x0d, 0xb0, 0x26,
	0xb6, 0xd5, 0xb6, 0x3a, 0xff, 0xa4, 0x35, 0x49, 0xd0, 0xd4, 0x2e, 0xa6, 0x68, 0x8a, 0xe7, 0x50,
	0x19, 0x05, 0xde, 0x07, 0x85, 0x76, 0x49, 0x53, 0x06, 0x89, 0x5b, 0x38, 0x71, 0xfb, 0x0f, 0xde,
	0x9a, 0x24, 0xbd, 0xc5, 0xc4, 0x51, 0x32, 0x98, 0xc0, 0x41, 0x5f, 0x2b, 0xd5, 0xa4, 0x41, 0x09,
	0xdf, 0xa7, 0x80, 0x22, 0xd2, 0x9a, 0x55, 0x69, 0x90, 0xf0, 0x01, 0xdd, 0x17, 0x9a, 0xaf, 0x64,
	0x1c, 0x10, 0x4b, 0xe2, 0xad, 0xda, 0x30, 0xe1, 0x15, 0xc0, 0x80, 0x47, 0x8a, 0xf9, 0x75, 0x16,
	0x90, 0x56, 0xaa, 0xca, 0x0c, 0x83, 0x0e, 0x54, 0x5d, 0x6f, 0x1b, 0x51, 0x48, 0xbe, 0x5d, 0x6c,
	0x97, 0x3a, 0xf5, 0x2e, 0x3a, 0xd9, 0x4c, 0x4e, 0x12, 0x48, 0x7e, 0xcf, 0x88, 0x47, 0x38, 0xdd,
	0xd9, 0x34, 0x1b, 0x5a, 0x50, 0x1b, 0xf0, 0x38, 0x9e, 0xcf, 0x89, 0xd9, 0x2c, 0xd8, 0x13, 0x68,
	0xc3, 0xff, 0x21, 0x31, 0x7b, 0xcb, 0xd4, 0x6e, 0x4d, 0xee, 0xa0, 0x58, 0x42, 0x7d, 0x1c, 0xa9,
	0x0d, 0xe9, 0xfc, 0x3e, 0xf6, 0xe0, 0xcc, 0x8d, 0xc3, 0x90, 0x36, 0x51, 0x5a, 0xc8, 0x50, 0xbd,
	0xa7, 0x7e, 0x8f, 0x3b, 0x3a, 0x1c, 0xce, 0x14, 0x56, 0xcc, 0x16, 0xd6, 0xfd, 0xb4, 0xa0, 0x9c,
	0x7c, 0xe2, 0x3d, 0x54, 0x52, 0xef, 0x78, 0x99, 0x57, 0xcc, 0x15, 0xdf, 0x6c, 0x1d, 0x7f, 0x4c,
	0xe3, 0x8a, 0x02, 0xf6, 0xcc, 0x05, 0x7d, 0xbc, 0xc8, 0x4f, 0x66, 0xe2, 0x34, 0x7f, 0x7f, 0x12,
	0x05, 0x7c, 0x02, 0xd8, 0x9f, 0xea, 0x2f, 0x95, 0xf6, 0x0f, 0x2b, 0x07, 0xf7, 0x15, 0x85, 0x59,
	0x45, 0xff, 0x89, 0xd7, 0x5f, 0x01, 0x00, 0x00, 0xff, 0xff, 0x59, 0xf9, 0x85, 0x1e, 0x99, 0x02,
	0x00, 0x00,
}

// Reference imports to suppress errors if they are not otherwise used.
var _ context.Context
var _ grpc.ClientConn

// This is a compile-time assertion to ensure that this generated file
// is compatible with the grpc package it is being compiled against.
const _ = grpc.SupportPackageIsVersion4

// GameClient is the client API for Game service.
//
// For semantics around ctx use and closing/ending streaming RPCs, please refer to https://godoc.org/google.golang.org/grpc#ClientConn.NewStream.
type GameClient interface {
	CDGame(ctx context.Context, in *CDGameRequest, opts ...grpc.CallOption) (*CDGameResponse, error)
	Played(ctx context.Context, in *StonePlayed, opts ...grpc.CallOption) (*StonePlayed, error)
	CheckRules(ctx context.Context, in *StonePlayed, opts ...grpc.CallOption) (*CheckRulesResponse, error)
}

type gameClient struct {
	cc *grpc.ClientConn
}

func NewGameClient(cc *grpc.ClientConn) GameClient {
	return &gameClient{cc}
}

func (c *gameClient) CDGame(ctx context.Context, in *CDGameRequest, opts ...grpc.CallOption) (*CDGameResponse, error) {
	out := new(CDGameResponse)
	err := c.cc.Invoke(ctx, "/gomokuBuffer.Game/CDGame", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

func (c *gameClient) Played(ctx context.Context, in *StonePlayed, opts ...grpc.CallOption) (*StonePlayed, error) {
	out := new(StonePlayed)
	err := c.cc.Invoke(ctx, "/gomokuBuffer.Game/Played", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

func (c *gameClient) CheckRules(ctx context.Context, in *StonePlayed, opts ...grpc.CallOption) (*CheckRulesResponse, error) {
	out := new(CheckRulesResponse)
	err := c.cc.Invoke(ctx, "/gomokuBuffer.Game/CheckRules", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

// GameServer is the server API for Game service.
type GameServer interface {
	CDGame(context.Context, *CDGameRequest) (*CDGameResponse, error)
	Played(context.Context, *StonePlayed) (*StonePlayed, error)
	CheckRules(context.Context, *StonePlayed) (*CheckRulesResponse, error)
}

func RegisterGameServer(s *grpc.Server, srv GameServer) {
	s.RegisterService(&_Game_serviceDesc, srv)
}

func _Game_CDGame_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(CDGameRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(GameServer).CDGame(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/gomokuBuffer.Game/CDGame",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(GameServer).CDGame(ctx, req.(*CDGameRequest))
	}
	return interceptor(ctx, in, info, handler)
}

func _Game_Played_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(StonePlayed)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(GameServer).Played(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/gomokuBuffer.Game/Played",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(GameServer).Played(ctx, req.(*StonePlayed))
	}
	return interceptor(ctx, in, info, handler)
}

func _Game_CheckRules_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(StonePlayed)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(GameServer).CheckRules(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/gomokuBuffer.Game/CheckRules",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(GameServer).CheckRules(ctx, req.(*StonePlayed))
	}
	return interceptor(ctx, in, info, handler)
}

var _Game_serviceDesc = grpc.ServiceDesc{
	ServiceName: "gomokuBuffer.Game",
	HandlerType: (*GameServer)(nil),
	Methods: []grpc.MethodDesc{
		{
			MethodName: "CDGame",
			Handler:    _Game_CDGame_Handler,
		},
		{
			MethodName: "Played",
			Handler:    _Game_Played_Handler,
		},
		{
			MethodName: "CheckRules",
			Handler:    _Game_CheckRules_Handler,
		},
	},
	Streams:  []grpc.StreamDesc{},
	Metadata: "buffer.proto",
}
