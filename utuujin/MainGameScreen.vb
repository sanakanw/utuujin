Public Class MainGameScreen

	Private m_video As Video
	Private m_renderState As RenderState

	Private m_graphics As Graphics

	Public ReadOnly Property renderState As RenderState
		Get
			Return m_renderState
		End Get
	End Property

	Private Sub MainGameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		m_graphics = panelGameScreen.CreateGraphics()
		m_graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
		m_graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor

		m_video = New Video(Settings.VIDEO_WIDTH, Settings.VIDEO_HEIGHT)
		m_renderState = New RenderState(m_video)
	End Sub
	Private Sub _SwapBuffer()
		m_graphics.DrawImage(
			m_video.ImageBuffer,
			0,
			0,
			panelGameScreen.Width + 1,
			panelGameScreen.Height + 1)
	End Sub

	Public Sub Render(gameState As GameState)
		m_renderState.RenderMap(gameState.Map, gameState.xView, gameState.yView)
		m_renderState.RenderEntities(gameState.Entities, gameState.xView, gameState.yView)
		m_renderState.RenderFloatingTiles(gameState.FloatingTiles, gameState.xView, gameState.yView)

		m_video.Update()

		_SwapBuffer()
	End Sub

	Public Sub RenderEndingScene()
		m_renderState.RenderEndingScene()

		m_video.Update()

		_SwapBuffer()
	End Sub
End Class
