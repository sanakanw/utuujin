Public Class RenderState
	Private Const MAX_SPRITES As Integer = 64
	Private Const MAX_RENDER_ENTITIES As Integer = 64
	
	Public Class _RenderEntity
		Public xPixel0 As Integer
		Public xPixel1 As Integer
		
		Public yPixel0 As Integer
		Public yPixel1 As Integer
		
		Public xTex As Integer
		Public yTex As Integer
		
		Public sprite As Sprite
		
		Public leftNode As _RenderEntity
		Public rightNode As _RenderEntity
	End Class
	
	Private m_video As Video
	
	Private m_tileSprites As SpriteTable
	Private m_entitySprites As SpriteTable
	Private m_floatingTileSprites As SpriteTable
	
	Private m_renderEntities(MAX_RENDER_ENTITIES) As _RenderEntity
	Private m_renderEntityPtr As Integer
	
	Private m_renderOpacity As Integer = 255

	Private Sub _InitSprites()
		m_tileSprites = New SpriteTable(MAX_SPRITES)
		m_entitySprites = New SpriteTable(MAX_SPRITES)
		m_floatingTileSprites = New SpriteTable(MAX_SPRITES)

		Dim bmp As Bitmap = New Bitmap("Assets/SpriteMap.png")

		For i As Integer = 0 To TileDatabase.Size - 1
			Dim tileData As TileData = TileDatabase.Lookup(i)
			m_tileSprites.Insert(bmp, i, tileData.spriteDef)
		Next

		For i As Integer = 0 To FloatingTileDatabase.Size - 1
			Dim floatingTileSprite As SpriteDef = FloatingTileDatabase.Lookup(i)
			m_floatingTileSprites.Insert(bmp, i, floatingTileSprite)
		Next

		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_NONE, New SpriteDef With {.xTexCoord = 0, .yTexCoord = 0, .texWidth = 1, .texheight = 1})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_PLAYER_FORWARD, New SpriteDef With {.xTexCoord = 0, .yTexCoord = 5, .texWidth = 1, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_PLAYER_FORWARD_WALK_0, New SpriteDef With {.xTexCoord = 1, .yTexCoord = 5, .texWidth = 1, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_PLAYER_FORWARD_WALK_1, New SpriteDef With {.xTexCoord = 2, .yTexCoord = 5, .texWidth = 1, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_PLAYER_LEFT, New SpriteDef With {.xTexCoord = 0, .yTexCoord = 7, .texWidth = 1, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_PLAYER_LEFT_WALK_0, New SpriteDef With {.xTexCoord = 1, .yTexCoord = 7, .texWidth = 1, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_PLAYER_LEFT_WALK_1, New SpriteDef With {.xTexCoord = 2, .yTexCoord = 7, .texWidth = 1, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_PLAYER_BACKWARD, New SpriteDef With {.xTexCoord = 0, .yTexCoord = 9, .texWidth = 1, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_PLAYER_BACKWARD_WALK_0, New SpriteDef With {.xTexCoord = 1, .yTexCoord = 9, .texWidth = 1, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_PLAYER_BACKWARD_WALK_1, New SpriteDef With {.xTexCoord = 2, .yTexCoord = 9, .texWidth = 1, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_PLAYER_RIGHT, New SpriteDef With {.xTexCoord = 0, .yTexCoord = 11, .texWidth = 1, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_PLAYER_RIGHT_WALK_0, New SpriteDef With {.xTexCoord = 1, .yTexCoord = 11, .texWidth = 1, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_PLAYER_RIGHT_WALK_1, New SpriteDef With {.xTexCoord = 2, .yTexCoord = 11, .texWidth = 1, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_SLIDE, New SpriteDef With {.xTexCoord = 3, .yTexCoord = 4, .texWidth = 5, .texheight = 4})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_BOARD, New SpriteDef With {.xTexCoord = 0, .yTexCoord = 2, .texWidth = 2, .texheight = 2})
		m_entitySprites.Insert(bmp, Entity.EntityState.ENTITY_MAGIC_SQUARE, New SpriteDef With {.xTexCoord = 0, .yTexCoord = 4, .texWidth = 2, .texheight = 1})
	End Sub

	Public Sub New(video As Video)
		m_video = video

		_InitSprites()

		m_renderEntityPtr = 0
		For i As Integer = 0 to MAX_RENDER_ENTITIES - 1
			m_renderEntities(i) = New _RenderEntity()
		Next
	End Sub
	
	Private Sub _PutPixelOpacity(color As Integer, x As Integer, y As Integer, opacity As Integer)
		Dim red As Integer = (color >> 16) And &HFF
		Dim green As Integer = (color >> 8) And &HFF
		Dim blue As Integer = color And &HFF
		
		red = (red * opacity << 8) And &HFF0000
		green = (green * opacity ) And &H00FF00
		blue = (blue * opacity >> 8) And &HFF

		m_video.PutPixel(red Or green Or blue, x, y)
	End Sub

	Private Sub _RenderEntityDraw(sprite As Sprite, renderEntity As _RenderEntity)
		Dim yTex As Integer = renderEntity.yTex

		For y As Integer = renderEntity.yPixel0 To renderEntity.yPixel1 - 1
			Dim xTex As Integer = renderEntity.xTex

			For x As Integer = renderEntity.xPixel0 To renderEntity.xPixel1
				Dim color As Integer = sprite.GetPixel(xTex, yTex)

				If color <> &H0 Then
					_PutPixelOpacity(color, x, y, m_renderOpacity)
				End If

				xTex = xTex + 1
			Next

			yTex = yTex + 1
		Next
	End Sub

	Private Function _RenderEntityAllocate(entity As Entity, xView As Single, yView As Single) As _RenderEntity
		Dim sprite As Sprite = m_entitySprites.GetSprite(entity.state)

		Dim xPixel0 As Integer = (entity.xPos - xView - 1) * Settings.SPRITE_SIZE
		Dim xPixel1 As Integer = xPixel0 + sprite.Width - 1

		Dim yPixel1 As Integer = (entity.yPos - yView - 1) * Settings.SPRITE_SIZE
		Dim yPixel0 As Integer = yPixel1 - sprite.Height

		Dim xTex As Integer = 0
		Dim yTex As Integer = 0

		If xPixel0 < 0 Then
			Dim xClip As Integer = 0 - xPixel0
			xPixel0 = xPixel0 + xClip
			xTex = xTex + xClip
		End If

		If yPixel0 < 0 Then
			Dim yClip As Integer = 0 - yPixel0
			yPixel0 = yPixel0 + yClip
			yTex = yTex + yClip
		End If

		If xPixel1 >= Settings.VIDEO_WIDTH Then
			xPixel1 = Settings.VIDEO_WIDTH - 1
		End If

		If yPixel1 >= Settings.VIDEO_HEIGHT Then
			yPixel1 = Settings.VIDEO_HEIGHT - 1
		End If

		Dim renderEntity As _RenderEntity = m_renderEntities(m_renderEntityPtr)
		renderEntity.xPixel0 = xPixel0
		renderEntity.yPixel0 = yPixel0
		renderEntity.xPixel1 = xPixel1
		renderEntity.yPixel1 = yPixel1
		renderEntity.xTex = xTex
		renderEntity.yTex = yTex
		renderEntity.sprite = sprite

		renderEntity.leftNode = Nothing
		renderEntity.rightNode = Nothing

		m_renderEntityPtr = m_renderEntityPtr + 1

		Return renderEntity
	End Function

	Private Sub _RenderEntityTreeInsert(root As _RenderEntity, node As _RenderEntity)
		If node.xPixel0 < node.xPixel1 And node.yPixel0 < node.yPixel1 Then
			If node.yPixel1 < root.yPixel1 Then
				If root.leftNode IsNot Nothing Then
					_RenderEntityTreeInsert(root.leftNode, node)
				Else
					root.leftNode = node
				End If
			Else
				If root.rightNode IsNot Nothing Then
					_RenderEntityTreeInsert(root.rightNode, node)
				Else
					root.rightNode = node
				End If
			End If
		End If
	End Sub

	Private Sub _RenderEntityDraw_R(node As _RenderEntity)
		If node.leftNode IsNot Nothing Then
			_RenderEntityDraw_R(node.leftNode)
		End If

		_RenderEntityDraw(node.sprite, node)

		If node.rightNode IsNot Nothing Then
			_RenderEntityDraw_R(node.rightNode)
		End If
	End Sub

	Public Sub SetOpacity(renderOpacity As Integer)
		m_renderOpacity = renderOpacity
	End Sub

	Public Sub RenderEntities(entities As List(Of Entity), xView As Single, yView As Single)
		If entities.Count > 0 Then
			Dim root As _RenderEntity

			m_renderEntityPtr = 0

			root = _RenderEntityAllocate(entities(0), xView, yView)

			For i = 1 To entities.Count - 1
				_RenderEntityTreeInsert(root, _RenderEntityAllocate(entities(i), xView, yView))
			Next

			_RenderEntityDraw_R(root)
		End If
	End Sub

	Private Function _TileGetSprite(map As TileMap, xTile As Integer, yTile As Integer) As Sprite
		Return m_tileSprites.GetSprite(map.GetTile(xTile, yTile))
	End Function

	Private Sub _RenderTile(sprite As Sprite, xPos As Integer, yPos As Integer, xClip0 As Integer, yClip0 As Integer, xClip1 As Integer, yClip1 As Integer)
		For y As Integer = 0 To Settings.SPRITE_SIZE - 1 - yClip0 - yClip1
			For x As Integer = 0 To Settings.SPRITE_SIZE - 1 - xClip0 - xClip1
				Dim color As Integer = sprite.GetPixel(x + xClip0, y + yClip0)

				If color <> &H0 Then
					_PutPixelOpacity(color, x + xPos + xClip1, y + yPos + yClip1, m_renderOpacity)
					' m_video.Put_Pixel(color, x + xPos + xClip1, y + yPos + yClip1)
				End If
			Next
		Next
	End Sub

	Public Sub RenderFloatingTiles(floatingTiles As List(Of FloatingTile), xView As Single, yView As Single)
		For i As Integer = 0 To floatingTiles.Count - 1
			Dim floatingTile As FloatingTile = floatingTiles(i)

			Dim xPixel As Integer = CType((-xView + floatingTile.xPos) * Settings.SPRITE_SIZE, Integer)
			Dim yPixel As Integer = CType((-yView + floatingTile.yPos) * Settings.SPRITE_SIZE, Integer)

			Dim xClip0 As Integer = 0
			Dim xClip1 As Integer = 0
			Dim yClip0 As Integer = 0
			Dim yClip1 As Integer = 0

			If xPixel < 0 Then
				xClip0 = 0 - xPixel
				xPixel = xPixel + xClip0
			End If

			If yPixel < 0 Then
				yClip0 = 0 - yPixel
				yPixel = yPixel + yClip0
			End If

			If xPixel + Settings.SPRITE_SIZE >= Settings.VIDEO_WIDTH Then
				xClip1 = xPixel + Settings.SPRITE_SIZE - Settings.VIDEO_WIDTH
				xPixel = xPixel - xClip1
			End If

			_RenderTile(
				m_floatingTileSprites.GetSprite(floatingTile.tileType),
				xPixel,
				yPixel,
				xClip0,
				yClip0,
				xClip1,
				yClip1
			)
		Next
	End Sub

	Public Sub RenderMap(map As TileMap, xView As Single, yView As Single)
		Dim xShift As Integer = CType(-xView * Settings.SPRITE_SIZE, Integer) And (Settings.SPRITE_SIZE - 1)
		Dim yShift As Integer = CType(-yView * Settings.SPRITE_SIZE, Integer) And (Settings.SPRITE_SIZE - 1)

		Dim xTileShift As Integer = CType(+xView * Settings.SPRITE_SIZE + xShift, Integer) >> 4
		Dim yTileShift As Integer = CType(+yView * Settings.SPRITE_SIZE + yShift, Integer) >> 4

		Dim clipTop As Integer = Settings.SPRITE_SIZE - yShift
		Dim clipLeft As Integer = Settings.SPRITE_SIZE - xShift
		Dim clipRight As Integer = xShift
		Dim clipBottom As Integer = yShift

		Dim leftTileBegin As Integer = xTileShift
		Dim topTileBegin As Integer = yTileShift
		Dim rightTileBegin As Integer = xTileShift + Settings.FIELD_OF_VIEW
		Dim bottomTileBegin As Integer = yTileShift + Settings.FIELD_OF_VIEW * 3 / 4

		Dim rightBegin As Integer = Settings.VIDEO_WIDTH - Settings.SPRITE_SIZE
		Dim bottomBegin As Integer = Settings.VIDEO_HEIGHT - Settings.SPRITE_SIZE

		_RenderTile(_TileGetSprite(map, leftTileBegin, topTileBegin), 0, 0, clipLeft, clipTop, 0, 0)
		_RenderTile(_TileGetSprite(map, rightTileBegin, topTileBegin), rightBegin, 0, 0, clipTop, clipRight, 0)
		_RenderTile(_TileGetSprite(map, leftTileBegin, bottomTileBegin), 0, bottomBegin, clipLeft, 0, 0, clipBottom)
		_RenderTile(_TileGetSprite(map, rightTileBegin, bottomTileBegin), rightBegin, bottomBegin, 0, 0, clipRight, clipBottom)

		Dim xTile As Integer = leftTileBegin
		Dim yTile As Integer = topTileBegin

		For xPos As Integer = xShift To rightBegin Step Settings.SPRITE_SIZE
			xTile = xTile + 1

			_RenderTile(_TileGetSprite(map, xTile, topTileBegin), xPos, 0, 0, clipTop, 0, 0)
			_RenderTile(_TileGetSprite(map, xTile, bottomTileBegin), xPos, bottomBegin, 0, 0, 0, clipBottom)
		Next

		For yPos As Integer = yShift To bottomBegin Step Settings.SPRITE_SIZE
			yTile = yTile + 1

			_RenderTile(_TileGetSprite(map, leftTileBegin, yTile), 0, yPos, clipLeft, 0, 0, 0)
			_RenderTile(_TileGetSprite(map, rightTileBegin, yTile), rightBegin, yPos, 0, 0, clipRight, 0)
		Next

		xTile = leftTileBegin
		yTile = topTileBegin

		For yPos As Integer = yShift To bottomBegin Step Settings.SPRITE_SIZE
			yTile = yTile + 1

			xTile = xTileShift

			For xPos As Integer = xShift To rightBegin Step Settings.SPRITE_SIZE
				xTile = xTile + 1

				_RenderTile(_TileGetSprite(map, xTile, yTile), xPos, yPos, 0, 0, 0, 0)
			Next
		Next
	End Sub
End Class
