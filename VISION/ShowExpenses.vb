Imports ADOX
Imports System.Data.OleDb
Imports System.String
Public Class ShowExpenses
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source2 As New BindingSource
    Dim source1 As New BindingSource
    Dim source3 As New BindingSource
    Dim dest As New BindingSource
    Private Sub CollegeDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ShowExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ForShowExpenses()
        Me.TopMost = True
        Me.CenterToScreen()
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select Item_Purchased,Amount,Purchase_Date from [Expenses]", MyConn)
            da.Fill(ds, "Expenses")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView2.DataSource = view



            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da2 = New OleDbDataAdapter("Select Item_Purchased,Amount,Purchase_Date from [StockR]", MyConn)
            da2.Fill(ds, "StockR")
            Dim view3 As New DataView(tables(0))
            source3.DataSource = view3
            DataGridView3.DataSource = view3


        Catch ex As Exception
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ExpensesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables



        da = New OleDbDataAdapter("SELECT *  FROM Expenses Where Date='" & TextBox1.Text.Trim() & "'", MyConn)
        da.Fill(ds, "Expenses")
        Dim view As New DataView(tables(0))
        dest.DataSource = view
        ' view.RowFilter = "Id = " + TextBox1.Text + ";"
        For i = 0 To Me.DataGridView1.Columns.Count - 1
            Me.DataGridView1.Columns(i).Name = Me.DataGridView1.Columns(i).DataPropertyName
        Next
        DataGridView1.DataSource = view

        Con.Close()
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label6.Text = ""
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Con.Close()
        Expenses.Show()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Label3.Text = "Rs:0.00"
            If DataGridView1.RowCount > 1 Then
                Dim tamount As Decimal = 0



                For index As Integer = 0 To DataGridView1.RowCount - 1
                    tamount += Convert.ToInt32(DataGridView1.Rows(index).Cells("Amount").Value)

                Next

                tamount = Math.Max(tamount, 2) '2 is number of decimal places
                Label6.Text = tamount.ToString("Rs:#########.00")
            End If
        Catch ex As Exception
            MsgBox(" This Click is for General Expenses >>>Use Total Button for Proper Data !!!")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables



        da = New OleDbDataAdapter("SELECT *  FROM PurchaseR Where Date='" & TextBox1.Text.Trim() & "'", MyConn)
        da.Fill(ds, "Purchase")
        Dim view As New DataView(tables(0))
        dest.DataSource = view
        ' view.RowFilter = "Id = " + TextBox1.Text + ";"
        For i = 0 To Me.DataGridView1.Columns.Count - 1
            Me.DataGridView1.Columns(i).Name = Me.DataGridView1.Columns(i).DataPropertyName
        Next
        DataGridView1.DataSource = view

        Con.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Label6.Text = "Rs:0.00"
            If DataGridView1.RowCount > 1 Then
                Dim tamoun1 As Decimal = 0
                Dim cell3 As Decimal = 0
                For index As Integer = 0 To DataGridView1.RowCount - 1
                    tamoun1 += Convert.ToInt32(DataGridView1.Rows(index).Cells("Amount_").Value)

                Next

                tamoun1 = Math.Max(tamoun1, 2) '2 is number of decimal places
                Label3.Text = tamoun1.ToString("Rs:#########.00")
            End If
        Catch ex As Exception
            MsgBox("This Click is for Stock Expenses >>>Use Total Button for Proper Data !!!  ")

        End Try
    End Sub
End Class