Imports ADOX
Imports System.Data.OleDb
Public Class IGNOU_LAB_ATT
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim Course As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim AccessConn As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            AccessConn.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConn.Open()
            SchemaTable1 = AccessConn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & TextBox1.Text.Trim() & ""})
            If SchemaTable1.Rows.Count = 0 Then
                MsgBox("PROGRAM DOES NOT EXIST!!!!")
                AccessConn.Close()
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        Course = Convert.ToString(TextBox2.Text.Trim() & "ATTENDANCE")
        Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
        Dim SchemaTable As DataTable
        AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        AccessConnection.Open()
        SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & Course & ""})
        If SchemaTable.Rows.Count <> 0 Then

            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            MyConn.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [" & Course & "]", MyConn)
            da.Fill(ds, "" & Course & "")
            If ds.Tables("" & Course & "").Rows.Count = Nothing Then
                MsgBox(" No Records ")
                AccessConnection.Close()
                Ignou_lab_attendance.Show()
            Else
                AccessConnection.Close()
                Ignou_lab_attendance.Show()
            End If
        Else
            Try
                Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim Conn As New OleDb.OleDbConnection(ConStr)
                Dim createTable As New OleDb.OleDbCommand
                createTable.Connection = Conn
                createTable.CommandType = CommandType.Text
                Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [" & Course & "] ([SNO] INTEGER,[ENROLL] TEXT(10),[NAME] TEXT(50),[ATTENDANCE] TEXT(10),[DATE_] TEXT(10))", Conn)
                Conn.Open()
                cmd1.ExecuteNonQuery()
                Conn.Close()
                MsgBox("CREATED")
                AccessConnection.Close()
                Ignou_lab_attendance.Show()
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub IGNOU_LAB_ATT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IGNOULABATT()
        Me.CenterToScreen()
        Me.TopMost = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class