Public Class Game
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click

        If btnanswer1.Checked Then
            MessageBox.Show("Correct...")
            Score = Score + 1
            MessageBox.Show("Your score is " + Score.ToString, "Good Job")
        Else
            MessageBox.Show("Incorrect", "Sorry")
        End If

        Me.Hide()
        Form5.Show()


    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = "$" + Score.ToString
    End Sub

    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        MessageBox.Show("Your score is " + Score.ToString, "Goodbye")
        Me.Close()
    End Sub
End Class