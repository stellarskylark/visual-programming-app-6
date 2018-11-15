<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.lblDiifficulty = New System.Windows.Forms.Label()
        Me.cboDifficulty = New System.Windows.Forms.ComboBox()
        Me.cboQuestionSet = New System.Windows.Forms.ComboBox()
        Me.lblQuestionSet = New System.Windows.Forms.Label()
        Me.btnClearLeaderboard = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.numTimer = New System.Windows.Forms.NumericUpDown()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.btnClearCustomSets = New System.Windows.Forms.Button()
        Me.lblQuestionNum = New System.Windows.Forms.Label()
        Me.cboQuestionNum = New System.Windows.Forms.ComboBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        CType(Me.numTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDiifficulty
        '
        Me.lblDiifficulty.AutoSize = True
        Me.lblDiifficulty.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiifficulty.Location = New System.Drawing.Point(16, 11)
        Me.lblDiifficulty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiifficulty.Name = "lblDiifficulty"
        Me.lblDiifficulty.Size = New System.Drawing.Size(78, 19)
        Me.lblDiifficulty.TabIndex = 0
        Me.lblDiifficulty.Text = "Difficulty:"
        '
        'cboDifficulty
        '
        Me.cboDifficulty.DisplayMember = "Easy"
        Me.cboDifficulty.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDifficulty.FormattingEnabled = True
        Me.cboDifficulty.Items.AddRange(New Object() {"Easy", "Medium", "Hard", "Extreme"})
        Me.cboDifficulty.Location = New System.Drawing.Point(140, 10)
        Me.cboDifficulty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboDifficulty.Name = "cboDifficulty"
        Me.cboDifficulty.Size = New System.Drawing.Size(179, 26)
        Me.cboDifficulty.TabIndex = 5
        '
        'cboQuestionSet
        '
        Me.cboQuestionSet.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuestionSet.FormattingEnabled = True
        Me.cboQuestionSet.Items.AddRange(New Object() {"All", "History", "Science", "Pop Culture", "Custom"})
        Me.cboQuestionSet.Location = New System.Drawing.Point(140, 49)
        Me.cboQuestionSet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboQuestionSet.Name = "cboQuestionSet"
        Me.cboQuestionSet.Size = New System.Drawing.Size(179, 26)
        Me.cboQuestionSet.TabIndex = 6
        '
        'lblQuestionSet
        '
        Me.lblQuestionSet.AutoSize = True
        Me.lblQuestionSet.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionSet.Location = New System.Drawing.Point(16, 50)
        Me.lblQuestionSet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestionSet.Name = "lblQuestionSet"
        Me.lblQuestionSet.Size = New System.Drawing.Size(103, 19)
        Me.lblQuestionSet.TabIndex = 7
        Me.lblQuestionSet.Text = "Question Set:"
        '
        'btnClearLeaderboard
        '
        Me.btnClearLeaderboard.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearLeaderboard.Location = New System.Drawing.Point(16, 225)
        Me.btnClearLeaderboard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClearLeaderboard.Name = "btnClearLeaderboard"
        Me.btnClearLeaderboard.Size = New System.Drawing.Size(140, 28)
        Me.btnClearLeaderboard.TabIndex = 8
        Me.btnClearLeaderboard.Text = "Clear Leaderboard"
        Me.btnClearLeaderboard.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(16, 90)
        Me.lblTimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(58, 19)
        Me.lblTimer.TabIndex = 10
        Me.lblTimer.Text = "Timer: "
        '
        'numTimer
        '
        Me.numTimer.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTimer.Location = New System.Drawing.Point(140, 85)
        Me.numTimer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numTimer.Name = "numTimer"
        Me.numTimer.Size = New System.Drawing.Size(65, 23)
        Me.numTimer.TabIndex = 11
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(213, 90)
        Me.lblSeconds.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(70, 19)
        Me.lblSeconds.TabIndex = 12
        Me.lblSeconds.Text = "seconds."
        '
        'btnClearCustomSets
        '
        Me.btnClearCustomSets.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearCustomSets.Location = New System.Drawing.Point(16, 190)
        Me.btnClearCustomSets.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClearCustomSets.Name = "btnClearCustomSets"
        Me.btnClearCustomSets.Size = New System.Drawing.Size(140, 28)
        Me.btnClearCustomSets.TabIndex = 13
        Me.btnClearCustomSets.Text = "Clear Custom Sets"
        Me.btnClearCustomSets.UseVisualStyleBackColor = True
        '
        'lblQuestionNum
        '
        Me.lblQuestionNum.AutoSize = True
        Me.lblQuestionNum.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNum.Location = New System.Drawing.Point(16, 128)
        Me.lblQuestionNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestionNum.Name = "lblQuestionNum"
        Me.lblQuestionNum.Size = New System.Drawing.Size(166, 19)
        Me.lblQuestionNum.TabIndex = 14
        Me.lblQuestionNum.Text = "Number Of Questions: "
        '
        'cboQuestionNum
        '
        Me.cboQuestionNum.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuestionNum.FormattingEnabled = True
        Me.cboQuestionNum.Items.AddRange(New Object() {"15", "30", "45", "60", "80", "100"})
        Me.cboQuestionNum.Location = New System.Drawing.Point(212, 128)
        Me.cboQuestionNum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboQuestionNum.Name = "cboQuestionNum"
        Me.cboQuestionNum.Size = New System.Drawing.Size(179, 26)
        Me.cboQuestionNum.TabIndex = 15
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.Location = New System.Drawing.Point(339, 214)
        Me.btnSaveChanges.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(136, 39)
        Me.btnSaveChanges.TabIndex = 16
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 268)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.cboQuestionNum)
        Me.Controls.Add(Me.lblQuestionNum)
        Me.Controls.Add(Me.btnClearCustomSets)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.numTimer)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnClearLeaderboard)
        Me.Controls.Add(Me.lblQuestionSet)
        Me.Controls.Add(Me.cboQuestionSet)
        Me.Controls.Add(Me.cboDifficulty)
        Me.Controls.Add(Me.lblDiifficulty)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Settings"
        Me.Text = "Settings"
        CType(Me.numTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDiifficulty As Label
    Friend WithEvents cboDifficulty As ComboBox
    Friend WithEvents cboQuestionSet As ComboBox
    Friend WithEvents lblQuestionSet As Label
    Friend WithEvents btnClearLeaderboard As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents numTimer As NumericUpDown
    Friend WithEvents lblSeconds As Label
    Friend WithEvents btnClearCustomSets As Button
    Friend WithEvents lblQuestionNum As Label
    Friend WithEvents cboQuestionNum As ComboBox
    Friend WithEvents btnSaveChanges As Button
End Class
