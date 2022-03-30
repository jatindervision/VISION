Imports ADOX
Imports System.Data.OleDb
Imports System.String
Public Class MROREPO02
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Public Course As String = MROREPO01.TextBox1.Text.Trim()
    Dim coursename As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub MROREPO02_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MROREPO0002()
        Me.CenterToScreen()
        Me.TopMost = True
        TextBox5.Text = DateTimePicker1.Value.ToShortDateString

        Dim SCH As String
        SCH = Convert.ToString(Course & "SCHEDULE")
        Label22.Text = SCH
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT Course_Code FROM [" & SCH & "] ORDER BY SNO", MyConn)
            da.Fill(ds, " & SCH & ")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            da1 = New OleDbDataAdapter("SELECT * FROM Name", MyConn)
            da1.Fill(ds, "Name")
            Label13.Text = ds.Tables("Name").Rows(CurrentRow)("Name")
            Label15.Text = ds.Tables("Name").Rows(CurrentRow)("Code")
            Label17.Text = ds.Tables("Name").Rows(CurrentRow)("CAddr1")
            Label18.Text = ds.Tables("Name").Rows(CurrentRow)("CAddr2")
            
            MyConn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox1.Text = "" Or TextBox3.Text = "" Or Label22.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
            MsgBox(" Don't Leave Any field Empty!!!")
            Exit Sub
        End If

        Try

            Dim cmd5 As New OleDb.OleDbCommand("INSERT INTO  MROBOTTOM (SNO,Dates,Timing_From,Timing_To) SELECT SNO,DATE_ ,Time_From,Time_To FROM [" & Label22.Text.Trim() & "] WHERE Course_Code = '" & TextBox1.Text.Trim() & "' ", Con)
            Con.Open()
            cmd5.ExecuteNonQuery()
            Dim str As String

            str = "INSERT INTO  MROTOP VALUES("
            str += """" & 1 & """"
            str += ","
            str += """" & Label13.Text & """"
            str += ","
            str += """" & Label15.Text & """"
            str += ","
            str += """" & TextBox3.Text.Trim() & """"
            str += ","
            str += """" & Label17.Text & """"
            str += ","
            str += """" & Label18.Text & """"
            str += ","
            str += """" & TextBox6.Text.Trim() & """"
            str += ","
            str += """" & TextBox7.Text.Trim() & """"
            str += ","
            str += """" & TextBox1.Text.Trim() & """"
            str += ","
            str += """" & TextBox9.Text.Trim() & """"
            str += ","
            str += """" & TextBox8.Text.Trim() & """"
            str += ","
            str += """" & TextBox5.Text.Trim() & """"
            str += ","
            str += """" & Label14.Text.Trim() & """"
            str += ","
            str += """" & Label20.Text.Trim() & """"
            str += ")"
            Cmd = New OleDbCommand(str, Con)
            Cmd.ExecuteNonQuery()
            MsgBox("Success")
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tot As Integer
        Dim rate As Integer
        Dim I As Integer
        rate = Convert.ToInt32(TextBox9.Text.Trim())
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        da2 = New OleDbDataAdapter("SELECT * FROM [" & Label22.Text.Trim & "] WHERE Course_Code ='" & TextBox1.Text.Trim & "'", MyConn)
        da2.Fill(ds, "" & Label22.Text.Trim & "")

        For I = 0 To ds.Tables("" & Label22.Text.Trim & "").Rows.Count - 1 Step 1
            tot = tot + rate
        Next I
        Label14.Text = tot
        Dim number As Integer
        If Decimal.TryParse(Label14.Text, number) Then
            Label20.Text = "(Rupees " + Numericalpha.GetNumberWords(number) + " Only)"
        Else
            Label20.Text = "Invalid Number"
        End If
        tot = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MROREPOVIEWER.Show()
    End Sub
End Class