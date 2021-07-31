Public Class ClimbingGameScreen
	Private Enum _GameShape
		SHAPE_CIRCLE
		SHAPE_SQUARE
		SHAPE_TRIANGLE
		SHAPE_DIAMOND
	End Enum

	Private Structure _ShapeGameQuestion
		Public shape As _GameShape
		Public column As Integer
	End Structure

	Private Const SHAPE_OFFSET_LEFT As Integer = 150
	Private Const SHAPE_OFFSET_RIGHT As Integer = 400
	Private Const QUESTION_COUNT As Integer = 17

	Private m_spriteBoxShape(3) As SpriteBox

	Private m_shapeBmpTable() As Bitmap = {
		My.Resources.png_shape_circle,
		My.Resources.png_shape_square,
		My.Resources.png_shape_triangle,
		My.Resources.png_shape_diamond
	}

	Private m_currentQuestion As Integer
	Private m_questionTable(QUESTION_COUNT) As _ShapeGameQuestion

	Private Sub ClimbingGameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		spriteBackdrop.SetBitmap(My.Resources.png_climbing_game_backdrop)

		spriteChoiceCircle.SetBitmap(My.Resources.png_btn_circle)
		spriteChoiceTriangle.SetBitmap(My.Resources.png_btn_triangle)
		spriteChoiceSquare.SetBitmap(My.Resources.png_btn_square)
		spriteChoiceDiamond.SetBitmap(My.Resources.png_btn_diamond)

		m_spriteBoxShape(0) = spriteShapeRow1
		m_spriteBoxShape(1) = spriteShapeRow2
		m_spriteBoxShape(2) = spriteShapeRow3
		m_spriteBoxShape(3) = spriteShapeRow4

		For i As Integer = 0 To QUESTION_COUNT
			Dim randomColumn As Integer = GlobalRandom.NextInt() Mod 4
			Dim randomShape As _GameShape = GlobalRandom.NextInt() Mod (_GameShape.SHAPE_DIAMOND + 1)

			m_questionTable(i) = New _ShapeGameQuestion With {.shape = randomShape, .column = randomColumn}
		Next

		_LoadCurrentQuestion()
	End Sub

	Private Sub _LoadCurrentQuestion()
		For i As Integer = 0 To m_spriteBoxShape.Length - 1
			Dim currentIndex = m_currentQuestion + i

			If currentIndex >= 0 And currentIndex < QUESTION_COUNT Then
				Dim currentQuestion As _ShapeGameQuestion = m_questionTable(currentIndex)

				Dim xPos As Integer = SHAPE_OFFSET_LEFT + currentQuestion.column * (SHAPE_OFFSET_RIGHT - SHAPE_OFFSET_LEFT) / 4

				m_spriteBoxShape(i).SetBitmap(m_shapeBmpTable(currentQuestion.shape))
				m_spriteBoxShape(i).Location = New Point(xPos, m_spriteBoxShape(i).Location.Y)

				m_spriteBoxShape(i).Visible = True
			Else
				m_spriteBoxShape(i).Visible = False
			End If
		Next
	End Sub

	Private Sub _spriteChoice_Click(gameShape As _GameShape)
		If m_questionTable(m_currentQuestion).shape = gameShape Then
			m_currentQuestion = m_currentQuestion + 1
			MainGame.PlaySound(GameSound.SOUND_CORRECT)
			spriteBackdrop.Location = New Point(0, spriteBackdrop.Location.Y + 64)
			_LoadCurrentQuestion()

			If m_currentQuestion = QUESTION_COUNT Then

			End If
		Else
			MainGame.PlaySound(GameSound.SOUND_ERROR)
		End If
	End Sub

	Private Sub spriteChoiceTriangle_Click(sender As Object, e As EventArgs) Handles spriteChoiceTriangle.Click
		_spriteChoice_Click(_GameShape.SHAPE_TRIANGLE)
	End Sub

	Private Sub spriteChoiceSquare_Click(sender As Object, e As EventArgs) Handles spriteChoiceSquare.Click
		_spriteChoice_Click(_GameShape.SHAPE_SQUARE)
	End Sub

	Private Sub spriteChoiceCircle_Click(sender As Object, e As EventArgs) Handles spriteChoiceCircle.Click
		_spriteChoice_Click(_GameShape.SHAPE_CIRCLE)
	End Sub

	Private Sub spriteChoiceDiamond_Click(sender As Object, e As EventArgs) Handles spriteChoiceDiamond.Click
		_spriteChoice_Click(_GameShape.SHAPE_DIAMOND)
	End Sub
End Class
