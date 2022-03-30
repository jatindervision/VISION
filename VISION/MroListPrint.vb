Imports System
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class MroListPrint
    Private Form12 As New MroList
    Dim coursecode As String = MroList.TextBox1.Text.Trim()

    Dim proname As String = MroList.TextBox3.Text.Trim()
    Dim dates As String = MroList.TextBox4.Text.Trim()
    Dim session As String = MroList.TextBox5.Text.Trim()
    Dim sem As String = MroList.TextBox6.Text.Trim()
    Dim mroname As String = MroList.TextBox7.Text.Trim()
    Dim rate As String = MroList.TextBox8.Text.Trim()
    Dim colname As String = MroList.Label13.Text.Trim()
    Dim colcode As String = MroList.Label15.Text.Trim()
    Dim coladd1 As String = MroList.Label17.Text.Trim()
    Dim coladd2 As String = MroList.Label18.Text.Trim()
    Dim schedule As String = MroList.Label16.Text.Trim()
    Dim Course As String = MroList.Label22.Text.Trim()
    Dim namemro As String = MroList.TextBox2.Text.Trim()
    


    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim da3 As OleDbDataAdapter
    Dim source1 As New BindingSource
    Dim DT As DataTable
    Dim tables As DataTableCollection
    Dim sno As Integer = 0
    Dim bills As String
    Dim tot As Integer = 0

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
            '  .PrinterSettings.DefaultPageSettings.Landscape = True
            .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)

        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub MroListPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formrolistprint()
        Me.CenterToScreen()
        Me.TopMost = True
        Label1.Text = colname
        Label2.Text = proname
        Label4.Text = colcode
        Label5.Text = coladd1
        Label6.Text = coladd2
        Label9.Text = session
        Label10.Text = sem
        Label12.Text = coursecode
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables

            da = New OleDbDataAdapter("SELECT * FROM  [" & schedule & "] WHERE Course_Code = '" & coursecode & "' ", MyConn)
            da.Fill(ds, "" & schedule & "")
            Dim i As Integer

            For i = 0 To ds.Tables("" & schedule & "").Rows.Count - 1 Step 1
                sno = sno + 1
                ListBox1.Items.Add(sno)
                ListBox2.Items.Add(ds.Tables("" & schedule & "").Rows(i)("Date_"))
                ListBox3.Items.Add(ds.Tables("" & schedule & "").Rows(i)("Time_From"))
                ListBox4.Items.Add(ds.Tables("" & schedule & "").Rows(i)("Time_To"))
                ListBox5.Items.Add(rate + "/-")
                ListBox6.Items.Add(rate + ".00")
                tot = tot + rate
            Next i
            Label19.Text = sno
            Label21.Text = rate & "/-" & " EACH SESSION)"
            Label29.Text = tot
            Dim number As Integer
            If Decimal.TryParse(Label29.Text, number) Then
                Label23.Text = "(Rupees " + Numericalpha.GetNumberWords(number) + " Only)"
            Else
                Label23.Text = "Invalid Number"
            End If
           
        Catch ex As Exception
        End Try
        Label25.Text = mroname
        Label28.Text = dates

        saveassign()
    End Sub
    Private Sub saveassign()
        Dim str As String
        Dim RECE As String
        RECE = Convert.ToString(namemro & "MRORECEIPT")
        '   [Mro_Name] TEXT(50),[Course] TEXT(30),[Course_Code] TEXT(10),[Session] TEXT(15),[Amount] TEXT(10),[Amount_in_Words] TEXT(150),[Date_of_Bill] TEXT(10))",
        Try
            str = "insert into [" & RECE & "]   values("
            str += """" & Label25.Text.Trim() & """"
            Str += ","
            str += """" & Label10.Text.Trim() & """"
            Str += ","
            Str += """" & Label12.Text.Trim() & """"
            Str += ","
            str += """" & Label9.Text.Trim() & """"
            str += ","
            str += """" & Label19.Text.Trim() & """"
            str += ","
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
End Class