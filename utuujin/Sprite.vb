Public Class Sprite
	Private m_width As Integer
	Private m_height As Integer
	Private m_pixelBuffer() As Integer
	
	Public ReadOnly Property Width As Integer
		Get
			Return m_width
		End Get
	End Property
	
	Public ReadOnly Property Height As Integer
		Get
			Return m_height
		End Get
	End Property

	Public ReadOnly Property GetPixel(x As Integer, y As Integer) As Integer
		Get
			If x + y * m_width > m_width * m_height Then
				Return 0
			End If
			Return m_pixelBuffer(x + y * m_width)
		End Get
	End Property

	Public Sub New(width As Integer, height As Integer, pixelBuffer() As Integer)
		m_width = width
		m_height = height
		m_pixelBuffer = pixelBuffer
	End Sub
End Class
