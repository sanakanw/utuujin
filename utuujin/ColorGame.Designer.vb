<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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
		Me.CheckButton = New System.Windows.Forms.Button()
		Me.Ans1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button_Blue = New System.Windows.Forms.Button()
		Me.Button_Green = New System.Windows.Forms.Button()
		Me.Button_Yellow = New System.Windows.Forms.Button()
		Me.Button_Red = New System.Windows.Forms.Button()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Text_plus = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'CheckButton
		'
		Me.CheckButton.Location = New System.Drawing.Point(866, 245)
		Me.CheckButton.Name = "CheckButton"
		Me.CheckButton.Size = New System.Drawing.Size(86, 56)
		Me.CheckButton.TabIndex = 36
		Me.CheckButton.Text = "Check"
		Me.CheckButton.UseVisualStyleBackColor = True
		'
		'Ans1
		'
		Me.Ans1.BackColor = System.Drawing.Color.White
		Me.Ans1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Ans1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Ans1.ForeColor = System.Drawing.Color.Black
		Me.Ans1.Location = New System.Drawing.Point(720, 212)
		Me.Ans1.Name = "Ans1"
		Me.Ans1.Size = New System.Drawing.Size(130, 116)
		Me.Ans1.TabIndex = 35
		Me.Ans1.Text = "?"
		Me.Ans1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.White
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(468, 211)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(130, 116)
		Me.Label2.TabIndex = 34
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label1.Location = New System.Drawing.Point(176, 211)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(130, 116)
		Me.Label1.TabIndex = 33
		'
		'Button_Blue
		'
		Me.Button_Blue.BackColor = System.Drawing.Color.Blue
		Me.Button_Blue.Location = New System.Drawing.Point(223, 525)
		Me.Button_Blue.Name = "Button_Blue"
		Me.Button_Blue.Size = New System.Drawing.Size(101, 61)
		Me.Button_Blue.TabIndex = 40
		Me.Button_Blue.UseVisualStyleBackColor = False
		'
		'Button_Green
		'
		Me.Button_Green.BackColor = System.Drawing.Color.Lime
		Me.Button_Green.Location = New System.Drawing.Point(731, 525)
		Me.Button_Green.Name = "Button_Green"
		Me.Button_Green.Size = New System.Drawing.Size(101, 61)
		Me.Button_Green.TabIndex = 39
		Me.Button_Green.UseVisualStyleBackColor = False
		'
		'Button_Yellow
		'
		Me.Button_Yellow.BackColor = System.Drawing.Color.Yellow
		Me.Button_Yellow.Location = New System.Drawing.Point(564, 525)
		Me.Button_Yellow.Name = "Button_Yellow"
		Me.Button_Yellow.Size = New System.Drawing.Size(101, 61)
		Me.Button_Yellow.TabIndex = 38
		Me.Button_Yellow.UseVisualStyleBackColor = False
		'
		'Button_Red
		'
		Me.Button_Red.BackColor = System.Drawing.Color.Red
		Me.Button_Red.Location = New System.Drawing.Point(398, 525)
		Me.Button_Red.Name = "Button_Red"
		Me.Button_Red.Size = New System.Drawing.Size(101, 61)
		Me.Button_Red.TabIndex = 37
		Me.Button_Red.UseVisualStyleBackColor = False
		'
		'TextBox3
		'
		Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox3.Enabled = False
		Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox3.Location = New System.Drawing.Point(595, 234)
		Me.TextBox3.Multiline = True
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(130, 84)
		Me.TextBox3.TabIndex = 32
		Me.TextBox3.Text = "="
		Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Text_plus
		'
		Me.Text_plus.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Text_plus.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Text_plus.Enabled = False
		Me.Text_plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text_plus.Location = New System.Drawing.Point(322, 233)
		Me.Text_plus.Multiline = True
		Me.Text_plus.Name = "Text_plus"
		Me.Text_plus.Size = New System.Drawing.Size(130, 85)
		Me.Text_plus.TabIndex = 31
		Me.Text_plus.Text = "+"
		Me.Text_plus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1076, 613)
		Me.Controls.Add(Me.Button_Blue)
		Me.Controls.Add(Me.Button_Green)
		Me.Controls.Add(Me.Button_Yellow)
		Me.Controls.Add(Me.Button_Red)
		Me.Controls.Add(Me.CheckButton)
		Me.Controls.Add(Me.Ans1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.Text_plus)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Colour Recognition"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents CheckButton As Button
	Friend WithEvents Ans1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Button_Blue As Button
	Friend WithEvents Button_Green As Button
	Friend WithEvents Button_Yellow As Button
	Friend WithEvents Button_Red As Button
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Text_plus As TextBox
End Class
