Public Class Settings

    'Sets default game settings
    Dim gameDifficulty = 1
    Dim timerStartNum = 30
    Dim questionSet = "All"
    Dim numQuestions = 30

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

        'sets the game difficulty based on the selected option
        If Me.cboDifficulty.Text = "Medium" Then

            gameDifficulty = 2

        ElseIf Me.gameDifficulty.text = "Hard" Then

            gameDifficulty = 3

        ElseIf Me.gameDifficulty.text = "Extreme" Then

            gameDifficulty = 4

        Else

            gameDifficulty = 1

        End If

        'Sets question set based on selected option
        If Me.cboQuestionSet.Text = "History" Then

            questionSet = "Hist"

        ElseIf Me.cboQuestionSet.Text = "Science" Then

            questionSet = "Sci"

        ElseIf Me.cboQuestionSet.Text = "Pop Culture" Then

            questionSet = "Pop"

        ElseIf Me.cboQuestionSet.Text = "Custom" Then

            questionSet = "Cust"

        Else

            questionSet = "All"

        End If

        'sets game timer to selected value
        timerStartNum = numTimer

        If Me.cboQuestionNum.Text = 15 Then

            numQuestions = 15

        ElseIf Me.cboQuestionNum.Text = 100 Then

            numQuestions = 100

        ElseIf Me.cboQuestionNum.Text = 45 Then

            numQuestions = 45

        ElseIf Me.cboQuestionNum.Text = 60 Then

            numQuestions = 60

        ElseIf Me.cboQuestionNum.Text = 80 Then

            numQuestions = 80

        Else

            numQuestions = 30

        End If

        Close()

    End Sub

    Private Sub btnClearCustomSets_Click(sender As Object, e As EventArgs) Handles btnClearCustomSets.Click

    End Sub

    Private Sub btnClearLeaderboard_Click(sender As Object, e As EventArgs) Handles btnClearLeaderboard.Click

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class