Imports ADOX
Imports System.Data.OleDb
Public Class forinputbox
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim Course As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Course = Convert.ToString(TextBox1.Text.Trim() & "CHCRECEIPT")
        Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
        Dim SchemaTable As DataTable
        AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        AccessConnection.Open()
        'Retrieve schema information about Table1.
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
                Me.Close()
            Else
                AccessConnection.Close()
                ReceiptCHC.Show()
            End If
        Else
            MsgBox("File Does not Exists !!!")
            Me.Close()
        End If
        AccessConnection.Close()
    End Sub

    Private Sub forinputbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        forib()
        Me.CenterToScreen()
        Me.TopMost = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class