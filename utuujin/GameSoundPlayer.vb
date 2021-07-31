Public Class GameSoundPlayer
	Private m_soundTable As System.Media.SoundPlayer() = {
		New System.Media.SoundPlayer(My.Resources.snd_button_click),
		New System.Media.SoundPlayer(My.Resources.snd_correct),
		New System.Media.SoundPlayer(My.Resources.snd_error)
	}

	Public Sub New()

	End Sub

	Public Sub Play(gameSound As GameSound)
		m_soundTable(gameSound).Play()
	End Sub
End Class
