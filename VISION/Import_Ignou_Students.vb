Imports System.Data.OleDb
Public Class Import_Ignou_Students
    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Private Form2 As New IgnouStStart
    WithEvents bsData As New BindingSource
    Private ConnectionNoHeader As String = "provider= Microsoft.ACE.OLEDB.12.0; data source='{0}';Extended Properties=""Excel 12.0; HDR=Yes;"""
    Private FileName As String = IgnouStStart.ExcelFileName.Text
    Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
    Dim SchemaTable As DataTable
    Private StatusDate As String
    Private Course As String

    Private Sub Import_Ignou_Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Forignoufirstdirect()
        Me.CenterToScreen()
        Me.TopMost = True

        Try
            Using MyConnection As New OleDbConnection(String.Format(ConnectionNoHeader, FileName))
                MyConnection.Open()
                ' SNO	ENRNO	PROGRAM	MEDIUM	STUDY	NAME	FNAME	ADD1	ADD2	ADD3	CITY	STATE	PIN	STD	TEL	FAXSTD	FAX	EMAIL	CRS1	CRS2	CRS3	CRS4	CRS5	CRS6	CRS7	CRS8	CRS9	CRS10	CRS11	CRS12	CRS13	MOBILE
                Dim CommandText = <SQL>  SELECT  SNO,	ENRNO,	PROGRAM	,MEDIUM	,STUDY,	NAME,	FNAME,	ADD1	,ADD2	,ADD3	,CITY	,STATE,	PIN	,STD,	TEL,	FAXSTD,	FAX	,EMAIL,	CRS1	,CRS2,	CRS3,	CRS4,	CRS5,	CRS6,	CRS7	,CRS8,	CRS9,	CRS10	,CRS11	,CRS12,	CRS13,	MOBILE FROM [Sheet1$]    </SQL>.Value

                Dim cmd As OleDbCommand = New OleDbCommand(CommandText, MyConnection)
                Dim dr As System.Data.IDataReader = cmd.ExecuteReader
                Dim dt As New DataTable
                dt.Load(dr)
                bsData.DataSource = dt

            End Using

            BindingNavigator1.BindingSource = bsData
            DataGridView1.DataSource = bsData


            'SNo	ENRNO	PROGRAM	MEDIUM	STUDY	NAME	FNAME	ADD1	ADD2	ADD3	
            'CITY	STATE	PIN	STD	TEL	FAXSTD	FAX	EMAIL	CRS1	CRS2	CRS3	CRS4	CRS5	CRS6	CRS7	CRS8	CRS9	
            'CRS10	CRS11	CRS12	CRS13	MOBILE

            DataGridView1.Columns("SNO").HeaderText = "SNO"
            DataGridView1.Columns("ENRNO").HeaderText = "ENRNO"
            DataGridView1.Columns("PROGRAM").HeaderText = "PROGRAM"
            DataGridView1.Columns("MEDIUM").HeaderText = "MEDIUM"
            DataGridView1.Columns("STUDY").HeaderText = "STUDY"
            DataGridView1.Columns("NAME").HeaderText = "NAME"
            DataGridView1.Columns("FNAME").HeaderText = "FNAME"
            DataGridView1.Columns("ADD1").HeaderText = "ADD1"
            DataGridView1.Columns("ADD2").HeaderText = "ADD2"
            DataGridView1.Columns("ADD3").HeaderText = "ADD3"
            DataGridView1.Columns("CITY").HeaderText = "CITY"
            DataGridView1.Columns("STATE").HeaderText = "STATE"
            DataGridView1.Columns("PIN").HeaderText = "PIN"
            DataGridView1.Columns("STD").HeaderText = "STD"
            DataGridView1.Columns("TEL").HeaderText = "TEL"
            DataGridView1.Columns("FAXSTD").HeaderText = "FAXID"
            DataGridView1.Columns("FAX").HeaderText = "FAX"
            DataGridView1.Columns("EMAIL").HeaderText = "EMAIL"
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
            DataGridView1.Columns("MOBILE").HeaderText = "MOBILE"

        Catch ex As Exception
            MsgBox("Can't load " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IgnouStStart.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TopMost = False
       
        StatusDate = InputBox("Enter Course Name ?", "{e.g MCA or MCOM etc", "  ")
        Course = Convert.ToString(StatusDate)
        Try
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            'Retrieve schema information about Table1.
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & Course & ""})
            If SchemaTable.Rows.Count <> 0 Then

                Me.TopMost = False
                MsgBox("Your Input Course Name Exists" & " ..............YOU HAVE ENTERED :-  " & Course & "")
                Dim D As String
                D = MsgBox("Do you Want to Save Imported Excel File ?", vbYesNo + vbQuestion, "Thanking You")
                If D = vbYes Then
                    Dim ISNO, IENRNO, IPIN As Integer
                    Dim IPROGRAM, IMEDIUM, ISTUDY, INAME, IFNAME, IADD1, IADD2, IADD3, ICITY, ISTATE, ISTD, ITEL, IFAXSTD, IFAX, IEMAIL, ICRS1, ICRS2, ICRS3, ICRS4, ICRS5, ICRS6, ICRS7, ICRS8, ICRS9, ICRS10, ICRS11, ICRS12, ICRS13, IMOBILE As String
                    For x As Integer = 0 To DataGridView1.Rows.Count - 1
                        ISNO = DataGridView1.Rows(x).Cells(0).Value
                        IENRNO = DataGridView1.Rows(x).Cells(1).Value.ToString
                        IPROGRAM = DataGridView1.Rows(x).Cells(2).Value.ToString
                        IMEDIUM = DataGridView1.Rows(x).Cells(3).Value.ToString
                        ISTUDY = DataGridView1.Rows(x).Cells(4).Value.ToString
                        INAME = DataGridView1.Rows(x).Cells(5).Value.ToString
                        IFNAME = DataGridView1.Rows(x).Cells(6).Value.ToString
                        IADD1 = DataGridView1.Rows(x).Cells(7).Value.ToString
                        IADD2 = DataGridView1.Rows(x).Cells(8).Value.ToString
                        IADD3 = DataGridView1.Rows(x).Cells(9).Value.ToString
                        ICITY = DataGridView1.Rows(x).Cells(10).Value.ToString
                        ISTATE = DataGridView1.Rows(x).Cells(11).Value.ToString
                        IPIN = DataGridView1.Rows(x).Cells(12).Value.ToString
                        ISTD = DataGridView1.Rows(x).Cells(13).Value.ToString
                        ITEL = DataGridView1.Rows(x).Cells(14).Value.ToString
                        IFAXSTD = DataGridView1.Rows(x).Cells(15).Value.ToString
                        IFAX = DataGridView1.Rows(x).Cells(16).Value.ToString
                        IEMAIL = DataGridView1.Rows(x).Cells(17).Value.ToString
                        ICRS1 = DataGridView1.Rows(x).Cells(18).Value.ToString
                        ICRS2 = DataGridView1.Rows(x).Cells(19).Value.ToString
                        ICRS3 = DataGridView1.Rows(x).Cells(20).Value.ToString
                        ICRS4 = DataGridView1.Rows(x).Cells(21).Value.ToString
                        ICRS5 = DataGridView1.Rows(x).Cells(22).Value.ToString
                        ICRS6 = DataGridView1.Rows(x).Cells(23).Value.ToString
                        ICRS7 = DataGridView1.Rows(x).Cells(24).Value.ToString
                        ICRS8 = DataGridView1.Rows(x).Cells(25).Value.ToString
                        ICRS9 = DataGridView1.Rows(x).Cells(25).Value.ToString
                        ICRS10 = DataGridView1.Rows(x).Cells(27).Value.ToString
                        ICRS11 = DataGridView1.Rows(x).Cells(28).Value.ToString
                        ICRS12 = DataGridView1.Rows(x).Cells(29).Value.ToString
                        ICRS13 = DataGridView1.Rows(x).Cells(30).Value.ToString
                        IMOBILE = DataGridView1.Rows(x).Cells(31).Value.ToString

                        Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                        Dim sqlquery As String = "INSERT INTO " & Course & " (SNO, ENRNO, PROGRAM, MEDIUM, STUDY, NAME, FNAME, ADD1, ADD2, ADD3, CITY, STATE, PIN, STD, TEL, FAXSTD, FAX, EMAIL, CRS1, CRS2, CRS3, CRS4, CRS5, CRS6, CRS7, CRS8, CRS9, CRS10, CRS11, CRS12, CRS13, MOBILE) VALUES (@SNO, @ENRNO, @PROGRAM, @MEDIUM, @STUDY, @NAME, @FNAME, @ADD1, @ADD2, @ADD3, @CITY, @STATE, @PIN, @STD, @TEL, @FAXSTD, @FAX, @EMAIL, @CRS1, @CRS2, @CRS3, @CRS4, @CRS5, @CRS6, @CRS7, @CRS8, @CRS9, @CRS10, @CRS11, @CRS12, @CRS13, @MOBILE)"
                        Using conn = New System.Data.OleDb.OleDbConnection(cnString)
                            Using com = New System.Data.OleDb.OleDbCommand(sqlquery, conn)
                                conn.Open()
                                com.Parameters.AddWithValue("@SNO", ISNO.ToString)
                                com.Parameters.AddWithValue("@ENRNO", IENRNO.ToString)
                                com.Parameters.AddWithValue("@PROGRAM", IPROGRAM.ToString)
                                com.Parameters.AddWithValue("@MEDIUM", IMEDIUM.ToString)
                                com.Parameters.AddWithValue("@STUDY", ISTUDY.ToString)
                                com.Parameters.AddWithValue("@NAME", INAME.ToString)
                                com.Parameters.AddWithValue("@FNAME", IFNAME.ToString)
                                com.Parameters.AddWithValue("@ADD1", IADD1.ToString)
                                com.Parameters.AddWithValue("@ADD2", IADD2.ToString)
                                com.Parameters.AddWithValue("@ADD3", IADD3.ToString)
                                com.Parameters.AddWithValue("@CITY", ICITY.ToString)
                                com.Parameters.AddWithValue("@STATE", ISTATE.ToString)
                                com.Parameters.AddWithValue("@PIN", IPIN.ToString)
                                com.Parameters.AddWithValue("@STD", ISTD.ToString)
                                com.Parameters.AddWithValue("@TEL", ITEL.ToString)
                                com.Parameters.AddWithValue("@FAXSTD", IFAXSTD.ToString)
                                com.Parameters.AddWithValue("@FAX", IFAX.ToString)
                                com.Parameters.AddWithValue("@EMAIL", IEMAIL.ToString)
                                com.Parameters.AddWithValue("@CRS1", ICRS1.ToString)
                                com.Parameters.AddWithValue("@CRS2", ICRS2.ToString)
                                com.Parameters.AddWithValue("@CRS3", ICRS3.ToString)
                                com.Parameters.AddWithValue("@CRS4", ICRS4.ToString)
                                com.Parameters.AddWithValue("@CRS5", ICRS5.ToString)
                                com.Parameters.AddWithValue("@CRS6", ICRS6.ToString)
                                com.Parameters.AddWithValue("@CRS7", ICRS7.ToString)
                                com.Parameters.AddWithValue("@CRS8", ICRS8.ToString)
                                com.Parameters.AddWithValue("@CRS9", ICRS9.ToString)
                                com.Parameters.AddWithValue("@CRS10", ICRS10.ToString)
                                com.Parameters.AddWithValue("@CRS11", ICRS11.ToString)
                                com.Parameters.AddWithValue("@CRS12", ICRS12.ToString)
                                com.Parameters.AddWithValue("@CRS13", ICRS13.ToString)
                                com.Parameters.AddWithValue("@MOBILE", IMOBILE.ToString)
                                com.ExecuteNonQuery()
                            End Using
                        End Using
                    Next
                    MessageBox.Show("Saved Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Exit Sub
                End If
            Else
                Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim Conn As New OleDb.OleDbConnection(ConStr)
                Dim createTable As New OleDb.OleDbCommand
                createTable.Connection = Conn
                createTable.CommandType = CommandType.Text

                Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [" + Course + "] ([SNO] INTEGER,[ENRNO] INTEGER, [PROGRAM] TEXT(10), [MEDIUM] TEXT(6), [STUDY] TEXT(10), [NAME] TEXT(30), [FNAME] TEXT(30), [ADD1] TEXT (150), [ADD2] TEXT(150), [ADD3] TEXT(150), [CITY] TEXT(15), [STATE] TEXT(30), [PIN] INTEGER, [STD] TEXT(10), [TEL] TEXT(12), [FAXSTD] TEXT(10), [FAX] TEXT(12), [EMAIL] TEXT(30), [CRS1] TEXT(10), [CRS2] TEXT(10), [CRS3] TEXT(10), [CRS4] TEXT(10), [CRS5] TEXT(10), [CRS6] TEXT(10), [CRS7] TEXT(10), [CRS8] TEXT(10), [CRS9] TEXT(10), [CRS10] TEXT(10), [CRS11] TEXT(10), [CRS12] TEXT(10), [CRS13] TEXT(10), MOBILE TEXT(10))", Conn)
                ' Dim cmd1 As New OleDb.OleDbCommand("create index [PrimaryKey] on [" & Course & "] ([ENRNO]) WITH PRIMARY", Conn)
                Conn.Open()
                cmd.ExecuteNonQuery()
                Conn.Close()
                ' cHECK TABLE EXISTS OR NOT 

                Dim D As String
                D = MsgBox("Do you Want to Save Imported Excel File ?", vbYesNo + vbQuestion, "Thanking You")
                If D = vbYes Then
                    Dim ISNO, IENRNO, IPIN As Integer
                    Dim IPROGRAM, IMEDIUM, ISTUDY, INAME, IFNAME, IADD1, IADD2, IADD3, ICITY, ISTATE, ISTD, ITEL, IFAXSTD, IFAX, IEMAIL, ICRS1, ICRS2, ICRS3, ICRS4, ICRS5, ICRS6, ICRS7, ICRS8, ICRS9, ICRS10, ICRS11, ICRS12, ICRS13, IMOBILE As String
                    For x As Integer = 0 To DataGridView1.Rows.Count - 1

                        ISNO = DataGridView1.Rows(x).Cells(0).Value
                        IENRNO = DataGridView1.Rows(x).Cells(1).Value.ToString
                        IPROGRAM = DataGridView1.Rows(x).Cells(2).Value.ToString
                        IMEDIUM = DataGridView1.Rows(x).Cells(3).Value.ToString
                        ISTUDY = DataGridView1.Rows(x).Cells(4).Value.ToString
                        INAME = DataGridView1.Rows(x).Cells(5).Value.ToString
                        IFNAME = DataGridView1.Rows(x).Cells(6).Value.ToString
                        IADD1 = DataGridView1.Rows(x).Cells(7).Value.ToString
                        IADD2 = DataGridView1.Rows(x).Cells(8).Value.ToString
                        IADD3 = DataGridView1.Rows(x).Cells(9).Value.ToString
                        ICITY = DataGridView1.Rows(x).Cells(10).Value.ToString
                        ISTATE = DataGridView1.Rows(x).Cells(11).Value.ToString
                        IPIN = DataGridView1.Rows(x).Cells(12).Value.ToString
                        ISTD = DataGridView1.Rows(x).Cells(13).Value.ToString
                        ITEL = DataGridView1.Rows(x).Cells(14).Value.ToString
                        IFAXSTD = DataGridView1.Rows(x).Cells(15).Value.ToString
                        IFAX = DataGridView1.Rows(x).Cells(16).Value.ToString
                        IEMAIL = DataGridView1.Rows(x).Cells(17).Value.ToString
                        ICRS1 = DataGridView1.Rows(x).Cells(18).Value.ToString
                        ICRS2 = DataGridView1.Rows(x).Cells(19).Value.ToString
                        ICRS3 = DataGridView1.Rows(x).Cells(20).Value.ToString
                        ICRS4 = DataGridView1.Rows(x).Cells(21).Value.ToString
                        ICRS5 = DataGridView1.Rows(x).Cells(22).Value.ToString
                        ICRS6 = DataGridView1.Rows(x).Cells(23).Value.ToString
                        ICRS7 = DataGridView1.Rows(x).Cells(24).Value.ToString
                        ICRS8 = DataGridView1.Rows(x).Cells(25).Value.ToString
                        ICRS9 = DataGridView1.Rows(x).Cells(25).Value.ToString
                        ICRS10 = DataGridView1.Rows(x).Cells(27).Value.ToString
                        ICRS11 = DataGridView1.Rows(x).Cells(28).Value.ToString
                        ICRS12 = DataGridView1.Rows(x).Cells(29).Value.ToString
                        ICRS13 = DataGridView1.Rows(x).Cells(30).Value.ToString
                        IMOBILE = DataGridView1.Rows(x).Cells(31).Value.ToString

                        Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                        Dim squery As String = "INSERT INTO " & Course & " (SNO, ENRNO, PROGRAM, MEDIUM, STUDY, NAME, FNAME, ADD1, ADD2, ADD3, CITY, STATE, PIN, STD, TEL, FAXSTD, FAX, EMAIL, CRS1, CRS2, CRS3, CRS4, CRS5, CRS6, CRS7, CRS8, CRS9, CRS10, CRS11, CRS12, CRS13, MOBILE) VALUES (@SNO, @ENRNO, @PROGRAM, @MEDIUM, @STUDY, @NAME, @FNAME, @ADD1, @ADD2, @ADD3, @CITY, @STATE, @PIN, @STD, @TEL, @FAXSTD, @FAX, @EMAIL, @CRS1, @CRS2, @CRS3, @CRS4, @CRS5, @CRS6, @CRS7, @CRS8, @CRS9, @CRS10, @CRS11, @CRS12, @CRS13, @MOBILE)"
                        Using connec = New System.Data.OleDb.OleDbConnection(cnString)
                            Using com = New System.Data.OleDb.OleDbCommand(squery, connec)
                                connec.Open()
                                com.Parameters.AddWithValue("@SNO", ISNO.ToString)
                                com.Parameters.AddWithValue("@ENRNO", IENRNO.ToString)
                                com.Parameters.AddWithValue("@PROGRAM", IPROGRAM.ToString)
                                com.Parameters.AddWithValue("@MEDIUM", IMEDIUM.ToString)
                                com.Parameters.AddWithValue("@STUDY", ISTUDY.ToString)
                                com.Parameters.AddWithValue("@NAME", INAME.ToString)
                                com.Parameters.AddWithValue("@FNAME", IFNAME.ToString)
                                com.Parameters.AddWithValue("@ADD1", IADD1.ToString)
                                com.Parameters.AddWithValue("@ADD2", IADD2.ToString)
                                com.Parameters.AddWithValue("@ADD3", IADD3.ToString)
                                com.Parameters.AddWithValue("@CITY", ICITY.ToString)
                                com.Parameters.AddWithValue("@STATE", ISTATE.ToString)
                                com.Parameters.AddWithValue("@PIN", IPIN.ToString)
                                com.Parameters.AddWithValue("@STD", ISTD.ToString)
                                com.Parameters.AddWithValue("@TEL", ITEL.ToString)
                                com.Parameters.AddWithValue("@FAXSTD", IFAXSTD.ToString)
                                com.Parameters.AddWithValue("@FAX", IFAX.ToString)
                                com.Parameters.AddWithValue("@EMAIL", IEMAIL.ToString)
                                com.Parameters.AddWithValue("@CRS1", ICRS1.ToString)
                                com.Parameters.AddWithValue("@CRS2", ICRS2.ToString)
                                com.Parameters.AddWithValue("@CRS3", ICRS3.ToString)
                                com.Parameters.AddWithValue("@CRS4", ICRS4.ToString)
                                com.Parameters.AddWithValue("@CRS5", ICRS5.ToString)
                                com.Parameters.AddWithValue("@CRS6", ICRS6.ToString)
                                com.Parameters.AddWithValue("@CRS7", ICRS7.ToString)
                                com.Parameters.AddWithValue("@CRS8", ICRS8.ToString)
                                com.Parameters.AddWithValue("@CRS9", ICRS9.ToString)
                                com.Parameters.AddWithValue("@CRS10", ICRS10.ToString)
                                com.Parameters.AddWithValue("@CRS11", ICRS11.ToString)
                                com.Parameters.AddWithValue("@CRS12", ICRS12.ToString)
                                com.Parameters.AddWithValue("@CRS13", ICRS13.ToString)
                                com.Parameters.AddWithValue("@MOBILE", IMOBILE.ToString)
                                com.ExecuteNonQuery()
                            End Using
                        End Using
                    Next
                    MessageBox.Show("Saved Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Exit Sub
                End If
            End If
            AccessConnection.Close()
        Catch ex As Exception
            MsgBox("Can't load " & vbCrLf & ex.Message)
        End Try
        ccname()
    End Sub
   

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        disp_all_tables.Show()
    End Sub
    Private Sub ccname()
        Try
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "ALL_COURSES"})
            If SchemaTable.Rows.Count <> 0 Then
                Dim ABC = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim DEF As String = "INSERT INTO ALL_COURSES" & "(COURSE_NAME)" & "VALUES (@COURSE_NAME)"
                Using JAT = New System.Data.OleDb.OleDbConnection(ABC)
                    Using TOM = New System.Data.OleDb.OleDbCommand(DEF, JAT)
                        JAT.Open()
                        TOM.Parameters.AddWithValue("@COURSE_NAME", Course)
                        TOM.ExecuteNonQuery()
                    End Using
                End Using
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [ALL_COURSES] ([COURSE_NAME] TEXT(15))", Conn)
                    cmd.Connection = Conn
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    Conn.Close()
                Catch ex As Exception
                End Try

                Dim ABC = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim DEF As String = "INSERT INTO ALL_COURSES" & "(COURSE_NAME)" & "VALUES (@COURSE_NAME)"
                Using JAT = New System.Data.OleDb.OleDbConnection(ABC)
                    Using TOM = New System.Data.OleDb.OleDbCommand(DEF, JAT)
                        JAT.Open()
                        TOM.Parameters.AddWithValue("@COURSE_NAME", Course)
                        TOM.ExecuteNonQuery()
                    End Using
                End Using
            End If
            AccessConnection.Close()
        Catch ex As Exception
            MsgBox("Can't load Course Name " & vbCrLf & ex.Message)
        End Try
    End Sub

End Class