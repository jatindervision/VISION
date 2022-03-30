Imports ADOX
Imports System.Data.OleDb
Imports System.String
Public Class EmployeeDetail
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim dest As New BindingSource
    Private Sub EmployeeDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForEmployeeEntry()
        Me.CenterToScreen()
        Me.TopMost = True
        CollegeNamedisplay()
        Me.ToolTip1.SetToolTip(Me.Button3, "Get Backup Before Use This Delete Button , This Will Delete Employee Record ")
        Me.ToolTip1.SetToolTip(Me.Button6, "I will Back up your all Employee Record Each Time When You Use Me , I am Backup Button ")
        Me.ToolTip1.SetToolTip(Me.Label6, "Enter Employee Id  Only in Numeric and Should be series {e.g 1, 2, 3....... ")
        Try
            CurrentRow = 0
            Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;")
            Dad = New OleDbDataAdapter("SELECT * FROM EmployeeDetail ORDER BY EmpId", Con)
            Con.Open()
            Dad.Fill(Dst, "EmployeeDetail")
            ShowData(CurrentRow)
            Con.Close()


            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [EmployeeDetail]", MyConn)
            da.Fill(ds, "EmployeeDetail")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            Id.Text = Dst.Tables("EmployeeDetail").Rows(CurrentRow)("EmpId")
            EmpName.Text = Dst.Tables("EmployeeDetail").Rows(CurrentRow)("Name")
            Ph.Text = Dst.Tables("EmployeeDetail").Rows(CurrentRow)("Ph_No")
            EDesignation.Text = Dst.Tables("EmployeeDetail").Rows(CurrentRow)("Designation")
            Address.Text = Dst.Tables("EmployeeDetail").Rows(CurrentRow)("Address")
            DOB.Text = Dst.Tables("EmployeeDetail").Rows(CurrentRow)("DOB")
            PAN.Text = Dst.Tables("EmployeeDetail").Rows(CurrentRow)("PAN_No")
            MF.Text = Dst.Tables("EmployeeDetail").Rows(CurrentRow)("Gender")

        Catch ex As Exception
        End Try
    End Sub
    Private Sub clear()
        Id.Text = ""
        EmpName.Text = ""
        Ph.Text = ""
        Address.Text = ""
        DOB.Text = ""
        PAN.Text = ""
        DOJ.Text = ""
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
            da = New OleDbDataAdapter("Select * from [EmployeeDetail]", MyConn)
            da.Fill(ds, "EmployeeDetail")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckId() = False Then
            MsgBox("Empployee Id : Integer Value Required !!!")
            Exit Sub
        ElseIf IsIdExist() = True Then
            MsgBox("Employee ID : Id is already exist. Please choose another one.....")
            Exit Sub
        End If

        Try
            Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim sqlquery As String = "INSERT INTO EmployeeDetail " & "(EmpId,Employee_Name,Ph_No,Designation,Address,DOB,PAN_No,Gender,Date_of_Joining) " & "VALUES (@EmpId, @Employee_Name,@Ph_No,@Designation,@Address,@DOB, @PAN_No,@Gender,@Date_of_Joining)"

            ' Use this form to initialize both connection and command to 
            ' avoid forgetting to set the appropriate properties....

            Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                    conn.Open()
                    cmd.Parameters.AddWithValue("@EmpId", Id.Text)
                    cmd.Parameters.AddWithValue("@Employee_Name", EmpName.Text)
                    cmd.Parameters.AddWithValue("@Ph_No", Ph.Text)
                    cmd.Parameters.AddWithValue("@Designation", EDesignation.Text)
                    cmd.Parameters.AddWithValue("@Address", Address.Text)
                    cmd.Parameters.AddWithValue("@DOB", DOB.Text)
                    cmd.Parameters.AddWithValue("@PAN_No", PAN.Text)
                    cmd.Parameters.AddWithValue("@Gender", MF.Text)
                    cmd.Parameters.AddWithValue("@Date_of_Joining", DOJ.Text)

                    Dim rowsInserted = cmd.ExecuteNonQuery()
                    If rowsInserted > 0 Then
                        MessageBox.Show("One record successfully added!", "Added!")
                        Try
                            MyConn = New OleDbConnection
                            MyConn.ConnectionString = connString
                            ds = New DataSet
                            tables = ds.Tables
                            da = New OleDbDataAdapter("Select * from [EmployeeDetail]", MyConn)
                            da.Fill(ds, "EmployeeDetail")
                            Dim view As New DataView(tables(0))
                            source1.DataSource = view
                            DataGridView1.DataSource = view
                        Catch ex As Exception
                        End Try
                    Else
                        MessageBox.Show("Failure to add new record!", "Failure!")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
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
    ' To show the data in the DataGridView1view

    ' To check whether Id exist in database
    Private Function IsIdExist()

        Dim Str, Str1 As String
        Dim i As Integer
        Str = Id.Text
        i = 0
        While i <> Dst.Tables("EmployeeDetail").rows.count
            Str1 = Dst.Tables("EmployeeDetail").Rows(i)("EmpId")
            If Str = Str1 Then
                Return True
            End If
            i += 1
        End While
        Return False

    End Function

    Private Sub ExitNow_Click(sender As Object, e As EventArgs) Handles ExitNow.Click
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
            j = Dst.Tables("EmployeeDetail").Rows.Count - 1
            i = 0
            While i <> j + 1
                If SearchId = Dst.Tables("EmployeeDetail").Rows(i)("EmpId") Then
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
        da = New OleDbDataAdapter("SELECT *  FROM EmployeeDetail Where EmpId=" + Id.Text + "", MyConn)
        da.Fill(ds, "EmployeeDetail")
        Dim view As New DataView(tables(0))
        dest.DataSource = view
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
            Str = "update EmployeeDetail set EmpId="
            Str += """" & Id.Text & """"
            Str += " where EmpId="
            Str += Id.Text.Trim()
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update EmployeeDetail set Name="
            Str += """" & EmpName.Text & """"
            Str += " where EmpId="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update EmployeeDetail set Ph_No="
            Str += """" & Ph.Text & """"
            Str += " where EmpId="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update EmployeeDetail set Designation="
            Str += """" & EDesignation.Text & """"
            Str += " where EmpId="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update EmployeeDetail set Address="
            Str += """" & Address.Text & """"
            Str += " where EmpId="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update EmployeeDetail set DOB="
            Str += """" & DOB.Text & """"
            Str += " where EmpId="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update EmployeeDetail set PAN_No="
            Str += """" & PAN.Text & """"
            Str += " where EmpId="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()

            TextBox1.Text = MF.SelectedItem.ToString()
            Str = "update EmployeeDetail set Gender="
            Str += """" & TextBox1.Text & """"
            Str += " where EmpId="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()

            Str = "update EmployeeDetail set Date_of_Joining="
            Str += """" & DOJ.Text & """"
            Str += " where EmpId="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM EmployeeDetail ORDER BY EmpId", Con)
            Dad.Fill(Dst, "EmployeeDetail")
            MsgBox("Updated Successfully...")
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [EmployeeDetail]", MyConn)
            da.Fill(ds, "EmployeeDetail")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
            MsgBox(ex.Message & "," & ex.Source)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Str As String
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required!!!")
            Exit Sub
        End If
        Try
            Str = "delete from EmployeeDetail where Empid="
            Str += Id.Text.Trim
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Dst.clear()
            Dad = New OleDbDataAdapter("SELECT * FROM EmployeeDetail ORDER BY EmpId", Con)
            Dad.Fill(Dst, "EmployeeDetail")
            MsgBox("Record deleted successfully...")
            If CurrentRow > 0 Then
                CurrentRow -= 1
                ShowData(CurrentRow)
            End If
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [EmployeeDetail]", MyConn)
            da.Fill(ds, "EmployeeDetail")
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
    Private Sub CollegeNamedisplay()
        Try
            Dim ABC As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;")
            Dim Dst = New DataSet
            Dim ds As New DataSet
            Dim dt As New DataTable
            ABC.Open()
            ds.Tables.Add(dt)

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter("SELECT Name from Name ", ABC)
            da.Fill(dt)
            CollegeName.Text = dt.Rows(0).Item(0)
            ABC.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GoEmpBackUp.Show()
    End Sub
End Class