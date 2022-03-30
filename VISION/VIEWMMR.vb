Imports System.Data.OleDb
Imports System.String
Imports Microsoft.Reporting.WinForms
Public Class VIEWMMR

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
            da1 = New OleDbDataAdapter("Select * from [MMR]", MyConn)
            da1.Fill(Dst, "MMR")
            Dim rpt1 = New ReportDataSource("DataSet1", Dst.Tables("MMR"))
            Me.ReportViewer1.LocalReport.DataSources.Add(rpt1)
            Me.ReportViewer1.RefreshReport()

            MyConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dst.Clear()
        ReportViewer1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub VIEWMMR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VIMMR()
        Me.TopMost = True
        Me.CenterToScreen()
    End Sub
End Class