<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WordGameScreen
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
		Me.panelSentence = New System.Windows.Forms.Panel()
		Me.lblProgress = New System.Windows.Forms.Label()
		Me.panelLetterConnect = New System.Windows.Forms.Panel()
		Me.lblLetter16 = New System.Windows.Forms.Label()
		Me.lblLetter14 = New System.Windows.Forms.Label()
		Me.lblLetter13 = New System.Windows.Forms.Label()
		Me.lblLetter15 = New System.Windows.Forms.Label()
		Me.lblLetter12 = New System.Windows.Forms.Label()
		Me.lblLetter11 = New System.Windows.Forms.Label()
		Me.lblLetter10 = New System.Windows.Forms.Label()
		Me.lblLetter9 = New System.Windows.Forms.Label()
		Me.lblLetter8 = New System.Windows.Forms.Label()
		Me.lblLetter7 = New System.Windows.Forms.Label()
		Me.lblLetter6 = New System.Windows.Forms.Label()
		Me.lblLetter5 = New System.Windows.Forms.Label()
		Me.lblLetter4 = New System.Windows.Forms.Label()
		Me.lblLetter3 = New System.Windows.Forms.Label()
		Me.lblLetter2 = New System.Windows.Forms.Label()
		Me.lblLetter1 = New System.Windows.Forms.Label()
		Me.panelSentence.SuspendLayout()
		Me.panelLetterConnect.SuspendLayout()
		Me.SuspendLayout()
		'
		'panelSentence
		'
		Me.panelSentence.BackgroundImage = Global.utuujin.My.Resources.Resources.png_btn_shape_backdrop
		Me.panelSentence.Controls.Add(Me.lblProgress)
		Me.panelSentence.Location = New System.Drawing.Point(0, 300)
		Me.panelSentence.Name = "panelSentence"
		Me.panelSentence.Size = New System.Drawing.Size(600, 100)
		Me.panelSentence.TabIndex = 1
		'
		'lblProgress
		'
		Me.lblProgress.BackColor = System.Drawing.Color.Transparent
		Me.lblProgress.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProgress.ForeColor = System.Drawing.Color.Snow
		Me.lblProgress.Location = New System.Drawing.Point(27, 18)
		Me.lblProgress.Name = "lblProgress"
		Me.lblProgress.Size = New System.Drawing.Size(561, 48)
		Me.lblProgress.TabIndex = 18
		Me.lblProgress.Text = "Sample Text"
		Me.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'panelLetterConnect
		'
		Me.panelLetterConnect.BackgroundImage = Global.utuujin.My.Resources.Resources.bg_space
		Me.panelLetterConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.panelLetterConnect.Controls.Add(Me.lblLetter16)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter14)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter13)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter15)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter12)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter11)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter10)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter9)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter8)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter7)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter6)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter5)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter4)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter3)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter2)
		Me.panelLetterConnect.Controls.Add(Me.lblLetter1)
		Me.panelLetterConnect.Location = New System.Drawing.Point(0, 0)
		Me.panelLetterConnect.Name = "panelLetterConnect"
		Me.panelLetterConnect.Size = New System.Drawing.Size(600, 300)
		Me.panelLetterConnect.TabIndex = 0
		'
		'lblLetter16
		'
		Me.lblLetter16.AutoSize = True
		Me.lblLetter16.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter16.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter16.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter16.Location = New System.Drawing.Point(418, 65)
		Me.lblLetter16.Name = "lblLetter16"
		Me.lblLetter16.Size = New System.Drawing.Size(30, 33)
		Me.lblLetter16.TabIndex = 17
		Me.lblLetter16.Text = "E"
		Me.lblLetter16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter14
		'
		Me.lblLetter14.AutoSize = True
		Me.lblLetter14.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter14.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter14.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter14.Location = New System.Drawing.Point(503, 75)
		Me.lblLetter14.Name = "lblLetter14"
		Me.lblLetter14.Size = New System.Drawing.Size(31, 33)
		Me.lblLetter14.TabIndex = 16
		Me.lblLetter14.Text = "O"
		Me.lblLetter14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter13
		'
		Me.lblLetter13.AutoSize = True
		Me.lblLetter13.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter13.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter13.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter13.Location = New System.Drawing.Point(395, 119)
		Me.lblLetter13.Name = "lblLetter13"
		Me.lblLetter13.Size = New System.Drawing.Size(31, 33)
		Me.lblLetter13.TabIndex = 15
		Me.lblLetter13.Text = "H"
		Me.lblLetter13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter15
		'
		Me.lblLetter15.AutoSize = True
		Me.lblLetter15.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter15.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter15.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter15.Location = New System.Drawing.Point(398, 16)
		Me.lblLetter15.Name = "lblLetter15"
		Me.lblLetter15.Size = New System.Drawing.Size(35, 33)
		Me.lblLetter15.TabIndex = 14
		Me.lblLetter15.Text = "M"
		Me.lblLetter15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter12
		'
		Me.lblLetter12.AutoSize = True
		Me.lblLetter12.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter12.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter12.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter12.Location = New System.Drawing.Point(265, 259)
		Me.lblLetter12.Name = "lblLetter12"
		Me.lblLetter12.Size = New System.Drawing.Size(29, 33)
		Me.lblLetter12.TabIndex = 13
		Me.lblLetter12.Text = "Y"
		Me.lblLetter12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter11
		'
		Me.lblLetter11.AutoSize = True
		Me.lblLetter11.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter11.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter11.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter11.Location = New System.Drawing.Point(195, 178)
		Me.lblLetter11.Name = "lblLetter11"
		Me.lblLetter11.Size = New System.Drawing.Size(32, 33)
		Me.lblLetter11.TabIndex = 12
		Me.lblLetter11.Text = "A"
		Me.lblLetter11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter10
		'
		Me.lblLetter10.AutoSize = True
		Me.lblLetter10.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter10.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter10.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter10.Location = New System.Drawing.Point(145, 230)
		Me.lblLetter10.Name = "lblLetter10"
		Me.lblLetter10.Size = New System.Drawing.Size(35, 33)
		Me.lblLetter10.TabIndex = 11
		Me.lblLetter10.Text = "W"
		Me.lblLetter10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter9
		'
		Me.lblLetter9.AutoSize = True
		Me.lblLetter9.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter9.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter9.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter9.Location = New System.Drawing.Point(384, 214)
		Me.lblLetter9.Name = "lblLetter9"
		Me.lblLetter9.Size = New System.Drawing.Size(30, 33)
		Me.lblLetter9.TabIndex = 10
		Me.lblLetter9.Text = "E"
		Me.lblLetter9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter8
		'
		Me.lblLetter8.AutoSize = True
		Me.lblLetter8.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter8.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter8.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter8.Location = New System.Drawing.Point(461, 180)
		Me.lblLetter8.Name = "lblLetter8"
		Me.lblLetter8.Size = New System.Drawing.Size(31, 33)
		Me.lblLetter8.TabIndex = 9
		Me.lblLetter8.Text = "H"
		Me.lblLetter8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter7
		'
		Me.lblLetter7.AutoSize = True
		Me.lblLetter7.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter7.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter7.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter7.Location = New System.Drawing.Point(428, 236)
		Me.lblLetter7.Name = "lblLetter7"
		Me.lblLetter7.Size = New System.Drawing.Size(29, 33)
		Me.lblLetter7.TabIndex = 8
		Me.lblLetter7.Text = "T"
		Me.lblLetter7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter6
		'
		Me.lblLetter6.AutoSize = True
		Me.lblLetter6.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter6.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter6.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter6.Location = New System.Drawing.Point(243, 91)
		Me.lblLetter6.Name = "lblLetter6"
		Me.lblLetter6.Size = New System.Drawing.Size(27, 33)
		Me.lblLetter6.TabIndex = 7
		Me.lblLetter6.Text = "S"
		Me.lblLetter6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter5
		'
		Me.lblLetter5.AutoSize = True
		Me.lblLetter5.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter5.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter5.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter5.Location = New System.Drawing.Point(293, 37)
		Me.lblLetter5.Name = "lblLetter5"
		Me.lblLetter5.Size = New System.Drawing.Size(21, 33)
		Me.lblLetter5.TabIndex = 6
		Me.lblLetter5.Text = "I"
		Me.lblLetter5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter4
		'
		Me.lblLetter4.AutoSize = True
		Me.lblLetter4.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter4.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter4.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter4.Location = New System.Drawing.Point(29, 117)
		Me.lblLetter4.Name = "lblLetter4"
		Me.lblLetter4.Size = New System.Drawing.Size(27, 33)
		Me.lblLetter4.TabIndex = 5
		Me.lblLetter4.Text = "S"
		Me.lblLetter4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter3
		'
		Me.lblLetter3.AutoSize = True
		Me.lblLetter3.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter3.Font = New System.Drawing.Font("Segoe Script", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter3.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter3.Location = New System.Drawing.Point(133, 34)
		Me.lblLetter3.Name = "lblLetter3"
		Me.lblLetter3.Size = New System.Drawing.Size(24, 40)
		Me.lblLetter3.TabIndex = 4
		Me.lblLetter3.Text = "I"
		Me.lblLetter3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter2
		'
		Me.lblLetter2.AutoSize = True
		Me.lblLetter2.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter2.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter2.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter2.Location = New System.Drawing.Point(113, 137)
		Me.lblLetter2.Name = "lblLetter2"
		Me.lblLetter2.Size = New System.Drawing.Size(31, 33)
		Me.lblLetter2.TabIndex = 3
		Me.lblLetter2.Text = "H"
		Me.lblLetter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblLetter1
		'
		Me.lblLetter1.AutoSize = True
		Me.lblLetter1.BackColor = System.Drawing.Color.Transparent
		Me.lblLetter1.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.lblLetter1.ForeColor = System.Drawing.Color.Snow
		Me.lblLetter1.Location = New System.Drawing.Point(48, 43)
		Me.lblLetter1.Name = "lblLetter1"
		Me.lblLetter1.Size = New System.Drawing.Size(29, 33)
		Me.lblLetter1.TabIndex = 2
		Me.lblLetter1.Text = "T"
		Me.lblLetter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'WordGameScreen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.panelSentence)
		Me.Controls.Add(Me.panelLetterConnect)
		Me.Name = "WordGameScreen"
		Me.Size = New System.Drawing.Size(600, 400)
		Me.panelSentence.ResumeLayout(False)
		Me.panelLetterConnect.ResumeLayout(False)
		Me.panelLetterConnect.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents panelLetterConnect As Panel
	Friend WithEvents panelSentence As Panel
	Friend WithEvents lblLetter1 As Label
	Friend WithEvents lblLetter4 As Label
	Friend WithEvents lblLetter3 As Label
	Friend WithEvents lblLetter2 As Label
	Friend WithEvents lblProgress As Label
	Friend WithEvents lblLetter16 As Label
	Friend WithEvents lblLetter14 As Label
	Friend WithEvents lblLetter13 As Label
	Friend WithEvents lblLetter15 As Label
	Friend WithEvents lblLetter12 As Label
	Friend WithEvents lblLetter11 As Label
	Friend WithEvents lblLetter10 As Label
	Friend WithEvents lblLetter9 As Label
	Friend WithEvents lblLetter8 As Label
	Friend WithEvents lblLetter7 As Label
	Friend WithEvents lblLetter6 As Label
	Friend WithEvents lblLetter5 As Label
End Class
