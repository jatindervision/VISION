

Imports ADOX
Imports System.Data.OleDb
Public Class Lab

    Private Sub Lab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForLab()
        Me.CenterToParent()
        Me.TopMost = True
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Dim ConStr As String = "ProvIder=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\shx.mdb;Persist Security Info=True"
            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)
            Dim createTable As New OleDb.OleDbCommand



            createTable.Connection = Conn
            createTable.CommandType = CommandType.Text

            Dim cmd1 As New OleDb.OleDbCommand("INSERT INTO  Lab (CPU,LED,KEYBOARD,MOUSE,PRINTER,PC) values ('" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "','" & Me.TextBox5.Text & "','" & Me.TextBox6.Text & "','" & Me.TextBox7.Text & "')", Conn)
            Conn.Open()

            cmd1.ExecuteNonQuery()
            MessageBox.Show("Records Entered Successfully")
            Conn.Close()

            Me.Close()

        Catch ex As Exception
        End Try
    End Sub

 

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class