Public Class directschedule
    Dim course As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        course = Convert.ToString(TextBox1.Text.Trim() & "SCHEDULE")
       
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & course & ""})
            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
                schedule1.Show()
            Else

                Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim Conn As New OleDb.OleDbConnection(ConStr)
                Dim createTable As New OleDb.OleDbCommand
                createTable.Connection = Conn
                createTable.CommandType = CommandType.Text
                Dim cmd3 As New OleDb.OleDbCommand("CREATE TABLE [" & course & "] ([SNO] integer,[DATE_] Text(10),[Semister] TEXT(7),[Time_From] Text(8),[Time_To] Text(8), [Course_Code] TEXT(10),[Academic_Counselor] Text(100))", Conn)
                Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [" & course & "] ([SNO]) WITH PRIMARY", Conn)
                cmd1.CommandType = System.Data.CommandType.Text
                Conn.Open()
                cmd3.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                Conn.Close()
                AccessConnection.Close()
                schedule1.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try

    End Sub

    Private Sub directschedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class