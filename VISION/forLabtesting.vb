Imports ADOX
Imports System.Data.OleDb
Public Class forLabtesting

    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim db_reader As OleDbDataReader
    Dim source1 As New BindingSource
    Dim DT As DataTable
    Dim tables As DataTableCollection
    Private Sub forLabtesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        beforechctesting()
        Me.CenterToScreen()
        Me.TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        testingCHC.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SCH As String
        SCH = Convert.ToString(TextBox3.Text.Trim() & "SCHEDULE")
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [" & SCH & "]", MyConn)
            da.Fill(ds, "" & SCH & "")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
            MsgBox(vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
    End Sub
End Class