Imports ADOX
Imports System.Data.OleDb
Imports System.String
Public Class StudentEntry
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim dest As New BindingSource
    Dim i As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckId() = False Then
            MsgBox("Student SNO : Integer Value Required !!!")
            Exit Sub
        End If
        Try
            Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim sqlquery As String = "INSERT INTO StAdmission " & "(Id,Adm_NO,StName,Parentage,Address,DOB,Ph_No,Gender,Date_of_Admission,Course_Name) " & "VALUES (@Id,@Adm_NO,@StName,@Parentage,@Address,@DOB,@Ph_No,@Gender,@Date_of_Admission,@Course_Name)"
            ' Use this form to initialize both connection and command to 
            ' avoid forgetting to set the appropriate properties....
            Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)
                    conn.Open()
                    cmd.Parameters.AddWithValue("@Id", Id.Text)
                    cmd.Parameters.AddWithValue("@Adm_NO", ANO.Text)
                    cmd.Parameters.AddWithValue("@StName", StName.Text)
                    cmd.Parameters.AddWithValue("@Parentage", Parentage.Text)
                    cmd.Parameters.AddWithValue("@Address", Address.Text)
                    cmd.Parameters.AddWithValue("@DOB", DOB.Text)
                    cmd.Parameters.AddWithValue("@Ph_No", Ph.Text)
                    cmd.Parameters.AddWithValue("@Gender", MF.Text)
                    cmd.Parameters.AddWithValue("@Date_of_Admission", DOA.Text)
                    cmd.Parameters.AddWithValue("@Course_Name", CName.Text)
                    Dim rowsInserted = cmd.ExecuteNonQuery()
                    If rowsInserted > 0 Then

                        MessageBox.Show("One record successfully added!", "Added!")


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
                            Con.Close()
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
      
        TotalA.Text = DataGridView1.Rows.Count - 1
        NNXT()
        Id.Focus()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required !!!")
            Exit Sub
        End If

        Try
            Dim Str As String
            Str = "update StAdmission set Id="
            Str += """" & Id.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Con.Open()
            Str = "update StAdmission set Adm_NO="
            Str += """" & ANO.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update StAdmission set StName="
            Str += """" & StName.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update StAdmission set Parentage="
            Str += """" & Parentage.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update StAdmission set Address="
            Str += """" & Address.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update StAdmission set DOB="
            Str += """" & DOB.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update StAdmission set Ph_No="
            Str += """" & Ph.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            TextBox1.Text = MF.SelectedItem.ToString()
            Str = "update StAdmission set Gender="
            Str += """" & TextBox1.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update StAdmission set Date_of_Admission="
            Str += """" & DOA.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update StAdmission set Course_Name="
            Str += """" & CName.Text & """"
            Str += " where Id="
            Str += Id.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Con.Close()

            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM StAdmission ORDER BY Id", Con)
            Dad.Fill(Dst, "StAdmission")
            MsgBox("Updated Successfully...")
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
            Str = "delete from StAdmission where Id="
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
            source1.DataSource = view
            DataGridView1.DataSource = view
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not delete Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
            Con.Close()
        End Try
    End Sub
    Private Sub clear()
        Id.Text = ""
        ANO.Text = ""
        StName.Text = ""
        Parentage.Text = ""
        Address.Text = ""
        DOB.Text = ""
        Ph.Text = ""
        DOA.Text = ""
        CName.Text = ""
        DataGridView1.DataSource = Nothing
        Dim SN As Integer = 0
    End Sub

    Private Sub StudentEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForCollegeStuEntry()
        Me.CenterToScreen()
        Me.TopMost = True
     
        Me.ToolTip1.SetToolTip(Me.Button7, "This Button Will be Used When Someone Complete Their Course , its for Attendance Registor")


        Try
            CurrentRow = 0
            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM StAdmission ORDER BY Id", Con)
            Dad.Fill(Dst, "StAdmission")
            TotalA.Text = Dst.Tables("StAdmission").Rows.Count
            ShowData(CurrentRow)
           
            Con.Close()
        Catch ex As Exception
        End Try
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
  
  
    Private Sub ShowData(ByVal CurrentRow)
        Try
            Id.Text = Dst.Tables("StAdmission").Rows(CurrentRow)("Id")
            ANO.Text = Dst.Tables("StAdmission").Rows(CurrentRow)("Adm_NO")
            StName.Text = Dst.Tables("StAdmission").Rows(CurrentRow)("StName")
            Parentage.Text = Dst.Tables("StAdmission").Rows(CurrentRow)("Parentage")
            Address.Text = Dst.Tables("StAdmission").Rows(CurrentRow)("Address")
            DOB.Text = Dst.Tables("StAdmission").Rows(CurrentRow)("DOB")
            Ph.Text = Dst.Tables("StAdmission").Rows(CurrentRow)("Ph_No")
            MF.Text = Dst.Tables("StAdmission").Rows(CurrentRow)("Gender")
            DOA.Text = Dst.Tables("StAdmission").Rows(CurrentRow)("Date_of_Admission")
            CName.Text = Dst.Tables("StAdmission").Rows(CurrentRow)("Course_Name")


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
 

    Private Sub ExitNow_Click(sender As Object, e As EventArgs) Handles ExitNow.Click
        Me.Close()
    End Sub

    
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CourseCompleted.Show()
    End Sub
    Private Sub NNXT()
        Id.Text = ""
        ANO.Text = ""
        StName.Text = ""
        Parentage.Text = ""
        Address.Text = ""
        DOB.Text = ""
        Ph.Text = ""
        DOA.Text = ""
        CName.Text = ""
    End Sub
End Class