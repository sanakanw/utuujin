Public Class Form1
	Dim currentquestion As Integer
	Dim questions(10, 2) As Color
	Dim answers(10) As Color



	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		currentquestion = 0
		answers(0) = Color.Red
		answers(1) = Color.Blue
		answers(2) = Color.Lime
		answers(3) = Color.Yellow
		answers(4) = Color.Lime
		answers(5) = Color.Red
		answers(6) = Color.Lime
		answers(7) = Color.Blue
		answers(8) = Color.Red
		answers(9) = Color.Yellow
		questions(0, 0) = Color.Yellow
		questions(0, 1) = Color.Magenta
		questions(1, 0) = Color.Magenta
		questions(1, 1) = Color.Cyan
		questions(2, 0) = Color.Cyan
		questions(2, 1) = Color.Yellow
		questions(3, 0) = Color.Red
		questions(3, 1) = Color.Green
		questions(4, 0) = Color.Olive
		questions(4, 1) = Color.Yellow
		questions(5, 0) = Color.Magenta
		questions(5, 1) = Color.Blue
		questions(6, 0) = Color.DarkGreen
		questions(6, 1) = Color.Gray
		questions(7, 0) = Color.Cyan
		questions(7, 1) = Color.Gray
		questions(8, 0) = Color.Salmon
		questions(8, 1) = Color.White
		questions(9, 0) = Color.Orange
		questions(9, 1) = Color.Red
		Load_currentquestion()
	End Sub

	Sub Load_currentquestion()
		Label1.BackColor = questions(currentquestion, 0)
		Label2.BackColor = questions(currentquestion, 1)
	End Sub
	Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
		My.Computer.Audio.Play("Assets/Button_Click.wav", AudioPlayMode.WaitToComplete)
		If Ans1.BackColor = answers(currentquestion) Then
			My.Computer.Audio.Play("Assets/Correct.wav", AudioPlayMode.WaitToComplete)
			MsgBox("Correct !", vbOKOnly)
			currentquestion = currentquestion + 1
			Load_currentquestion()
			Ans1.Text = "?"
			Ans1.BackColor = Color.White
			If currentquestion = 5 Then
				Text_plus.Text = "-"
			End If
			If currentquestion = 10 Then
				MainGame.PostEvent(MainGame.GameEvent.LOAD_GAME_MAIN)
			End If
		Else
			My.Computer.Audio.Play("Assets/Error.wav", AudioPlayMode.WaitToComplete)
			MsgBox("Incorrect !", vbRetryCancel)



		End If
	End Sub

	Private Sub Button_Blue_Click(sender As Object, e As EventArgs) Handles Button_Blue.Click
		Ans1.BackColor = Color.Blue
		My.Computer.Audio.Play("Assets/Button_Click.wav", AudioPlayMode.WaitToComplete)
		Ans1.Text = ""
	End Sub

	Private Sub Button_Red_Click(sender As Object, e As EventArgs) Handles Button_Red.Click
		Ans1.BackColor = Color.Red
		My.Computer.Audio.Play("Assets/Button_Click.wav", AudioPlayMode.WaitToComplete)
		Ans1.Text = ""
	End Sub

	Private Sub Button_Yellow_Click(sender As Object, e As EventArgs) Handles Button_Yellow.Click
		Ans1.BackColor = Color.Yellow
		My.Computer.Audio.Play("Assets/Button_Click.wav", AudioPlayMode.WaitToComplete)
		Ans1.Text = ""
	End Sub

	Private Sub Button_Green_Click(sender As Object, e As EventArgs) Handles Button_Green.Click
		Ans1.BackColor = Color.Lime
		My.Computer.Audio.Play("Assets/Button_Click.wav", AudioPlayMode.WaitToComplete)
		Ans1.Text = ""
	End Sub
End Class
