Imports ADOX
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class MroReceipt
    Private Course = _13forinputbox.TextBox1.Text.Trim()
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim mror As String
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

    Private Sub MroReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formroreceipt()
        Me.TopMost = True
        Me.CenterToScreen()
        Try
            Con.Open()
            Dad = New OleDbDataAdapter("SELECT * FROM Name", Con)
            Dad.Fill(Dst, "Name")
            Label17.Text = Dst.Tables("Name").Rows(CurrentRow)("Code")
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Try
            mror = Convert.ToString(Course & "MRORECEIPT")
            'ds.Clear()
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            MyConn.Open()
            ds = New DataSet
            tables = ds.Tables

            da = New OleDbDataAdapter("Select * from [" & mror & "]", MyConn)
            da.Fill(ds, "" & mror & "")
            Label19.Text = ds.Tables(0).Rows(CurrentRow)("Mro_Name")
            Label9.Text = ds.Tables(0).Rows(CurrentRow)("Course")
            Label10.Text = ds.Tables(0).Rows(CurrentRow)("Course_Code")
            Label7.Text = ds.Tables(0).Rows(CurrentRow)("Session")
            Label3.Text = ds.Tables(0).Rows(CurrentRow)("Amount")
            Label4.Text = ds.Tables(0).Rows(CurrentRow)("Amount_in_Words")
            Label12.Text = ds.Tables(0).Rows(CurrentRow)("Amount")
            Label13.Text = ds.Tables(0).Rows(CurrentRow)("Amount_in_Words")
            Label21.Text = ds.Tables(0).Rows(CurrentRow)("Date_of_Bill")
            Label23.Text = ds.Tables(0).Rows(CurrentRow)("Date_of_Bill")
            MyConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub
End Class