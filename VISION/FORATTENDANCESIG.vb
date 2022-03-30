
Imports System.Data.OleDb
Public Class FORATTENDANCESIG
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim Course As String
    Dim dup As String
    Private SCHEDULE As String = STARTATT.TextBox1.Text.Trim()
    Dim Str As String
    Dim NNAME As String
    Private Sub FORATTENDANCESIG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ABCD()
        Me.CenterToScreen()
        Me.TopMost = True
        TextBox4.Text = DateTimePicker1.Value.ToShortDateString
        TextBox6.Visible = False
        TextBox7.Visible = False
        NNAME = Convert.ToString(SCHEDULE & "SCHEDULE")
       
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da = New OleDbDataAdapter("Select * from [" & NNAME & "]", MyConn)
            da.Fill(ds, "" & NNAME & "")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            MyConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da1 = New OleDbDataAdapter("SELECT * FROM Name", MyConn)
            da1.Fill(ds, "Name")
            Label13.Text = ds.Tables("Name").Rows(0)("University_Name")
            Label34.Text = ds.Tables("Name").Rows(0)("Code")
            Label15.Text = ds.Tables("Name").Rows(0)("PLACE")
            MyConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Report_IStudentAttendance.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" And TextBox8.Text = "" Then
            MsgBox(" DONT LEAVE ANY FIELD EMPTY")
            Exit Sub
        End If
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            Dim SchemaTable2 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
          
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "TOPADMISSION"})
            SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "BOTTOMADMISSION"})
            If SchemaTable1.Rows.Count <> 0 And SchemaTable2.Rows.Count <> 0 Then

                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table TOPADMISSION")
                Dim cmd8 As New OleDb.OleDbCommand("DROP  Table BOTTOMADMISSION")
                cmd7.Connection = AccessConnection
                cmd8.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                cmd8.ExecuteNonQuery()
                MsgBox("Exists and Packed , Do Same Job Again")
                AccessConnection.Close()
                Exit Sub
            Else
                Try
                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [TOPADMISSION] ([SNO] INTEGER,[Uname] TEXT(150),[Place] TEXT(15),[Code] TEXT(20),[Time] TEXT(50),[Prog_Code] TEXT(15),[Course_Code] TEXT(20),[Dates] TEXT(10),[CName] TEXT(50),[Line1] TEXT(150), [Line1a] TEXT(100),[Line2] TEXT(150), [Line2b] TEXT(100),[Line3] TEXT(150), [Line3c] TEXT(100))", Con)
                    Dim cmd2 As New OleDb.OleDbCommand("create index [PrimaryKey] on [TOPADMISSION] ([SNO]) WITH PRIMARY", Con)
                    Dim cmd3 As New OleDb.OleDbCommand("CREATE TABLE [BOTTOMADMISSION] ([SNO] INTEGER,[Enrollment] TEXT(10),[StName] TEXT(30))", Con)
                    Dim cmd4 As New OleDb.OleDbCommand("create index [PrimaryKey] on [BOTTOMADMISSION] ([SNO]) WITH PRIMARY", Con)
                    Dim cmd5 As New OleDb.OleDbCommand("INSERT INTO  BOTTOMADMISSION (SNO,Enrollment,StName) SELECT SNO, ENRNO, NAME FROM " & TextBox5.Text.Trim() & "", Con)
                    cmd2.CommandType = System.Data.CommandType.Text
                    cmd4.CommandType = System.Data.CommandType.Text
                    cmd1.Connection = Con
                    cmd3.Connection = Con
                    Con.Open()
                    cmd1.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()
                    cmd4.ExecuteNonQuery()
                    ' INSERT RECORD
                    cmd5.ExecuteNonQuery()
                    Con.Close()

                    Str = "INSERT INTO  TOPADMISSION VALUES("
                    Str += """" & 1 & """"
                    Str += ","
                    Str += """" & Label13.Text & """"
                    Str += ","
                    Str += """" & Label15.Text & """"
                    Str += ","
                    Str += """" & Label34.Text & """"
                    Str += ","
                    Str += """" & TextBox2.Text.Trim() & """"
                    Str += ","
                    Str += """" & TextBox1.Text.Trim() & """"
                    Str += ","
                    Str += """" & TextBox3.Text.Trim() & """"
                    Str += ","
                    Str += """" & TextBox4.Text.Trim() & """"
                    Str += ","
                    Str += """" & TextBox8.Text.Trim() & """"
                    Str += ","
                    Str += """" & Label28.Text & """"
                    Str += ","
                    Str += """" & Label29.Text & """"
                    Str += ","
                    Str += """" & Label30.Text & """"
                    Str += ","
                    Str += """" & Label31.Text & """"
                    Str += ","
                    Str += """" & Label32.Text & """"
                    Str += ","
                    Str += """" & Label33.Text & """"
                    Str += ")"
                    Con.Open()
                    Cmd = New OleDbCommand(Str, Con)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Success")
                    Con.Close()
                    AccessConnection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If
            AccessConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        reportview.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox6.Visible = True
        TextBox7.Visible = True
    End Sub

  
End Class