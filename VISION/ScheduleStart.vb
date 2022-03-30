Imports System
Imports System.Data.OleDb
Public Class ScheduleStart
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim da1 As OleDbDataAdapter
    Dim tables As DataTableCollection
    Dim source2 As New BindingSource
    Dim id As Integer

    Private Sub ScheduleStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CollegeDataSet4.Holidays' table. You can move, or remove it, as needed.

        forschhol()
        ' Me.TopMost = True
        Me.CenterToParent()
        CurrentRow = 0
        Try
            CurrentRow = 0
            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM Holidays  ORDER BY SNO", Con)
            Dad.Fill(Dst, "Holidays")
            ShowData(CurrentRow)
            Con.Close()
           
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("Select * from [Holidays]", MyConn)
            da1.Fill(ds, "Holidays")
            'Dim view11 As New DataView(tables(0))
            ' source2.DataSource = view11
            DataGridView2.DataSource = ds.Tables("Holidays")
            id = Dst.TABLES("Holidays").ROWS.COUNT - 1
            TextBox1.Text = id + 1
            TextBox2.Text = ""
        Catch ex As Exception
        End Try

    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            TextBox1.Text = Dst.Tables("Holidays").Rows(CurrentRow)("SNO")
            TextBox2.Text = Dst.Tables("Holidays").Rows(CurrentRow)("Holidays")

        Catch ex As Exception
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _14forinputbox.Show()
    End Sub

    Private Sub ExitNow_Click(sender As Object, e As EventArgs) Handles ExitNow.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
      
        Try

            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)
            Dim createTable As New OleDb.OleDbCommand

            createTable.Connection = Conn
            createTable.CommandType = CommandType.Text

            Dim cmd As New OleDb.OleDbCommand("INSERT INTO Holidays (SNO,Holidays) values ('" & TextBox1.Text & "','" & TextBox2.Text & "')", Conn)
            Conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox(" Holidate Date Successfully Saved ")
            TextBox1.Text = ""
            TextBox2.Text = ""
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("Select * from [Holidays]", MyConn)
            da1.Fill(ds, "Holidays")
            Dim view11 As New DataView(tables(0))
            source2.DataSource = view11
            DataGridView2.DataSource = view11
        Catch ex As Exception
        End Try
        MyConn.Close()
        TextBox1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("Select * from [Holidays]", MyConn)
            da1.Fill(ds, "Holidays")
            Dim view11 As New DataView(tables(0))
            source2.DataSource = view11
            DataGridView2.DataSource = view11
        Catch ex As Exception
        End Try
        MyConn.Close()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim SearchId As Integer
        Dim i, j As Integer
        If CheckId() = False Then
            MsgBox("Integer Value Required!!!")
            Exit Sub
        End If
        Try
            SearchId = TextBox1.Text
            j = Dst.Tables("Holidays").Rows.Count - 1
            i = 0
            While i <> j + 1
                If SearchId = Dst.Tables("Holidays").Rows(i)("SNO") Then
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
            MsgBox(ex.Message)
        End Try
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT *  FROM Holidays Where SNO=" + TextBox1.Text + "", MyConn)
        da.Fill(ds, "Holidays")
        Dim view As New DataView(tables(0))
        source2.DataSource = view
        For i = 0 To Me.DataGridView2.Columns.Count - 1
            Me.DataGridView2.Columns(i).Name = Me.DataGridView2.Columns(i).DataPropertyName
        Next
        DataGridView2.DataSource = view
    End Sub
    Private Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If CheckId() = False Then
            MsgBox("SNO : Integer Value Required !!!")
            Exit Sub
        End If
      

        Try
            Dim Str As String
            Str = "update Holidays set SNO="
            Str += """" & TextBox1.Text & """"
            Str += " where SNO="
            Str += TextBox1.Text.Trim()
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update Holidays set Holidays="
            Str += """" & TextBox2.Text & """"
            Str += " where SNO="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()

            Con.Open()
            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Holidays ORDER BY SNO", Con)
            Dad.Fill(Dst, "Holidays")
            MsgBox("Updated Successfully...")
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Holidays]", MyConn)
            da.Fill(ds, "Holidays")
            Dim view As New DataView(tables(0))
            source2.DataSource = view
            DataGridView2.DataSource = view
        Catch ex As Exception
            MsgBox(ex.Message & ",")
        End Try
        Con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Str As String
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required!!!")
            Exit Sub
        End If
        Try
            Str = "delete from Holidays where SNO="
            Str += TextBox1.Text.Trim
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.clear()
            Dad = New OleDbDataAdapter("SELECT * FROM Holidays ORDER BY SNO", Con)
            Dad.Fill(Dst, "Holidays")
            MsgBox("Record deleted successfully...")
            If CurrentRow > 0 Then
                CurrentRow -= 1
                ShowData(CurrentRow)
            End If
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Holidays]", MyConn)
            da.Fill(ds, "Holidays")
            Dim view As New DataView(tables(0))
            source2.DataSource = view
            DataGridView2.DataSource = view
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not delete Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
            Con.Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
       
    End Sub
End Class