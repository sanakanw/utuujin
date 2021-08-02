Imports System.Runtime.InteropServices
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
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_OLIVE, .strOperator = "+", .rightHandSide = GameColor.COLOR_YELLOW, .answer = GameColor.COLOR_LIME},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_MAGENTA, .strOperator = "-", .rightHandSide = GameColor.COLOR_BLUE, .answer = GameColor.COLOR_RED},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_DARK_GREEN, .strOperator = "-", .rightHandSide = GameColor.COLOR_GRAY, .answer = GameColor.COLOR_LIME},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_CYAN, .strOperator = "+", .rightHandSide = GameColor.COLOR_GRAY, .answer = GameColor.COLOR_BLUE},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_SALMON, .strOperator = "-", .rightHandSide = GameColor.COLOR_WHITE, .answer = GameColor.COLOR_RED},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_RED, .strOperator = "+", .rightHandSide = GameColor.COLOR_GREEN, .answer = GameColor.COLOR_YELLOW},
		New _ColorGameQuestion With {.leftHandSide = GameColor.COLOR_ORANGE, .strOperator = "-", .rightHandSide = GameColor.COLOR_RED, .answer = GameColor.COLOR_YELLOW}
	}

	Private m_selectedAnswer As GameColor
	Private m_currentQuestion As Integer

	Private Sub ColorGameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		_ColorGameInit()
		_ColorGameLoad()
	End Sub

	Private Sub ColorGameScreen_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
		If Me.Visible = True Then
			_ColorGameLoad()
		End If
	End Sub

	Private Sub _ColorGameInit()
		_InitPaintBmp()
	End Sub

	Private Sub _ColorGameLoad()
		m_currentQuestion = 0
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

		Dim bmp As Bitmap = My.Resources.png_paint_bucket

		For paintIndex As Integer = 0 To m_paintBmpTable.Count - 1
			m_paintBmpTable(paintIndex) = New Bitmap(Settings.SPRITE_SIZE, Settings.SPRITE_SIZE)

			For yTexCoord As Integer = 0 To bmp.Width - 1
				For xTexCoord As Integer = 0 To bmp.Height - 1
					Dim color As Color = bmp.GetPixel(xTexCoord, yTexCoord)

					If color.R = 255 And color.G = 0 And color.B = 255 Then
						m_paintBmpTable(paintIndex).SetPixel(xTexCoord, yTexCoord, colorTable(paintIndex))
					Else
						m_paintBmpTable(paintIndex).SetPixel(xTexCoord, yTexCoord, color)
					End If
				Next
			Next
		Next

		spriteBackButton.SetBitmap(My.Resources.png_btn_back)
		spriteCheckButton.SetBitmap(My.Resources.png_btn_check)

		spriteAnswer.SetBitmap(m_paintBmpTable(GameColor.COLOR_BLUE))
	End Sub

	Private Sub _LoadCurrentQuestion()
		spriteLeftHandSide.SetBitmap(m_paintBmpTable(m_questionTable(m_currentQuestion).leftHandSide))
		spriteRightHandSide.SetBitmap(m_paintBmpTable(m_questionTable(m_currentQuestion).rightHandSide))

		lblOperator.Text = m_questionTable(m_currentQuestion).strOperator
	End Sub

	Private Sub _QuestionCorrect()
		GameSoundPlayer.Play(GameSound.SOUND_CORRECT)
	End Sub

	Private Sub _QuestionIncorrect()
		GameSoundPlayer.Play(GameSound.SOUND_ERROR)
	End Sub

	Private Sub spriteCheck_Click(sender As Object, e As EventArgs) Handles spriteCheckButton.Click
		GameSoundPlayer.Play(GameSound.SOUND_BUTTON_CLICK)

		If m_selectedAnswer = m_questionTable(m_currentQuestion).answer Then
			_QuestionCorrect()

			m_currentQuestion = m_currentQuestion + 1

			If m_currentQuestion = m_questionTable.Length Then
				MainGame.PostEvent(GameEvent.EVENT_PAINT_COMPLETE)
			Else
				_LoadCurrentQuestion()

				If m_currentQuestion = m_questionTable.Length Then
					m_currentQuestion = 0
				End If
			End If
		Else
			_QuestionIncorrect()
		End If
	End Sub

	Private Sub _Button_Click(color As GameColor)
		m_selectedAnswer = color
		spriteAnswer.SetBitmap(m_paintBmpTable(m_selectedAnswer))
		GameSoundPlayer.Play(GameSound.SOUND_BUTTON_CLICK)
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

	Private Sub spriteBackButton_Click(sender As Object, e As EventArgs) Handles spriteBackButton.Click
		MainGame.PostEvent(GameEvent.LOAD_GAME_MAIN)
		GameSoundPlayer.Play(GameSound.SOUND_BUTTON_CLICK)
	End Sub
End Class
