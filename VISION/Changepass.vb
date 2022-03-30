Public Class Changepass

    Private Sub Changepass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TopMost = True
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.Username = TextBox1.Text And My.Settings.Password = TextBox2.Text Then
            If TextBox4.Text = TextBox5.Text Then
                My.Settings.Username = TextBox3.Text
                My.Settings.Password = TextBox4.Text
                My.Settings.Save()
                MsgBox("Password Saved")
                Dim a As Control

                For Each a In Me.Controls

                    If TypeOf a Is TextBox Then

                        a.Text = Nothing

                    End If

                Next

                Me.Hide()
                login.Show()
            Else
                MsgBox("Password Dont Match ")
            End If
        Else
            MsgBox("Wrong Current Password And Username")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main.Show()
    End Sub
End Class