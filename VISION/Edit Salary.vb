
Imports System.Data.OleDb
Imports System.String
Public Class Edit_Salary
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MonthNo.Text = "" And EmpId.Text = "" Then
            Exit Sub
        End If

        Dim SalMonth As Integer
        SalMonth = Convert.ToInt32(MonthNo.Text)

        Select Case SalMonth
            Case 1

                Try

                    MyConn = New OleDbConnection
                    MyConn.ConnectionString = connString
                    ds = New DataSet
                    tables = ds.Tables
                    da = New OleDbDataAdapter("Select * from [JanSalary] Where EmpNO=" + EmpId.Text + "", MyConn)
                    da.Fill(ds, "JanSalary")

                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView1.DataSource = view
                Catch ex As Exception
                End Try

            Case 2

                Try
                    MyConn = New OleDbConnection
                    MyConn.ConnectionString = connString
                    ds = New DataSet
                    tables = ds.Tables
                    da = New OleDbDataAdapter("Select * from [FebSalary] Where EmpNO=" + EmpId.Text + "", MyConn)
                    da.Fill(ds, "FebSalary")
                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView1.DataSource = view
                Catch ex As Exception
                End Try

            Case 3

                Try
                    MyConn = New OleDbConnection
                    MyConn.ConnectionString = connString
                    ds = New DataSet
                    tables = ds.Tables
                    da = New OleDbDataAdapter("Select * from [MarchSalary] Where EmpNO=" + EmpId.Text + "", MyConn)
                    da.Fill(ds, "MarchSalary")
                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView1.DataSource = view
                Catch ex As Exception
                End Try

            Case 4

                Try
                    MyConn = New OleDbConnection
                    MyConn.ConnectionString = connString
                    ds = New DataSet
                    tables = ds.Tables
                    da = New OleDbDataAdapter("Select * from [AprilSalary] Where EmpNO=" + EmpId.Text + "", MyConn)
                    da.Fill(ds, "AprilSalary")
                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView1.DataSource = view
                Catch ex As Exception
                End Try
            Case 5

                Try
                    MyConn = New OleDbConnection
                    MyConn.ConnectionString = connString
                    ds = New DataSet
                    tables = ds.Tables
                    da = New OleDbDataAdapter("Select * from [MaySalary] Where EmpNO=" + EmpId.Text + "", MyConn)
                    da.Fill(ds, "MaySalary")
                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView1.DataSource = view
                Catch ex As Exception
                End Try

            Case 6

                Try
                    MyConn = New OleDbConnection
                    MyConn.ConnectionString = connString
                    ds = New DataSet
                    tables = ds.Tables
                    da = New OleDbDataAdapter("Select * from [JuneSalary] Where EmpNO=" + EmpId.Text + "", MyConn)
                    da.Fill(ds, "JuneSalary")
                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView1.DataSource = view
                Catch ex As Exception
                End Try

            Case 7

                Try
                    MyConn = New OleDbConnection
                    MyConn.ConnectionString = connString
                    ds = New DataSet
                    tables = ds.Tables
                    da = New OleDbDataAdapter("Select * from [JulySalary] Where EmpNO=" + EmpId.Text + "", MyConn)
                    da.Fill(ds, "JulySalary")
                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView1.DataSource = view
                Catch ex As Exception
                End Try

            Case 8

                Try
                    MyConn = New OleDbConnection
                    MyConn.ConnectionString = connString
                    ds = New DataSet
                    tables = ds.Tables
                    da = New OleDbDataAdapter("Select * from [AugSalary] Where EmpNO=" + EmpId.Text + "", MyConn)
                    da.Fill(ds, "AugSalary")
                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView1.DataSource = view
                Catch ex As Exception
                End Try

            Case 9

                Try
                    MyConn = New OleDbConnection
                    MyConn.ConnectionString = connString
                    ds = New DataSet
                    tables = ds.Tables
                    da = New OleDbDataAdapter("Select * from [SeptSalary] Where EmpNO=" + EmpId.Text + "", MyConn)
                    da.Fill(ds, "SeptSalary")
                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView1.DataSource = view
                Catch ex As Exception
                End Try

            Case 10

                Try
                    MyConn = New OleDbConnection
                    MyConn.ConnectionString = connString
                    ds = New DataSet
                    tables = ds.Tables
                    da = New OleDbDataAdapter("Select * from [OctSalary] Where EmpNO=" + EmpId.Text + "", MyConn)
                    da.Fill(ds, "OctSalary")
                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView1.DataSource = view
                Catch ex As Exception
                End Try

            Case 11


                Try
                    MyConn = New OleDbConnection
                    MyConn.ConnectionString = connString
                    ds = New DataSet
                    tables = ds.Tables
                    da = New OleDbDataAdapter("Select * from [NovSalary] Where EmpNO=" + EmpId.Text + "", MyConn)
                    da.Fill(ds, "NovSalary")
                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView1.DataSource = view
                Catch ex As Exception
                End Try

            Case 12

                Try
                    MyConn = New OleDbConnection
                    MyConn.ConnectionString = connString
                    ds = New DataSet
                    tables = ds.Tables
                    da = New OleDbDataAdapter("Select * from [DecSalary] Where EmpNO=" + EmpId.Text + "", MyConn)
                    da.Fill(ds, "DecSalary")
                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView1.DataSource = view
                Catch ex As Exception
                End Try
            Case Else
                MsgBox("Enter Correct Month")
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MonthNo.Text = "" And EmpId.Text = "" Then
            Exit Sub
        End If
        Dim SalMonth As Integer
        SalMonth = Convert.ToInt32(MonthNo.Text)

        Select Case SalMonth
            Case 1
                Dim D As String
                D = MsgBox("Are you sure you want to DELETE?", vbYesNo + vbQuestion, "Please Think for a While")
                If D = vbYes Then

                    Dim Str As String
                    If CheckId() = False Then
                        MsgBox("EmpNO : Integer Value Required!!!")
                        Exit Sub
                    End If
                    Try
                        Str = "delete from JanSalary where EmpNO="
                        Str += EmpId.Text.Trim
                        Con.Open()
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Dst.clear()
                        Dad = New OleDbDataAdapter("SELECT * FROM JanSalary ORDER BY EmpNO", Con)
                        Dad.Fill(Dst, "JanSalary")
                        MsgBox("Record deleted successfully...")
                        If CurrentRow > 0 Then
                            CurrentRow -= 1
                        End If
                        Con.Close()
                    Catch ex As Exception
                        MessageBox.Show("Could Not delete Record!!!")
                        Con.Close()
                    End Try
                    Try
                        MyConn = New OleDbConnection
                        MyConn.ConnectionString = connString
                        ds = New DataSet
                        tables = ds.Tables
                        da = New OleDbDataAdapter("Select * from [JanSalary]", MyConn)
                        da.Fill(ds, "JanSalary")
                        Dim view As New DataView(tables(0))
                        source1.DataSource = view
                        DataGridView1.DataSource = view
                    Catch ex As Exception
                    End Try
                Else
                    Exit Sub
                End If
            Case 2
                Dim D As String
                D = MsgBox("Are you sure you want to DELETE?", vbYesNo + vbQuestion, "Please Think for a While")
                If D = vbYes Then
                    Dim Str As String
                    If CheckId() = False Then
                        MsgBox("EmpNO : Integer Value Required!!!")
                        Exit Sub
                    End If
                    Try
                        Str = "delete from FebSalary where EmpNO="
                        Str += EmpId.Text.Trim
                        Con.Open()
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Dst.clear()
                        Dad = New OleDbDataAdapter("SELECT * FROM FebSalary ORDER BY EmpNO", Con)
                        Dad.Fill(Dst, "FebSalary")
                        MsgBox("Record deleted successfully...")
                        If CurrentRow > 0 Then
                            CurrentRow -= 1
                        End If
                        Con.Close()
                    Catch ex As Exception
                        MessageBox.Show("Could Not delete Record!!!")
                        Con.Close()
                    End Try
                    Try
                        MyConn = New OleDbConnection
                        MyConn.ConnectionString = connString
                        ds = New DataSet
                        tables = ds.Tables
                        da = New OleDbDataAdapter("Select * from [FebSalary]", MyConn)
                        da.Fill(ds, "FebSalary")
                        Dim view As New DataView(tables(0))
                        source1.DataSource = view
                        DataGridView1.DataSource = view
                    Catch ex As Exception
                    End Try
                Else
                    Exit Sub
                End If
            Case 3
                Dim D As String
                D = MsgBox("Are you sure you want to DELETE?", vbYesNo + vbQuestion, "Please Think for a While")
                If D = vbYes Then
                    Dim Str As String
                    If CheckId() = False Then
                        MsgBox("EmpNO : Integer Value Required!!!")
                        Exit Sub
                    End If
                    Try
                        Str = "delete from MarchSalary where EmpNO="
                        Str += EmpId.Text.Trim
                        Con.Open()
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Dst.clear()
                        Dad = New OleDbDataAdapter("SELECT * FROM MarchSalary ORDER BY EmpNO", Con)
                        Dad.Fill(Dst, "MarchSalary")
                        MsgBox("Record deleted successfully...")
                        If CurrentRow > 0 Then
                            CurrentRow -= 1
                        End If
                        Con.Close()
                    Catch ex As Exception
                        MessageBox.Show("Could Not delete Record!!!")
                        Con.Close()
                    End Try
                    Try
                        MyConn = New OleDbConnection
                        MyConn.ConnectionString = connString
                        ds = New DataSet
                        tables = ds.Tables
                        da = New OleDbDataAdapter("Select * from [MarchSalary]", MyConn)
                        da.Fill(ds, "MarchSalary")
                        Dim view As New DataView(tables(0))
                        source1.DataSource = view
                        DataGridView1.DataSource = view
                    Catch ex As Exception
                    End Try
                Else
                    Exit Sub
                End If
            Case 4
                Dim D As String
                D = MsgBox("Are you sure you want to DELETE?", vbYesNo + vbQuestion, "Please Think for a While")
                If D = vbYes Then
                    Dim Str As String
                    If CheckId() = False Then
                        MsgBox("EmpNO : Integer Value Required!!!")
                        Exit Sub
                    End If
                    Try
                        Str = "delete from AprilSalary where EmpNO="
                        Str += EmpId.Text.Trim
                        Con.Open()
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Dst.clear()
                        Dad = New OleDbDataAdapter("SELECT * FROM AprilSalary ORDER BY EmpNO", Con)
                        Dad.Fill(Dst, "AprilSalary")
                        MsgBox("Record deleted successfully...")
                        If CurrentRow > 0 Then
                            CurrentRow -= 1
                        End If
                        Con.Close()
                    Catch ex As Exception
                        MessageBox.Show("Could Not delete Record!!!")
                        Con.Close()
                    End Try
                    Try
                        MyConn = New OleDbConnection
                        MyConn.ConnectionString = connString
                        ds = New DataSet
                        tables = ds.Tables
                        da = New OleDbDataAdapter("Select * from [AprilSalary]", MyConn)
                        da.Fill(ds, "AprilSalary")
                        Dim view As New DataView(tables(0))
                        source1.DataSource = view
                        DataGridView1.DataSource = view
                    Catch ex As Exception
                    End Try
                Else
                    Exit Sub
                End If
            Case 5
                Dim D As String
                D = MsgBox("Are you sure you want to DELETE?", vbYesNo + vbQuestion, "Please Think for a While")
                If D = vbYes Then
                    Dim Str As String
                    If CheckId() = False Then
                        MsgBox("EmpNO : Integer Value Required!!!")
                        Exit Sub
                    End If
                    Try
                        Str = "delete from MaySalary where EmpNO="
                        Str += EmpId.Text.Trim
                        Con.Open()
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Dst.clear()
                        Dad = New OleDbDataAdapter("SELECT * FROM MaySalary ORDER BY EmpNO", Con)
                        Dad.Fill(Dst, "MaySalary")
                        MsgBox("Record deleted successfully...")
                        If CurrentRow > 0 Then
                            CurrentRow -= 1
                        End If
                        Con.Close()
                    Catch ex As Exception
                        MessageBox.Show("Could Not delete Record!!!")
                        Con.Close()
                    End Try
                    Try
                        MyConn = New OleDbConnection
                        MyConn.ConnectionString = connString
                        ds = New DataSet
                        tables = ds.Tables
                        da = New OleDbDataAdapter("Select * from [MaySalary]", MyConn)
                        da.Fill(ds, "MaySalary")
                        Dim view As New DataView(tables(0))
                        source1.DataSource = view
                        DataGridView1.DataSource = view
                    Catch ex As Exception
                    End Try
                Else
                    Exit Sub
                End If
            Case 6
                Dim D As String
                D = MsgBox("Are you sure you want to DELETE?", vbYesNo + vbQuestion, "Please Think for a While")
                If D = vbYes Then
                    Dim Str As String
                    If CheckId() = False Then
                        MsgBox("EmpNO : Integer Value Required!!!")
                        Exit Sub
                    End If
                    Try
                        Str = "delete from JuneSalary where EmpNO="
                        Str += EmpId.Text.Trim
                        Con.Open()
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Dst.clear()
                        Dad = New OleDbDataAdapter("SELECT * FROM JuneSalary ORDER BY EmpNO", Con)
                        Dad.Fill(Dst, "JuneSalary")
                        MsgBox("Record deleted successfully...")
                        If CurrentRow > 0 Then
                            CurrentRow -= 1
                        End If
                        Con.Close()
                    Catch ex As Exception
                        MessageBox.Show("Could Not delete Record!!!")
                        Con.Close()
                    End Try
                    Try
                        MyConn = New OleDbConnection
                        MyConn.ConnectionString = connString
                        ds = New DataSet
                        tables = ds.Tables
                        da = New OleDbDataAdapter("Select * from [JuneSalary]", MyConn)
                        da.Fill(ds, "JuneSalary")
                        Dim view As New DataView(tables(0))
                        source1.DataSource = view
                        DataGridView1.DataSource = view
                    Catch ex As Exception
                    End Try
                Else
                    Exit Sub
                End If
            Case 7
                Dim D As String
                D = MsgBox("Are you sure you want to DELETE?", vbYesNo + vbQuestion, "Please Think for a While")
                If D = vbYes Then
                    Dim Str As String
                    If CheckId() = False Then
                        MsgBox("EmpNO : Integer Value Required!!!")
                        Exit Sub
                    End If
                    Try
                        Str = "delete from JulySalary where EmpNO="
                        Str += EmpId.Text.Trim
                        Con.Open()
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Dst.clear()
                        Dad = New OleDbDataAdapter("SELECT * FROM JulySalary ORDER BY EmpNO", Con)
                        Dad.Fill(Dst, "JulySalary")
                        MsgBox("Record deleted successfully...")
                        If CurrentRow > 0 Then
                            CurrentRow -= 1
                        End If
                        Con.Close()
                    Catch ex As Exception
                        MessageBox.Show("Could Not delete Record!!!")
                        Con.Close()
                    End Try
                    Try
                        MyConn = New OleDbConnection
                        MyConn.ConnectionString = connString
                        ds = New DataSet
                        tables = ds.Tables
                        da = New OleDbDataAdapter("Select * from [JulySalary]", MyConn)
                        da.Fill(ds, "JulySalary")
                        Dim view As New DataView(tables(0))
                        source1.DataSource = view
                        DataGridView1.DataSource = view
                    Catch ex As Exception
                    End Try
                Else
                    Exit Sub
                End If
            Case 8
                Dim D As String
                D = MsgBox("Are you sure you want to DELETE?", vbYesNo + vbQuestion, "Please Think for a While")
                If D = vbYes Then
                    Dim Str As String
                    If CheckId() = False Then
                        MsgBox("EmpNO : Integer Value Required!!!")
                        Exit Sub
                    End If
                    Try
                        Str = "delete from AugSalary where EmpNO="
                        Str += EmpId.Text.Trim
                        Con.Open()
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Dst.clear()
                        Dad = New OleDbDataAdapter("SELECT * FROM AugSalary ORDER BY EmpNO", Con)
                        Dad.Fill(Dst, "AugSalary")
                        MsgBox("Record deleted successfully...")
                        If CurrentRow > 0 Then
                            CurrentRow -= 1
                        End If
                        Con.Close()
                    Catch ex As Exception
                        MessageBox.Show("Could Not delete Record!!!")
                        Con.Close()
                    End Try
                    Try
                        MyConn = New OleDbConnection
                        MyConn.ConnectionString = connString
                        ds = New DataSet
                        tables = ds.Tables
                        da = New OleDbDataAdapter("Select * from [AugSalary]", MyConn)
                        da.Fill(ds, "AugSalary")
                        Dim view As New DataView(tables(0))
                        source1.DataSource = view
                        DataGridView1.DataSource = view
                    Catch ex As Exception
                    End Try
                Else
                    Exit Sub
                End If
            Case 9
                Dim D As String
                D = MsgBox("Are you sure you want to DELETE?", vbYesNo + vbQuestion, "Please Think for a While")
                If D = vbYes Then


                    Dim Str As String
                    If CheckId() = False Then
                        MsgBox("EmpNO : Integer Value Required!!!")
                        Exit Sub
                    End If
                    Try
                        Str = "delete from SeptSalary where EmpNO="
                        Str += EmpId.Text.Trim
                        Con.Open()
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Dst.clear()
                        Dad = New OleDbDataAdapter("SELECT * FROM SeptSalary ORDER BY EmpNO", Con)
                        Dad.Fill(Dst, "SeptSalary")
                        MsgBox("Record deleted successfully...")
                        If CurrentRow > 0 Then
                            CurrentRow -= 1
                        End If
                        Con.Close()
                    Catch ex As Exception
                        MessageBox.Show("Could Not delete Record!!!")
                        Con.Close()
                    End Try
                    Try
                        MyConn = New OleDbConnection
                        MyConn.ConnectionString = connString
                        ds = New DataSet
                        tables = ds.Tables
                        da = New OleDbDataAdapter("Select * from [SeptSalary]", MyConn)
                        da.Fill(ds, "SeptSalary")
                        Dim view As New DataView(tables(0))
                        source1.DataSource = view
                        DataGridView1.DataSource = view
                    Catch ex As Exception
                    End Try
                Else
                    Exit Sub
                End If
            Case 10
                Dim D As String
                D = MsgBox("Are you sure you want to DELETE?", vbYesNo + vbQuestion, "Please Think for a While")
                If D = vbYes Then
                    Dim Str As String
                    If CheckId() = False Then
                        MsgBox("EmpNO : Integer Value Required!!!")
                        Exit Sub
                    End If
                    Try
                        Str = "delete from OctSalary where EmpNO="
                        Str += EmpId.Text.Trim
                        Con.Open()
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Dst.clear()
                        Dad = New OleDbDataAdapter("SELECT * FROM OctSalary ORDER BY EmpNO", Con)
                        Dad.Fill(Dst, "OctSalary")
                        MsgBox("Record deleted successfully...")
                        If CurrentRow > 0 Then
                            CurrentRow -= 1
                        End If
                        Con.Close()
                    Catch ex As Exception
                        MessageBox.Show("Could Not delete Record!!!")
                        Con.Close()
                    End Try
                    Try
                        MyConn = New OleDbConnection
                        MyConn.ConnectionString = connString
                        ds = New DataSet
                        tables = ds.Tables
                        da = New OleDbDataAdapter("Select * from [OctSalary]", MyConn)
                        da.Fill(ds, "OctSalary")
                        Dim view As New DataView(tables(0))
                        source1.DataSource = view
                        DataGridView1.DataSource = view
                    Catch ex As Exception
                    End Try
                Else
                    Exit Sub
                End If
            Case 11
                Dim D As String
                D = MsgBox("Are you sure you want to DELETE?", vbYesNo + vbQuestion, "Please Think for a While")
                If D = vbYes Then
                    Dim Str As String
                    If CheckId() = False Then
                        MsgBox("EmpNO : Integer Value Required!!!")
                        Exit Sub
                    End If
                    Try
                        Str = "delete from NovSalary where EmpNO="
                        Str += EmpId.Text.Trim
                        Con.Open()
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Dst.clear()
                        Dad = New OleDbDataAdapter("SELECT * FROM NovSalary ORDER BY EmpNO", Con)
                        Dad.Fill(Dst, "NovSalary")
                        MsgBox("Record deleted successfully...")
                        If CurrentRow > 0 Then
                            CurrentRow -= 1
                        End If
                        Con.Close()
                    Catch ex As Exception
                        MessageBox.Show("Could Not delete Record!!!")
                        Con.Close()
                    End Try

                    Try
                        MyConn = New OleDbConnection
                        MyConn.ConnectionString = connString
                        ds = New DataSet
                        tables = ds.Tables
                        da = New OleDbDataAdapter("Select * from [NovSalary]", MyConn)
                        da.Fill(ds, "NovSalary")
                        Dim view As New DataView(tables(0))
                        source1.DataSource = view
                        DataGridView1.DataSource = view
                    Catch ex As Exception
                    End Try
                Else
                    Exit Sub
                End If
            Case 12
                Dim D As String
                D = MsgBox("Are you sure you want to DELETE?", vbYesNo + vbQuestion, "Please Think for a While")
                If D = vbYes Then
                    Dim Str As String
                    If CheckId() = False Then
                        MsgBox("EmpNO : Integer Value Required!!!")
                        Exit Sub
                    End If
                    Try
                        Str = "delete from DecSalary where EmpNO="
                        Str += EmpId.Text.Trim
                        Con.Open()
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Dst.clear()
                        Dad = New OleDbDataAdapter("SELECT * FROM DecSalary ORDER BY EmpNO", Con)
                        Dad.Fill(Dst, "DecSalary")
                        MsgBox("Record deleted successfully...")
                        If CurrentRow > 0 Then
                            CurrentRow -= 1
                        End If
                        Con.Close()
                    Catch ex As Exception
                        MessageBox.Show("Could Not delete Record!!!")
                        Con.Close()
                    End Try
                    Try
                        MyConn = New OleDbConnection
                        MyConn.ConnectionString = connString
                        ds = New DataSet
                        tables = ds.Tables
                        da = New OleDbDataAdapter("Select * from [DecSalary]", MyConn)
                        da.Fill(ds, "DecSalary")
                        Dim view As New DataView(tables(0))
                        source1.DataSource = view
                        DataGridView1.DataSource = view
                    Catch ex As Exception
                    End Try
                Else
                    Exit Sub
                End If
            Case Else
                MsgBox("Enter Correct Month 1 to 12 !!!!!")
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Salary.Show()
    End Sub
    Private Function CheckId()
        Try
            If IsNumeric(EmpId.Text) = False Then

                EmpId.Focus()
                Return False
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub Edit_Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForDeleteSalary()
        Me.TopMost = True
        Me.CenterToScreen()

    End Sub
    Private Sub DeleteSure()
        Dim D As String

        D = MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion, "Thanking You")

        If D = vbYes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub
   
End Class