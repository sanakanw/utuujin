
Public Class MainGame
	Private Const MAX_SCREEN = 4

	Private m_deltaTime As Double
	Private m_previousTime As Long
	Private m_tickCount As Integer

	Private m_userInput As UserInput
	Private m_gameState As GameState
	Private m_currentScreen As UserControl

	Public EventFlag(128) As Boolean

	Private m_stopwatch As Stopwatch

	Private Sub MainGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		m_stopwatch = New Stopwatch()

		m_userInput = New UserInput()
		m_gameState = New GameState()

		m_stopwatch.Start()

		m_previousTime = m_stopwatch.ElapsedMilliseconds

		GameSoundPlayer.PlayBgm(GameBgm.BGM_REALITY)

		PostEvent(GameEvent.LOAD_LEVEL_MALL_2)
	End Sub

	Public Sub PostEvent(gameEvent As GameEvent)
		Select Case gameEvent
			Case GameEvent.LOAD_GAME_CLIMBING
				_SwitchScreen(climbingGameScreen)
			Case GameEvent.LOAD_GAME_COLOR
				_SwitchScreen(colorGameScreen)
			Case GameEvent.LOAD_GAME_REGISTER
				_SwitchScreen(cashRegisterScreen)
			Case GameEvent.LOAD_GAME_WORD_CONNECT
				_SwitchScreen(wordGameScreen)
			Case GameEvent.LOAD_GAME_CIPHER
				_SwitchScreen(cipherGameScreen)
			Case GameEvent.LOAD_GAME_MAGIC_SQUARE
				_SwitchScreen(magicSquareScreen)
			Case GameEvent.LOAD_GAME_MAIN
				_LoadGameMain()
			Case GameEvent.LOAD_LEVEL_PARK_1
				mainGameScreen.renderState.SetOpacity(250)
				m_gameState.LoadLevel(GameLevel.LEVEL_PARK1)
			Case GameEvent.LOAD_LEVEL_PARK_2
				mainGameScreen.renderState.SetOpacity(250)
				mainGameScreen.renderState.SetBackground(RenderStateBackground.BG_CLIMBING_GAME_TOP)
				m_gameState.LoadLevel(GameLevel.LEVEL_PARK2)
			Case GameEvent.EVENT_CLIMBING_GAME_COMPLETE
				_LoadGameMain()
				m_gameState.LoadLevel(GameLevel.LEVEL_CLIMBING_TOP)
			Case GameEvent.EVENT_SLIDE_COMPLETE
				EventFlag(GameEvent.EVENT_SLIDE_COMPLETE) = True

				GameSoundPlayer.Play(GameSound.SOUND_BUTTON_CLICK)
				
				mainGameScreen.renderState.SetBackground(RenderStateBackground.BG_CLIMBING_GAME_TOP)
				m_gameState.LoadLevel(GameLevel.LEVEL_PARK2)
				m_gameState.Player.baseEntity.xPos = 9
				m_gameState.Player.baseEntity.yPos = 18
				
				If EventFlag(GameEvent.EVENT_MAGIC_SQUARE_COMPLETE) = True Then
					m_gameState.OpenManhole()
				End If
			Case GameEvent.EVENT_MAGIC_SQUARE_COMPLETE
				EventFlag(GameEvent.EVENT_MAGIC_SQUARE_COMPLETE) = True

				_LoadGameMain()
				GameSoundPlayer.Play(GameSound.SOUND_BUTTON_CLICK)

				If EventFlag(GameEvent.EVENT_SLIDE_COMPLETE) = True Then
					m_gameState.OpenManhole()
				End If
			Case GameEvent.LOAD_LEVEL_SEWERS_1
				mainGameScreen.renderState.SetOpacity(100)
				m_gameState.LoadLevel(GameLevel.LEVEL_SEWERS1)
			Case GameEvent.LOAD_LEVEL_STREETS_1
				mainGameScreen.renderState.SetOpacity(200)
				m_gameState.LoadLevel(GameLevel.LEVEL_STREETS1)
			Case GameEvent.LOAD_LEVEL_MALL_1
				mainGameScreen.renderState.SetOpacity(150)
				m_gameState.LoadLevel(GameLevel.LEVEL_MALL1)
			Case GameEvent.LOAD_LEVEL_MALL_2
				mainGameScreen.renderState.SetOpacity(100)
				m_gameState.LoadLevel(GameLevel.LEVEL_MALL2)
			Case GameEvent.LOAD_LEVEL_MALL_3
				m_gameState.LoadLevel(GameLevel.LEVEL_MALL3)
			CASE GameEvent.LOAD_LEVEL_BOOK_STORE
				mainGameScreen.renderState.SetBackground(RenderStateBackground.BG_BOOK_STORE)
				m_gameState.LoadLevel(GameLevel.LEVEL_BOOK_STORE)
		End Select
	End Sub

	Private Sub _LoadGameMain()
		mainGameLoop.Enabled = True
		m_currentScreen.Hide()
		mainGameScreen.Show()
	End Sub

	Private Sub _SwitchScreen(screen As UserControl)
		screen.Show()
		mainGameScreen.Hide()
		m_currentScreen = screen

		mainGameLoop.Enabled = False
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

		mainGameScreen.Render(m_gameState)
	End Sub

	Private Sub MainGameLoop_Tick(sender As Object, e As EventArgs) Handles mainGameLoop.Tick
		Dim t1, t2 As Double

		t1 = m_stopwatch.ElapsedMilliseconds
		_MainFrame()
		t2 = m_stopwatch.ElapsedMilliseconds

		' Console.WriteLine(t2 - t1)
	End Sub

	Private Sub MainGame_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
		m_userInput.KeyUp(e.KeyCode)
	End Sub

	Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
		m_userInput.KeyDown(keyData)
		Return MyBase.ProcessCmdKey(msg, keyData)
	End Function
End Class
