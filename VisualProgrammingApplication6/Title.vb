Public Class Title
    Public Sub ShowAboutBox()
        'Display the About dialog box
        Using objAbout As New About
            objAbout.ShowDialog(Me)
        End Using
    End Sub
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ShowAboutBox()
    End Sub
End Class
