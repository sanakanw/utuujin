Public Class GameSoundPlayer
	Private Shared m_soundTable As System.Media.SoundPlayer() = {
		New System.Media.SoundPlayer(My.Resources.snd_button_click),
		New System.Media.SoundPlayer(My.Resources.snd_correct),
		New System.Media.SoundPlayer(My.Resources.snd_error)
	}

	Private Shared m_bgmTable As String() = {
		"\bgm_reality.mp3"
	}

	Private Shared m_bgmPlayer As System.Windows.Media.MediaPlayer = New System.Windows.Media.MediaPlayer

	Public Shared Sub Play(gameSound As GameSound)
		m_soundTable(gameSound).Play()
	End Sub

	Public Shared Sub PlayBgm(gameBgm As GameBgm)
		m_bgmPlayer.Open(New Uri(System.Environment.CurrentDirectory + m_bgmTable(gameBgm)))
		m_bgmPlayer.Play()
	End Sub
End Class
