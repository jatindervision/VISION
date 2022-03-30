Public Class disp_all_tables
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim db_reader As OleDbDataReader
    Dim source1 As New BindingSource
    Dim DT As DataTable
    Dim tables As DataTableCollection
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [" & TextBox1.Text.Trim() & "]", MyConn)
            da.Fill(ds, "" & TextBox1.Text.Trim() & "")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    Private Sub disp_all_tables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DISPALLTBL()
        Me.CenterToScreen()
        Me.TopMost = True
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
End Class