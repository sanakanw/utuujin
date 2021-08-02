Public Class GameState
	Private m_levelData()() As Byte = {
		My.Resources.map_park1,
		My.Resources.map_park2,
		My.Resources.map_climbing_top,
		My.Resources.map_sewers1,
		My.Resources.map_streets1,
		My.Resources.map_mall1,
		My.Resources.map_mall2,
		My.Resources.map_mall3,
		My.Resources.map_book_store,
		My.Resources.lvl_shop
	}

	Private m_map As TileMap
	Private m_entities As List(Of Entity)
	Private m_floatingTiles As List(Of FloatingTile)

	Private m_player As Player
	Private m_manhole As Entity
	
	Private m_currentLevel As GameLevel

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

	Public Property Player As Player
		Get
			Return m_player
		End Get
	  Set(value As Player)
			m_player = value
	  End Set
	End Property

	Public Sub New()
		m_map = New TileMap()
		m_entities = New List(Of Entity)
		m_floatingTiles = New List(Of FloatingTile)
		
		m_collision = New Collision(m_map)
		
		' LoadLevel(GameLevel.LEVEL_MALL2)
	End Sub

	Public Sub OpenManhole()
		m_manhole.state = EntityState.ENTITY_MANHOLE_OPEN
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
		m_collision = New Collision(m_map)
		m_floatingTiles = New List(Of FloatingTile)

		Dim entityCount As Integer = levelLoader.ReadEntityCount()
		For i As Integer = 0 To entityCount - 1
			Dim entity As Entity = levelLoader.ReadEntity()

			Select Case entity.state
				Case EntityState.ENTITY_PLAYER_FORWARD
					m_player = New Player(entity, m_collision.AddDynamicObject(entity, 0.8, 0.5))
				Case EntityState.ENTITY_MANHOLE
					m_manhole = entity
					m_collision.AddStaticObject(entity, 1.8, 0.6)
				Case EntityState.ENTITY_SLIDE
					m_collision.AddStaticObject(entity, 4.2, 0.7)
				Case EntityState.ENTITY_BOARD
					m_collision.AddStaticObject(entity, 2.0, 0.5)
				Case EntityState.ENTITY_MAGIC_SQUARE
					m_collision.AddStaticObject(entity, 2.0, 0.5)
				Case EntityState.ENTITY_TREE
					m_collision.AddStaticObject(entity, 0.7, 0.5)
				Case EntityState.ENTITY_TREE_BUNDLE
					m_collision.AddStaticObject(entity, 2.0, 0.7)
				Case EntityState.ENTITY_ROAD_BLOCK
					m_collision.AddStaticObject(entity, 2.0, 3.0)
				Case EntityState.ENTITY_LAMP
					m_collision.AddStaticObject(entity, 0.5, 0.5)
				Case EntityState.ENTITY_BUS_STOP
					m_collision.AddStaticObject(entity, 0.5, 0.5)
				Case EntityState.ENTITY_BENCH
					m_collision.AddStaticObject(entity, 2, 0.5)
				Case EntityState.ENTITY_BIN
					m_collision.AddStaticObject(entity, 0.8, 0.8)
				Case EntityState.ENTITY_BOOK_GAME
					m_collision.AddStaticObject(entity, 2, 0.4)
				Case EntityState.ENTITY_BOOK_SHELF_0
					m_collision.AddStaticObject(entity, 2, 0.8)
				Case EntityState.ENTITY_BOOK_SHELF_1
					m_collision.AddStaticObject(entity, 1, 0.8)
			End Select
			
			m_entities.Add(entity)
		Next

		Dim floatingTileCount As Integer = levelLoader.ReadFloatingTileCount()
		For i As Integer = 0 To floatingTileCount - 1
			m_floatingTiles.Add(levelLoader.ReadFloatingTile())
		Next

		Dim loadTriggerCount As Integer = levelLoader.ReadLoadTriggerCount()
		For i As Integer = 0 To loadTriggerCount - 1
			m_collision.AddLoadTrigger(levelLoader.ReadLoadTrigger())
		Next
		
		m_currentLevel = level
	End Sub

	Public Sub Frame(currentTick As Integer, userInput As UserInput)
		m_player.Move(currentTick, userInput)
		m_collision.Resolve()

		Dim viewWidth As Single = Settings.FIELD_OF_VIEW / 2
		Dim viewHeight As Single = Settings.FIELD_OF_VIEW * 3 / 8
		
		Select Case m_currentLevel 
			Case GameLevel.LEVEL_CLIMBING_TOP, GameLevel.LEVEL_BOOK_STORE
				xView = 0
				yView = 0
			Case Else
				Dim xOffset As Single = Math.Max(m_player.baseEntity.xPos - viewWidth, 0)
				Dim yOffset As Single = Math.Max(m_player.baseEntity.yPos - viewHeight - 2, 0)
				
				xView = Math.Min(xOffset, m_map.Width - 2 * viewWidth - 1)
				yView = Math.Min(yOffset, m_map.Height - 2 * viewHeight - 1)
		End Select
		
	End Sub
End Class
