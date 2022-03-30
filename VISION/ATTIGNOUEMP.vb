Public Class ATTIGNOUEMP
    Private Sub ATTIGNOUEMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.TopMost = True
        TextBox1.Text = "IgnouEmployeeDetail"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "IgnouEmployeeDetail" Then
            MsgBox("Invalid File Name")
            Exit Sub
        End If
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "IGNOUEMPATTENDANCE"})
            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
                IgnouStaffAttendance.Show()
            Else
                Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim Conn As New OleDb.OleDbConnection(ConStr)
                Dim createTable As New OleDb.OleDbCommand
                createTable.Connection = Conn
                createTable.CommandType = CommandType.Text

                Dim cmd As New OleDb.OleDbCommand("CREATE TABLE IGNOUEMPATTENDANCE ([EMPID] INTEGER,[MOBILE] TEXT(10),[NAME] TEXT(50),[ATTENDANCE] TEXT(10),[DATES] TEXT(10))", Conn)
                cmd.Connection = Conn
                Conn.Open()
                cmd.ExecuteNonQuery()
                Conn.Close()
                AccessConnection.Close()
                IgnouStaffAttendance.Show()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class