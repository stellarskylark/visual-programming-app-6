Public Class About
    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        Me.ProjectLabel.Text = My.Application.Info.ProductName
        Me.VersionLabel.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.GameDescription.Text = "*Who Wants to Be a Millionaire* is a trivia game testing your
        skills - determining if you are good enough to win the awesome prize at the end... 
        Are you smart enough?"


    End Sub


End Class