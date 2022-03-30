Imports System.Data.OleDb
Imports System.String
Imports Microsoft.Reporting.WinForms
Public Class billviewerpage1

    Private Sub billviewerpage1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BILL.Close()
        Me.TopMost = True
        Me.Location = New Point(400, 60)
        'TODO: This line of code loads data into the 'collegeDataSet2.TOPBILLP1' table. You can move, or remove it, as needed.
        '  Me.TOPBILLP1TableAdapter.Fill(Me.collegeDataSet2.TOPBILLP1)
        'TODO: This line of code loads data into the 'collegeDataSet2.P1BOTTOMBILL' table. You can move, or remove it, as needed.
        '   Me.P1BOTTOMBILLTableAdapter.Fill(Me.collegeDataSet2.P1BOTTOMBILL)

        ' Me.ReportViewer1.RefreshReport()
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
            Dim da2 As OleDbDataAdapter
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            MyConn.Open()
            da1 = New OleDbDataAdapter("Select * from [P1BOTTOMBILL]", MyConn)
            da2 = New OleDbDataAdapter("Select * from [TOPBILLP1]", MyConn)
            da1.Fill(Dst, "P1BOTTOMBILL")
            da2.Fill(Dst, "TOPBILLP1")
            Dim rpt1 = New ReportDataSource("DataSet1", Dst.Tables("P1BOTTOMBILL"))
            Dim rpt2 = New ReportDataSource("DataSet2", Dst.Tables("TOPBILLP1"))
            '  ReportViewer1.LocalReport.DataSources.Clear()

            Me.ReportViewer1.LocalReport.DataSources.Add(rpt2)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class