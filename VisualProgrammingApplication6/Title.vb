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

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Settings.Show()
    End Sub

    Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        Custom.Show()
    End Sub
End Class
