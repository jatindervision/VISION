Imports ADOX
Imports System.Data.OleDb
Public Class IgnouBooksEntry
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim da3 As OleDbDataAdapter
    Dim da4 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim source2 As New BindingSource
    Dim source3 As New BindingSource
    Dim source4 As New BindingSource
    Private Sub IgnouBooksEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForIgBEn()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
            CurrentRow = 0
            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM IBooksE ORDER BY SNO", Con)
            Dad.Fill(Dst, "IBooksE")
            ShowData(CurrentRow)
            Con.Close()
       
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da = New OleDbDataAdapter("Select * from [IBooksE]", MyConn)
            da.Fill(ds, "IBooksE")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            MyConn.Close()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            TextBox1.Text = Dst.Tables("IBooksE").Rows(0).item(0)
            TextBox3.Text = Dst.Tables("IBooksE").Rows(0).item(1)
            TextBox2.Text = Dst.Tables("IBooksE").Rows(0).item(2)
            TextBox4.Text = Dst.Tables("IBooksE").Rows(0).item(3)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub Clea1r()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Str As String
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required !!!")
            Exit Sub
        ElseIf IsIdExist() = True Then
            MsgBox("Id : Id is already exist. Please choose another one..... For help please consider the data by clicking on ""Show Data"" Button")
            Exit Sub
        ElseIf CheckTextbox2() = False Then
            MsgBox("Textbox2 : Only Characters Allowed!!!")
            Exit Sub


        End If

        Try
            Str = "insert into IbooksE values("
            Str += TextBox1.Text.Trim()
            Str += ","
            Str += """" & TextBox3.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox2.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox4.Text.Trim() & """"
            Str += ")"
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM IBooksE  ORDER BY SNO", Con)
            Dad.Fill(Dst, "IBooksE")
            MsgBox("Record inserted successfully...")
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [IBooksE]", MyConn)
            da.Fill(ds, "IBooksE")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
           
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
            Con.Close()
        End Try
        Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Clea1r()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SearchSNO As Integer
        Dim i, j As Integer
        If CheckSNO() = False Then
            MsgBox("Integer Value Required!!!")
            Exit Sub
        End If
        Try
            SearchSNO = TextBox1.Text
            j = Dst.Tables("IBooksE").Rows.Count - 1
            i = 0
            While i <> j + 1
                If SearchSNO = Dst.Tables("IBooksE").Rows(i)("SNO") Then
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
        da = New OleDbDataAdapter("SELECT *  FROM IBooksE Where SNO=" + Me.TextBox1.Text.Trim() + "", MyConn)
        da.Fill(ds, "IBooksE")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        ' view.RowFilter = "Id = " + TextBox1.Text + ";"
        For i = 0 To Me.DataGridView1.Columns.Count - 1
            Me.DataGridView1.Columns(i).Name = Me.DataGridView1.Columns(i).DataPropertyName
        Next
        DataGridView1.DataSource = view
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CheckSNO() = False Then
            MsgBox("Id : Integer Value Required !!!")
            Exit Sub
        End If

        Try
            Dim Str As String
            Str = "update IBooksE set SNO="
            Str += """" & TextBox1.Text & """"
            Str += " where SNO="
            Str += TextBox1.Text.Trim()
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IBooksE set Course_Code="
            Str += """" & TextBox3.Text & """"
            Str += " where SNO="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update"
            Str = "update IBooksE set Book_Name="
            Str += """" & TextBox2.Text & """"
            Str += " where SNO="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IBooksE set Qty="
            Str += TextBox4.Text.Trim()
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
            da3 = New OleDbDataAdapter("Select * from [IBooksE]", MyConn)
            da3.Fill(ds, "IBooksE")
            Dim view As New DataView(tables(0))
            source3.DataSource = view
            DataGridView1.DataSource = view

        Catch ex As Exception
            MsgBox(ex.Message & "," & ex.Source)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Str As String
        If CheckSNO() = False Then
            MsgBox("Id : Integer Value Required!!!")
            Exit Sub
        End If
        Try
            Str = "delete from IBooksE where SNO="
            Str += TextBox1.Text.Trim
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("Record deleted successfully...")
            If CurrentRow > 0 Then
                CurrentRow -= 1
                ShowData(CurrentRow)
            End If
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da4 = New OleDbDataAdapter("Select * from [IBooksE]", MyConn)
            da4.Fill(ds, "IBooksE")
            Dim view As New DataView(tables(0))
            source4.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
            MessageBox.Show("Could Not delete Record!!!")
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

    ' To check the data in Book Name Field : whether a string or not
    Private Function CheckTextbox2()
        Try
            If Textbox2.Text = "" Or ValidateString(Textbox2.Text) = False Then
                ShowData(CurrentRow)
                Textbox2.Focus()
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
        Str = TextBox1.Text
        i = 0
        While i <> Dst.Tables("IBooksE").rows.count
            Str1 = Dst.Tables("IBooksE").Rows(i)("SNO")
            If Str = Str1 Then
                Return True
            End If
            i += 1
        End While
        Return False
    End Function

End Class