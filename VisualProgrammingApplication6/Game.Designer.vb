<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAnswer3 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer1 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer4 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer2 = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnHelpAdd = New System.Windows.Forms.Button()
        Me.btnHelpStop = New System.Windows.Forms.Button()
        Me.btnHelp50 = New System.Windows.Forms.Button()
        Me.btnHelpShow = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(84, 13)
        Me.lblTitle.TabIndex = 47
        Me.lblTitle.Text = "Millionaire Game"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(266, 384)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 46
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(12, 35)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(19, 13)
        Me.lblScore.TabIndex = 38
        Me.lblScore.Text = "$0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAnswer3)
        Me.GroupBox2.Controls.Add(Me.btnAnswer1)
        Me.GroupBox2.Controls.Add(Me.btnAnswer4)
        Me.GroupBox2.Controls.Add(Me.btnAnswer2)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 118)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'btnAnswer3
        '
        Me.btnAnswer3.AutoSize = True
        Me.btnAnswer3.Location = New System.Drawing.Point(12, 88)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(49, 17)
        Me.btnAnswer3.TabIndex = 19
        Me.btnAnswer3.TabStop = True
        Me.btnAnswer3.Text = "Pluto"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer1
        '
        Me.btnAnswer1.AutoSize = True
        Me.btnAnswer1.Location = New System.Drawing.Point(12, 19)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(63, 17)
        Me.btnAnswer1.TabIndex = 17
        Me.btnAnswer1.TabStop = True
        Me.btnAnswer1.Text = "Mercury"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'btnAnswer4
        '
        Me.btnAnswer4.AutoSize = True
        Me.btnAnswer4.Location = New System.Drawing.Point(12, 65)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(56, 17)
        Me.btnAnswer4.TabIndex = 20
        Me.btnAnswer4.TabStop = True
        Me.btnAnswer4.Text = "Saturn"
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.AutoSize = True
        Me.btnAnswer2.Location = New System.Drawing.Point(12, 42)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(55, 17)
        Me.btnAnswer2.TabIndex = 18
        Me.btnAnswer2.TabStop = True
        Me.btnAnswer2.Text = "Venus"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(15, 384)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 45
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.White
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuestion.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblQuestion.Location = New System.Drawing.Point(15, 61)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(326, 100)
        Me.lblQuestion.TabIndex = 44
        Me.lblQuestion.Text = "Which planet is closest to the Sun?"
        '
        'btnHelpAdd
        '
        Me.btnHelpAdd.BackColor = System.Drawing.Color.Blue
        Me.btnHelpAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelpAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelpAdd.ForeColor = System.Drawing.Color.Yellow
        Me.btnHelpAdd.Location = New System.Drawing.Point(181, 212)
        Me.btnHelpAdd.Name = "btnHelpAdd"
        Me.btnHelpAdd.Size = New System.Drawing.Size(160, 42)
        Me.btnHelpAdd.TabIndex = 43
        Me.btnHelpAdd.Text = "Add Time"
        Me.btnHelpAdd.UseVisualStyleBackColor = False
        '
        'btnHelpStop
        '
        Me.btnHelpStop.BackColor = System.Drawing.Color.Blue
        Me.btnHelpStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelpStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelpStop.ForeColor = System.Drawing.Color.Yellow
        Me.btnHelpStop.Location = New System.Drawing.Point(15, 212)
        Me.btnHelpStop.Name = "btnHelpStop"
        Me.btnHelpStop.Size = New System.Drawing.Size(160, 42)
        Me.btnHelpStop.TabIndex = 42
        Me.btnHelpStop.Text = "Stop Time"
        Me.btnHelpStop.UseVisualStyleBackColor = False
        '
        'btnHelp50
        '
        Me.btnHelp50.BackColor = System.Drawing.Color.Blue
        Me.btnHelp50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp50.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp50.ForeColor = System.Drawing.Color.Yellow
        Me.btnHelp50.Location = New System.Drawing.Point(181, 164)
        Me.btnHelp50.Name = "btnHelp50"
        Me.btnHelp50.Size = New System.Drawing.Size(160, 42)
        Me.btnHelp50.TabIndex = 40
        Me.btnHelp50.Text = "50/50"
        Me.btnHelp50.UseVisualStyleBackColor = False
        '
        'btnHelpShow
        '
        Me.btnHelpShow.BackColor = System.Drawing.Color.Blue
        Me.btnHelpShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelpShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelpShow.ForeColor = System.Drawing.Color.Yellow
        Me.btnHelpShow.Location = New System.Drawing.Point(15, 164)
        Me.btnHelpShow.Name = "btnHelpShow"
        Me.btnHelpShow.Size = New System.Drawing.Size(160, 42)
        Me.btnHelpShow.TabIndex = 39
        Me.btnHelpShow.Text = "Show Answer"
        Me.btnHelpShow.UseVisualStyleBackColor = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(236, 9)
        Me.lblTimer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(105, 39)
        Me.lblTimer.TabIndex = 48
        Me.lblTimer.Text = "00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 417)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnHelpAdd)
        Me.Controls.Add(Me.btnHelpStop)
        Me.Controls.Add(Me.btnHelp50)
        Me.Controls.Add(Me.btnHelpShow)
        Me.Name = "Game"
        Me.Text = "Who Wants to Be a Millionaire?"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
	Friend WithEvents btnQuit As Button
	Friend WithEvents lblScore As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents btnAnswer3 As RadioButton
	Friend WithEvents btnAnswer1 As RadioButton
	Friend WithEvents btnAnswer4 As RadioButton
	Friend WithEvents btnAnswer2 As RadioButton
	Friend WithEvents btnConfirm As Button
	Friend WithEvents lblQuestion As Label
	Friend WithEvents btnHelpAdd As Button
	Friend WithEvents btnHelpStop As Button
	Friend WithEvents btnHelp50 As Button
	Friend WithEvents btnHelpShow As Button
	Friend WithEvents lblTimer As Label
    Friend WithEvents Timer1 As Timer
End Class
