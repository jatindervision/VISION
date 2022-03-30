Imports ADOX
Imports System.Data.OleDb
Public Class GoIgnouBooksE

    Private Sub GoIgnouBooksE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "IBooksE"})
            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
                IgnouBooksEntry.Show()
            Else
                Try
                    'Dim ConStr As String = "ProvIder=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\shx.mdb;Persist Security Info=True"
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [IBooksE] ([SNO] INTEGER, [Course_Code] Text(10),[Book_Name] TEXT(100),[Qty] INTEGER)", Conn)
                    Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [IBooksE] ([SNO]) WITH PRIMARY", Conn)


                    cmd1.CommandType = System.Data.CommandType.Text
                    cmd.Connection = Conn
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    Conn.Close()
                Catch ex As Exception
                End Try
            End If
            AccessConnection.Close()
        Catch ex As Exception
        End Try
        IgnouBooksEntry.Show()
    End Sub
End Class