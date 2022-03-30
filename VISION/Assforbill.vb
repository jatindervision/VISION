
Imports System.Data.OleDb
Public Class Assforbill
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Private StatusDate As String = ASSFORBILLSTART.TextBox1.Text.Trim()
    Dim coursename As String
    Dim BILL As String
    Dim Course As String


    Private Sub Assforbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        forassnlist()
        Me.CenterToScreen()
        Me.TopMost = True
        TextBox1.Text = DateTimePicker1.Value.ToShortDateString

        Course = Convert.ToString(StatusDate)
        Me.Text = "You have Entered:-- " + Course
        TextBox9.Text = Course
        Try

            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT CRS1,CRS2,CRS3,CRS4,CRS5,CRS6,CRS7,CRS8,CRS9,CRS10,CRS11,CRS12,CRS13 FROM [" & Course & "] ORDER BY SNO", MyConn)
            da.Fill(ds, " & Course & ")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "ASSBILLTOP"})
            If SchemaTable1.Rows.Count <> 0 Then
                ' DELETE RECORD FROM BOTH 
                '    INSERT RECORD IN BOTH
                MsgBox("Exists and Now Packed USE THIS BUTTON AGAIN")
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table ASSBILLTOP")
                cmd7.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                AccessConnection.Close()
                Exit Sub
            Else

                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [ASSBILLTOP] ([UNAME] TEXT(100),[UADD1] TEXT(100),[UADD2] TEXT(100),[COLL_NAME] TEXT(100),[CODE] TEXT(15),[COURSE_FULL_NAME] TEXT(60),[COURSE_CODE] TEXT(15),[CNAME] TEXT(30),[COLADD1] TEXT(100),[COLADD2] TEXT(100),[YEAR] TEXT(4),[ASS_NO] TEXT(50),[NO_OF_ASS] TEXT(3),[RATE] TEXT(3),[AMOUNT] TEXT(5),[LIST_NO] TEXT(3),[DATED] TEXT(10),[AMOUNT_IN_WORD] TEXT(100),[TOTAL] TEXT(5),[LETTER_NO] TEXT(20))", Conn)
                    cmd1.Connection = Conn
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try

        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
                MsgBox(" Don't Leave Any field Empty!!!")
                Exit Sub
            End If
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da = New OleDbDataAdapter("SELECT CRS1,CRS2,CRS3,CRS4,CRS5,CRS6,CRS7,CRS8,CRS9,CRS10,CRS11,CRS12,CRS13 FROM [" & Me.Course & "] ORDER BY SNO", MyConn)
            da.Fill(ds, " & TextBox8.Text.Trim() & ")
            coursename = ds.Tables(" & TextBox8.Text.Trim() & ").Rows(0)(TextBox8.Text.Trim())
            If coursename <> TextBox2.Text.Trim() Then
                MsgBox("Your Course Code and Header or Not same Click Again of Assignment Evaluation Bill")
                MyConn.Close()
                Exit Sub
            Else
                MyConn.Close()
            End If
        Catch ex As Exception
        End Try
        Try
            BILL = Convert.ToString(TextBox9.Text.Trim() & "ALLASSIGNBILL")

            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & BILL & ""})
            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
                AssignmentBill.Show()
            Else
                Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim Conn As New OleDb.OleDbConnection(ConStr)
                Dim createTable As New OleDb.OleDbCommand
                createTable.Connection = Conn
                createTable.CommandType = CommandType.Text

                Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" & Me.BILL & "] ([Evaluator_Name] TEXT(50),[Course_Code] TEXT(50),[Course_FullName] TEXT(50),[Year] TEXT(4),[Assignment_No] TEXT(20),[Total_Assignment] TEXT(4),[Rate] Text(3),[Amount] TEXT(5))", Conn)
                'Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [AssignmentMarks] ([SNO]) WITH PRIMARY", Conn)
                'cmd1.CommandType = System.Data.CommandType.Text
                cmd.Connection = Conn
                Conn.Open()
                cmd.ExecuteNonQuery()
                Conn.Close()
                AccessConnection.Close()
                AssignmentBill.Show()
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

End Class