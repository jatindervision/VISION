Public Class chklabstart

    Private Sub chklabstart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ignou_lab_attendance.Close()
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LABATTCHECK.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class