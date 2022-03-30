Imports ADOX
Imports System.Data.OleDb
Public Class GOSchedule
    Private Sub GOSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForGoSchedule()
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "Holidays"})
            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
                ScheduleStart.Show()
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [Holidays] ([SNO] integer,[Holidays] Text(10))", Conn)
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
                    Conn.Close()
                    AccessConnection.Close()
                    ScheduleStart.Show()
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class