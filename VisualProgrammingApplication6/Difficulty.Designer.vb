<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Difficulty
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
        Me.ButtonEasy = New System.Windows.Forms.Button()
        Me.ButtonMedium = New System.Windows.Forms.Button()
        Me.ButtonHard = New System.Windows.Forms.Button()
        Me.ButtonExtreme = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonEasy
        '
        Me.ButtonEasy.BackgroundImage = Global.VisualProgrammingApplication6.My.Resources.Resources.GoldDollarSign
        Me.ButtonEasy.Image = Global.VisualProgrammingApplication6.My.Resources.Resources.GoldDollarSign
        Me.ButtonEasy.Location = New System.Drawing.Point(129, 57)
        Me.ButtonEasy.Name = "ButtonEasy"
        Me.ButtonEasy.Size = New System.Drawing.Size(95, 23)
        Me.ButtonEasy.TabIndex = 0
        Me.ButtonEasy.Text = "Easy"
        Me.ButtonEasy.UseVisualStyleBackColor = True
        '
        'ButtonMedium
        '
        Me.ButtonMedium.Image = Global.VisualProgrammingApplication6.My.Resources.Resources.GoldDollarSign
        Me.ButtonMedium.Location = New System.Drawing.Point(129, 115)
        Me.ButtonMedium.Name = "ButtonMedium"
        Me.ButtonMedium.Size = New System.Drawing.Size(95, 23)
        Me.ButtonMedium.TabIndex = 1
        Me.ButtonMedium.Text = "Medium"
        Me.ButtonMedium.UseVisualStyleBackColor = True
        '
        'ButtonHard
        '
        Me.ButtonHard.Image = Global.VisualProgrammingApplication6.My.Resources.Resources.GoldDollarSign
        Me.ButtonHard.Location = New System.Drawing.Point(129, 175)
        Me.ButtonHard.Name = "ButtonHard"
        Me.ButtonHard.Size = New System.Drawing.Size(95, 23)
        Me.ButtonHard.TabIndex = 2
        Me.ButtonHard.Text = "Hard"
        Me.ButtonHard.UseVisualStyleBackColor = True
        '
        'ButtonExtreme
        '
        Me.ButtonExtreme.Image = Global.VisualProgrammingApplication6.My.Resources.Resources.GoldDollarSign
        Me.ButtonExtreme.Location = New System.Drawing.Point(129, 237)
        Me.ButtonExtreme.Name = "ButtonExtreme"
        Me.ButtonExtreme.Size = New System.Drawing.Size(95, 23)
        Me.ButtonExtreme.TabIndex = 3
        Me.ButtonExtreme.Text = "Extreme"
        Me.ButtonExtreme.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(106, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Chose Your Difficulty!"
        '
        'Difficulty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 288)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonExtreme)
        Me.Controls.Add(Me.ButtonHard)
        Me.Controls.Add(Me.ButtonMedium)
        Me.Controls.Add(Me.ButtonEasy)
        Me.Name = "Difficulty"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEasy As Button
    Friend WithEvents ButtonMedium As Button
    Friend WithEvents ButtonHard As Button
    Friend WithEvents ButtonExtreme As Button
    Friend WithEvents Label1 As Label
End Class
