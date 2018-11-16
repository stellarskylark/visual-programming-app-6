<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Title
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblDollar1 = New System.Windows.Forms.Label()
        Me.lblDollar2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 13.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(260, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Who Wants to be a Millionaire?"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Bookman Old Style", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnPlay.Location = New System.Drawing.Point(81, 58)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(130, 30)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Font = New System.Drawing.Font("Bookman Old Style", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnSettings.Location = New System.Drawing.Point(81, 130)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(130, 30)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Bookman Old Style", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnAbout.Location = New System.Drawing.Point(81, 166)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(130, 30)
        Me.btnAbout.TabIndex = 4
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnCustom
        '
        Me.btnCustom.Font = New System.Drawing.Font("Bookman Old Style", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustom.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnCustom.Location = New System.Drawing.Point(81, 94)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(130, 30)
        Me.btnCustom.TabIndex = 5
        Me.btnCustom.Text = "Custom"
        Me.btnCustom.UseVisualStyleBackColor = True
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Monotype Corsiva", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblCopyright.Location = New System.Drawing.Point(12, 239)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(173, 14)
        Me.lblCopyright.TabIndex = 6
        Me.lblCopyright.Text = "Oklahoma Baptist University - © 2018"
        '
        'lblDollar1
        '
        Me.lblDollar1.Font = New System.Drawing.Font("Modern No. 20", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblDollar1.ForeColor = System.Drawing.Color.Gold
        Me.lblDollar1.Location = New System.Drawing.Point(216, 58)
        Me.lblDollar1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDollar1.Name = "lblDollar1"
        Me.lblDollar1.Size = New System.Drawing.Size(52, 52)
        Me.lblDollar1.TabIndex = 7
        Me.lblDollar1.Text = "$"
        '
        'lblDollar2
        '
        Me.lblDollar2.Font = New System.Drawing.Font("Modern No. 20", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblDollar2.ForeColor = System.Drawing.Color.Gold
        Me.lblDollar2.Location = New System.Drawing.Point(24, 58)
        Me.lblDollar2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDollar2.Name = "lblDollar2"
        Me.lblDollar2.Size = New System.Drawing.Size(52, 52)
        Me.lblDollar2.TabIndex = 8
        Me.lblDollar2.Text = "$"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Title
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblDollar2)
        Me.Controls.Add(Me.lblDollar1)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.btnCustom)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Title"
        Me.Text = "Title Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnCustom As Button
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblDollar1 As Label
    Friend WithEvents lblDollar2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
