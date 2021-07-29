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
		Me.lblOperation = New System.Windows.Forms.TextBox()
		Me.lblEqual = New System.Windows.Forms.TextBox()
		Me.btnCheck = New System.Windows.Forms.Button()
		Me.btnChoiceRed = New System.Windows.Forms.Button()
		Me.btnChoiceYellow = New System.Windows.Forms.Button()
		Me.btnChoiceGreen = New System.Windows.Forms.Button()
		Me.btnChoiceBlue = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.spriteLeftHandSide = New utuujin.SpriteBox()
		Me.spriteAnswer = New utuujin.SpriteBox()
		Me.spriteRightHandSide = New utuujin.SpriteBox()
		Me.spriteBackground = New utuujin.SpriteBox()
		Me.btnBack = New System.Windows.Forms.Button()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblOperation
		'
		Me.lblOperation.BackColor = System.Drawing.SystemColors.Control
		Me.lblOperation.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblOperation.Enabled = False
		Me.lblOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOperation.Location = New System.Drawing.Point(125, 39)
		Me.lblOperation.Margin = New System.Windows.Forms.Padding(2)
		Me.lblOperation.Multiline = True
		Me.lblOperation.Name = "lblOperation"
		Me.lblOperation.Size = New System.Drawing.Size(64, 64)
		Me.lblOperation.TabIndex = 41
		Me.lblOperation.Text = "+"
		Me.lblOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblEqual
		'
		Me.lblEqual.BackColor = System.Drawing.SystemColors.Control
		Me.lblEqual.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblEqual.Enabled = False
		Me.lblEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEqual.Location = New System.Drawing.Point(309, 39)
		Me.lblEqual.Margin = New System.Windows.Forms.Padding(2)
		Me.lblEqual.Multiline = True
		Me.lblEqual.Name = "lblEqual"
		Me.lblEqual.Size = New System.Drawing.Size(64, 64)
		Me.lblEqual.TabIndex = 42
		Me.lblEqual.Text = "="
		Me.lblEqual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'btnCheck
		'
		Me.btnCheck.Location = New System.Drawing.Point(460, 75)
		Me.btnCheck.Margin = New System.Windows.Forms.Padding(2)
		Me.btnCheck.Name = "btnCheck"
		Me.btnCheck.Size = New System.Drawing.Size(67, 39)
		Me.btnCheck.TabIndex = 46
		Me.btnCheck.Text = "Check"
		Me.btnCheck.UseVisualStyleBackColor = True
		'
		'btnChoiceRed
		'
		Me.btnChoiceRed.BackColor = System.Drawing.Color.Red
		Me.btnChoiceRed.Location = New System.Drawing.Point(190, 282)
		Me.btnChoiceRed.Margin = New System.Windows.Forms.Padding(2)
		Me.btnChoiceRed.Name = "btnChoiceRed"
		Me.btnChoiceRed.Size = New System.Drawing.Size(67, 40)
		Me.btnChoiceRed.TabIndex = 47
		Me.btnChoiceRed.UseVisualStyleBackColor = False
		'
		'btnChoiceYellow
		'
		Me.btnChoiceYellow.BackColor = System.Drawing.Color.Yellow
		Me.btnChoiceYellow.Location = New System.Drawing.Point(331, 282)
		Me.btnChoiceYellow.Margin = New System.Windows.Forms.Padding(2)
		Me.btnChoiceYellow.Name = "btnChoiceYellow"
		Me.btnChoiceYellow.Size = New System.Drawing.Size(67, 40)
		Me.btnChoiceYellow.TabIndex = 48
		Me.btnChoiceYellow.UseVisualStyleBackColor = False
		'
		'btnChoiceGreen
		'
		Me.btnChoiceGreen.BackColor = System.Drawing.Color.Lime
		Me.btnChoiceGreen.Location = New System.Drawing.Point(460, 282)
		Me.btnChoiceGreen.Margin = New System.Windows.Forms.Padding(2)
		Me.btnChoiceGreen.Name = "btnChoiceGreen"
		Me.btnChoiceGreen.Size = New System.Drawing.Size(67, 40)
		Me.btnChoiceGreen.TabIndex = 49
		Me.btnChoiceGreen.UseVisualStyleBackColor = False
		'
		'btnChoiceBlue
		'
		Me.btnChoiceBlue.BackColor = System.Drawing.Color.Blue
		Me.btnChoiceBlue.Location = New System.Drawing.Point(54, 282)
		Me.btnChoiceBlue.Margin = New System.Windows.Forms.Padding(2)
		Me.btnChoiceBlue.Name = "btnChoiceBlue"
		Me.btnChoiceBlue.Size = New System.Drawing.Size(67, 40)
		Me.btnChoiceBlue.TabIndex = 50
		Me.btnChoiceBlue.UseVisualStyleBackColor = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Transparent
		Me.Panel1.Controls.Add(Me.btnBack)
		Me.Panel1.Controls.Add(Me.Panel2)
		Me.Panel1.Controls.Add(Me.btnChoiceBlue)
		Me.Panel1.Controls.Add(Me.btnChoiceGreen)
		Me.Panel1.Controls.Add(Me.btnChoiceYellow)
		Me.Panel1.Controls.Add(Me.btnChoiceRed)
		Me.Panel1.Controls.Add(Me.btnCheck)
		Me.Panel1.Controls.Add(Me.spriteBackground)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(600, 400)
		Me.Panel1.TabIndex = 0
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.spriteLeftHandSide)
		Me.Panel2.Controls.Add(Me.spriteAnswer)
		Me.Panel2.Controls.Add(Me.lblOperation)
		Me.Panel2.Controls.Add(Me.spriteRightHandSide)
		Me.Panel2.Controls.Add(Me.lblEqual)
		Me.Panel2.Location = New System.Drawing.Point(54, 134)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(473, 119)
		Me.Panel2.TabIndex = 55
		'
		'spriteLeftHandSide
		'
		Me.spriteLeftHandSide.BackColor = System.Drawing.SystemColors.Control
		Me.spriteLeftHandSide.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteLeftHandSide.Location = New System.Drawing.Point(21, 7)
		Me.spriteLeftHandSide.Name = "spriteLeftHandSide"
		Me.spriteLeftHandSide.Size = New System.Drawing.Size(96, 96)
		Me.spriteLeftHandSide.TabIndex = 52
		'
		'spriteAnswer
		'
		Me.spriteAnswer.BackColor = System.Drawing.SystemColors.Control
		Me.spriteAnswer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteAnswer.Location = New System.Drawing.Point(364, 7)
		Me.spriteAnswer.Name = "spriteAnswer"
		Me.spriteAnswer.Size = New System.Drawing.Size(96, 96)
		Me.spriteAnswer.TabIndex = 53
		'
		'spriteRightHandSide
		'
		Me.spriteRightHandSide.BackColor = System.Drawing.SystemColors.Control
		Me.spriteRightHandSide.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteRightHandSide.Location = New System.Drawing.Point(194, 7)
		Me.spriteRightHandSide.Name = "spriteRightHandSide"
		Me.spriteRightHandSide.Size = New System.Drawing.Size(96, 96)
		Me.spriteRightHandSide.TabIndex = 51
		'
		'spriteBackground
		'
		Me.spriteBackground.BackColor = System.Drawing.Color.Magenta
		Me.spriteBackground.Dock = System.Windows.Forms.DockStyle.Fill
		Me.spriteBackground.ForeColor = System.Drawing.SystemColors.ControlText
		Me.spriteBackground.Location = New System.Drawing.Point(0, 0)
		Me.spriteBackground.Name = "spriteBackground"
		Me.spriteBackground.Size = New System.Drawing.Size(600, 400)
		Me.spriteBackground.TabIndex = 54
		'
		'btnBack
		'
		Me.btnBack.Location = New System.Drawing.Point(20, 20)
		Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(67, 39)
		Me.btnBack.TabIndex = 56
		Me.btnBack.Text = "Back"
		Me.btnBack.UseVisualStyleBackColor = True
		'
		'ColorGameScreen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Panel1)
		Me.Name = "ColorGameScreen"
		Me.Size = New System.Drawing.Size(600, 400)
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents lblOperation As TextBox
	Friend WithEvents lblEqual As TextBox
	Friend WithEvents btnCheck As Button
	Friend WithEvents btnChoiceRed As Button
	Friend WithEvents btnChoiceYellow As Button
	Friend WithEvents btnChoiceGreen As Button
	Friend WithEvents btnChoiceBlue As Button
	Friend WithEvents spriteRightHandSide As SpriteBox
	Friend WithEvents spriteLeftHandSide As SpriteBox
	Friend WithEvents spriteAnswer As SpriteBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents spriteBackground As SpriteBox
	Friend WithEvents Panel2 As Panel
	Friend WithEvents btnBack As Button
End Class
