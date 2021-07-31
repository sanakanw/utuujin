<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClimbingGameScreen
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
		Me.panelShapeBackdrop = New System.Windows.Forms.Panel()
		Me.spriteChoiceTriangle = New utuujin.SpriteBox()
		Me.spriteChoiceSquare = New utuujin.SpriteBox()
		Me.spriteChoiceCircle = New utuujin.SpriteBox()
		Me.spriteChoiceDiamond = New utuujin.SpriteBox()
		Me.spriteShapeRow3 = New utuujin.SpriteBox()
		Me.spriteShapeRow4 = New utuujin.SpriteBox()
		Me.spriteShapeRow2 = New utuujin.SpriteBox()
		Me.spriteBackdrop = New utuujin.SpriteBox()
		Me.spriteShapeRow1 = New utuujin.SpriteBox()
		Me.panelShapeBackdrop.SuspendLayout()
		Me.SuspendLayout()
		'
		'panelShapeBackdrop
		'
		Me.panelShapeBackdrop.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.panelShapeBackdrop.BackgroundImage = Global.utuujin.My.Resources.Resources.png_btn_shape_backdrop
		Me.panelShapeBackdrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panelShapeBackdrop.Controls.Add(Me.spriteChoiceTriangle)
		Me.panelShapeBackdrop.Controls.Add(Me.spriteChoiceSquare)
		Me.panelShapeBackdrop.Controls.Add(Me.spriteChoiceCircle)
		Me.panelShapeBackdrop.Controls.Add(Me.spriteChoiceDiamond)
		Me.panelShapeBackdrop.Location = New System.Drawing.Point(0, 300)
		Me.panelShapeBackdrop.Name = "panelShapeBackdrop"
		Me.panelShapeBackdrop.Size = New System.Drawing.Size(600, 100)
		Me.panelShapeBackdrop.TabIndex = 11
		'
		'spriteChoiceTriangle
		'
		Me.spriteChoiceTriangle.BackColor = System.Drawing.Color.Transparent
		Me.spriteChoiceTriangle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteChoiceTriangle.Location = New System.Drawing.Point(442, 16)
		Me.spriteChoiceTriangle.Name = "spriteChoiceTriangle"
		Me.spriteChoiceTriangle.Size = New System.Drawing.Size(64, 64)
		Me.spriteChoiceTriangle.TabIndex = 3
		'
		'spriteChoiceSquare
		'
		Me.spriteChoiceSquare.BackColor = System.Drawing.Color.Transparent
		Me.spriteChoiceSquare.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteChoiceSquare.Location = New System.Drawing.Point(325, 17)
		Me.spriteChoiceSquare.Name = "spriteChoiceSquare"
		Me.spriteChoiceSquare.Size = New System.Drawing.Size(64, 64)
		Me.spriteChoiceSquare.TabIndex = 2
		'
		'spriteChoiceCircle
		'
		Me.spriteChoiceCircle.BackColor = System.Drawing.Color.Transparent
		Me.spriteChoiceCircle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteChoiceCircle.Location = New System.Drawing.Point(198, 16)
		Me.spriteChoiceCircle.Name = "spriteChoiceCircle"
		Me.spriteChoiceCircle.Size = New System.Drawing.Size(64, 64)
		Me.spriteChoiceCircle.TabIndex = 1
		'
		'spriteChoiceDiamond
		'
		Me.spriteChoiceDiamond.BackColor = System.Drawing.Color.Transparent
		Me.spriteChoiceDiamond.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteChoiceDiamond.Location = New System.Drawing.Point(60, 17)
		Me.spriteChoiceDiamond.Name = "spriteChoiceDiamond"
		Me.spriteChoiceDiamond.Size = New System.Drawing.Size(64, 64)
		Me.spriteChoiceDiamond.TabIndex = 0
		'
		'spriteShapeRow3
		'
		Me.spriteShapeRow3.BackColor = System.Drawing.Color.Transparent
		Me.spriteShapeRow3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteShapeRow3.Location = New System.Drawing.Point(151, 81)
		Me.spriteShapeRow3.Name = "spriteShapeRow3"
		Me.spriteShapeRow3.Size = New System.Drawing.Size(48, 48)
		Me.spriteShapeRow3.TabIndex = 9
		'
		'spriteShapeRow4
		'
		Me.spriteShapeRow4.BackColor = System.Drawing.Color.Transparent
		Me.spriteShapeRow4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteShapeRow4.Location = New System.Drawing.Point(151, 17)
		Me.spriteShapeRow4.Name = "spriteShapeRow4"
		Me.spriteShapeRow4.Size = New System.Drawing.Size(48, 48)
		Me.spriteShapeRow4.TabIndex = 8
		'
		'spriteShapeRow2
		'
		Me.spriteShapeRow2.BackColor = System.Drawing.Color.Transparent
		Me.spriteShapeRow2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteShapeRow2.Location = New System.Drawing.Point(150, 146)
		Me.spriteShapeRow2.Name = "spriteShapeRow2"
		Me.spriteShapeRow2.Size = New System.Drawing.Size(48, 48)
		Me.spriteShapeRow2.TabIndex = 7
		'
		'spriteBackdrop
		'
		Me.spriteBackdrop.BackColor = System.Drawing.Color.Black
		Me.spriteBackdrop.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteBackdrop.Location = New System.Drawing.Point(0, -1190)
		Me.spriteBackdrop.Name = "spriteBackdrop"
		Me.spriteBackdrop.Size = New System.Drawing.Size(600, 1500)
		Me.spriteBackdrop.TabIndex = 0
		'
		'spriteShapeRow1
		'
		Me.spriteShapeRow1.BackColor = System.Drawing.Color.Transparent
		Me.spriteShapeRow1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteShapeRow1.Location = New System.Drawing.Point(150, 207)
		Me.spriteShapeRow1.Name = "spriteShapeRow1"
		Me.spriteShapeRow1.Size = New System.Drawing.Size(48, 48)
		Me.spriteShapeRow1.TabIndex = 12
		'
		'ClimbingGameScreen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.spriteShapeRow1)
		Me.Controls.Add(Me.panelShapeBackdrop)
		Me.Controls.Add(Me.spriteShapeRow3)
		Me.Controls.Add(Me.spriteShapeRow4)
		Me.Controls.Add(Me.spriteShapeRow2)
		Me.Controls.Add(Me.spriteBackdrop)
		Me.Name = "ClimbingGameScreen"
		Me.Size = New System.Drawing.Size(600, 400)
		Me.panelShapeBackdrop.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents spriteBackdrop As SpriteBox
	Friend WithEvents spriteShapeRow3 As SpriteBox
	Friend WithEvents spriteShapeRow4 As SpriteBox
	Friend WithEvents panelShapeBackdrop As Panel
	Friend WithEvents spriteChoiceTriangle As SpriteBox
	Friend WithEvents spriteChoiceSquare As SpriteBox
	Friend WithEvents spriteChoiceCircle As SpriteBox
	Friend WithEvents spriteChoiceDiamond As SpriteBox
	Friend WithEvents spriteShapeRow2 As SpriteBox
	Friend WithEvents spriteShapeRow1 As SpriteBox
End Class
