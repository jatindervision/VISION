Public Class ASSFORBILLSTART
    Dim NAMEa As String
    Dim BNAMEa As String
    Private Sub ASSFORBILLSTART_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ABILLSTARTA()
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NAMEa = Convert.ToString(TextBox1.Text.Trim())
        BNAMEa = Convert.ToString(TextBox1.Text.Trim() & "AssignmentMarks")
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            Dim SchemaTable2 As DataTable
            Dim SchemaTable3 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & NAMEa & ""})
            SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & BNAMEa & ""})
            SchemaTable3 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "Name"})
            If SchemaTable1.Rows.Count = 0 Or SchemaTable2.Rows.Count = 0 Or SchemaTable3.Rows.Count = 0 Then
                MsgBox(" IGNOU STUDENT LIST OR ASSIGNMENT MARKS MISSING , BOTH SHOULD BE IMPORT   !!!")
                AccessConnection.Close()
                Me.Close()
            Else
                Assforbill.Show()
            End If
        Catch ex As Exception
        End Try

    End Sub
End Class