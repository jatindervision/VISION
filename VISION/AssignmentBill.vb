Imports System
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class AssignmentBill
    Private Form As New Assforbill
    Dim dates As String = Assforbill.TextBox1.Text.Trim()
    Private codes As String = Assforbill.TextBox2.Text.Trim()
    Dim fname As String = Assforbill.TextBox3.Text.Trim()
    Dim ano As String = Assforbill.TextBox4.Text.Trim()
    Dim lno As String = Assforbill.TextBox5.Text.Trim()
    Dim VIDEno As String = Assforbill.TextBox6.Text.Trim()
    Dim ACharge As String = Assforbill.TextBox7.Text.Trim()
    Dim Ccol As String = Assforbill.TextBox8.Text.Trim()
    Dim COURSESEM As String = Assforbill.TextBox9.Text.Trim()
    Dim EVNAME As String = Assforbill.TextBox10.Text.Trim()

    Dim wordd As Integer
    Dim WW As String
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
    Dim fieldname As String
    Dim totala As Integer
    Dim achargea As Integer
    Dim bills As String

    Dim i As Integer = 0
    Private Sub AssignmentBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ForAbill()
        Me.CenterToScreen()
        Me.TopMost = True
        Label12.Text = fname
        Dim d As Date
        Dim y As String
        If Date.TryParse(dates, d) Then
            y = d.Year
            Label28.Text = y
        End If
        Label29.Text = codes
        Label32.Text = ACharge
        Label40.Text = dates
        Label46.Text = dates
        Label54.Text = dates
        Label56.Text = dates
        Label68.Text = codes
        Label30.Text = ano
        Label38.Text = lno
        Label52.Text = VIDEno
        Try

            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            ' da1 = New OleDbDataAdapter("Select * from [" & ANAME & "]", MyConn)
            da2 = New OleDbDataAdapter("Select * from [Name]", MyConn)
            'da3 = New OleDbDataAdapter("Select * from [AEvaluator]", MyConn)
            ' da1.Fill(ds, "" & ANAME & "")
            da2.Fill(ds, "Name")
            'da3.Fill(ds, "AEvaluator")
            Label7.Text = ds.Tables("Name").Rows(0)("Name")
            Label9.Text = ds.Tables("Name").Rows(0)("Code")
            Label43.Text = ds.Tables("Name").Rows(0)("Code")
            Label16.Text = ds.Tables("Name").Rows(0)("CAddr1")
            Label48.Text = ds.Tables("Name").Rows(0)("CAddr2")
            Label3.Text = ds.Tables("Name").Rows(0)("University_Name")
            Label4.Text = ds.Tables("Name").Rows(0)("University_Add1")
            Label5.Text = ds.Tables("Name").Rows(0)("University_Add2")
            Label14.Text = EVNAME
            MyConn.Close()
        Catch ex As Exception
            MsgBox(" Some Thing Wrong HAVE YOU COLLEGE NAME ????")
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            MyConn.Open()
            Dim ANAME As String
            ANAME = Convert.ToString(COURSESEM & "AssignmentMarks")
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT COUNT(" & Ccol & ") FROM  [" & ANAME & "] WHERE " & Ccol & " <> 'ABSENT' OR " & Ccol & " <> 'Absent'", MyConn)
            Dim count As Int32 = cmd.ExecuteScalar
            Label31.Text = count
            i = Convert.ToInt32(ACharge)
            totala = count * i
            Label34.Text = totala
            Label69.Text = totala

            Dim number As Integer
            If Decimal.TryParse(Label34.Text, number) Then
                Label49.Text = Numericalpha.GetNumberWords(number) + " only" + " (Rs:-" + Label34.Text + ".00)"
                Label58.Text = Numericalpha.GetNumberWords(number) + " only" + " (Rs:-" + Label34.Text + ".00)"
            Else
                Label1.Text = "Invalid Number"
            End If
            MyConn.Close()
        Catch ex As Exception
            MsgBox("Have you entered Assignment Marks ????")
        End Try
        saveassign()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Me.TopMost = False
        With Me.PrintForm1
            .PrintAction = Printing.PrintAction.PrintToPreview
            Dim MyMargins As New Margins
            With MyMargins
                .Left = 1
                .Right = 0.2
                .Top = 0.8
                .Bottom = 0.5
            End With
            .PrinterSettings.DefaultPageSettings.Margins = MyMargins
            .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)

        End With
    End Sub
    Private Sub saveassign()
        Dim str As String
        bills = (COURSESEM & "ALLASSIGNBILL")
        
        Try
            str = "insert into [" & bills & "]   values("
            str += """" & Me.Label14.Text.Trim() & """"
            Str += ","
            str += """" & Me.Label68.Text.Trim() & """"
            Str += ","
            str += """" & Me.Label12.Text.Trim() & """"
            Str += ","
            str += """" & Me.Label28.Text.Trim() & """"
            Str += ","
            str += """" & Me.Label30.Text.Trim() & """"
            Str += ","
            str += """" & Me.Label31.Text.Trim() & """"
            Str += ","
            str += """" & Me.Label32.Text.Trim() & """"
            Str += ","
            str += """" & Me.Label34.Text.Trim() & """"
            str += ")"
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Record inserted successfully...BILL IS SAVED IN  " & "" & bills & " ")
        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try

    End Sub
    Private Sub SAVE()
        Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        bills = (codes & "ASSIGNBILL")
        Dim StatusDate As String
        Dim Course As String
        StatusDate = InputBox("Input This  Name in BOX", "" & BILLS & "", "  ")
        Course = Convert.ToString(StatusDate)
       
        Dim squery As String = "INSERT INTO " & BILLS & " (Evaluator_Name,Course_Code,Course_FullName,Year,Assignment_No,Total_Assignment,Rate,Amount) VALUES (@Evaluator_Name,@Course_Code,@Course_FullName,@Year,@Assignment_No,@Total_Assignment,@Rate,@Amount)"
        Using connec = New System.Data.OleDb.OleDbConnection(cnString)
            Using com = New System.Data.OleDb.OleDbCommand(squery, connec)
                connec.Open()

                com.Parameters.AddWithValue("@Evaluator_Name", Label14.Text.Trim())
                com.Parameters.AddWithValue("@Course_Code", Label68.Text.Trim())
                com.Parameters.AddWithValue("@Course_FullName", Label12.Text.Trim())
                com.Parameters.AddWithValue("@Year", Label28.Text.Trim())
                com.Parameters.AddWithValue("@Assignment_No", Label30.Text.Trim())
                com.Parameters.AddWithValue("@Total_Assignment", Label31.Text.Trim())
                com.Parameters.AddWithValue("@Rate", Label32.Text.Trim())
                com.Parameters.AddWithValue("@Amount", Label34.Text.Trim())
                
                com.ExecuteNonQuery()

            End Using
        End Using

        MessageBox.Show("Saved Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub CREATETABLE()
      
        Try
            Dim asstable As String
            asstable = Convert.ToString(Label29.Text.Trim & "-BILL")
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, " & asstable & "})
            If SchemaTable.Rows.Count <> 0 Then
                MsgBox("Repeated Same Course , It Exists and Packed Now , Do Same Job Again")
                Dim cmd As New OleDb.OleDbCommand("DROP  Table " & asstable & "")
                cmd.Connection = Con
                Con.Open()
                cmd.ExecuteNonQuery()
                Con.Close()
            Else

                Try
                    'Dim ConStr As String = "ProvIder=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\shx.mdb;Persist Security Info=True"
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" & asstable & "] ([Course_Code] TEXT(10),[Course_Full_Name] TEXT(100), [Amount] TEXT(10))", Conn)
                    cmd.Connection = Conn
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If


            Try
                Dim str As String
                Str = "insert into [" & asstable & "]   values("
                Str += """" & Label29.Text.Trim() & """"
                Str += ","
                Str += """" & Label12.Text.Trim() & """"
                Str += ","
                Str += """" & Label34.Text.Trim() & """"
                Str += ")"
                Con.Open()
                Cmd = New OleDbCommand(Str, Con)
                Cmd.ExecuteNonQuery()
                MsgBox("Record inserted successfully...BILL IS SAVED IN  " & "" & asstable & " ")
                Con.Close()
            Catch ex As Exception
                MsgBox(ex.Message & " -  " & ex.Source)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        Dim MyConn As OleDbConnection
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        Dim Str1 As String
        MyConn.Open()
        Str1 = "INSERT INTO  [ASSBILLTOP] VALUES ('" & Label3.Text.Trim() & "','" & Label4.Text.Trim() & "','" & Label5.Text.Trim() & "','" & Label7.Text.Trim() & "','" & Label9.Text.Trim() & "','" & Label12.Text.Trim() & "','" & Label68.Text.Trim() & "','" & Label14.Text.Trim() & "','" & Label16.Text.Trim() & "','" & Label48.Text.Trim() & "','" & Label28.Text.Trim() & "','" & Label30.Text.Trim() & "','" & Label31.Text.Trim() & "','" & Label32.Text.Trim() & "','" & Label34.Text.Trim() & "','" & Label38.Text.Trim() & "','" & Label40.Text.Trim() & "','" & Label49.Text.Trim() & "','" & Label69.Text.Trim() & "','" & Label52.Text.Trim() & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(Str1, MyConn)
        Cmd.ExecuteNonQuery()
        MyConn.Close()
        assbillviewer.Show()
    End Sub
End Class