Imports ADOX
Imports System.Data.OleDb
Public Class GOFIRSTEXCELIGNOU

    Private Sub GOFIRSTEXCELIGNOU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()

            Dim SchemaTable As DataTable


            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()


            'Retrieve schema information about Table1.

            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "FirstExcelIgnou"})


            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
                MixedIGNOUExcel.Show()
            Else

                Try
                    'Dim ConStr As String = "ProvIder=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\shx.mdb;Persist Security Info=True"
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand



                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text

                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [FirstExcelIgnou] ([SNO] INTEGER,[ENRNO] INTEGER, [PROGRAM] TEXT(10), [MEDIUM] TEXT(6), [STUDY] TEXT(10), [NAME] TEXT(30), [FNAME] TEXT(30), [ADD1] TEXT (150), [ADD2] TEXT(150), [ADD3] TEXT(150), [CITY] TEXT(15), [STATE] TEXT(30), [PIN] INTEGER, [STD] TEXT(10), [TEL] TEXT(12), [FAXSTD] TEXT(10), [FAX] TEXT(12), [EMAIL] TEXT(30), [CRS1] TEXT(10), [CRS2] TEXT(10), [CRS3] TEXT(10), [CRS4] TEXT(10), [CRS5] TEXT(10), [CRS6] TEXT(10), [CRS7] TEXT(10), [CRS8] TEXT(10), [CRS9] TEXT(10), [CRS10] TEXT(10), [CRS11] TEXT(10), [CRS12] TEXT(10), [CRS13] TEXT(10), MOBILE TEXT(10))", Conn)
                    Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [FirstExcelIgnou] ([SNo]) WITH PRIMARY", Conn)


                    cmd1.CommandType = System.Data.CommandType.Text
                    cmd.Connection = Conn

                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()


                    Conn.Close()
                    AccessConnection.Close()
                    MixedIGNOUExcel.Show()
                Catch ex As Exception
                End Try

            End If
        Catch ex As Exception
        End Try


    End Sub
End Class