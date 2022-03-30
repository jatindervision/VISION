Imports System
Imports System.Data.OleDb
Public Class MDIParent1
    Dim objconn As OleDbConnection
    Dim objcmd As OleDbCommand
    Dim objdr As OleDbDataReader
    Dim str As String
    Dim userTables As DataTable = Nothing
    Dim D As String
    Dim cw As Integer ' Forms current Width.
    Dim ch As Integer ' Forms current Height.
    Dim iw As Integer = 1440 ' Forms initial width.
    Dim ih As Integer = 900 ' Forms initial height.
    ' Retrieve the working rectangle from the Screen class using the        PrimaryScreen and the WorkingArea properties.  
    Dim workingRectangle As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Main.Close()
        Me.WindowState = FormWindowState.Maximized
        Me.Size = New System.Drawing.Size(workingRectangle.Width - 0, workingRectangle.Height - 0)
        'Set the location so the entire form is visible. 
        Me.Location = New System.Drawing.Point(0, 0)
        Me.CenterToScreen()

        Try
            Con.Open()

            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter("SELECT Name,University_Name from Name ", Con)
            da.Fill(ds, "Name")
            Label4.Text = ds.Tables("Name").Rows(0)("Name")
            Con.Close()
        Catch ex As Exception
        End Try
        ' MenuStrip1.Visible = False



    End Sub

    ' Public Function ScreenResolution() As String
    'Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
    'Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
    'Return intX & " × " & intY
    'Label2.Text = (intX & " × " & intY).ToString
    'End Function

    Private Sub NameToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NameToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of GoCollegeName).Any Then
            frmCollection.Item("GoCollegeName").Close()
        End If
        GoCollegeName.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs)
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of DisplayCollege).Any Then
            frmCollection.Item("DisplayCollege").Close()
        End If
        DisplayCollege.Show()


    End Sub

    Private Sub LabEquipmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabEquipmentsToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of GoLav).Any Then
            frmCollection.Item("GoLav").Close()
        End If

        GoLav.Show()


    End Sub


    Private Sub EditLabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditLabToolStripMenuItem.Click
        If System.IO.File.Exists("C\Database\college.accdb") = False Then
            Dim frmCollection = System.Windows.Forms.Application.OpenForms
            If frmCollection.OfType(Of EditLab).Any Then
                frmCollection.Item("EditLab").Close()
            End If
            EditLab.Show()
        Else
            MsgBox("Please First Create Database")
            Database.Show()

        End If


    End Sub

    Private Sub DisplayLabToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DisplayLabToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of DisplayLab).Any Then
            frmCollection.Item("DisplayLab").Close()
        End If

        DisplayLab.Show()

    End Sub

    Private Sub EnterBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterBooksToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of Enterbooks).Any Then
            frmCollection.Item("Enterbooks").Close()
        End If

        GoLiv.Show()

    End Sub

    Private Sub BooksIssuedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BooksIssuedToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of BooksIssued).Any Then
            frmCollection.Item("BooksIssued").Close()
        End If
        GoBooksIssued.Show()

    End Sub

    Private Sub ReturnBooksRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnBooksRecordToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of ReturnBooks).Any Then
            frmCollection.Item("ReturnBooks").Close()
        End If

        GoBooksReturn.Show()
    End Sub

    Private Sub IGNOUBooksEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IGNOUBooksEntryToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of IgnouBooksEntry).Any Then
            frmCollection.Item("IgnouBooksEntry").Close()
        End If
        GoIgnouBooksE.Show()
    End Sub

    Private Sub IGNOUBooksIssueRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IGNOUBooksIssueRecordToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of IgnouBooksIssue).Any Then
            frmCollection.Item("IgnouBooksIssue").Close()
        End If
        GoIgnouBIss.Show()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
    Private Sub TutionFeeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TutionFeeToolStripMenuItem1.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of TutionFee).Any Then
            frmCollection.Item("TutionFee").Close()
        End If
        GoTutionFee.Show()
    End Sub
    Private Sub ExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpensesToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of Expenses).Any Then
            frmCollection.Item("Expenses").Close()
        End If
        GoExpenses.Show()
    End Sub
    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of Salary).Any Then
            frmCollection.Item("Salary").Close()
        End If
        GoSalary.Show()
    End Sub
    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of ATTSTUDENTS).Any Then
            frmCollection.Item("ATTSTUDENTS").Close()
        End If
        ATTSTUDENTS.Show()
    End Sub

    Private Sub MannualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MannualToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of StudentEntry).Any Then
            frmCollection.Item("StudentEntry").Close()
        End If
        GoCollegeStuEntry.Show()
    End Sub

    Private Sub ChangeCollegeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeCollegeNameToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of DisplayCollege).Any Then
            frmCollection.Item("DisplayCollege").Close()
        End If
        DisplayCollege.Show()
    End Sub
    Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ' Change controls size and fonts to fit screen working area..
        Dim rw As Double = (Me.Width - cw) / cw ' Ratio change of original form width.
        Dim rh As Double = (Me.Height - ch) / ch ' Ratio change of original form height.
        ' Change controls size to fit users screen working area.
        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * rw)
            Ctrl.Height += CInt(Ctrl.Height * rh)
            Ctrl.Left += CInt(Ctrl.Left * rw)
            Ctrl.Top += CInt(Ctrl.Top * rh)
        Next
        cw = Me.Width
        ch = Me.Height
        ' Change all the forms controls font size.
        Dim nfsize As Single
        If cw > iw + 500 Then
            For Each Ctrl As Control In Controls
                ' Get the forms controls font size's property and increase it. Reset the font to the new size. 
                nfsize = Me.Font.Size + 3
                Ctrl.Font = New Font(Ctrl.Font.Name, nfsize, FontStyle.Bold, Ctrl.Font.Unit)
            Next
        Else
            Exit Sub
        End If
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of ATTSTAFF).Any Then
            frmCollection.Item("ATTSTAFF").Close()
        End If
        ATTSTAFF.Show()
    End Sub

    Private Sub IGNOUStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IGNOUStaffToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of ATTIGNOUEMP).Any Then
            frmCollection.Item(" ATTIGNOUEMP").Close()
        End If
        ATTIGNOUEMP.Show()
    End Sub

    Private Sub CollegeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollegeToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of EmployeeDetail).Any Then
            frmCollection.Item("EmployeeDetail").Close()
        End If
        GoEmployeeDetail.Show()
    End Sub

    Private Sub IgnouToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IgnouToolStripMenuItem1.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of IgnouEmpEntry).Any Then
            frmCollection.Item("IgnouEmpEntry").Close()
        End If
        GoIgnouEmpEntry.Show()
    End Sub

    Private Sub TypingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TypingToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of Typing).Any Then
            frmCollection.Item("Typing").Close()
        End If
        Typing.Show()
    End Sub

    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of IgnouStStart).Any Then
            frmCollection.Item("IgnouStStart").Close()
        End If
        IgnouStStart.Show()
    End Sub

    Private Sub CoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoursesToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of All_Courses).Any Then
            frmCollection.Item("All_Courses").Close()
        End If
        All_Courses.Show()
    End Sub
   

    Private Sub DatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of Database).Any Then
            frmCollection.Item("Database").Close()
        End If
        Database.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of BACKUPDATA).Any Then
            frmCollection.Item("BACKUPDATA").Close()
        End If
        BACKUPDATA.Show()
    End Sub
    Private Sub showall()
        InitializeComponent()
        FileToolStripMenuItem.Enabled = True
    End Sub

    Private Sub IGNOUExpenditureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IGNOUExpenditureToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of IGNOUExpenses).Any Then
            frmCollection.Item("IGNOUExpenses").Close()
        End If
        GOIGNOUExpenses.Show()
    End Sub

    Private Sub AttendanceToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        STARTATT.Show()
    End Sub

    Private Sub StockRegistorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockRegistorToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of StockRegistor).Any Then
            frmCollection.Item("StockRegistor").Close()
        End If
        GoStockRegister.Show()
    End Sub

    Private Sub ExitApp_Click(sender As Object, e As EventArgs) Handles ExitApp.Click
        ' For Each frm As Form In Application.OpenForms
        'frm.WindowState = FormWindowState.Minimized
        'Me.WindowState = FormWindowState.Maximized
        'Next frm
        'Me.WindowState = FormWindowState.Maximized
        CloseAllForms()
        Dim answer As MsgBoxResult
        answer = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.Yes Then
            login.Close()
            Application.Exit()

        End If

    End Sub
    Private Sub IGNOUStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IGNOUStudentsToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of IGNOU_LAB_ATT).Any Then
            frmCollection.Item("IGNOU_LAB_ATT").Close()
        End If
        IGNOU_LAB_ATT.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        DISPLAY.Items.Clear()
        DISPLAY.Visible = True
        DISPLAY.BorderStyle = BorderStyle.Fixed3D
        'Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
        'AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        'AccessConnection.Open()
        'Dim schemaTable As DataTable = AccessConnection.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
        Try
            str = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            objconn = New OleDbConnection(str)

            Dim restriction() As String = New String(3) {}
            restriction(3) = "Table"
            objconn.Open()
            userTables = objconn.GetSchema("Tables", restriction)

            objconn.Close()
            Dim i As Integer
            Dim z As Integer = 0
            For i = 0 To userTables.Rows.Count - 1 Step 1
                z = z + 1
                DISPLAY.Items.Add("(" & z & ")  " & userTables.Rows(i)(2).ToString)
                ' ListBox1.Items.Add("________________")
            Next i
            'objcmd = New OleDbCommand("select * from ", objconn)
        Catch ex As Exception
            DISPLAY.Visible = False
            MsgBox("DataBase Does Not Exist")
            Exit Sub
        End Try

        ' DataGridView1.DataSource = schemaTable
        'DataGrid1.DataSource = schemaTable

    End Sub
    Private Sub OFF_Click(sender As Object, e As EventArgs)
        'DataGridView1.DataSource = Nothing
        DISPLAY.Visible = False
    End Sub
    Private Sub STOCKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STOCKToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of stock_start_buttons).Any Then
            frmCollection.Item("stock_start_buttons").Close()
        End If
        stock_start_buttons.Show()
    End Sub

    Private Sub ATTENDANCEToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of STARTATT).Any Then
            frmCollection.Item("STARTATT").Close()
        End If
        STARTATT.Show()
    End Sub
    Private Sub CHCToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MROREPOSTART.Show()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.WindowState = 1
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub MannualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MannualToolStripMenuItem1.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of GOSchedule).Any Then
            frmCollection.Item("GOSchedule").Close()
        End If
        GOSchedule.Show()
    End Sub

    Private Sub ImportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem1.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of importsch).Any Then
            frmCollection.Item("importsch").Close()
        End If
        importsch.Show()
    End Sub
    Private Sub IputAssignmentMArksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IputAssignmentMArksToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of inputassfilename).Any Then
            frmCollection.Item("inputassfilename").Close()
        End If
        inputassfilename.Show()
    End Sub

    Private Sub ImportToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem2.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of importassmarks).Any Then
            frmCollection.Item("importassmarks").Close()
        End If
        importassmarks.Show()
    End Sub

    Private Sub ScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleToolStripMenuItem.Click
        startscheduleschow.Show()
    End Sub

    Private Sub AssignmentEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignmentEntryToolStripMenuItem.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Visible = True
        Button2.Visible = False
        DISPLAY.Items.Clear()
        DISPLAY.Visible = True
        DISPLAY.BorderStyle = BorderStyle.Fixed3D
        'Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
        'AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        'AccessConnection.Open()
        'Dim schemaTable As DataTable = AccessConnection.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
        Try
            str = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            objconn = New OleDbConnection(str)

            Dim restriction() As String = New String(3) {}
            restriction(3) = "Table"
            objconn.Open()
            userTables = objconn.GetSchema("Tables", restriction)

            objconn.Close()
            Dim i As Integer
            Dim z As Integer = 0
            For i = 0 To userTables.Rows.Count - 1 Step 1
                z = z + 1
                DISPLAY.Items.Add("(" & z & ")  " & userTables.Rows(i)(2).ToString)
                ' ListBox1.Items.Add("________________")
            Next i
            'objcmd = New OleDbCommand("select * from ", objconn)
        Catch ex As Exception
            DISPLAY.Visible = False
            MsgBox("DataBase Does Not Exist")
            Exit Sub
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button2.Visible = True
        Button3.Visible = False
        DISPLAY.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OvalShape1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EXPENSESREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXPENSESREPORTToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of ALLPURCHASES).Any Then
            frmCollection.Item("ALLPURCHASES").Close()
        End If
        ALLPURCHASES.Show()
    End Sub

    Private Sub DirectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of directschedule).Any Then
            frmCollection.Item("directschedule").Close()
        End If
        directschedule.Show()
    End Sub

    
    Private Sub AssignmentAwartListToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of ASSFORBILLSTART).Any Then
            frmCollection.Item("ASSFORBILLSTART").Close()
        End If
        ASSFORBILLSTART.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of _12forinputbox).Any Then
            frmCollection.Item("_12forinputbox").Close()
        End If
        _12forinputbox.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of _13forinputbox).Any Then
            frmCollection.Item("_13forinputbox").Close()
        End If
        MsgBox("HAVE YOU CLICK ON MRO FIRST AND COMPLETER IT :::: BECAUSE MRO RECEIPT CREATED BY MRO OPTION")
        _13forinputbox.Show()
    End Sub
    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of forLabtesting).Any Then
            frmCollection.Item("forLabtesting").Close()
        End If
        forLabtesting.Show()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of forinputbox).Any Then
            frmCollection.Item(" forinputbox").Close()
        End If
        MsgBox("HAVE YOU CLICK ON COMPUTER HIRING CHARGES  FIRST AND COMPLETER IT :::: BECAUSE CHC RECEIPT CREATED BY COMPUTER HIRING CHARGES O OPTION")
        forinputbox.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of StartCounSchedule).Any Then
            frmCollection.Item("StartCounSchedule").Close()
        End If
        StartCounSchedule.Show()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of counst).Any Then
            frmCollection.Item("counst").Close()
        End If
        counst.Show()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of EXPENSESIGNOU).Any Then
            frmCollection.Item("EXPENSESIGNOU").Close()
        End If
        EXPENSESIGNOU.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of STARTATT).Any Then
            frmCollection.Item("STARTATT").Close()
        End If
        STARTATT.Show()
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of ASSIGNMENTREPO1).Any Then
            frmCollection.Item("ASSIGNMENTREPO1").Close()
        End If
        ASSIGNMENTREPO1.Show()
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of MROREPO01).Any Then
            frmCollection.Item("MROREPO01").Close()
        End If
        MROREPO01.Show()
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        MROREPOSTART.Show()
    End Sub

    Private Sub AttendanceToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem1.Click
        Arts_Attendance.Show()
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        ARTS_ASSIGNMENT_START.Show()
    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem19.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of Assforbill).Any Then
            frmCollection.Item("Assforbill").Close()
        End If
        Assforbill.Show()
    End Sub

  

   
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Delete_Database_Tables.Show()
    End Sub

  
    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem20.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of StartCounSchedule).Any Then
            frmCollection.Item("StartCounSchedule").Close()
        End If
        StartCounSchedule.Show()
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem21.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of counst).Any Then
            frmCollection.Item(" counst").Close()
        End If
        counst.Show()
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem22.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of artsbill1).Any Then
            frmCollection.Item("artsbill1").Close()
        End If
        artsbill1.Show()
    End Sub

    Private Sub AllTableRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllTableRecordsToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of disp_all_tables).Any Then
            frmCollection.Item("disp_all_tables").Close()
        End If
        disp_all_tables.Show()
    End Sub

    Private Sub TopicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopicsToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of help).Any Then
            frmCollection.Item("help").Close()
        End If
        help.Show()
    End Sub

    Private Sub CounsellorReceiptsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CounsellorReceiptsToolStripMenuItem.Click
        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of stco).Any Then
            frmCollection.Item("stco").Close()
        End If
        stco.Show()
    End Sub

    Private Sub CounsellorReceiptsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CounsellorReceiptsToolStripMenuItem1.Click
        stco.Show()
    End Sub

    Private Sub MMRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MMRToolStripMenuItem1.Click
        GOMMR.Show()
    End Sub
End Class

