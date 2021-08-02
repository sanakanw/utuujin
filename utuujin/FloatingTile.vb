Public Enum FloatingTileType
	FLOATING_TILE_NONE
	FLOATING_TILE_VOID
	FLOATING_TILE_HALF_VOID
	FLOATING_TILE_SHOP_0
	FLOATING_TILE_SHOP_1
End Enum

Public Structure FloatingTile
	Public xPos As Single
	Public yPos As Single
	Public tileType As FloatingTileType
End Structure

Public Class FloatingTileDatabase
	Private Shared m_floatingTileSprites() As SpriteDef = {
		New SpriteDef With { .xTexCoord = 00, .yTexCoord = 00, .texWidth = 01, .texHeight = 01 }, ' FLOATING_TILE_NONE
		New SpriteDef With { .xTexCoord = 07, .yTexCoord = 01, .texWidth = 01, .texHeight = 01 }, ' FLOATING_TILE_VOID
		New SpriteDef With { .xTexCoord = 08, .yTexCoord = 00, .texWidth = 01, .texHeight = 01 }, ' FLOATING_TILE_HALF_VOID
		New SpriteDef With { .xTexCoord = 06, .yTexCoord = 02, .texWidth = 01, .texHeight = 01 }, ' FLOATING_TILE_SHOP_0
		New SpriteDef With { .xTexCoord = 11, .yTexCoord = 00, .texWidth = 01, .texHeight = 01 }, ' FLOATING_TILE_SHOP_1
		New SpriteDef With { .xTexCoord = 04, .yTexCoord = 12, .texWidth = 01, .texHeight = 01 }, ' FLOATING_TILE_SEWER_WALL
		New SpriteDef With { .xTexCoord = 04, .yTexCoord = 14, .texWidth = 01, .texHeight = 01 }, ' FLOATING_TILE_MALL_4
		New SpriteDef With { .xTexCoord = 05, .yTexCoord = 14, .texWidth = 01, .texHeight = 01 }, ' FLOATING_TILE_MALL_5
		New SpriteDef With { .xTexCoord = 06, .yTexCoord = 14, .texWidth = 01, .texHeight = 01 }  ' FLOATING_TILE_MALL_6
	}
	
	Public Shared ReadOnly Property Size
		Get
			Return m_floatingTileSprites.Length
		End Get
	End Property
	
	Public Shared ReadOnly Property Lookup(key As Tile)
		Get
			Return m_floatingTileSprites(key)
		End get
	End Property
End Class
