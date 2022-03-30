Imports System
Imports System.Data.OleDb
Public Class StockRegistor
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim da1 As OleDbDataAdapter
    Dim ds1 As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim tables1 As DataTableCollection
    Dim source2 As New BindingSource
    Dim currentrow1 As Integer = 0
    Dim number1 As Integer

    Private Sub StockRegistor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Forstockregistor()
        Me.CenterToScreen()
        Me.TopMost = True

        TextBox1.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox7.Text = DateTimePicker1.Value.ToShortDateString

        Con.Open()
        Dad = New OleDbDataAdapter("SELECT * FROM StockR ORDER BY SNo", Con)
        Dad.Fill(Dst, "StockR")
        ShowData(CurrentRow)
        Con.Close()
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select SNo,Item_Name,Qty,Issue_Name,Issue_Item,Issue_Qty,Stock_Date from [StockR]", MyConn)
            da.Fill(ds, "StockR")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
        num2()
    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            Label8.Text = Dst.Tables("StockR").Rows(CurrentRow)("SNo")
            TextBox2.Text = Dst.Tables("StockR").Rows(CurrentRow)("Item_Name")
            TextBox3.Text = Dst.Tables("StockR").Rows(CurrentRow)("Qty")
            TextBox4.Text = Dst.Tables("StockR").Rows(CurrentRow)("Issue_Name")
            TextBox5.Text = Dst.Tables("StockR").Rows(CurrentRow)("Issue_Item")
            TextBox6.Text = Dst.Tables("StockR").Rows(CurrentRow)("Issue_Qty")
            TextBox7.Text = Dst.Tables("StockR").Rows(CurrentRow)("Stock_date")
            
        Catch ex As Exception
        End Try
    End Sub
    Public Sub clear()
      TextBox2.Text = "" & 0 & ""
        TextBox3.Text = "" & 0 & ""
        TextBox4.Text = "" & 0 & ""
        TextBox5.Text = "" & 0 & ""
        TextBox6.Text = "" & 0 & ""
        DataGridView1.DataSource = Nothing
    End Sub
    Private Sub num2()
        Try
            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)
            Dim cmd As New OleDb.OleDbCommand("Select count(SNo) from StockR", Conn)
            Dim number As Integer = 1
            Conn.Open()
            If IsDBNull(cmd.ExecuteScalar) Then
                Label5.Text = number

            Else
                number = cmd.ExecuteScalar
                Label5.Text = number
                Label8.Text = number + 1
            End If
            Conn.Close()
        Catch ex As Exception
        End Try
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
            j = Dst.Tables("StockR").Rows.Count - 1
            i = 0
            While i <> j + 1
                If SearchId = Dst.Tables("StockR").Rows(i)("SNo") Then
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
          
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT *  FROM StockR Where SNo=" + Id.Text + "", MyConn)
        da.Fill(ds, "StockR")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        For i = 0 To Me.DataGridView1.Columns.Count - 1
            Me.DataGridView1.Columns(i).Name = Me.DataGridView1.Columns(i).DataPropertyName
        Next
        DataGridView1.DataSource = view
        CurrentRow = i
       
    End Sub

    Private Sub ExitNow_Click(sender As Object, e As EventArgs) Handles ExitNow.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Str As String
        '  If TextBox2.Text Then
        If TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" & 0 & "" And TextBox5.Text = "" And TextBox6.Text = "" Then
            MsgBox("FILL AL FIELDS PUT 0 WHICH IS NOT REQUIRED")
            Exit Sub
        End If
        If TextBox7.Text.Length < 10 Or TextBox7.Text.Length > 10 Then
            MsgBox("Date Format Wrong ")
            Exit Sub
        End If
        TextBox1.Text = "" & 0 & ""
        TextBox8.Text = "" & 0 & ""
        TextBox9.Text = "" & 0 & ""
        TextBox10.Text = "" & 0 & ""
        TextBox11.Text = "" & 0 & ""
        Try
            Str = "insert into StockR values("
            Str += Label8.Text.Trim()
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
            Str += ","
            Str += """" & TextBox1.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox8.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox9.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox10.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox11.Text.Trim() & """"
            Str += ")"
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()

            Str = "insert into BFILLSTOCK values("
            Str += """" & TextBox2.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox3.Text.Trim() & """"
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
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select SNo,Item_Name,Qty,Issue_Name,Issue_Item,Issue_Qty,Stock_Date from [StockR]", MyConn)
            da.Fill(ds, "StockR")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
        num2()
        TextBox2.Focus()
        TextBox2.Text = "" & 0 & ""
        TextBox3.Text = "" & 0 & ""
        TextBox4.Text = "" & 0 & ""
        TextBox5.Text = "" & 0 & ""
        TextBox6.Text = "" & 0 & ""
        TextBox7.Text = DateTimePicker1.Value.ToShortDateString
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [StockR]", MyConn)
            da.Fill(ds, "StockR")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
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
  
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView1.DataSource = Nothing
        Try
            Dim Str As String
            Con.Open()
            Str = "update StockR set Item_Name="
            Str += """" & TextBox2.Text & """"
            Str += " where SNo="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update StockR set Qty="
            Str += """" & TextBox3.Text & """"
            Str += " where SNo="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update StockR set Issue_Name="
            Str += """" & TextBox4.Text & """"
            Str += " where SNo="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update StockR set Issue_Item="
            Str += """" & TextBox4.Text & """"
            Str += " where SNo="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update StockR set Issue_Qty="
            Str += """" & TextBox4.Text & """"
            Str += " where SNo="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update StockR set Stock_Date="
            Str += """" & TextBox4.Text & """"
            Str += " where SNo="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()

            MsgBox("Updated Successfully...You can Check By Search this Record for Updation Success")

        Catch ex As Exception
            MsgBox(ex.Message & ",")
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [StockR]", MyConn)
            da.Fill(ds, "StockR")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
    End Sub

End Class