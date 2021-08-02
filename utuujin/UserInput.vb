Public Class UserInput
	Const AXIS_X = 0
	Const AXIS_Y = 1

	Private m_axisPriority As Integer = AXIS_X

	Private m_up As Single = 0
	Private m_down As Single = 0
	Private m_left As Single = 0
	Private m_right As Single = 0
	Private m_interact As Boolean = False

	Public Sub New()

	End Sub

	Public ReadOnly Property Up() As Integer
		Get
			If m_axisPriority = AXIS_X Then
				If Right <> 0 Then
					Return 0
				End If
			End If
			Return (m_down - m_up)
		End Get
	End Property

	Public ReadOnly Property Right() As Integer
		Get
			If m_axisPriority = AXIS_Y Then
				If Up <> 0 Then
					Return 0
				End If
			End If
			Return (m_left - m_right)
		End Get
	End Property
	
	Public ReadOnly Property Interact() As Boolean
		Get
			Dim interactCache As Boolean = m_interact
			m_interact = False
			
			Return interactCache
		End Get
	End Property

	Public Sub Puppet(xDir As Integer, yDir As Integer)
		m_left = xDir
		m_down = yDir
		m_right = 0
		m_up = 0
	End Sub
	
	Public Sub KeyUp(keyCode As Keys)
		Select Case keyCode
			Case Keys.Up
				m_up = False
				m_axisPriority = AXIS_Y
			Case Keys.Down
				m_down = False
				m_axisPriority = AXIS_Y
			Case Keys.Left
				m_left = False
				m_axisPriority = AXIS_X
			Case Keys.Right
				m_right = False
				m_axisPriority = AXIS_X
			Case Keys.Z
				m_interact = False
		End Select
	End Sub

	Public Sub KeyDown(keyCode As Keys)
		Select Case keyCode
			Case Keys.Up
				If Not m_up Then
					m_up = True
					m_axisPriority = AXIS_Y
				End If
			Case Keys.Down
				If Not m_down Then
					m_down = True
					m_axisPriority = AXIS_Y
				End If
			Case Keys.Left
				If Not m_left Then
					m_left = True
					m_axisPriority = AXIS_X
				End If
			Case Keys.Right
				If Not m_right Then
					m_right = True
					m_axisPriority = AXIS_X
				End If
			Case Keys.Z
				If Not m_interact Then 
					m_interact = True
				End If
		End Select
	End Sub
End Class
