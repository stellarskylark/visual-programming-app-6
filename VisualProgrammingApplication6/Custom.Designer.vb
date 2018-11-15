<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Custom
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblCorrectAnswer = New System.Windows.Forms.Label()
        Me.lblIncorrect1 = New System.Windows.Forms.Label()
        Me.lblIncorrect2 = New System.Windows.Forms.Label()
        Me.lblIncorrect3 = New System.Windows.Forms.Label()
        Me.txtCorrectAnswer = New System.Windows.Forms.TextBox()
        Me.txtIncorrect2 = New System.Windows.Forms.TextBox()
        Me.txtIncorrect3 = New System.Windows.Forms.TextBox()
        Me.txtIncorrect1 = New System.Windows.Forms.TextBox()
        Me.txtQuestionPrompt = New System.Windows.Forms.TextBox()
        Me.lstCustQuestions = New System.Windows.Forms.ListBox()
        Me.btnSaveQuestion = New System.Windows.Forms.Button()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.lblSavedQuestions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(16, 11)
        Me.lblPrompt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(134, 19)
        Me.lblPrompt.TabIndex = 4
        Me.lblPrompt.Text = "Question Prompt: "
        '
        'lblCorrectAnswer
        '
        Me.lblCorrectAnswer.AutoSize = True
        Me.lblCorrectAnswer.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectAnswer.Location = New System.Drawing.Point(16, 94)
        Me.lblCorrectAnswer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCorrectAnswer.Name = "lblCorrectAnswer"
        Me.lblCorrectAnswer.Size = New System.Drawing.Size(120, 19)
        Me.lblCorrectAnswer.TabIndex = 5
        Me.lblCorrectAnswer.Text = "Correct Answer:"
        '
        'lblIncorrect1
        '
        Me.lblIncorrect1.AutoSize = True
        Me.lblIncorrect1.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect1.Location = New System.Drawing.Point(16, 126)
        Me.lblIncorrect1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncorrect1.Name = "lblIncorrect1"
        Me.lblIncorrect1.Size = New System.Drawing.Size(146, 19)
        Me.lblIncorrect1.TabIndex = 6
        Me.lblIncorrect1.Text = "Incorrect Answer 1:"
        '
        'lblIncorrect2
        '
        Me.lblIncorrect2.AutoSize = True
        Me.lblIncorrect2.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect2.Location = New System.Drawing.Point(16, 158)
        Me.lblIncorrect2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncorrect2.Name = "lblIncorrect2"
        Me.lblIncorrect2.Size = New System.Drawing.Size(146, 19)
        Me.lblIncorrect2.TabIndex = 7
        Me.lblIncorrect2.Text = "Incorrect Answer 2:"
        '
        'lblIncorrect3
        '
        Me.lblIncorrect3.AutoSize = True
        Me.lblIncorrect3.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect3.Location = New System.Drawing.Point(16, 190)
        Me.lblIncorrect3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncorrect3.Name = "lblIncorrect3"
        Me.lblIncorrect3.Size = New System.Drawing.Size(146, 19)
        Me.lblIncorrect3.TabIndex = 8
        Me.lblIncorrect3.Text = "Incorrect Answer 3:"
        '
        'txtCorrectAnswer
        '
        Me.txtCorrectAnswer.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrectAnswer.Location = New System.Drawing.Point(183, 94)
        Me.txtCorrectAnswer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCorrectAnswer.Name = "txtCorrectAnswer"
        Me.txtCorrectAnswer.Size = New System.Drawing.Size(211, 23)
        Me.txtCorrectAnswer.TabIndex = 9
        '
        'txtIncorrect2
        '
        Me.txtIncorrect2.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncorrect2.Location = New System.Drawing.Point(183, 156)
        Me.txtIncorrect2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIncorrect2.Name = "txtIncorrect2"
        Me.txtIncorrect2.Size = New System.Drawing.Size(211, 23)
        Me.txtIncorrect2.TabIndex = 10
        '
        'txtIncorrect3
        '
        Me.txtIncorrect3.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncorrect3.Location = New System.Drawing.Point(183, 188)
        Me.txtIncorrect3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIncorrect3.Name = "txtIncorrect3"
        Me.txtIncorrect3.Size = New System.Drawing.Size(211, 23)
        Me.txtIncorrect3.TabIndex = 11
        '
        'txtIncorrect1
        '
        Me.txtIncorrect1.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncorrect1.Location = New System.Drawing.Point(183, 124)
        Me.txtIncorrect1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIncorrect1.Name = "txtIncorrect1"
        Me.txtIncorrect1.Size = New System.Drawing.Size(211, 23)
        Me.txtIncorrect1.TabIndex = 12
        '
        'txtQuestionPrompt
        '
        Me.txtQuestionPrompt.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestionPrompt.Location = New System.Drawing.Point(175, 15)
        Me.txtQuestionPrompt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuestionPrompt.Multiline = True
        Me.txtQuestionPrompt.Name = "txtQuestionPrompt"
        Me.txtQuestionPrompt.Size = New System.Drawing.Size(308, 69)
        Me.txtQuestionPrompt.TabIndex = 13
        '
        'lstCustQuestions
        '
        Me.lstCustQuestions.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCustQuestions.FormattingEnabled = True
        Me.lstCustQuestions.ItemHeight = 18
        Me.lstCustQuestions.Location = New System.Drawing.Point(16, 288)
        Me.lstCustQuestions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstCustQuestions.Name = "lstCustQuestions"
        Me.lstCustQuestions.Size = New System.Drawing.Size(467, 148)
        Me.lstCustQuestions.TabIndex = 14
        '
        'btnSaveQuestion
        '
        Me.btnSaveQuestion.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveQuestion.Location = New System.Drawing.Point(349, 220)
        Me.btnSaveQuestion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSaveQuestion.Name = "btnSaveQuestion"
        Me.btnSaveQuestion.Size = New System.Drawing.Size(135, 28)
        Me.btnSaveQuestion.TabIndex = 15
        Me.btnSaveQuestion.Text = "Save Question"
        Me.btnSaveQuestion.UseVisualStyleBackColor = True
        '
        'btnDiscard
        '
        Me.btnDiscard.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscard.Location = New System.Drawing.Point(183, 220)
        Me.btnDiscard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(135, 28)
        Me.btnDiscard.TabIndex = 16
        Me.btnDiscard.Text = "Discard Question"
        Me.btnDiscard.UseVisualStyleBackColor = True
        '
        'lblSavedQuestions
        '
        Me.lblSavedQuestions.AutoSize = True
        Me.lblSavedQuestions.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavedQuestions.Location = New System.Drawing.Point(16, 265)
        Me.lblSavedQuestions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSavedQuestions.Name = "lblSavedQuestions"
        Me.lblSavedQuestions.Size = New System.Drawing.Size(129, 19)
        Me.lblSavedQuestions.TabIndex = 17
        Me.lblSavedQuestions.Text = "Saved Questions:"
        '
        'Custom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 446)
        Me.Controls.Add(Me.lblSavedQuestions)
        Me.Controls.Add(Me.btnDiscard)
        Me.Controls.Add(Me.btnSaveQuestion)
        Me.Controls.Add(Me.lstCustQuestions)
        Me.Controls.Add(Me.txtQuestionPrompt)
        Me.Controls.Add(Me.txtIncorrect1)
        Me.Controls.Add(Me.txtIncorrect3)
        Me.Controls.Add(Me.txtIncorrect2)
        Me.Controls.Add(Me.txtCorrectAnswer)
        Me.Controls.Add(Me.lblIncorrect3)
        Me.Controls.Add(Me.lblIncorrect2)
        Me.Controls.Add(Me.lblIncorrect1)
        Me.Controls.Add(Me.lblCorrectAnswer)
        Me.Controls.Add(Me.lblPrompt)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Custom"
        Me.Text = "Custom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblCorrectAnswer As Label
    Friend WithEvents lblIncorrect1 As Label
    Friend WithEvents lblIncorrect2 As Label
    Friend WithEvents lblIncorrect3 As Label
    Friend WithEvents txtCorrectAnswer As TextBox
    Friend WithEvents txtIncorrect2 As TextBox
    Friend WithEvents txtIncorrect3 As TextBox
    Friend WithEvents txtIncorrect1 As TextBox
    Friend WithEvents txtQuestionPrompt As TextBox
    Friend WithEvents lstCustQuestions As ListBox
    Friend WithEvents btnSaveQuestion As Button
    Friend WithEvents btnDiscard As Button
    Friend WithEvents lblSavedQuestions As Label
End Class
