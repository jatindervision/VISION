Imports ADOX
Imports System.Data.OleDb
Public Class Collegename
    Dim Id As Integer = 1
    Private Sub Collegename_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForCollegename()
        Me.CenterToScreen()
        Me.TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or
            TextBox2.Text = "" Or
            TextBox3.Text = "" Or
            TextBox4.Text = "" Or
            TextBox5.Text = "" Or
            TextBox6.Text = "" Or
            TextBox7.Text = "" Or
            TextBox8.Text = "" Or
            TextBox9.Text = "" Or
            TextBox10.Text = "" Or
            TextBox11.Text = "" Or
            TextBox12.Text = "" Then
            MsgBox(" Fill All Fields !!")
            Exit Sub
        End If
        TextBox13.Text = 1
        Try

            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)
            Dim createTable As New OleDb.OleDbCommand

            createTable.Connection = Conn
            createTable.CommandType = CommandType.Text

            Dim cmd1 As New OleDb.OleDbCommand("INSERT INTO  [Name] values ('" & Me.TextBox13.Text.Trim & "','" & Me.TextBox12.Text & "','" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "','" & Me.TextBox5.Text & "','" & Me.TextBox6.Text & "','" & Me.TextBox7.Text & "','" & Me.TextBox8.Text & "','" & Me.TextBox9.Text & "','" & Me.TextBox10.Text & "','" & Me.TextBox11.Text & "')", Conn)
            Conn.Open()
            cmd1.ExecuteNonQuery()
            MessageBox.Show("College Name Entered Successfully")
            Conn.Close()
            Me.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

