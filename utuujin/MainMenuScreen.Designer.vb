<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuScreen
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
		Me.sprTitle = New utuujin.SpriteBox()
		Me.sprBtnPlay = New utuujin.SpriteBox()
		Me.SuspendLayout
		'
		'sprTitle
		'
		Me.sprTitle.BackColor = System.Drawing.Color.Transparent
		Me.sprTitle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.sprTitle.Location = New System.Drawing.Point(137, 53)
		Me.sprTitle.Name = "sprTitle"
		Me.sprTitle.Size = New System.Drawing.Size(323, 101)
		Me.sprTitle.TabIndex = 0
		'
		'sprBtnPlay
		'
		Me.sprBtnPlay.BackColor = System.Drawing.Color.Transparent
		Me.sprBtnPlay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.sprBtnPlay.Location = New System.Drawing.Point(186, 222)
		Me.sprBtnPlay.Name = "sprBtnPlay"
		Me.sprBtnPlay.Size = New System.Drawing.Size(221, 55)
		Me.sprBtnPlay.TabIndex = 1
		'
		'MainMenuScreen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.Controls.Add(Me.sprBtnPlay)
		Me.Controls.Add(Me.sprTitle)
		Me.Name = "MainMenuScreen"
		Me.Size = New System.Drawing.Size(600, 400)
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents sprTitle As SpriteBox
	Friend WithEvents sprBtnPlay As SpriteBox
End Class
