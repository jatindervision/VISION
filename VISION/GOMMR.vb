Public Class GOMMR

    Private Sub GOMMR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()

            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "MMR"})

            If SchemaTable1.Rows.Count <> 0 Then
                MsgBox("Exists and Now Packed , OPEN MMR  AGAIN")
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table MMR")
                cmd7.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                AccessConnection.Close()
                Me.Close()
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [MMR] ([UName] Text(100),[Code] Text(20),[T1] Text(50),[T2] Text(50),[T3] Text(50),[T4] Text(50),[T5] Text(50),[T6] Text(50),[T7] Text(50),[T8] Text(50),[T9] Text(50),[T10] Text(50),[T11] Text(50),[T12] Text(50),[T13] Text(50),[T14] Text(50),[T15] Text(50),[T16] Text(50),[T17] Text(50),[T18] Text(50),[T19] Text(50),[T20] Text(50),[T21] Text(50),[T22] Text(50),[T23] Text(50),[T24] Text(50),[T25] Text(50),[T26] Text(50),[T27] Text(50),[T28] Text(50),[T29] Text(50),[T30] Text(50),[T31] Text(50),[T32] Text(50),[T33] Text(50),[T34] Text(50),[T35] Text(50))", Conn)
                    cmd1.Connection = Conn
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
                    Conn.Close()
                    AccessConnection.Close()
                    MMR.Show()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub
End Class