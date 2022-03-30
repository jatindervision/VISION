Public Class Main

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.Hide()
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Changepass.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MDIParent1.Show()
    End Sub
End Class
