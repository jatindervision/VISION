
Imports System.Data.OleDb
Imports System.String
Public Class BooksIssued
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim source2 As New BindingSource
    Private Sub BooksIssued_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ForBooksIssued()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
            CurrentRow = 0
            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM Bissued ORDER BY Id", Con)
            Dad.Fill(Dst, "Bissued")
            ShowData(CurrentRow)
            Con.Close()

            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Bissued]", MyConn)
            da.Fill(ds, "Bissued")
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
            da1 = New OleDbDataAdapter("Select * from [Library]", MyConn)
            da1.Fill(ds, "Library")
            Dim view As New DataView(tables(0))
            source2.DataSource = view
            DataGridView2.DataSource = view
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            Id.Text = Dst.Tables("Bissued").Rows(CurrentRow)("Id")
            TextBox2.Text = Dst.Tables("Bissued").Rows(CurrentRow)("Student_Name")
            TextBox3.Text = Dst.Tables("Bissued").Rows(CurrentRow)("Book_Name")
            TextBox1.Text = Dst.Tables("Bissued").Rows(CurrentRow)("Book_Code")
            TextBox4.Text = Dst.Tables("Bissued").Rows(CurrentRow)("Issue_Date")

        Catch ex As Exception
        End Try
    End Sub
    ' To clear all fields : 
    Private Sub Clear()
        Id.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        DataGridView1.DataSource = Nothing
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox4.Text.Length < 10 Or TextBox4.Text.Length > 10 Then
            MsgBox("Date Format Wrong ")
            Exit Sub
        End If
        Dim Str As String
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required !!!")
            Exit Sub


        End If

        Try
            Str = "insert into Bissued values("
            Str += Id.Text.Trim()
            Str += ","
            Str += """" & TextBox2.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox3.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox1.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox4.Text.Trim() & """"
            Str += ")"
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Bissued ORDER BY Id", Con)
            Dad.Fill(Dst, "Bissued")
            MsgBox("Record inserted successfully...")
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Bissued]", MyConn)
            da.Fill(ds, "Bissued")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            Clear()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
            Con.Close()
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Bissued]", MyConn)
            da.Fill(ds, "Bissued")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
        Id.Focus()
    End Sub
    Private Function CheckId()
        Try
            If IsNumeric(Id.Text) = False Then
                ShowData(CurrentRow)
                Id.Focus()
                Return False
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function
    Private Sub Id_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Id.GotFocus
        Id.SelectAll()
    End Sub

    ' To check the data in Book Name Field : whether a string or not



    ' To check the string for numeric values
    Private Function ValidateString(ByVal Str)
        Dim i As Integer
        Dim ch As Char
        i = 0
        While i < Str.Length()
            ch = Str.Chars(i)
            If IsNumeric(ch) = True Then
                Return False
            End If
            i += 1
        End While
        Return True
    End Function
    ' To show the data in the datagridview

    ' To check whether Id exist in database
    Private Function IsIdExist()
        Dim Str, Str1 As String
        Dim i As Integer
        Str = Id.Text
        i = 0
        While i <> Dst.Tables("Bissued").rows.count
            Str1 = Dst.Tables("Bissued").Rows(i)("Id")
            If Str = Str1 Then
                Return True
            End If
            i += 1
        End While
        Return False
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub ExitNow_Click(sender As Object, e As EventArgs) Handles ExitNow.Click
        Con.Close()
        Me.Close()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim SearchId As Integer
        Dim i, j As Integer
        If CheckId() = False Then
            MsgBox("Integer Value Required!!!")
            Exit Sub
        End If
        Try
            SearchId = Id.Text
            j = Dst.Tables("Bissued").Rows.Count - 1
            i = 0
            While i <> j + 1
                If SearchId = Dst.Tables("Bissued").Rows(i)("Id") Then
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT *  FROM Bissued Where Id=" + Id.Text + "", MyConn)
        da.Fill(ds, "Bissued")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        ' view.RowFilter = "Id = " + TextBox1.Text + ";"
        For i = 0 To Me.DataGridView1.Columns.Count - 1
            Me.DataGridView1.Columns(i).Name = Me.DataGridView1.Columns(i).DataPropertyName
        Next
        DataGridView1.DataSource = view

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required !!!")
            Exit Sub

        End If

        Try
            Dim Str As String
            Str = "update Bissued set Id="
            Str += """" & Id.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update Bissued set Student_Name="
            Str += """" & TextBox2.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update Bissued set Book_Name="
            Str += """" & TextBox3.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update Bissued set Issue_Date="
            Str += """" & TextBox4.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Bissued ORDER BY Id", Con)
            Dad.Fill(Dst, "Bissued")
            MsgBox("Updated Successfully...")
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Bissued]", MyConn)
            da.Fill(ds, "Bissued")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view

        Catch ex As Exception
            MsgBox(ex.Message & ",")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Bissued]", MyConn)
            da.Fill(ds, "Bissued")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
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
        If CurrentRow = Dst.Tables("Bissued").Rows.Count - 1 Then
            MsgBox("Last Record is Reached!!!")
        Else
            CurrentRow += 1
            ShowData(CurrentRow)
        End If
    End Sub
    ' To Navigate to Last Record
    Private Sub Last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last.Click
        CurrentRow = Dst.Tables("Bissued").Rows.Count - 1
        ShowData(CurrentRow)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Str As String
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required!!!")
            Exit Sub
        End If
        Try
            Str = "delete from Bissued where Id="
            Str += Id.Text.Trim
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Bissued ORDER BY Id", Con)
            Dad.Fill(Dst, "Bissued")
            MsgBox("Record deleted successfully...")
            If CurrentRow > 0 Then
                CurrentRow -= 1
                ShowData(CurrentRow)
            End If
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Bissued]", MyConn)
            da.Fill(ds, "Bissued")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not delete Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
            Con.Close()
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        TextBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        TextBox3.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
    End Sub
End Class