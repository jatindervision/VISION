Imports ADOX
Imports System.Data.OleDb
Public Class Chc
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Private SCHEDULE As String = testingCHC.Label12.Text.Trim()
    Dim CHCNAME As String


    Private Sub Chc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        forCHC()
        Me.TopMost = True
        Me.CenterToScreen()
        TextBox3.Text = DateTimePicker1.Value.ToShortDateString
        Dim SCH As String
        SCH = Convert.ToString(SCHEDULE)
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da2 = New OleDbDataAdapter("SELECT Course_Code FROM [" & SCH & "] ORDER BY SNO", MyConn)
            da2.Fill(ds, " & SCH & ")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("SELECT * FROM Name", MyConn)
            da1.Fill(ds, "Name")
            Label13.Text = ds.Tables("Name").Rows(CurrentRow)("Name")
            Label15.Text = ds.Tables("Name").Rows(CurrentRow)("Code")
            Label17.Text = ds.Tables("Name").Rows(CurrentRow)("CAddr1")
            Label18.Text = ds.Tables("Name").Rows(CurrentRow)("CAddr2")
            MyConn.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
            MsgBox(" Don't Leave Any field Empty!!!")
            Exit Sub
        End If
        CHCNAME = Convert.ToString(TextBox9.Text.Trim() & "CHCRECEIPT")
        Try

            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & CHCNAME & ""})
            If SchemaTable.Rows.Count <> 0 Then
             
                ChcPrint.Show()
               
            Else
                Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" & CHCNAME & "] ([Course] TEXT(30),[Course_Code] TEXT(10),[Session] TEXT(15),[Amount] TEXT(15),[Amount_in_Words] TEXT(200),[Date_of_Bill] TEXT(10))", AccessConnection)
                'Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [AssignmentMarks] ([SNO]) WITH PRIMARY", Conn)
                'cmd1.CommandType = System.Data.CommandType.Text
                cmd.Connection = AccessConnection
                cmd.ExecuteNonQuery()
                MsgBox("created")
                AccessConnection.Close()
                ChcPrint.Show()
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub
End Class