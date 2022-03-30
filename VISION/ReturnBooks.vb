Imports System.Data.OleDb
Imports System.String
Public Class ReturnBooks
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim source2 As New BindingSource
    Private Sub ReturnBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForRBooksI()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Breturn]", MyConn)
            da.Fill(ds, "Breturn")
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
            da1 = New OleDbDataAdapter("Select * from [Bissued]", MyConn)
            da1.Fill(ds, "BIssued")
            Dim view As New DataView(tables(0))
            source2.DataSource = view
            DataGridView2.DataSource = view
        Catch ex As Exception
        End Try
    End Sub
   
    ' To exit from application
    Private Sub ExitNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitNow.Click
        Con.Close()
        Me.Close()
    End Sub
   
    'To select the data in Id field
    Private Sub Id_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Id.SelectAll()
    End Sub
    ' To clear all fields : Id, First Name, Last Name, Designation, Salary
    Private Sub Clear()
        Id.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
  

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
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DisplayReturnBooks.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Str As String
        Try
            Str = "insert into Breturn values("
            Str += Id.Text.Trim()
            Str += ","
            Str += """" & TextBox2.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox1.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox3.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox4.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox5.Text.Trim() & """"
            Str += ")"
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Breturn ORDER BY Id", Con)
            Dad.Fill(Dst, "Breturn")
            MsgBox("Record inserted successfully...")

            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Try
            Str = "delete from Bissued where Id="
            Str += Id.Text.Trim
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Bissued ORDER BY Id", Con)
            Dad.Fill(Dst, "Bissued")
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message & ",")
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Breturn]", MyConn)
            da.Fill(ds, "Breturn")
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
            da1 = New OleDbDataAdapter("Select * from [Bissued]", MyConn)
            da1.Fill(ds, "Bissued")
            Dim view As New DataView(tables(0))
            source2.DataSource = view
            DataGridView2.DataSource = view
        Catch ex As Exception
        End Try
        Clear()
    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Id.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        TextBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value
        TextBox3.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        TextBox4.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value

    End Sub
End Class