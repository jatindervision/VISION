
Imports System.Data.OleDb
Imports System.String
' Form Load
Public Class Enterbooks
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim dest As New BindingSource



    Private Sub Enterbooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ForEnBooksI()
        Me.CenterToScreen()
        Me.TopMost = True
      


        Try

            CurrentRow = 0
            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM Library ORDER BY Id", Con)
            Dad.Fill(Dst, "Library")
            ShowData(CurrentRow)
            Con.Close()


            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Library]", MyConn)
            da.Fill(ds, "Library")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub
    'code
   
    'code ends progress bar
    ' To display data on form
    Private Sub ShowData(ByVal CurrentRow)
        Try
            Id.Text = Dst.Tables("Library").Rows(CurrentRow)("Id")
            BookName.Text = Dst.Tables("Library").Rows(CurrentRow)("BookName")
            Code.Text = Dst.Tables("Library").Rows(CurrentRow)("Code")

        Catch ex As Exception
        End Try
    End Sub
    ' To exit from application
    Private Sub ExitNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitNow.Click
        Con.Close()
        Me.Close()
    End Sub
    ' To Navigate to First Record
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
        If CurrentRow = Dst.Tables("Library").Rows.Count - 1 Then
            MsgBox("Last Record is Reached!!!")
        Else
            CurrentRow += 1
            ShowData(CurrentRow)
        End If
    End Sub
    ' To Navigate to Last Record
    Private Sub Last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last.Click
        CurrentRow = Dst.Tables("Library").Rows.Count - 1
        ShowData(CurrentRow)
    End Sub
    'To select the data in Id field
    Private Sub Id_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Id.GotFocus
        Id.SelectAll()
    End Sub
    ' To clear all fields : Id, First Name, Last Name, Designation, Salary
    Private Sub Clear()
        Id.Text = ""
        BookName.Text = ""
        Code.Text = ""

    End Sub
    ' To search a record in database
    Private Sub Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search.Click
        Dim SearchId As Integer
        Dim i, j As Integer
        If CheckId() = False Then
            MsgBox("Integer Value Required!!!")
            Exit Sub
        End If
        Try
            SearchId = Id.Text
            j = Dst.Tables("Library").Rows.Count - 1
            i = 0
            While i <> j + 1
                If SearchId = Dst.Tables("Library").Rows(i)("Id") Then
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
        'Dim text As String = TextBox1.Text
        'Dim stringToInteger As Integer = Convert.ToInt32(text)
        da = New OleDbDataAdapter("SELECT *  FROM Library Where Id=" + Id.Text + "", MyConn)
        da.Fill(ds, "Library")
        Dim view As New DataView(tables(0))
        dest.DataSource = view
        ' view.RowFilter = "Id = " + TextBox1.Text + ";"
        For i = 0 To Me.DataGridView1.Columns.Count - 1
            Me.DataGridView1.Columns(i).Name = Me.DataGridView1.Columns(i).DataPropertyName
        Next
        DataGridView1.DataSource = view
    End Sub
    ' To insert the record in database
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Str As String
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required !!!")
            Exit Sub
        ElseIf IsIdExist() = True Then
            MsgBox("Id : Id is already exist. Please choose another one..... For help please consider the data by clicking on ""Show Data"" Button")
            Exit Sub
        ElseIf CheckBookName() = False Then
            MsgBox("BookName : Only Characters Allowed!!!")
            Exit Sub
       

        End If

        Try
            Str = "insert into Library values("
            Str += Id.Text.Trim()
            Str += ","
            Str += """" & BookName.Text.Trim() & """"
            Str += ","
            Str += """" & Code.Text.Trim() & """"
            Str += ")"
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Library ORDER BY Id", Con)
            Dad.Fill(Dst, "Library")
            MsgBox("Record inserted successfully...")
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Library]", MyConn)
            da.Fill(ds, "Library")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            Id.Text = ""
            BookName.Text = ""
            Code.Text = ""
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
            Con.Close()
        End Try
        Id.Focus()
    End Sub
    ' To delete the record from database
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Str As String
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required!!!")
            Exit Sub
        End If
        Try
            Str = "delete from Library where id="
            Str += Id.Text.Trim
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Library ORDER BY Id", Con)
            Dad.Fill(Dst, "Library")
            MsgBox("Record deleted successfully...")
            If CurrentRow > 0 Then
                CurrentRow -= 1
                ShowData(CurrentRow)
            End If
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Library]", MyConn)
            da.Fill(ds, "Library")
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
    ' To select the data in First Name Field
    Private Sub BookName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BookName.GotFocus
        BookName.SelectAll()
    End Sub
    ' To select the data in Last Name Field
    Private Sub Code_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Code.GotFocus
        Code.SelectAll()
    End Sub

    ' To update the records in database
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required !!!")
            Exit Sub
        ElseIf CheckBookName() = False Then
            MsgBox("Book Name : Only Characters Allowed!!!")
            Exit Sub

        End If

        Try
            Dim Str As String
            Str = "update Library set Id="
            Str += """" & Id.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update Library set BookName="
            Str += """" & BookName.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update Library set Code="
            Str += """" & Code.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
          
            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Library ORDER BY Id", Con)
            Dad.Fill(Dst, "Library")
            MsgBox("Updated Successfully...")
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Library]", MyConn)
            da.Fill(ds, "Library")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
            MsgBox(ex.Message & "," & ex.Source)
        End Try
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

    ' To check the data in Book Name Field : whether a string or not
    Private Function CheckBookName()
        Try
            If BookName.Text = "" Or ValidateString(BookName.Text) = False Then
                ShowData(CurrentRow)
                BookName.Focus()
                Return False
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function
    

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
        While i <> Dst.Tables("Library").rows.count
            Str1 = Dst.Tables("Library").Rows(i)("Id")
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Clear()
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Library]", MyConn)
            da.Fill(ds, "Library")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub
End Class