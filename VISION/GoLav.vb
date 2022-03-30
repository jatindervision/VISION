Imports ADOX
Imports System.Data.OleDb
Public Class GoLav

    Private Sub GoLav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "Lab"})
            If SchemaTable.Rows.Count <> 0 Then
                MsgBox("Already Exits, For Changing  Use Edit From Lab ")
                AccessConnection.Close()
                Me.Close()
            Else
                Try
                    'Dim ConStr As String = "ProvIder=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\shx.mdb;Persist Security Info=True"
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [Lab] ([CPU] TEXT(5), [LED] TEXT(5),[KEYBOARD] TEXT(5),[MOUSE] TEXT(5),[PRINTER] TEXT(5),[PC] TEXT(5))", Conn)
                    cmd.Connection = Conn
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    Conn.Close()
                    AccessConnection.Close()
                    Lab.Show()
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class