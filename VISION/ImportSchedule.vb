Imports System.Data.OleDb
Public Class ImportSchedule
    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Private Form3 As New IgnouStStart
    WithEvents bsData As New BindingSource
    Private ConnectionNoHeader As String = "provider= Microsoft.ACE.OLEDB.12.0; data source='{0}';Extended Properties=""Excel 12.0; HDR=Yes;"""
    Private FileName As String = importsch.TextBox1.Text.Trim()
    Private SCH As String = importsch.TextBox2.Text.Trim()
    Dim Course As String

    Private Sub ImportSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        impsch()
        Me.CenterToScreen()
        Me.TopMost = True
        MsgBox(" EXCEL FILE SHOULD IN TEXT FORMAT WITH NOT ANY FIELD EMPTY")
         Try
            Using MyConnection As New OleDbConnection(String.Format(ConnectionNoHeader, FileName))
                Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
                Dim DtSet As System.Data.DataSet

                MyCommand = New System.Data.OleDb.OleDbDataAdapter _
                    ("select * from [Sheet1$]", MyConnection)
                MyCommand.TableMappings.Add("Table", "TestTable")
                DtSet = New System.Data.DataSet
                MyCommand.Fill(DtSet)
                Dim dt As New DataTable


                DataGridView1.DataSource = DtSet.Tables(0)
            End Using
        Catch ex As Exception
            MsgBox("Can't load " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TopMost = False
        Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
        Dim SchemaTable As DataTable
        Course = Convert.ToString(SCH & "SCHEDULE")
        Try
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & Course & ""})
            If SchemaTable.Rows.Count <> 0 Then
                AccessConnection.Close()
                Me.TopMost = False
                MsgBox("Your Input Course Name Exists" & " ..............YOU HAVE ENTERED :-  " & Course & "")
                Exit Sub
            Else
                Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim Conn As New OleDb.OleDbConnection(ConStr)
                Dim createTable As New OleDb.OleDbCommand
                createTable.Connection = Conn
                createTable.CommandType = CommandType.Text
                Dim cmd3 As New OleDb.OleDbCommand("CREATE TABLE [" & Course & "] ([SNO] INTEGER,[DATE_] Text(10),[Semister] TEXT(7),[Time_From] Text(15),[Time_To] Text(15), [Course_Code] TEXT(10),[Academic_Counselor] Text(100))", Conn)
                Conn.Open()
                cmd3.ExecuteNonQuery()
                Conn.Close()
                Dim D As String
                D = MsgBox("Do you Want to Save Imported Excel File ?", vbYesNo + vbQuestion, "Thanking You")
                If D = vbYes Then
                    Dim ISNO, ADATE_, BSemister, CTime_From, DTime_To, ECourse_Code, FAcademic_Counselor As String
                    For x As Integer = 0 To DataGridView1.Rows.Count - 1
                        ISNO = DataGridView1.Rows(x).Cells(0).Value.ToString
                        ADATE_ = DataGridView1.Rows(x).Cells(1).Value.ToString
                        BSemister = DataGridView1.Rows(x).Cells(2).Value.ToString
                        CTime_From = DataGridView1.Rows(x).Cells(3).Value.ToString
                        DTime_To = DataGridView1.Rows(x).Cells(4).Value.ToString
                        ECourse_Code = DataGridView1.Rows(x).Cells(5).Value.ToString
                        FAcademic_Counselor = DataGridView1.Rows(x).Cells(6).Value.ToString
                        Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                        Dim sqlquery As String = "INSERT INTO [" & Course & " ] (SNO, DATE_, Semister, Time_From, Time_To, Course_Code, Academic_Counselor) VALUES (@SNO, @DATE_, @Semister, @Time_From, @Time_To, @Course_Code, @Academic_Counselor)"
                        Using aconn = New System.Data.OleDb.OleDbConnection(cnString)
                            Using com = New System.Data.OleDb.OleDbCommand(sqlquery, aconn)
                                aconn.Open()
                                com.Parameters.AddWithValue("@SNO", ISNO.ToString)
                                com.Parameters.AddWithValue("@DATE_", ADATE_.ToString)
                                com.Parameters.AddWithValue("@Semister", BSemister.ToString)
                                com.Parameters.AddWithValue("@Time_From", CTime_From.ToString)
                                com.Parameters.AddWithValue("@Time_To", DTime_To.ToString)
                                com.Parameters.AddWithValue("@Course_Code", ECourse_Code.ToString)
                                com.Parameters.AddWithValue("@Academic_Counselor", FAcademic_Counselor.ToString)

                                com.ExecuteNonQuery()
                            End Using
                        End Using
                    Next
                    MessageBox.Show("Saved Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Can't load " & vbCrLf & ex.Message)
        End Try
       

       
        '(SNO, DATE_, Semister, Time_From, Time_To, Course_Code, Academic_Counselor) 
    End Sub
      

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        disp_all_tables.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
   
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class