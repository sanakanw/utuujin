Public Class BoardHintScren
	Private Sub BoardHintScren_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	
		sprBtnBack.SetBitmap(My.Resources.png_btn_back)
	End Sub

	Private Sub sprBtnBack_Click(sender As Object, e As EventArgs) Handles sprBtnBack.Click
		MainGame.PostEvent(GameEvent.LOAD_GAME_MAIN)
		GameSoundPlayer.Play(GameSound.SOUND_BUTTON_CLICK)
	End Sub
End Class
