<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.ProjectLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.GameDescription = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ProjectLabel
        '
        Me.ProjectLabel.AutoSize = True
        Me.ProjectLabel.Location = New System.Drawing.Point(167, 30)
        Me.ProjectLabel.Name = "ProjectLabel"
        Me.ProjectLabel.Size = New System.Drawing.Size(49, 17)
        Me.ProjectLabel.TabIndex = 0
        Me.ProjectLabel.Text = "About:"
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(167, 77)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(96, 17)
        Me.VersionLabel.TabIndex = 1
        Me.VersionLabel.Text = "Version: 0.0.1"
        '
        'GameDescription
        '
        Me.GameDescription.Location = New System.Drawing.Point(30, 120)
        Me.GameDescription.Multiline = True
        Me.GameDescription.Name = "GameDescription"
        Me.GameDescription.Size = New System.Drawing.Size(320, 172)
        Me.GameDescription.TabIndex = 2
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 344)
        Me.Controls.Add(Me.GameDescription)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.ProjectLabel)
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProjectLabel As Label
    Friend WithEvents VersionLabel As Label
    Friend WithEvents GameDescription As TextBox
End Class
