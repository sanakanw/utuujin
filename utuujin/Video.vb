Imports System.Drawing.Imaging

Public Class Video
	Private m_width As Integer
	Private m_height As Integer

	Private m_bmp As Bitmap
	Private m_bmpDef As Rectangle

	Private m_pixelBuffer() As Integer

	Public ReadOnly Property Width() As Integer
		Get
			Return m_width
		End Get
	End Property
	Public ReadOnly Property Height() As Integer
		Get
			Return m_height
		End Get
	End Property

	Public ReadOnly Property ImageBuffer() As Bitmap
		Get
			Return m_bmp
		End Get
	End Property

	Public ReadOnly Property GetPixel(x As Integer, y As Integer) As Integer
		Get
			Return m_pixelBuffer(x + y * m_width)
		End Get
	End Property

	Public Sub New(width As Integer, height As Integer)
		m_width = width
		m_height = height

		m_bmp = New Bitmap(width, height, PixelFormat.Format32bppRgb)
		m_bmpDef = New Rectangle(0, 0, width, height)

		ReDim m_pixelBuffer(width * height)
	End Sub

	Public Sub PutPixel(color As Integer, xPos As Integer, yPos As Integer)
		m_pixelBuffer(xPos + yPos * m_width) = color
	End Sub

	Public Sub Update()
		Dim bmpData As BitmapData = m_bmp.LockBits(m_bmpDef, ImageLockMode.ReadWrite, m_bmp.PixelFormat)
		Dim bmpStartAddr As IntPtr = bmpData.Scan0

		System.Runtime.InteropServices.Marshal.Copy(m_pixelBuffer, 0, bmpStartAddr, m_pixelBuffer.Length - 1)

		m_bmp.UnlockBits(bmpData)
	End Sub
End Class
