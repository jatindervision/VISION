Imports ADOX
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class StaffAttendance
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim sno As Integer
    Private Coursename = ATTSTAFF.TextBox1.Text.Trim()
    Dim dateReg As Regex = New Regex("((^(10|12|0?[13578])(/)(3[01]|[12][0-9]|0?[1-9])(/)((1[8-9]\d{2})|([2-9]\d{3}))$)" _
                                     & "|(^(11|0?[469])(/)(30|[12][0-9]|0?[1-9])(/)((1[8-9]\d{2})|([2-9]\d{3}))$)" _
                                     & "|(^(0?2)(/)(2[0-8]|1[0-9]|0?[1-9])(/)((1[8-9]\d{2})|([2-9]\d{3}))$)" _
                                     & "|(^(0?2)(/)(29)(/)([2468][048]00)$)|(^(0?2)(/)(29)(/)([3579][26]00)$)" _
                                     & "|(^(0?2)(/)(29)(/)([1][89][0][48])$)" _
                                     & "|(^(0?2)(/)(29)(/)([2-9][0-9][0][48])$)" _
                                     & "|(^(0?2)(/)(29)(/)([1][89][2468][048])$)" _
                                     & "|(^(0?2)(/)(29)(/)([2-9][0-9][2468][048])$)" _
                                     & "|(^(0?2)(/)(29)(/)([1][89][13579][26])$)" _
                                     & "|(^(0?2)(/)(29)(/)([2-9][0-9][13579][26])$))")
   

    Private Sub StaffAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForSStaffattendance()
        Me.CenterToScreen()
        Me.TopMost = True


        Label21.ForeColor = Color.Red
        Label21.Text = ""

        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da1 = New OleDbDataAdapter("SELECT * FROM  [" & Coursename & "]", MyConn)
            da1.Fill(ds, "" & Coursename & "")
            Label14.Text = ds.Tables("" & Coursename & "").Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try

        maindata()
    End Sub
    Private Sub Textbox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged
        Dim dateMatch As Match = dateReg.Match(TextBox23.Text.Trim())
        If dateMatch.Success Then
            Label21.Text = ""
        Else
            Label21.Text = "Invalid Date"
        End If
    End Sub
   

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox21.Text = "" And TextBox22.Text = "" Then
            Exit Sub
        End If


        Dim i As Integer = 0
        Dim J As Integer
        i = Convert.ToInt32(TextBox21.Text.Trim())
        J = Convert.ToInt32(TextBox22.Text.Trim())
        Try
            If i = 1 And J = 20 Or i = 21 And J = 40 Or i = 41 And J = 60 Or i = 61 And J = 80 Or i = 81 And J = 100 Or i = 101 And J = 120 Or i = 121 And J = 140 Or i = 141 And J = 160 Or i = 161 And J = 180 Or i = 181 And J = 200 Then

                For i = i - 1 To J - 1 Step 1

                    sno = sno + 1
                    ListBox1.Items.Add(ds.Tables("" & Coursename & "").Rows(i)("EmpId"))
                    ' ListBox1.Items.Add("----")
                    ListBox2.Items.Add(ds.Tables("" & Coursename & "").Rows(i)("Ph_No"))
                    ' ListBox2.Items.Add("----------------")
                    ListBox3.Items.Add(ds.Tables("" & Coursename & "").Rows(i)("Employee_Name"))
                    If i = ds.Tables("" & Coursename & "").Rows.Count - 1 Then
                        Exit For
                    End If
                Next i
            Else
                MsgBox("Enter According to Range!!!")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Con.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox23.Text.Length < 10 Then
            MsgBox("Date Format Wrong i.e : MM/DD/2020 ::::means if Date is 4th sept. 2040 then Enter 09/04/2040")
            Exit Sub
        End If
        If Label21.Text = "Invalid Data" Then
            MsgBox("Enter Date IN Correct Format i.e MM/DD/YYYY")
            Exit Sub
        End If
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        TextBox13.Visible = False
        TextBox14.Visible = False
        TextBox15.Visible = False
        TextBox16.Visible = False
        TextBox17.Visible = False
        TextBox18.Visible = False
        TextBox19.Visible = False
        TextBox20.Visible = False
        If ComboBox1.Text = "P" Then
            ComboBox2.Text = "Present"
            ComboBox3.Text = "Present"
            ComboBox4.Text = "Present"
            ComboBox5.Text = "Present"
            ComboBox6.Text = "Present"
            ComboBox7.Text = "Present"
            ComboBox8.Text = "Present"
            ComboBox9.Text = "Present"
            ComboBox10.Text = "Present"
            ComboBox11.Text = "Present"
            ComboBox12.Text = "Present"
            ComboBox13.Text = "Present"
            ComboBox14.Text = "Present"
            ComboBox15.Text = "Present"
            ComboBox16.Text = "Present"
            ComboBox17.Text = "Present"
            ComboBox18.Text = "Present"
            ComboBox19.Text = "Present"
            ComboBox20.Text = "Present"
            ComboBox21.Text = "Present"

        ElseIf ComboBox1.Text = "A" Then
            ComboBox2.Text = "Absent"
            ComboBox3.Text = "Absent"
            ComboBox4.Text = "Absent"
            ComboBox5.Text = "Absent"
            ComboBox6.Text = "Absent"
            ComboBox7.Text = "Absent"
            ComboBox8.Text = "Absent"
            ComboBox9.Text = "Absent"
            ComboBox10.Text = "Absent"
            ComboBox11.Text = "Absent"
            ComboBox12.Text = "Absent"
            ComboBox13.Text = "Absent"
            ComboBox14.Text = "Absent"
            ComboBox15.Text = "Absent"
            ComboBox16.Text = "Absent"
            ComboBox17.Text = "Absent"
            ComboBox18.Text = "Absent"
            ComboBox19.Text = "Absent"
            ComboBox20.Text = "Absent"
            ComboBox21.Text = "Absent"


        ElseIf ComboBox1.Text = "L" Then
            ComboBox2.Text = "Leave"
            ComboBox3.Text = "Leave"
            ComboBox4.Text = "Leave"
            ComboBox5.Text = "Leave"
            ComboBox6.Text = "Leave"
            ComboBox7.Text = "Leave"
            ComboBox8.Text = "Leave"
            ComboBox9.Text = "Leave"
            ComboBox10.Text = "Leave"
            ComboBox11.Text = "Leave"
            ComboBox12.Text = "Leave"
            ComboBox13.Text = "Leave"
            ComboBox14.Text = "Leave"
            ComboBox15.Text = "Leave"
            ComboBox16.Text = "Leave"
            ComboBox17.Text = "Leave"
            ComboBox18.Text = "Leave"
            ComboBox19.Text = "Leave"
            ComboBox20.Text = "Leave"
            ComboBox21.Text = "Leave"

        ElseIf ComboBox1.Text = "S" Then
            ComboBox2.Text = "Sick"
            ComboBox3.Text = "Sick"
            ComboBox4.Text = "Sick"
            ComboBox5.Text = "Sick"
            ComboBox6.Text = "Sick"
            ComboBox7.Text = "Sick"
            ComboBox8.Text = "Sick"
            ComboBox9.Text = "Sick"
            ComboBox10.Text = "Sick"
            ComboBox11.Text = "Sick"
            ComboBox12.Text = "Sick"
            ComboBox13.Text = "Sick"
            ComboBox14.Text = "Sick"
            ComboBox15.Text = "Sick"
            ComboBox16.Text = "Sick"
            ComboBox17.Text = "Sick"
            ComboBox18.Text = "Sick"
            ComboBox19.Text = "Sick"
            ComboBox20.Text = "Sick"
            ComboBox21.Text = "Sick"


        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox23.Text.Length < 10 Then
            MsgBox("Date Format Wrong i.e : MM/DD/2020 ::::means if Date is 4th sept. 2040 then Enter 09/04/2040")
            Exit Sub
        End If
        If TextBox21.Text = "" And TextBox22.Text = "" And Label21.Text = "Invalid Data" Then
            Exit Sub
        End If

        Dim Str As String
        Dim Dates As String
        Dates = TextBox23.Text.Trim()
        ListBox4.Items.Add(ComboBox2.Text.Trim())
        ListBox4.Items.Add(ComboBox3.Text.Trim())
        ListBox4.Items.Add(ComboBox4.Text.Trim())
        ListBox4.Items.Add(ComboBox5.Text.Trim())
        ListBox4.Items.Add(ComboBox6.Text.Trim())
        ListBox4.Items.Add(ComboBox7.Text.Trim())
        ListBox4.Items.Add(ComboBox8.Text.Trim())
        ListBox4.Items.Add(ComboBox9.Text.Trim())
        ListBox4.Items.Add(ComboBox10.Text.Trim())
        ListBox4.Items.Add(ComboBox11.Text.Trim())
        ListBox4.Items.Add(ComboBox12.Text.Trim())
        ListBox4.Items.Add(ComboBox13.Text.Trim())
        ListBox4.Items.Add(ComboBox14.Text.Trim())
        ListBox4.Items.Add(ComboBox15.Text.Trim())
        ListBox4.Items.Add(ComboBox16.Text.Trim())
        ListBox4.Items.Add(ComboBox17.Text.Trim())
        ListBox4.Items.Add(ComboBox18.Text.Trim())
        ListBox4.Items.Add(ComboBox19.Text.Trim())
        ListBox4.Items.Add(ComboBox20.Text.Trim())
        ListBox4.Items.Add(ComboBox21.Text.Trim())

        Try
            Dim i As Integer
            Con.Open()
            For i = 0 To ListBox1.Items.Count - 1
                Str = "insert into STAFFATTENDANCE values('" & ListBox1.Items.Item(i) & "','" & ListBox2.Items.Item(i) & "','" & ListBox3.Items.Item(i) & "','" & ListBox4.Items.Item(i) & "','" & Dates & "')"
                Dim cmd As OleDbCommand = New OleDbCommand(Str, Con)
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Record inserted successfully...")
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
        TextBox21.Focus()
    End Sub
    Private Sub maindata()
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        TextBox13.Visible = False
        TextBox14.Visible = False
        TextBox15.Visible = False
        TextBox16.Visible = False
        TextBox17.Visible = False
        TextBox18.Visible = False
        TextBox19.Visible = False
        TextBox20.Visible = False



        ComboBox1.Items.Add("P")
        ComboBox1.Items.Add("A")
        ComboBox1.Items.Add("L")
        ComboBox1.Items.Add("S")

        ComboBox2.Items.Add("Present")
        ComboBox2.Items.Add("Absent")
        ComboBox2.Items.Add("Leave")
        ComboBox2.Items.Add("Sick")

        ComboBox3.Items.Add("Present")
        ComboBox3.Items.Add("Absent")
        ComboBox3.Items.Add("Leave")
        ComboBox3.Items.Add("Sick")

        ComboBox4.Items.Add("Present")
        ComboBox4.Items.Add("Absent")
        ComboBox4.Items.Add("Leave")
        ComboBox4.Items.Add("Sick")

        ComboBox5.Items.Add("Present")
        ComboBox5.Items.Add("Absent")
        ComboBox5.Items.Add("Leave")
        ComboBox5.Items.Add("Sick")

        ComboBox6.Items.Add("Present")
        ComboBox6.Items.Add("Absent")
        ComboBox6.Items.Add("Leave")
        ComboBox6.Items.Add("Sick")

        ComboBox7.Items.Add("Present")
        ComboBox7.Items.Add("Absent")
        ComboBox7.Items.Add("Leave")
        ComboBox7.Items.Add("Sick")

        ComboBox8.Items.Add("Present")
        ComboBox8.Items.Add("Absent")
        ComboBox8.Items.Add("Leave")
        ComboBox8.Items.Add("Sick")

        ComboBox9.Items.Add("Present")
        ComboBox9.Items.Add("Absent")
        ComboBox9.Items.Add("Leave")
        ComboBox9.Items.Add("Sick")

        ComboBox10.Items.Add("Present")
        ComboBox10.Items.Add("Absent")
        ComboBox10.Items.Add("Leave")
        ComboBox10.Items.Add("Sick")

        ComboBox11.Items.Add("Present")
        ComboBox11.Items.Add("Absent")
        ComboBox11.Items.Add("Leave")
        ComboBox11.Items.Add("Sick")

        ComboBox12.Items.Add("Present")
        ComboBox12.Items.Add("Absent")
        ComboBox12.Items.Add("Leave")
        ComboBox12.Items.Add("Sick")

        ComboBox13.Items.Add("Present")
        ComboBox13.Items.Add("Absent")
        ComboBox13.Items.Add("Leave")
        ComboBox13.Items.Add("Sick")

        ComboBox14.Items.Add("Present")
        ComboBox14.Items.Add("Absent")
        ComboBox14.Items.Add("Leave")
        ComboBox14.Items.Add("Sick")

        ComboBox15.Items.Add("Present")
        ComboBox15.Items.Add("Absent")
        ComboBox15.Items.Add("Leave")
        ComboBox15.Items.Add("Sick")

        ComboBox16.Items.Add("Present")
        ComboBox16.Items.Add("Absent")
        ComboBox16.Items.Add("Leave")
        ComboBox16.Items.Add("Sick")

        ComboBox17.Items.Add("Present")
        ComboBox17.Items.Add("Absent")
        ComboBox17.Items.Add("Leave")
        ComboBox17.Items.Add("Sick")

        ComboBox18.Items.Add("Present")
        ComboBox18.Items.Add("Absent")
        ComboBox18.Items.Add("Leave")
        ComboBox18.Items.Add("Sick")

        ComboBox19.Items.Add("Present")
        ComboBox19.Items.Add("Absent")
        ComboBox19.Items.Add("Leave")
        ComboBox19.Items.Add("Sick")

        ComboBox20.Items.Add("Present")
        ComboBox20.Items.Add("Absent")
        ComboBox20.Items.Add("Leave")
        ComboBox20.Items.Add("Sick")

        ComboBox21.Items.Add("Present")
        ComboBox21.Items.Add("Absent")
        ComboBox21.Items.Add("Leave")
        ComboBox21.Items.Add("Sick")


    End Sub
End Class
