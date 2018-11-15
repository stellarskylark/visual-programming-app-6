Public Class Question
	Implements ICloneable
	Public Prompt As String
	Public Correct As String
	Public Wrong1 As String
	Public Wrong2 As String
	Public Wrong3 As String

	Public Sub New(prompt As String, correct As String,
				   wrong1 As String, wrong2 As String, wrong3 As String)

		Me.Prompt = prompt
		Me.Correct = correct
		Me.Wrong1 = wrong1
		Me.Wrong2 = wrong2
		Me.Wrong3 = wrong3
	End Sub

	Public Function Clone() As Object Implements ICloneable.Clone
		Return New Question(Me.Prompt, Me.Correct, Me.Wrong1, Me.Wrong2, Me.Wrong3)
	End Function
End Class
