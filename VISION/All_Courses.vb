Imports System.Data.OleDb
Public Class All_Courses
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource


    Private Sub All_Courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORdisplaycourse()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [ALL_COURSES]", MyConn)
            da.Fill(ds, "ALL_COURSES")
            Label1.Text = ds.Tables(0).Rows.Count
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class