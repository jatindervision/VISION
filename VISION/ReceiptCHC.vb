Imports ADOX
Imports System.Data.OleDb
Public Class ReceiptCHC
    Private coursename = forinputbox.TextBox1.Text.Trim()
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim Course As String
    Private Sub ReceiptCHC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        forCHCReceipt()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
            Course = Convert.ToString(coursename & "CHCRECEIPT")
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            MyConn.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [" & Course & "]", MyConn)
            da1 = New OleDbDataAdapter("Select * from Name", MyConn)
            da.Fill(ds, "" & Course & "")
            da1.Fill(ds, "Name")

            Label9.Text = ds.Tables(0).Rows(CurrentRow)("Course")
            Label10.Text = ds.Tables(0).Rows(CurrentRow)("Course_Code")
            Label7.Text = ds.Tables(0).Rows(CurrentRow)("Session")
            Label3.Text = ds.Tables(0).Rows(CurrentRow)("Amount")
            Label4.Text = ds.Tables(0).Rows(CurrentRow)("Amount_in_Words")
            Label12.Text = ds.Tables(0).Rows(CurrentRow)("Amount")
            Label13.Text = ds.Tables(0).Rows(CurrentRow)("Amount_in_Words")
            Label21.Text = ds.Tables(0).Rows(CurrentRow)("Date_of_Bill")
            Label23.Text = ds.Tables(0).Rows(CurrentRow)("Date_of_Bill")
            Label24.Text = ds.Tables("Name").Rows(CurrentRow)("PLACE")
            MyConn.Close()

            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM Name", Con)
            Dad.Fill(Dst, "Name")
            Label17.Text = Dst.Tables("Name").Rows(CurrentRow)("Code")

        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TopMost = False
        Button1.Visible = False
        Button2.Visible = False


        PrintPreviewDialog1.WindowState = FormWindowState.Normal
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
        PrintPreviewDialog1.ClientSize = New Size(800, 800)

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class