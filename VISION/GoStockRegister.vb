Imports ADOX
Imports System.Data.OleDb
Public Class GoStockRegister
    Private Sub GoStockRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GOForstock()
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.

            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "StockR"})
            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [StockR] ([SNo] INTEGER,[Item_Name] TEXT(30),[Qty] INTEGER,[Issue_Name] TEXT(30),[Issue_Item] Text(30),[Issue_Qty] INTEGER,[Stock_Date] Text(10),[Item_Purchased] TEXT(50),[P_Rate] INTEGER,[P_Qty] INTEGER,[Amount] INTEGER,[Purchase_Date] TEXT(10))", Conn)
                    ' Dim cmd2 As New OleDb.OleDbCommand("create index [PrimaryKey] on [StockR] ([SNo]) WITH PRIMARY", Conn)
                    '  cmd2.CommandType = System.Data.CommandType.Text
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
                    ' cmd2.ExecuteNonQuery()
                    Conn.Close()
                    AccessConnection.Close()
                Catch ex As Exception
                End Try
            End If
            Try
                Dim AccessConne As New System.Data.OleDb.OleDbConnection()
                Dim SchemaTable1 As DataTable
                AccessConne.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                AccessConne.Open()
                SchemaTable1 = AccessConne.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "BFILLSTOCK"})
                If SchemaTable1.Rows.Count <> 0 Then
                    AccessConne.Close()
                Else
                    Try
                        Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                        Dim Conn As New OleDb.OleDbConnection(ConStr)
                        Dim createTable As New OleDb.OleDbCommand
                        createTable.Connection = Conn
                        createTable.CommandType = CommandType.Text
                        Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [BFILLSTOCK] ([TItem_Name] TEXT(30),[TQty] INTEGER)", Conn)
                        cmd1.Connection = Conn
                        Conn.Open()
                        cmd1.ExecuteNonQuery()
                        Conn.Close()
                    Catch ex As Exception
                    End Try
                End If
            Catch ex As Exception
            End Try
            Catch ex As Exception
        End Try
        StockRegistor.Show()
    End Sub
End Class