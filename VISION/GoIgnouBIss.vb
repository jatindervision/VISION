Imports ADOX
Imports System.Data.OleDb
Public Class GoIgnouBIss
    Private Sub GoIgnouBIss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "IBooksIss"})
            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
                IgnouBooksIssue.Show()
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [IBooksIss] ([Enroll] INTEGER, [Student_Name] TEXT(50), [Book_Name] TEXT(50),[Course_Code] TEXT(10),[Issue_Date] TEXT(10))", Conn)
                    ' Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [IBooksE] ([Enroll]) WITH PRIMARY", Conn)
                    cmd1.CommandType = System.Data.CommandType.Text
                    cmd.Connection = Conn
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    ' cmd1.ExecuteNonQuery()
                    Conn.Close()
                    AccessConnection.Close()

                Catch ex As Exception
                End Try
                IgnouBooksIssue.Show()
            End If

        Catch ex As Exception
        End Try

    End Sub
End Class