Public Class Settings
	Public Const SECONDS_PER_TICK As Double = 1.0 / 60.0

	Public Const SPRITE_SIZE As Integer = 16
	Public Const FIELD_OF_VIEW As Integer = 16

	Public Const VIDEO_WIDTH As Integer = FIELD_OF_VIEW * SPRITE_SIZE
	Public Const VIDEO_HEIGHT As Integer = VIDEO_WIDTH * 3 / 4

	Public Const MAX_MAP_SIZE As Integer = 512 * 512
End Class
