Public Class importsch

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBox1.Text = dialog.FileName
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ImportSchedule.Show()
    End Sub

    Private Sub importsch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class