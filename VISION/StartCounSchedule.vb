Imports System
Imports System.Data.OleDb
Public Class StartCounSchedule
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim source2 As New BindingSource
    Dim course As String
    Private Sub StartCounSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        counsch()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select Employee_Name from [IgnouEmployeeDetail]", MyConn)
            da.Fill(ds, "IgnouEmployeeDetail")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        course = Convert.ToString(TextBox1.Text.Trim() & "SCHEDULE")
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("Select * from [" & course & "] Where Academic_Counselor='" & TextBox2.Text.Trim() & "'", MyConn)
            da1.Fill(ds, "" & TextBox1.Text.Trim() & "")
            Dim view As New DataView(tables(0))
            source2.DataSource = view
            DataGridView2.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        COUNSELLINGSCHEDULE.Show()
    End Sub
End Class