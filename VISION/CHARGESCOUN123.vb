Imports System.Drawing.Printing
Public Class CHARGESCOUN123
    Inherits System.Windows.Forms.Form
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim da3 As OleDbDataAdapter
    Dim da4 As OleDbDataAdapter
    Dim source1 As New BindingSource
    Dim DT As DataTable
    Dim tables As DataTableCollection
    Private schedule = FORCOUNSELLORCHARGES.Label7.Text.Trim()
    Private counname = FORCOUNSELLORCHARGES.TextBox8.Text.Trim()
    Private ccode = FORCOUNSELLORCHARGES.TextBox3.Text.Trim()
    Private codefullname = FORCOUNSELLORCHARGES.TextBox4.Text.Trim()
    Private councharges = FORCOUNSELLORCHARGES.TextBox5.Text.Trim()
    Private ancecharges = FORCOUNSELLORCHARGES.TextBox6.Text.Trim()
    Private mints = FORCOUNSELLORCHARGES.TextBox11.Text.Trim()
    Private chrs = FORCOUNSELLORCHARGES.TextBox12.Text.Trim()
    Private timee = FORCOUNSELLORCHARGES.TextBox13.Text.Trim()
    Private months = FORCOUNSELLORCHARGES.TextBox7.Text.Trim()
    Private PROGRA = FORCOUNSELLORCHARGES.Label7.Text.Trim()
    Dim Total As Integer
    Dim Net As Integer
    Dim ccount As Integer
    Dim SCH As String
    Private a As Integer
    Private Sub CHARGESCOUN123_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hELLOCHARGES()
        Me.CenterToScreen()
        Me.TopMost = True
       
        SCH = Convert.ToString(schedule & "SCHEDULE")
        Try

            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da2 = New OleDbDataAdapter("Select * from [Name]", MyConn)
            da2.Fill(ds, "Name")
            Label1.Text = ds.Tables("Name").Rows(0)("University_Name")
            Label4.Text = ds.Tables("Name").Rows(0)("University_Add1")
            Label5.Text = ds.Tables("Name").Rows(0)("University_Add2")
            Label7.Text = ds.Tables("Name").Rows(0)("Name")
            Label9.Text = ds.Tables("Name").Rows(0)("Code")
            Label11.Text = counname
            Label13.Text = months
            Label15.Text = codefullname
            Label16.Text = "(" & ccode & ")"
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
            da = New OleDbDataAdapter("SELECT * FROM [" & SCH & "] Where Academic_Counselor= '" & counname & "' and Course_Code= '" & ccode & "'", MyConn)
            'Where Academic_Counselor= counname ", MyConn)
            da.Fill(ds, "" & SCH & "")
            For j As Integer = 0 To ds.Tables("" & SCH & "").Rows.Count - 1 Step 1
                ccount = ccount + 1
            Next j
            Label45.Text = ccount
            Dim i As Integer = 0
            If ancecharges = "" Then
                ancecharges = "0"
            End If
            Dim CONV As Integer = Convert.ToInt32(ancecharges)
            Dim CONC As Integer = Convert.ToInt32(councharges)
            For i = i To ds.Tables("" & SCH & "").Rows.Count - 1 Step 1
                ListBox1.Items.Add(ds.Tables("" & SCH & "").Rows(i)(1))
                ListBox2.Items.Add(ds.Tables("" & SCH & "").Rows(i)(3))
                ListBox3.Items.Add(ds.Tables("" & SCH & "").Rows(i)(4))
                ListBox4.Items.Add(mints)
                ListBox5.Items.Add(chrs)
                ListBox6.Items.Add(timee)
                ListBox7.Items.Add(CONC)
                ListBox8.Items.Add(CONV)
                Total = CONC + CONV
                ListBox9.Items.Add(Total)
                Net = Net + Total
            Next i

            Label32.Text = Net
            Label39.Text = Net
            Dim number As Integer
            If Decimal.TryParse(Label39.Text, number) Then
                Label41.Text = "( Rs." + Numericalpha.GetNumberWords(number) + " only )"
            Else
                Label41.Text = "Invalid Number"
            End If
            MyConn.Close()
        Catch ex As Exception
            MsgBox(" Some Thing Wrong ????")
            Exit Sub
        End Try
        saveassign()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TopMost = False
        Button1.Visible = False
        Button2.Visible = False


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
    Private Sub saveassign()
        Dim str As String
        Dim cname As String
        cname = Convert.ToString(PROGRA & "ALLCOUNSELLINGBILL")
        Try
            ' ([Counsellor_Name] TEXT(150),[Course_Code] TEXT(10),[Course_FullName] TEXT(150),[Lessons] TEXT(15),[Time_From] TEXT(20),[Time_To] TEXT(20),[Amount] TEXT(20)
            str = "insert into [" & cname & "]   values("
            Str += """" & Label11.Text.Trim() & """"
            Str += ","
            Str += """" & Label16.Text.Trim() & """"
            Str += ","
            Str += """" & Label15.Text.Trim() & """"
            Str += ","
            str += """" & Label45.Text.Trim() & """"
            str += ","
            str += """" & timee & """"
            str += ","
            str += """" & Label32.Text.Trim() & """"
            Str += ")"
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            MsgBox("Record inserted successfully...BILL IS SAVED IN  " & "" & cname & " ")

        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            Dim SchemaTable2 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "TCoCHARGES"})
            SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "BCoCHARGES"})
            If SchemaTable1.Rows.Count <> 0 And SchemaTable1.Rows.Count <> 0 Then
                ' DELETE RECORD FROM BOTH 
                '    INSERT RECORD IN BOTH
                MsgBox("Exists and Now Packed USE THIS BUTTON AGAIN")
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table BCoCHARGES")
                Dim cmd8 As New OleDb.OleDbCommand("DROP  Table TCoCHARGES")
                cmd7.Connection = AccessConnection
                cmd8.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                cmd8.ExecuteNonQuery()
                Exit Sub
            Else
                AccessConnection.Close()
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [TCoCHARGES] ([UNAME] TEXT(100),[UADDR1] TEXT(100),[UADDR2] TEXT(100),[NAME] TEXT(50),[CODE] TEXT(20),[CNAME] TEXT(50),[MONTH] TEXT(20),[PROGRAMME] TEXT(100),[PCODE] TEXT(12),[AMOUNT] TEXT(10),[AMIN_WORDS] TEXT(100))", Conn)
                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [BCoCHARGES] ([DATES] TEXT(10),[TIME_FROM] TEXT(10),[TIME_TO] TEXT(10),[D3A] TEXT(12),[D3B] TEXT(12),[DRC] TEXT(12),[CHARGES] TEXT(4),[CONVEY] TEXT(4),[TOTALA] TEXT(10))", Conn)
                    cmd.Connection = Conn
                    cmd1.Connection = Conn
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
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
                    Str1 = "insert into [BCoCHARGES] values('" & ListBox1.Items.Item(i) & "','" & ListBox2.Items.Item(i) & "','" & ListBox3.Items.Item(i) & "','" & ListBox4.Items.Item(i) & "','" & ListBox5.Items.Item(i) & "','" & ListBox6.Items.Item(i) & "','" & ListBox7.Items.Item(i) & "','" & ListBox8.Items.Item(i) & "','" & ListBox9.Items.Item(i) & "')"
                    Dim TOP As OleDbCommand = New OleDbCommand(Str1, Con)
                    TOP.ExecuteNonQuery()
                Next i
                MsgBox("Record inserted successfully...")
                Str = "insert into [TCoCHARGES] values('" & Label1.Text & "','" & Label4.Text & "','" & Label5.Text & "','" & Label7.Text & "','" & Label9.Text & "','" & Label11.Text & "','" & Label13.Text & "','" & Label15.Text & "','" & Label16.Text & "','" & Label39.Text & "','" & Label41.Text & "')"
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
        CO_CHARGES__VIEWER.Show()
    End Sub
   
End Class