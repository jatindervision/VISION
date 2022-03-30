Imports ADOX
Imports System.Data.OleDb
Module Module1
    Public Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;")
    Public Dad As OleDbDataAdapter
    Public Drd As OleDbDataReader
    Public Cmd As OleDbCommand
    Public Cmd1 As OleDbCommand
    Public Dst = New DataSet
    Public PST = New DataSet
    Dim i As Integer
    Public CurrentRow As Integer
    Public totalRow As Integer
    Public Sub ClearlabelBoxes(frm As Form)

        For Each Control In frm.Controls
            If TypeOf Control Is Label Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

    End Sub
    Public Sub ClearTextBoxes(frm As Form)

        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

    End Sub
    Public Sub CloseAllForms()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next
    End Sub

    Public Sub ForBooksIssued()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "BooksIssued" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub

    Public Sub ForAbout()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "AboutBox1" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForCollegename()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Collegename" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub Onlydatabase()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Database" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForDisplaybooks()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "DisplayBooks" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForDisplayCollege()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "DisplayCollege" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForDisIsdBooks()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "DisplayIsuedBooks" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub DispLab()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "DisplayLab" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForDisRBooks()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "DisplayReturnBooks" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForEditLab()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "EditLab" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForEnBooksI()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Enterbooks" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForIgBEn()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "IgnouBooksEntry" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForIgBooIsd()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "IgnouBooksIssue" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForRBooksI()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "ReturnBooks" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForLab()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Lab" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForTutionFee()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "TutionFee" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForcalculateFee()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "CalculateFee" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
   
    Public Sub ForSalary()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Salary" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForExpenses()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Expenses" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForShowExpenses()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "ShowExpenses" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForUpdateExpenses()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "UpdateExpenses" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForEmployeeEntry()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "EmployeeDetail" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForEmpDataBack()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "EmployDataBackup" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForSalary1()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Salary1" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForSalary2()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Salary2" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForDeleteSalary()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Edit_Salary" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForStudentAtt()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "StudentAttendance" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForCollegeStuEntry()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "StudentEntry" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForTwoStudentAtt()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "TwoStudentAtt" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub

    Public Sub ForAdmissionBackup()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "AdmissionBackup" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForCCourseCompleted()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "CourseCompleted" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForSStaffattendance()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "StaffAttendance" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForIgnoutaffattendance()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "IgnouStaffAttendance" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForIgnoueMPeNTRY()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "IgnouEmpEntry" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForTyping()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Typing" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForStart()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub Forignoufirstdirect()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Import_Ignou_Students" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub FORIGSTART()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "IgnouStStart" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub FORdisplaycourse()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "All_Courses" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub FORcheckall()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "CheckAllTableRecords" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub FORBACKUPDATA()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "BACKUPDATA" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub mixedignou()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "MixedIGNOUExcel" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub IGNOUExpensesfor()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "IGNOUExpenses" Then
                formNames.Add(currentForm.Name)
            End If

        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub Forstockregistor()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "StockRegistor" Then
                formNames.Add(currentForm.Name)
            End If


        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub GOForstock()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "GOStockRegistor" Then
                formNames.Add(currentForm.Name)
            End If


        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForGoone()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "GoAdmissionBackup" Then
                formNames.Add(currentForm.Name)
            End If


        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForGoSchedule()
        Dim formNames As New List(Of String)

        For Each currentForm As Form In Application.OpenForms

            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "GoSchedule" Then
                formNames.Add(currentForm.Name)
            End If


        Next

        For Each currentFormName As String In formNames

            Application.OpenForms(currentFormName).Close()

        Next

    End Sub
    Public Sub ForSchedule()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Schedule" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub ForAssignments()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "GoAssignments" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub ForGOA()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Assignments" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub ForASSIGMARKS()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "AssignmentMarks" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub forassnlist()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Assforbill" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub ForAbill()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "AssignmentBill" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub PRINTASSIGN()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "PRINTASSIGNMENT" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub formrolist()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "MroList" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub forasslist()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "AssignmentRollFinal" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub formrolistprint()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "MroListPrint" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub formroreceipt()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "MroReceipt" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub forCHCPRINT()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "ChcPrint" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub forCHC()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Chc" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub forCHCReceipt()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "ReceiptCHC" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub forschhol()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "ScheduleStart" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub forib()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "forinputbox" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub forib2()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "_11forinputbox" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub for12()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "_12forinputbox" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub for13()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "_13forinputbox" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub for14()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "_14forinputbox" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub IGNOULABATT()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "IGNOU_LAB_ATT" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub FORIGNOULABATT()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Ignou_lab_attendance" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub chctesting()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "testingCHC" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub beforechctesting()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "forLabtesting" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub counsch()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "StartCounSchedule" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub scheduleco()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "COUNSELLINGSCHEDULE" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub FORCOUNCHARGES()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "FORCOUNSELLORCHARGES" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub hELLOCHARGES()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "CHARGESCOUN123" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub ABCD()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "FORATTENDANCESIG" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub FORATTENDANCEPRINT()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Report_IStudentAttendance" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub REPORTATT()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "ATTEN-PRINTING" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub startatt113()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "STARTATT" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub ASSIGNPRINT()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "ASSIGNMENTREPO2" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub ASSVIEW()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "ASSIGNMENTVIEWER" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub MROREPO0002()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "MROREPO02" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub repomro()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "MROREPOVIEWER" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub attenrepo()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "reportview" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub chcviwerepo()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "CHCREPORTVIEWER" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub BILLASSSREPO()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "assbillviewer" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub gocname()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "GoCollegeName" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub impsch()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "ImportSchedule" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub GRIDAAS()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "importassignmentgrid" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub CH01REPO()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "CHC01" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub SHSCHE()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "SCHEDULESHOW" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub entto()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "EXPENSESIGNOU" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub billff()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "finalbillstart" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub STSHOW()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "STOCKDETAIL" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub EREPO()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "expenrepo" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub sch11()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "schedule1" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub COSHVI()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "CO_SCHEDULE_VIEWER" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub COOCHARGES()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "CO_CHARGES__VIEWER" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub cexpcol()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "EXPALL" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub ARTSATT()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "FOR_ARTS_ATTENDANCE_SIG" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub ASSARTS()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "ARTS_ASSIGNMENT_REPORT" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub DELONEBYONE()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Delete_Database_Tables" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub Aentto()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "artsbill1" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub Abillff()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "Afinalbillstart" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub AUTOATTEN()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "ATTENAUTO" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub DISPALLTBL()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "disp_all_tables" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub ABILLSTARTA()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "ASSFORBILLSTART" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub STOCKFI()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "stock_start_buttons" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub cocharges()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "counsellorreceipt" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub VIMMR()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "VIEWMMR" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
    Public Sub FMMR()
        Dim formNames As New List(Of String)
        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name <> "MDIParent1" And currentForm.Name <> "MMR" Then
                formNames.Add(currentForm.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
End Module
