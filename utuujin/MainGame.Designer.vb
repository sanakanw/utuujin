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
		Me.mainGameLoop = New System.Windows.Forms.Timer(Me.components)
		Me.colorGameScreen = New utuujin.ColorGameScreen()
		Me.mainGameScreen = New utuujin.MainGameScreen()
		Me.SuspendLayout()
		'
		'mainGameLoop
		'
		Me.mainGameLoop.Enabled = True
		Me.mainGameLoop.Interval = 33
		'
		'colorGameScreen
		'
		Me.colorGameScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.colorGameScreen.Location = New System.Drawing.Point(0, 0)
		Me.colorGameScreen.Name = "colorGameScreen"
		Me.colorGameScreen.Size = New System.Drawing.Size(600, 400)
		Me.colorGameScreen.TabIndex = 1
		Me.colorGameScreen.Visible = False
		'
		'mainGameScreen
		'
		Me.mainGameScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.mainGameScreen.Location = New System.Drawing.Point(0, 0)
		Me.mainGameScreen.Name = "mainGameScreen"
		Me.mainGameScreen.Size = New System.Drawing.Size(600, 400)
		Me.mainGameScreen.TabIndex = 0
		'
		'MainGame
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.ClientSize = New System.Drawing.Size(600, 400)
		Me.Controls.Add(Me.colorGameScreen)
		Me.Controls.Add(Me.mainGameScreen)
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.KeyPreview = True
		Me.Name = "MainGame"
		Me.Text = "Allan"
		Me.TransparencyKey = System.Drawing.Color.BlueViolet
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents mainGameLoop As Timer
	Friend WithEvents mainGameScreen As MainGameScreen
	Friend WithEvents colorGameScreen As ColorGameScreen
End Class
