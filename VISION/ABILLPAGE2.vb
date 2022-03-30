Imports ADOX
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class ABILLPAGE2
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim da3 As OleDbDataAdapter
    Dim da4 As OleDbDataAdapter
    Dim da5 As OleDbDataAdapter
    Dim da6 As OleDbDataAdapter
    Dim da7 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim db_reader As OleDbDataReader
    Private caharges = Afinalbillstart.TextBox1.Text.Trim()
    Private assignment = Afinalbillstart.TextBox2.Text.Trim()

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
    Dim str As String
    Dim str1 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs)
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
    Private Sub ABILLPAGE2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BILL.Close()
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
            CALC4()
            TTT10 = TTT1 + TTT2 + TTT3 + TTT4 + TTT5 + TTT6 + TTT7 + TTT8 + TTT9
            nettotal = TUMM + tumm1 + TTT10
            Label19.Text = nettotal

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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
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

        str1 = "INSERT INTO  [TOPBILLP2] VALUES ('" & Label14.Text.Trim() & "','" & Label18.Text.Trim() & "','" & Label12.Text.Trim() & "','" & Label13.Text.Trim() & "','" & Label16.Text.Trim() & "','" & Label19.Text.Trim() & "')"
        Dim Hcmd As OleDbCommand = New OleDbCommand(str1, MyConn)
        Hcmd.ExecuteNonQuery()
        MyConn.Close()
        Abillpage2viewer.Show()
    End Sub

End Class