Public Class stco
    Dim NAMEF As String
    Private Sub stco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NAMEF = Convert.ToString(TextBox1.Text.Trim() & "ALLCOUNSELLINGBILL")
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & NAMEF & ""})
            If SchemaTable1.Rows.Count = 0 Then
             
                MsgBox("COURSE!ALLCOUNSELLINGBILL FILE DOES NOT EXIST , FIRST COMPLETE COUNSELLOR CHARGES!!")
             
                AccessConnection.Close()
                Exit Sub
            Else
                AccessConnection.Close()
                counsellorreceipt.Show()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class