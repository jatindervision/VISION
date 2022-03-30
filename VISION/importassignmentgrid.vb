Imports System.Data.OleDb
Public Class importassignmentgrid
    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Private Form3 As New IgnouStStart
    WithEvents bsData As New BindingSource
    Private ConnectionNoHeader As String = "provider= Microsoft.ACE.OLEDB.12.0; data source='{0}';Extended Properties=""Excel 12.0; HDR=Yes;"""
    Private FileName As String = importassmarks.TextBox1.Text.Trim()
    Private ccrse As String = importassmarks.TextBox2.Text.Trim()
    Dim Course As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        disp_all_tables.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Course = Convert.ToString(ccrse & "AssignmentMarks")
        Me.TopMost = False
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            Dim SchemaTable2 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & Course & ""})
            SchemaTable2 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "AEvaluator"})

            If SchemaTable1.Rows.Count <> 0 And SchemaTable2.Rows.Count <> 0 Then
                ' DELETE RECORD FROM BOTH 
                '    INSERT RECORD IN BOTH
                MsgBox("Exists and Now Packed , AGAIN REPAET PROCESS")
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table [" & Course & "]")
                Dim cmd8 As New OleDb.OleDbCommand("DROP  Table AEvaluator")
                cmd7.Connection = AccessConnection
                cmd8.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                cmd8.ExecuteNonQuery()
                AccessConnection.Close()
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text

                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" & Course & "] ([SNO] INTEGER,[ENROLL] INTEGER,[PROGRAM] TEXT(10), [STUDENT_NAME] TEXT(100),[CRS1] TEXT(10),[CRS2] TEXT(10),[CRS3] TEXT(10),[CRS4] TEXT(10),[CRS5] TEXT(10),[CRS6] TEXT(10),[CRS7] TEXT(10),[CRS8] TEXT(10),[CRS9] TEXT(10),[CRS10] TEXT(10),[CRS11] TEXT(10),[CRS12] TEXT(10),[CRS13] TEXT(10),[MM] TEXT(6))", Conn)
                    Dim cmd2 As New OleDb.OleDbCommand("CREATE TABLE [AEvaluator] ([CRS1] TEXT(30),[CRS2] TEXT(30),[CRS3] TEXT(30),[CRS4] TEXT(30),[CRS5] TEXT(30),[CRS6] TEXT(30),[CRS7] TEXT(30),[CRS8] TEXT(30),[CRS9] TEXT(30),[CRS10] TEXT(30),[CRS11] TEXT(30),[CRS12] TEXT(30),[CRS13] TEXT(30))", Conn)
                    'Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [AssignmentMarks] ([SNO]) WITH PRIMARY", Conn)
                    'cmd1.CommandType = System.Data.CommandType.Text
                    cmd.Connection = Conn
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                    Conn.Close()
                    Dim D As String
                    D = MsgBox("Do you Want to Save Imported Excel File ?", vbYesNo + vbQuestion, "Thanking You")
                    If D = vbYes Then
                        Dim ASNO, BENRNO, CPROGRAM, DSTNAME, ECRS1, FCRS2, GCRS3, HCRS4, ICRS5, JCRS6, KCRS7, LCRS8, MCRS9, NCRS10, OCRS11, PCRS12, QCRS13, RMM As String
                        For x As Integer = 0 To DataGridView1.Rows.Count - 1 Step 1
                            ASNO = DataGridView1.Rows(x).Cells(0).Value.ToString
                            BENRNO = DataGridView1.Rows(x).Cells(1).Value.ToString
                            CPROGRAM = DataGridView1.Rows(x).Cells(2).Value.ToString
                            DSTNAME = DataGridView1.Rows(x).Cells(3).Value.ToString
                            ECRS1 = DataGridView1.Rows(x).Cells(4).Value.ToString
                            FCRS2 = DataGridView1.Rows(x).Cells(5).Value.ToString
                            GCRS3 = DataGridView1.Rows(x).Cells(6).Value.ToString
                            HCRS4 = DataGridView1.Rows(x).Cells(7).Value.ToString
                            ICRS5 = DataGridView1.Rows(x).Cells(8).Value.ToString
                            JCRS6 = DataGridView1.Rows(x).Cells(9).Value.ToString
                            KCRS7 = DataGridView1.Rows(x).Cells(10).Value.ToString
                            LCRS8 = DataGridView1.Rows(x).Cells(11).Value.ToString
                            MCRS9 = DataGridView1.Rows(x).Cells(12).Value.ToString
                            NCRS10 = DataGridView1.Rows(x).Cells(13).Value.ToString
                            OCRS11 = DataGridView1.Rows(x).Cells(14).Value.ToString
                            PCRS12 = DataGridView1.Rows(x).Cells(15).Value.ToString
                            QCRS13 = DataGridView1.Rows(x).Cells(16).Value.ToString
                            RMM = DataGridView1.Rows(x).Cells(17).Value.ToString
                            Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                            Dim sqlquery As String = "INSERT INTO [" & Course & " ] (SNO, ENROLL, PROGRAM, STUDENT_NAME, CRS1, CRS2, CRS3, CRS4, CRS5, CRS6, CRS7, CRS8, CRS9, CRS10, CRS11, CRS12, CRS13, MM) VALUES (@SNO, @ENROLL, @PROGRAM, @STUDENT_NAME, @CRS1, @CRS2, @CRS3, @CRS4, @CRS5, @CRS6, @CRS7, @CRS8, @CRS9, @CRS10, @CRS11, @CRS12, @CRS13, @MM)"
                            Using aconn = New System.Data.OleDb.OleDbConnection(cnString)
                                Using com = New System.Data.OleDb.OleDbCommand(sqlquery, aconn)
                                    aconn.Open()
                                    com.Parameters.AddWithValue("@SNO", ASNO.ToString)
                                    com.Parameters.AddWithValue("@ENROLL", BENRNO.ToString)
                                    com.Parameters.AddWithValue("@PROGRAM", CPROGRAM.ToString)
                                    com.Parameters.AddWithValue("@STUDENT_NAME", DSTNAME.ToString)
                                    com.Parameters.AddWithValue("@CRS1", ECRS1.ToString)
                                    com.Parameters.AddWithValue("@CRS2", FCRS2.ToString)
                                    com.Parameters.AddWithValue("@CRS3", GCRS3.ToString)
                                    com.Parameters.AddWithValue("@CRS4", HCRS4.ToString)
                                    com.Parameters.AddWithValue("@CRS5", ICRS5.ToString)
                                    com.Parameters.AddWithValue("@CRS6", JCRS6.ToString)
                                    com.Parameters.AddWithValue("@CRS7", KCRS7.ToString)
                                    com.Parameters.AddWithValue("@CRS8", LCRS8.ToString)
                                    com.Parameters.AddWithValue("@CRS9", MCRS9.ToString)
                                    com.Parameters.AddWithValue("@CRS10", NCRS10.ToString)
                                    com.Parameters.AddWithValue("@CRS11", OCRS11.ToString)
                                    com.Parameters.AddWithValue("@CRS12", PCRS12.ToString)
                                    com.Parameters.AddWithValue("@CRS13", QCRS13.ToString)
                                    com.Parameters.AddWithValue("@MM", RMM.ToString)

                                    com.ExecuteNonQuery()
                                End Using
                            End Using
                        Next x
                        MessageBox.Show("Saved Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox("CAN NOT INSERT  " & vbCrLf & ex.Message)
                End Try
            End If
        Catch ex As Exception
        End Try



    End Sub

    Private Sub importassignmentgrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GRIDAAS()
        Me.CenterToScreen()
        Me.TopMost = True
        ' SNO	ENRNO	PROGRAM	STUDENT_NAME	CRS1	CRS2	CRS3	CRS4	CRS5	CRS6	CRS7	CRS8	CRS9	CRS10	CRS11	CRS12	CRS13	MM

        Try
            Using MyConnection As New OleDbConnection(String.Format(ConnectionNoHeader, FileName))
                MyConnection.Open()
                Dim CommandText = <SQL>  SELECT  SNO, ENRNO, PROGRAM, STUDENT_NAME, CRS1, CRS2, CRS3, CRS4, CRS5, CRS6, CRS7, CRS8, CRS9, CRS10, CRS11, CRS12, CRS13, MM  FROM [Sheet1$]    </SQL>.Value

                Dim cmd As OleDbCommand = New OleDbCommand(CommandText, MyConnection)
                Dim dr As System.Data.IDataReader = cmd.ExecuteReader
                Dim dt As New DataTable
                dt.Load(dr)
                bsData.DataSource = dt
            End Using
            BindingNavigator1.BindingSource = bsData
            DataGridView1.DataSource = bsData
            DataGridView1.Columns("SNO").HeaderText = "SNO"
            DataGridView1.Columns("ENRNO").HeaderText = "ENRNO"
            DataGridView1.Columns("PROGRAM").HeaderText = "PROGRAM"
            DataGridView1.Columns("STUDENT_NAME").HeaderText = "STUDENT_NAME"
            DataGridView1.Columns("CRS1").HeaderText = "CRS1"
            DataGridView1.Columns("CRS2").HeaderText = "CRS2"
            DataGridView1.Columns("CRS3").HeaderText = "CRS3"
            DataGridView1.Columns("CRS4").HeaderText = "CRS4"
            DataGridView1.Columns("CRS5").HeaderText = "CRS5"
            DataGridView1.Columns("CRS6").HeaderText = "CRS6"
            DataGridView1.Columns("CRS7").HeaderText = "CRS7"
            DataGridView1.Columns("CRS8").HeaderText = "CRS8"
            DataGridView1.Columns("CRS9").HeaderText = "CRS9"
            DataGridView1.Columns("CRS10").HeaderText = "CRS10"
            DataGridView1.Columns("CRS11").HeaderText = "CRS11"
            DataGridView1.Columns("CRS12").HeaderText = "CRS12"
            DataGridView1.Columns("CRS13").HeaderText = "CRS13"
            DataGridView1.Columns("MM").HeaderText = "MM"
        Catch ex As Exception
            MsgBox("Can't load " & vbCrLf & ex.Message)
        End Try
    End Sub
End Class