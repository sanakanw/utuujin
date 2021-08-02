<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainGame
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainGame))
		Me.mainGameLoop = New System.Windows.Forms.Timer(Me.components)
		Me.lblHelp = New System.Windows.Forms.Label()
		Me.mainMenuScreen = New utuujin.MainMenuScreen()
		Me.boardHintScreen = New utuujin.BoardHintScren()
		Me.magicSquareScreen = New utuujin.MagicSquareScreen()
		Me.cipherGameScreen = New utuujin.CipherGameScreen()
		Me.wordGameScreen = New utuujin.WordGameScreen()
		Me.cashRegisterScreen = New utuujin.CashRegisterScreen()
		Me.climbingGameScreen = New utuujin.ClimbingGameScreen()
		Me.colorGameScreen = New utuujin.ColorGameScreen()
		Me.mainGameScreen = New utuujin.MainGameScreen()
		Me.sprBtnReplay = New utuujin.SpriteBox()
		Me.SuspendLayout
		'
		'mainGameLoop
		'
		Me.mainGameLoop.Enabled = true
		Me.mainGameLoop.Interval = 33
		'
		'lblHelp
		'
		Me.lblHelp.AutoSize = true
		Me.lblHelp.BackColor = System.Drawing.Color.Black
		Me.lblHelp.Font = New System.Drawing.Font("Consolas", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblHelp.ForeColor = System.Drawing.Color.White
		Me.lblHelp.Location = New System.Drawing.Point(190, 381)
		Me.lblHelp.Name = "lblHelp"
		Me.lblHelp.Size = New System.Drawing.Size(207, 19)
		Me.lblHelp.TabIndex = 8
		Me.lblHelp.Text = "Press 'z' to interact."
		Me.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lblHelp.Visible = false
		'
		'mainMenuScreen
		'
		Me.mainMenuScreen.BackColor = System.Drawing.Color.Black
		Me.mainMenuScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.mainMenuScreen.Location = New System.Drawing.Point(0, 0)
		Me.mainMenuScreen.Name = "mainMenuScreen"
		Me.mainMenuScreen.Size = New System.Drawing.Size(600, 400)
		Me.mainMenuScreen.TabIndex = 10
		Me.mainMenuScreen.Visible = false
		'
		'boardHintScreen
		'
		Me.boardHintScreen.BackgroundImage = CType(resources.GetObject("boardHintScreen.BackgroundImage"),System.Drawing.Image)
		Me.boardHintScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.boardHintScreen.Location = New System.Drawing.Point(0, 0)
		Me.boardHintScreen.Name = "boardHintScreen"
		Me.boardHintScreen.Size = New System.Drawing.Size(600, 400)
		Me.boardHintScreen.TabIndex = 9
		Me.boardHintScreen.Visible = false
		'
		'magicSquareScreen
		'
		Me.magicSquareScreen.BackColor = System.Drawing.Color.Transparent
		Me.magicSquareScreen.BackgroundImage = CType(resources.GetObject("magicSquareScreen.BackgroundImage"),System.Drawing.Image)
		Me.magicSquareScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.magicSquareScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.magicSquareScreen.Location = New System.Drawing.Point(0, 0)
		Me.magicSquareScreen.Name = "magicSquareScreen"
		Me.magicSquareScreen.Size = New System.Drawing.Size(600, 400)
		Me.magicSquareScreen.TabIndex = 6
		Me.magicSquareScreen.Visible = false
		'
		'cipherGameScreen
		'
		Me.cipherGameScreen.BackgroundImage = CType(resources.GetObject("cipherGameScreen.BackgroundImage"),System.Drawing.Image)
		Me.cipherGameScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.cipherGameScreen.ForeColor = System.Drawing.Color.SaddleBrown
		Me.cipherGameScreen.Location = New System.Drawing.Point(0, 0)
		Me.cipherGameScreen.Name = "cipherGameScreen"
		Me.cipherGameScreen.Size = New System.Drawing.Size(600, 400)
		Me.cipherGameScreen.TabIndex = 5
		Me.cipherGameScreen.Visible = false
		'
		'wordGameScreen
		'
		Me.wordGameScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.wordGameScreen.Location = New System.Drawing.Point(0, 0)
		Me.wordGameScreen.Name = "wordGameScreen"
		Me.wordGameScreen.Size = New System.Drawing.Size(600, 400)
		Me.wordGameScreen.TabIndex = 4
		Me.wordGameScreen.Visible = false
		'
		'cashRegisterScreen
		'
		Me.cashRegisterScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.cashRegisterScreen.Location = New System.Drawing.Point(0, 0)
		Me.cashRegisterScreen.Name = "cashRegisterScreen"
		Me.cashRegisterScreen.Size = New System.Drawing.Size(600, 400)
		Me.cashRegisterScreen.TabIndex = 3
		Me.cashRegisterScreen.Visible = false
		'
		'climbingGameScreen
		'
		Me.climbingGameScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.climbingGameScreen.Location = New System.Drawing.Point(0, 0)
		Me.climbingGameScreen.Name = "climbingGameScreen"
		Me.climbingGameScreen.Size = New System.Drawing.Size(600, 400)
		Me.climbingGameScreen.TabIndex = 2
		Me.climbingGameScreen.Visible = false
		'
		'colorGameScreen
		'
		Me.colorGameScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.colorGameScreen.Location = New System.Drawing.Point(0, 0)
		Me.colorGameScreen.Name = "colorGameScreen"
		Me.colorGameScreen.Size = New System.Drawing.Size(600, 400)
		Me.colorGameScreen.TabIndex = 1
		Me.colorGameScreen.Visible = false
		'
		'mainGameScreen
		'
		Me.mainGameScreen.BackColor = System.Drawing.Color.Magenta
		Me.mainGameScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.mainGameScreen.Location = New System.Drawing.Point(0, 0)
		Me.mainGameScreen.Name = "mainGameScreen"
		Me.mainGameScreen.Size = New System.Drawing.Size(600, 400)
		Me.mainGameScreen.TabIndex = 0
		'
		'sprBtnReplay
		'
		Me.sprBtnReplay.BackColor = System.Drawing.Color.Black
		Me.sprBtnReplay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.sprBtnReplay.Location = New System.Drawing.Point(194, 299)
		Me.sprBtnReplay.Name = "sprBtnReplay"
		Me.sprBtnReplay.Size = New System.Drawing.Size(203, 55)
		Me.sprBtnReplay.TabIndex = 11
		Me.sprBtnReplay.Visible = false
		'
		'MainGame
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = true
		Me.ClientSize = New System.Drawing.Size(600, 400)
		Me.Controls.Add(Me.sprBtnReplay)
		Me.Controls.Add(Me.mainMenuScreen)
		Me.Controls.Add(Me.lblHelp)
		Me.Controls.Add(Me.boardHintScreen)
		Me.Controls.Add(Me.magicSquareScreen)
		Me.Controls.Add(Me.cipherGameScreen)
		Me.Controls.Add(Me.wordGameScreen)
		Me.Controls.Add(Me.cashRegisterScreen)
		Me.Controls.Add(Me.climbingGameScreen)
		Me.Controls.Add(Me.colorGameScreen)
		Me.Controls.Add(Me.mainGameScreen)
		Me.DoubleBuffered = true
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.KeyPreview = true
		Me.Name = "MainGame"
		Me.Text = "Allan"
		Me.TransparencyKey = System.Drawing.Color.BlueViolet
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
	Friend WithEvents mainGameLoop As Timer
	Friend WithEvents mainGameScreen As MainGameScreen
	Friend WithEvents colorGameScreen As ColorGameScreen
	Friend WithEvents climbingGameScreen As ClimbingGameScreen
	Friend WithEvents cashRegisterScreen As CashRegisterScreen
	Friend WithEvents wordGameScreen As WordGameScreen
	Friend WithEvents cipherGameScreen As CipherGameScreen
	Friend WithEvents magicSquareScreen As MagicSquareScreen
	Friend WithEvents lblHelp As Label
	Friend WithEvents boardHintScreen As BoardHintScren
	Friend WithEvents mainMenuScreen As MainMenuScreen
	Friend WithEvents sprBtnReplay As SpriteBox
End Class
