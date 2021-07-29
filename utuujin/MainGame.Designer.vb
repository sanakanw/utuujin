<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainGame
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
		Me.components = New System.ComponentModel.Container()
		Me.m_gameScreen = New System.Windows.Forms.Panel()
		Me.m_gameLoop = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'm_gameScreen
		'
		Me.m_gameScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.m_gameScreen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.m_gameScreen.Location = New System.Drawing.Point(0, 0)
		Me.m_gameScreen.Name = "m_gameScreen"
		Me.m_gameScreen.Size = New System.Drawing.Size(800, 600)
		Me.m_gameScreen.TabIndex = 0
		'
		'm_gameLoop
		'
		Me.m_gameLoop.Enabled = True
		Me.m_gameLoop.Interval = 33
		'
		'm_mainGame
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.ClientSize = New System.Drawing.Size(800, 600)
		Me.Controls.Add(Me.m_gameScreen)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "m_mainGame"
		Me.Text = "Allan"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents m_gameScreen As Panel
    Friend WithEvents m_gameLoop As Timer
End Class
