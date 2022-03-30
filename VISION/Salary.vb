Imports ADOX
Imports System.Data.OleDb
Imports System.String
Public Class Salary
    Dim cw As Integer ' Forms current Width.
    Dim ch As Integer ' Forms current Height.
    Dim iw As Integer = 1015 ' Forms initial width.
    Dim ih As Integer = 633 ' Forms initial height.
    ' Retrieve the working rectangle from the Screen class using the        PrimaryScreen and the WorkingArea properties.  
    Dim workingRectangle As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea

    Dim DDA, HRA, FA, LTA, SA, ITAX, ESI, Salary, pf1, pf2 As Integer
    Dim TSalary As Integer
    Dim Earning As Integer
    Dim Deduction As Integer
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet

    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim dest As New BindingSource
    Dim SalMonth As Integer
    Dim daydate As String
    Dim monthdate As String
    Dim yeardate As String
    Dim space As String = "-"
    Dim result As String


    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForSalary()
        Me.CenterToScreen()
        Me.TopMost = True

        Me.Size = New System.Drawing.Size(workingRectangle.Width - 50, workingRectangle.Height - 200)
        ' Set the location so the entire form is visible. 
        Me.Location = New System.Drawing.Point(25, 100)




        fetchemployeedata()
    End Sub
    Private Sub fetchemployeedata()
        Try
            CurrentRow = 0
            'Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            'Dim Conn As New OleDb.OleDbConnection(ConStr)

            Con.Open()
            ' Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Dad = New OleDbDataAdapter("SELECT * FROM EmployeeDetail ORDER BY EmpId", Con)
            Dad.Fill(Dst, "EmployeeDetail")
            ShowData(CurrentRow)
            Con.Close()
        Catch ex As Exception
        End Try
    End Sub
Private Sub ShowData(ByVal CurrentRow)
    Try
            empno.Text = Dst.Tables("EmployeeDetail").Rows(CurrentRow)("EmpId")
            empname.Text = Dst.Tables("EmployeeDetail").Rows(CurrentRow)("Employee_Name")
            empdes.Text = Dst.Tables("EmployeeDetail").Rows(CurrentRow)("Designation")

            ' Next
        Catch ex As Exception
        End Try
    End Sub
  

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox13.Text = "" Or TextBox14.Text = "" Or TextBox15.Text = "" Then
            MsgBox(" Enter Date in DD   MM   YYYY")
            Exit Sub
        End If
        Label39.Text = DDA
        Label25.Text = pf1
        Label26.Text = pf2
        Label27.Text = HRA
        Label28.Text = FA
        Label29.Text = LTA
        Label30.Text = SA
        Label31.Text = ITAX
        Label32.Text = ESI
        Label10.Text = Earning
        Label11.Text = Deduction
        Label12.Text = TSalary
        Dim SalMonth As Integer = 0
        SalMonth = Convert.ToInt32(TextBox14.Text)



        'concat date


        daydate = TextBox13.Text.Trim()
        monthdate = TextBox14.Text.Trim()
        yeardate = TextBox15.Text.Trim()
        result = daydate + space + monthdate + space + yeardate



        Select Case SalMonth
            Case 1

                If CheckId() = False Then
                    MsgBox("Empployee Id : Integer Value Required !!!")
                    Exit Sub

                End If

                Try
                    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim sqlquery As String = "INSERT INTO JanSalary " & "(EmpNO,Employee_Name,Designation,Basic,CA,Medical,DA,P_F_Emp,P_F_Empr,HRA,FA,LTA,SA,ITax,ESIns,Earnings,Deductions,Net_Salary,Salary_Date) " & "VALUES (@EmpNO,@Employee_Name,@Designation,@Basic,@CA,@Medical,@DA,@P.F.Emp,@P.F.Empr,@HRA,@FA,@LTA,@SA,@ITax,@ESIns,@Earnings,@Deductions,@Net_Salary,@Salary_Date)"
                    ' Dim dateofsal As String

                    '  Dim ddt As String = " textbox13.text.trim()" + " textbox14.text.Trim()" + "textbox15.text.Trim()"
                    '  dateofsal = ddt.ToString
                    ' Use this form to initialize both connection and command to 
                    ' avoid forgetting to set the appropriate properties....

                    Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                        Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                            conn.Open()
                            cmd.Parameters.AddWithValue("@EmpNO", empno.Text.Trim())
                            cmd.Parameters.AddWithValue("@Employee_Name", empname.Text.Trim())
                            cmd.Parameters.AddWithValue("@Designation", empdes.Text.Trim())
                            cmd.Parameters.AddWithValue("@Basic", TextBox1.Text.Trim())
                            cmd.Parameters.AddWithValue("@CA", TextBox2.Text.Trim())
                            cmd.Parameters.AddWithValue("@Medical", TextBox3.Text.Trim())
                            cmd.Parameters.AddWithValue("@DA", Label39.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Emp", Label25.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Empr", Label26.Text.Trim())
                            cmd.Parameters.AddWithValue("@HRA", Label27.Text.Trim())
                            cmd.Parameters.AddWithValue("@FA", Label28.Text.Trim())
                            cmd.Parameters.AddWithValue("@LTA", Label29.Text.Trim())
                            cmd.Parameters.AddWithValue("@SA", Label30.Text.Trim())
                            cmd.Parameters.AddWithValue("@ITax", Label31.Text.Trim())
                            cmd.Parameters.AddWithValue("@ESIns", Label32.Text.Trim())
                            cmd.Parameters.AddWithValue("@Earnings", Label10.Text.Trim())
                            cmd.Parameters.AddWithValue("@Deductions", Label11.Text.Trim())
                            cmd.Parameters.AddWithValue("@Net_Salary", Label12.Text.Trim())
                            cmd.Parameters.AddWithValue("@Salary_Date", result)

                            Dim rowsInserted = cmd.ExecuteNonQuery()
                            If rowsInserted > 0 Then
                                MessageBox.Show("One record successfully added!", "Added!")
                                clearentry()
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
                                MessageBox.Show("Failure to add new record!", "Failure!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("You have Alreday Entered January Month Salary Detail for Given Employee ID: ")
                End Try

            Case 2
                If CheckId() = False Then
                    MsgBox("Empployee Id : Integer Value Required !!!")
                    Exit Sub

                End If

                Try
                    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim sqlquery As String = "INSERT INTO FebSalary " & "(EmpNO,Employee_Name,Designation,Basic,CA,Medical,DA,P_F_Emp,P_F_Empr,HRA,FA,LTA,SA,ITax,ESIns,Earnings,Deductions,Net_Salary,Salary_Date) " & "VALUES (@EmpNO,@Employee_Name,@Designation,@Basic,@CA,@Medical,@DA,@P.F.Emp,@P.F.Empr,@HRA,@FA,@LTA,@SA,@ITax,@ESIns,@Earnings,@Deductions,@Net_Salary,@Salary_Date)"
                    ' Dim dateofsal As String

                    '  Dim ddt As String = " textbox13.text.trim()" + " textbox14.text.Trim()" + "textbox15.text.Trim()"
                    '  dateofsal = ddt.ToString
                    ' Use this form to initialize both connection and command to 
                    ' avoid forgetting to set the appropriate properties....

                    Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                        Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                            conn.Open()
                            cmd.Parameters.AddWithValue("@EmpNO", empno.Text.Trim())
                            cmd.Parameters.AddWithValue("@Employee_Name", empname.Text.Trim())
                            cmd.Parameters.AddWithValue("@Designation", empdes.Text.Trim())
                            cmd.Parameters.AddWithValue("@Basic", TextBox1.Text.Trim())
                            cmd.Parameters.AddWithValue("@CA", TextBox2.Text.Trim())
                            cmd.Parameters.AddWithValue("@Medical", TextBox3.Text.Trim())
                            cmd.Parameters.AddWithValue("@DA", Label39.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Emp", Label25.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Empr", Label26.Text.Trim())
                            cmd.Parameters.AddWithValue("@HRA", Label27.Text.Trim())
                            cmd.Parameters.AddWithValue("@FA", Label28.Text.Trim())
                            cmd.Parameters.AddWithValue("@LTA", Label29.Text.Trim())
                            cmd.Parameters.AddWithValue("@SA", Label30.Text.Trim())
                            cmd.Parameters.AddWithValue("@ITax", Label31.Text.Trim())
                            cmd.Parameters.AddWithValue("@ESIns", Label32.Text.Trim())
                            cmd.Parameters.AddWithValue("@Earnings", Label10.Text.Trim())
                            cmd.Parameters.AddWithValue("@Deductions", Label11.Text.Trim())
                            cmd.Parameters.AddWithValue("@Net_Salary", Label12.Text.Trim())
                            cmd.Parameters.AddWithValue("@Salary_Date", result)

                            Dim rowsInserted = cmd.ExecuteNonQuery()
                            If rowsInserted > 0 Then
                                MessageBox.Show("One record successfully added!", "Added!")
                                clearentry()
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
                                MessageBox.Show("Failure to add new record!", "Failure!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("You have Alreday Entered Feburary Month Salary Detail for Given Employee ID: ")
                End Try
            Case 3
                If CheckId() = False Then
                    MsgBox("Empployee Id : Integer Value Required !!!")
                    Exit Sub

                End If

                Try
                    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim sqlquery As String = "INSERT INTO MarchSalary " & "(EmpNO,Employee_Name,Designation,Basic,CA,Medical,DA,P_F_Emp,P_F_Empr,HRA,FA,LTA,SA,ITax,ESIns,Earnings,Deductions,Net_Salary,Salary_Date) " & "VALUES (@EmpNO,@Employee_Name,@Designation,@Basic,@CA,@Medical,@DA,@P.F.Emp,@P.F.Empr,@HRA,@FA,@LTA,@SA,@ITax,@ESIns,@Earnings,@Deductions,@Net_Salary,@Salary_Date)"
                    ' Dim dateofsal As String

                    '  Dim ddt As String = " textbox13.text.trim()" + " textbox14.text.Trim()" + "textbox15.text.Trim()"
                    '  dateofsal = ddt.ToString
                    ' Use this form to initialize both connection and command to 
                    ' avoid forgetting to set the appropriate properties....

                    Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                        Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                            conn.Open()
                            cmd.Parameters.AddWithValue("@EmpNO", empno.Text.Trim())
                            cmd.Parameters.AddWithValue("@Employee_Name", empname.Text.Trim())
                            cmd.Parameters.AddWithValue("@Designation", empdes.Text.Trim())
                            cmd.Parameters.AddWithValue("@Basic", TextBox1.Text.Trim())
                            cmd.Parameters.AddWithValue("@CA", TextBox2.Text.Trim())
                            cmd.Parameters.AddWithValue("@Medical", TextBox3.Text.Trim())
                            cmd.Parameters.AddWithValue("@DA", Label39.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Emp", Label25.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Empr", Label26.Text.Trim())
                            cmd.Parameters.AddWithValue("@HRA", Label27.Text.Trim())
                            cmd.Parameters.AddWithValue("@FA", Label28.Text.Trim())
                            cmd.Parameters.AddWithValue("@LTA", Label29.Text.Trim())
                            cmd.Parameters.AddWithValue("@SA", Label30.Text.Trim())
                            cmd.Parameters.AddWithValue("@ITax", Label31.Text.Trim())
                            cmd.Parameters.AddWithValue("@ESIns", Label32.Text.Trim())
                            cmd.Parameters.AddWithValue("@Earnings", Label10.Text.Trim())
                            cmd.Parameters.AddWithValue("@Deductions", Label11.Text.Trim())
                            cmd.Parameters.AddWithValue("@Net_Salary", Label12.Text.Trim())
                            cmd.Parameters.AddWithValue("@Salary_Date", result)

                            Dim rowsInserted = cmd.ExecuteNonQuery()
                            If rowsInserted > 0 Then
                                MessageBox.Show("One record successfully added!", "Added!")
                                clearentry()
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
                                MessageBox.Show("Failure to add new record!", "Failure!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("You have Alreday Entered March Month Salary Detail for Given Employee ID: ")
                End Try
            Case 4
                If CheckId() = False Then
                    MsgBox("Empployee Id : Integer Value Required !!!")
                    Exit Sub

                End If

                Try
                    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim sqlquery As String = "INSERT INTO AprilSalary " & "(EmpNO,Employee_Name,Designation,Basic,CA,Medical,DA,P_F_Emp,P_F_Empr,HRA,FA,LTA,SA,ITax,ESIns,Earnings,Deductions,Net_Salary,Salary_Date) " & "VALUES (@EmpNO,@Employee_Name,@Designation,@Basic,@CA,@Medical,@DA,@P.F.Emp,@P.F.Empr,@HRA,@FA,@LTA,@SA,@ITax,@ESIns,@Earnings,@Deductions,@Net_Salary,@Salary_Date)"
                    ' Dim dateofsal As String

                    '  Dim ddt As String = " textbox13.text.trim()" + " textbox14.text.Trim()" + "textbox15.text.Trim()"
                    '  dateofsal = ddt.ToString
                    ' Use this form to initialize both connection and command to 
                    ' avoid forgetting to set the appropriate properties....

                    Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                        Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                            conn.Open()
                            cmd.Parameters.AddWithValue("@EmpNO", empno.Text.Trim())
                            cmd.Parameters.AddWithValue("@Employee_Name", empname.Text.Trim())
                            cmd.Parameters.AddWithValue("@Designation", empdes.Text.Trim())
                            cmd.Parameters.AddWithValue("@Basic", TextBox1.Text.Trim())
                            cmd.Parameters.AddWithValue("@CA", TextBox2.Text.Trim())
                            cmd.Parameters.AddWithValue("@Medical", TextBox3.Text.Trim())
                            cmd.Parameters.AddWithValue("@DA", Label39.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Emp", Label25.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Empr", Label26.Text.Trim())
                            cmd.Parameters.AddWithValue("@HRA", Label27.Text.Trim())
                            cmd.Parameters.AddWithValue("@FA", Label28.Text.Trim())
                            cmd.Parameters.AddWithValue("@LTA", Label29.Text.Trim())
                            cmd.Parameters.AddWithValue("@SA", Label30.Text.Trim())
                            cmd.Parameters.AddWithValue("@ITax", Label31.Text.Trim())
                            cmd.Parameters.AddWithValue("@ESIns", Label32.Text.Trim())
                            cmd.Parameters.AddWithValue("@Earnings", Label10.Text.Trim())
                            cmd.Parameters.AddWithValue("@Deductions", Label11.Text.Trim())
                            cmd.Parameters.AddWithValue("@Net_Salary", Label12.Text.Trim())
                            cmd.Parameters.AddWithValue("@Salary_Date", result)

                            Dim rowsInserted = cmd.ExecuteNonQuery()
                            If rowsInserted > 0 Then
                                MessageBox.Show("One record successfully added!", "Added!")
                                clearentry()
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
                                MessageBox.Show("Failure to add new record!", "Failure!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("You have Alreday Entered April Month Salary Detail for Given Employee ID: ")
                End Try
            Case 5
                If CheckId() = False Then
                    MsgBox("Empployee Id : Integer Value Required !!!")
                    Exit Sub

                End If

                Try
                    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim sqlquery As String = "INSERT INTO MaySalary " & "(EmpNO,Employee_Name,Designation,Basic,CA,Medical,DA,P_F_Emp,P_F_Empr,HRA,FA,LTA,SA,ITax,ESIns,Earnings,Deductions,Net_Salary,Salary_Date) " & "VALUES (@EmpNO,@Employee_Name,@Designation,@Basic,@CA,@Medical,@DA,@P.F.Emp,@P.F.Empr,@HRA,@FA,@LTA,@SA,@ITax,@ESIns,@Earnings,@Deductions,@Net_Salary,@Salary_Date)"
                    ' Dim dateofsal As String

                    '  Dim ddt As String = " textbox13.text.trim()" + " textbox14.text.Trim()" + "textbox15.text.Trim()"
                    '  dateofsal = ddt.ToString
                    ' Use this form to initialize both connection and command to 
                    ' avoid forgetting to set the appropriate properties....

                    Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                        Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                            conn.Open()
                            cmd.Parameters.AddWithValue("@EmpNO", empno.Text.Trim())
                            cmd.Parameters.AddWithValue("@Employee_Name", empname.Text.Trim())
                            cmd.Parameters.AddWithValue("@Designation", empdes.Text.Trim())
                            cmd.Parameters.AddWithValue("@Basic", TextBox1.Text.Trim())
                            cmd.Parameters.AddWithValue("@CA", TextBox2.Text.Trim())
                            cmd.Parameters.AddWithValue("@Medical", TextBox3.Text.Trim())
                            cmd.Parameters.AddWithValue("@DA", Label39.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Emp", Label25.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Empr", Label26.Text.Trim())
                            cmd.Parameters.AddWithValue("@HRA", Label27.Text.Trim())
                            cmd.Parameters.AddWithValue("@FA", Label28.Text.Trim())
                            cmd.Parameters.AddWithValue("@LTA", Label29.Text.Trim())
                            cmd.Parameters.AddWithValue("@SA", Label30.Text.Trim())
                            cmd.Parameters.AddWithValue("@ITax", Label31.Text.Trim())
                            cmd.Parameters.AddWithValue("@ESIns", Label32.Text.Trim())
                            cmd.Parameters.AddWithValue("@Earnings", Label10.Text.Trim())
                            cmd.Parameters.AddWithValue("@Deductions", Label11.Text.Trim())
                            cmd.Parameters.AddWithValue("@Net_Salary", Label12.Text.Trim())
                            cmd.Parameters.AddWithValue("@Salary_Date", result)

                            Dim rowsInserted = cmd.ExecuteNonQuery()
                            If rowsInserted > 0 Then
                                MessageBox.Show("One record successfully added!", "Added!")
                                clearentry()
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
                                MessageBox.Show("Failure to add new record!", "Failure!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("You have Alreday Entered May Month Salary Detail for Given Employee ID: ")
                End Try
            Case 6
                If CheckId() = False Then
                    MsgBox("Empployee Id : Integer Value Required !!!")
                    Exit Sub

                End If

                Try
                    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim sqlquery As String = "INSERT INTO JuneSalary " & "(EmpNO,Employee_Name,Designation,Basic,CA,Medical,DA,P_F_Emp,P_F_Empr,HRA,FA,LTA,SA,ITax,ESIns,Earnings,Deductions,Net_Salary,Salary_Date) " & "VALUES (@EmpNO,@Employee_Name,@Designation,@Basic,@CA,@Medical,@DA,@P.F.Emp,@P.F.Empr,@HRA,@FA,@LTA,@SA,@ITax,@ESIns,@Earnings,@Deductions,@Net_Salary,@Salary_Date)"
                    ' Dim dateofsal As String

                    '  Dim ddt As String = " textbox13.text.trim()" + " textbox14.text.Trim()" + "textbox15.text.Trim()"
                    '  dateofsal = ddt.ToString
                    ' Use this form to initialize both connection and command to 
                    ' avoid forgetting to set the appropriate properties....

                    Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                        Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                            conn.Open()
                            cmd.Parameters.AddWithValue("@EmpNO", empno.Text.Trim())
                            cmd.Parameters.AddWithValue("@Employee_Name", empname.Text.Trim())
                            cmd.Parameters.AddWithValue("@Designation", empdes.Text.Trim())
                            cmd.Parameters.AddWithValue("@Basic", TextBox1.Text.Trim())
                            cmd.Parameters.AddWithValue("@CA", TextBox2.Text.Trim())
                            cmd.Parameters.AddWithValue("@Medical", TextBox3.Text.Trim())
                            cmd.Parameters.AddWithValue("@DA", Label39.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Emp", Label25.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Empr", Label26.Text.Trim())
                            cmd.Parameters.AddWithValue("@HRA", Label27.Text.Trim())
                            cmd.Parameters.AddWithValue("@FA", Label28.Text.Trim())
                            cmd.Parameters.AddWithValue("@LTA", Label29.Text.Trim())
                            cmd.Parameters.AddWithValue("@SA", Label30.Text.Trim())
                            cmd.Parameters.AddWithValue("@ITax", Label31.Text.Trim())
                            cmd.Parameters.AddWithValue("@ESIns", Label32.Text.Trim())
                            cmd.Parameters.AddWithValue("@Earnings", Label10.Text.Trim())
                            cmd.Parameters.AddWithValue("@Deductions", Label11.Text.Trim())
                            cmd.Parameters.AddWithValue("@Net_Salary", Label12.Text.Trim())
                            cmd.Parameters.AddWithValue("@Salary_Date", result)

                            Dim rowsInserted = cmd.ExecuteNonQuery()
                            If rowsInserted > 0 Then
                                MessageBox.Show("One record successfully added!", "Added!")
                                clearentry()
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
                                MessageBox.Show("Failure to add new record!", "Failure!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("You have Alreday Entered June Month Salary Detail for Given Employee ID: ")
                End Try
            Case 7
                If CheckId() = False Then
                    MsgBox("Empployee Id : Integer Value Required !!!")
                    Exit Sub

                End If

                Try
                    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim sqlquery As String = "INSERT INTO JulySalary " & "(EmpNO,Employee_Name,Designation,Basic,CA,Medical,DA,P_F_Emp,P_F_Empr,HRA,FA,LTA,SA,ITax,ESIns,Earnings,Deductions,Net_Salary,Salary_Date) " & "VALUES (@EmpNO,@Employee_Name,@Designation,@Basic,@CA,@Medical,@DA,@P.F.Emp,@P.F.Empr,@HRA,@FA,@LTA,@SA,@ITax,@ESIns,@Earnings,@Deductions,@Net_Salary,@Salary_Date)"
                    ' Dim dateofsal As String

                    '  Dim ddt As String = " textbox13.text.trim()" + " textbox14.text.Trim()" + "textbox15.text.Trim()"
                    '  dateofsal = ddt.ToString
                    ' Use this form to initialize both connection and command to 
                    ' avoid forgetting to set the appropriate properties....

                    Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                        Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                            conn.Open()
                            cmd.Parameters.AddWithValue("@EmpNO", empno.Text.Trim())
                            cmd.Parameters.AddWithValue("@Employee_Name", empname.Text.Trim())
                            cmd.Parameters.AddWithValue("@Designation", empdes.Text.Trim())
                            cmd.Parameters.AddWithValue("@Basic", TextBox1.Text.Trim())
                            cmd.Parameters.AddWithValue("@CA", TextBox2.Text.Trim())
                            cmd.Parameters.AddWithValue("@Medical", TextBox3.Text.Trim())
                            cmd.Parameters.AddWithValue("@DA", Label39.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Emp", Label25.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Empr", Label26.Text.Trim())
                            cmd.Parameters.AddWithValue("@HRA", Label27.Text.Trim())
                            cmd.Parameters.AddWithValue("@FA", Label28.Text.Trim())
                            cmd.Parameters.AddWithValue("@LTA", Label29.Text.Trim())
                            cmd.Parameters.AddWithValue("@SA", Label30.Text.Trim())
                            cmd.Parameters.AddWithValue("@ITax", Label31.Text.Trim())
                            cmd.Parameters.AddWithValue("@ESIns", Label32.Text.Trim())
                            cmd.Parameters.AddWithValue("@Earnings", Label10.Text.Trim())
                            cmd.Parameters.AddWithValue("@Deductions", Label11.Text.Trim())
                            cmd.Parameters.AddWithValue("@Net_Salary", Label12.Text.Trim())
                            cmd.Parameters.AddWithValue("@Salary_Date", result)

                            Dim rowsInserted = cmd.ExecuteNonQuery()
                            If rowsInserted > 0 Then
                                MessageBox.Show("One record successfully added!", "Added!")
                                clearentry()
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
                                MessageBox.Show("Failure to add new record!", "Failure!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("You have Alreday Entered July Month Salary Detail for Given Employee ID: ")
                End Try
            Case 8
                If CheckId() = False Then
                    MsgBox("Empployee Id : Integer Value Required !!!")
                    Exit Sub

                End If

                Try
                    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim sqlquery As String = "INSERT INTO AugSalary " & "(EmpNO,Employee_Name,Designation,Basic,CA,Medical,DA,P_F_Emp,P_F_Empr,HRA,FA,LTA,SA,ITax,ESIns,Earnings,Deductions,Net_Salary,Salary_Date) " & "VALUES (@EmpNO,@Employee_Name,@Designation,@Basic,@CA,@Medical,@DA,@P.F.Emp,@P.F.Empr,@HRA,@FA,@LTA,@SA,@ITax,@ESIns,@Earnings,@Deductions,@Net_Salary,@Salary_Date)"
                    ' Dim dateofsal As String

                    '  Dim ddt As String = " textbox13.text.trim()" + " textbox14.text.Trim()" + "textbox15.text.Trim()"
                    '  dateofsal = ddt.ToString
                    ' Use this form to initialize both connection and command to 
                    ' avoid forgetting to set the appropriate properties....

                    Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                        Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                            conn.Open()
                            cmd.Parameters.AddWithValue("@EmpNO", empno.Text.Trim())
                            cmd.Parameters.AddWithValue("@Employee_Name", empname.Text.Trim())
                            cmd.Parameters.AddWithValue("@Designation", empdes.Text.Trim())
                            cmd.Parameters.AddWithValue("@Basic", TextBox1.Text.Trim())
                            cmd.Parameters.AddWithValue("@CA", TextBox2.Text.Trim())
                            cmd.Parameters.AddWithValue("@Medical", TextBox3.Text.Trim())
                            cmd.Parameters.AddWithValue("@DA", Label39.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Emp", Label25.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Empr", Label26.Text.Trim())
                            cmd.Parameters.AddWithValue("@HRA", Label27.Text.Trim())
                            cmd.Parameters.AddWithValue("@FA", Label28.Text.Trim())
                            cmd.Parameters.AddWithValue("@LTA", Label29.Text.Trim())
                            cmd.Parameters.AddWithValue("@SA", Label30.Text.Trim())
                            cmd.Parameters.AddWithValue("@ITax", Label31.Text.Trim())
                            cmd.Parameters.AddWithValue("@ESIns", Label32.Text.Trim())
                            cmd.Parameters.AddWithValue("@Earnings", Label10.Text.Trim())
                            cmd.Parameters.AddWithValue("@Deductions", Label11.Text.Trim())
                            cmd.Parameters.AddWithValue("@Net_Salary", Label12.Text.Trim())
                            cmd.Parameters.AddWithValue("@Salary_Date", result)

                            Dim rowsInserted = cmd.ExecuteNonQuery()
                            If rowsInserted > 0 Then
                                MessageBox.Show("One record successfully added!", "Added!")
                                clearentry()
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
                                MessageBox.Show("Failure to add new record!", "Failure!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("You have Alreday Entered August Month Salary Detail for Given Employee ID: ")
                End Try
            Case 9
                If CheckId() = False Then
                    MsgBox("Empployee Id : Integer Value Required !!!")
                    Exit Sub

                End If

                Try
                    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim sqlquery As String = "INSERT INTO SeptSalary " & "(EmpNO,Employee_Name,Designation,Basic,CA,Medical,DA,P_F_Emp,P_F_Empr,HRA,FA,LTA,SA,ITax,ESIns,Earnings,Deductions,Net_Salary,Salary_Date) " & "VALUES (@EmpNO,@Employee_Name,@Designation,@Basic,@CA,@Medical,@DA,@P.F.Emp,@P.F.Empr,@HRA,@FA,@LTA,@SA,@ITax,@ESIns,@Earnings,@Deductions,@Net_Salary,@Salary_Date)"
                    ' Dim dateofsal As String

                    '  Dim ddt As String = " textbox13.text.trim()" + " textbox14.text.Trim()" + "textbox15.text.Trim()"
                    '  dateofsal = ddt.ToString
                    ' Use this form to initialize both connection and command to 
                    ' avoid forgetting to set the appropriate properties....

                    Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                        Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                            conn.Open()
                            cmd.Parameters.AddWithValue("@EmpNO", empno.Text.Trim())
                            cmd.Parameters.AddWithValue("@Employee_Name", empname.Text.Trim())
                            cmd.Parameters.AddWithValue("@Designation", empdes.Text.Trim())
                            cmd.Parameters.AddWithValue("@Basic", TextBox1.Text.Trim())
                            cmd.Parameters.AddWithValue("@CA", TextBox2.Text.Trim())
                            cmd.Parameters.AddWithValue("@Medical", TextBox3.Text.Trim())
                            cmd.Parameters.AddWithValue("@DA", Label39.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Emp", Label25.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Empr", Label26.Text.Trim())
                            cmd.Parameters.AddWithValue("@HRA", Label27.Text.Trim())
                            cmd.Parameters.AddWithValue("@FA", Label28.Text.Trim())
                            cmd.Parameters.AddWithValue("@LTA", Label29.Text.Trim())
                            cmd.Parameters.AddWithValue("@SA", Label30.Text.Trim())
                            cmd.Parameters.AddWithValue("@ITax", Label31.Text.Trim())
                            cmd.Parameters.AddWithValue("@ESIns", Label32.Text.Trim())
                            cmd.Parameters.AddWithValue("@Earnings", Label10.Text.Trim())
                            cmd.Parameters.AddWithValue("@Deductions", Label11.Text.Trim())
                            cmd.Parameters.AddWithValue("@Net_Salary", Label12.Text.Trim())
                            cmd.Parameters.AddWithValue("@Salary_Date", result)

                            Dim rowsInserted = cmd.ExecuteNonQuery()
                            If rowsInserted > 0 Then
                                MessageBox.Show("One record successfully added!", "Added!")
                                clearentry()
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
                                MessageBox.Show("Failure to add new record!", "Failure!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("You have Alreday Entered September Month Salary Detail for Given Employee ID: ")
                End Try
            Case 10
                If CheckId() = False Then
                    MsgBox("Empployee Id : Integer Value Required !!!")
                    Exit Sub

                End If

                Try
                    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim sqlquery As String = "INSERT INTO OctSalary " & "(EmpNO,Employee_Name,Designation,Basic,CA,Medical,DA,P_F_Emp,P_F_Empr,HRA,FA,LTA,SA,ITax,ESIns,Earnings,Deductions,Net_Salary,Salary_Date) " & "VALUES (@EmpNO,@Employee_Name,@Designation,@Basic,@CA,@Medical,@DA,@P.F.Emp,@P.F.Empr,@HRA,@FA,@LTA,@SA,@ITax,@ESIns,@Earnings,@Deductions,@Net_Salary,@Salary_Date)"
                    ' Dim dateofsal As String

                    '  Dim ddt As String = " textbox13.text.trim()" + " textbox14.text.Trim()" + "textbox15.text.Trim()"
                    '  dateofsal = ddt.ToString
                    ' Use this form to initialize both connection and command to 
                    ' avoid forgetting to set the appropriate properties....

                    Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                        Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                            conn.Open()
                            cmd.Parameters.AddWithValue("@EmpNO", empno.Text.Trim())
                            cmd.Parameters.AddWithValue("@Employee_Name", empname.Text.Trim())
                            cmd.Parameters.AddWithValue("@Designation", empdes.Text.Trim())
                            cmd.Parameters.AddWithValue("@Basic", TextBox1.Text.Trim())
                            cmd.Parameters.AddWithValue("@CA", TextBox2.Text.Trim())
                            cmd.Parameters.AddWithValue("@Medical", TextBox3.Text.Trim())
                            cmd.Parameters.AddWithValue("@DA", Label39.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Emp", Label25.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Empr", Label26.Text.Trim())
                            cmd.Parameters.AddWithValue("@HRA", Label27.Text.Trim())
                            cmd.Parameters.AddWithValue("@FA", Label28.Text.Trim())
                            cmd.Parameters.AddWithValue("@LTA", Label29.Text.Trim())
                            cmd.Parameters.AddWithValue("@SA", Label30.Text.Trim())
                            cmd.Parameters.AddWithValue("@ITax", Label31.Text.Trim())
                            cmd.Parameters.AddWithValue("@ESIns", Label32.Text.Trim())
                            cmd.Parameters.AddWithValue("@Earnings", Label10.Text.Trim())
                            cmd.Parameters.AddWithValue("@Deductions", Label11.Text.Trim())
                            cmd.Parameters.AddWithValue("@Net_Salary", Label12.Text.Trim())
                            cmd.Parameters.AddWithValue("@Salary_Date", result)

                            Dim rowsInserted = cmd.ExecuteNonQuery()
                            If rowsInserted > 0 Then
                                MessageBox.Show("One record successfully added!", "Added!")
                                clearentry()
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
                                MessageBox.Show("Failure to add new record!", "Failure!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("You have Alreday Entered Octover Month Salary Detail for Given Employee ID: ")
                End Try
            Case 11
                If CheckId() = False Then
                    MsgBox("Empployee Id : Integer Value Required !!!")
                    Exit Sub

                End If

                Try
                    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim sqlquery As String = "INSERT INTO NovSalary " & "(EmpNO,Employee_Name,Designation,Basic,CA,Medical,DA,P_F_Emp,P_F_Empr,HRA,FA,LTA,SA,ITax,ESIns,Earnings,Deductions,Net_Salary,Salary_Date) " & "VALUES (@EmpNO,@Employee_Name,@Designation,@Basic,@CA,@Medical,@DA,@P.F.Emp,@P.F.Empr,@HRA,@FA,@LTA,@SA,@ITax,@ESIns,@Earnings,@Deductions,@Net_Salary,@Salary_Date)"
                    ' Dim dateofsal As String

                    '  Dim ddt As String = " textbox13.text.trim()" + " textbox14.text.Trim()" + "textbox15.text.Trim()"
                    '  dateofsal = ddt.ToString
                    ' Use this form to initialize both connection and command to 
                    ' avoid forgetting to set the appropriate properties....

                    Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                        Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                            conn.Open()
                            cmd.Parameters.AddWithValue("@EmpNO", empno.Text.Trim())
                            cmd.Parameters.AddWithValue("@Employee_Name", empname.Text.Trim())
                            cmd.Parameters.AddWithValue("@Designation", empdes.Text.Trim())
                            cmd.Parameters.AddWithValue("@Basic", TextBox1.Text.Trim())
                            cmd.Parameters.AddWithValue("@CA", TextBox2.Text.Trim())
                            cmd.Parameters.AddWithValue("@Medical", TextBox3.Text.Trim())
                            cmd.Parameters.AddWithValue("@DA", Label39.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Emp", Label25.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Empr", Label26.Text.Trim())
                            cmd.Parameters.AddWithValue("@HRA", Label27.Text.Trim())
                            cmd.Parameters.AddWithValue("@FA", Label28.Text.Trim())
                            cmd.Parameters.AddWithValue("@LTA", Label29.Text.Trim())
                            cmd.Parameters.AddWithValue("@SA", Label30.Text.Trim())
                            cmd.Parameters.AddWithValue("@ITax", Label31.Text.Trim())
                            cmd.Parameters.AddWithValue("@ESIns", Label32.Text.Trim())
                            cmd.Parameters.AddWithValue("@Earnings", Label10.Text.Trim())
                            cmd.Parameters.AddWithValue("@Deductions", Label11.Text.Trim())
                            cmd.Parameters.AddWithValue("@Net_Salary", Label12.Text.Trim())
                            cmd.Parameters.AddWithValue("@Salary_Date", result)

                            Dim rowsInserted = cmd.ExecuteNonQuery()
                            If rowsInserted > 0 Then
                                MessageBox.Show("One record successfully added!", "Added!")
                                clearentry()
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
                                MessageBox.Show("Failure to add new record!", "Failure!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("You have Alreday Entered November Month Salary Detail for Given Employee ID: ")
                End Try
            Case 12
                If CheckId() = False Then
                    MsgBox("Empployee Id : Integer Value Required !!!")
                    Exit Sub

                End If

                Try
                    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim sqlquery As String = "INSERT INTO DecSalary " & "(EmpNO,Employee_Name,Designation,Basic,CA,Medical,DA,P_F_Emp,P_F_Empr,HRA,FA,LTA,SA,ITax,ESIns,Earnings,Deductions,Net_Salary,Salary_Date) " & "VALUES (@EmpNO,@Employee_Name,@Designation,@Basic,@CA,@Medical,@DA,@P.F.Emp,@P.F.Empr,@HRA,@FA,@LTA,@SA,@ITax,@ESIns,@Earnings,@Deductions,@Net_Salary,@Salary_Date)"
                    ' Dim dateofsal As String

                    '  Dim ddt As String = " textbox13.text.trim()" + " textbox14.text.Trim()" + "textbox15.text.Trim()"
                    '  dateofsal = ddt.ToString
                    ' Use this form to initialize both connection and command to 
                    ' avoid forgetting to set the appropriate properties....

                    Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                        Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, conn)

                            conn.Open()
                            cmd.Parameters.AddWithValue("@EmpNO", empno.Text.Trim())
                            cmd.Parameters.AddWithValue("@Employee_Name", empname.Text.Trim())
                            cmd.Parameters.AddWithValue("@Designation", empdes.Text.Trim())
                            cmd.Parameters.AddWithValue("@Basic", TextBox1.Text.Trim())
                            cmd.Parameters.AddWithValue("@CA", TextBox2.Text.Trim())
                            cmd.Parameters.AddWithValue("@Medical", TextBox3.Text.Trim())
                            cmd.Parameters.AddWithValue("@DA", Label39.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Emp", Label25.Text.Trim())
                            cmd.Parameters.AddWithValue("@P_F_Empr", Label26.Text.Trim())
                            cmd.Parameters.AddWithValue("@HRA", Label27.Text.Trim())
                            cmd.Parameters.AddWithValue("@FA", Label28.Text.Trim())
                            cmd.Parameters.AddWithValue("@LTA", Label29.Text.Trim())
                            cmd.Parameters.AddWithValue("@SA", Label30.Text.Trim())
                            cmd.Parameters.AddWithValue("@ITax", Label31.Text.Trim())
                            cmd.Parameters.AddWithValue("@ESIns", Label32.Text.Trim())
                            cmd.Parameters.AddWithValue("@Earnings", Label10.Text.Trim())
                            cmd.Parameters.AddWithValue("@Deductions", Label11.Text.Trim())
                            cmd.Parameters.AddWithValue("@Net_Salary", Label12.Text.Trim())
                            cmd.Parameters.AddWithValue("@Salary_Date", result)

                            Dim rowsInserted = cmd.ExecuteNonQuery()
                            If rowsInserted > 0 Then
                                MessageBox.Show("One record successfully added!", "Added!")
                                clearentry()
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
                                MessageBox.Show("Failure to add new record!", "Failure!")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("You have Alreday Entered December Month Salary Detail for Given Employee ID: ")
                End Try
            Case Else
                MsgBox("Enter Correct Month")
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            ' salary text
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Then
                Exit Sub
            Else
                Dim Salary As Integer = Convert.ToInt32(TextBox1.Text)
                Dim CA As Integer = Convert.ToInt32(TextBox2.Text)
                Dim Medical As Integer = Convert.ToInt32(TextBox3.Text)

                ' allowance 

                Dim DA1 As Integer = Convert.ToInt32(TextBox4.Text.Trim())
                Dim pf1cl As Integer = Convert.ToInt32(TextBox5.Text.Trim())
                Dim pf2cl As Integer = Convert.ToInt32(TextBox6.Text.Trim())
                Dim HRAcl As Integer = Convert.ToInt32(TextBox7.Text.Trim())
                Dim FAcl As Integer = Convert.ToInt32(TextBox8.Text.Trim())
                Dim LTAcl As Integer = Convert.ToInt32(TextBox9.Text.Trim())
                Dim SAcl As Integer = Convert.ToInt32(TextBox10.Text.Trim())
                Dim Itaxcl As Integer = Convert.ToInt32(TextBox11.Text.Trim())
                Dim ESIcl As Integer = Convert.ToInt32(TextBox12.Text.Trim())
                DDA = (Salary * DA1) / 100
                pf1 = (Salary * pf1cl) / 100
                pf2 = (Salary * pf2cl) / 100
                HRA = (Salary * HRAcl) / 100
                FA = (Salary * FAcl) / 100
                LTA = (Salary * LTAcl) / 100
                SA = (Salary * SAcl) / 100
                ITAX = (Salary * Itaxcl) / 100
                ESI = (Salary * ESIcl) / 100
                ' earnings 

                Earning = (Salary + CA + Medical + DDA + HRA + FA + LTA)
                ' deductions 

                Deduction = (pf1 + pf2 + ITAX + ESI + SA)
                ' net income 
                TSalary = (Earning - Deduction)
                Label39.Text = DDA.ToString("Rs:######")
                Label25.Text = pf1.ToString("Rs:######")
                Label26.Text = pf2.ToString("Rs:######")
                Label27.Text = HRA.ToString("Rs:######")
                Label28.Text = FA.ToString("Rs:######")
                Label29.Text = LTA.ToString("Rs:######")
                Label30.Text = SA.ToString("Rs:######")
                Label31.Text = ITAX.ToString("Rs:######")
                Label32.Text = ESI.ToString("Rs:######")
                Label10.Text = Earning.ToString("Rs:###########.00")
                Label11.Text = Deduction.ToString("Rs:###########.00")
                Label12.Text = TSalary.ToString("Rs:###########.00")
                Label36.Text = Salary.ToString("Rs:######")
                Label37.Text = CA.ToString("Rs:######")
                Label38.Text = Medical.ToString("Rs:######")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If CurrentRow = Dst.Tables("EmployeeDetail").Rows.Count - 1 Then
            MsgBox("Last Record is Reached!!!")
        Else
            CurrentRow += 1
            ShowData(CurrentRow)
        End If
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
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        Label25.Text = ""
        Label26.Text = ""
        Label27.Text = ""
        Label28.Text = ""
        Label29.Text = ""
        Label30.Text = ""
        Label31.Text = ""
        Label32.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label12.Text = ""
        Label36.Text = ""
        Label37.Text = ""
        Label38.Text = ""
        Label39.Text = ""
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
    End Sub
    Private Function CheckId()
        Try
            If IsNumeric(empno.Text) = False Then
                ShowData(CurrentRow)
                Label17.Focus()
                Return False
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.TopMost = False
        Dim StatusDate As String
        StatusDate = InputBox("Enter Month No. (1 to 12 )Which You  want to Display ?", "Enter Month", "  ")
        SalMonth = Convert.ToInt32(StatusDate)
        If StatusDate = " " Then
            MessageBox.Show("You must enter a Month Number to continue.")
            Exit Sub
        End If
        Me.TopMost = True
        Select Case SalMonth
            Case 1

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

            Case 2

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

            Case 3

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

            Case 4

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
            Case 5

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

            Case 6

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

            Case 7

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

            Case 8

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

            Case 9

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

            Case 10

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

            Case 11


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

            Case 12

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
            Case Else
                MsgBox("Enter Correct Month")
        End Select
    End Sub
    Private Sub clearentry()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        Label25.Text = ""
        Label26.Text = ""
        Label27.Text = ""
        Label28.Text = ""
        Label29.Text = ""
        Label30.Text = ""
        Label31.Text = ""
        Label32.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label12.Text = ""
        Label36.Text = ""
        Label37.Text = ""
        Label38.Text = ""
        Label39.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Edit_Salary.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If DataGridView1.RowCount > 1 Then
            Dim tamount As Decimal = 0

            For index As Integer = 0 To DataGridView1.RowCount - 1
                tamount += Convert.ToInt32(DataGridView1.Rows(index).Cells(17).Value)

            Next

            tamount = Math.Max(tamount, 2) '2 is number of decimal places
            Label164.Text = tamount.ToString("Rs:#########.00")
        Else
            MsgBox(" NO Record Exits !!!!")
        End If
    End Sub
    Private Function JanSalaryData() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM JanSalary", connection)
        Dim ds As New DataSet
        da.Fill(ds, "JanSalary")
        connection.Dispose()
        connection = Nothing
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("do somethis ")
            Else
                MsgBox(" Record Does Not Not Exist !!!!")
            End If
        End If

        Return ds
    End Function
    Private Function FebSalaryData() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT EmpNO FROM [FebSalary] WHERE EmpNO = '" & empno.Text & "';", connection)
        Dim ds As New DataSet
        da.Fill(ds, "FilteredDesc")
        connection.Dispose()
        connection = Nothing
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM FebSalary ", Con)
                Con.Open()
                Dim tot1 As Int32 = cmd.ExecuteNonQuery

                Label164.Text = tot1.ToString("Rs:##############.00")
                Con.Close()
            Else
                MsgBox(" Record Does Not Not Exist !!!!")
            End If
        End If

        Return ds
    End Function
    Private Function MarchSalaryData() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT EmpNO FROM [MarchSalary] WHERE EmpNO = '" & empno.Text & "';", connection)
        Dim ds As New DataSet
        da.Fill(ds, "FilteredDesc")
        connection.Dispose()
        connection = Nothing
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM MarchSalary ", Con)
                Con.Open()
                Dim tot1 As Int32 = cmd.ExecuteNonQuery

                Label164.Text = tot1.ToString("Rs:##############.00")
                Con.Close()
            Else
                MsgBox(" Record Does Not Not Exist !!!!")
            End If
        End If

        Return ds
    End Function
    Private Function AprilSalaryData() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT EmpNO FROM [AprilSalary] WHERE EmpNO = '" & empno.Text & "';", connection)
        Dim ds As New DataSet
        da.Fill(ds, "FilteredDesc")
        connection.Dispose()
        connection = Nothing
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM AprilSalary ", Con)
                Con.Open()
                Dim tot1 As Int32 = cmd.ExecuteNonQuery

                Label164.Text = tot1.ToString("Rs:##############.00")
                Con.Close()
            Else
                MsgBox(" Record Does Not Not Exist !!!!")
            End If
        End If

        Return ds
    End Function
    Private Function MaySalaryData() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT EmpNO FROM [MaySalary] WHERE EmpNO = '" & empno.Text & "';", connection)
        Dim ds As New DataSet
        da.Fill(ds, "FilteredDesc")
        connection.Dispose()
        connection = Nothing
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM MaySalary ", Con)
                Con.Open()
                Dim tot1 As Int32 = cmd.ExecuteNonQuery

                Label164.Text = tot1.ToString("Rs:##############.00")
                Con.Close()
            Else
                MsgBox(" Record Does Not Not Exist !!!!")
            End If
        End If

        Return ds
    End Function
    Private Function JuneSalaryData() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT EmpNO FROM [JuneSalary] WHERE EmpNO = '" & empno.Text & "';", connection)
        Dim ds As New DataSet
        da.Fill(ds, "FilteredDesc")
        connection.Dispose()
        connection = Nothing
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM JuneSalary ", Con)
                Con.Open()
                Dim tot1 As Int32 = cmd.ExecuteNonQuery

                Label164.Text = tot1.ToString("Rs:##############.00")
                Con.Close()
            Else
                MsgBox(" Record Does Not Not Exist !!!!")
            End If
        End If

        Return ds
    End Function
    Private Function JulySalaryData() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT EmpNO FROM [JulySalary] WHERE EmpNO = '" & empno.Text & "';", connection)
        Dim ds As New DataSet
        da.Fill(ds, "FilteredDesc")
        connection.Dispose()
        connection = Nothing
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM JulySalary ", Con)
                Con.Open()
                Dim tot1 As Int32 = cmd.ExecuteNonQuery

                Label164.Text = tot1.ToString("Rs:##############.00")
                Con.Close()
            Else
                MsgBox(" Record Does Not Not Exist !!!!")
            End If
        End If

        Return ds
    End Function
    Private Function AugSalaryData() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT EmpNO FROM [AugSalary] WHERE EmpNO = '" & empno.Text & "';", connection)
        Dim ds As New DataSet
        da.Fill(ds, "FilteredDesc")
        connection.Dispose()
        connection = Nothing
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM AugSalary ", Con)
                Con.Open()
                Dim tot1 As Int32 = cmd.ExecuteNonQuery

                Label164.Text = tot1.ToString("Rs:##############.00")
                Con.Close()
            Else
                MsgBox(" Record Does Not Not Exist !!!!")
            End If
        End If

        Return ds
    End Function
    Private Function SeptSalaryData() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT EmpNO FROM [SeptSalary] WHERE EmpNO = '" & empno.Text & "';", connection)
        Dim ds As New DataSet
        da.Fill(ds, "FilteredDesc")
        connection.Dispose()
        connection = Nothing
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM SeptSalary ", Con)
                Con.Open()
                Dim tot1 As Int32 = cmd.ExecuteNonQuery

                Label164.Text = tot1.ToString("Rs:##############.00")
                Con.Close()
            Else
                MsgBox(" Record Does Not Not Exist !!!!")
            End If
        End If

        Return ds
    End Function
    Private Function OctSalaryData() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT EmpNO FROM [OctSalary] WHERE EmpNO = '" & empno.Text & "';", connection)
        Dim ds As New DataSet
        da.Fill(ds, "FilteredDesc")
        connection.Dispose()
        connection = Nothing
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM OctSalary ", Con)
                Con.Open()
                Dim tot1 As Int32 = cmd.ExecuteNonQuery

                Label164.Text = tot1.ToString("Rs:##############.00")
                Con.Close()
            Else
                MsgBox(" Record Does Not Not Exist !!!!")
            End If
        End If

        Return ds
    End Function
    Private Function NovSalaryData() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT EmpNO FROM [NovSalary] WHERE EmpNO = '" & empno.Text & "';", connection)
        Dim ds As New DataSet
        da.Fill(ds, "FilteredDesc")
        connection.Dispose()
        connection = Nothing
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM NovSalary ", Con)
                Con.Open()
                Dim tot1 As Int32 = cmd.ExecuteNonQuery

                Label164.Text = tot1.ToString("Rs:##############.00")
                Con.Close()
            Else
                MsgBox(" Record Does Not Not Exist !!!!")
            End If
        End If

        Return ds
    End Function
    Private Function DecSalaryData() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter("SELECT EmpNO FROM [DecSalary] WHERE EmpNO = '" & empno.Text & "';", connection)
        Dim ds As New DataSet
        da.Fill(ds, "FilteredDesc")
        connection.Dispose()
        connection = Nothing
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM DecSalary ", Con)
                Con.Open()
                Dim tot1 As Int32 = cmd.ExecuteNonQuery

                Label164.Text = tot1.ToString("Rs:##############.00")
                Con.Close()
            Else
                MsgBox(" Record Does Not Not Exist !!!!")
            End If
        End If

        Return ds
    End Function
Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    ' Change controls size and fonts to fit screen working area..
    Dim rw As Double = (Me.Width - cw) / cw ' Ratio change of original form width.
    Dim rh As Double = (Me.Height - ch) / ch ' Ratio change of original form height.
    ' Change controls size to fit users screen working area.
    For Each Ctrl As Control In Controls
        Ctrl.Width += CInt(Ctrl.Width * rw)
        Ctrl.Height += CInt(Ctrl.Height * rh)
        Ctrl.Left += CInt(Ctrl.Left * rw)
        Ctrl.Top += CInt(Ctrl.Top * rh)
    Next
    cw = Me.Width
    ch = Me.Height
    ' Change all the forms controls font size.
    Dim nfsize As Single
    If cw > iw + 500 Then
        For Each Ctrl As Control In Controls
            ' Get the forms controls font size's property and increase it. Reset the font to the new size. 
            nfsize = Me.Font.Size + 3
            Ctrl.Font = New Font(Ctrl.Font.Name, nfsize, FontStyle.Bold, Ctrl.Font.Unit)
        Next
    Else
        Exit Sub
    End If
End Sub
End Class