Imports System.Data.OleDb
Public Class AssignmentMarks
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim da3 As OleDbDataAdapter
    Dim da4 As OleDbDataAdapter
    Dim da5 As OleDbDataAdapter
    Dim ds As DataSet
    Dim ds1 As DataSet
    Dim ds2 As DataSet
    Dim ds3 As DataSet
    Dim ds4 As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim source2 As New BindingSource
    Dim source3 As New BindingSource
    Dim source4 As New BindingSource
    Private cccourse As String = inputassfilename.TextBox1.Text.Trim
    Dim nname As String
    Dim NON As String
    Private Sub AssignmentMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForASSIGMARKS()
        Me.CenterToScreen()
        Me.TopMost = False
        nname = Convert.ToString(cccourse & "-Assignment-Marks")
        Try
            Dim row As Integer = 0
            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            ' Dim reader As OleDbDataReader = cmd.ExecuteReader()
            da = New OleDbDataAdapter("SELECT * FROM [" & cccourse & "] ORDER BY SNO", MyConn)
            da.Fill(ds, "" & cccourse & "")
            ShowData(CurrentRow)
            SERCHUPPER(CurrentRow)
            evaluator(CurrentRow)
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("Select * from [" & nname & "]", MyConn)
            da1.Fill(ds, "" & nname & "")
            ShowDataMarks(CurrentRow)
            clea11r()
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            CurrentRow = 0
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub
    Private Sub ShowDataMarks(ByVal CurrentRow)
        Try
            TextBox21.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("SNO")
            TextBox20.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("ENROLL")
            TextBox19.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("PROGRAM")
            TextBox18.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("STUDENT_NAME")
            TextBox17.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS1")
            TextBox25.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS2")
            TextBox24.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS3")
            TextBox23.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS4")
            TextBox22.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS5")
            TextBox38.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS6")
            TextBox39.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS7")
            TextBox40.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS8")
            TextBox41.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS9")
            TextBox42.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS10")
            TextBox43.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS11")
            TextBox44.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS12")
            TextBox45.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("CRS13")
            TextBox46.Text = ds.Tables("" & nname & "").Rows(CurrentRow)("MM")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub evaluator(ByVal CurrentRow)
        Try
            Label37.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS1")
            Label39.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS2")
            Label40.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS3")
            Label41.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS4")
            Label45.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS5")
            Label44.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS6")
            Label43.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS7")
            Label42.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS8")
            Label49.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS9")
            Label48.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS10")
            Label47.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS11")
            Label46.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS12")
            Label50.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS13")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            Label7.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("SNO")
            Label8.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("ENRNO")
            Label9.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("PROGRAM")
            Label21.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("NAME")
            Label5.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS1")
            Label6.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS2")
            Label11.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS3")
            Label10.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS4")
            Label13.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS5")
            Label12.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS6")
            Label15.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS7")
            Label14.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS8")
            Label17.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS9")
            Label16.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS10")
            Label19.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS11")
            Label18.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS12")
            Label4.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS13")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SERCHUPPER(CurrentRow)
        Try
            Label36.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS1")
            Label35.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS2")
            Label34.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS3")
            Label33.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS4")
            Label32.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS5")
            Label54.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS6")
            Label53.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS7")
            Label52.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS8")
            Label51.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS9")
            Label24.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS10")
            Label59.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS11")
            Label58.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS12")
            Label57.Text = ds.Tables("" & cccourse & "").Rows(CurrentRow)("CRS13")

        Catch ex As Exception
        End Try
    End Sub
    Private Sub ExitNow_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try

            Dim ABC = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim DEF = "SELECT count(*) from " & nname & " where SNO = Label7.Value"
            Using JAT = New OleDbConnection(ABC)
                Using TOM = New OleDb.OleDbCommand(DEF, JAT)
                    JAT.Open()
                    TOM.Parameters.AddWithValue("@SNO", Label7.Text)
                    TOM.ExecuteNonQuery()
                    Dim count = Convert.ToInt32(TOM.ExecuteScalar())
                    If count > 0 Then
                        MsgBox("This Record Searil Number  already exists ")
                        Exit Sub
                    Else
                        GoTo label120
                    End If
                End Using
            End Using
        Catch ex As Exception
        End Try
Label120:
        If TextBox1.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox3.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox4.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox5.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox6.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox7.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox8.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox9.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox10.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox11.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox12.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox13.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox15.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        End If
        Try

            Dim str As String
            str = "insert into " & nname & " values("
            str += """" & Label7.Text.Trim() & """"
            str += ","
            str += """" & Label8.Text.Trim() & """"
            str += ","
            str += """" & Label9.Text.Trim() & """"
            str += ","
            str += """" & Label21.Text.Trim() & """"
            str += ","
            str += """" & TextBox1.Text.Trim() & """"
            str += ","
            str += """" & TextBox2.Text.Trim() & """"
            str += ","
            str += """" & TextBox3.Text.Trim() & """"
            str += ","
            str += """" & TextBox4.Text.Trim() & """"
            str += ","
            str += """" & TextBox5.Text.Trim() & """"
            str += ","
            str += """" & TextBox6.Text.Trim() & """"
            str += ","
            str += """" & TextBox7.Text.Trim() & """"
            str += ","
            str += """" & TextBox8.Text.Trim() & """"
            str += ","
            str += """" & TextBox9.Text.Trim() & """"
            str += ","
            str += """" & TextBox10.Text.Trim() & """"
            str += ","
            str += """" & TextBox11.Text.Trim() & """"
            str += ","
            str += """" & TextBox12.Text.Trim() & """"
            str += ","
            str += """" & TextBox13.Text.Trim() & """"
            str += ","
            str += """" & TextBox15.Text.Trim() & """"
            str += ")"
            Con.Open()
            Cmd = New OleDbCommand(str, Con)
            Cmd.ExecuteNonQuery()
            MsgBox("Record inserted successfully...")
            Try
                MyConn = New OleDbConnection
                MyConn.ConnectionString = connString
                ds = New DataSet
                tables = ds.Tables
                da2 = New OleDbDataAdapter("Select * from [" & nname & "]", MyConn)
                da2.Fill(ds, "" & nname & "")
                Dim view As New DataView(tables(0))
                source2.DataSource = view
                DataGridView1.DataSource = view
            Catch ex As Exception
            End Try

            clear()

        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Con.Close()

    End Sub
    Private Sub clea11r()
        TextBox21.Text = ""
        TextBox20.Text = ""
        TextBox19.Text = ""
        TextBox18.Text = ""
        TextBox17.Text = ""
        TextBox25.Text = ""
        TextBox24.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""
    End Sub
    Private Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox15.Text = ""
        TextBox21.Text = ""
        TextBox20.Text = ""
        TextBox19.Text = ""
        TextBox18.Text = ""
        TextBox17.Text = ""
        TextBox25.Text = ""
        TextBox24.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""
    End Sub
    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        clear()
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [" & nname & "]", MyConn)
            da.Fill(ds, "" & nname & "")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub

    Private Sub Search_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Search.Click

        Dim SearchId As Integer
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds1 = New DataSet
        tables = ds1.Tables
        da3 = New OleDbDataAdapter("Select * from [" & nname & "]", MyConn)
        da3.Fill(ds1, "" & nname & "")
        NON = Convert.ToString(cccourse & "-Assignment-Marks")
        Dim i, j As Integer
        If CheckId() = False Then
            MsgBox("Integer Value Required!!!")
            Exit Sub
        End If
        Try
            SearchId = TextBox16.Text
            j = ds1.Tables("" & NON & "").Rows.Count - 1
            i = 0
            While i <> j + 1
                If SearchId = ds1.Tables("" & NON & "").Rows(i).Item(1) Then
                    ShowDataMarks(i)
                    Exit While
                ElseIf i = j Then
                    clear()
                    MsgBox("Record Not Found!!!")
                    ShowDataMarks(CurrentRow)
                    Exit While
                End If
                i += 1
            End While
            CurrentRow = i
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da3 = New OleDbDataAdapter("SELECT *  FROM [" & NON & "] Where ENROLL = " + TextBox16.Text.Trim() + "", MyConn)
        da3.Fill(ds, "" & NON & "")
        Dim view As New DataView(tables(0))
        source3.DataSource = view
        ' view.RowFilter = "Id = " + TextBox1.Text + ";"
        For i = 0 To Me.DataGridView1.Columns.Count - 1
            Me.DataGridView1.Columns(i).Name = Me.DataGridView1.Columns(i).DataPropertyName
        Next
        DataGridView1.DataSource = view
        MyConn.Close()
    End Sub
    Private Function CheckId()
        Try
            If IsNumeric(TextBox16.Text) = False Then
                ShowData(CurrentRow)
                TextBox16.Focus()
                Return False
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        ' Dim reader As OleDbDataReader = cmd.ExecuteReader()
        da = New OleDbDataAdapter("SELECT * FROM [" & cccourse & "] ORDER BY SNO", MyConn)
        da.Fill(ds, "" & cccourse & "")
        ShowData(CurrentRow)
        If CurrentRow = ds.Tables("" & cccourse & "").Rows.Count - 1 Then
            MsgBox("Last Record is Reached!!!")
        Else
            CurrentRow += 1
            ShowData(CurrentRow)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If CurrentRow <> 0 Then
            CurrentRow -= 1
            ShowData(CurrentRow)
        Else
            MsgBox("First Record is Reached!!!")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CheckId() = False Then
            MsgBox("ENROLLMENT  : Integer Value Required !!!")
            Exit Sub
        End If
        UPDD()
        '  Try
        '' If TextBox21.Text <> "" And TextBox20.Text <> "" And TextBox19.Text <> "" And TextBox18.Text <> "" And TextBox17.Text <> "" And TextBox25.Text <> "" And TextBox24.Text <> "" And TextBox23.Text <> "" And TextBox22.Text <> "" And TextBox38.Text <> "" And TextBox39.Text <> "" And TextBox40.Text <> "" And TextBox41.Text <> "" And TextBox42.Text <> "" And TextBox43.Text <> "" And TextBox44.Text <> "" And TextBox45.Text <> "" And TextBox46.Text <> "" Then

        '        Dim cmdupdate = New OleDb.OleDbCommand("UPDATE " & nname & " SET [SNO] = '" & TextBox21.Text & "', [ENROLL] = '" & TextBox20.Text & "', [PROGRAM] = '" & TextBox19.Text & "', [STUDENT_NAME] = '" & TextBox18.Text & "', [CRS1] = '" & TextBox17.Text & "', [CRS2] = '" & TextBox25.Text & "', [CRS3] = '" & TextBox24.Text & "', [CRS4] = '" & TextBox23.Text & "' , [CRS5] = '" & TextBox22.Text & "', [CRS6] = '" & TextBox38.Text & "', [CRS7] = '" & TextBox39.Text & "', [CRS8] = '" & TextBox40.Text & "', [CRS9] = '" & TextBox41.Text & "', [CRS10] = '" & TextBox42.Text & "', [CRS11] = '" & TextBox43.Text & "', [CRS12] = '" & TextBox44.Text & "', [CRS13] = '" & TextBox45.Text & "', [MM] = '" & TextBox46.Text & "', WHERE SNO = '" & TextBox21.Text & "'")
        '       Con.Open()
        ' cmdupdate = New OleDbCommand(cmdupdate, con)
        '      cmdupdate.CommandType = CommandType.Text
        '    cmdupdate.Connection = Con
        '     cmdupdate.ExecuteNonQuery()
        '   MsgBox("Updated Successfully...")
        '   Else
        '  MsgBox("Enter the required values:" & vbNewLine & "1. name" & vbNewLine)

        '  End If
        '  Con.Close()
        ' Catch ex As Exception
        'MsgBox(ex.Message & " -  " & ex.Source)
        'End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds4 = New DataSet
            tables = ds4.Tables
            da4 = New OleDbDataAdapter("Select * from [" & nname & "]", MyConn)
            da4.Fill(ds4, "" & nname & "")
            Dim view4 As New DataView(tables(0))
            source4.DataSource = view4
            DataGridView1.DataSource = view4
            MyConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        clea11r()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        If TextBox14.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox26.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox27.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox28.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox29.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox30.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox31.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox32.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox33.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox34.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox35.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox36.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        ElseIf TextBox37.Text = "" Then
            MsgBox(" Field is empty ")
            Exit Sub
        End If
        Try

            Dim str As String
            str = "insert into AEvaluator values("
            str += """" & TextBox14.Text.Trim() & """"
            str += ","
            str += """" & TextBox26.Text.Trim() & """"
            str += ","
            str += """" & TextBox27.Text.Trim() & """"
            str += ","
            str += """" & TextBox28.Text.Trim() & """"
            str += ","
            str += """" & TextBox29.Text.Trim() & """"
            str += ","
            str += """" & TextBox30.Text.Trim() & """"
            str += ","
            str += """" & TextBox31.Text.Trim() & """"
            str += ","
            str += """" & TextBox32.Text.Trim() & """"
            str += ","
            str += """" & TextBox33.Text.Trim() & """"
            str += ","
            str += """" & TextBox34.Text.Trim() & """"
            str += ","
            str += """" & TextBox35.Text.Trim() & """"
            str += ","
            str += """" & TextBox36.Text.Trim() & """"
            str += ","
            str += """" & TextBox37.Text.Trim() & """"
            str += ")"
            Con.Open()
            Cmd = New OleDbCommand(str, Con)
            Cmd.ExecuteNonQuery()
            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM AEvaluator", Con)
            Dad.Fill(Dst, "AEvaluator")
            MsgBox("Record inserted successfully...")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox14.Text = ""
        TextBox26.Text = ""
        TextBox27.Text = ""
        TextBox28.Text = ""
        TextBox29.Text = ""
        TextBox30.Text = ""
        TextBox31.Text = ""
        TextBox32.Text = ""
        TextBox33.Text = ""
        TextBox34.Text = ""
        TextBox35.Text = ""
        TextBox36.Text = ""
        TextBox37.Text = ""
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub UPDD()
        Dim Str As String
        ' Try

        Str = "update [" & nname & "] set SNO="
        Str += TextBox21.Text.Trim()
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Con.Open()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set ENROLL="
        Str += """" & TextBox20.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set PROGRAM="
        Str += """" & TextBox19.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set STUDENT_NAME="
        Str += """" & TextBox18.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS1="
        Str += """" & TextBox17.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS2="
        Str += """" & TextBox25.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS3="
        Str += """" & TextBox24.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS4="
        Str += """" & TextBox23.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS5="
        Str += """" & TextBox22.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS6="
        Str += """" & TextBox38.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS7="
        Str += """" & TextBox39.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS8="
        Str += """" & TextBox40.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS9="
        Str += """" & TextBox41.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS10="
        Str += """" & TextBox42.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS11="
        Str += """" & TextBox43.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS12="
        Str += """" & TextBox44.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set CRS13="
        Str += """" & TextBox45.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        Con.Open()
        Str = "update [" & nname & "] set MM="
        Str += """" & TextBox46.Text & """"
        Str += " where SNO="
        Str += TextBox21.Text.Trim()
        Cmd = New OleDbCommand(Str, Con)
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("Updated Successfully...SEARCH AGAIN THIS ENROLL AND WATCH  THE UPDATE DETAIL")
        ' Catch ex As Exception
        'MsgBox(ex.Message & " -  " & ex.Source)
        ' End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class