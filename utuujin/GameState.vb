Public Class GameState
	Private m_levelData()() As Byte = {
		My.Resources.lvl_park,
		My.Resources.lvl_shop
	}

	Private m_map As TileMap
	Private m_entities As List(Of Entity)
	Private m_floatingTiles As List(Of FloatingTile)

	Private m_player As Player
	Private m_collision As Collision

	Public xView As Single = 0
	Public yView As Single = 0

	Public ReadOnly Property Map
		Get
			Return m_map
		End Get
	End Property
	
	Public ReadOnly Property Entities
		Get
			Return m_entities
		End Get
	End Property
	
	Public ReadOnly Property FloatingTiles
		Get
			Return m_floatingTiles
		End Get
	End Property

	Public Sub New()
		m_map = New TileMap()
		m_entities = New List(Of Entity)
		m_floatingTiles = New List(Of FloatingTile)
		
		m_collision = New Collision(m_map)

		LoadLevel(GameLevel.LEVEL_PARK)
	End Sub
	
	Public Sub LoadLevel(level As GameLevel)
		Dim levelLoader As LevelLoader = New LevelLoader(m_levelData(level))

		Dim mapWidth As Integer = levelLoader.ReadMapWidth()
		Dim mapHeight As Integer = levelLoader.ReadMapHeight()

		m_map.Init(mapWidth, mapHeight)

		For y As Integer = 0 To mapHeight - 1
			For x As Integer = 0 To mapWidth - 1
				m_map.PutTile(levelLoader.Read_Map_Tile(), x, y)
			Next
		Next

		m_entities = New List(Of Entity)

		Dim entityCount As Integer = levelLoader.ReadEntityCount()

		For i As Integer = 0 To entityCount - 1
			Dim entity As Entity = levelLoader.ReadEntity()

			Select Case entity.State
				Case Entity.EntityState.ENTITY_PLAYER_FORWARD
					m_player = New Player(entity, m_collision.AddDynamicObject(entity, 0.8, 0.5))
				Case Entity.EntityState.ENTITY_SLIDE
					m_collision.AddStaticObject(entity, 4.2, 0.7)
				Case Entity.EntityState.ENTITY_BOARD
					m_collision.AddStaticObject(entity, 2.0, 0.5)
				Case Entity.EntityState.ENTITY_MAGIC_SQUARE
					m_collision.AddStaticObject(entity, 2.0, 0.5)
			End Select
			
			m_entities.Add(entity)
		Next

		Dim floatingTileCount As Integer = levelLoader.ReadFloatingTileCount()

		For i As Integer = 0 To floatingTileCount - 1
			Dim floatingTile As FloatingTile = levelLoader.ReadFloatingTile()

			m_floatingTiles.Add(floatingTile)
		Next
	End Sub

	Public Sub Frame(currentTick As Integer, userInput As UserInput)
		m_player.Move(currentTick, userInput)
		m_collision.Resolve()

		xView = Math.Min(Math.Max(m_player.baseEntity.xPos - Settings.FIELD_OF_VIEW / 2, 0), m_map.Width)
		yView = Math.Min(Math.Max(m_player.baseEntity.yPos - Settings.FIELD_OF_VIEW * 3 / 8 - 2, 0), m_map.Height)
	End Sub
End Class
