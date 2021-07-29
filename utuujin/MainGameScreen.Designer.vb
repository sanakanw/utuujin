<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainGameScreen
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.panelGameScreen = New System.Windows.Forms.Panel()
		Me.SuspendLayout()
		'
		'panelGameScreen
		'
		Me.panelGameScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.panelGameScreen.Location = New System.Drawing.Point(0, 0)
		Me.panelGameScreen.Name = "panelGameScreen"
		Me.panelGameScreen.Size = New System.Drawing.Size(600, 400)
		Me.panelGameScreen.TabIndex = 0
		'
		'MainGameScreen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Magenta
		Me.Controls.Add(Me.panelGameScreen)
		Me.Name = "MainGameScreen"
		Me.Size = New System.Drawing.Size(600, 400)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents panelGameScreen As Panel
End Class
