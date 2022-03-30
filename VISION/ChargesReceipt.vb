Imports ADOX
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class ChargesReceipt
    Private Course = _13forinputbox.TextBox1.Text.Trim()
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim mror As String
    Private CNAME As String = counsellorreceipt.Label8.Text.Trim()
    Private PROGRAM As String = counsellorreceipt.Label9.Text.Trim()
    Private COURSECODE As String = counsellorreceipt.Label10.Text.Trim()
    Private AMOUNT As String = counsellorreceipt.Label11.Text.Trim()
    Private INWAMOUNT As String = counsellorreceipt.Label13.Text.Trim()
    Private SESSION As String = counsellorreceipt.TextBox1.Text.Trim()
    Private DATES As String = counsellorreceipt.TextBox2.Text.Trim()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TopMost = False
        Button1.Visible = False
        Button2.Visible = False
        With Me.PrintForm1
            .PrintAction = Printing.PrintAction.PrintToPreview
            Dim MyMargins As New Margins
            With MyMargins
                .Left = 0.5
                .Right = 0.2
                .Top = 0.8
                .Bottom = 0.5
            End With
            .PrinterSettings.DefaultPageSettings.Margins = MyMargins

            .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)

        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ChargesReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.CenterToScreen()
        Try
            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM Name", Con)
            Dad.Fill(Dst, "Name")
            Label17.Text = Dst.Tables("Name").Rows(CurrentRow)("Code")
            Con.Close()
            Label3.Text = AMOUNT
            Label4.Text = INWAMOUNT
            Label7.Text = SESSION
            Label9.Text = PROGRAM
            Label10.Text = COURSECODE
            Label12.Text = AMOUNT
            Label13.Text = INWAMOUNT
            Label19.Text = CNAME
            Label21.Text = DATES
            Label23.Text = DATES
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub
End Class