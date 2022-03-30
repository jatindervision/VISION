Imports System.Data.OleDb
Public Class counst
    Dim NNAME As String
    Private Sub counst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NNAME = Convert.ToString(TextBox1.Text.Trim() & "SCHEDULE")
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()

            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & NNAME & ""})
            If SchemaTable1.Rows.Count = 0 Then
                MsgBox("SCHEDULE DOES NOT EXIT CLOSE IT AND ENTER SCHEDULE FIRST")
                AccessConnection.Close()
                Exit Sub
            End If
        Catch ex As Exception
        End Try
        FORCOUNSELLORCHARGES.Show()
    End Sub
End Class