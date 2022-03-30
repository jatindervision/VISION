
Imports System.Data.OleDb
Imports System.String
Public Class counsellorreceipt
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim dest As New BindingSource
    Private FNAME As String = stco.TextBox1.Text.Trim()
    Dim NAMEF As String
    Private Sub counsellorreceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cocharges()
        Me.CenterToScreen()
        Me.TopMost = True
        NAMEF = Convert.ToString(FNAME & "ALLCOUNSELLINGBILL")
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [" & NAMEF & "]", MyConn)
            da.Fill(ds, "" & NAMEF & "")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView2.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Label8.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        Label10.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        Label11.Text = DataGridView2.Rows(e.RowIndex).Cells(5).Value
        Label9.Text = FNAME
        Dim numB As Integer
        If Decimal.TryParse(Label11.Text, numB) Then
            Label13.Text = "(Rs." + GetInWords(numB) + ")"
        Else
            Label13.Text = "Invalid Number"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChargesReceipt.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class