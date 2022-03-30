Imports ADOX
Imports System.Data.OleDb
Public Class Database
    Dim cat As New Catalog()
    'Make sure you put a space " " at the end of your string.
    Dim scrolledString As String = "ITS ONE TIME PROCESS AT THE BEGINING , FIRST BUTTON WILL CREATE WORKING FOLDER AND SECOND WILL CREATE BACKUP FOLDER!! HAVE A NICE DAY "

    Dim myStrings(scrolledString.Length - 1) As String
    Dim position As Integer = -1
    Private Sub Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Onlydatabase()
        Me.CenterToScreen()
        Me.fordatabase.SetToolTip(Me.Button2, "Hello My Name is Button , I will Create Database & All Work will be stored in Database")
        Me.fordatabase.SetToolTip(Me.Button1, "Hello My Name is Button , I will Create Backup Database Where Copy of All Work will be stored ")
        Dim labelSize As Size
        labelSize.Width = 200
        labelSize.Height = 13
        Label1.MinimumSize = labelSize
        Label1.MaximumSize = labelSize
        Label1.Size = labelSize

        Call ScrollType2(scrolledString)
        'Make this value smaller say as low as 25 for
        'a faster scroll effect.
        Timer1.Interval = 75
        Timer1.Enabled = True
        Timer1.Start()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cat As New Catalog()
        If (System.IO.Directory.Exists("C:\Database")) = True Then
            Me.Close()
            MsgBox(" Please Dont Press Again As Database  Folder on C Drive Already Exists")
        Else

            My.Computer.FileSystem.CreateDirectory("C:\Database")
           
            cat.Create("ProvIder=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Database\college.accdb;")
         
            MsgBox("Database Created Successfully")

            cat = Nothing
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cat As New Catalog()
        If (System.IO.Directory.Exists("C:\BackupData")) = True Then

            MsgBox(" Please Dont Press Again As BackupData Folder on C Drive Already Exists")
            Me.Close()
        Else
            My.Computer.FileSystem.CreateDirectory("C:\BackupData")


            cat.Create("ProvIder=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\BackupData\college.accdb;")


            MsgBox("BackupData Database Created Successfully")

            cat = Nothing
        End If
        Me.Close()
    End Sub
    Private Sub ScrollType1(ByVal someString As String)
        For index As Integer = 0 To UBound(myStrings)
            Dim workedString As String = ""
            workedString = someString.Substring(index)
            myStrings(index) = workedString
        Next
    End Sub

    Private Sub ScrollType2(ByVal someString As String)
        For index As Integer = 0 To UBound(myStrings)
            Dim workedString As String = ""
            workedString = someString.Substring(index) & " " & someString.Substring(0, index)
            myStrings(index) = workedString
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles Timer1.Tick

        position += 1
        Dim testString As String
        testString = myStrings(position)
        Label1.Text = testString
        'You could add this line to scroll the FORM title text too!!
        Me.Text = testString
        If position = UBound(myStrings) Then position = -1
    End Sub
    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class