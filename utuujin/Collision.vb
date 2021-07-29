Public Class Collision
	Public Interface ICollisionState
		ReadOnly Property isCollide As Boolean
		ReadOnly Property entityCollide As Entity
	End Interface
	
	Private Class _CollisionState
		Implements ICollisionState
		
		Private m_isCollide As Boolean
		Private m_entityCollide As Entity
		
		ReadOnly Property isCollide As Boolean Implements ICollisionState.isCollide
			Get
				Return m_isCollide
			End Get
		End Property
		
		ReadOnly Property entityCollide As Entity Implements ICollisionState.entityCollide
			Get
				Return m_entityCollide
			End Get
		End Property
		
		Public Sub State_Update(isCollide As Boolean, entityCollide As Entity)
			m_isCollide = isCollide
			m_entitycollide = entityCollide
		End Sub
	End Class
	
	Private Structure _DynamicObject
		Public entity As Entity
		Public boxWidth As Single
		Public boxHeight As Single
		Public collisionState As _CollisionState
	End Structure
	
	Private Structure _StaticObject
		Public entity As Entity
		Public boxWidth As Single
		Public boxHeight As Single
	End Structure
	
	Private Structure _CollisionData
		Public xNormal As Single
		Public yNormal As Single
		
		Public depth As Single
	End Structure
	
	Private m_dynamicObjects As List(Of _DynamicObject)
	Private m_staticObjects As List(Of _StaticObject)
	
	Private m_map As TileMap
	
	Public Sub New(map As TileMap)
		m_map = map
		m_staticObjects = New List(Of _StaticObject)
		m_dynamicObjects = New List(Of _DynamicObject)
	End Sub
	
	Private Function _Test_AABB(
		xPos0 As Single, yPos0 As Single, boxWidth0 As Single, boxHeight0 As Single,
		xPos1 As Single, yPos1 As Single, boxWidth1 As Single, boxHeight1 As Single) As _CollisionData
		
		Dim sideDist(4) As Single
		
		sideDist(0) = xPos1 - (xPos0 + boxWidth0)
		sideDist(1) = -yPos1 + (yPos0 - boxHeight0)
		sidedist(2) = xPos0 - (xPos1 + boxWidth1)
		sideDist(3) = -yPos0 + (yPos1 - boxHeight1)
		
		Dim depth As Single = -128
		Dim normalIndex As Integer
		
		Dim normalTable(,) As Integer = {
			{ -1, +0 },
			{ +0, +1 },
			{ +1, +0 },
			{ +0, -1 }
		}
		
		For i As Integer = 0 To 3
			If sideDist(i) > 0 Then
				Return New _CollisionData With { .xNormal = 0, .yNormal = 0, .depth = 0 }
			End If
			
			if sideDist(i) > depth Then
				normalIndex = i
				depth = sideDist(i)
			End If
		Next
		
		Return New _CollisionData With { .xNormal = normalTable(normalIndex, 0), .yNormal = normalTable(normalIndex, 1), .depth = -depth }
	End Function
	
	Private Function _Test_Map(xPos As Single, yPos As Single, boxWidth As Single, boxHeight As Single) As _CollisionData
		Dim hitCheck(4) As Tile
		
		Dim depth As Single = 0
		Dim xNormal As Single
		Dim yNormal As Single
		
		For y As Integer = 0 To 1
			For x As Integer = 0 To 1
				Dim xCheck As Single = xPos + x * boxWidth
				Dim yCheck As Single = yPos - y * boxHeight
				
				Dim xMap As Integer = Math.Floor(xCheck)
				Dim yMap As Integer = Math.Floor(yCheck)
				
				If TileDatabase.Lookup(m_map.Get_Tile(xMap, yMap)).solid Then
					Dim xCorner As Single = Math.Round(xCheck)
					Dim yCorner As Single = Math.Round(yCheck)
					
					Dim xDist As Single = xCheck - xCorner
					Dim yDist As Single = yCheck - yCorner
					
					Dim xDepth As Single = Math.Abs(xDist)
					Dim yDepth As Single = Math.Abs(yDist)
					
					If xDepth < yDepth Then
						xNormal = -(xDist < 0) * 2 - 1
						If xDepth > depth Then
							depth = xDepth
						End If
					Else
						yNormal = -(yDist < 0) * 2 - 1
						If yDepth > depth Then
							depth = yDepth
						End If
					End If
				End If
			Next
		Next
		
		If depth = 128 Then
			depth = 0
		End If
		
		Return New _CollisionData With { .xNormal = xNormal, .yNormal = yNormal, .depth = depth + 0.05 }
	End Function
	
	Private Sub _Resolve_Static(dynamicObject As _DynamicObject)
		dynamicObject.collisionState.State_Update(False, Nothing)
		
		For i As Integer = 0 To m_staticObjects.Count - 1
			Dim staticObject As _StaticObject = m_staticObjects(i)
			
			Dim collisionData As _CollisionData
			collisionData = _Test_AABB(
				dynamicObject.entity.xPos,
				dynamicObject.entity.yPos,
				dynamicObject.boxWidth,
				dynamicObject.boxHeight,
				staticObject.entity.xPos,
				staticObject.entity.yPos,
				staticObject.boxWidth,
				staticObject.boxHeight)
			
			If collisionData.depth > 0 Then
				dynamicObject.collisionState.State_Update(True, staticObject.entity)
				dynamicObject.entity.xPos = dynamicObject.entity.xPos + collisionData.Depth * collisionData.xNormal
				dynamicObject.entity.yPos = dynamicObject.entity.yPos + collisionData.Depth * collisionData.yNormal
			End If
		Next
	End Sub
	
	Private Sub _Resolve_Map(dynamicObject As _DynamicObject)
		Dim collisionData As _CollisionData
		collisionData = _Test_Map(
			dynamicObject.entity.xPos,
			dynamicObject.entity.yPos,
			dynamicObject.boxWidth,
			dynamicObject.boxHeight
		)
		
		If collisionData.depth > 0 Then
			dynamicObject.entity.xPos = dynamicObject.entity.xPos + collisionData.Depth * collisionData.xNormal
			dynamicObject.entity.yPos = dynamicObject.entity.yPos + collisionData.Depth * collisionData.yNormal
		End If
	End Sub
	
	Public Sub Add_Static_Object(entity As Entity, boxWidth As Single, boxHeight As Single)
		m_staticObjects.Add(New _StaticObject With {
			.entity = entity,
			.boxWidth = boxWidth,
			.boxHeight = boxHeight})
	End Sub
	
	Public Function Add_Dynamic_Object(entity As Entity, boxWidth As Single, boxHeight As Single) As ICollisionState
		Dim dynamicObject As _DynamicObject
		dynamicObject = New _DynamicObject With {
			.entity = entity,
			.boxWidth = boxWidth,
			.boxHeight = boxHeight,
			.collisionState = New _CollisionState()
		}
		
		m_dynamicObjects.Add(dynamicObject)
		
		Return dynamicObject.collisionState
	End Function
	
	Public Sub Resolve()
		For i As Integer = 0 To m_dynamicObjects.Count - 1
			_Resolve_Map(m_dynamicObjects(i))
			_Resolve_Static(m_dynamicObjects(i))
		Next
	End Sub
End Class
