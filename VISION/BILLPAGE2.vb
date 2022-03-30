Imports ADOX
Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class BILLPAGE2
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim da3 As OleDbDataAdapter
    Dim da4 As OleDbDataAdapter
    Dim da5 As OleDbDataAdapter
    Dim da6 As OleDbDataAdapter
    Dim da7 As OleDbDataAdapter
    Dim da9 As OleDbDataAdapter
    Dim da10 As OleDbDataAdapter
    Dim da11 As OleDbDataAdapter
    Dim da12 As OleDbDataAdapter
    Dim da13 As OleDbDataAdapter
    Dim da14 As OleDbDataAdapter

    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim db_reader As OleDbDataReader
    Private caharges = finalbillstart.TextBox1.Text.Trim()
    Private assignment = finalbillstart.TextBox2.Text.Trim()
    Private mroreceipt = finalbillstart.TextBox3.Text.Trim()
    Private chcreceipt = finalbillstart.TextBox4.Text.Trim()
    Private m2roreceipt = finalbillstart.TextBox8.Text.Trim()
    Private c2hcreceipt = finalbillstart.TextBox7.Text.Trim()
    Private m3roreceipt = finalbillstart.TextBox10.Text.Trim()
    Private c3hcreceipt = finalbillstart.TextBox12.Text.Trim()
    Private m4roreceipt = finalbillstart.TextBox9.Text.Trim()
    Private c4hcreceipt = finalbillstart.TextBox11.Text.Trim()
    Private program = finalbillstart.TextBox6.Text.Trim()
    Dim ass As String
    Dim mror As String
    Dim chcr As String
    Dim m2ror As String
    Dim c2hcr As String
    Dim m3ror As String
    Dim c3hcr As String
    Dim m4ror As String
    Dim c4hcr As String
    Dim summ As Integer
    Dim tumm As Integer
    Dim summ1 As Integer
    Dim tumm1 As Integer
    Dim mrr As Integer
    Dim chccc As Integer
    Dim m2rr As Integer
    Dim c2hccc As Integer
    Dim m3rr As Integer
    Dim c3hccc As Integer
    Dim m4rr As Integer
    Dim c4hccc As Integer
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
    Dim str As String
    Dim str1 As String
    Dim CCD As String
    Dim c2cd As String
    Dim c3cd As String
    Dim c4cd As String
    Dim ses1 As String
    Dim ses2 As String
    Dim ses3 As String
    Dim ses4 As String
    Dim M1CCD As String
    Dim M2CCD As String
    Dim M3CCD As String
    Dim M4CCD As String
    Private Sub BILLPAGE2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BILL.Close()
        Me.TopMost = True
        Me.Location = New Point(400, 60)

        CurrentRow = 0
        Try
            'ds.Clear()
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("SELECT * FROM IGEXPENSES", MyConn)
            da1.Fill(ds, "IGEXPENSES")

            TTT1 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Postage")
            TTT2 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Telephone")
            TTT3 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Stationary")
            TTT4 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Furniture")
            TTT5 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Equipment")
            TTT6 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Electricity_Charges")
            TTT7 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Water_Charges")
            TTT8 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Printing_Binding")
            TTT9 = ds.Tables("IGEXPENSES").Rows(CurrentRow)("Entertainment")


            Dim TUMM As Integer
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            COUSELLING = (caharges & "ALLCOUNSELLINGBILL")
            da2 = New OleDbDataAdapter("SELECT * FROM [" & COUSELLING & "]", MyConn)
            da2.Fill(ds, "" & COUSELLING & "")
            For x As Integer = 0 To ds.Tables("" & COUSELLING & "").Rows.Count - 1 Step 1

                TUMM = TUMM + ds.Tables("" & COUSELLING & "").Rows(x).Item(5)
            Next x


            ALLASS()
            C1ALC1()
            C2ALC2()
            C3ALC3()
            C4ALC4()
            C5ALC5()
            C6ALC6()
            C7ALC7()
            C8ALC8()

            TTT10 = TTT1 + TTT2 + TTT3 + TTT4 + TTT5 + TTT6 + TTT7 + TTT8 + TTT9
            nettotal = TUMM + tumm1 + mrr + chccc + m2rr + c2hccc + m3rr + c3hccc + m4rr + c4hccc + TTT10

            Label19.Text = nettotal


            MyConn.Close()
        Catch ex As Exception
        End Try
    End Sub
   
    Private Sub ALLASS()
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            ass = Convert.ToString(assignment & "ALLASSIGNBILL")
            da5 = New OleDbDataAdapter("SELECT * FROM  [" & ass & "]", MyConn)
            da5.Fill(ds, "" & ass & "")
            For x As Integer = 0 To ds.Tables("" & ass & "").Rows.Count - 1 Step 1
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
                ListBox2.Items.Add(ds.Tables("" & ass & "").Rows(x).Item(1))
                ListBox3.Items.Add(ds.Tables("" & ass & "").Rows(x).Item(2))
                ListBox4.Items.Add(ds.Tables("" & ass & "").Rows(x).Item(7))
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
        Dim assign As String
        MyConn.Open()
        assign = Convert.ToString(assignment & "ALLASSIGNBILL")
        da5 = New OleDbDataAdapter("SELECT * FROM  [" & assign & "]", MyConn)
        da5.Fill(ds, "" & assign & "")
        For x As Integer = 0 To ds.Tables("" & assign & "").Rows.Count - 1 Step 1
            str = "INSERT INTO  [P2BOTTOMBILL]  VALUES ('" & ListBox2.Items.Item(x) & "','" & ListBox3.Items.Item(x) & "','" & ListBox4.Items.Item(x) & "')"
            Dim Scmd As OleDbCommand = New OleDbCommand(str, MyConn)
            Scmd.ExecuteNonQuery()
        Next x

        str1 = "INSERT INTO  [TOPBILLP2] VALUES ('" & Label12.Text.Trim() & "','" & Label13.Text.Trim() & "','" & Label14.Text.Trim() & "','" & Label22.Text.Trim() & "','" & Label21.Text.Trim() & "','" & Label20.Text.Trim() & "','" & Label37.Text.Trim() & "','" & Label36.Text.Trim() & "','" & Label35.Text.Trim() & "','" & Label34.Text.Trim() & "','" & Label33.Text.Trim() & "','" & Label32.Text.Trim() & "','" & Label15.Text.Trim() & "','" & Label41.Text.Trim() & "','" & Label16.Text.Trim() & "','" & Label18.Text.Trim() & "','" & Label25.Text.Trim() & "','" & Label40.Text.Trim() & "','" & Label24.Text.Trim() & "','" & Label23.Text.Trim() & "','" & Label31.Text.Trim() & "','" & Label39.Text.Trim() & "','" & Label30.Text.Trim() & "','" & Label29.Text.Trim() & "','" & Label28.Text.Trim() & "','" & Label38.Text.Trim() & "','" & Label27.Text.Trim() & "','" & Label26.Text.Trim() & "','" & Label19.Text.Trim() & "')"
        Dim Hcmd As OleDbCommand = New OleDbCommand(Str1, MyConn)
        Hcmd.ExecuteNonQuery()
        MyConn.Close()
        billpage2viewer.Show()
    End Sub
    Private Sub C1ALC1()
       
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            mror = Convert.ToString(mroreceipt & "MRORECEIPT")
            da6 = New OleDbDataAdapter("SELECT * FROM  [" & mror & "]", MyConn)
            da6.Fill(ds, "" & mror & "")

            M1CCD = ds.Tables("" & mror & "").Rows(0)("Course_Code")
            ses1 = ds.Tables("" & mror & "").Rows(0)("TOTAL_SESSIONS")
            mrr = ds.Tables("" & mror & "").Rows(0)("Amount")

            Label15.Text = program
            Label41.Text = M1CCD
            Label16.Text = ses1 & " SESSIONS"
            Label18.Text = mrr
        Catch ex As Exception
            MsgBox("PRESS OK AND CONTINUE:::::")
        End Try

    End Sub
    Private Sub C2ALC2()
    

            Try
                MyConn = New OleDbConnection
                MyConn.ConnectionString = connString
                ds = New DataSet
                tables = ds.Tables
                chcr = Convert.ToString(chcreceipt & "CHCRECEIPT")
                da7 = New OleDbDataAdapter("SELECT * FROM  [" & chcr & "]", MyConn)
                da7.Fill(ds, "" & chcr & "")
                CCD = ds.Tables("" & chcr & "").Rows(0)("Course_Code")
                chccc = ds.Tables("" & chcr & "").Rows(0)("Amount")
                Label12.Text = program
                Label13.Text = CCD
                Label14.Text = chccc
            Catch ex As Exception
            MsgBox("PRESS OK AND CONTINUE:::::")
            End Try


    End Sub
    Private Sub C3ALC3()
    

            Try
                MyConn = New OleDbConnection
                MyConn.ConnectionString = connString
                ds = New DataSet
                tables = ds.Tables
                m2ror = Convert.ToString(m2roreceipt & "MRORECEIPT")
                da9 = New OleDbDataAdapter("SELECT * FROM  [" & m2ror & "]", MyConn)
                da9.Fill(ds, "" & m2ror & "")
                M2CCD = ds.Tables("" & m2ror & "").Rows(0)("Course_Code")
                ses2 = ds.Tables("" & m2ror & "").Rows(0)("TOTAL_SESSIONS")
                m2rr = ds.Tables("" & m2ror & "").Rows(0)("Amount")

                Label25.Text = program
                Label40.Text = M2CCD
            Label24.Text = ses2 & " SESSIONS"
                Label23.Text = m2rr

            Catch ex As Exception
            MsgBox("PRESS OK AND CONTINUE:::::")
            End Try

    End Sub
    Private Sub C4ALC4()
     
            Try
                MyConn = New OleDbConnection
                MyConn.ConnectionString = connString
                ds = New DataSet
                tables = ds.Tables
                c2hcr = Convert.ToString(c2hcreceipt & "CHCRECEIPT")
                da10 = New OleDbDataAdapter("SELECT * FROM  [" & c2hcr & "]", MyConn)
                da10.Fill(ds, "" & c2hcr & "")
                c2cd = ds.Tables("" & c2hcr & "").Rows(0)("Course_Code")
                c2hccc = ds.Tables("" & c2hcr & "").Rows(0)("Amount")

                Label22.Text = program
                Label21.Text = c2cd
                Label20.Text = c2hccc
            Catch ex As Exception
            MsgBox("PRESS OK AND CONTINUE:::::")
            End Try

    End Sub
    Private Sub C5ALC5()
      
            Try
                MyConn = New OleDbConnection
                MyConn.ConnectionString = connString
                ds = New DataSet
                tables = ds.Tables
                m3ror = Convert.ToString(m3roreceipt & "MRORECEIPT")
                da11 = New OleDbDataAdapter("SELECT * FROM  [" & m3ror & "]", MyConn)
                da11.Fill(ds, "" & m3ror & "")
                M3CCD = ds.Tables("" & m3ror & "").Rows(0)("Course_Code")
                ses3 = ds.Tables("" & m3ror & "").Rows(0)("TOTAL_SESSIONS")
                m3rr = ds.Tables("" & m3ror & "").Rows(0)("Amount")

                Label31.Text = program
                Label39.Text = M3CCD
            Label30.Text = ses3 & " SESSIONS"
                Label29.Text = m3rr

            Catch ex As Exception
            MsgBox("PRESS OK AND CONTINUE:::::")
            End Try

    End Sub
    Private Sub C6ALC6()
      
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            c3hcr = Convert.ToString(c3hcreceipt & "CHCRECEIPT")
            da12 = New OleDbDataAdapter("SELECT * FROM  [" & c3hcr & "]", MyConn)
            da12.Fill(ds, "" & c3hcr & "")
            c3cd = ds.Tables("" & c3hcr & "").Rows(0)("Course_Code")
            c3hccc = ds.Tables("" & c3hcr & "").Rows(0)("Amount")
            Label37.Text = program
            Label36.Text = c3cd
            Label35.Text = c3hccc
        Catch ex As Exception
            MsgBox("PRESS OK AND CONTINUE:::::")
        End Try

    End Sub
    Private Sub C7ALC7()
       
            Try
                MyConn = New OleDbConnection
                MyConn.ConnectionString = connString
                ds = New DataSet
                tables = ds.Tables
                m4ror = Convert.ToString(m4roreceipt & "MRORECEIPT")
                da13 = New OleDbDataAdapter("SELECT * FROM  [" & m4ror & "]", MyConn)
                da13.Fill(ds, "" & m4ror & "")
                M4CCD = ds.Tables("" & m4ror & "").Rows(0)("Course_Code")
                ses4 = ds.Tables("" & m4ror & "").Rows(0)("TOTAL_SESSIONS")
                m4rr = ds.Tables("" & m4ror & "").Rows(0)("Amount")

                Label28.Text = program
                Label38.Text = M4CCD
            Label27.Text = ses4 & " SESSIONS"
                Label26.Text = m4rr

            Catch ex As Exception
            MsgBox("PRESS OK AND CONTINUE:::::")
            End Try

    End Sub
    Private Sub C8ALC8()
      
            Try
                MyConn = New OleDbConnection
                MyConn.ConnectionString = connString
                ds = New DataSet
                tables = ds.Tables
                c4hcr = Convert.ToString(c4hcreceipt & "CHCRECEIPT")
                da14 = New OleDbDataAdapter("SELECT * FROM  [" & c4hcr & "]", MyConn)
                da14.Fill(ds, "" & c4hcr & "")
                c4cd = ds.Tables("" & c4hcr & "").Rows(0)("Course_Code")
                c4hccc = ds.Tables("" & c4hcr & "").Rows(0)("Amount")
                Label34.Text = program
                Label33.Text = c4cd
                Label32.Text = c4hccc
            Catch ex As Exception
            MsgBox("PRESS OK AND CONTINUE:::::")
            End Try

    End Sub


End Class