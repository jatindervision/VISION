Imports System
Imports System.Data.OleDb
Public Class FORCOUNSELLORCHARGES
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim da3 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim source2 As New BindingSource
    Dim source3 As New BindingSource
    Dim source4 As New BindingSource
    Dim position As Integer = -1
    Dim SCH As String
    Private ourse = counst.TextBox1.Text.Trim()
    Dim Bill As String
    Dim idates As String
    Dim BBT As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Visible = False
        ListBox1.Items.Clear()
        ListBox1.Visible = False
       
        DataGridView2.Visible = True
        DataGridView3.Visible = True
        SCH = Convert.ToString(ourse & "SCHEDULE")
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da1 = New OleDbDataAdapter("Select DATE_,Time_From,Time_To,Course_Code,Academic_Counselor from [" & SCH & "] Where Academic_Counselor='" & TextBox8.Text.Trim() & "'  and  Course_Code = '" & TextBox3.Text.Trim() & "'", MyConn)
            'and Course_Code = '" & TextBox3.Text.Trim() & "'", MyConn)
            da1.Fill(ds, "" & SCH & "")
            Dim view As New DataView(tables(0))
            source2.DataSource = view
            DataGridView2.DataSource = view
            MyConn.Close()
        Catch ex As Exception
        End Try



        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da2 = New OleDbDataAdapter("Select DATE_,Time_From,Time_To,Course_Code,Academic_Counselor from [" & SCH & "] Where Academic_Counselor='" & TextBox8.Text.Trim() & "'", MyConn)
            ' and  Course_Code <> '" & TextBox3.Text.Trim() & "'", MyConn)
            da2.Fill(ds, "" & SCH & "")
            Dim view As New DataView(tables(0))
            source3.DataSource = view
            DataGridView3.DataSource = view
            MyConn.Close()
        Catch ex As Exception
        End Try
        MsgBox("::::::FOR NEXT STEP Select COURSE CODE FROM TOP TABLE AND ENTER VALUES THEN PRESS SUBMIT :: BOTTOM TABLE SHOWING ALL SCHEDULE OF YOUR SELECTED COUNSELLOR :: ON REVISED DATES LEAVE THE CONVEYANCE CHARGE FILED EMPTY :::::: CHECK REVISED DATES BY REVISED DATE BUTTON")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub FORCOUNSELLORCHARGES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORCOUNCHARGES()
        Me.CenterToScreen()
        ' Me.TopMost = True
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        ListBox1.Visible = False
        TextBox11.Text = "20 Minutes"
        TextBox12.Text = " 2:10 HRS"
        TextBox13.Text = "3 HRS"
        
        Label7.Text = ourse
        Try
            Dim BILL As String
            BILL = Convert.ToString(ourse & "ALLCOUNSELLINGBILL")

            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & BILL & ""})
            If SchemaTable.Rows.Count <> 0 Then
                MsgBox("Exists ")
            Else
                Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim Conn As New OleDb.OleDbConnection(ConStr)
                Dim createTable As New OleDb.OleDbCommand
                createTable.Connection = Conn
                createTable.CommandType = CommandType.Text

                Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" & BILL & "] ([Counsellor_Name] TEXT(150),[Course_Code] TEXT(10),[Course_FullName] TEXT(150),[Lessons] TEXT(15),[TIME] TEXT(20),[Amount] TEXT(20))", Conn)
                'Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [AssignmentMarks] ([SNO]) WITH PRIMARY", Conn)
                'cmd1.CommandType = System.Data.CommandType.Text
                cmd.Connection = Conn
                Conn.Open()
                cmd.ExecuteNonQuery()
                Conn.Close()
            End If
            AccessConnection.Close()
        Catch ex As Exception
        End Try
        SCH = Convert.ToString(ourse & "SCHEDULE")
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select DATE_,Time_From,Time_To,Course_Code,Academic_Counselor from [" & SCH & "]", MyConn)
            da.Fill(ds, "" & SCH & "")

            Dim view As New DataView(tables(0))
            source2.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
      
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = TextBox2.Text.Replace(" ", "")
        TextBox2.Text = TextBox2.Text.Trim()
        Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
        Dim SchemaTable1 As DataTable
        AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        AccessConnection.Open()
        SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & TextBox2.Text.Trim() & ""})
        If SchemaTable1.Rows.Count <> 0 Then
            ' DELETE RECORD FROM BOTH 
            '    INSERT RECORD IN BOTH
            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)
            Dim createTable As New OleDb.OleDbCommand
            createTable.Connection = Conn
            createTable.CommandType = CommandType.Text
            Dim cmd1 As New OleDb.OleDbCommand("INSERT INTO [" & TextBox2.Text.Trim() & " ] (DATES, Time_From, Time_To, Course_Code, Academic_Counselor, Allowances, Charges) VALUES('" & TextBox1.Text.Trim() & "','" & TextBox9.Text.Trim() & "','" & TextBox10.Text.Trim() & "','" & TextBox3.Text.Trim() & "','" & TextBox8.Text.Trim() & "','" & TextBox5.Text.Trim() & "','" & TextBox6.Text.Trim() & "')", Conn)
            Conn.Open()
            cmd1.ExecuteNonQuery()
            Conn.Close()
            AccessConnection.Close()
        Else
            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)
            Dim createTable As New OleDb.OleDbCommand
            createTable.Connection = Conn
            createTable.CommandType = CommandType.Text
            Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" & TextBox2.Text.Trim() & "] ([DATES] TEXT(10),[Time_From] Text(15),[Time_To] Text(15),[Course_Code] TEXT(10),[Academic_Counselor] Text(100),[Allowances] INTEGER ,[Charges] INTEGER)", Conn)
            Dim cmd1 As New OleDb.OleDbCommand("INSERT INTO [" & TextBox2.Text.Trim() & "] (DATES, Time_From, Time_To, Course_Code, Academic_Counselor, Allowances, Charges) VALUES('" & TextBox1.Text.Trim() & "','" & TextBox9.Text.Trim() & "','" & TextBox10.Text.Trim() & "','" & TextBox3.Text.Trim() & "','" & TextBox8.Text.Trim() & "','" & TextBox5.Text.Trim() & "','" & TextBox6.Text.Trim() & "')", Conn)
            cmd.Connection = Conn
            Conn.Open()
            cmd.ExecuteNonQuery()
            cmd1.ExecuteNonQuery()
            Conn.Close()
            AccessConnection.Close()
        End If
       
     
        CHARGESCOUN123.Show()
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Visible = True
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        ListBox1.Items.Clear()
        ListBox1.Visible = False
       
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox9.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox10.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox8.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
       
        MsgBox(":::: PRESS PROCEED TO SEARCH YOUR SELCTED COUNSELOR'S DATA IN SCHEDULE ::::")
    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        TextBox9.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        TextBox10.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        TextBox3.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value
        TextBox2.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value
        TextBox8.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value

    End Sub
    Private Sub insertt()
        Try
            Dim iDATES, iTime_From, iTime_To, iCourse_Code, iAcademic_Counselor As String
            For x As Integer = 0 To DataGridView2.Rows.Count - 1
                iDATES = DataGridView2.Rows(x).Cells(0).Value.ToString
                iTime_From = DataGridView2.Rows(x).Cells(1).Value.ToString
                iTime_To = DataGridView2.Rows(x).Cells(2).Value.ToString
                iCourse_Code = DataGridView2.Rows(x).Cells(3).Value.ToString
                iAcademic_Counselor = DataGridView2.Rows(x).Cells(4).Value.ToString
                Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim sqlquery As String = "INSERT INTO [" & TextBox2.Text & " ] (DATES, Time_From, Time_To, Course_Code, Academic_Counselor) VALUES (@DATES, @Time_From, @Time_To, @Course_Code, @Academic_Counselor)"
                Using aconn = New System.Data.OleDb.OleDbConnection(cnString)
                    Using com = New System.Data.OleDb.OleDbCommand(sqlquery, aconn)
                        aconn.Open()

                        com.Parameters.AddWithValue("@DATES", iDATES.ToString)
                        com.Parameters.AddWithValue("@Time_From", iTime_From.ToString)
                        com.Parameters.AddWithValue("@Time_To", iTime_To.ToString)
                        com.Parameters.AddWithValue("@Course_Code", iCourse_Code.ToString)
                        com.Parameters.AddWithValue("@Academic_Counselor", iAcademic_Counselor.ToString)

                        com.ExecuteNonQuery()
                    End Using
                End Using
            Next
            MessageBox.Show("Saved Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
       
              
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox1.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value
        TextBox9.Text = DataGridView3.Rows(e.RowIndex).Cells(1).Value
        TextBox10.Text = DataGridView3.Rows(e.RowIndex).Cells(2).Value
        TextBox3.Text = DataGridView3.Rows(e.RowIndex).Cells(3).Value
        TextBox2.Text = DataGridView3.Rows(e.RowIndex).Cells(4).Value
        TextBox8.Text = DataGridView3.Rows(e.RowIndex).Cells(4).Value

        For x As Integer = 0 To DataGridView3.Rows.Count - 1
            If TextBox1.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value Then

                TextBox6.Text = 0
            End If
        Next x
        MsgBox("Already Paid and your Conveyance Charges Set to Zero, Dont' fill")
    End Sub

   

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView1.Visible = False
        DataGridView3.Visible = False
        ListBox1.Items.Clear()
        ListBox1.Visible = True
      
        BBT = Convert.ToString(ourse & "SCHEDULE")

        For intI As Integer = 0 To DataGridView3.Rows.Count - 2
            For intJ As Integer = intI + 1 To DataGridView3.Rows.Count - 2
                If DataGridView3.Rows(intI).Cells(0).Value = DataGridView3.Rows(intJ).Cells(0).Value Then
                    ListBox1.Items.Add(DataGridView3.Rows(intJ).Cells(0).Value.ToString)

                End If
            Next
        Next
        If ListBox1.Items.Count > 0 Then
            MsgBox("::::NOTE THESE DATES ON YOUR NOTEBOOK:::::ENTER CONVEYANCE CHARGES ONE TIME IN THESE DATES ::::")
        Else
            ListBox1.Visible = False
            DataGridView3.Visible = True
            Exit Sub
        End If

    End Sub
End Class