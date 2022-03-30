Imports System.Data.OleDb
Public Class DisplayLab

    Dim con As New OleDbConnection

    Private Sub DisplayLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DispLab()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
          
            con.ConnectionString = "PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb"
            con.Open()
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter("SELECT * from Lab", con)
            da.Fill(ds, "Lab")

            Label7.Text = ds.Tables("Lab").Rows(0).Item(0)
            Label8.Text = ds.Tables("Lab").Rows(0).Item(1)
            Label9.Text = ds.Tables("Lab").Rows(0).Item(2)
            Label10.Text = ds.Tables("Lab").Rows(0).Item(3)
            Label11.Text = ds.Tables("Lab").Rows(0).Item(4)
            Label12.Text = ds.Tables("Lab").Rows(0).Item(5)
        Catch ex As Exception
            MsgBox("Can't load First Create Lab")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class