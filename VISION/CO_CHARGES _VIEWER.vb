Imports System.Data.OleDb
Imports System.String
Imports Microsoft.Reporting.WinForms

Public Class CO_CHARGES__VIEWER

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dst.Clear()
        ReportViewer1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CO_CHARGES__VIEWER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COOCHARGES()
        Me.CenterToScreen()
        Me.TopMost = True


        'TODO: This line of code loads data into the 'collegeDataSet1.BCoCHARGES' table. You can move, or remove it, as needed.
        '  Me.BCoCHARGESTableAdapter.Fill(Me.collegeDataSet1.BCoCHARGES)
        ' 'TODO: This line of code loads data into the 'collegeDataSet1.TCoCHARGES' table. You can move, or remove it, as needed.
        ' Me.TCoCHARGESTableAdapter.Fill(Me.collegeDataSet1.TCoCHARGES)
        ' Me.ReportViewer1.RefreshReport()
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
            Dim da2 As OleDbDataAdapter
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            MyConn.Open()
            da1 = New OleDbDataAdapter("Select * from [BCoCHARGES]", MyConn)
            da2 = New OleDbDataAdapter("Select * from [TCoCHARGES]", MyConn)
            da1.Fill(Dst, "BCoCHARGES")
            da2.Fill(Dst, "TCoCHARGES")
            Dim rpt1 = New ReportDataSource("DataSet1", Dst.Tables("BCoCHARGES"))
            Dim rpt2 = New ReportDataSource("DataSet2", Dst.Tables("TCoCHARGES"))
            '  ReportViewer1.LocalReport.DataSources.Clear()

            Me.ReportViewer1.LocalReport.DataSources.Add(rpt2)
            Me.ReportViewer1.LocalReport.DataSources.Add(rpt1)
            Me.ReportViewer1.RefreshReport()
            MyConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class