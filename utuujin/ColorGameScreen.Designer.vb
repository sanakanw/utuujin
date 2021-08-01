<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ColorGameScreen
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ColorGameScreen))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.panelColorBackdrop = New System.Windows.Forms.Panel()
		Me.btnChoiceRed = New System.Windows.Forms.Button()
		Me.btnChoiceBlue = New System.Windows.Forms.Button()
		Me.btnChoiceGreen = New System.Windows.Forms.Button()
		Me.btnChoiceYellow = New System.Windows.Forms.Button()
		Me.panelColorGame = New System.Windows.Forms.Panel()
		Me.lblEqual = New System.Windows.Forms.Label()
		Me.lblOperator = New System.Windows.Forms.Label()
		Me.spriteCheckButton = New utuujin.SpriteBox()
		Me.spriteBackButton = New utuujin.SpriteBox()
		Me.spriteAnswer = New utuujin.SpriteBox()
		Me.spriteRightHandSide = New utuujin.SpriteBox()
		Me.SpriteBox2 = New utuujin.SpriteBox()
		Me.spriteLeftHandSide = New utuujin.SpriteBox()
		Me.Panel1.SuspendLayout()
		Me.panelColorBackdrop.SuspendLayout()
		Me.panelColorGame.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Transparent
		Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel1.Controls.Add(Me.panelColorBackdrop)
		Me.Panel1.Controls.Add(Me.panelColorGame)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(600, 400)
		Me.Panel1.TabIndex = 0
		'
		'panelColorBackdrop
		'
		Me.panelColorBackdrop.BackgroundImage = Global.utuujin.My.Resources.Resources.png_btn_shape_backdrop
		Me.panelColorBackdrop.Controls.Add(Me.btnChoiceRed)
		Me.panelColorBackdrop.Controls.Add(Me.btnChoiceBlue)
		Me.panelColorBackdrop.Controls.Add(Me.btnChoiceGreen)
		Me.panelColorBackdrop.Controls.Add(Me.btnChoiceYellow)
		Me.panelColorBackdrop.Location = New System.Drawing.Point(0, 300)
		Me.panelColorBackdrop.Name = "panelColorBackdrop"
		Me.panelColorBackdrop.Size = New System.Drawing.Size(600, 100)
		Me.panelColorBackdrop.TabIndex = 58
		'
		'btnChoiceRed
		'
		Me.btnChoiceRed.BackColor = System.Drawing.Color.Red
		Me.btnChoiceRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnChoiceRed.Location = New System.Drawing.Point(209, 29)
		Me.btnChoiceRed.Margin = New System.Windows.Forms.Padding(2)
		Me.btnChoiceRed.Name = "btnChoiceRed"
		Me.btnChoiceRed.Size = New System.Drawing.Size(67, 40)
		Me.btnChoiceRed.TabIndex = 47
		Me.btnChoiceRed.UseVisualStyleBackColor = False
		'
		'btnChoiceBlue
		'
		Me.btnChoiceBlue.BackColor = System.Drawing.Color.Blue
		Me.btnChoiceBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnChoiceBlue.Location = New System.Drawing.Point(74, 29)
		Me.btnChoiceBlue.Margin = New System.Windows.Forms.Padding(2)
		Me.btnChoiceBlue.Name = "btnChoiceBlue"
		Me.btnChoiceBlue.Size = New System.Drawing.Size(67, 40)
		Me.btnChoiceBlue.TabIndex = 50
		Me.btnChoiceBlue.UseVisualStyleBackColor = False
		'
		'btnChoiceGreen
		'
		Me.btnChoiceGreen.BackColor = System.Drawing.Color.Lime
		Me.btnChoiceGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnChoiceGreen.Location = New System.Drawing.Point(480, 29)
		Me.btnChoiceGreen.Margin = New System.Windows.Forms.Padding(2)
		Me.btnChoiceGreen.Name = "btnChoiceGreen"
		Me.btnChoiceGreen.Size = New System.Drawing.Size(67, 40)
		Me.btnChoiceGreen.TabIndex = 49
		Me.btnChoiceGreen.UseVisualStyleBackColor = False
		'
		'btnChoiceYellow
		'
		Me.btnChoiceYellow.BackColor = System.Drawing.Color.Yellow
		Me.btnChoiceYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnChoiceYellow.Location = New System.Drawing.Point(349, 29)
		Me.btnChoiceYellow.Margin = New System.Windows.Forms.Padding(2)
		Me.btnChoiceYellow.Name = "btnChoiceYellow"
		Me.btnChoiceYellow.Size = New System.Drawing.Size(67, 40)
		Me.btnChoiceYellow.TabIndex = 48
		Me.btnChoiceYellow.UseVisualStyleBackColor = False
		'
		'panelColorGame
		'
		Me.panelColorGame.BackgroundImage = CType(resources.GetObject("panelColorGame.BackgroundImage"), System.Drawing.Image)
		Me.panelColorGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panelColorGame.Controls.Add(Me.spriteCheckButton)
		Me.panelColorGame.Controls.Add(Me.lblEqual)
		Me.panelColorGame.Controls.Add(Me.lblOperator)
		Me.panelColorGame.Controls.Add(Me.spriteBackButton)
		Me.panelColorGame.Controls.Add(Me.spriteAnswer)
		Me.panelColorGame.Controls.Add(Me.spriteRightHandSide)
		Me.panelColorGame.Controls.Add(Me.SpriteBox2)
		Me.panelColorGame.Controls.Add(Me.spriteLeftHandSide)
		Me.panelColorGame.Location = New System.Drawing.Point(0, 0)
		Me.panelColorGame.Name = "panelColorGame"
		Me.panelColorGame.Size = New System.Drawing.Size(600, 300)
		Me.panelColorGame.TabIndex = 57
		'
		'lblEqual
		'
		Me.lblEqual.AutoSize = True
		Me.lblEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEqual.ForeColor = System.Drawing.Color.White
		Me.lblEqual.Location = New System.Drawing.Point(302, 145)
		Me.lblEqual.Name = "lblEqual"
		Me.lblEqual.Size = New System.Drawing.Size(52, 55)
		Me.lblEqual.TabIndex = 5
		Me.lblEqual.Text = "="
		'
		'lblOperator
		'
		Me.lblOperator.AutoSize = True
		Me.lblOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOperator.ForeColor = System.Drawing.Color.White
		Me.lblOperator.Location = New System.Drawing.Point(174, 145)
		Me.lblOperator.Name = "lblOperator"
		Me.lblOperator.Size = New System.Drawing.Size(52, 55)
		Me.lblOperator.TabIndex = 4
		Me.lblOperator.Text = "+"
		'
		'spriteCheckButton
		'
		Me.spriteCheckButton.BackColor = System.Drawing.Color.Transparent
		Me.spriteCheckButton.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteCheckButton.Location = New System.Drawing.Point(483, 145)
		Me.spriteCheckButton.Name = "spriteCheckButton"
		Me.spriteCheckButton.Size = New System.Drawing.Size(64, 64)
		Me.spriteCheckButton.TabIndex = 6
		'
		'spriteBackButton
		'
		Me.spriteBackButton.BackColor = System.Drawing.Color.Transparent
		Me.spriteBackButton.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteBackButton.Location = New System.Drawing.Point(21, 18)
		Me.spriteBackButton.Name = "spriteBackButton"
		Me.spriteBackButton.Size = New System.Drawing.Size(64, 64)
		Me.spriteBackButton.TabIndex = 3
		'
		'spriteAnswer
		'
		Me.spriteAnswer.BackColor = System.Drawing.Color.Transparent
		Me.spriteAnswer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteAnswer.Location = New System.Drawing.Point(360, 145)
		Me.spriteAnswer.Name = "spriteAnswer"
		Me.spriteAnswer.Size = New System.Drawing.Size(64, 64)
		Me.spriteAnswer.TabIndex = 2
		'
		'spriteRightHandSide
		'
		Me.spriteRightHandSide.BackColor = System.Drawing.Color.Transparent
		Me.spriteRightHandSide.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteRightHandSide.Location = New System.Drawing.Point(232, 145)
		Me.spriteRightHandSide.Name = "spriteRightHandSide"
		Me.spriteRightHandSide.Size = New System.Drawing.Size(64, 64)
		Me.spriteRightHandSide.TabIndex = 1
		'
		'SpriteBox2
		'
		Me.SpriteBox2.BackColor = System.Drawing.Color.Transparent
		Me.SpriteBox2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SpriteBox2.Location = New System.Drawing.Point(238, 162)
		Me.SpriteBox2.Name = "SpriteBox2"
		Me.SpriteBox2.Size = New System.Drawing.Size(64, 64)
		Me.SpriteBox2.TabIndex = 1
		'
		'spriteLeftHandSide
		'
		Me.spriteLeftHandSide.BackColor = System.Drawing.Color.Transparent
		Me.spriteLeftHandSide.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteLeftHandSide.Location = New System.Drawing.Point(104, 145)
		Me.spriteLeftHandSide.Name = "spriteLeftHandSide"
		Me.spriteLeftHandSide.Size = New System.Drawing.Size(64, 64)
		Me.spriteLeftHandSide.TabIndex = 0
		'
		'ColorGameScreen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Panel1)
		Me.Name = "ColorGameScreen"
		Me.Size = New System.Drawing.Size(600, 400)
		Me.Panel1.ResumeLayout(False)
		Me.panelColorBackdrop.ResumeLayout(False)
		Me.panelColorGame.ResumeLayout(False)
		Me.panelColorGame.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnChoiceRed As Button
	Friend WithEvents btnChoiceYellow As Button
	Friend WithEvents btnChoiceGreen As Button
	Friend WithEvents btnChoiceBlue As Button
	Friend WithEvents panelColorGame As Panel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents panelColorBackdrop As Panel
	Friend WithEvents spriteLeftHandSide As SpriteBox
	Friend WithEvents spriteRightHandSide As SpriteBox
	Friend WithEvents SpriteBox2 As SpriteBox
	Friend WithEvents spriteAnswer As SpriteBox
	Friend WithEvents spriteBackButton As SpriteBox
	Friend WithEvents lblOperator As Label
	Friend WithEvents lblEqual As Label
	Friend WithEvents spriteCheckButton As SpriteBox
End Class
