Option Explicit On
Imports System
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class Report_IStudentAttendance
   Private Const WS_EX_TRANSPARENT = &H20&
    Private Const GWL_EXSTYLE = (-20)
    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long

    Private pcode As String = FORATTENDANCESIG.TextBox1.Text.Trim()
    Private time As String = FORATTENDANCESIG.TextBox2.Text.Trim()
    Private coursecode As String = FORATTENDANCESIG.TextBox3.Text.Trim()
    Private dates As String = FORATTENDANCESIG.TextBox4.Text.Trim()
    Private Course As String = FORATTENDANCESIG.TextBox5.Text.Trim()
    Private min As String = FORATTENDANCESIG.TextBox6.Text.Trim()
    Private max As String = FORATTENDANCESIG.TextBox7.Text.Trim()
    Private COUNNAME As String = FORATTENDANCESIG.TextBox8.Text.Trim()

    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Private Sub Report_IStudentAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORATTENDANCEPRINT()
        Me.CenterToScreen()
        Me.TopMost = True
        Label7.Text = time
        Label9.Text = pcode
        Label11.Text = dates
        Label13.Text = coursecode
        Label20.Text = COUNNAME

        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT * FROM Name", MyConn)
            da.Fill(ds, "Name")
            Label1.Text = ds.Tables("Name").Rows(CurrentRow)("University_Name")
            Label6.Text = ds.Tables("Name").Rows(CurrentRow)("Code")
            Label3.Text = ds.Tables("Name").Rows(CurrentRow)("PLACE")
            MyConn.Close()
        Catch ex As Exception
        End Try
        Try
            Con.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT * FROM  [" & Course & "]", Con)
            da.Fill(ds, "" & Course & "")
            clear()
            'Where SNO=" & TextBox21.Text.Trim & "
            
            Dim i As Integer = 0
            Dim J As Integer
            i = Convert.ToInt32(min)
            J = Convert.ToInt32(max)
            For i = i - 1 To J - 1 Step 1

                ListBox1.Items.Add(ds.Tables("" & Course & "").Rows(i)("SNO"))
                ListBox2.Items.Add(ds.Tables("" & Course & "").Rows(i)("NAME"))
                ListBox3.Items.Add(ds.Tables("" & Course & "").Rows(i)("ENRNO"))
                ListBox5.Items.Add(ds.Tables("" & Course & "").Rows(i)("SNO"))

            Next i
            Con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button2.Visible = False
        Me.TopMost = False
        With Me.PrintForm1
            .PrintAction = Printing.PrintAction.PrintToPreview
            Dim MyMargins As New Margins
            With MyMargins
                .Left = 1
                .Right = 0.2
                .Top = 0.8
                .Bottom = 0.5
            End With
            .PrinterSettings.DefaultPageSettings.Margins = MyMargins
            .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)

        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Public Function MakeListTransparent(ListCtl As Object) As Boolean

        On Error Resume Next
        ListCtl.BackColor = ListCtl.Parent.BackColor
        SetWindowLong(ListCtl.hwnd, GWL_EXSTYLE, WS_EX_TRANSPARENT)
        MakeListTransparent = Err.LastDllError = 0

    End Function
End Class