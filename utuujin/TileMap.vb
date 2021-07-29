Public Class TileMap
	Dim m_width As Integer
	Dim m_height As Integer

	Dim m_mapData(Settings.MAX_MAP_SIZE) As Tile

	Public ReadOnly Property Width
		Get
			return m_width
		End Get
	End Property
	
	Public ReadOnly Property Height
		Get
			return m_height
		End Get
	End Property

	Public ReadOnly Property Get_Tile(xTileCoord As Integer, yTileCoord As Integer) As Tile
		Get
			Return m_mapData(xTileCoord + yTileCoord * m_width)
		End Get
	End Property

	Public Sub Put_Tile(tile As Tile, xTileCoord As Integer, yTileCoord As Integer)
		m_mapData(xTileCoord + yTileCoord * m_width) = tile
	End Sub

	Public Sub Init(width As Integer, height As Integer)
		m_width = width
		m_height = height

		For i As Integer = 0 To m_width * m_height - 1
			m_mapData(i) = Tile.TILE_GRASS
		Next
	End Sub
End Class
