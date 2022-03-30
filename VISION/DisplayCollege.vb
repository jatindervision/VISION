Imports System
Imports System.Data.OleDb
Public Class DisplayCollege

    Private Sub DisplayCollege_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForDisplayCollege()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
            Con.ConnectionString = "PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb"
            Con.Open()
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter("SELECT * from Name", Con)
            da.Fill(ds, "Name")
            Label1.Text = ds.Tables("Name").Rows(0).Item(1)
            Label14.Text = ds.Tables("Name").Rows(0).Item(2)
            Label15.Text = ds.Tables("Name").Rows(0).Item(3)
            Label16.Text = ds.Tables("Name").Rows(0).Item(4)
            Label17.Text = ds.Tables("Name").Rows(0).Item(5)
            Label18.Text = ds.Tables("Name").Rows(0).Item(6)
            Label19.Text = ds.Tables("Name").Rows(0).Item(7)
            Label20.Text = ds.Tables("Name").Rows(0).Item(8)
            Label21.Text = ds.Tables("Name").Rows(0).Item(9)
            Label22.Text = ds.Tables("Name").Rows(0).Item(10)
            Label23.Text = ds.Tables("Name").Rows(0).Item(11)
            Label24.Text = ds.Tables("Name").Rows(0).Item(12)
            Con.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "Name"})
            If SchemaTable1.Rows.Count <> 0 Then
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table Name")
                cmd7.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
            End If
        Catch ex As Exception
        End Try
        GoCollegeName.Show()

    End Sub
End Class
   