Imports ADOX
Imports System.Data.OleDb
Public Class IGNOUExpenses
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim dest As New BindingSource
    Dim i As Integer = 0
    Private Sub IGNOUExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        IGNOUExpensesfor()
        Me.CenterToScreen()
        Me.TopMost = True
        Date_of_Expense.Text = DateTimePicker1.Value.ToShortDateString
        Me.ToolTip1.SetToolTip(Me.Button7, "This Button Will be Used When Someone Complete Their Course , its for Attendance Registor")


        CollegeNamedisplay()
        Try
            CurrentRow = 0
            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM IGNOUExpenses ORDER BY SN", Con)
            Dad.Fill(Dst, "IGNOUExpenses")
            MsgBox("Number of Record(s)  -  " & Dst.Tables(0).Rows.Count)
            TotalA.Text = Dst.Tables(0).Rows.Count
            ShowData(CurrentRow)
            Con.Close()


            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [IGNOUExpenses]", MyConn)
            da.Fill(ds, "IGNOUExpenses")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try
            TextBox1.Text = Dst.Tables("IGNOUExpenses").Rows(CurrentRow)("SN")
            TextBox2.Text = Dst.Tables("IGNOUExpenses").Rows(CurrentRow)("Postage")
            TextBox3.Text = Dst.Tables("IGNOUExpenses").Rows(CurrentRow)("Telephone")
            TextBox4.Text = Dst.Tables("IGNOUExpenses").Rows(CurrentRow)("Stationary")
            TextBox5.Text = Dst.Tables("IGNOUExpenses").Rows(CurrentRow)("Furniture")
            TextBox6.Text = Dst.Tables("IGNOUExpenses").Rows(CurrentRow)("Equipment")
            TextBox7.Text = Dst.Tables("IGNOUExpenses").Rows(CurrentRow)("Electricity_Charges")
            TextBox8.Text = Dst.Tables("IGNOUExpenses").Rows(CurrentRow)("Water_Charges")
            TextBox9.Text = Dst.Tables("IGNOUExpenses").Rows(CurrentRow)("Printing_Binding")
            TextBox10.Text = Dst.Tables("IGNOUExpenses").Rows(CurrentRow)("Entertainmnet")
            Date_of_Expense.Text = Dst.Tables("IGNOUExpenses").Rows(CurrentRow)("Date_of_Expense")



        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub CollegeNamedisplay()
        Dim ABC As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;")
        Dim Dst = New DataSet
        Dim ds As New DataSet
        Dim dt As New DataTable
        ABC.Open()
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT Name from Name ", ABC)
        da.Fill(dt)
        Collegename.Text = dt.Rows(0).Item(0)
        ABC.Close()
    End Sub

    Private Sub ExitNow_Click(sender As Object, e As EventArgs) Handles ExitNow.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try



            Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim sqlquery As String = "INSERT INTO IGNOUExpenses " & "(SN,Postage,Telephone,Stationary,Furniture,Equipment,Electricity_Charges,Water_Charges,Printing_Binding,Entertainment,Date_of_Expense)" & "VALUES (@SN,@Postage,@Telephone,@Stationary,@Furniture,@Equipment,@Electricity_Charges,@Water_Charges,@Printing_Binding,@Entertainment,@Date_of_Expense)"

            ' Use this form to initialize both connection and command to 
            ' avoid forgetting to set the appropriate properties....

            Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                    conn.Open()

                    cmd.Parameters.AddWithValue("@SN", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@Postage", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@Telephone", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@Stationary", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@Furniture", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@Equipment", TextBox6.Text)
                    cmd.Parameters.AddWithValue("@Electricity_Charges", TextBox7.Text)
                    cmd.Parameters.AddWithValue("@Water_Charges", TextBox8.Text)
                    cmd.Parameters.AddWithValue("@Printing_Binding", TextBox9.Text)
                    cmd.Parameters.AddWithValue("@Entertainment", TextBox10.Text)
                    cmd.Parameters.AddWithValue("@Date_of_Expense", Date_of_Expense.Text)
                    Dim rowsInserted = cmd.ExecuteNonQuery()


                    If rowsInserted > 0 Then

                        MessageBox.Show("One record successfully added!", "Added!")


                        Try
                            MyConn = New OleDbConnection
                            MyConn.ConnectionString = connString
                            ds = New DataSet
                            tables = ds.Tables
                            da = New OleDbDataAdapter("Select * from [IGNOUExpenses]", MyConn)
                            da.Fill(ds, "IGNOUExpenses")
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
        clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
    End Sub
    Private Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        Date_of_Expense.Text = ""
        TextBox10.Text = ""

        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [IGNOUExpenses]", MyConn)
            da.Fill(ds, "IGNOUExpenses")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim SearchId As Integer
        Dim i, j As Integer
       
        Try
            SearchId = TextBox1.Text
            j = Dst.Tables("IGNOUExpenses").Rows.Count - 1
            i = 0
            While i <> j + 1
                If SearchId = Dst.Tables("IGNOUExpenses").Rows(i)("SN") Then
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
        da = New OleDbDataAdapter("SELECT *  FROM IGNOUExpenses Where SN=" + TextBox1.Text + "", MyConn)
        da.Fill(ds, "IGNOUExpenses")
        Dim view As New DataView(tables(0))
        dest.DataSource = view
        ' view.RowFilter = "Id = " + TextBox1.Text + ";"
        For i = 0 To Me.DataGridView1.Columns.Count - 1
            Me.DataGridView1.Columns(i).Name = Me.DataGridView1.Columns(i).DataPropertyName
        Next
        DataGridView1.DataSource = view
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If CheckId() = False Then
            MsgBox("Id : Integer Value Required !!!")
            Exit Sub
        End If

        Try
            Dim Str As String
            Str = "update IGNOUExpenses set SN="
            Str += """" & TextBox1.Text & """"
            Str += " where SN="
            Str += TextBox1.Text.Trim()
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IGNOUExpenses set Postage="
            Str += """" & TextBox2.Text & """"
            Str += " where SN="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IGNOUExpenses set Telephone="
            Str += """" & TextBox3.Text & """"
            Str += " where SN="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IGNOUExpenses set Stationary="
            Str += """" & TextBox4.Text & """"
            Str += " where SN="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IGNOUExpenses set Furniture="
            Str += """" & TextBox5.Text & """"
            Str += " where SN="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IGNOUExpenses set Equipment="
            Str += """" & TextBox6.Text & """"
            Str += " where SN="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IGNOUExpenses set Electricity_Charges="
            Str += """" & TextBox7.Text & """"
            Str += " where SN="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IGNOUExpenses set Water_Charges="
            Str += """" & TextBox8.Text & """"
            Str += " where SN="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IGNOUExpenses set Printing_Binding="
            Str += """" & TextBox9.Text & """"
            Str += " where SN="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IGNOUExpenses set Entertainment="
            Str += """" & TextBox10.Text & """"
            Str += " where SN="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            Con.Open()
            Str = "update IGNOUExpenses set Date_of_Expense="
            Str += """" & Date_of_Expense.Text & """"
            Str += " where SN="
            Str += TextBox1.Text.Trim()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            

            Dst.Clear()
            Dad = New OleDbDataAdapter("SELECT * FROM IGNOUExpenses ORDER BY SN", Con)
            Dad.Fill(Dst, "IGNOUExpenses")
            MsgBox("Updated Successfully...")
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [IGNOUExpenses]", MyConn)
            da.Fill(ds, "IGNOUExpenses")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
            MsgBox(ex.Message & "," & ex.Source)
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
End Class