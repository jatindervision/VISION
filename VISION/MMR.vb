Imports System
Imports System.Data.OleDb
Public Class MMR
    Dim Str As String
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim source2 As New BindingSource
    Private Sub MMR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FMMR()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
          MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da = New OleDbDataAdapter("SELECT * from Name", MyConn)
            da.Fill(ds, "Name")
            Label39.Text = ds.Tables("Name").Rows(0).Item(5)
            Label1.Text = ds.Tables("Name").Rows(0).Item(9)
            MyConn.Close()
        Catch ex As Exception
        End Try
        TextBox1.Text = " NIL "
        TextBox2.Text = " NIL "
        TextBox3.Text = " NIL "
        TextBox4.Text = " NIL "
        TextBox5.Text = " NIL "
        TextBox6.Text = " NIL "
        TextBox7.Text = " NIL "
        TextBox8.Text = " NIL "
        TextBox9.Text = " NIL "
        TextBox10.Text = " NIL "
        TextBox11.Text = " NIL "
        TextBox12.Text = " NIL "
        TextBox13.Text = " NIL "
        TextBox14.Text = " NIL "
        TextBox15.Text = " NIL "
        TextBox16.Text = " NIL "
        TextBox17.Text = " NIL "
        TextBox18.Text = " NIL "
        TextBox19.Text = " NIL "
        TextBox20.Text = " NIL "
        TextBox21.Text = " NIL "
        TextBox22.Text = " NIL "
        TextBox23.Text = " NIL "
        TextBox24.Text = " NIL "
        TextBox25.Text = " NIL "
        TextBox26.Text = " NIL "
        TextBox27.Text = " NIL "
        TextBox28.Text = " NIL "
        TextBox29.Text = " NIL "
        TextBox30.Text = " NIL "
        TextBox31.Text = " NIL "
        TextBox32.Text = " NIL "
        TextBox33.Text = " NIL "
        TextBox34.Text = " NIL "
        TextBox35.Text = " NIL "
      
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" And TextBox6.Text = "" And TextBox7.Text = "" And TextBox8.Text = "" And TextBox9.Text = "" And TextBox10.Text = "" And TextBox11.Text = "" And TextBox12.Text = "" And TextBox13.Text = "" And TextBox14.Text = "" And TextBox15.Text = "" And TextBox16.Text = "" And TextBox17.Text = "" And TextBox18.Text = "" And TextBox19.Text = "" And TextBox20.Text = "" And TextBox21.Text = "" And TextBox22.Text = "" And TextBox23.Text = "" And TextBox24.Text = "" And TextBox25.Text = "" And TextBox26.Text = "" And TextBox27.Text = "" And TextBox28.Text = "" And TextBox29.Text = "" And TextBox30.Text = "" And TextBox31.Text = "" And TextBox32.Text = "" And TextBox33.Text = "" And TextBox34.Text = "" And TextBox35.Text = "" Then
            MsgBox("FILL ALL FIELDS , AS FOR YOUR CONVIENCE NIL IS ALREADY FILLED !!")
            Exit Sub
        End If

        Try
            Str = "insert into [MMR] values("
            Str += """" & Label1.Text.Trim() & """"
            Str += ","
            Str += """" & Label39.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox1.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox2.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox3.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox4.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox5.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox6.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox7.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox8.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox9.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox10.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox11.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox12.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox13.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox14.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox15.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox16.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox17.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox18.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox19.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox20.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox21.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox22.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox23.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox24.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox25.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox26.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox27.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox28.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox29.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox30.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox31.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox32.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox33.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox34.Text.Trim() & """"
            Str += ","
            Str += """" & TextBox35.Text.Trim() & """"
            Str += ")"
            Con.Open()
            Cmd = New OleDbCommand(Str, Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("Could Not Insert Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        VIEWMMR.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class