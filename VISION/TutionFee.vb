Imports System.Data.OleDb
Imports System.String
Public Class TutionFee
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source2 As New BindingSource
    Dim source3 As New BindingSource
    Private Sub TutionFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForTutionFee()
        Me.CenterToScreen()
        Me.TopMost = True
        CurrentRow = 0
        Try
            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM Tutionfee ORDER BY Id", Con)
            Dad.Fill(Dst, "Tutionfee")
            ShowData(CurrentRow)
            Con.Close()
        Catch ex As Exception
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("Select * from [Tutionfee]", MyConn)
            da1.Fill(ds, "Tutionfee")
            Dim view As New DataView(tables(0))
            source3.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try

    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            Id.Text = Dst.Tables("Tutionfee").Rows(CurrentRow)("Id")
            StudentName.Text = Dst.Tables("Tutionfee").Rows(CurrentRow)("StudentName")
            Amount.Text = Dst.Tables("Tutionfee").Rows(CurrentRow)("Amount")
            DateT.Text = Dst.Tables("Tutionfee").Rows(CurrentRow)("Date")
        Catch ex As Exception
        End Try
    End Sub
    ' To exit from application
    Private Sub ExitNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitNow.Click
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
        If CurrentRow = Dst.Tables("Tutionfee").Rows.Count - 1 Then
            MsgBox("Last Record is Reached!!!")
        Else
            CurrentRow += 1
            ShowData(CurrentRow)
        End If
    End Sub
    ' To Navigate to Last Record
    Private Sub Last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last.Click
        CurrentRow = Dst.Tables("Tutionfee").Rows.Count - 1
        ShowData(CurrentRow)
    End Sub
    'To select the data in Id field
    Private Sub Id_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Id.GotFocus
        Id.SelectAll()
    End Sub
    ' To clear all fields : Id, First Name, Last Name, Designation, Salary
    Private Sub Clear()
        Id.Text = ""
        StudentName.Text = ""
        Amount.Text = ""
        ' DateT.Text = ""

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
            j = Dst.Tables("Tutionfee").Rows.Count - 1
            i = 0
            While i <> j + 1
                If SearchId = Dst.Tables("Tutionfee").Rows(i)("Id") Then
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
    End Sub
    ' To insert the record in database
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Str As String
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required !!!")
            Exit Sub

        ElseIf CheckStudentName() = False Then
            MsgBox("StudentName : Only Characters Allowed!!!")
            Exit Sub
        ElseIf CheckAmount() = False Then
            MsgBox("Amount : Enter Amount in Integer !!!")

            Exit Sub

        End If

        Try
            Str = "insert into Tutionfee values("
            Str += Id.Text.Trim()
            Str += ","
            Str += """" & StudentName.Text.Trim() & """"
            Str += ","
            Str += """" & Amount.Text.Trim() & """"
            Str += ","
            Str += """" & DateT.Text.Trim() & """"
            Str += ")"
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Tutionfee ORDER BY Id", Con)
            Dad.Fill(Dst, "Tutionfee")
            MsgBox("Record inserted successfully...")
            Id.Text = ""
            StudentName.Text = ""
            Amount.Text = ""
            Con.Close()
        Catch ex As Exception
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Tutionfee]", MyConn)
            da.Fill(ds, "Tutionfee")
            Dim view As New DataView(tables(0))
            source2.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
        Id.Focus()
    End Sub
    ' To delete the record from database
   
    ' To select the data in First Name Field
    Private Sub BookName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles StudentName.GotFocus
        StudentName.SelectAll()
    End Sub
    ' To select the data in Last Name Field
    Private Sub Code_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Amount.GotFocus
        Amount.SelectAll()
    End Sub

    ' To update the records in database
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required !!!")
            Exit Sub

        ElseIf CheckStudentName() = False Then
            MsgBox("StudentName : Only Characters Allowed!!!")
            Exit Sub
        ElseIf CheckAmount() = False Then
            MsgBox("Amount : Enter Amount in Integer !!!")

            Exit Sub

        End If

        Try
            Dim Str As String
            Str = "update Tutionfee set Id="
            Str += """" & Me.Id.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update Tutionfee set StudentName="
            Str += """" & Me.StudentName.Text & """"
            Str += " where Id="
            Str += Me.Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update Tutionfee set Amount="
            Str += """" & Me.Amount.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update Tutionfee set DateT="
            Str += """" & Me.DateT.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()

            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Tutionfee ORDER BY Id", Con)
            Dad.Fill(Dst, "Tutionfee")
            MsgBox("Updated Successfully...")
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
    Private Function CheckAmount()
        Try
            If IsNumeric(Amount.Text) = False Then
                ShowData(CurrentRow)
                Amount.Focus()
                Return False
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    ' To check the data in Book Name Field : whether a string or not
    Private Function CheckStudentName()
        Try
            If StudentName.Text = "" Or ValidateString(StudentName.Text) = False Then
                ShowData(CurrentRow)
                StudentName.Focus()
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
 

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CalculateFee.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Clear()
    End Sub
End Class