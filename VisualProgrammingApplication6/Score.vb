Public Class Score

    Function MainMenu()

        Title.Show()

		Me.Close()

	End Function

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        MainMenu()

    End Sub

    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblCorrect_Click(sender As Object, e As EventArgs) Handles lblCorrect.Click
        'correct answers is the count of correct answers'

        lblCorrect = qCorrect

    End Sub

    Private Sub lblAsked_Click(sender As Object, e As EventArgs) Handles lblAsked.Click
        'qasked is the total number of questions asked'

        lblAsked = qAsked

    End Sub
End Class