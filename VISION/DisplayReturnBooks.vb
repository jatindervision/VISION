Imports System.Data.OleDb
Public Class DisplayReturnBooks
    Dim tonString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim tonConn As OleDbConnection
    Dim daa As OleDbDataAdapter
    Dim dss As DataSet
    Dim tables As DataTableCollection
    Dim source2 As New BindingSource
    Private Sub DisplayReturnBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForDisRBooks()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
            tonConn = New OleDbConnection
            tonConn.ConnectionString = tonString
            dss = New DataSet
            tables = dss.Tables
            daa = New OleDbDataAdapter("Select * from [Breturn]", tonConn)
            daa.Fill(dss, "Breturn")
            Dim view As New DataView(tables(0))
            source2.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        tonConn.Close()
        Con.Close()
        ReturnBooks.Show()
    End Sub
End Class