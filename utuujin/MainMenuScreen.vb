Public Class MainMenuScreen
	Private Sub MainMenuScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		sprTitle.SetBitmap(My.Resources.png_title)
		sprBtnPlay.SetBitmap(My.Resources.png_btn_play)
	End Sub

	Private Sub sprBtnPlay_Click(sender As Object, e As EventArgs) Handles sprBtnPlay.Click
		GameSoundPlayer.Play(GameSound.SOUND_BUTTON_CLICK)
		MainGame.PostEvent(GameEvent.EVENT_GAME_START)
	End Sub
End Class
