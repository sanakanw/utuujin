
Public Class MainGame
	Private m_deltaTime As Double
	Private m_previousTime As Long
	Private m_tickCount As Integer

	Private m_userInput As UserInput
	Private m_gameState As GameState
	Private m_animState As AnimationState
	Private m_currentScreen As UserControl

	Public EventFlag(128) As Boolean

	Private m_stopwatch As Stopwatch

	Private m_transitionTick As Integer = 0
	Private m_targetOpacity As Integer = 0

	Private Sub MainGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		m_stopwatch = New Stopwatch()

		m_userInput = New UserInput()
		m_gameState = New GameState()
		m_animState = New AnimationState()

		m_stopwatch.Start()

		m_previousTime = m_stopwatch.ElapsedMilliseconds

		sprBtnReplay.SetBitmap(My.Resources.png_btn_replay)

		PostEvent(GameEvent.LOAD_SCREEN_MAIN_MENU)
	End Sub

	Private Sub _LoadLevel(level As GameLevel, transitionTime As Integer)
		m_userInput = New UserInput()
		m_targetOpacity = transitionTime
		m_transitionTick = m_tickCount + transitionTime
		m_gameState.LoadLevel(level)
	End Sub

	Public Sub PostEvent(gameEvent As GameEvent)
		EventFlag(gameEvent) = True

		Select Case gameEvent
			Case GameEvent.LOAD_LEVEL_PARK_1
				GameSoundPlayer.PlayBgm(GameBgm.BGM_REALITY)
				_LoadLevel(GameLevel.LEVEL_PARK1, 250)
			Case GameEvent.LOAD_LEVEL_PARK_2
				_LoadLevel(GameLevel.LEVEL_PARK2, 250)
			Case GameEvent.LOAD_LEVEL_SEWERS_1
				_LoadLevel(GameLevel.LEVEL_SEWERS1, 120)
			Case GameEvent.LOAD_LEVEL_STREETS_1
				_LoadLevel(GameLevel.LEVEL_STREETS1, 200)
			Case GameEvent.LOAD_LEVEL_MALL_1
				_LoadLevel(GameLevel.LEVEL_MALL1, 200)
			Case GameEvent.LOAD_LEVEL_MALL_2
				GameSoundPlayer.PlayBgm(GameBgm.BGM_DREAMING)
				_LoadLevel(GameLevel.LEVEL_MALL2, 140)
			Case GameEvent.LOAD_LEVEL_MALL_3
				_LoadLevel(GameLevel.LEVEL_MALL3, 140)
			Case GameEvent.LOAD_LEVEL_MALL_4
				_LoadLevel(GameLevel.LEVEL_MALL4, 140)
			Case GameEvent.LOAD_LEVEL_MALL_5
				_LoadLevel(GameLevel.LEVEL_MALL5, 140)
			Case GameEvent.LOAD_LEVEL_ROOF
				mainGameScreen.renderState.SetBackground(RenderStateBackground.BG_ROOF)
				_LoadLevel(GameLevel.LEVEL_ROOF, 170)

			Case GameEvent.LOAD_LEVEL_CLIMBING_TOP
				mainGameScreen.renderState.SetBackground(RenderStateBackground.BG_CLIMBING_GAME_TOP)
				_LoadLevel(GameLevel.LEVEL_CLIMBING_TOP, 250)
			CASE GameEvent.LOAD_LEVEL_BOOK_STORE
				mainGameScreen.renderState.SetBackground(RenderStateBackground.BG_BOOK_STORE)
				_LoadLevel(GameLevel.LEVEL_BOOK_STORE, 100)
			Case GameEvent.LOAD_LEVEL_HARDWARE_STORE
				mainGameScreen.renderState.SetBackground(RenderStateBackground.BG_HARDWARE_STORE)
				_LoadLevel(GameLevel.LEVEL_HARDWARE_STORE, 100)
			Case GameEvent.LOAD_LEVEL_ART_STORE
				mainGameScreen.renderState.SetBackground(RenderStateBackground.BG_ART_STORE)
				_LoadLevel(GameLevel.LEVEL_ART_STORE, 100)

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
			Case GameEvent.LOAD_BOARD_HINT
				_SwitchScreen(boardHintScreen)
			Case GameEvent.LOAD_SCREEN_MAIN_MENU
				GameSoundPlayer.PlayBgm(GameBgm.BGM_SUNDAY_AFTERNOON)
				_SwitchScreen(mainMenuScreen)
			Case GameEvent.LOAD_GAME_MAIN
				_LoadGameMain()

			Case GameEvent.EVENT_GAME_START
				_LoadGameMain()
				PostEvent(gameEvent.LOAD_LEVEL_PARK_1)
			Case GameEvent.EVENT_CIPHER_COMPLETE
				_LoadGameMain()
				PostEvent(GameEvent.LOAD_LEVEL_MALL_3)
			Case GameEvent.EVENT_HARDWARE_COMPLETE
				_LoadGameMain()
				PostEvent(GameEvent.LOAD_LEVEL_MALL_4)
			Case GameEvent.EVENT_PAINT_COMPLETE
				_LoadGameMain()
				PostEvent(GameEvent.LOAD_LEVEL_MALL_5)
			Case GameEvent.EVENT_CLIMBING_GAME_COMPLETE
				_LoadGameMain()
				PostEvent(GameEvent.LOAD_LEVEL_CLIMBING_TOP)
			Case GameEvent.EVENT_WORD_GAME_COMPLETE
				_LoadGameMain()

				PostEvent(GameEvent.LOAD_LEVEL_ROOF)

				m_gameState.Player.baseEntity.xPos = 19
				m_gameState.Player.baseEntity.yPos = 16

				m_animState.PlayFinalScene(m_tickCount)
				
			Case GameEvent.EVENT_SLIDE_COMPLETE
				GameSoundPlayer.Play(GameSound.SOUND_BUTTON_CLICK)

				mainGameScreen.renderState.SetBackground(RenderStateBackground.BG_CLIMBING_GAME_TOP)
				PostEvent(GameEvent.LOAD_LEVEL_PARK_2)

				m_gameState.Player.baseEntity.xPos = 9
				m_gameState.Player.baseEntity.yPos = 18
				
				If EventFlag(GameEvent.EVENT_MAGIC_SQUARE_COMPLETE) = True Then
					m_gameState.OpenManhole()
				End If
			Case GameEvent.EVENT_MAGIC_SQUARE_COMPLETE
				_LoadGameMain()
				GameSoundPlayer.Play(GameSound.SOUND_BUTTON_CLICK)

				If EventFlag(GameEvent.EVENT_SLIDE_COMPLETE) = True Then
					m_gameState.OpenManhole()
				End If
		End Select
	End Sub

	Private Sub _LoadGameMain()
		mainGameLoop.Enabled = True
		m_currentScreen.Hide()
		mainGameScreen.Show()
		m_previousTime = m_stopwatch.ElapsedMilliseconds
	End Sub

	Private Sub _SwitchScreen(screen As UserControl)
		screen.Show()
		mainGameScreen.Hide()
		m_currentScreen = screen
		
		m_previousTime = m_stopwatch.ElapsedMilliseconds
		mainGameLoop.Enabled = False
		lblHelp.Visible = False
	End Sub

	Private Sub _MainFrame()
		Dim elapsedTime As Double = m_stopwatch.ElapsedMilliseconds - m_previousTime
		m_previousTime = m_stopwatch.ElapsedMilliseconds

		m_deltaTime = m_deltaTime + elapsedTime / 1000.0

		lblHelp.Visible = m_gameState.Player.IsShowHelpLabel

		While m_deltaTime >= 0.0
			m_deltaTime = m_deltaTime - Settings.SECONDS_PER_TICK
			
			If m_animState.Playing Then
				m_gameState.Frame(m_tickCount, m_animState.GetFrameState(m_tickCount))
			Else
				If Not m_animState.Playing And EventFlag(GameEvent.EVENT_WORD_GAME_COMPLETE) And Not EventFlag(GameEvent.EVENT_LOAD_ENDING_SCENE)
					GameSoundPlayer.Play(GameSound.SOUND_TAKE_OFF)
					GameSoundPlayer.PlayBgm(GameBgm.BGM_SHELTER)
					sprBtnReplay.Show()
					PostEvent(GameEvent.EVENT_LOAD_ENDING_SCENE)
				End If
				
				m_gameState.Frame(m_tickCount, m_userInput)
			End If

			m_tickCount = m_tickCount + 1
		End While

		If m_transitionTick > m_tickCount Then
			Dim opacity As Integer = m_targetOpacity - (m_transitionTick - m_tickCount)
			mainGameScreen.renderState.SetOpacity(opacity)
		End If

		If EventFlag(GameEvent.EVENT_LOAD_ENDING_SCENE)
			mainGameScreen.RenderEndingScene()
		Else
			mainGameScreen.Render(m_gameState)
		End If
	End Sub

	Private Sub MainGameLoop_Tick(sender As Object, e As EventArgs) Handles mainGameLoop.Tick
		Dim t1, t2 As Double

		t1 = m_stopwatch.ElapsedMilliseconds
		_MainFrame()
		t2 = m_stopwatch.ElapsedMilliseconds

		' Console.WriteLine(t2 - t1)
	End Sub

	Private Sub MainGame_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
		If m_tickCount > (m_transitionTick >> 1) Or Not m_animState.Playing Then
			m_userInput.KeyUp(e.KeyCode)
		End If
	End Sub

	Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
		If m_tickCount > (m_transitionTick >> 1) Or Not m_animState.Playing Then
			m_userInput.KeyDown(keyData)
		End If

		Return MyBase.ProcessCmdKey(msg, keyData)
	End Function

	Private Sub sprBtnReplay_Click(sender As Object, e As EventArgs) Handles sprBtnReplay.Click
		Me.Close()
	End Sub
End Class
