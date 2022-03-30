Imports ADOX
Imports System.Data.OleDb
Public Class Afinalbillstart

    Private Sub Afinalbillstart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 60)
        Abillff()
        Me.TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            Dim SchemaTable2 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()

            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "TOPBILLP1"})
            SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "P1BOTTOMBILL"})
            If SchemaTable1.Rows.Count <> 0 And SchemaTable2.Rows.Count <> 0 Then
                ' DELETE RECORD FROM BOTH 
                '    INSERT RECORD IN BOTH
                MsgBox("Exists and Now Packed USE THIS BUTTON AGAIN")
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table TOPBILLP1")
                Dim cmd8 As New OleDb.OleDbCommand("DROP  Table P1BOTTOMBILL")
                cmd7.Connection = AccessConnection
                cmd8.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                cmd8.ExecuteNonQuery()
                Exit Sub
            Else
                AccessConnection.Close()
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text

                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [TOPBILLP1] ([UName] TEXT(100),[Uadd1] TEXT(60),[Uadd2] TEXT(60),[Place] TEXT(15),[COLLEGE] TEXT(100),[CODE] TEXT(15),[COURSE_NAME] TEXT(6),[TotalA] TEXT(15),[Aminwords] TEXT(100),[Session] TEXT(15),[one] TEXT(6),[Two] TEXT(6),[Three] TEXT(6),[Four] TEXT(6),[Five] TEXT(6),[Six] Text(6),[Seven] TEXT(6),[Eight] TEXT(6),[Nine] Text(6))", Conn)
                    Dim cmd3 As New OleDb.OleDbCommand("CREATE TABLE [P1BOTTOMBILL] ([Course_Code] TEXT(10),[Course_FullName] TEXT(100),[Sessions] TEXT(15),[Hrs] TEXT(15),[Amount] TEXT(10))", Conn)
                    cmd1.Connection = Conn
                    cmd3.Connection = Conn
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        ABILL.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            Dim SchemaTable2 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()

            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "TOPBILLP2"})
            SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "P2BOTTOMBILL"})
            If SchemaTable1.Rows.Count <> 0 And SchemaTable2.Rows.Count <> 0 Then
                ' DELETE RECORD FROM BOTH 
                '    INSERT RECORD IN BOTH
                MsgBox("Exists and Now Packed USE THIS BUTTON AGAIN")
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table TOPBILLP2")
                Dim cmd8 As New OleDb.OleDbCommand("DROP  Table P2BOTTOMBILL")
                cmd7.Connection = AccessConnection
                cmd8.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                cmd8.ExecuteNonQuery()
                Exit Sub
            Else
                AccessConnection.Close()
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text

                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [TOPBILLP2] ([HIRINGCH] TEXT(10),[MROOMCH] TEXT(10),[COURSE] TEXT(10),[COURSE_CODE] TEXT(12),[SESSIONS] TEXT(15),[NETA] TEXT(10))", Conn)

                    Dim cmd3 As New OleDb.OleDbCommand("CREATE TABLE [P2BOTTOMBILL] ([Course_Code] TEXT(10),[Course_FullName] TEXT(100),[Amount] TEXT(10))", Conn)

                    cmd1.Connection = Conn
                    cmd3.Connection = Conn
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        ABILLPAGE2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ABILL.Close()
        ABILLPAGE2.Close()
        Me.Close()
    End Sub
End Class