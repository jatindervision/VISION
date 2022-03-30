
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class ChcPrint

    Private sem As String = Chc.TextBox1.Text.Trim()
    Private programme As String = Chc.TextBox2.Text.Trim()
    Private today As String = Chc.TextBox3.Text.Trim()
    Private session As String = Chc.TextBox4.Text.Trim()
    Private Rate As String = Chc.TextBox5.Text.Trim()
    Private CCNAME = Chc.TextBox6.Text.Trim()
    Private COCODE = Chc.TextBox7.Text.Trim()
    Private HRS = Chc.TextBox8.Text.Trim()
    Private colname As String = Chc.Label13.Text.Trim()
    Private colcode As String = Chc.Label15.Text.Trim()
    Private coladd1 As String = Chc.Label17.Text.Trim()
    Private coladd2 As String = Chc.Label18.Text.Trim()
    Private CHCREC As String = Chc.TextBox9.Text.Trim()
    Dim NAMECHC As String

    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim DT As DataTable
    Dim tables As DataTableCollection
    Dim ATT As String
    Dim SCH As String
    Dim sno As Integer = 0
    Dim bills As String
    Dim tot As Integer = 0
    Dim amount As Integer
    Dim nc As Integer = 0
    Dim HRSCAL As Integer
    Dim chcfill As String
    Private Sub ChcPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        forCHCPRINT()
        Me.CenterToScreen()
        Me.TopMost = True
        Label1.Text = colname
        Label2.Text = programme
        Label4.Text = colcode
        Label5.Text = coladd1
        Label6.Text = coladd2
        Label9.Text = session
        Label10.Text = sem
        Label12.Text = COCODE
        HRSCAL = Rate * HRS
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            MyConn.Open()
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT * FROM  testingchc", MyConn)
            da.Fill(ds, "testingchc")

            Dim i As Integer = 0
            ' i = i + Convert.ToInt32(Recmin)
            For i = i To ds.Tables("testingchc").Rows.Count - 1 Step 1
                sno = sno + 1
                ListBox1.Items.Add(sno)
                ListBox2.Items.Add(ds.Tables("testingchc").Rows(i)(3))
                ListBox3.Items.Add(ds.Tables("testingchc").Rows(i)(4))
                ListBox4.Items.Add(ds.Tables("testingchc").Rows(i)(5))
                ListBox5.Items.Add(ds.Tables("testingchc").Rows(i)(1))
                ListBox6.Items.Add(ds.Tables("testingchc").Rows(i)(2))
                ListBox7.Items.Add(Rate & "/-per hr.")
                amount = HRSCAL * ds.Tables("testingchc").Rows(i)(2)
                ListBox8.Items.Add(amount & ".00")
                tot = tot + amount
            Next i

            Label28.Text = today
            Label19.Text = today
            Label29.Text = tot


            Dim numB As Integer
            If Decimal.TryParse(Label29.Text, numB) Then
                Label23.Text = "(Rs." + GetInWords(numB) + ")"
            Else
                Label23.Text = "Invalid Number"
            End If
            MyConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        delete()
        saveassign()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TopMost = False
        Button1.Visible = False
        Button2.Visible = False


        With Me.PrintForm1
            .PrintAction = Printing.PrintAction.PrintToPreview
            Dim MyMargins As New Margins
            With MyMargins
                .Left = 1
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
    Private Sub saveassign()
        Dim str As String
        NAMECHC = Convert.ToString(CHCREC & "CHCRECEIPT")
      
        Try
            str = "insert into [" & NAMECHC & "]  values("
            str += """" & Label10.Text.Trim() & """"
            Str += ","
            Str += """" & Label12.Text.Trim() & """"
            Str += ","
            str += """" & Label9.Text.Trim() & """"
            Str += ","
            str += """" & Label29.Text.Trim() & """"
            str += ","
            str += """" & Label23.Text.Trim() & """"
            str += ","
            str += """" & Label28.Text.Trim() & """"
            str += ")"
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            MsgBox("Record inserted successfully...BILL IS SAVED IN  [ Remind This Name for Receipt]" & "" & bills & " ")

        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Con.Close()
    End Sub

    Private Sub delete()
        Try
            Dim Str As String
            Str = "delete * from testingchc "
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not DELETE Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub

End Class