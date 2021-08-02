Public Class Player
	Private Const playerMoveSpeed = 1.0 / Settings.SPRITE_SIZE

	Private m_baseEntity As Entity
	Private m_baseState As EntityState
	Private m_collisionState As ICollisionState

	Public Property baseEntity As Entity
		Get
			Return m_baseEntity
		End Get
		Set (value As Entity)
			m_baseEntity = value
		End Set
	End Property

	Public Sub New(baseEntity As Entity, collisionState As ICollisionState)
		m_baseEntity = baseEntity
		m_collisionState = collisionState

		m_baseState = m_baseEntity.state
	End Sub

	Public Sub Move(currentTick As Integer, userInput As UserInput)
		Dim moveX As Integer = userInput.Right()
		Dim moveY As Integer = userInput.Up()

		m_baseEntity.xPos = m_baseEntity.xPos + userInput.Right() * playerMoveSpeed
		m_baseEntity.yPos = m_baseEntity.yPos - userInput.Up() * playerMoveSpeed
		
		Dim animFrame As Integer = 0
		
		If (moveX <> 0 Or moveY <> 0) Then
			animFrame = 1 - ((currentTick Mod 30) > 15)
		End If

		If m_collisionState.entityCollide IsNot Nothing And userInput.Interact() Then
			Select Case m_collisionState.entityCollide.state
				Case EntityState.ENTITY_SLIDE
					MainGame.PostEvent(GameEvent.LOAD_GAME_CLIMBING)
				Case EntityState.ENTITY_BOARD
					MainGame.PostEvent(GameEvent.LOAD_GAME_CIPHER)
				Case EntityState.ENTITY_MAGIC_SQUARE
					MainGame.PostEvent(GameEvent.LOAD_GAME_MAGIC_SQUARE)
				Case EntityState.ENTITY_MANHOLE_OPEN
					MainGame.PostEvent(GameEvent.LOAD_LEVEL_SEWERS_1)
				Case EntityState.ENTITY_BOOK_GAME
					MainGame.PostEvent(GameEvent.LOAD_GAME_CIPHER)
			End Select
		End If

		If m_collisionState.triggerEvent <> GameEvent.EVENT_NONE Then
			MainGame.PostEvent(m_collisionState.triggerEvent)
		End If

		If moveY < 0 Then
			m_baseState = EntityState.ENTITY_PLAYER_BACKWARD
		ElseIf moveY > 0 Then
			m_baseState = EntityState.ENTITY_PLAYER_FORWARD
		ElseIf moveX < 0 Then
			m_baseState = EntityState.ENTITY_PLAYER_LEFT
		ElseIf moveX > 0 Then
			m_baseState = EntityState.ENTITY_PLAYER_RIGHT
		End If

		m_baseEntity.state = m_baseState + animFrame
	End Sub
End Class
