Imports ADOX
Imports System.Data.OleDb
Public Class GoEmployeeDetail

    Private Sub GoEmployeeDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()

            Dim SchemaTable As DataTable


            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()


            'Retrieve schema information about Table1.

            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "EmployeeDetail"})


            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
                EmployeeDetail.Show()

            Else

                Try
                    'Dim ConStr As String = "ProvIder=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\shx.mdb;Persist Security Info=True"
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text

                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [EmployeeDetail]([EmpId] INTEGER,[Employee_Name] TEXT(50), [Ph_No] TEXT(13],[Designation] TEXT(15),[Address] TEXT(255),[DOB] TEXT(10),[PAN_No] Text(15),[Gender] Text(6),[Date_of_Joining] TEXT(10))", Conn)
                    Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [EmployeeDetail] ([EmpId]) WITH PRIMARY", Conn)
                    ' Dim cmd2 As New OleDb.OleDbCommand("INSERT INTO  [EmployeeDetail] (EmpId,Name,Ph_No,Designation,Address,DOB,PAN_No,Gender,Date_of_Joining) values (1,'Sample',1,'Sample','Sample','Sample','Sample','Sample','Sample')", Conn)

                    cmd1.CommandType = System.Data.CommandType.Text

                    cmd.Connection = Conn

                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    ' cmd2.ExecuteNonQuery()


                    Conn.Close()
                    AccessConnection.Close()
                    EmployeeDetail.Show()
                Catch ex As Exception
                End Try

            End If
        Catch ex As Exception
        End Try

    End Sub
End Class