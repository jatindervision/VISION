Public Class IgnouStStart
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            ExcelFileName.Text = dialog.FileName
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Import_Ignou_Students.Show()
    End Sub
    Private Sub IgnouStStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORIGSTART()
        Me.CenterToScreen()
        Me.TopMost = True
    End Sub
   
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        MixedIGNOUExcel.Show()
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBox2.Text = dialog.FileName
        End If
    End Sub
    
End Class