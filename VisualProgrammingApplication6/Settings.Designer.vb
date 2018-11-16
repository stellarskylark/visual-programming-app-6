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
        Me.lblDiifficulty.Location = New System.Drawing.Point(12, 9)
        Me.lblDiifficulty.Name = "lblDiifficulty"
        Me.lblDiifficulty.Size = New System.Drawing.Size(63, 15)
        Me.lblDiifficulty.TabIndex = 0
        Me.lblDiifficulty.Text = "Difficulty:"
        '
        'cboDifficulty
        '
        Me.cboDifficulty.DisplayMember = "Easy"
        Me.cboDifficulty.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDifficulty.FormattingEnabled = True
        Me.cboDifficulty.Items.AddRange(New Object() {"Easy", "Medium", "Hard", "Extreme"})
        Me.cboDifficulty.Location = New System.Drawing.Point(105, 8)
        Me.cboDifficulty.Name = "cboDifficulty"
        Me.cboDifficulty.Size = New System.Drawing.Size(135, 22)
        Me.cboDifficulty.TabIndex = 5
        '
        'cboQuestionSet
        '
        Me.cboQuestionSet.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuestionSet.FormattingEnabled = True
        Me.cboQuestionSet.Items.AddRange(New Object() {"All", "History", "Science", "Pop Culture", "Custom"})
        Me.cboQuestionSet.Location = New System.Drawing.Point(105, 40)
        Me.cboQuestionSet.Name = "cboQuestionSet"
        Me.cboQuestionSet.Size = New System.Drawing.Size(135, 22)
        Me.cboQuestionSet.TabIndex = 6
        '
        'lblQuestionSet
        '
        Me.lblQuestionSet.AutoSize = True
        Me.lblQuestionSet.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionSet.Location = New System.Drawing.Point(12, 41)
        Me.lblQuestionSet.Name = "lblQuestionSet"
        Me.lblQuestionSet.Size = New System.Drawing.Size(82, 15)
        Me.lblQuestionSet.TabIndex = 7
        Me.lblQuestionSet.Text = "Question Set:"
        '
        'btnClearLeaderboard
        '
        Me.btnClearLeaderboard.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearLeaderboard.Location = New System.Drawing.Point(12, 183)
        Me.btnClearLeaderboard.Name = "btnClearLeaderboard"
        Me.btnClearLeaderboard.Size = New System.Drawing.Size(105, 23)
        Me.btnClearLeaderboard.TabIndex = 8
        Me.btnClearLeaderboard.Text = "Clear Leaderboard"
        Me.btnClearLeaderboard.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(12, 73)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(48, 15)
        Me.lblTimer.TabIndex = 10
        Me.lblTimer.Text = "Timer: "
        '
        'numTimer
        '
        Me.numTimer.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTimer.Location = New System.Drawing.Point(105, 69)
        Me.numTimer.Name = "numTimer"
        Me.numTimer.Size = New System.Drawing.Size(49, 20)
        Me.numTimer.TabIndex = 11
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(160, 73)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(56, 15)
        Me.lblSeconds.TabIndex = 12
        Me.lblSeconds.Text = "seconds."
        '
        'btnClearCustomSets
        '
        Me.btnClearCustomSets.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearCustomSets.Location = New System.Drawing.Point(12, 154)
        Me.btnClearCustomSets.Name = "btnClearCustomSets"
        Me.btnClearCustomSets.Size = New System.Drawing.Size(105, 23)
        Me.btnClearCustomSets.TabIndex = 13
        Me.btnClearCustomSets.Text = "Clear Custom Sets"
        Me.btnClearCustomSets.UseVisualStyleBackColor = True
        '
        'lblQuestionNum
        '
        Me.lblQuestionNum.AutoSize = True
        Me.lblQuestionNum.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNum.Location = New System.Drawing.Point(12, 104)
        Me.lblQuestionNum.Name = "lblQuestionNum"
        Me.lblQuestionNum.Size = New System.Drawing.Size(135, 15)
        Me.lblQuestionNum.TabIndex = 14
        Me.lblQuestionNum.Text = "Number Of Questions: "
        '
        'cboQuestionNum
        '
        Me.cboQuestionNum.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuestionNum.FormattingEnabled = True
        Me.cboQuestionNum.Items.AddRange(New Object() {"15", "30", "45", "60", "80", "100"})
        Me.cboQuestionNum.Location = New System.Drawing.Point(159, 104)
        Me.cboQuestionNum.Name = "cboQuestionNum"
        Me.cboQuestionNum.Size = New System.Drawing.Size(135, 22)
        Me.cboQuestionNum.TabIndex = 15
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.Location = New System.Drawing.Point(254, 174)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(102, 32)
        Me.btnSaveChanges.TabIndex = 16
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 218)
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
