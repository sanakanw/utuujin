Public Class SpriteBox
	Private m_graphics As Graphics
	Private m_bitmap As Bitmap

	Private Sub SpriteBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		m_graphics = panelSprite.CreateGraphics()
		m_graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
		m_graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor
	End Sub

	Public Sub SetBitmap(bmp As Bitmap)
		m_bitmap = bmp
		panelSprite.Refresh()
	End Sub

	Private Sub panelSprite_Paint(sender As Object, e As PaintEventArgs) Handles panelSprite.Paint
		If m_bitmap IsNot Nothing Then
			m_graphics.DrawImage(
			m_bitmap,
			0,
			0,
			panelSprite.Width + 2,
			panelSprite.Height + 2)
		End If
	End Sub

	Private Sub panelSprite_Click(sender As Object, e As EventArgs) Handles panelSprite.Click
		Me.OnClick(EventArgs.Empty)
	End Sub
End Class
