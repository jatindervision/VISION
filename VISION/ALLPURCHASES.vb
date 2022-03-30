Public Class ALLPURCHASES
    Dim ATOTAL, Dtotal, Ctotal, tot1, tot2, tot3, tot4, tot5, tot6, tot7, tot8, tot9, tot10, tot11, tot12 As Integer
    Private Sub ALLPURCHASES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.TopMost = True
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Amount) FROM StockR ", Con)
        Dim cmd1 As OleDbCommand = New OleDbCommand("SELECT SUM(Amount) FROM Expenses ", Con)

        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM JanSalary", Con)
        Dim cmd3 As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM FebSalary", Con)
        Dim cmd4 As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM MarchSalary", Con)
        Dim cmd5 As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM AprilSalary", Con)
        Dim cmd6 As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM MaySalary", Con)
        Dim cmd7 As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM JuneSalary", Con)
        Dim cmd8 As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM JulySalary", Con)
        Dim cmd9 As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM AugSalary", Con)
        Dim cmd10 As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM SeptSalary", Con)
        Dim cmd11 As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM OctSalary", Con)
        Dim cmd12 As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM NovSalary", Con)
        Dim cmd13 As OleDbCommand = New OleDbCommand("SELECT SUM(Net_Salary) FROM DecSalary", Con)
        Try
            Con.Open()
            Dim tota As Int32 = cmd.ExecuteScalar
            Dim totb As Int32 = cmd1.ExecuteScalar
            If IsDBNull(cmd2.ExecuteScalar) Then
                tot1 = 0
            Else
                tot1 = cmd2.ExecuteScalar
            End If
            If IsDBNull(cmd3.ExecuteScalar) Then
                tot2 = 0
            Else
                tot2 = cmd3.ExecuteScalar
            End If
            If IsDBNull(cmd4.ExecuteScalar) Then
                tot3 = 0
            Else
                tot3 = cmd4.ExecuteScalar
            End If
            If IsDBNull(cmd5.ExecuteScalar) Then
                tot4 = 0
            Else
                tot4 = cmd5.ExecuteScalar
            End If
            If IsDBNull(cmd6.ExecuteScalar) Then
                tot5 = 0
            Else
                tot5 = cmd6.ExecuteScalar
            End If
            If IsDBNull(cmd7.ExecuteScalar) Then
                tot6 = 0
            Else
                tot6 = cmd7.ExecuteScalar
            End If
            If IsDBNull(cmd8.ExecuteScalar) Then
                tot7 = 0
            Else
                tot7 = cmd8.ExecuteScalar
            End If
            If IsDBNull(cmd9.ExecuteScalar) Then
                tot8 = 0
            Else
                tot8 = cmd9.ExecuteScalar
            End If
            If IsDBNull(cmd10.ExecuteScalar) Then
                tot9 = 0
            Else
                tot9 = cmd10.ExecuteScalar
            End If
            If IsDBNull(cmd11.ExecuteScalar) Then
                tot10 = 0
            Else
                tot10 = cmd11.ExecuteScalar

            End If
            If IsDBNull(cmd12.ExecuteScalar) Then
                tot11 = 0
            Else
                tot11 = cmd12.ExecuteScalar
            End If
            If IsDBNull(cmd13.ExecuteScalar) Then
                tot12 = 0
            Else
                tot12 = cmd13.ExecuteScalar
            End If
            Ctotal = tota + totb
            Dtotal = tot1 + tot2 + tot3 + tot4 + tot5 + tot6 + tot7 + tot8 + tot9 + tot10 + tot11 + tot12
            Con.Close()
            Label5.Text = tota.ToString("Rs:##############.00")
            Label6.Text = totb.ToString("Rs:##############.00")
            Label3.Text = Ctotal.ToString("Rs:##############.00")
            Label9.Text = Dtotal.ToString("Rs:##############.00")

            ATOTAL = tota + totb + Ctotal + Dtotal
            Label11.Text = ATOTAL.ToString("Rs:##############.00")
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class