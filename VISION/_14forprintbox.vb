Imports ADOX
Imports System.Data.OleDb
Public Class _14forinputbox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub _14forprintbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        for14()
        Me.TopMost = True
        Me.CenterToScreen()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Schedule.Show()
    End Sub
End Class