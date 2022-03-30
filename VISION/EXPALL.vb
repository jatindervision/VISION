
Imports System.Data.OleDb
Imports System.String
Imports Microsoft.Reporting.WinForms
Public Class EXPALL
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim DT As DataTable
    Dim tables As DataTableCollection
    Private sno As String = Expenses.TextBox7.Text
    Private Sub EXPALL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'collegeDataSet3.exprepo' table. You can move, or remove it, as needed.
        ' Me.exprepoTableAdapter.Fill(Me.collegeDataSet3.exprepo)
        cexpcol()
        Me.CenterToScreen()
        Me.TopMost = True

        Try
            Dim com As OleDbCommand

            com = New OleDb.OleDbCommand("delete from exprepo where Item_Name =@sno", Con)
            Con.Open()
            com.Parameters.AddWithValue("@sno", "" & 0 & "")
            com.ExecuteNonQuery()
            Con.Close()

        Catch ex As Exception
            MessageBox.Show("Could Not delete Record!!!")
            MsgBox(ex.Message & " -  " & ex.Source)
            Con.Close()
        End Try



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            da1 = New OleDbDataAdapter("Select * from [exprepo]", MyConn)

            da1.Fill(Dst, "exprepo")

            Dim rpt1 = New ReportDataSource("DataSet1", Dst.Tables("exprepo"))
            Me.ReportViewer1.LocalReport.DataSources.Add(rpt1)
            Me.ReportViewer1.RefreshReport()
            MyConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class