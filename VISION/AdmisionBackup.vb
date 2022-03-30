Imports System.Data
Public Class AdmissionBackup
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim dest As New BindingSource
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)
            Dim createTable As New OleDb.OleDbCommand
            createTable.Connection = Conn
            createTable.CommandType = CommandType.Text

            Dim cmd As New OleDb.OleDbCommand("INSERT INTO AdmissionBackup  SELECT * FROM StAdmission", Conn)

            Conn.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("Backup Successfully")
            Conn.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub TransferButton_Click(sender As Object, e As EventArgs) Handles TransferButton.Click
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [AdmissionBackup]", MyConn)
            da.Fill(ds, "StAdmission")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGrid2.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [StAdmission]", MyConn)
            da.Fill(ds, "StAdmission")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGrid1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AdmisionBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForAdmissionBackup()
        Me.TopMost = True
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CourseCompleted.Show()
    End Sub
End Class