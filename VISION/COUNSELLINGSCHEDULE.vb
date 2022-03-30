Imports System.Drawing.Printing
Public Class COUNSELLINGSCHEDULE
    Inherits System.Windows.Forms.Form
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim da3 As OleDbDataAdapter
    Dim source1 As New BindingSource
    Dim DT As DataTable
    Dim tables As DataTableCollection
    Private schedule = StartCounSchedule.TextBox1.Text.Trim()
    Private counname = StartCounSchedule.TextBox2.Text.Trim()
    Private ccode = StartCounSchedule.TextBox3.Text.Trim()
    Private codefullname = StartCounSchedule.TextBox4.Text.Trim()
    Private coursename = StartCounSchedule.TextBox5.Text.Trim()
    Dim sno As Integer
    Dim SN As String
    Dim SCH As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TopMost = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False

      With Me.PrintForm1
            .PrintAction = Printing.PrintAction.PrintToPreview
            Dim MyMargins As New Margins
            With MyMargins
                .Left = 0.5
                .Right = 0.2
                .Top = 0.5
                .Bottom = 0.5
            End With
            .PrinterSettings.DefaultPageSettings.Margins = MyMargins
            .PrinterSettings.DefaultPageSettings.Landscape = True
            .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)

        End With

    End Sub

    Private Sub COUNSELLINGSCHEDULE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scheduleco()
        Me.CenterToScreen()
        Me.TopMost = True

        Try

            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da2 = New OleDbDataAdapter("Select * from [Name]", MyConn)
            da2.Fill(ds, "Name")
            Label1.Text = ds.Tables("Name").Rows(0)("University_Name")
            Label3.Text = ds.Tables("Name").Rows(0)("PLACE")
            Label4.Text = ds.Tables("Name").Rows(0)("Code")
            Label6.Text = coursename
            MyConn.Close()
        Catch ex As Exception
            MsgBox(" Some Thing Wrong ????")
            Exit Sub
        End Try
        SCH = Convert.ToString(schedule & "SCHEDULE")
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            MyConn.Open()
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT * FROM [" & SCH & "] WHERE Academic_Counselor = '" & counname & "'", MyConn)
            da.Fill(ds, "" & SCH & "")

            Dim i As Integer = 0
            For i = i To ds.Tables("" & SCH & "").Rows.Count - 1 Step 1
                SN = SN + 1
                ListBox1.Items.Add(SN)
                ListBox2.Items.Add(counname)
                ListBox3.Items.Add(codefullname & "(" & ccode & ")")
                ListBox4.Items.Add(ds.Tables("" & SCH & "").Rows(i).Item("DATE_"))
                ListBox5.Items.Add(ds.Tables("" & SCH & "").Rows(i).Item("Time_From"))
                ListBox6.Items.Add(ds.Tables("" & SCH & "").Rows(i).Item("Time_To"))
            Next i
            MyConn.Close()
        Catch ex As Exception
            MsgBox(" Some Thing Wrong ????")
            Exit Sub
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            Dim SchemaTable2 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "TCoSCHEDULE"})
            SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "BCoSCHEDULE"})
            If SchemaTable1.Rows.Count <> 0 And SchemaTable1.Rows.Count <> 0 Then
                ' DELETE RECORD FROM BOTH 
                '    INSERT RECORD IN BOTH
                MsgBox("Exists and Now Packed USE THIS BUTTON AGAIN")
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table TCoSCHEDULE")
                Dim cmd8 As New OleDb.OleDbCommand("DROP  Table BCoSCHEDULE")
                cmd7.Connection = AccessConnection
                cmd8.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                cmd8.ExecuteNonQuery()
                AccessConnection.Close()
                Exit Sub
            Else

                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [TCoSCHEDULE] ([UNAME] TEXT(100),[PLACE] TEXT(20),[CODE] TEXT(15),[COURSE_NAME] TEXT(15))", Conn)
                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [BCoSCHEDULE] ([SNO] TEXT(5),[CNAME] TEXT(50),[PROGRAMME] TEXT(100),[DATES] TEXT(10),[TIME_FROM] TEXT(10),[TIME_TO] TEXT(10))", Conn)
                    cmd.Connection = Conn
                    cmd1.Connection = Conn
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    AccessConnection.Close()
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If
            Try
                Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim Conn As New OleDb.OleDbConnection(ConStr)

                Dim i As Integer
                Dim Str As String
                Dim Str1 As String
                Con.Open()

              
                For i = 0 To ListBox1.Items.Count - 1
                    Str1 = "insert into [BCoSCHEDULE] values('" & ListBox1.Items.Item(i) & "','" & ListBox2.Items.Item(i) & "','" & ListBox3.Items.Item(i) & "','" & ListBox4.Items.Item(i) & "','" & ListBox5.Items.Item(i) & "','" & ListBox6.Items.Item(i) & "')"
                    Dim TOP As OleDbCommand = New OleDbCommand(Str1, Con)
                    TOP.ExecuteNonQuery()
                Next i
                MsgBox("Record inserted successfully...")
                Str = "insert into [TCoSCHEDULE] values('" & Label1.Text & "','" & Label3.Text & "','" & Label4.Text & "','" & Label6.Text & "')"
                Dim Scmd As OleDbCommand = New OleDbCommand(Str, Con)
                Scmd.ExecuteNonQuery()
                Con.Close()
            Catch ex As Exception
                MessageBox.Show("Could Not Insert Record!!!")
                MsgBox(ex.Message & " -  " & ex.Source)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        CO_SCHEDULE_VIEWER.Show()
    End Sub
End Class