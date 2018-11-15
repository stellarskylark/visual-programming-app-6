Public Class Title
	Public Questions As List(Of Question)

	Public Sub ShowAboutBox()
		'Display the About dialog box
		Using objAbout As New About
			objAbout.ShowDialog(Me)
		End Using
	End Sub
	Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
		ShowAboutBox()
	End Sub

	Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
		Settings.Show()
	End Sub

	Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
		Custom.Show()
	End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Game.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        changeColorTitle()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        changeColorMoney()
    End Sub

    Sub changeColorTitle()
        If lblTitle.ForeColor = Color.Gold Then
            lblTitle.ForeColor = Color.ForestGreen
        Else lblTitle.ForeColor = Color.Gold

        End If
    End Sub

    Sub changeColorMoney()
        If lblDollar1.ForeColor = Color.Gold Then
            lblDollar1.ForeColor = Color.ForestGreen
        Else lblDollar1.ForeColor = Color.Gold

        End If
        If lblDollar2.ForeColor = Color.Gold Then
            lblDollar2.ForeColor = Color.ForestGreen
        Else lblDollar2.ForeColor = Color.Gold

        End If
    End Sub

    Private Sub Title_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Initialize default questions
		Questions = New List(Of Question)

		Questions.Add(New Question("Do you know the muffin man?", 'Prompt
									"The one on Drury Lane?", 'Correct
									"What?",
									"I thought this was a trivia game",
									"I think maybe no?"))
		Questions.Add(New Question("What planet is closest to the sun?", 'Prompt
									"Mercury", 'Correct
									"Earth",
									"Venus",
									"Gallifrey"))
		Questions.Add(New Question("Who started the Protestant Reformation?", 'Prompt
									"Martin Luther", 'Correct
									"Ulrich Zwingli",
									"Werner von Protestant",
									"The Pope"))
		Questions.Add(New Question("Where did potatoes originate?", 'Prompt
									"The Americas", 'Correct
									"Russia",
									"Ireland",
									"in the dirt lol"))
		Questions.Add(New Question("Who was the first president of the USA?", 'Prompt
									"George Washington", 'Correct
									"Ganondorf",
									"Donald Trump",
									"John Adams"))
	End Sub


End Class
