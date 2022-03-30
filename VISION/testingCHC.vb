Imports System
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class testingCHC
    Private form As New forLabtesting
    Private coursename As String = forLabtesting.TextBox3.Text.Trim()
    Private coursecode As String = forLabtesting.TextBox2.Text.Trim()
    Private ccd As String = forLabtesting.TextBox1.Text.Trim()
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim db_reader As OleDbDataReader
    Dim source1 As New BindingSource
    Dim DT As DataTable
    Dim tables As DataTableCollection
    Dim ATT As String
    Dim SCH As String
    Private Sub testingCHC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chctesting()
        Me.CenterToScreen()
        Me.TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ATT = Convert.ToString(coursecode & "ATTENDANCE")
        Try
            listclear1()
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            MyConn.Open()
            ' Make a SELECT Command.
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT DATE_,COUNT(ATTENDANCE) FROM [" & ATT & "] WHERE ATTENDANCE = 'Present'  GROUP BY DATE_", MyConn)

            ' Execute the query.
            db_reader = cmd.ExecuteReader(CommandBehavior.Default)


            ' Display the results.
            Dim txt1 As String
            Dim txt2 As String
            Dim i As Integer
            Dim C As Decimal
            Dim SN As Integer
            Do While db_reader.Read
                txt1 = db_reader.Item(0).ToString
                txt2 = db_reader.Item(1).ToString
                C = (Convert.ToInt32(txt2) / 2)
                If C = 24.5 Then C = 25
                Dim MyVar2 As Double = Math.Round(C)
                'Dim MyVar2 As Double = Math.Round(C)


                For i = 1 To db_reader.FieldCount - 1
                    SN = SN + 1
                    ' txt &= vbTab & db_reader.Item(i).ToString
                    ListBox8.Items.Add(SN)
                    ListBox1.Items.Add(txt1)
                    ListBox2.Items.Add(txt2)
                    ListBox3.Items.Add(MyVar2)
                   
                    ListBox9.Items.Add(txt1)
                Next i
                ' ListBox1.Items.Add(txt)
            Loop
            MyConn.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SCH = Convert.ToString(coursename & "SCHEDULE")
        Label12.Text = SCH
        Try
            listclear2()
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT * FROM [" & SCH & "] WHERE Course_Code =   '" & ccd & "'   ", MyConn)
            da.Fill(ds, "" & SCH & "")
            MyConn.Open()
            Dim i As Integer
            For i = 0 To ds.Tables("" & SCH & "").Rows.Count - 1 Step 1
                ListBox4.Items.Add(ds.Tables("" & SCH & "").Rows(i)("Date_"))
                ListBox5.Items.Add(ds.Tables("" & SCH & "").Rows(i)("Time_From"))
                ListBox6.Items.Add(ds.Tables("" & SCH & "").Rows(i)("Time_To"))
                ListBox7.Items.Add(ds.Tables("" & SCH & "").Rows(i)("Course_Code"))
            Next i
            MyConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try

    End Sub
    Private Sub listclear1()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox8.Items.Clear()
    End Sub
    Private Sub listclear2()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try

            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "testingchc"})
            If SchemaTable.Rows.Count <> 0 Then
                Try
                    Dim i As Integer
                    Dim Str As String
                    Con.Open()
                    For i = 0 To ListBox1.Items.Count - 1
                        Str = "insert into [testingchc] values('" & Me.ListBox1.Items.Item(i) & "','" & Me.ListBox2.Items.Item(i) & "','" & Me.ListBox3.Items.Item(i) & "','" & Me.ListBox4.Items.Item(i) & "','" & Me.ListBox5.Items.Item(i) & "','" & Me.ListBox6.Items.Item(i) & "')"
                        Dim Scmd As OleDbCommand = New OleDbCommand(Str, Con)
                        Scmd.ExecuteNonQuery()
                    Next
                    MsgBox("Record inserted successfully...")
                    Con.Close()
                    AccessConnection.Close()
                Catch ex As Exception
                    MessageBox.Show("Could Not Insert Record!!!")
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try

                Chc.Show()
            Else
                Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim Conn As New OleDb.OleDbConnection(ConStr)
                Dim createTable As New OleDb.OleDbCommand
                createTable.Connection = Conn
                createTable.CommandType = CommandType.Text
                Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [testingchc] ([Date_fromLab] TEXT(10),[No_Att] TEXT(10),[Pc] INTEGER,[Date_from_Sc] TEXT(10),[Time_From] Text(5),[Time_To] TEXT(5))", Conn)
                cmd.Connection = Conn
                Conn.Open()
                cmd.ExecuteNonQuery()
                Conn.Close()
                Try
                    Dim i As Integer
                    Dim Str As String
                    Con.Open()
                    For i = 0 To ListBox1.Items.Count - 1
                        Str = "insert into [testingchc] values('" & ListBox1.Items.Item(i) & "','" & ListBox2.Items.Item(i) & "','" & ListBox3.Items.Item(i) & "','" & ListBox4.Items.Item(i) & "','" & ListBox5.Items.Item(i) & "','" & ListBox6.Items.Item(i) & "' )"
                        Dim Scmd As OleDbCommand = New OleDbCommand(Str, Con)
                        Scmd.ExecuteNonQuery()
                    Next
                    MsgBox("Record inserted successfully...")
                    Con.Close()
                    AccessConnection.Close()
                Catch ex As Exception
                    MessageBox.Show("Could Not Insert Record!!!")
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try

                Chc.Show()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        ChcPrint.Show()
    End Sub
  
End Class