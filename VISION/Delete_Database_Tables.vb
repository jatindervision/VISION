Public Class Delete_Database_Tables
    Public selected As String

    Private Sub Delete_Database_Tables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DELONEBYONE()
        Me.CenterToScreen()
        Me.TopMost = True
        'Create a connection object using OleDB
        Dim conn As New OleDb.OleDbConnection
        'Create a connection string for an Access database
        Dim strConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"

        'Attach the connection string to the connection object
        conn.ConnectionString = strConnectionString
        'Open the connection
        conn.Open()

        'Create a DataTable object for holding database information
        Dim schemaTable As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})

        'Loop through the rows in the databases schema and retrieve table names and add them to the combo box
        For Each dr As DataRow In schemaTable.Rows
            ComboBox1.Items.Add(dr.Item("TABLE_NAME"))
        Next
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
     
        AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        AccessConnection.Open()
        Try
            Dim TBL As String
            TBL = Convert.ToString(TextBox1.Text.Trim())
            Dim cmd7 As New OleDb.OleDbCommand("DROP  Table " & TBL & "", AccessConnection)
            ' Dim cmd7 As New OleDb.OleDbCommand("DROP  Table BCSL-013-ATTENDANCE")
            cmd7.ExecuteNonQuery()

            MsgBox("DATABASE SELECTED TABLE HAS BEEN DELETED")
            AccessConnection.Close()
        Catch ex As Exception
        End Try

        ' Remove all previous entries.
        ComboBox1.Items.Clear()

        Dim conn As New OleDb.OleDbConnection
        'Create a connection string for an Access database
        Dim strConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"

        'Attach the connection string to the connection object
        conn.ConnectionString = strConnectionString
        'Open the connection
        conn.Open()

        'Create a DataTable object for holding database information
        Dim schemaTable As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})

        'Loop through the rows in the databases schema and retrieve table names and add them to the combo box
        For Each dr As DataRow In schemaTable.Rows
            ComboBox1.Items.Add(dr.Item("TABLE_NAME"))
        Next
    End Sub
  
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BACKUPDATA.Show()
    End Sub
End Class