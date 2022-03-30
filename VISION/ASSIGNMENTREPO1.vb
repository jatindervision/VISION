Imports System.Data.OleDb
Imports System.String
Public Class ASSIGNMENTREPO1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            Dim SchemaTable2 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()

            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "ASSIGNMENTTOP"})
            SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "ASSIGNMENTBOTTOM"})
            If SchemaTable1.Rows.Count <> 0 And SchemaTable2.Rows.Count <> 0 Then
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table ASSIGNMENTTOP")
                Dim cmd8 As New OleDb.OleDbCommand("DROP  Table ASSIGNMENTBOTTOM")
                cmd7.Connection = AccessConnection
                cmd8.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                cmd8.ExecuteNonQuery()
                MsgBox("Exists and Now Packed , AGAIN Enter Course Name { eg BCA1 } and Press Submit Button")
                AccessConnection.Close()
                Exit Sub
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text

                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [ASSIGNMENTTOP] ([SNO] INTEGER,[Uname] TEXT(100),[Place] TEXT(15),[College_Code] TEXT(20),[U_Code] TEXT(15),[Course_Code] TEXT(15),[Assign_Number] TEXT(20),[MM] TEXT(10),[AwardList_No] TEXT(4),[CName] TEXT(30),[Date] TEXT(10),[CADD1] TEXT(50),[CADD2] TEXT(100),[CourseFullName] TEXT(100))", Conn)
                    Dim cmd2 As New OleDb.OleDbCommand("create index [PrimaryKey] on [ASSIGNMENTTOP] ([SNO]) WITH PRIMARY", Conn)
                    Dim cmd3 As New OleDb.OleDbCommand("CREATE TABLE [ASSIGNMENTBOTTOM] ([SNO] INTEGER,[Enrollment] TEXT(10),[StName] TEXT(40),[Course_Col] TEXT(10))", Conn)
                    Dim cmd4 As New OleDb.OleDbCommand("create index [PrimaryKey] on [ASSIGNMENTBOTTOM] ([SNO]) WITH PRIMARY", Conn)

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
                    ASSIGNMENTREPO2.Show()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ASSIGNMENTREPO1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class