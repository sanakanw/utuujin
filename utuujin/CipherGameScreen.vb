Public Class CipherGameScreen
	Private Const CHARSET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

	Private Structure _ShiftQuestion
		Public target As String
		Public shift As Integer
	End Structure

	Private m_questionTable() As _ShiftQuestion = {
		New _ShiftQuestion With {.target = "HELLO"},
		New _ShiftQuestion With {.target = "THERE"},
		New _ShiftQuestion With {.target = "WHAT"},
		New _ShiftQuestion With {.target = "IS"},
		New _ShiftQuestion With {.target = "YOUR"},
		New _ShiftQuestion With {.target = "NAME"}
	}

	Private m_currentQuestion As Integer = 0
	Private m_currentShift As Integer = 0

	Private m_letterShift(26) As Label

	Private Sub CipherGameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		m_letterShift(0) = lblLetterA
		m_letterShift(1) = lblLetterB
		m_letterShift(2) = lblLetterC
		m_letterShift(3) = lblLetterD
		m_letterShift(4) = lblLetterE
		m_letterShift(5) = lblLetterF
		m_letterShift(6) = lblLetterG
		m_letterShift(7) = lblLetterH
		m_letterShift(8) = lblLetterI
		m_letterShift(9) = lblLetterJ
		m_letterShift(10) = lblLetterK
		m_letterShift(11) = lblLetterL
		m_letterShift(12) = lblLetterM
		m_letterShift(13) = lblLetterN
		m_letterShift(14) = lblLetterO
		m_letterShift(15) = lblLetterP
		m_letterShift(16) = lblLetterQ
		m_letterShift(17) = lblLetterR
		m_letterShift(18) = lblLetterS
		m_letterShift(19) = lblLetterT
		m_letterShift(20) = lblLetterU
		m_letterShift(21) = lblLetterV
		m_letterShift(22) = lblLetterW
		m_letterShift(23) = lblLetterX
		m_letterShift(24) = lblLetterY
		m_letterShift(25) = lblLetterZ

		For i As Integer = 0 To m_questionTable.Length - 2
			m_questionTable(i).shift = GlobalRandom.NextInt() Mod 26
		Next

		sprBtnShiftLeft.SetBitmap(My.Resources.png_btn_shift_left)
		sprBtnShiftRight.SetBitmap(My.Resources.png_btn_shift_right)
		sprBtnCheck.SetBitmap(My.Resources.png_btn_check)

		_LoadCurrentQuestion()
	End Sub

	Private Sub _LoadCurrentQuestion()
		m_currentShift = m_questionTable(m_currentQuestion).shift

		_LoadLetterShift()
	End Sub

	Private Function _EncryptLetter(letter As Char) As Char
		Dim letterPos As Integer = Asc(letter) - Asc("A"c)
		Dim letterShift As Integer = (letterPos + m_currentShift) Mod CHARSET.Length

		Return CHARSET(letterShift)
	End Function

	Private Sub _LoadLetterShift()
		lblEncryptedString.Text = ""

		For i As Integer = 0 To CHARSET.Length - 1
			m_letterShift(i).Text = CHARSET((i + m_currentShift) Mod CHARSET.Length)
		Next

		For i As Integer = 0 To m_questionTable(m_currentQuestion).target.Length - 1
			Dim questionString As String = m_questionTable(m_currentQuestion).target

			lblEncryptedString.Text = lblEncryptedString.Text + _EncryptLetter(questionString(i))
		Next
	End Sub

	Private Sub sprBtnShiftRight_Click(sender As Object, e As EventArgs) Handles sprBtnShiftRight.Click
		MainGame.PlaySound(GameSound.SOUND_BUTTON_CLICK)

		m_currentShift = m_currentShift - 1

		If m_currentShift < 0 Then
			m_currentShift = CHARSET.Length - 1
		End If

		_LoadLetterShift()
	End Sub

	Private Sub sprBtnShiftLeft_Click(sender As Object, e As EventArgs) Handles sprBtnShiftLeft.Click
		MainGame.PlaySound(GameSound.SOUND_BUTTON_CLICK)

		m_currentShift = m_currentShift + 1

		If m_currentShift > CHARSET.Length - 1 Then
			m_currentShift = 0
		End If

		_LoadLetterShift()
	End Sub

	Private Sub sprBtnCheck_Click(sender As Object, e As EventArgs) Handles sprBtnCheck.Click
		If m_currentShift = 0 Then
			MainGame.PlaySound(GameSound.SOUND_CORRECT)
			m_currentQuestion = m_currentQuestion + 1
			_LoadCurrentQuestion()
		Else
			MainGame.PlaySound(GameSound.SOUND_ERROR)
		End If
	End Sub
End Class
