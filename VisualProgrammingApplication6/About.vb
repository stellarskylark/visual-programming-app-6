Public Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ApplicationTitle As String = "Who Wants to be a Millionaire"

        Me.lblAbout.Text = ApplicationTitle
        Me.lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.txtGameDescription.Text = "Who Wants to Be a Millionaire! is a trivia game which test your skills about various topics in order to determine whether or not you are smart enough to win the awesome prize at the end. Are you smart enough?"

    End Sub

End Class