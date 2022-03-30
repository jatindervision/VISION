Imports ADOX
Imports System.Data.OleDb
Public Class importassmarks

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub importassmarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
       
        importassignmentgrid.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBox1.Text = dialog.FileName
        End If
    End Sub
End Class