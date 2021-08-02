Public Class AnimationState	
	Private Structure _AnimFrame
		Public xDir As Integer
		Public yDir As Integer
		Public duration As Integer
	End Structure

	Private m_finalSceneAnimation() As _AnimFrame = {
		New _AnimFrame With { .xDir =  1, .yDir = 0, .duration  = 1   },
		New _AnimFrame With { .xDir =  0, .yDir = 0, .duration  = 110 },
		New _AnimFrame With { .xDir = -1, .yDir =  0, .duration = 135 },
		New _AnimFrame With { .xDir =  0, .yDir = -1, .duration = 1   },
		New _AnimFrame With { .xDir =  0, .yDir =  0, .duration = 60  },
		New _AnimFrame With { .xDir =  0, .yDir = -1, .duration = 60  }
	}

	Private m_playing As Boolean
	Private m_puppetInput As UserInput
	Private m_currentFrame As Integer
	Private m_nextFrameTick As Integer

	Public ReadOnly Property Playing As Boolean
		Get
			Return m_playing
		End Get
	End Property

	Public Sub New()
		m_puppetInput = New UserInput()
	End Sub

	Public Sub PlayFinalScene(tickCount As Integer)
		m_playing = True

		m_currentFrame = 0
		m_nextFrameTick = tickCount + m_finalSceneAnimation(m_currentFrame).duration
	End Sub

	Public Function GetFrameState(tickCount As Integer) As UserInput
		Dim animFrame As _AnimFrame = m_finalSceneAnimation(m_currentFrame)	

		If tickCount > m_nextFrameTick Then
			m_currentFrame = m_currentFrame + 1

			If m_currentFrame = m_finalSceneAnimation.Length Then
				m_playing = False
			Else
				m_nextFrameTick = tickCount + m_finalSceneAnimation(m_currentFrame).duration
			End If
		End If

		m_puppetInput.Puppet(animFrame.xDir, animFrame.yDir)
		
		Return m_puppetInput
	End Function
End Class
