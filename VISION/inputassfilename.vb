Imports ADOX
Imports System.Data.OleDb
Public Class inputassfilename
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim Course As String
            Course = Convert.ToString(TextBox1.Text.Trim() & "-Assignment-Marks")
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            Dim SchemaTable2 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & Course & ""})
            SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "AEvaluator"})

            If SchemaTable1.Rows.Count <> 0 And SchemaTable2.Rows.Count <> 0 Then

                Dim answer As MsgBoxResult
                answer = MsgBox("File Already Exists Do You want to Delete ?", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.CopyFile("C:\Database\college.accdb", "C:\BackupData\college.accdb", True)
                    Dim cmd7 As New OleDb.OleDbCommand("DROP  Table [" & Course & "]")
                    Dim cmd8 As New OleDb.OleDbCommand("DROP  Table AEvaluator")
                    cmd7.Connection = AccessConnection
                    cmd8.Connection = AccessConnection
                    cmd7.ExecuteNonQuery()
                    cmd8.ExecuteNonQuery()
                    AccessConnection.Close()
                    answer = MsgBox("YOUR FILE HAS BEEN DELETED DO YOU WANT TO RESTORE ", MsgBoxStyle.YesNo)
                    If answer = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.CopyFile("C:\BackupData\college.accdb", "C:\Database\college.accdb", True)
                        MsgBox("YOUR FILE HAS BEEN RESTORED OPEN ME AGIAN ")
                    Else
                        MsgBox(" YOU DID NOT RESTORE , I AM GOING ")
                    End If
                    Me.Close()

                Else
                    AssignmentMarks.Show()

                End If
               
        ' MsgBox("Exists and Now Packed , AGAIN REPAET PROCESS")

            Else
        Try
            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)
            Dim createTable As New OleDb.OleDbCommand
            createTable.Connection = Conn
            createTable.CommandType = CommandType.Text

            Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" & Course & "] ([SNO] INTEGER,[ENROLL] INTEGER,[PROGRAM] TEXT(10), [STUDENT_NAME] TEXT(50),[CRS1] TEXT(10),[CRS2] TEXT(10),[CRS3] TEXT(10),[CRS4] TEXT(10),[CRS5] TEXT(10),[CRS6] TEXT(10),[CRS7] TEXT(10),[CRS8] TEXT(10),[CRS9] TEXT(10),[CRS10] TEXT(10),[CRS11] TEXT(10),[CRS12] TEXT(10),[CRS13] TEXT(10),[MM] TEXT(6))", Conn)
            Dim cmd2 As New OleDb.OleDbCommand("CREATE TABLE [AEvaluator] ([CRS1] TEXT(30),[CRS2] TEXT(30),[CRS3] TEXT(30),[CRS4] TEXT(30),[CRS5] TEXT(30),[CRS6] TEXT(30),[CRS7] TEXT(30),[CRS8] TEXT(30),[CRS9] TEXT(30),[CRS10] TEXT(30),[CRS11] TEXT(30),[CRS12] TEXT(30),[CRS13] TEXT(30))", Conn)
            'Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [AssignmentMarks] ([SNO]) WITH PRIMARY", Conn)
            'cmd1.CommandType = System.Data.CommandType.Text
            cmd.Connection = Conn
            Conn.Open()
            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            Conn.Close()
            AssignmentMarks.Show()
        Catch ex As Exception
        End Try
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub inputassfilename_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class