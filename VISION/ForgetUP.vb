Public Class ForgetUP

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "9018725826" Then
            Dim Uname As String
            Dim Pass As String
            Uname = My.Settings.Username
            Pass = My.Settings.Password

            Label1.Text = Uname
            Label2.Text = Pass
        Else



        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub ForgetUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        Me.TopMost = True
    End Sub
End Class