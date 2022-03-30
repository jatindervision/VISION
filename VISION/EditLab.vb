Option Explicit On
Imports System.IO
Imports ADOX
Imports System.Data.OleDb
Public Class EditLab
    Dim SQL As String
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        Dim Conn As New OleDb.OleDbConnection(ConStr)
        Conn.Open()
        SQL = "update Lab set [CPU]=?,[LED]=?,[KEYBOARD]=?, [MOUSE]= ?,[PRINTER]=?,[PC]=?"
        ', where Id = ?"
        Dim cmd As New OleDb.OleDbCommand(SQL, Conn)

        'cmd.Parameters.AddWithValue("@Id", TextBox7.Text)
        cmd.Parameters.AddWithValue("@CPU", TextBox1.Text)
        cmd.Parameters.AddWithValue("@LED", TextBox2.Text)
        cmd.Parameters.AddWithValue("@KEYBOARD", TextBox3.Text)
        cmd.Parameters.AddWithValue("@MOUSE", TextBox4.Text)
        cmd.Parameters.AddWithValue("@PRINTER", TextBox5.Text)
        cmd.Parameters.AddWithValue("@PC", TextBox6.Text)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Updated")
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub EditLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForEditLab()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Lab]", MyConn)
            da.Fill(ds, "Lab")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
     
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class