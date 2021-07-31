Public Class CashRegisterScreen
	Private Structure _ItemControl
		Public sprite As SpriteBox
		Public price As Label
		Public multiplier As Label
	End Structure

	Private Structure _ItemQuestion
		Public sprite As Bitmap
		Public price As Integer
		Public multiplier As Integer
	End Structure

	Private m_currentQuestion As Integer = 0

	Private m_questionTable() As _ItemQuestion = {
		New _ItemQuestion With {.sprite = My.Resources.png_item_battery, .price = 240, .multiplier = 5},
		New _ItemQuestion With {.sprite = My.Resources.png_item_nail, .price = 20, .multiplier = 8},
		New _ItemQuestion With {.sprite = My.Resources.png_item_screwdriver, .price = 520, .multiplier = 4},
		New _ItemQuestion With {.sprite = My.Resources.png_item_crowbar, .price = 920, .multiplier = 2},
		New _ItemQuestion With {.sprite = My.Resources.png_item_hammer, .price = 730, .multiplier = 3},
		New _ItemQuestion With {.sprite = My.Resources.png_item_wrench, .price = 520, .multiplier = 6}
	}

	Private m_itemControlTable(7) As _ItemControl

	Private m_digitPtr As Integer = -1
	Private m_answerDigit(4) As Integer

	Private Sub CashRegisterScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		m_itemControlTable(0) = New _ItemControl With {.sprite = sprItem1, .price = lblItemPrice1, .multiplier = lblMul1}
		m_itemControlTable(1) = New _ItemControl With {.sprite = sprItem2, .price = lblItemPrice2, .multiplier = lblMul2}
		m_itemControlTable(2) = New _ItemControl With {.sprite = sprItem3, .price = lblItemPrice3, .multiplier = lblMul3}
		m_itemControlTable(3) = New _ItemControl With {.sprite = sprItem4, .price = lblItemPrice4, .multiplier = lblMul4}
		m_itemControlTable(4) = New _ItemControl With {.sprite = sprItem5, .price = lblItemPrice5, .multiplier = lblMul5}
		m_itemControlTable(5) = New _ItemControl With {.sprite = sprItem6, .price = lblitemPrice6, .multiplier = lblMul6}
		m_itemControlTable(6) = New _ItemControl With {.sprite = sprItem7, .price = lblItemPrice7, .multiplier = lblMul7}
		m_itemControlTable(7) = New _ItemControl With {.sprite = sprItem8, .price = lblItemPrice8, .multiplier = lblMul8}

		_LoadRemainingItems()
		_LoadCurrentQuestion()
	End Sub

	Private Sub _LoadCurrentQuestion()
		Dim currentQuestion As _ItemQuestion = m_questionTable(m_currentQuestion)

		lblNumber.Text = _GetDigitStr(2, currentQuestion.price) + " . " + _GetDigitStr(1, currentQuestion.price) + " " + _GetDigitStr(0, currentQuestion.price)
		lblMultiplier.Text = currentQuestion.multiplier.ToString()
	End Sub

	Private Function _GetDigitStr(digit As Integer, num As Integer) As String
		Return (Math.Floor(num / Math.Pow(10, digit)) Mod 10).ToString()
	End Function

	Private Sub _LoadRemainingItems()
		For i As Integer = 0 To m_itemControlTable.Length - 1
			Dim questionIndex As Integer = i + m_currentQuestion

			If questionIndex < m_questionTable.Length Then
				Dim itemQuestion As _ItemQuestion = m_questionTable(questionIndex)

				m_itemControlTable(i).sprite.SetBitmap(itemQuestion.sprite)
				m_itemControlTable(i).multiplier.Text = itemQuestion.multiplier.ToString() + "x"
				m_itemControlTable(i).price.Text = "$" + _GetDigitStr(2, itemQuestion.price) + "." + _GetDigitStr(1, itemQuestion.price) + _GetDigitStr(0, itemQuestion.price)
			Else
				m_itemControlTable(i).sprite.Hide()
				m_itemControlTable(i).multiplier.Hide()
				m_itemControlTable(i).price.Hide()
			End If
		Next
	End Sub

	Private Sub _UpdateAnswer()
		lblAnswer.Text = m_answerDigit(3).ToString() + " " + m_answerDigit(2).ToString() + " . " + m_answerDigit(1).ToString() + " " + m_answerDigit(0).ToString()
	End Sub

	Private Sub _Digit_Click(digit As Integer)
		m_digitPtr = Math.Min(m_digitPtr + 1, 3)
		m_answerDigit(m_digitPtr) = digit

		MainGame.PlaySound(GameSound.SOUND_BUTTON_CLICK)

		_UpdateAnswer()
	End Sub

	Private Sub lblBtnCheck_Click(sender As Object, e As EventArgs) Handles lblBtnCheck.Click
		Dim itemQuestion As _ItemQuestion = m_questionTable(m_currentQuestion)

		Dim answer As Integer = itemQuestion.price * itemQuestion.multiplier

		For i As Integer = 0 To 3
			If m_answerDigit(i) <> _GetDigitStr(i, answer) Then
				MainGame.PlaySound(GameSound.SOUND_ERROR)
				Return
			End If
		Next

		MainGame.PlaySound(GameSound.SOUND_CORRECT)
		m_currentQuestion = m_currentQuestion + 1

		m_digitPtr = -1
		m_answerDigit(0) = "0"
		m_answerDigit(1) = "0"
		m_answerDigit(2) = "0"
		m_answerDigit(3) = "0"

		_UpdateAnswer()
		_LoadCurrentQuestion()
		_LoadRemainingItems()
	End Sub

	Private Sub lblBtnClear_Click(sender As Object, e As EventArgs) Handles lblBtnClear.Click
		If m_digitPtr > -1 Then
			m_answerDigit(m_digitPtr) = 0
			m_digitPtr = Math.Max(m_digitPtr - 1, -1)

			_UpdateAnswer()
		End If

		MainGame.PlaySound(GameSound.SOUND_BUTTON_CLICK)
	End Sub

	Private Sub lblBtnNum0_Click(sender As Object, e As EventArgs) Handles lblBtnNum0.Click
		_Digit_Click(0)
	End Sub

	Private Sub lblBtnNum1_Click(sender As Object, e As EventArgs) Handles lblBtnNum1.Click
		_Digit_Click(1)
	End Sub

	Private Sub lblBtnNum2_Click(sender As Object, e As EventArgs) Handles lblBtnNum2.Click
		_Digit_Click(2)
	End Sub

	Private Sub lblBtnNum3_Click(sender As Object, e As EventArgs) Handles lblBtnNum3.Click
		_Digit_Click(3)
	End Sub

	Private Sub lblBtnNum4_Click(sender As Object, e As EventArgs) Handles lblBtnNum4.Click
		_Digit_Click(4)
	End Sub

	Private Sub lblBtnNum5_Click(sender As Object, e As EventArgs) Handles lblBtnNum5.Click
		_Digit_Click(5)
	End Sub

	Private Sub lblBtnNum6_Click(sender As Object, e As EventArgs) Handles lblBtnNum6.Click
		_Digit_Click(6)
	End Sub

	Private Sub lblBtnNum7_Click(sender As Object, e As EventArgs) Handles lblBtnNum7.Click
		_Digit_Click(7)
	End Sub

	Private Sub lblBtnNum8_Click(sender As Object, e As EventArgs) Handles lblBtnNum8.Click
		_Digit_Click(8)
	End Sub

	Private Sub lblBtnNum9_Click(sender As Object, e As EventArgs) Handles lblBtnNum9.Click
		_Digit_Click(9)
	End Sub
End Class
