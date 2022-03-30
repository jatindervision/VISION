Imports System
Imports System.Data.OleDb
Imports System.IO

Public Class BACKUPDATA

    Dim scrolledString As String = "GET BACKUP OF ALL DATA BEFORE PACK , OTHERWISE YOU WILL LOOSE YOUR DATA SO BE CAREFULL !! HAVE A NICE DAY "

    Dim myStrings(scrolledString.Length - 1) As String
    Dim position As Integer = -1
    Private Sub BACKUPDATA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FORBACKUPDATA()
        Me.CenterToScreen()
        Me.TopMost = True

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If My.Computer.FileSystem.FileExists("C:\Database\college.accdb") = True Then
                My.Computer.FileSystem.CopyFile("C:\Database\college.accdb", "C:\BackupData\college.accdb", True)
                MsgBox("You have Successfully Backup you Data on C:\BackupData ")
                Me.Close()
            Else
                MsgBox("C:\Database  Folder Does Not EXIST ")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If My.Computer.FileSystem.FileExists("C:\Database\college.accdb") = True Then
                MsgBox("All Data has been Packed from  C:\Database and DATABASE folder from C Drive has been Removed")
                Con.Dispose()
                Dim path As String = "C:\Database\"
                DeleteDirectory(path)
                Me.Close()
            Else
                MsgBox("C:\Database does not Exits , You Press This Button Twice")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DeleteDirectory(path As String)
        Try
            If Directory.Exists(path) Then
                'Delete all files from the Directory
                For Each filepath As String In Directory.GetFiles(path)
                    File.Delete("C:\Database\college.accdb")
                Next
                'Delete all child Directories
                For Each dir As String In Directory.GetDirectories(path)
                    DeleteDirectory(dir)
                Next
                'Delete a Directory
                Directory.Delete(path)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            My.Computer.FileSystem.CopyFile("C:\BackupData\college.accdb", "C:\Database\college.accdb", True)
            MsgBox("You have Successfully Copied Your Database from  C:\BackupData to C:\Database")
            Exit Sub
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Delete_Database_Tables.Show()
    End Sub
End Class