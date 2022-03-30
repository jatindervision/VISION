Imports ADOX
Imports System.Data.OleDb
Public Class MroList
    Private Forminput As _12forinputbox
    Dim Course = _12forinputbox.TextBox1.Text.Trim()
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim source2 As New BindingSource
    Dim coursename As String
    Dim BILL As String
    Private Sub MroList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formrolist()
        Me.TopMost = True
        Me.CenterToScreen()
        TextBox4.Text = DateTimePicker1.Value.ToShortDateString
        Label22.Text = Course
        Try
            Dim sch As String
            sch = Convert.ToString(Course & "SCHEDULE")
            Label16.Text = sch
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da2 = New OleDbDataAdapter("SELECT Course_Code FROM [" & sch & "] ORDER BY SNO", MyConn)
            da2.Fill(ds, " & sch & ")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView2.DataSource = view
        Catch ex As Exception
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            da1 = New OleDbDataAdapter("SELECT * FROM Name", MyConn)
            da1.Fill(ds, "Name")
            MyConn.Open()
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
        Try
            BILL = Convert.ToString(TextBox2.Text.Trim() & "MRORECEIPT")

            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & BILL & ""})
            If SchemaTable.Rows.Count <> 0 Then
                MroListPrint.Show()
            Else
                Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim Conn As New OleDb.OleDbConnection(ConStr)
                Dim createTable As New OleDb.OleDbCommand
                createTable.Connection = Conn
                createTable.CommandType = CommandType.Text
                Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" & BILL & "] ([Mro_Name] TEXT(50),[Course] TEXT(30),[Course_Code] TEXT(10),[Session] TEXT(15),[TOTAL_SESSIONS] INTEGER,[Amount] TEXT(10),[Amount_in_Words] TEXT(150),[Date_of_Bill] TEXT(10))", Conn)
                'Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [AssignmentMarks] ([SNO]) WITH PRIMARY", Conn)
                'cmd1.CommandType = System.Data.CommandType.Text
                cmd.Connection = Conn
                Conn.Open()
                cmd.ExecuteNonQuery()
                Conn.Close()
                AccessConnection.Close()
                MroListPrint.Show()
            End If

        Catch ex As Exception
        End Try

       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        TextBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
    End Sub
End Class