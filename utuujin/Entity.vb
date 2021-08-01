Public Class Entity

	Public xPos As Single
	Public yPos As Single
	Public state As EntityState

	Public Sub New(_state As EntityState, _xPos As Single, _yPos As Single)
		state = _state
		xPos = _xPos
		yPos = _yPos
	End Sub
End Class
