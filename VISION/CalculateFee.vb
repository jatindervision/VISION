Option Explicit On
Imports System.Data.OleDb

Public Class CalculateFee
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim dest As New BindingSource
    Dim source3 As New BindingSource


    Private Sub CalculateFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForcalculateFee()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("Select * from [Tutionfee]", MyConn)
            da1.Fill(ds, "Tutionfee")
            Dim view As New DataView(tables(0))
            source3.DataSource = view
            DataGridView2.DataSource = view
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label8.Text = ""
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Amount) FROM Tutionfee ", Con)
        Con.Open()
        Dim tot1 As Int32 = Cmd.ExecuteScalar
        'MessageBox.Show(tot1)
        Label8.Text = tot1.ToString("Rs:##############.00")
        Con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            'Dim text As String = TextBox1.Text
            'Dim stringToInteger As Integer = Convert.ToInt32(text)
            da = New OleDbDataAdapter("SELECT *  FROM Tutionfee Where Id=" + TextBox1.Text + "", MyConn)
            da.Fill(ds, "Tutionfee")
            Dim view As New DataView(tables(0))
            dest.DataSource = view
            ' view.RowFilter = "Id = " + TextBox1.Text + ";"
            For i = 0 To Me.DataGridView1.Columns.Count - 1
                Me.DataGridView1.Columns(i).Name = Me.DataGridView1.Columns(i).DataPropertyName
            Next
            DataGridView1.DataSource = view

            Con.Close()
            Label6.Text = ""
            Label8.Text = ""
        Catch ex As Exception
        End Try
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TutionFee.Show()
    End Sub
 
    Public Sub search()
    
    End Sub
    
    Private Sub Click_Me_Click(sender As Object, e As EventArgs) Handles Click_Me.Click
        If DataGridView1.RowCount > 1 Then
            Dim tamount As Decimal = 0
            
            For index As Integer = 0 To DataGridView1.RowCount - 1
                tamount += Convert.ToInt32(DataGridView1.Rows(index).Cells(2).Value)
                
            Next

            tamount = Math.Max(tamount, 2) '2 is number of decimal places
            Label6.Text = tamount.ToString("Rs:#########.00")


            
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class