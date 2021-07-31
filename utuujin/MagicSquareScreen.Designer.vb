<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MagicSquareScreen
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
		Me.lblGrid11 = New System.Windows.Forms.Label()
		Me.lblGrid12 = New System.Windows.Forms.Label()
		Me.lblGrid13 = New System.Windows.Forms.Label()
		Me.lblGrid23 = New System.Windows.Forms.Label()
		Me.lblGrid22 = New System.Windows.Forms.Label()
		Me.lblGrid21 = New System.Windows.Forms.Label()
		Me.lblGrid33 = New System.Windows.Forms.Label()
		Me.lblGrid32 = New System.Windows.Forms.Label()
		Me.lblGrid31 = New System.Windows.Forms.Label()
		Me.lblResultCol3 = New System.Windows.Forms.Label()
		Me.lblResultCol2 = New System.Windows.Forms.Label()
		Me.lblResultCol1 = New System.Windows.Forms.Label()
		Me.lblResultRow3 = New System.Windows.Forms.Label()
		Me.lblResultRow2 = New System.Windows.Forms.Label()
		Me.lblResultRow1 = New System.Windows.Forms.Label()
		Me.sprBtnCheck = New utuujin.SpriteBox()
		Me.SuspendLayout()
		'
		'lblGrid11
		'
		Me.lblGrid11.BackColor = System.Drawing.Color.Transparent
		Me.lblGrid11.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrid11.Location = New System.Drawing.Point(114, 15)
		Me.lblGrid11.Name = "lblGrid11"
		Me.lblGrid11.Size = New System.Drawing.Size(83, 79)
		Me.lblGrid11.TabIndex = 0
		Me.lblGrid11.Text = "9"
		Me.lblGrid11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblGrid12
		'
		Me.lblGrid12.BackColor = System.Drawing.Color.Transparent
		Me.lblGrid12.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrid12.Location = New System.Drawing.Point(261, 15)
		Me.lblGrid12.Name = "lblGrid12"
		Me.lblGrid12.Size = New System.Drawing.Size(83, 79)
		Me.lblGrid12.TabIndex = 1
		Me.lblGrid12.Text = "9"
		Me.lblGrid12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblGrid13
		'
		Me.lblGrid13.BackColor = System.Drawing.Color.Transparent
		Me.lblGrid13.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrid13.Location = New System.Drawing.Point(402, 15)
		Me.lblGrid13.Name = "lblGrid13"
		Me.lblGrid13.Size = New System.Drawing.Size(83, 79)
		Me.lblGrid13.TabIndex = 2
		Me.lblGrid13.Text = "9"
		Me.lblGrid13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblGrid23
		'
		Me.lblGrid23.BackColor = System.Drawing.Color.Transparent
		Me.lblGrid23.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrid23.Location = New System.Drawing.Point(402, 145)
		Me.lblGrid23.Name = "lblGrid23"
		Me.lblGrid23.Size = New System.Drawing.Size(83, 79)
		Me.lblGrid23.TabIndex = 5
		Me.lblGrid23.Text = "9"
		Me.lblGrid23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblGrid22
		'
		Me.lblGrid22.BackColor = System.Drawing.Color.Transparent
		Me.lblGrid22.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrid22.Location = New System.Drawing.Point(261, 145)
		Me.lblGrid22.Name = "lblGrid22"
		Me.lblGrid22.Size = New System.Drawing.Size(83, 79)
		Me.lblGrid22.TabIndex = 4
		Me.lblGrid22.Text = "9"
		Me.lblGrid22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblGrid21
		'
		Me.lblGrid21.BackColor = System.Drawing.Color.Transparent
		Me.lblGrid21.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrid21.Location = New System.Drawing.Point(114, 145)
		Me.lblGrid21.Name = "lblGrid21"
		Me.lblGrid21.Size = New System.Drawing.Size(83, 79)
		Me.lblGrid21.TabIndex = 3
		Me.lblGrid21.Text = "9"
		Me.lblGrid21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblGrid33
		'
		Me.lblGrid33.BackColor = System.Drawing.Color.Transparent
		Me.lblGrid33.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrid33.Location = New System.Drawing.Point(402, 268)
		Me.lblGrid33.Name = "lblGrid33"
		Me.lblGrid33.Size = New System.Drawing.Size(83, 79)
		Me.lblGrid33.TabIndex = 8
		Me.lblGrid33.Text = "9"
		Me.lblGrid33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblGrid32
		'
		Me.lblGrid32.BackColor = System.Drawing.Color.Transparent
		Me.lblGrid32.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrid32.Location = New System.Drawing.Point(261, 268)
		Me.lblGrid32.Name = "lblGrid32"
		Me.lblGrid32.Size = New System.Drawing.Size(83, 79)
		Me.lblGrid32.TabIndex = 7
		Me.lblGrid32.Text = "9"
		Me.lblGrid32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblGrid31
		'
		Me.lblGrid31.BackColor = System.Drawing.Color.Transparent
		Me.lblGrid31.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrid31.Location = New System.Drawing.Point(114, 268)
		Me.lblGrid31.Name = "lblGrid31"
		Me.lblGrid31.Size = New System.Drawing.Size(83, 79)
		Me.lblGrid31.TabIndex = 6
		Me.lblGrid31.Text = "9"
		Me.lblGrid31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblResultCol3
		'
		Me.lblResultCol3.BackColor = System.Drawing.Color.Transparent
		Me.lblResultCol3.Font = New System.Drawing.Font("Consolas", 20.0!)
		Me.lblResultCol3.Location = New System.Drawing.Point(402, 336)
		Me.lblResultCol3.Name = "lblResultCol3"
		Me.lblResultCol3.Size = New System.Drawing.Size(83, 79)
		Me.lblResultCol3.TabIndex = 11
		Me.lblResultCol3.Text = "9"
		Me.lblResultCol3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lblResultCol3.Visible = False
		'
		'lblResultCol2
		'
		Me.lblResultCol2.BackColor = System.Drawing.Color.Transparent
		Me.lblResultCol2.Font = New System.Drawing.Font("Consolas", 20.0!)
		Me.lblResultCol2.Location = New System.Drawing.Point(265, 336)
		Me.lblResultCol2.Name = "lblResultCol2"
		Me.lblResultCol2.Size = New System.Drawing.Size(83, 79)
		Me.lblResultCol2.TabIndex = 10
		Me.lblResultCol2.Text = "9"
		Me.lblResultCol2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lblResultCol2.Visible = False
		'
		'lblResultCol1
		'
		Me.lblResultCol1.BackColor = System.Drawing.Color.Transparent
		Me.lblResultCol1.Font = New System.Drawing.Font("Consolas", 20.0!)
		Me.lblResultCol1.Location = New System.Drawing.Point(114, 336)
		Me.lblResultCol1.Name = "lblResultCol1"
		Me.lblResultCol1.Size = New System.Drawing.Size(83, 79)
		Me.lblResultCol1.TabIndex = 9
		Me.lblResultCol1.Text = "9"
		Me.lblResultCol1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lblResultCol1.Visible = False
		'
		'lblResultRow3
		'
		Me.lblResultRow3.BackColor = System.Drawing.Color.Transparent
		Me.lblResultRow3.Font = New System.Drawing.Font("Consolas", 20.0!)
		Me.lblResultRow3.Location = New System.Drawing.Point(21, 266)
		Me.lblResultRow3.Name = "lblResultRow3"
		Me.lblResultRow3.Size = New System.Drawing.Size(83, 79)
		Me.lblResultRow3.TabIndex = 12
		Me.lblResultRow3.Text = "9"
		Me.lblResultRow3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lblResultRow3.Visible = False
		'
		'lblResultRow2
		'
		Me.lblResultRow2.BackColor = System.Drawing.Color.Transparent
		Me.lblResultRow2.Font = New System.Drawing.Font("Consolas", 20.0!)
		Me.lblResultRow2.Location = New System.Drawing.Point(21, 143)
		Me.lblResultRow2.Name = "lblResultRow2"
		Me.lblResultRow2.Size = New System.Drawing.Size(83, 79)
		Me.lblResultRow2.TabIndex = 13
		Me.lblResultRow2.Text = "9"
		Me.lblResultRow2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lblResultRow2.Visible = False
		'
		'lblResultRow1
		'
		Me.lblResultRow1.BackColor = System.Drawing.Color.Transparent
		Me.lblResultRow1.Font = New System.Drawing.Font("Consolas", 20.0!)
		Me.lblResultRow1.Location = New System.Drawing.Point(25, 15)
		Me.lblResultRow1.Name = "lblResultRow1"
		Me.lblResultRow1.Size = New System.Drawing.Size(83, 79)
		Me.lblResultRow1.TabIndex = 14
		Me.lblResultRow1.Text = "9"
		Me.lblResultRow1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lblResultRow1.Visible = False
		'
		'sprBtnCheck
		'
		Me.sprBtnCheck.BackColor = System.Drawing.Color.Transparent
		Me.sprBtnCheck.ForeColor = System.Drawing.SystemColors.ControlText
		Me.sprBtnCheck.Location = New System.Drawing.Point(517, 21)
		Me.sprBtnCheck.Name = "sprBtnCheck"
		Me.sprBtnCheck.Size = New System.Drawing.Size(64, 64)
		Me.sprBtnCheck.TabIndex = 15
		'
		'MagicSquareScreen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.utuujin.My.Resources.Resources.bg_magic_square
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Controls.Add(Me.sprBtnCheck)
		Me.Controls.Add(Me.lblResultRow1)
		Me.Controls.Add(Me.lblResultRow2)
		Me.Controls.Add(Me.lblResultRow3)
		Me.Controls.Add(Me.lblResultCol3)
		Me.Controls.Add(Me.lblResultCol2)
		Me.Controls.Add(Me.lblResultCol1)
		Me.Controls.Add(Me.lblGrid33)
		Me.Controls.Add(Me.lblGrid32)
		Me.Controls.Add(Me.lblGrid31)
		Me.Controls.Add(Me.lblGrid23)
		Me.Controls.Add(Me.lblGrid22)
		Me.Controls.Add(Me.lblGrid21)
		Me.Controls.Add(Me.lblGrid13)
		Me.Controls.Add(Me.lblGrid12)
		Me.Controls.Add(Me.lblGrid11)
		Me.DoubleBuffered = True
		Me.Name = "MagicSquareScreen"
		Me.Size = New System.Drawing.Size(600, 400)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents lblGrid11 As Label
	Friend WithEvents lblGrid12 As Label
	Friend WithEvents lblGrid13 As Label
	Friend WithEvents lblGrid23 As Label
	Friend WithEvents lblGrid22 As Label
	Friend WithEvents lblGrid21 As Label
	Friend WithEvents lblGrid33 As Label
	Friend WithEvents lblGrid32 As Label
	Friend WithEvents lblGrid31 As Label
	Friend WithEvents lblResultCol3 As Label
	Friend WithEvents lblResultCol2 As Label
	Friend WithEvents lblResultCol1 As Label
	Friend WithEvents lblResultRow3 As Label
	Friend WithEvents lblResultRow2 As Label
	Friend WithEvents lblResultRow1 As Label
	Friend WithEvents sprBtnCheck As SpriteBox
End Class
