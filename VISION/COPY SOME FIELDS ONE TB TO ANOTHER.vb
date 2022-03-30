Public Class Assignments

    Private Sub Assignments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForGOA()
        Me.CenterToScreen()
        Me.TopMost = True
        Me.ToolTip1.SetToolTip(Me.Button1, "This Button Will will create assigment Data , So Use it first and Enter Same Spelling of Course Name ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.TopMost = False
            Dim StatusDate As String

            Dim Course As String
            StatusDate = InputBox("Enter Course Name ?", "{e.g MCA or MCOM etc", "  ")
            Course = Convert.ToString(StatusDate)

            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)
            Dim createTable As New OleDb.OleDbCommand
            Dim cmd As New OleDb.OleDbCommand("INSERT INTO Assignments (SNO,ENROLL,PROGRAM,STUDENT_NAME,CRS1,CRS2,CRS3,CRS4,CRS5,CRS6,CRS7,CRS8,CRS9,CRS10,CRS11,CRS12,CRS13) SELECT SNO,ENRNO,PROGRAM,NAME,CRS1,CRS2,CRS3,CRS4,CRS5,CRS6,CRS7,CRS8,CRS9,CRS10,CRS11,CRS12,CRS13 FROM " & Course & " ", Conn)
            Conn.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("Assignmnet Mentioned  Course Successfully Filled , Now You Can Enter Marks ")
            Conn.Close()
        Catch ex As Exception
            MsgBox("Can't load ")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    
End Class