Public Class Game
	Dim Correct = 0
	Dim Asked = 1
	Dim NumToAsk = 5

	Dim minutes As Integer
	Dim seconds As Integer
	Dim TotalMinutes As Integer = 0
	Dim TotalSeconds As Integer = 45

	Dim CorrectAnswer = 1
	Dim CorrectAnswerText As String

	Dim Questions As List(Of Question)

	Private Sub LoadNewQuestion()
		' Get random question
		Dim rnd = New Random()
		Dim Question = Questions(
							rnd.Next(0, Title.Questions.Count - 1))
		Questions.Remove(Question) ' To prevent duplication

		CorrectAnswerText = Question.Correct
		lblQuestion.Text = Question.Prompt
		CorrectAnswer = rnd.Next(1, 5)

		Select Case CorrectAnswer
			Case 1
				btnAnswer1.Text = Question.Correct
				btnAnswer2.Text = Question.Wrong1
				btnAnswer3.Text = Question.Wrong2
				btnAnswer4.Text = Question.Wrong3
			Case 2
				btnAnswer2.Text = Question.Correct
				btnAnswer1.Text = Question.Wrong1
				btnAnswer3.Text = Question.Wrong2
				btnAnswer4.Text = Question.Wrong3
			Case 3
				btnAnswer3.Text = Question.Correct
				btnAnswer2.Text = Question.Wrong1
				btnAnswer1.Text = Question.Wrong2
				btnAnswer4.Text = Question.Wrong3
			Case 4
				btnAnswer4.Text = Question.Correct
				btnAnswer2.Text = Question.Wrong1
				btnAnswer3.Text = Question.Wrong2
				btnAnswer1.Text = Question.Wrong3
		End Select

		minutes = TotalMinutes
		seconds = TotalSeconds

	End Sub

	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
		Dim Answer = 0

		If btnAnswer1.Checked Then
			Answer = 1
		ElseIf btnAnswer2.Checked Then
			Answer = 2
		ElseIf btnAnswer3.Checked Then
			Answer = 3
		ElseIf btnAnswer4.Checked Then
			Answer = 4
		End If

		'No answers were checked
		If Answer = 0 Then
			MessageBox.Show("Please select an answer")
			Return
		End If

		If Answer = CorrectAnswer Then
			MessageBox.Show("Correct!")
			Correct += 1
			Asked += 1
		Else
			MessageBox.Show("Sorry, the correct answer was" & vbCrLf & CorrectAnswerText,
							"Incorrect")
			Asked += 1
		End If

		If Asked >= NumToAsk Then
			Score.Show()
			Me.Close()
		End If

		LoadNewQuestion()
	End Sub

	Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
		MessageBox.Show("Your score is " + Score.ToString, "Goodbye")
		Me.Close()
	End Sub


	Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblScore.Text = "$" + Score.ToString

		Me.Questions = Title.Questions
		If NumToAsk < Questions.Count Then ' Sanity check
			NumToAsk = Questions.Count
		End If
		LoadNewQuestion()

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