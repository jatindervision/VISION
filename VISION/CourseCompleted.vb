Imports System.Data.OleDb
Imports System.String
Public Class CourseCompleted
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim dest As New BindingSource
    Private Sub CourseCompleted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForCCourseCompleted()
        Me.TopMost = True
        Me.CenterToScreen()
        Me.ToolTip1.SetToolTip(Me.Button3, "Please Backup of All Student Admission's Before Pack/Delete")
        Me.ToolTip1.SetToolTip(Me.Button1, "This Button will Backup All Admission Records ----- Thanking You")
        Try
            CurrentRow = 0
            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM StAdmission ORDER BY Id", Con)
            Dad.Fill(Dst, "Bissued")
            ShowData(CurrentRow)
            Con.Close()


            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [StAdmission]", MyConn)
            da.Fill(ds, "StAdmission")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            Id.Text = Dst.Tables("StAdmission").Rows(CurrentRow)("Id")
            StName.Text = Dst.Tables("StAdmission").Rows(CurrentRow)("StName")
         
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GoAdmissionBackup.Show()
    End Sub

    Private Sub ExitNow_Click(sender As Object, e As EventArgs) Handles ExitNow.Click
        Me.Close()
    End Sub
    Private Sub clear()
        Id.Text = ""
        StName.Text = ""
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [StAdmission]", MyConn)
            da.Fill(ds, "StAdmission")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
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
            j = Dst.Tables("StAdmission").Rows.Count - 1
            i = 0
            While i <> j + 1
                If SearchId = Dst.Tables("StAdmission").Rows(i)("Id") Then
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
        'Dim text As String = TextBox1.Text
        'Dim stringToInteger As Integer = Convert.ToInt32(text)
        da = New OleDbDataAdapter("SELECT *  FROM StAdmission Where Id=" + Id.Text + "", MyConn)
        da.Fill(ds, "StAdmission")
        Dim view As New DataView(tables(0))
        dest.DataSource = view
        ' view.RowFilter = "Id = " + TextBox1.Text + ";"
        For i = 0 To Me.DataGridView1.Columns.Count - 1
            Me.DataGridView1.Columns(i).Name = Me.DataGridView1.Columns(i).DataPropertyName
        Next
        DataGridView1.DataSource = view
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

    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim D As String

        D = MsgBox("Are you sure you want to DELETE ?", vbYesNo + vbQuestion, "Hello")

        If D = vbYes Then

        
        Dim Str As String
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required!!!")
            Exit Sub
        End If
        Try
            Str = "delete from StAdmission where id="
            Str += Id.Text.Trim
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.clear()
            Dad = New OleDbDataAdapter("SELECT * FROM StAdmission ORDER BY Id", Con)
            Dad.Fill(Dst, "StAdmission")
            MsgBox("Record deleted successfully...")
            If CurrentRow > 0 Then
                CurrentRow -= 1
                ShowData(CurrentRow)
            End If
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [StAdmission]", MyConn)
            da.Fill(ds, "StAdmission")
                Dim view As New DataView(tables(0))
                DataGridView1.Refresh()
            source1.DataSource = view
            DataGridView1.DataSource = view
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not delete Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
            Con.Close()
            End Try
        Else
            Exit Sub
        End If
    End Sub
End Class