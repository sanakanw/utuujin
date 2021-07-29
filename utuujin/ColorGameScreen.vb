Public Class ColorGameScreen
	Private Enum GameColor
		COLOR_YELLOW
		COLOR_MAGENTA
		COLOR_CYAN
		COLOR_RED
		COLOR_OLIVE
		COLOR_DARK_GREEN
		COLOR_SALMON
		COLOR_ORANGE
		COLOR_GRAY
		COLOR_BLUE
		COLOR_WHITE
		COLOR_LIME
		COLOR_GREEN
	End Enum

	Private m_paintBmpTable(GameColor.COLOR_GREEN) As Bitmap

	Private Structure _ColorGameQuestion
		Public answer As GameColor
		Public strOperator As String
		Public leftHandSide As GameColor
		Public rightHandSide As GameColor
	End Structure

	Private m_questionTable() As _ColorGameQuestion = {
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_YELLOW, .strOperator = "+", .rightHandSide = GameColor.COLOR_MAGENTA, .answer = GameColor.COLOR_RED},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_MAGENTA, .strOperator = "+", .rightHandSide = GameColor.COLOR_CYAN, .answer = GameColor.COLOR_BLUE},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_CYAN, .strOperator = "+", .rightHandSide = GameColor.COLOR_YELLOW, .answer = GameColor.COLOR_LIME},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_RED, .strOperator = "+", .rightHandSide = GameColor.COLOR_GREEN, .answer = GameColor.COLOR_YELLOW},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_OLIVE, .strOperator = "+", .rightHandSide = GameColor.COLOR_YELLOW, .answer = GameColor.COLOR_LIME},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_MAGENTA, .strOperator = "-", .rightHandSide = GameColor.COLOR_BLUE, .answer = GameColor.COLOR_RED},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_DARK_GREEN, .strOperator = "+", .rightHandSide = GameColor.COLOR_GRAY, .answer = GameColor.COLOR_LIME},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_CYAN, .strOperator = "+", .rightHandSide = GameColor.COLOR_GRAY, .answer = GameColor.COLOR_BLUE},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_SALMON, .strOperator = "+", .rightHandSide = GameColor.COLOR_WHITE, .answer = GameColor.COLOR_RED},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_ORANGE, .strOperator = "+", .rightHandSide = GameColor.COLOR_RED, .answer = GameColor.COLOR_YELLOW}
	}

	Private m_selectedAnswer As GameColor
	Private m_currentQuestion As Integer

	Private Sub ColorGameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		m_currentQuestion = 0

		_InitPaintBmp()
		_LoadCurrentQuestion()
	End Sub

	Private Sub _InitPaintBmp()
		Dim colorTable() As Color = {
			Color.Yellow,
			Color.Magenta,
			Color.Cyan,
			Color.Red,
			Color.Olive,
			Color.DarkGreen,
			Color.Salmon,
			Color.Orange,
			Color.Gray,
			Color.Blue,
			Color.White,
			Color.Lime,
			Color.Green
		}

		Const paint_xTexCoord = 0 * Settings.SPRITE_SIZE
		Const paint_yTexCoord = 1 * Settings.SPRITE_SIZE

		Const paint_texWidth = Settings.SPRITE_SIZE
		Const paint_texHeight = Settings.SPRITE_SIZE

		Dim bmp As Bitmap = New Bitmap("Assets/sprite_map.png")

		For paintIndex As Integer = 0 To m_paintBmpTable.Count - 1
			m_paintBmpTable(paintIndex) = New Bitmap(Settings.SPRITE_SIZE, Settings.SPRITE_SIZE)

			For yTexCoord As Integer = 0 To paint_texHeight - 1
				For xTexCoord As Integer = 0 To paint_texWidth - 1
					Dim color As Color = bmp.GetPixel(paint_xTexCoord + xTexCoord, paint_yTexCoord + yTexCoord)

					If color.R = 255 And color.G = 0 And color.B = 255 Then
						m_paintBmpTable(paintIndex).SetPixel(xTexCoord, yTexCoord, colorTable(paintIndex))
					Else
						m_paintBmpTable(paintIndex).SetPixel(xTexCoord, yTexCoord, color)
					End If
				Next
			Next
		Next

		Dim bmp_background As Bitmap = bmp.Clone(New Rectangle(10 * Settings.SPRITE_SIZE, 12 * Settings.SPRITE_SIZE, 6 * Settings.SPRITE_SIZE, 4 * Settings.SPRITE_SIZE), bmp.PixelFormat)

		spriteBackground.SetBitmap(bmp_background)
	End Sub

	Private Sub _LoadCurrentQuestion()
		spriteLeftHandSide.SetBitmap(m_paintBmpTable(m_questionTable(m_currentQuestion).leftHandSide))
		spriteRightHandSide.SetBitmap(m_paintBmpTable(m_questionTable(m_currentQuestion).rightHandSide))

		lblOperation.Text = m_questionTable(m_currentQuestion).strOperator
	End Sub

	Private Sub _QuestionCorrect()
		MainGame.PlaySound(GameSound.SOUND_CORRECT)
		MsgBox("Correct !", vbOKOnly)
	End Sub

	Private Sub _QuestionIncorrect()
		MainGame.PlaySound(GameSound.SOUND_ERROR)
		MsgBox("Incorrect !", vbRetryCancel)
	End Sub

	Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
		MainGame.PlaySound(GameSound.SOUND_BUTTON_CLICK)

		If m_selectedAnswer = m_questionTable(m_currentQuestion).answer Then
			_QuestionCorrect()

			m_currentQuestion = m_currentQuestion + 1

			_LoadCurrentQuestion()

			If m_currentQuestion = m_questionTable.Length Then
				m_currentQuestion = 0
				MainGame.PostEvent(MainGame.GameEvent.LOAD_GAME_MAIN)
			End If
		Else
			_QuestionIncorrect()
		End If
	End Sub

	Private Sub _Button_Click(color As GameColor)
		m_selectedAnswer = color
		spriteAnswer.SetBitmap(m_paintBmpTable(m_selectedAnswer))
		MainGame.PlaySound(GameSound.SOUND_BUTTON_CLICK)
	End Sub

	Private Sub Button_Blue_Click(sender As Object, e As EventArgs) Handles btnChoiceBlue.Click
		_Button_Click(GameColor.COLOR_BLUE)
	End Sub

	Private Sub Button_Red_Click(sender As Object, e As EventArgs) Handles btnChoiceRed.Click
		_Button_Click(GameColor.COLOR_RED)
	End Sub

	Private Sub Button_Yellow_Click(sender As Object, e As EventArgs) Handles btnChoiceYellow.Click
		_Button_Click(GameColor.COLOR_YELLOW)
	End Sub

	Private Sub Button_Green_Click(sender As Object, e As EventArgs) Handles btnChoiceGreen.Click
		_Button_Click(GameColor.COLOR_LIME)
	End Sub

	Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
		m_currentQuestion = 0
		MainGame.PostEvent(MainGame.GameEvent.LOAD_GAME_MAIN)
	End Sub
End Class
