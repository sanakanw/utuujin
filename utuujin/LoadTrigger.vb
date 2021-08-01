Public Class LoadTrigger
	Public xPos As Single
	Public yPos As Single
	Public width As Single
	Public height As Single
	Public gameEvent As GameEvent
	Public Sub New(_gameEvent As GameEvent, _xPos As Single, _yPos As Single, _width As Single, _height As Single)
		gameEvent = _gameEvent
		xPos = _xPos
		yPos = _yPos
		width = _width
		height = _height
	End Sub
End Class
