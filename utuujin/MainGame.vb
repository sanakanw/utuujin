
Public Class MainGame
	Public Enum GameEvent
		LOAD_GAME_MAIN
		LOAD_GAME_COLOR
	End Enum
	
	Private m_deltaTime As Double
	Private m_previousTime As Long

	Private m_tickCount As Integer
	Private m_frameCount As Integer

	Private m_gameScreenGraphics As Graphics

	Private m_userInput As UserInput
	Private m_gameState As GameState
	Private m_renderState As RenderState
	Private m_video As Video

	Private m_stopwatch As Stopwatch
	
	Private m_transitionTick As Integer
	
	Private Sub _ScreenSwap()
		m_gameScreenGraphics.DrawImage(
			m_video.Image_Buffer,
			0,
			0,
			m_gameScreen.Width,
			m_gameScreen.Height)
	End Sub

	Private Sub _MainFrame()
		Dim elapsedTime As Double = m_stopwatch.ElapsedMilliseconds - m_previousTime
		m_previousTime = m_stopwatch.ElapsedMilliseconds

		m_deltaTime = m_deltaTime + elapsedTime / 1000.0

		While m_deltaTime >= 0.0
			m_deltaTime = m_deltaTime - Settings.SECONDS_PER_TICK
			
			m_gameState.Frame(m_tickCount, m_userInput)

			m_tickCount = m_tickCount + 1
		End While

		m_renderState.Render_Map(m_gameState.Map, m_gameState.xView, m_gameState.yView)
		m_renderState.Render_Entities(m_gameState.Entities, m_gameState.xView, m_gameState.yView)
		m_renderState.Render_Floating_Tiles(m_gameState.FloatingTiles, m_gameState.xView, m_gameState.yView)

		m_video.Update()
		_ScreenSwap()
	End Sub

	Private Sub MainGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		m_gameScreenGraphics = m_gameScreen.CreateGraphics()
		m_gameScreenGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
		m_gameScreenGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor

		m_stopwatch = New Stopwatch()

		m_video = New Video(Settings.VIDEO_WIDTH, Settings.VIDEO_HEIGHT)
		m_renderState = New RenderState(m_video)

		m_gameState = New GameState()
		m_userInput = New UserInput()

		m_stopwatch.Start()

		m_previousTime = m_stopwatch.ElapsedMilliseconds
	End Sub
	
	Public Sub PostEvent(gameEvent As GameEvent)
		Select Case gameEvent
			Case GameEvent.LOAD_GAME_COLOR
				m_transitionTick = 255
				m_gameState.LoadLevel(GameLevel.LEVEL_MALL)
				' Form1.Show()
				' Me.Hide()
			Case GameEvent.LOAD_GAME_MAIN
				m_transitionTick = 255
				Me.Show()
				Form1.Hide()
		End Select
	End Sub

	Private Sub m_gameLoop_Tick(sender As Object, e As EventArgs) Handles m_gameLoop.Tick
		Dim t1, t2 As Double

		t1 = m_stopwatch.ElapsedMilliseconds
		_MainFrame()
		t2 = m_stopwatch.ElapsedMilliseconds

		Console.WriteLine(t2 - t1)
	End Sub

	Private Sub m_mainGame_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
		m_userInput.KeyDown(e.KeyCode)
	End Sub

	Private Sub m_mainGame_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
		m_userInput.KeyUp(e.KeyCode)
	End Sub
End Class
