Public Class Game
	Dim Score = 0
	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

		If btnAnswer1.Checked Then
			MessageBox.Show("Correct...")
			Score = Score + 1
			MessageBox.Show("Your score is " + Score.ToString, "Good Job")
		Else
			MessageBox.Show("Incorrect", "Sorry")
		End If


	End Sub

	Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblScore.Text = "$" + Score.ToString
	End Sub

	Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
		MessageBox.Show("Your score is " + Score.ToString, "Goodbye")
		Me.Close()
	End Sub

	Dim minutes As Integer
	Dim seconds As Integer
	Dim TotalMinutes As Integer
	Dim TotalSeconds As Integer

	Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TotalMinutes = 0
		TotalSeconds = 45
		minutes = TotalMinutes
		seconds = TotalSeconds
		displayTimer()
		Timer1.Enabled = True
		Timer1.Interval = 1000
	End Sub

	Sub decrement()
		seconds = seconds - 1
		If seconds < 0 Then
			minutes = minutes - 1
			seconds = 59
		End If
		If minutes < 0 Then
			minutes = TotalMinutes
			seconds = 0
		End If
		displayTimer()
	End Sub

	Sub displayTimer()
		Dim displaySecond As String
		Dim displayMinute As String
		displaySecond = seconds
		displayMinute = minutes
		If seconds < 10 Then displaySecond = "0" & seconds
		If minutes < 10 Then displayMinute = "0" & minutes
		lblTimer.Text = displayMinute & ":" & displaySecond
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		decrement()
	End Sub
End Class