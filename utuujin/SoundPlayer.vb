Public Class SoundPlayer
	Private m_audioPath As String() = {
		"Assets/button_click.wav", ' SOUND_CLICK
		"Assets/correct.wav", ' SOUND_CORRECT
		"Assets/error.wav" ' SOUND_ERROR
	}

	Public Sub New()

	End Sub

	Public Sub Play(gameSound As GameSound)
		My.Computer.Audio.Play(m_audioPath(gameSound))
	End Sub
End Class
