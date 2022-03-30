Imports ADOX
Imports System.Data.OleDb
Public Class GoAdmissionBackup

    Private Sub GoAdmissionBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForGoone()
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()

            Dim SchemaTable As DataTable


            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()


            'Retrieve schema information about Table1.

            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "AdmissionBackup"})


            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
                AdmissionBackup.Show()

            Else

                Try
                    'Dim ConStr As String = "ProvIder=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\shx.mdb;Persist Security Info=True"
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text

                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [AdmissionBackup] ([Id] INTEGER,[Adm_NO] TEXT(10),[StName] TEXT(30),[Parentage] TEXT(30),[Address] TEXT(255),[DOB] TEXT(10),[Ph_No] INTEGER ,[Gender] TEXT(6),[Date_of_Admission] TEXT(10),[Course_Name] TEXT(15))", Conn)
                    Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [StAdmission] ([Id]) WITH PRIMARY", Conn)

                    '  Dim cmd2 As New OleDb.OleDbCommand("INSERT INTO  Tutionfee (Id,StudentName,Amount,DateT) values (1,'Sample','Sample','sample')", Conn)
                    cmd1.CommandType = System.Data.CommandType.Text
                    cmd.Connection = Conn

                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    '    cmd2.ExecuteNonQuery()
                    Conn.Close()
                    AccessConnection.Close()
                    AdmissionBackup.Show()
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class