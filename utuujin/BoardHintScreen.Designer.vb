<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BoardHintScren
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
		Me.sprBtnBack = New utuujin.SpriteBox()
		Me.SuspendLayout
		'
		'sprBtnBack
		'
		Me.sprBtnBack.BackColor = System.Drawing.Color.Transparent
		Me.sprBtnBack.ForeColor = System.Drawing.SystemColors.ControlText
		Me.sprBtnBack.Location = New System.Drawing.Point(21, 18)
		Me.sprBtnBack.Name = "sprBtnBack"
		Me.sprBtnBack.Size = New System.Drawing.Size(64, 64)
		Me.sprBtnBack.TabIndex = 0
		'
		'BoardHintScren
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.utuujin.My.Resources.Resources.bg_hint_screen
		Me.Controls.Add(Me.sprBtnBack)
		Me.Name = "BoardHintScren"
		Me.Size = New System.Drawing.Size(600, 400)
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents sprBtnBack As SpriteBox
End Class
