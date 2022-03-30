Imports System.Data.OleDb
Public Class SCHEDULESHOW
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim db_reader As OleDbDataReader
    Dim source1 As New BindingSource
    Dim DT As DataTable
    Dim tables As DataTableCollection
    Private schedule As String = startscheduleschow.TextBox1.Text.Trim()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub SCHEDULESHOW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SHSCHE()
        Me.CenterToScreen()
        Dim sch As String
        sch = Convert.ToString(schedule & "-SCHEDULE")
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [" & sch & "]", MyConn)
            da.Fill(ds, "" & sch & "")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub
End Class