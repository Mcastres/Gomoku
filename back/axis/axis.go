package axis

// Axis ...
type Axis struct {
	X, Y int32
}

// Axes is the list Axis
var Axes = [8]Axis{
	Axis{X: 1, Y: 0},   // →
	Axis{X: 1, Y: 1},   // ↘
	Axis{X: 0, Y: 1},   // ↓
	Axis{X: -1, Y: 1},  // ↙
	Axis{X: -1, Y: 0},  // ←
	Axis{X: -1, Y: -1}, // ↖
	Axis{X: 1, Y: -1},  // ↑
	Axis{X: 1, Y: -1},  // ↗
}

// Multiply multiply axis by multiplier
func (axis Axis) Multiply(multiplier int32) Axis {
	return Axis{X: axis.X * multiplier, Y: axis.Y * multiplier}
}

// Divide divide axis by divisor
func (axis Axis) Divide(divisor int32) Axis {
	return Axis{X: axis.X / divisor, Y: axis.Y / divisor}
}