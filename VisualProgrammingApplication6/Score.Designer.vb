<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Score
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
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.lblOutOf = New System.Windows.Forms.Label()
        Me.lblAsked = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Monotype Corsiva", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(12, 324)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(163, 13)
        Me.lblCopyright.TabIndex = 7
        Me.lblCopyright.Text = "Oklahoma Baptist University - © 2018"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 25.0!, System.Drawing.FontStyle.Italic)
        Me.lblTitle.Location = New System.Drawing.Point(64, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(82, 41)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Score"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(12, 274)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(214, 23)
        Me.btnPlay.TabIndex = 9
        Me.btnPlay.Text = "Title Screen"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.Font = New System.Drawing.Font("Monotype Corsiva", 15.0!, System.Drawing.FontStyle.Italic)
        Me.lblCorrect.Location = New System.Drawing.Point(12, 147)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(59, 24)
        Me.lblCorrect.TabIndex = 10
        Me.lblCorrect.Text = "Label1"
        '
        'lblOutOf
        '
        Me.lblOutOf.AutoSize = True
        Me.lblOutOf.Font = New System.Drawing.Font("Monotype Corsiva", 15.0!, System.Drawing.FontStyle.Italic)
        Me.lblOutOf.Location = New System.Drawing.Point(77, 147)
        Me.lblOutOf.Name = "lblOutOf"
        Me.lblOutOf.Size = New System.Drawing.Size(59, 24)
        Me.lblOutOf.TabIndex = 11
        Me.lblOutOf.Text = "Out of "
        '
        'lblAsked
        '
        Me.lblAsked.AutoSize = True
        Me.lblAsked.Font = New System.Drawing.Font("Monotype Corsiva", 15.0!, System.Drawing.FontStyle.Italic)
        Me.lblAsked.Location = New System.Drawing.Point(142, 147)
        Me.lblAsked.Name = "lblAsked"
        Me.lblAsked.Size = New System.Drawing.Size(59, 24)
        Me.lblAsked.TabIndex = 12
        Me.lblAsked.Text = "Label1"
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 346)
        Me.Controls.Add(Me.lblAsked)
        Me.Controls.Add(Me.lblOutOf)
        Me.Controls.Add(Me.lblCorrect)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblCopyright)
        Me.Name = "Score"
        Me.Text = "Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents lblCorrect As Label
    Friend WithEvents lblOutOf As Label
    Friend WithEvents lblAsked As Label
End Class
