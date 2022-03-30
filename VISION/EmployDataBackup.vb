Imports System.Data
Public Class EmployDataBackup
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim dest As New BindingSource
    Private Sub EmployDataBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForEmpDataBack()
        Me.CenterToScreen()
        Me.TopMost = True
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        Dim Conn As New OleDb.OleDbConnection(ConStr)
        Dim createTable As New OleDb.OleDbCommand
        createTable.Connection = Conn
        createTable.CommandType = CommandType.Text

        Dim cmd As New OleDb.OleDbCommand("INSERT INTO EmployeeBackUp  SELECT * FROM EmployeeDetail", Conn)

        Conn.Open()
        cmd.ExecuteNonQuery()

        MessageBox.Show("Backup Successfully")
        Conn.Close()
    End Sub

   
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [EmployeeDetail]", MyConn)
            da.Fill(ds, "EmployeeDetail")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGrid1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TransferButton_Click(sender As Object, e As EventArgs) Handles TransferButton.Click
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [EmployeeBackUp]", MyConn)
            da.Fill(ds, "EmployeeBackUp")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGrid2.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MyConn.Close()
        Me.Close()
    End Sub

    Private Sub DataGrid2_Navigate(sender As Object, ne As NavigateEventArgs) Handles DataGrid2.Navigate

    End Sub
End Class