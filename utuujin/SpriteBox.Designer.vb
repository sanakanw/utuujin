<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpriteBox
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
		Me.panelSprite = New System.Windows.Forms.Panel()
		Me.SuspendLayout()
		'
		'panelSprite
		'
		Me.panelSprite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelSprite.Dock = System.Windows.Forms.DockStyle.Fill
		Me.panelSprite.Location = New System.Drawing.Point(0, 0)
		Me.panelSprite.Name = "panelSprite"
		Me.panelSprite.Size = New System.Drawing.Size(64, 64)
		Me.panelSprite.TabIndex = 0
		'
		'SpriteBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Transparent
		Me.Controls.Add(Me.panelSprite)
		Me.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Name = "SpriteBox"
		Me.Size = New System.Drawing.Size(64, 64)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents panelSprite As Panel
End Class
