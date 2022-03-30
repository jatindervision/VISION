
Imports System.Data.OleDb
Public Class FOR_ARTS_ATTENDANCE_SIG
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim source2 As New BindingSource
    Dim Course As String
    Dim dup As String
    Private SCHEDULE As String = Arts_Attendance.TextBox1.Text.Trim()
    Dim Str As String
    Dim NNAME As String
    Dim SCH As String
    Private Sub FOR_ARTS_ATTENDANCE_SIG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ARTSATT()
        Me.CenterToScreen()
        Me.TopMost = True
        DataGridView2.Visible = False
        TextBox1.Text = Convert.ToString("BA(BDP)")
        TextBox5.Text = SCHEDULE
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
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" And TextBox5.Text = "" And TextBox9.Text = "" Then
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
                    Dim time As String
                    time = Convert.ToString(Label3.Text & " To " & Label4.Text)

                    Str = "INSERT INTO  TOPADMISSION VALUES("
                    Str += """" & 1 & """"
                    Str += ","
                    Str += """" & Label13.Text & """"
                    Str += ","
                    Str += """" & Label15.Text & """"
                    Str += ","
                    Str += """" & Label34.Text & """"
                    Str += ","
                    Str += """" & time & """"
                    Str += ","
                    Str += """" & TextBox1.Text.Trim() & """"
                    Str += ","
                    Str += """" & Label5.Text.Trim() & """"
                    Str += ","
                    Str += """" & Label6.Text.Trim() & """"
                    Str += ","
                    Str += """" & Label7.Text.Trim() & """"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CurrentRow = DataGridView2.RowCount - 1 Then
            MsgBox("Last Record is Reached!!!")
        Else
            CurrentRow += 1
            ShowData(CurrentRow)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView1.Visible = False
        DataGridView2.Visible = True
        SCH = Convert.ToString(SCHEDULE & "SCHEDULE")
        CurrentRow = 0
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("Select DATE_,Time_From,Time_To,Course_Code,Academic_Counselor from [" & SCH & "] Where Course_Code='" & TextBox9.Text.Trim() & "'", MyConn)
            da1.Fill(ds, "" & SCH & "")
            Dim view As New DataView(tables(0))
            source2.DataSource = view
            DataGridView2.DataSource = view
            ShowData(CurrentRow)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            Label6.Text = DataGridView2.Rows(CurrentRow).Cells(0).Value
            Label3.Text = DataGridView2.Rows(CurrentRow).Cells(1).Value
            Label4.Text = DataGridView2.Rows(CurrentRow).Cells(2).Value
            Label5.Text = DataGridView2.Rows(CurrentRow).Cells(3).Value
            Label7.Text = DataGridView2.Rows(CurrentRow).Cells(4).Value
        Catch ex As Exception
        End Try
    End Sub
End Class