Imports ADOX
Imports System.Data.OleDb
Public Class finalbillstart

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub finalbillstart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim x As Integer
        'Dim y As Integer
        'x = Screen.PrimaryScreen.WorkingArea.Width - 50
        'y = Screen.PrimaryScreen.WorkingArea.Height - 50
        Me.Location = New Point(0, 60)
        billff()
        Me.TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
     

            If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" And TextBox6.Text = "" And TextBox7.Text = "" And TextBox8.Text = "" And TextBox9.Text = "" And TextBox10.Text = "" And TextBox11.Text = "" And TextBox12.Text = "" Then
                MsgBox("FILL ALL THE FIELDS ")
                Exit Sub
            End If
            Try
                Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
                Dim SchemaTable1 As DataTable
                Dim SchemaTable2 As DataTable
                AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                AccessConnection.Open()

                SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "TOPBILLP1"})
                SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "P1BOTTOMBILL"})
                If SchemaTable1.Rows.Count <> 0 And SchemaTable2.Rows.Count <> 0 Then
                    ' DELETE RECORD FROM BOTH 
                    '    INSERT RECORD IN BOTH
                    MsgBox("Exists and Now Packed USE THIS BUTTON AGAIN")
                    Dim cmd7 As New OleDb.OleDbCommand("DROP  Table TOPBILLP1")
                    Dim cmd8 As New OleDb.OleDbCommand("DROP  Table P1BOTTOMBILL")
                    cmd7.Connection = AccessConnection
                    cmd8.Connection = AccessConnection
                    cmd7.ExecuteNonQuery()
                    cmd8.ExecuteNonQuery()
                    AccessConnection.Close()
                    Exit Sub
                Else

                    Try
                        Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                        Dim Conn As New OleDb.OleDbConnection(ConStr)
                        Dim createTable As New OleDb.OleDbCommand
                        createTable.Connection = Conn
                        createTable.CommandType = CommandType.Text

                        Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [TOPBILLP1] ([UName] TEXT(100),[Uadd1] TEXT(60),[Uadd2] TEXT(60),[Place] TEXT(15),[COLLEGE] TEXT(100),[CODE] TEXT(15),[COURSE_NAME] TEXT(6),[TotalA] TEXT(15),[Aminwords] TEXT(100),[Session] TEXT(15),[one] TEXT(6),[Two] TEXT(6),[Three] TEXT(6),[Four] TEXT(6),[Five] TEXT(6),[Six] Text(6),[Seven] TEXT(6),[Eight] TEXT(6),[Nine] Text(6))", Conn)
                        Dim cmd3 As New OleDb.OleDbCommand("CREATE TABLE [P1BOTTOMBILL] ([Course_Code] TEXT(10),[Course_FullName] TEXT(100),[Sessions] TEXT(15),[Hrs] TEXT(15),[Amount] TEXT(10))", Conn)
                        cmd1.Connection = Conn
                        cmd3.Connection = Conn
                        Conn.Open()
                        cmd1.ExecuteNonQuery()
                        cmd3.ExecuteNonQuery()
                        Conn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message & " -  " & ex.Source)
                    End Try
                End If
            Catch ex As Exception
                MsgBox(ex.Message & " -  " & ex.Source)
            End Try
            BILL.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BILL.Close()
        BILLPAGE2.Close()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
      
            If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" And TextBox6.Text = "" And TextBox7.Text = "" And TextBox8.Text = "" And TextBox9.Text = "" And TextBox10.Text = "" And TextBox11.Text = "" And TextBox12.Text = "" Then
                MsgBox("FILL ALL THE FIELDS ")
                Exit Sub
            End If
            Try
                Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
                Dim SchemaTable1 As DataTable
                Dim SchemaTable2 As DataTable
                AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                AccessConnection.Open()

                SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "TOPBILLP2"})
                SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "P2BOTTOMBILL"})
                If SchemaTable1.Rows.Count <> 0 And SchemaTable2.Rows.Count <> 0 Then
                    ' DELETE RECORD FROM BOTH 
                    '    INSERT RECORD IN BOTH
                    MsgBox("Exists and Now Packed USE THIS BUTTON AGAIN")
                    Dim cmd7 As New OleDb.OleDbCommand("DROP  Table TOPBILLP2")
                    Dim cmd8 As New OleDb.OleDbCommand("DROP  Table P2BOTTOMBILL")
                    cmd7.Connection = AccessConnection
                    cmd8.Connection = AccessConnection
                    cmd7.ExecuteNonQuery()
                    cmd8.ExecuteNonQuery()
                    AccessConnection.Close()
                    Exit Sub
                Else

                    Try
                        Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                        Dim Conn As New OleDb.OleDbConnection(ConStr)
                        Dim createTable As New OleDb.OleDbCommand
                        createTable.Connection = Conn
                        createTable.CommandType = CommandType.Text

                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [TOPBILLP2] ([H1COURSE] TEXT(10),[H1COURSECODE] TEXT(10),[H1AMOUNT] TEXT(10),[H2COURSE] TEXT(10),[H2COURSECODE] TEXT(10),[H2AMOUNT] TEXT(10),[H3COURSE] TEXT(10),[H3COURSECODE] TEXT(10),[H3AMOUNT] TEXT(10),[H4COURSE] TEXT(10),[H4COURSECODE] TEXT(10),[H4AMOUNT] TEXT(10),[M1COURSE] TEXT(10),[M1COURSECODE] TEXT(10),[M1SESSIONS] TEXT(15),[M1AMOUNT] TEXT(10),[M2COURSE] TEXT(10),[M2COURSECODE] TEXT(10),[M2SESSIONS] TEXT(15),[M2AMOUNT] TEXT(10),[M3COURSE] TEXT(10),[M3COURSECODE] TEXT(10),[M3SESSIONS] TEXT(15),[M3AMOUNT] TEXT(10),[M4COURSE] TEXT(10),[M4COURSECODE] TEXT(10),[M4SESSIONS] TEXT(15),[M4AMOUNT] TEXT(10),[TAMOUNT] TEXT(15))", Conn)

                        Dim cmd3 As New OleDb.OleDbCommand("CREATE TABLE [P2BOTTOMBILL] ([Course_Code] TEXT(10),[Course_FullName] TEXT(100),[Amount] TEXT(10))", Conn)

                        cmd1.Connection = Conn
                        cmd3.Connection = Conn
                        Conn.Open()
                        cmd1.ExecuteNonQuery()
                        cmd3.ExecuteNonQuery()
                        Conn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message & " -  " & ex.Source)
                    End Try
                End If
            Catch ex As Exception
                MsgBox(ex.Message & " -  " & ex.Source)
            End Try
            BILLPAGE2.Show()

    End Sub
End Class