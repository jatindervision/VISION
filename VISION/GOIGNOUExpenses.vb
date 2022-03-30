Imports ADOX
Imports System.Data.OleDb
Public Class GOIGNOUExpenses

    Private Sub GOIGNOUExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "IGNOUExpenses"})
            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
                IGNOUExpenses.Show()
            Else
                Try
                    'Dim ConStr As String = "ProvIder=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\shx.mdb;Persist Security Info=True"
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [IGNOUExpenses] ([SN] INTEGER,[Postage] INTEGER,[Telephone] INTEGER,[Stationary] INTEGER,[Furniture] INTEGER,[Equipment] INTEGER,[Electricity_Charges] INTEGER,[Water_Charges] INTEGER,[Printing_Binding] INTEGER,[Entertainment] INTEGER,[Date_of_Expense] TEXT(10))", Conn)
                    Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [IGNOUExpenses] ([SN]) WITH PRIMARY", Conn)
                    cmd1.CommandType = System.Data.CommandType.Text
                    cmd.Connection = Conn
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()


                    Conn.Close()
                    AccessConnection.Close()
                    IGNOUExpenses.Show()
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try

    End Sub
End Class