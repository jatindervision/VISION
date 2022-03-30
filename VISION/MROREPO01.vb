Imports ADOX
Imports System.Data.OleDb
Public Class MROREPO01

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            Dim SchemaTable2 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()

            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "MROTOP"})
            SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "MROBOTTOM"})
            If SchemaTable1.Rows.Count <> 0 And SchemaTable2.Rows.Count <> 0 Then
                ' DELETE RECORD FROM BOTH 
                '    INSERT RECORD IN BOTH
                MsgBox("Exists and Now Packed , AGAIN Enter Course Name { eg BCA1 } and Press Submit Button")
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table MROTOP")
                Dim cmd8 As New OleDb.OleDbCommand("DROP  Table MROBOTTOM")
                cmd7.Connection = AccessConnection
                cmd8.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                cmd8.ExecuteNonQuery()
                AccessConnection.Close()
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text

                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [MROTOP] ([SNO] INTEGER,[CName] TEXT(100),[Code] TEXT(15),[Prog_Name] TEXT(20),[CAdd1] TEXT(75),[CAdd2] TEXT(75),[Session] TEXT(20),[Course_Name] TEXT(15),[Lab_Code] TEXT(10),[Rate] TEXT(4),[MRO_Name] TEXT(50),[Dates] TEXT(10),[AmDigit] TEXT(6),[AmWords] Text(100))", Conn)
                    Dim cmd2 As New OleDb.OleDbCommand("create index [PrimaryKey] on [MROTOP] ([SNO]) WITH PRIMARY", Conn)
                    Dim cmd3 As New OleDb.OleDbCommand("CREATE TABLE [MROBOTTOM] ([SNO] INTEGER,[Dates] TEXT(10),[Timing_From] TEXT(10),[Timing_To] TEXT(10))", Conn)
                    Dim cmd4 As New OleDb.OleDbCommand("create index [PrimaryKey] on [MROBOTTOM] ([SNO]) WITH PRIMARY", Conn)

                    cmd2.CommandType = System.Data.CommandType.Text
                    cmd4.CommandType = System.Data.CommandType.Text
                    cmd1.Connection = Conn
                    cmd3.Connection = Conn
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()
                    cmd4.ExecuteNonQuery()
                    Conn.Close()
                    AccessConnection.Close()
                    MROREPO02.Show()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If
            AccessConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub

    Private Sub MROREPO01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


End Class