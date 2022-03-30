Imports ADOX
Imports System.Data.OleDb
Public Class GoSalary
    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim Conn As New OleDb.OleDbConnection(ConStr)
    Dim createTable As New OleDb.OleDbCommand



            
    Private Sub GoSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable


            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()


            'Retrieve schema information about Table1.

            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "JanSalary"})
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "FebSalary"})
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "MarchSalary"})
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "AprilSalary"})
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "MaySalary"})
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "JuneSalary"})
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "JulySalary"})
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "AugSalary"})
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "SeptSalary"})
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "OctSalary"})
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "NovSalary"})
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "DecSalary"})


            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()

                Salary.Show()

            Else
                Con.Close()


                createTable.Connection = Conn
                createTable.CommandType = CommandType.Text


                Dim one As New OleDb.OleDbCommand("CREATE TABLE [JanSalary] ([EmpNO] INTEGER,[Employee_Name] TEXT(25),[Designation] TEXT(12), [Basic] INTEGER,[CA] INTEGER,[Medical] INTEGER,[DA] INTEGER ,[P_F_Emp] INTEGER , [P_F_Empr] INTEGER,[HRA] INTEGER,[FA] INTEGER ,[LTA] INTEGER ,[SA] INTEGER ,[ITax] INTEGER ,[ESIns] INTEGER,[Earnings] INTEGER , [Deductions] INTEGER,[Net_Salary] INTEGER,[Salary_Date] TEXT(10))", Conn)
                Dim two As New OleDb.OleDbCommand("create index [PrimaryKey] on [JanSalary] ([EmpNO]) WITH PRIMARY", Conn)

                Conn.Open()

                one.ExecuteNonQuery()
                two.ExecuteNonQuery()



                Dim three As New OleDb.OleDbCommand("CREATE TABLE [FebSalary]([EmpNO] INTEGER,[Employee_Name] TEXT(25),[Designation] TEXT(12), [Basic] INTEGER,[CA] INTEGER,[Medical] INTEGER,[DA] INTEGER ,[P_F_Emp] INTEGER , [P_F_Empr] INTEGER,[HRA] INTEGER,[FA] INTEGER ,[LTA] INTEGER ,[SA] INTEGER ,[ITax] INTEGER ,[ESIns] INTEGER,[Earnings] INTEGER , [Deductions] INTEGER,[Net_Salary] INTEGER,[Salary_Date] TEXT(10))", Conn)
                Dim four As New OleDb.OleDbCommand("create index [PrimaryKey] on [FebSalary] ([EmpNO]) WITH PRIMARY", Conn)



                three.ExecuteNonQuery()
                four.ExecuteNonQuery()



                Dim cmd4 As New OleDb.OleDbCommand("CREATE TABLE [MarchSalary] ([EmpNO] INTEGER,[Employee_Name] TEXT(25),[Designation] TEXT(12), [Basic] INTEGER,[CA] INTEGER,[Medical] INTEGER,[DA] INTEGER ,[P_F_Emp] INTEGER , [P_F_Empr] INTEGER,[HRA] INTEGER,[FA] INTEGER ,[LTA] INTEGER ,[SA] INTEGER ,[ITax] INTEGER ,[ESIns] INTEGER,[Earnings] INTEGER , [Deductions] INTEGER,[Net_Salary] INTEGER,[Salary_Date] TEXT(10))", Conn)
                Dim cmd5 As New OleDb.OleDbCommand("create index [PrimaryKey] on [MarchSalary] ([EmpNO]) WITH PRIMARY", Conn)


                cmd4.ExecuteNonQuery()
                cmd5.ExecuteNonQuery()


                Dim cmd6 As New OleDb.OleDbCommand("CREATE TABLE [AprilSalary] ([EmpNO] INTEGER,[Employee_Name] TEXT(25),[Designation] TEXT(12), [Basic] INTEGER,[CA] INTEGER,[Medical] INTEGER,[DA] INTEGER ,[P_F_Emp] INTEGER , [P_F_Empr] INTEGER,[HRA] INTEGER,[FA] INTEGER ,[LTA] INTEGER ,[SA] INTEGER ,[ITax] INTEGER ,[ESIns] INTEGER,[Earnings] INTEGER , [Deductions] INTEGER,[Net_Salary] INTEGER,[Salary_Date] TEXT(10))", Conn)
                Dim cmd7 As New OleDb.OleDbCommand("create index [PrimaryKey] on [AprilSalary] ([EmpNO]) WITH PRIMARY", Conn)


                cmd6.ExecuteNonQuery()
                cmd7.ExecuteNonQuery()


                Dim cmd8 As New OleDb.OleDbCommand("CREATE TABLE [MaySalary] ([EmpNO] INTEGER,[Employee_Name] TEXT(25),[Designation] TEXT(12), [Basic] INTEGER,[CA] INTEGER,[Medical] INTEGER,[DA] INTEGER ,[P_F_Emp] INTEGER , [P_F_Empr] INTEGER,[HRA] INTEGER,[FA] INTEGER ,[LTA] INTEGER ,[SA] INTEGER ,[ITax] INTEGER ,[ESIns] INTEGER,[Earnings] INTEGER , [Deductions] INTEGER,[Net_Salary] INTEGER,[Salary_Date] TEXT(10))", Conn)
                Dim cmd9 As New OleDb.OleDbCommand("create index [PrimaryKey] on [MaySalary] ([EmpNO]) WITH PRIMARY", Conn)


                cmd8.ExecuteNonQuery()
                cmd9.ExecuteNonQuery()


                Dim cmd10 As New OleDb.OleDbCommand("CREATE TABLE [JuneSalary] ([EmpNO] INTEGER,[Employee_Name] TEXT(25),[Designation] TEXT(12), [Basic] INTEGER,[CA] INTEGER,[Medical] INTEGER,[DA] INTEGER ,[P_F_Emp] INTEGER , [P_F_Empr] INTEGER,[HRA] INTEGER,[FA] INTEGER ,[LTA] INTEGER ,[SA] INTEGER ,[ITax] INTEGER ,[ESIns] INTEGER,[Earnings] INTEGER , [Deductions] INTEGER,[Net_Salary] INTEGER,[Salary_Date] TEXT(10))", Conn)
                Dim cmd11 As New OleDb.OleDbCommand("create index [PrimaryKey] on [JuneSalary] ([EmpNO]) WITH PRIMARY", Conn)


                cmd10.ExecuteNonQuery()
                cmd11.ExecuteNonQuery()


                Dim cmd12 As New OleDb.OleDbCommand("CREATE TABLE [JulySalary] ([EmpNO] INTEGER,[Employee_Name] TEXT(25),[Designation] TEXT(12), [Basic] INTEGER,[CA] INTEGER,[Medical] INTEGER,[DA] INTEGER ,[P_F_Emp] INTEGER , [P_F_Empr] INTEGER,[HRA] INTEGER,[FA] INTEGER ,[LTA] INTEGER ,[SA] INTEGER ,[ITax] INTEGER ,[ESIns] INTEGER,[Earnings] INTEGER , [Deductions] INTEGER,[Net_Salary] INTEGER,[Salary_Date] TEXT(10))", Conn)
                Dim cmd13 As New OleDb.OleDbCommand("create index [PrimaryKey] on [JulySalary] ([EmpNO]) WITH PRIMARY", Conn)


                cmd12.ExecuteNonQuery()
                cmd13.ExecuteNonQuery()


                Dim cmd14 As New OleDb.OleDbCommand("CREATE TABLE [AugSalary] ([EmpNO] INTEGER,[Employee_Name] TEXT(25),[Designation] TEXT(12), [Basic] INTEGER,[CA] INTEGER,[Medical] INTEGER,[DA] INTEGER ,[P_F_Emp] INTEGER , [P_F_Empr] INTEGER,[HRA] INTEGER,[FA] INTEGER ,[LTA] INTEGER ,[SA] INTEGER ,[ITax] INTEGER ,[ESIns] INTEGER,[Earnings] INTEGER , [Deductions] INTEGER,[Net_Salary] INTEGER,[Salary_Date] TEXT(10))", Conn)
                Dim cmd15 As New OleDb.OleDbCommand("create index [PrimaryKey] on [AugSalary] ([EmpNO]) WITH PRIMARY", Conn)


                cmd14.ExecuteNonQuery()
                cmd15.ExecuteNonQuery()


                Dim cmd16 As New OleDb.OleDbCommand("CREATE TABLE [SeptSalary] ([EmpNO] INTEGER,[Employee_Name] TEXT(25),[Designation] TEXT(12), [Basic] INTEGER,[CA] INTEGER,[Medical] INTEGER,[DA] INTEGER ,[P_F_Emp] INTEGER , [P_F_Empr] INTEGER,[HRA] INTEGER,[FA] INTEGER ,[LTA] INTEGER ,[SA] INTEGER ,[ITax] INTEGER ,[ESIns] INTEGER,[Earnings] INTEGER , [Deductions] INTEGER,[Net_Salary] INTEGER,[Salary_Date] TEXT(10))", Conn)
                Dim cmd17 As New OleDb.OleDbCommand("create index [PrimaryKey] on [SeptSalary] ([EmpNO]) WITH PRIMARY", Conn)


                cmd16.ExecuteNonQuery()
                cmd17.ExecuteNonQuery()


                Dim cmd18 As New OleDb.OleDbCommand("CREATE TABLE [OctSalary] ([EmpNO] INTEGER,[Employee_Name] TEXT(25),[Designation] TEXT(12), [Basic] INTEGER,[CA] INTEGER,[Medical] INTEGER,[DA] INTEGER ,[P_F_Emp] INTEGER , [P_F_Empr] INTEGER,[HRA] INTEGER,[FA] INTEGER ,[LTA] INTEGER ,[SA] INTEGER ,[ITax] INTEGER ,[ESIns] INTEGER,[Earnings] INTEGER , [Deductions] INTEGER,[Net_Salary] INTEGER,[Salary_Date] TEXT(10))", Conn)
                Dim cmd19 As New OleDb.OleDbCommand("create index [PrimaryKey] on [OctSalary] ([EmpNO]) WITH PRIMARY", Conn)


                cmd18.ExecuteNonQuery()
                cmd19.ExecuteNonQuery()


                Dim cmd20 As New OleDb.OleDbCommand("CREATE TABLE [NovSalary] ([EmpNO] INTEGER,[Employee_Name] TEXT(25),[Designation] TEXT(12), [Basic] INTEGER,[CA] INTEGER,[Medical] INTEGER,[DA] INTEGER ,[P_F_Emp] INTEGER , [P_F_Empr] INTEGER,[HRA] INTEGER,[FA] INTEGER ,[LTA] INTEGER ,[SA] INTEGER ,[ITax] INTEGER ,[ESIns] INTEGER,[Earnings] INTEGER , [Deductions] INTEGER,[Net_Salary] INTEGER,[Salary_Date] TEXT(10))", Conn)
                Dim cmd21 As New OleDb.OleDbCommand("create index [PrimaryKey] on [NovSalary] ([EmpNO]) WITH PRIMARY", Conn)


                cmd20.ExecuteNonQuery()
                cmd21.ExecuteNonQuery()


                Dim cmd22 As New OleDb.OleDbCommand("CREATE TABLE [DecSalary] ([EmpNO] INTEGER,[Employee_Name] TEXT(25),[Designation] TEXT(12), [Basic] INTEGER,[CA] INTEGER,[Medical] INTEGER,[DA] INTEGER ,[P_F_Emp] INTEGER , [P_F_Empr] INTEGER,[HRA] INTEGER,[FA] INTEGER ,[LTA] INTEGER ,[SA] INTEGER ,[ITax] INTEGER ,[ESIns] INTEGER,[Earnings] INTEGER , [Deductions] INTEGER,[Net_Salary] INTEGER,[Salary_Date] TEXT(10))", Conn)
                Dim cmd23 As New OleDb.OleDbCommand("create index [PrimaryKey] on [DecSalary] ([EmpNO]) WITH PRIMARY", Conn)


                cmd22.ExecuteNonQuery()
                cmd23.ExecuteNonQuery()

                Conn.Close()
                AccessConnection.Close()
                Salary.Show()
            End If
        Catch ex As Exception
        End Try

    End Sub


End Class