﻿Public Class Player
	Private Const playerMoveSpeed = 1.0 / Settings.SPRITE_SIZE

	Private m_baseEntity As Entity
	Private m_baseState As Entity.EntityState
	Private m_collisionState As ICollisionState

	Public ReadOnly Property baseEntity
		Get
			Return m_baseEntity
		End Get
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

		If (moveX <> 0 Or moveY <> 0) And Not m_collisionState.isCollide Then
			animFrame = 1 - ((currentTick Mod 30) > 15)
		End If

		If m_collisionState.isCollide And userInput.Interact() Then
			Select Case m_collisionState.entityCollide.state
				Case Entity.EntityState.ENTITY_SLIDE
					MainGame.PostEvent(MainGame.GameEvent.LOAD_GAME_CLIMBING)
				Case Entity.EntityState.ENTITY_BOARD
					MainGame.PostEvent(MainGame.GameEvent.LOAD_GAME_WORD_CONNECT)
				Case Entity.EntityState.ENTITY_MAGIC_SQUARE
					MainGame.PostEvent(MainGame.GameEvent.LOAD_GAME_MAGIC_SQUARE)
			End Select
		End If

		If moveY < 0 Then
			m_baseState = Entity.EntityState.ENTITY_PLAYER_BACKWARD
		ElseIf moveY > 0 Then
			m_baseState = Entity.EntityState.ENTITY_PLAYER_FORWARD
		ElseIf moveX < 0 Then
			m_baseState = Entity.EntityState.ENTITY_PLAYER_LEFT
		ElseIf moveX > 0 Then
			m_baseState = Entity.EntityState.ENTITY_PLAYER_RIGHT
		End If

		m_baseEntity.state = m_baseState + animFrame
	End Sub
End Class
