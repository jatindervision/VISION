Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForgetUP.Close()
        Me.CenterToScreen()
        Dim borderWidth As Integer = 1

        Dim borderColor As Color = Color.FromArgb(55, 96, 145) 'Color.LimeGreen
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Username And TextBox2.Text = My.Settings.Password Then
            MsgBox("Access Granted")
            Main.Show()
        Else
            MsgBox(" Wrong Username OR Password")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ForgetUP.Show()
    End Sub
End Class
