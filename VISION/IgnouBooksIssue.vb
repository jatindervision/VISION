Imports ADOX
Imports System.Data.OleDb
Public Class IgnouBooksIssue
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
    Private Sub IgnouBooksIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForIgBooIsd()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
            CurrentRow = 0
            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM IBooksIss ORDER BY Enroll", Con)
            Dad.Fill(Dst, "IBooksIss")
            ShowData(CurrentRow)
            Con.Close()

            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da = New OleDbDataAdapter("Select * from [IBooksIss]", MyConn)
            da.Fill(ds, "IBooksIss")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            MyConn.Close()
        Catch ex As Exception
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da1 = New OleDbDataAdapter("Select * from [IBooksE]", MyConn)
            da1.Fill(ds, "IBooksE")
            Dim view As New DataView(tables(0))
            source2.DataSource = view
            DataGridView2.DataSource = view
            MyConn.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            TextBox1.Text = Dst.Tables("IBooksIss").Rows(CurrentRow)("Enroll")
            TextBox2.Text = Dst.Tables("IBooksIss").Rows(CurrentRow)("Student_Name")
            TextBox3.Text = Dst.Tables("IBooksIss").Rows(CurrentRow)("Book_Name")
            TextBox4.Text = Dst.Tables("IBooksIss").Rows(CurrentRow)("Course_Code")
            TextBox5.Text = Dst.Tables("IBooksIss").Rows(CurrentRow)("Issue_Date")

        Catch ex As Exception
        End Try
    End Sub
    Private Sub Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        DataGridView1.DataSource = Nothing

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = "" And TextBox4.Text = "" Then
            MsgBox("SELECT BOOK CODE FROM RIGHT PANE!!!!")
            Exit Sub
        End If
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox5.Text = "" Then
            MsgBox("ENTER ENROLLMENT , NAME , DATE!!!!!")
            Exit Sub
        End If
        If TextBox5.Text.Length < 10 Or TextBox5.Text.Length > 10 Then
            MsgBox("Date Format Wrong ")
            Exit Sub
        End If
        Try
            Dim Str As String
            Str = "insert into IBooksIss values("
            Str += TextBox1.Text.Trim()
            Str += ","
            Str += """" & TextBox2.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox3.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox4.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox5.Text.Trim() & """"
            Str += ")"
            Con.Open()
            Cmd1 = New OleDbCommand(Str, Con)
            Cmd1.ExecuteNonQuery()
            Con.Close()
            MsgBox("Record inserted successfully...")
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)

            Con.Close()
        End Try
        Try

            Dim Str As String
            Str = "update IBooksE set SNO="
            Str += Label14.Text.Trim()
            Str += " where SNO="
            Str += Label14.Text.Trim()
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IBooksE set Course_Code="
            Str += """" & TextBox4.Text & """"
            Str += " where SNO="
            Str += Label14.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IBooksE set Book_Name="
            Str += """" & TextBox3.Text & """"
            Str += " where SNO="
            Str += Label14.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IBooksE set Qty="
            Str += Label12.Text.Trim()
            Str += " where SNO="
            Str += Label14.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Updated Successfully...")

            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da3 = New OleDbDataAdapter("Select * from [IBooksE]", MyConn)
            da3.Fill(ds, "IBooksE")
            Dim view As New DataView(tables(0))
            source3.DataSource = view
            DataGridView2.DataSource = view
            MyConn.Close()
        Catch ex As Exception
            MyConn.Close()
            Con.Close()
        End Try

        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da = New OleDbDataAdapter("Select * from [IBooksIss]", MyConn)
            da.Fill(ds, "IBooksIss")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            MyConn.Close()
        Catch ex As Exception
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Label12.Text = ""
        Label14.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Con.Open()
        Dim SearchSNO As Integer
        Dim i, j As Integer
        If CheckSNO() = False Then
            MsgBox("Integer Value Required!!!")
            Exit Sub
        End If
        Try
            SearchSNO = TextBox1.Text
            j = Dst.Tables("IBooksIss").Rows.Count - 1
            i = 0
            While i <> j + 1
                If SearchSNO = Dst.Tables("IBooksIss").Rows(i)("Enroll") Then
                    ShowData(i)
                    Exit While
                ElseIf i = j Then
                    Clear()
                    MsgBox("Record Not Found!!!")
                    ShowData(CurrentRow)
                    Exit While
                End If
                i += 1
            End While
            CurrentRow = i
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        MyConn.Open()
        da = New OleDbDataAdapter("SELECT *  FROM IBooksIss Where Enroll=" + TextBox1.Text + "", MyConn)
        da.Fill(ds, "IBooksIss")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        ' view.RowFilter = "Id = " + TextBox1.Text + ";"
        For i = 0 To Me.DataGridView1.Columns.Count - 1
            Me.DataGridView1.Columns(i).Name = Me.DataGridView1.Columns(i).DataPropertyName
        Next
        DataGridView1.DataSource = view
        MyConn.Close()
    End Sub
    Private Function CheckSNO()
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da = New OleDbDataAdapter("Select * from [IBooksIss]", MyConn)
            da.Fill(ds, "IBooksIss")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            MyConn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Clear()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If CheckSNO() = False Then
            MsgBox("Enrollment  : Integer Value Required !!!")
            Exit Sub
        End If

        Try
            Dim Str As String
            Str = "update IBooksIss set Enroll="
            Str += """" & TextBox1.Text & """"
            Str += " where Enroll="
            Str += TextBox1.Text.Trim()
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IBooksIss set Student_Name="
            Str += """" & TextBox2.Text & """"
            Str += " where Enroll="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IBooksIss set Book_Name="
            Str += """" & TextBox3.Text & """"
            Str += " where Enroll="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IBooksIss set Course_Code="
            Str += """" & TextBox4.Text & """"
            Str += " where Enroll="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IBooksIss set Issue_Date="
            Str += """" & TextBox5.Text & """"
            Str += " where Enroll="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Updated Successfully...")

            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da = New OleDbDataAdapter("Select * from [IBooksIss]", MyConn)
            da.Fill(ds, "IBooksIss")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            MyConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "," & ex.Source)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Str As String
        If CheckSNO() = False Then
            MsgBox("Id : Integer Value Required!!!")
            Exit Sub
        End If
        Try
            Str = "delete from IBooksIss where Enroll="
            Str += TextBox1.Text.Trim
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.clear()
            Dad = New OleDbDataAdapter("SELECT * FROM IBooksIss ORDER BY Enroll", Con)
            Dad.Fill(Dst, "IBooksIss")
            MsgBox("Record deleted successfully...")
            If CurrentRow > 0 Then
                CurrentRow -= 1
                ShowData(CurrentRow)
            End If
            Con.Close()
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da = New OleDbDataAdapter("Select * from [IBooksIss]", MyConn)
            da.Fill(ds, "IBooksIss")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            MyConn.Close()

        Catch ex As Exception
            MessageBox.Show("Could Not delete Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
            Con.Close()
        End Try

    End Sub
    Private Sub First_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First.Click
        CurrentRow = 0
        ShowData(CurrentRow)
    End Sub
    ' To Navigate to Last Record
    Private Sub Previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Previous.Click
        If CurrentRow <> 0 Then
            CurrentRow -= 1
            ShowData(CurrentRow)
        Else
            MsgBox("First Record is Reached!!!")
        End If
    End Sub
    ' To Navigate to Next Record
    Private Sub Forward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Forward.Click
        If CurrentRow = Dst.Tables("IBooksIss").Rows.Count - 1 Then
            MsgBox("Last Record is Reached!!!")
        Else
            CurrentRow += 1
            ShowData(CurrentRow)
        End If
    End Sub
    ' To Navigate to Last Record
    Private Sub Last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last.Click
        CurrentRow = Dst.Tables("IBooksIss").Rows.Count - 1
        ShowData(CurrentRow)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Label14.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        TextBox3.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        TextBox4.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        Label12.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value - 1
    End Sub
End Class