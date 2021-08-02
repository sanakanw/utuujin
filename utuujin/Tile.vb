Public Enum Tile
	TILE_NONE      
	TILE_GRASS
	TILE_SAND
	TILE_SAND_BOX_0
	TILE_SAND_BOX_1
	TILE_SAND_BOX_2
	TILE_SAND_BOX_3
	TILE_SAND_BOX_4
	TILE_SAND_BOX_5
	TILE_SAND_BOX_6
	TILE_SAND_BOX_7
	TILE_CHECKER
	TILE_VOID
	TILE_SHOP_0
	TILE_SHOP_1
	TILE_SHOP_2
	TILE_SHOP_3
	TILE_SHOP_4
	TILE_SHOP_5
	TILE_SHOP_6
	TILE_SHOP_7
	TILE_SHOP_8
	TILE_SHOP_9
	TILE_SHOP_10
	TILE_SHOP_11
	TILE_SHOP_12   
	TILE_SEWER_LADDER_0
	TILE_SEWER_LADDER_2
	TILE_SEWER_WALL
	TILE_SEWER_WATER
	TILE_SEWER_FLOOR_0
	TILE_SEWER_FLOOR_1
	TILE_SEWER_BRIDGE_0
	TILE_SEWER_BRIDGE_1
	TILE_SEWER_BRIDGE_2
	TILE_SEWER_BRIDGE_3
	TILE_SEWER_BRIDGE_4
	TILE_SEWER_BRIDGE_5
	TILE_SEWER_BRIDGE_6
	TILE_MALL_0
	TILE_MALL_1
	TILE_MALL_2
	TILE_MALL_3
	TILE_MALL_4
	TILE_MALL_5
	TILE_MALL_6
	TILE_MALL_7
	TILE_MALL_8
	TILE_MALL_9
	TILE_MALL_10
	TILE_MALL_11
	TILE_MALL_12
	TILE_MALL_13
	TILE_MALL_14
	TILE_MALL_15
	TILE_MALL_16
	TILE_MALL_17
	TILE_MALL_18
	TILE_MALL_19
End Enum

Public Structure TileData
	Dim solid As Boolean
	Dim spriteDef As SpriteDef
End Structure

Public Class TileDatabase
	Private Shared m_tileData() As TileData = {
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 00, .yTexCoord = 00, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_NONE      
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 01, .yTexCoord = 00, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_GRASS
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 01, .yTexCoord = 01, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 02, .yTexCoord = 00, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_BOX_0
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 03, .yTexCoord = 00, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_BOX_1
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 04, .yTexCoord = 00, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_BOX_2
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 05, .yTexCoord = 00, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_BOX_3
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 02, .yTexCoord = 01, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_BOX_4
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 03, .yTexCoord = 01, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_BOX_5
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 04, .yTexCoord = 01, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_BOX_6
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 05, .yTexCoord = 01, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_BOX_7
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 06, .yTexCoord = 00, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_CHECKER
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 07, .yTexCoord = 00, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_VOID
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 06, .yTexCoord = 03, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_SHOP_0
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 07, .yTexCoord = 02, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_SHOP_1
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 08, .yTexCoord = 02, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_SHOP_2
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 09, .yTexCoord = 02, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_SHOP_3
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 07, .yTexCoord = 03, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_SHOP_4
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 08, .yTexCoord = 03, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_SHOP_5
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 09, .yTexCoord = 03, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_SHOP_6
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 10, .yTexCoord = 03, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SHOP_7
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 11, .yTexCoord = 03, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_SHOP_8
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 10, .yTexCoord = 02, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_SHOP_9
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 11, .yTexCoord = 02, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SHOP_10
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 10, .yTexCoord = 01, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SHOP_11
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 11, .yTexCoord = 01, .texWidth = 1, .texheight = 1}, .solid = True  },  ' TILE_SHOP_12  
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 08, .yTexCoord = 04, .texWidth = 1, .texheight = 1}, .solid = False },   ' TILE_SAND_PATH_0
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 08, .yTexCoord = 05, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_PATH_1
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 08, .yTexCoord = 06, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_PATH_2
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 09, .yTexCoord = 06, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_PATH_3
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 10, .yTexCoord = 06, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_PATH_4
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 10, .yTexCoord = 05, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_PATH_5
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 09, .yTexCoord = 04, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_PATH_6
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 10, .yTexCoord = 04, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_SAND_PATH_7
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 11, .yTexCoord = 04, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_TREE_BORDER_0
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 12, .yTexCoord = 04, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_1
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 13, .yTexCoord = 04, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_2
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 11, .yTexCoord = 05, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_3
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 13, .yTexCoord = 05, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_4
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 11, .yTexCoord = 06, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_5
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 12, .yTexCoord = 06, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_6
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 13, .yTexCoord = 06, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_7
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 08, .yTexCoord = 07, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_8
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 09, .yTexCoord = 07, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_9
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 10, .yTexCoord = 07, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_10
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 08, .yTexCoord = 08, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_11
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 10, .yTexCoord = 08, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_13
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 08, .yTexCoord = 09, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_14
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 09, .yTexCoord = 09, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_15
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 10, .yTexCoord = 09, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_TREE_BORDER_16
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 03, .yTexCoord = 08, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_ROAD_0
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 04, .yTexCoord = 08, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_ROAD_1
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 03, .yTexCoord = 09, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_ROAD_2
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 04, .yTexCoord = 09, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_ROAD_3
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 06, .yTexCoord = 04, .texWidth = 1, .texheight = 1}, .solid = False }, ' TILE_INVISIBLE
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 07, .yTexCoord = 04, .texWidth = 1, .texheight = 1}, .solid = True  }, ' TILE_INVISIBLE_SOLID
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 03, .yTexCoord = 11, .texWidth = 1, .texHeight = 1}, .solid = False }, ' TILE_SEWER_LADDER_0
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 03, .yTexCoord = 12, .texWidth = 1, .texHeight = 1}, .solid = False }, ' TILE_SEWER_LADDER_1
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 03, .yTexCoord = 13, .texWidth = 1, .texHeight = 1}, .solid = True  }, ' TILE_SEWER_WALL
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 06, .yTexCoord = 12, .texWidth = 1, .texHeight = 1}, .solid = True  }, ' TILE_SEWER_WATER
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 05, .yTexCoord = 12, .texWidth = 1, .texHeight = 1}, .solid = False }, ' TILE_SEWER_FLOOR
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 04, .yTexCoord = 13, .texWidth = 1, .texHeight = 1}, .solid = True  }, ' TILE_SEWER_BRIDGE_0
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 05, .yTexCoord = 13, .texWidth = 1, .texHeight = 1}, .solid = False }, ' TILE_SEWER_BRIDGE_1
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 06, .yTexCoord = 13, .texWidth = 1, .texHeight = 1}, .solid = False }, ' TILE_SEWER_BRIDGE_2
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 07, .yTexCoord = 13, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_SEWER_BRIDGE_3
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 00, .yTexCoord = 14, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_0
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 01, .yTexCoord = 14, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_1
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 02, .yTexCoord = 14, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_2
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 03, .yTexCoord = 14, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_3
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 07, .yTexCoord = 14, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_4
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 00, .yTexCoord = 15, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_5
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 01, .yTexCoord = 15, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_6
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 02, .yTexCoord = 15, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_7
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 03, .yTexCoord = 15, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_8
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 04, .yTexCoord = 15, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_9
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 05, .yTexCoord = 15, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_10
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 06, .yTexCoord = 15, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_11
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 07, .yTexCoord = 15, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_12
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 00, .yTexCoord = 16, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_13
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 01, .yTexCoord = 16, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_14
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 02, .yTexCoord = 16, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_15
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 03, .yTexCoord = 16, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_16
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 04, .yTexCoord = 16, .texWidth = 1, .texHeight = 1}, .solid = True  },  ' TILE_MALL_17
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 04, .yTexCoord = 17, .texWidth = 1, .texHeight = 1}, .solid = False },  ' TILE_MALL_18
		New TileData With { .spriteDef = New SpriteDef With {.xTexCoord = 05, .yTexCoord = 16, .texWidth = 1, .texHeight = 1}, .solid = True  }  ' TILE_MALL_19
	}

	Public Shared ReadOnly Property Size
		Get
			Return m_tileData.Length
		End Get
	End Property
	
	Public Shared ReadOnly Property Lookup(key As Tile)
		Get
			Return m_tileData(key)
		End Get
	End Property
End Class
