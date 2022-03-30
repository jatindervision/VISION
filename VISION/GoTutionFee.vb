Imports ADOX
Imports System.Data.OleDb
Public Class GoTutionFee
    Private Sub GoTutionFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.

            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "Tutionfee"})
            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
                TutionFee.Show()
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [Tutionfee] ([Id] INTEGER,[StudentName] TEXT(100), [Amount] INTEGER,[DateT] TEXT(20))", Conn)
                    cmd.Connection = Conn
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    Conn.Close()
                    AccessConnection.Close()
                    TutionFee.Show()
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class