Public Class MagicSquareScreen
	Dim m_resultRow(3) As Label
	Dim m_resultCol(3) As Label

	Dim m_btnGrid(3, 3) As Label
	Dim m_numGrid(3, 3) As Integer

	Private Sub MagicSquareScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		sprBtnCheck.SetBitmap(My.Resources.png_btn_check)

		m_resultCol(0) = lblResultCol1
		m_resultCol(1) = lblResultCol2
		m_resultCol(2) = lblResultCol3

		m_resultRow(0) = lblResultRow1
		m_resultRow(1) = lblResultRow2
		m_resultRow(2) = lblResultRow3

		m_btnGrid(0, 0) = lblGrid11
		m_btnGrid(0, 1) = lblGrid12
		m_btnGrid(0, 2) = lblGrid13

		m_btnGrid(1, 0) = lblGrid21
		m_btnGrid(1, 1) = lblGrid22
		m_btnGrid(1, 2) = lblGrid23

		m_btnGrid(2, 0) = lblGrid31
		m_btnGrid(2, 1) = lblGrid32
		m_btnGrid(2, 2) = lblGrid33

		_UpdateGrid()
	End Sub

	Private Sub sprBtnCheck_Click(sender As Object, e As EventArgs) Handles sprBtnCheck.Click
		MainGame.PlaySound(GameSound.SOUND_BUTTON_CLICK)

		Dim isValid As Boolean = True

		For row As Integer = 0 To 2
			Dim sum As Integer = 0
			For col As Integer = 0 To 2
				sum = sum + m_numGrid(row, col)
			Next

			If sum <> 15 Then
				isValid = False
			End If

			m_resultRow(row).Show()
			m_resultRow(row).Text = sum.ToString()
		Next

		For col As Integer = 0 To 2
			Dim sum As Integer = 0
			For row As Integer = 0 To 2
				sum = sum + m_numGrid(row, col)
			Next

			If sum <> 15 Then
				isValid = False
			End If

			m_resultCol(col).Show()
			m_resultCol(col).Text = sum.ToString()
		Next

		If isValid Then

		Else
			MainGame.PlaySound(GameSound.SOUND_ERROR)
		End If
	End Sub

	Private Sub _UpdateGrid()
		For yGrid As Integer = 0 To 2
			For xGrid As Integer = 0 To 2
				m_btnGrid(xGrid, yGrid).Text = m_numGrid(xGrid, yGrid).ToString()
			Next
		Next
	End Sub

	Private Sub _GridClick(xPos As Integer, yPos As Integer)
		m_numGrid(xPos, yPos) = (m_numGrid(xPos, yPos) + 1) Mod 10

		MainGame.PlaySound(GameSound.SOUND_BUTTON_CLICK)
		_UpdateGrid()
	End Sub

	Private Sub lblGrid12_Click(sender As Object, e As EventArgs) Handles lblGrid12.Click
		_GridClick(0, 1)
	End Sub

	Private Sub lblGrid21_Click(sender As Object, e As EventArgs) Handles lblGrid21.Click
		_GridClick(1, 0)

	End Sub

	Private Sub lblGrid31_Click(sender As Object, e As EventArgs) Handles lblGrid31.Click
		_GridClick(2, 0)

	End Sub

	Private Sub lblGrid32_Click(sender As Object, e As EventArgs) Handles lblGrid32.Click
		_GridClick(2, 1)

	End Sub

	Private Sub lblGrid22_Click(sender As Object, e As EventArgs) Handles lblGrid22.Click
		_GridClick(1, 1)

	End Sub

	Private Sub lblGrid11_Click(sender As Object, e As EventArgs) Handles lblGrid11.Click
		_GridClick(0, 0)

	End Sub

	Private Sub lblGrid13_Click(sender As Object, e As EventArgs) Handles lblGrid13.Click
		_GridClick(0, 2)

	End Sub

	Private Sub lblGrid23_Click(sender As Object, e As EventArgs) Handles lblGrid23.Click
		_GridClick(1, 2)

	End Sub

	Private Sub lblGrid33_Click(sender As Object, e As EventArgs) Handles lblGrid33.Click
		_GridClick(2, 2)

	End Sub
End Class
