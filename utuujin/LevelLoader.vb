Public Class LevelLoader
	Private m_levelData() As Integer
	Private m_filePointer As Integer

	Public ReadOnly Property ReadMapWidth As Integer
		Get
			Dim width As Integer = m_levelData(m_filePointer)
			m_filePointer = m_filePointer + 1

			Return width
		End Get
	End Property

	Public ReadOnly Property ReadMapHeight As Integer
		Get
			Dim height As Integer = m_levelData(m_filePointer)
			m_filePointer = m_filePointer + 1

			Return height
		End Get
	End Property

	Public ReadOnly Property Read_Map_Tile As Integer
		Get
			Dim tile As Tile = m_levelData(m_filePointer)
			m_filePointer = m_filePointer + 1

			Return tile
		End Get
	End Property

	Public ReadOnly Property ReadEntityCount As Integer
		Get
			Dim entityCount As Integer = m_levelData(m_filePointer)
			m_filePointer = m_filePointer + 1

			Return entityCount
		End Get
	End Property

	Public ReadOnly Property ReadEntity As Entity
		Get
			Dim entityState As EntityState = m_levelData(m_filePointer)
			Dim xPos As Single = m_levelData(m_filePointer + 1)
			Dim yPos As Single = m_levelData(m_filePointer + 2)

			m_filePointer = m_filePointer + 3

			Return New Entity(entityState, xPos, yPos)
		End Get
	End Property

	Public ReadOnly Property ReadFloatingTileCount As Integer
		Get
			Dim floatingTileCount As Integer = m_levelData(m_filePointer)
			m_filePointer = m_filePointer + 1

			Return floatingTileCount
		End Get
	End Property

	Public ReadOnly Property ReadFloatingTile As FloatingTile
		Get
			Dim floatingTileType As FloatingTileType = m_levelData(m_filePointer)
			Dim xPos As Single = m_levelData(m_filePointer + 1)
			Dim yPos As Single = m_levelData(m_filePointer + 2)

			m_filePointer = m_filePointer + 3

			Return New FloatingTile With {.tileType = floatingTileType, .xPos = xPos - 1, .yPos = yPos - 1}
		End Get
	End Property

	Public ReadOnly Property ReadLoadTriggerCount As Integer
		Get
			Dim entityCount As Integer = m_levelData(m_filePointer)
			m_filePointer = m_filePointer + 1

			Return entityCount
		End Get
	End Property

	Public ReadOnly Property ReadLoadTrigger As LoadTrigger
		Get
			Dim level As GameLevel = m_levelData(m_filePointer)
			Dim xPos As Single = m_levelData(m_filePointer + 1)
			Dim yPos As Single = m_levelData(m_filePointer + 2)
			Dim width As Single = m_levelData(m_filePointer + 3)
			Dim height As Single = m_levelData(m_filePointer + 4)

			m_filePointer = m_filePointer + 5

			Return New LoadTrigger(level, xPos, yPos, width, height)
		End Get
	End Property

	Public Sub New(fileData() As Byte)
		Dim levelData() As String
		levelData = System.Text.Encoding.ASCII.GetString(fileData).Split(" "c)

		ReDim m_levelData(levelData.Length)

		For i As Integer = 0 To levelData.Length - 1
			If levelData(i).Trim().Length > 0 Then
				m_levelData(i) = Convert.ToInt32(levelData(i))
			End If
		Next

		m_filePointer = 0
	End Sub
End Class
