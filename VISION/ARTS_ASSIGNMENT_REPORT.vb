Imports System.Data.OleDb
Imports System.String
Public Class ARTS_ASSIGNMENT_REPORT
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Public Course As String = ARTS_ASSIGNMENT_START.TextBox1.Text.Trim()
    Dim coursename As String
    Dim CCNAME As String
    Private Sub ARTS_ASSIGNMENT_REPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ASSARTS()
        Me.CenterToScreen()
        Me.TopMost = True
        TextBox4.Text = DateTimePicker1.Value.ToShortDateString

        Me.Text = "You have Entered:-- " + Course
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
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            da1 = New OleDbDataAdapter("SELECT * FROM Name", MyConn)
            da1.Fill(ds, "Name")
            Label13.Text = ds.Tables("Name").Rows(CurrentRow)("University_Name")
            Label14.Text = ds.Tables("Name").Rows(CurrentRow)("Reg_No")
            Label15.Text = ds.Tables("Name").Rows(CurrentRow)("Code")
            Label16.Text = ds.Tables("Name").Rows(CurrentRow)("Coordinator_Name")
            Label17.Text = ds.Tables("Name").Rows(CurrentRow)("Co_Addr1")
            Label18.Text = ds.Tables("Name").Rows(CurrentRow)("Co_Add2")
            Label22.Text = ds.Tables("Name").Rows(CurrentRow)("PLACE")
            MyConn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ASSIGNMENTVIEWER.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
                MsgBox(" Don't Leave Any field Empty!!!")
                Exit Sub
            End If
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da = New OleDbDataAdapter("SELECT CRS1,CRS2,CRS3,CRS4,CRS5,CRS6,CRS7,CRS8,CRS9,CRS10,CRS11,CRS12,CRS13 FROM [" & Course & "] ORDER BY SNO", MyConn)
            da.Fill(ds, " & TextBox2.Text.Trim() & ")
            coursename = ds.Tables(" & TextBox2.Text.Trim() & ").Rows(0)(TextBox2.Text.Trim())
            If coursename <> TextBox1.Text.Trim() Then
                MsgBox("Your Course Code and Header or Not same Click Again of Assignment Evaluation Bill")
                MyConn.Close()
                Exit Sub
            Else
                MyConn.Close()
            End If
        Catch ex As Exception
        End Try

        Try
            CCNAME = Convert.ToString(Course & "AssignmentMarks")
            Dim cmd5 As New OleDb.OleDbCommand("INSERT INTO  ASSIGNMENTBOTTOM (SNO,Enrollment,StName,Course_Col) SELECT SNO, ENROLL, STUDENT_NAME ," & Me.TextBox2.Text.Trim() & " FROM [" & CCNAME & "]", Con)
            Con.Open()
            cmd5.ExecuteNonQuery()
            Dim str As String
            str = "INSERT INTO  ASSIGNMENTTOP VALUES("
            str += """" & 1 & """"
            str += ","
            str += """" & Label13.Text & """"
            str += ","
            str += """" & Label22.Text & """"
            str += ","
            str += """" & Label15.Text & """"
            str += ","
            str += """" & Label14.Text & """"
            str += ","
            str += """" & TextBox1.Text.Trim() & """"
            str += ","
            str += """" & TextBox5.Text.Trim() & """"
            str += ","
            str += """" & TextBox6.Text.Trim() & """"
            str += ","
            str += """" & TextBox7.Text.Trim() & """"
            str += ","
            str += """" & Label16.Text & """"
            str += ","
            str += """" & TextBox4.Text.Trim() & """"
            str += ","
            str += """" & Label17.Text & """"
            str += ","
            str += """" & Label18.Text & """"
            str += ","
            str += """" & TextBox3.Text.Trim() & """"
            str += ")"
            Cmd = New OleDbCommand(str, Con)
            Cmd.ExecuteNonQuery()
            MsgBox("Success")
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class