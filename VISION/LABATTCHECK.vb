Imports System.Data
Imports System.Data.OleDb
Public Class LABATTCHECK
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim Coursecode As String = chklabstart.TextBox2.Text.Trim()
    Dim TCourse As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IGNOU_LAB_ATT.Show()
    End Sub
    Private Sub LABATTCHECK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chklabstart.Close()
        Ignou_lab_attendance.Close()
        Me.TopMost = True
        Me.CenterToScreen()
        TCourse = Convert.ToString(Coursecode & "ATTENDANCE")
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [" & TCourse & "]", MyConn)
            da.Fill(ds, "" & TCourse & "")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
            MsgBox(vbCrLf & ex.Message)
        End Try
    End Sub
End Class