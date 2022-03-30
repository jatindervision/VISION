Imports System
Imports System.Data.OleDb
Imports System.String
Public Class schedule1
    Private Coursename = directschedule.TextBox1.Text.Trim()
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim da1 As OleDbDataAdapter
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim source2 As New BindingSource
    Dim StatusDate As String
    Dim id As Integer
    Dim course As String
    Dim SERA As String
    Private Sub schedule1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sch11()
        Me.TopMost = True
        Me.CenterToScreen()
        course = Convert.ToString(Coursename & "-SCHEDULE")
        Try
            CurrentRow = 0
            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM [" & course & "]  ORDER BY SNO", Con)
            Dad.Fill(Dst, "" & course & "")
            ShowData(CurrentRow)
            Con.Close()
        Catch ex As Exception
        End Try
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [" & course & "]", MyConn)
        da.Fill(ds, "" & course & "")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view

    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            TextBox1.Text = Dst.Tables("" & course & "").Rows(CurrentRow)("SNO")
            TextBox2.Text = Dst.Tables("" & course & "").Rows(CurrentRow)("DATE_")
            TextBox3.Text = Dst.Tables("" & Course & "").Rows(CurrentRow)("Semister")
            TextBox4.Text = Dst.Tables("" & course & "").Rows(CurrentRow)("Time_From")
            TextBox5.Text = Dst.Tables("" & course & "").Rows(CurrentRow)("Time_To")
            TextBox6.Text = Dst.Tables("" & course & "").Rows(CurrentRow)("Course_Code")
            TextBox7.Text = Dst.Tables("" & course & "").Rows(CurrentRow)("Academic_Counselor")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox(" Dont Leave Any Field Empty")
            Exit Sub
        End If
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da1 = New OleDbDataAdapter("Select * from [" & course & "]", MyConn)
        da1.Fill(ds, "" & course & "")
        For i As Integer = 0 To ds.Tables("" & course & "").Rows.Count - 1
            If ds.Tables("" & course & "").Rows(i).Item("Date_") = TextBox2.Text.Trim() And
                ds.Tables("" & course & "").Rows(i).Item("Time_From") = TextBox4.Text.Trim() And
                  ds.Tables("" & course & "").Rows(i).Item("Time_To") = TextBox5.Text.Trim() And
                ds.Tables("" & course & "").Rows(i).Item("Academic_Counselor") = TextBox7.Text.Trim() Then
                MsgBox("Your Entered Time and Academic_Counselor is Already Fixed")
                Label3.Text = "Error"
                Label14.Text = TextBox2.Text
                Label12.Text = TextBox3.Text
                Label15.Text = TextBox4.Text
                Label9.Text = TextBox5.Text
                Label4.Text = TextBox7.Text
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                Exit Sub
            End If
        Next i
        Try
            Label3.Text = ""
            Label14.Text = ""
            Label12.Text = ""
            Label15.Text = ""
            Label9.Text = ""
            Label4.Text = ""
            Dim Str As String
            Str = "insert into [" & course & "] values("
            Str += """" & TextBox1.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox2.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox3.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox4.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox5.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox6.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox7.Text.Trim() & """"
            Str += ")"
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Record inserted successfully...")
        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try

        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [" & course & "]", MyConn)
        da.Fill(ds, "" & course & "")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view
        TextBox1.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [" & course & "]", MyConn)
            da.Fill(ds, "" & course & "")
            Dim view As New DataView(tables(0))
            TextBox1.Text = ds.Tables("" & course & "").Rows.Count
            source1.DataSource = view
            DataGridView1.DataSource = view

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        srh()
        Try
            Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim MyConn As OleDbConnection
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("SELECT *  FROM [" & SERA & "] Where SNO=" + TextBox1.Text + "", MyConn)
            da1.Fill(ds, "" & SERA & "")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            For i = 0 To Me.DataGridView1.Columns.Count - 1
                Me.DataGridView1.Columns(i).Name = Me.DataGridView1.Columns(i).DataPropertyName
            Next
            DataGridView1.DataSource = view
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub
    Private Function CheckId()
        Try
            If IsNumeric(TextBox1.Text) = False Then
                ShowData(CurrentRow)
                TextBox1.Focus()
                Return False
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function
    Private Sub srh()
        SERA = Convert.ToString(Coursename & "-SCHEDULE")
        Dim SearchId As Integer
        Dim i, j As Integer
        If CheckId() = False Then
            MsgBox("Integer Value Required!!!")
            Exit Sub
        End If
        Try
            SearchId = TextBox1.Text
            j = Dst.Tables("& SERA &").Rows.Count - 1
            i = 0
            While i <> j + 1
                If SearchId = Dst.Tables("& SERA &").Rows(i)("SNO") Then
                    ShowData(i)
                    Exit While
                ElseIf i = j Then
                    clear()
                    MsgBox("Record Not Found!!!")
                    ShowData(CurrentRow)
                    Exit While
                End If
                i += 1
            End While
            CurrentRow = i
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If CheckId() = False Then
            MsgBox("SNO : Integer Value Required !!!")
            Exit Sub
        End If
        Try
            Dim Str As String
            Str = "update [" & course & "] set [SNO]="
            Str += """" & TextBox1.Text & """"
            Str += " where SNO="
            Str += TextBox1.Text.Trim()
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update [" & course & "] set [Date_]="
            Str += """" & TextBox2.Text & """"
            Str += " where SNO="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update [" & course & "] set [Semister]="
            Str += """" & TextBox3.Text & """"
            Str += " where SNO="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update [" & course & "] set [Time]="
            Str += """" & TextBox4.Text & """"
            Str += " where SNO="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update [" & course & "] set [Course_Code]="
            Str += """" & TextBox5.Text & """"
            Str += " where SNO="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update [" & course & "] set [Academic_Counselor]="
            Str += """" & TextBox6.Text & """"
            Str += " where SNO="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Updated Successfully...")
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [" & course & "]", MyConn)
            da.Fill(ds, "" & course & "")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            TextBox1.Text = ds.Tables("" & course & "").Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message & ",")
        End Try
    End Sub

    Private Sub ExitNow_Click(sender As Object, e As EventArgs) Handles ExitNow.Click
        Me.Close()
    End Sub
    Private Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        DataGridView1.DataSource = Nothing
    End Sub
End Class