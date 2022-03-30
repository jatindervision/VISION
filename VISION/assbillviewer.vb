Imports System.Data.OleDb
Imports System.String
Imports Microsoft.Reporting.WinForms
Public Class assbillviewer
    Private Sub assbillviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
        BILLASSSREPO()
        Me.TopMost = True
        Me.CenterToScreen()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dst.Clear()
        ReportViewer1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dst.clear()
            ReportViewer1.Visible = True
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
            End With
            ' Use the same name as defined in the report Data Source Definition
            Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim MyConn As OleDbConnection
            Dim da1 As OleDbDataAdapter

            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            MyConn.Open()
            da1 = New OleDbDataAdapter("Select * from [ASSBILLTOP]", MyConn)

            da1.Fill(Dst, "ASSBILLTOP")
            Dim rpt1 = New ReportDataSource("DataSet1", Dst.Tables("ASSBILLTOP"))

            '  ReportViewer1.LocalReport.DataSources.Clear()

            Me.ReportViewer1.LocalReport.DataSources.Add(rpt1)

            ' Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

            ' Me.ReportViewer1.RefreshReport()

            'TODO: This line of code loads data into the 'collegeDataSet.BOTTOMADMISSION' table. You can move, or remove it, as needed.
            'Me.BOTTOMADMISSIONTableAdapter.Fill(Me.collegeDataSet.BOTTOMADMISSION)
            'TODO: This line of code loads data into the 'collegeDataSet.TOPADMISSION' table. You can move, or remove it, as needed.
            'Me.TOPADMISSIONTableAdapter.Fill(Me.collegeDataSet.TOPADMISSION)

            Me.ReportViewer1.RefreshReport()

            MyConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function collegeDataSet() As Object
        Throw New NotImplementedException
    End Function

End Class