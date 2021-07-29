Public Class Entity
	Enum EntityState
		ENTITY_NONE
		ENTITY_PLAYER_FORWARD
		ENTITY_PLAYER_FORWARD_WALK_0
		ENTITY_PLAYER_FORWARD_WALK_1
		ENTITY_PLAYER_LEFT
		ENTITY_PLAYER_LEFT_WALK_0
		ENTITY_PLAYER_LEFT_WALK_1
		ENTITY_PLAYER_BACKWARD
		ENTITY_PLAYER_BACKWARD_WALK_0
		ENTITY_PLAYER_BACKWARD_WALK_1
		ENTITY_PLAYER_RIGHT
		ENTITY_PLAYER_RIGHT_WALK_0
		ENTITY_PLAYER_RIGHT_WALK_1
		ENTITY_SLIDE
		ENTITY_BOARD
		ENTITY_MAGIC_SQUARE
	End Enum

	Public xPos As Single
	Public yPos As Single
	Public state As EntityState

	Public Sub New(_state As EntityState, _xPos As Single, _yPos As Single)
		state = _state
		xPos = _xPos
		yPos = _yPos
	End Sub
End Class
