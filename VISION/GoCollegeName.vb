Imports ADOX
Imports System.Data.OleDb
Public Class GoCollegeName
    Private Sub GoCollegeName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gocname()
        Me.CenterToScreen()
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "Name"})
            If SchemaTable.Rows.Count <> 0 Then
                MsgBox("Already Exits, For Changing  Click on  College from Main Menu and Select CHANGE COLLEGE NAME and Choose Delete College Name , then Again Make Entry ")
                AccessConnection.Close()
                Me.Close()
            Else
                Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim Conn As New OleDb.OleDbConnection(ConStr)
                Dim createTable As New OleDb.OleDbCommand
                createTable.Connection = Conn
                createTable.CommandType = CommandType.Text
                Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [Name] ([Id] INTEGER,[PLACE] TEXT(20),[Name] TEXT(100),[CAddr1] TEXT(100),[CAddr2] TEXT(100),[Code] TEXT(10),[Coordinator_Name] TEXT(50),[Co_Addr1] TEXT(100),[Co_Add2] TEXT(100),[University_Name] TEXT(50),[Reg_No] TEXT(10),[University_Add1] TEXT(50),[University_Add2] TEXT(50))", Conn)
                Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [Name] ([Id]) WITH PRIMARY", Conn)
                cmd1.CommandType = System.Data.CommandType.Text
                cmd.Connection = Conn
                Conn.Open()
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                Conn.Close()
                AccessConnection.Close()
                Collegename.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub
End Class