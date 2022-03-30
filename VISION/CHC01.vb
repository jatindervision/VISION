
Imports System.Data.OleDb
Public Class CHC01
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim db_reader As OleDbDataReader
    Private SCHEDULE As String = MROREPOSTART.TextBox1.Text.Trim()
    Dim Coursename As String
    Private Sub CHC01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CH01REPO()
        Me.CenterToScreen()
        Me.TopMost = True
        TextBox6.Text = DateTimePicker1.Value.ToShortDateString
        Dim sch As String
        sch = Convert.ToString(SCHEDULE & "SCHEDULE")
        Try
            'Label16.Text = sch
            Label24.Text = sch
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da2 = New OleDbDataAdapter("SELECT Course_Code FROM [" & sch & "] ORDER BY SNO", MyConn)
            da2.Fill(ds, " & sch & ")
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox8.Text = "" And TextBox7.Text = "" And TextBox6.Text = "" And TextBox4.Text = "" Then
            MsgBox("FILL ALL THE FILEDS ")
            Exit Sub
        End If
        Try
            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)

            Dim i As Integer
            Dim Str As String
            Dim Str1 As String
            Con.Open()
            For i = 0 To ListBox1.Items.Count - 1
                Str = "insert into [ONETWOPLUS] values('" & ListBox7.Items.Item(i) & "','" & ListBox6.Items.Item(i) & "','" & ListBox5.Items.Item(i) & "','" & ListBox4.Items.Item(i) & "','" & ListBox3.Items.Item(i) & "','" & ListBox2.Items.Item(i) & "','" & ListBox1.Items.Item(i) & "')"
                Dim Scmd As OleDbCommand = New OleDbCommand(Str, Con)
                Scmd.ExecuteNonQuery()
            Next i
            Str1 = "insert into [CHCTOP] values('" & 1 & "','" & Label13.Text.Trim() & "','" & Label15.Text.Trim() & "','" & TextBox7.Text.Trim() & "','" & Label17.Text.Trim() & "','" & Label18.Text.Trim() & "','" & TextBox4.Text.Trim() & "','" & TextBox8.Text.Trim() & "','" & TextBox3.Text.Trim() & "','" & TextBox6.Text.Trim() & "','" & Label16.Text.Trim() & "','" & Label20.Text.Trim() & "' )"
            Dim TOP As OleDbCommand = New OleDbCommand(Str1, Con)
            TOP.ExecuteNonQuery()
            MsgBox("Record inserted successfully...")
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = "" And TextBox5.Text = "" And TextBox9.Text = "" Then
            MsgBox("FILL ALL THE FIELDS")
        End If
        Coursename = Convert.ToString(TextBox3.Text.Trim() & "ATTENDANCE")
        Try

            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            MyConn.Open()

            ' Make a SELECT Command.
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT DATE_,COUNT(ATTENDANCE) FROM [" & Coursename & "] WHERE ATTENDANCE <> 'ABSENT' OR ATTENDANCE <> 'Absent' GROUP BY DATE_", MyConn)

            ' Execute the query.
            db_reader = cmd.ExecuteReader(CommandBehavior.Default)


            ' Display the results.
            Dim txt1 As String
            Dim txt2 As String
            Dim i As Integer
            Dim C As Decimal
            Dim RATE As Integer
            Dim Amount As Integer
            Dim Tot As Integer
            Dim hrch As Integer
            Dim AMT As Integer
            Do While db_reader.Read
                txt1 = db_reader.Item(0).ToString
                txt2 = db_reader.Item(1).ToString
                C = (Convert.ToInt32(txt2) / 2)
                If C = 24.5 Then C = 25
                Dim MyVar2 As Double = Math.Round(C)

                    RATE = Convert.ToInt32(TextBox5.Text.Trim())
                    hrch = Convert.ToInt32(TextBox9.Text.Trim())
                    AMT = (RATE * hrch)
                    Amount = (AMT * MyVar2)
                    Tot = Tot + Amount
                    For i = 1 To db_reader.FieldCount - 1

                        ' txt &= vbTab & db_reader.Item(i).ToString

                        ' ListBox6.Items.Add(txt1)
                        ListBox4.Items.Add(txt2)
                        ListBox3.Items.Add(MyVar2)
                        ListBox2.Items.Add(RATE)
                        ListBox1.Items.Add(Amount)
                    Next i
                    ' ListBox1.Items.Add(txt)

            Loop
            Label16.Text = Tot
            Dim num As Integer
            If Decimal.TryParse(Label16.Text, num) Then
                Label20.Text = Numericalpha.GetNumberWords(num) + " only"
            Else
                Label20.Text = "Invalid Number"
            End If
        Catch ex As Exception
        End Try
        MyConn.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            MsgBox("CHOOSE LAB COURSE CODE FROM RIGHT PANE")
            Exit Sub
        End If
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable4 As DataTable
            Dim SchemaTable5 As DataTable
            Dim SchemaTable6 As DataTable
            Dim SchemaTable7 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable4 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "CHCTOP"})
            SchemaTable5 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "CHCBOTTOMONE"})
            SchemaTable6 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "CHCBOTTOMTWO"})
            SchemaTable7 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "ONETWOPLUS"})
            If SchemaTable4.Rows.Count = 0 And SchemaTable5.Rows.Count = 0 And SchemaTable6.Rows.Count = 0 And SchemaTable7.Rows.Count = 0 Then
                ' DELETE RECORD FROM BOTH 
                '    INSERT RECORD IN BOTH
                MsgBox("USE BUTTON 1 FIRST ")

                AccessConnection.Close()
                Exit Sub
            End If
             Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Try

            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT * FROM [" & Label24.Text.Trim() & "] WHERE Course_Code =   '" & TextBox1.Text.Trim() & "'   ", MyConn)
            da.Fill(ds, "" & Label24.Text.Trim() & "")
            MyConn.Open()
            Dim i As Integer
            For i = 0 To ds.Tables("" & Label24.Text.Trim() & "").Rows.Count - 1 Step 1


                ListBox7.Items.Add(ds.Tables("" & Label24.Text.Trim() & "").Rows(i)("Date_"))
                ListBox6.Items.Add(ds.Tables("" & Label24.Text.Trim() & "").Rows(i)("Time_From"))
                ListBox5.Items.Add(ds.Tables("" & Label24.Text.Trim() & "").Rows(i)("Time_To"))

            Next i
            MsgBox(" SUCCESS , NOW PRESS BUTTON THREE  , AMOUNT WILL BE DISPLAYED , THEN FILL REST OF FIELDS AND PRESS CREATE REPORT")

        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        MyConn.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "" And TextBox3.Text = "" Then
            MsgBox("FILL ABOVE FIELDS")
            Exit Sub
        End If
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            Dim SchemaTable2 As DataTable
            Dim SchemaTable3 As DataTable
            Dim SchemaTable4 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "CHCTOP"})
            SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "CHCBOTTOMONE"})
            SchemaTable3 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "CHCBOTTOMTWO"})
            SchemaTable4 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "ONETWOPLUS"})
            If SchemaTable1.Rows.Count <> 0 And SchemaTable2.Rows.Count <> 0 And SchemaTable3.Rows.Count <> 0 And SchemaTable4.Rows.Count <> 0 Then
                ' DELETE RECORD FROM BOTH 
                '    INSERT RECORD IN BOTH
                MsgBox("Exists and Now Packed , Press Button 1 Again ")
                Dim cmd1 As New OleDb.OleDbCommand("DROP  Table CHCTOP")
                Dim cmd2 As New OleDb.OleDbCommand("DROP  Table CHCBOTTOMONE")
                Dim cmd3 As New OleDb.OleDbCommand("DROP  Table CHCBOTTOMTWO")
                Dim cmd4 As New OleDb.OleDbCommand("DROP  Table ONETWOPLUS")
                cmd1.Connection = AccessConnection
                cmd2.Connection = AccessConnection
                cmd3.Connection = AccessConnection
                cmd4.Connection = AccessConnection
                cmd1.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()
                cmd3.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                AccessConnection.Close()
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text

                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [CHCTOP] ([SNO] INTEGER,[CName] TEXT(100),[Code] TEXT(15),[Prog_Name] TEXT(20),[CAdd1] TEXT(75),[CAdd2] TEXT(75),[Session] TEXT(20),[Course_Name] TEXT(15),[Lab_Code] TEXT(10),[Dates] TEXT(10),[AmDigit] TEXT(6),[AmWords] Text(100))", Conn)
                    Dim cmd2 As New OleDb.OleDbCommand("CREATE TABLE [CHCBOTTOMONE] ([DATES] TEXT(10),[TIMING_FROM] TEXT(10),[TIMING_TO] TEXT(10))", Conn)
                    Dim cmd3 As New OleDb.OleDbCommand("CREATE TABLE [CHCBOTTOMTWO] ([STUDENTS_QTY] TEXT(5),[NO_OF_COMPUTERS] TEXT(5))", Conn)
                    Dim cmd4 As New OleDb.OleDbCommand("CREATE TABLE [ONETWOPLUS] ([DATES] TEXT(10),[TIMING_FROM] TEXT(10),[TIMING_TO] TEXT(10),[STUDENTS_QTY] TEXT(5),[NO_OF_COMPUTERS] TEXT(5),[RATE] TEXT(5),[AMOUNT] TEXT(7))", Conn)
                    cmd1.Connection = Conn
                    cmd2.Connection = Conn
                    cmd3.Connection = Conn
                    cmd4.Connection = Conn
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()
                    cmd4.ExecuteNonQuery()
                    MsgBox("CREATED SUCCESSFULLY FILL FIRST FOUR FIELDS AND PRESS BUTTON 2  ")
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CHCREPORTVIEWER.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub
End Class