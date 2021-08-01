Public Class WordGameScreen
	Private Const TARGET_STRING As String = "THISISTHEWAYHOME"

	Private m_panelGraphics As Graphics

	Private m_labelOrder(TARGET_STRING.Length) As Label

	Private m_letterPtr As Integer

	Private Sub WordGameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		_WordGameInit()
		_WordGameLoad()
	End Sub

	Private Sub WordGameScreen_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
		If Me.Visible = True Then
			_WordGameLoad()
		End If
	End Sub

	Private Sub _WordGameInit()

		m_labelOrder(0) = lblLetter1
		m_labelOrder(1) = lblLetter2
		m_labelOrder(2) = lblLetter3
		m_labelOrder(3) = lblLetter4
		m_labelOrder(4) = lblLetter5
		m_labelOrder(5) = lblLetter6
		m_labelOrder(6) = lblLetter7
		m_labelOrder(7) = lblLetter8
		m_labelOrder(8) = lblLetter9
		m_labelOrder(9) = lblLetter10
		m_labelOrder(10) = lblLetter11
		m_labelOrder(11) = lblLetter12
		m_labelOrder(12) = lblLetter13
		m_labelOrder(13) = lblLetter14
		m_labelOrder(14) = lblLetter15
		m_labelOrder(15) = lblLetter16

		m_panelGraphics = panelLetterConnect.CreateGraphics()

		sprBtnBack.SetBitmap(My.Resources.png_btn_back)
	End Sub

	Private Sub _WordGameLoad()
		_UpdateProgressLabel()
	End Sub

	Private Sub _UpdateProgressLabel()
		lblProgress.Text = ""

		For i As Integer = 0 To TARGET_STRING.Length - 1
			If i < m_letterPtr Then
				lblProgress.Text = lblProgress.Text + TARGET_STRING(i) + " "
			Else
				lblProgress.Text = lblProgress.Text + "_ "
			End If

			Select Case i
				Case 3, 5, 8, 11
					lblProgress.Text = lblProgress.Text + " "
			End Select
		Next
	End Sub

	Private Sub _LetterClick(sequence As Integer)
		Const xOffset As Integer = 10
		Const yOffset As Integer = 20

		If sequence = m_letterPtr Then
			If sequence > 0 Then
				Dim xStart As Integer = m_labelOrder(sequence - 1).Location.X + xOffset
				Dim yStart As Integer = m_labelOrder(sequence - 1).Location.Y + yOffset

				Dim xEnd As Integer = m_labelOrder(sequence).Location.X + xOffset
				Dim yEnd As Integer = m_labelOrder(sequence).Location.Y + yOffset
				m_panelGraphics.DrawLine(New Pen(Color.White, 1), xStart, yStart, xEnd, yEnd)
			End If

			GameSoundPlayer.Play(GameSound.SOUND_CORRECT)

			m_letterPtr = m_letterPtr + 1

			_UpdateProgressLabel()
		Else
			GameSoundPlayer.Play(GameSound.SOUND_ERROR)
		End If
	End Sub

	Private Sub lblLetter1_Click(sender As Object, e As EventArgs) Handles lblLetter1.Click
		_LetterClick(0)
	End Sub

	Private Sub lblLetter2_Click(sender As Object, e As EventArgs) Handles lblLetter2.Click
		_LetterClick(1)

	End Sub

	Private Sub lblLetter3_Click(sender As Object, e As EventArgs) Handles lblLetter3.Click
		_LetterClick(2)

	End Sub

	Private Sub lblLetter4_Click(sender As Object, e As EventArgs) Handles lblLetter4.Click
		_LetterClick(3)

	End Sub

	Private Sub lblLetter5_Click(sender As Object, e As EventArgs) Handles lblLetter5.Click
		_LetterClick(4)

	End Sub

	Private Sub lblLetter6_Click(sender As Object, e As EventArgs) Handles lblLetter6.Click
		_LetterClick(5)
	End Sub

	Private Sub lblLetter7_Click(sender As Object, e As EventArgs) Handles lblLetter7.Click
		_LetterClick(6)

	End Sub

	Private Sub lblLetter8_Click(sender As Object, e As EventArgs) Handles lblLetter8.Click
		_LetterClick(7)

	End Sub

	Private Sub lblLetter9_Click(sender As Object, e As EventArgs) Handles lblLetter9.Click
		_LetterClick(8)

	End Sub

	Private Sub lblLetter10_Click(sender As Object, e As EventArgs) Handles lblLetter10.Click
		_LetterClick(9)

	End Sub

	Private Sub lblLetter11_Click(sender As Object, e As EventArgs) Handles lblLetter11.Click
		_LetterClick(10)

	End Sub

	Private Sub lblLetter12_Click(sender As Object, e As EventArgs) Handles lblLetter12.Click
		_LetterClick(11)

	End Sub

	Private Sub lblLetter13_Click(sender As Object, e As EventArgs) Handles lblLetter13.Click
		_LetterClick(12)

	End Sub

	Private Sub lblLetter14_Click(sender As Object, e As EventArgs) Handles lblLetter14.Click
		_LetterClick(13)

	End Sub

	Private Sub lblLetter15_Click(sender As Object, e As EventArgs) Handles lblLetter15.Click
		_LetterClick(14)

	End Sub

	Private Sub lblLetter16_Click(sender As Object, e As EventArgs) Handles lblLetter16.Click
		_LetterClick(15)

	End Sub

	Private Sub sprBtnBack_Click(sender As Object, e As EventArgs) Handles sprBtnBack.Click
		MainGame.PostEvent(GameEvent.LOAD_GAME_MAIN)
		GameSoundPlayer.Play(GameSound.SOUND_BUTTON_CLICK)
	End Sub
End Class
