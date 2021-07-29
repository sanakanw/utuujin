
Public Class SpriteTable
	
	Private m_spriteTable() As Sprite
	
	Public Sub Insert(bmp As Bitmap, key As Integer, spriteDef As SpriteDef)
		Dim xTexCoord As Integer = spriteDef.xTexCoord * Settings.SPRITE_SIZE
		Dim yTexCoord As Integer = spriteDef.yTexCoord * Settings.SPRITE_SIZE
			
		Dim texWidth As Integer = spriteDef.texWidth * Settings.SPRITE_SIZE
		Dim texHeight As Integer = spriteDef.texHeight * Settings.SPRITE_SIZE
		
		Dim pixelBuffer(texWidth * texHeight) As Integer
		
		For yTex As Integer = 0 To texHeight - 1
			For xTex As Integer = 0 To texWidth - 1
				Dim color As Integer = 0
				
				Dim pixelColor As Color = bmp.GetPixel(xTexCoord + xTex, yTexCoord + yTex)
				
				color = color Or (CType(pixelColor.A, Int32) << 24)
				color = color Or (CType(pixelColor.R, Int32) << 16)
				color = color Or (CType(pixelColor.G, Int32) << 8)
				color = color Or CType(pixelColor.B, Int32)
				
				pixelBuffer(xTex + yTex * texWidth) = color
			Next
		Next
		
		m_spriteTable(key) = New Sprite(texWidth, texHeight, pixelBuffer)
	End Sub

	Public ReadOnly Property GetSprite(key As Integer) As Sprite
		Get
			Return m_spriteTable(key)
		End Get
	End Property

	Public Sub New(spriteTableSize)
		ReDim m_spriteTable(spriteTableSize)
	End Sub
End Class
