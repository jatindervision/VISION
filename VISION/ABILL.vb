Imports ADOX
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class ABILL
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim da3 As OleDbDataAdapter
    Dim da4 As OleDbDataAdapter
    Dim da5 As OleDbDataAdapter
    Dim da6 As OleDbDataAdapter
    Dim da7 As OleDbDataAdapter
    Dim da8 As OleDbDataAdapter

    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim db_reader As OleDbDataReader
    Private caharges = Afinalbillstart.TextBox1.Text.Trim()
    Private assignment = Afinalbillstart.TextBox2.Text.Trim()
    Private Session = Afinalbillstart.TextBox5.Text.Trim()
    Private CourseName = Afinalbillstart.TextBox6.Text.Trim()


    Dim ass As String
  
    Dim summ As Integer
    Dim tumm As Integer
    Dim summ1 As Integer
    Dim tumm1 As Integer
    Dim mrr As Integer
    Dim chccc As Integer
    Dim nettotal As Integer
    Dim COUSELLING As String
    Dim COUSE As String
    Dim NUM As String
    Dim SN As Integer
    Dim TTT1 As Integer
    Dim TTT2 As Integer
    Dim TTT3 As Integer
    Dim TTT4 As Integer
    Dim TTT5 As Integer
    Dim TTT6 As Integer
    Dim TTT7 As Integer
    Dim TTT8 As Integer
    Dim TTT9 As Integer
    Dim TTT10 As Integer
    Dim Str As String
    Dim Str1 As String
    Private Sub ABILL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ABILLPAGE2.Close()
        Me.Location = New Point(400, 60)
        CurrentRow = 0
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da3 = New OleDbDataAdapter("SELECT * FROM  Name", MyConn)
            da3.Fill(ds, "Name")
            Label12.Text = ds.Tables("Name").Rows(CurrentRow)("Name")
            Label13.Text = ds.Tables("Name").Rows(CurrentRow)("Code")
            Label15.Text = ds.Tables("Name").Rows(CurrentRow)("PLACE")
            Label3.Text = ds.Tables("Name").Rows(CurrentRow)("University_Name")
            Label1.Text = ds.Tables("Name").Rows(CurrentRow)("University_Add1")
            Label7.Text = ds.Tables("Name").Rows(CurrentRow)("University_Add2")
            MyConn.Close()
        Catch ex As Exception

        End Try
        Label55.Text = Session
        Try
            'ds.Clear()
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("SELECT * FROM IGEXPENSES", MyConn)
            da1.Fill(ds, "IGEXPENSES")
            Dim A1, A2, A3, A4, A5, A6, A7, A8, A9 As Integer

            A1 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Postage")
            A2 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Telephone")
            A3 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Stationary")
            A4 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Furniture")
            A5 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Equipment")
            A6 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Electricity_Charges")
            A7 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Water_Charges")
            A8 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Printing_Binding")
            A9 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Entertainment")

            If A1 = 0 And A2 = 0 And A3 = 0 And A4 = 0 And A5 = 0 And A6 = 0 And A7 = 0 And A8 = 0 And A9 = 0 Then
                TTT1 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Postage")
                TTT2 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Telephone")
                TTT3 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Stationary")
                TTT4 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Furniture")
                TTT5 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Equipment")
                TTT6 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Electricity_Charges")
                TTT7 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Water_Charges")
                TTT8 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Printing_Binding")
                TTT9 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Entertainment")
                Label27.Visible = False
                Label28.Visible = False
                Label29.Visible = False
                Label30.Visible = False
                Label31.Visible = False
                Label32.Visible = False
                Label33.Visible = False
                Label49.Visible = False

            Else
                Label26.Text = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Postage") & ".00"
                Label27.Text = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Telephone") & ".00"
                Label28.Text = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Stationary") & ".00"
                Label29.Text = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Furniture") & ".00"
                Label30.Text = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Equipment") & ".00"
                Label31.Text = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Electricity_Charges") & ".00"
                Label32.Text = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Water_Charges") & ".00"
                Label33.Text = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Printing_Binding") & ".00"
                Label49.Text = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Entertainment") & ".00"

                TTT1 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Postage")
                TTT2 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Telephone")
                TTT3 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Stationary")
                TTT4 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Furniture")
                TTT5 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Equipment")
                TTT6 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Electricity_Charges")
                TTT7 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Water_Charges")
                TTT8 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Printing_Binding")
                TTT9 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Entertainment")
            End If
            Label56.Text = CourseName

            Dim TUMM As Integer
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            COUSELLING = (caharges & "ALLCOUNSELLINGBILL")
            da2 = New OleDbDataAdapter("SELECT * FROM [" & COUSELLING & "]", MyConn)
            da2.Fill(ds, "" & COUSELLING & "")
            For x As Integer = 0 To ds.Tables("" & COUSELLING & "").Rows.Count - 1 Step 1
                SN = SN + 1
                If SN = 1 Then
                    NUM = "i."
                ElseIf SN = 2 Then
                    NUM = "ii."
                ElseIf SN = 3 Then
                    NUM = "iii."
                ElseIf SN = 4 Then
                    NUM = "iv."
                ElseIf SN = 5 Then
                    NUM = "v."
                ElseIf SN = 6 Then
                    NUM = "vi."
                End If
                ListBox1.Items.Add(NUM)
                ListBox2.Items.Add(ds.Tables("" & COUSELLING & "").Rows(x).Item(1))
                ListBox3.Items.Add(ds.Tables("" & COUSELLING & "").Rows(x).Item(2))
                ListBox4.Items.Add(ds.Tables("" & COUSELLING & "").Rows(x).Item(3) & " SESSIONS")
                ListBox5.Items.Add(ds.Tables("" & COUSELLING & "").Rows(x).Item(4) & "EACH")
                ListBox6.Items.Add(ds.Tables("" & COUSELLING & "").Rows(x).Item(5) & ".00")
                TUMM = TUMM + ds.Tables("" & COUSELLING & "").Rows(x).Item(5)
            Next x


            CALC4()
           

            TTT10 = TTT1 + TTT2 + TTT3 + TTT4 + TTT5 + TTT6 + TTT7 + TTT8 + TTT9
            nettotal = TUMM + tumm1 + TTT10
            Label19.Text = nettotal
            Dim numB As Integer
            If Decimal.TryParse(Label19.Text, numB) Then
                Label50.Text = "(Rs." + GetInWords(numB) + ")"
            Else
                Label50.Text = "Invalid Number"
            End If
            MyConn.Close()
        Catch ex As Exception
        End Try

    End Sub

  
    Private Sub CALC4()
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            ass = Convert.ToString(assignment & "ALLASSIGNBILL")
            da5 = New OleDbDataAdapter("SELECT * FROM  [" & ass & "]", MyConn)
            da5.Fill(ds, "" & ass & "")
            For x As Integer = 0 To ds.Tables("" & ass & "").Rows.Count - 1 Step 1
                summ1 = summ1 + ds.Tables("" & ass & "").Rows(x).Item(7)
            Next x
            tumm1 = summ1

        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button2.Visible = False
        Me.TopMost = False
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
        Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        Dim MyConn As OleDbConnection
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        Dim COU2 As String
        MyConn.Open()
        COU2 = (caharges & "ALLCOUNSELLINGBILL")
        da2 = New OleDbDataAdapter("SELECT * FROM [" & COU2 & "]", MyConn)
        da2.Fill(ds, "" & COU2 & "")
        For Y As Integer = 0 To ds.Tables("" & COU2 & "").Rows.Count - 1 Step 1
            Str = "INSERT INTO  [P1BOTTOMBILL]  VALUES ('" & ListBox2.Items.Item(Y) & "','" & ListBox3.Items.Item(Y) & "','" & ListBox4.Items.Item(Y) & "','" & ListBox5.Items.Item(Y) & "','" & ListBox6.Items.Item(Y) & "')"
            Dim Scmd As OleDbCommand = New OleDbCommand(Str, MyConn)
            Scmd.ExecuteNonQuery()
        Next Y
        Str1 = "INSERT INTO  [TOPBILLP1] VALUES ('" & Label3.Text.Trim() & "','" & Label1.Text.Trim() & "','" & Label7.Text.Trim() & "','" & Label15.Text.Trim() & "','" & Label12.Text.Trim() & "','" & Label13.Text.Trim() & "','" & Label56.Text.Trim() & "','" & Label19.Text.Trim() & "','" & Label50.Text.Trim() & "','" & Label55.Text.Trim() & "','" & Label26.Text.Trim() & "','" & Label27.Text.Trim() & "','" & Label28.Text.Trim() & "','" & Label29.Text.Trim() & "','" & Label30.Text.Trim() & "','" & Label31.Text.Trim() & "','" & Label32.Text.Trim() & "','" & Label33.Text.Trim() & "','" & Label49.Text.Trim() & "')"
        Dim Hcmd As OleDbCommand = New OleDbCommand(Str1, MyConn)
        Hcmd.ExecuteNonQuery()
        MyConn.Close()
        billviewerpage1.Show()
    End Sub
End Class