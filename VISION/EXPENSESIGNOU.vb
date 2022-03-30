Imports System.Data.OleDb
Public Class EXPENSESIGNOU
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim ds As DataSet
    Dim db_reader As OleDbDataReader
    Dim source1 As New BindingSource
    Dim DT As DataTable
    Dim tables As DataTableCollection

    Private Sub EXPENSESIGNOU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        entto()
        Me.CenterToScreen()
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "IGEXPENSES"})

            If SchemaTable1.Rows.Count <> 0 Then
                ' DELETE RECORD FROM BOTH 
                '    INSERT RECORD IN BOTH
                MsgBox("Exists and Now Packed USE THIS AGAIN")
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table IGEXPENSES")
                cmd7.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                AccessConnection.Close()
                Me.Close()
            Else
                AccessConnection.Close()
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [IGEXPENSES] ([Postage] INTEGER,[Telephone] INTEGER,[Stationary] INTEGER,[Furniture] INTEGER,[Equipment] INTEGER,[Electricity_Charges] INTEGER,[Water_Charges] INTEGER,[Printing_Binding] INTEGER,[Entertainment] INTEGER,[Date_of_Expense] TEXT(10))", Conn)
                    cmd.Connection = Conn
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [IGNOUExpenses]", MyConn)
            da.Fill(ds, "IGNOUExpenses")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim sqlquery As String = "INSERT INTO IGEXPENSES " & "(Postage,Telephone,Stationary,Furniture,Equipment,Electricity_Charges,Water_Charges,Printing_Binding,Entertainment)" & "VALUES (@Postage,@Telephone,@Stationary,@Furniture,@Equipment,@Electricity_Charges,@Water_Charges,@Printing_Binding,@Entertainment)"

            ' Use this form to initialize both connection and command to 
            ' avoid forgetting to set the appropriate properties....
            Using ronn = New System.Data.OleDb.OleDbConnection(cnString)
                Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, ronn)

                    ronn.Open()
                    Dim A As Integer = 0
                    cmd.Parameters.AddWithValue("@Postage", A)
                    cmd.Parameters.AddWithValue("@Telephone", A)
                    cmd.Parameters.AddWithValue("@Stationary", A)
                    cmd.Parameters.AddWithValue("@Furniture", A)
                    cmd.Parameters.AddWithValue("@Equipment", A)
                    cmd.Parameters.AddWithValue("@Electricity_Charges", A)
                    cmd.Parameters.AddWithValue("@Water_Charges", A)
                    cmd.Parameters.AddWithValue("@Printing_Binding", A)
                    cmd.Parameters.AddWithValue("@Entertainment", A)
                    Dim rowsInserted = cmd.ExecuteNonQuery()
                End Using
            End Using
                      Catch ex As Exception
        End Try
        finalbillstart.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim min As Integer
        Dim max As Integer
        min = Convert.ToInt32(TextBox1.Text.Trim())
        max = Convert.ToInt32(TextBox2.Text.Trim())
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [IGNOUExpenses]", MyConn)
        da.Fill(ds, "IGNOUExpenses")
        Dim i As Integer = 0
        i = i + Convert.ToInt32(min)
        Dim a1, a2, a3, a4, a5, a6, a7, a8, a9 As Integer
        For i = i - 1 To max - 1 Step 1
            Dim b1 As Int32 = ds.Tables("IGNOUExpenses").Rows(i)("Postage")
            a1 = a1 + b1
            Dim b2 As Int32 = ds.Tables("IGNOUExpenses").Rows(i)("Telephone")
            a2 = a2 + b2
            Dim b3 As Int32 = ds.Tables("IGNOUExpenses").Rows(i)("Stationary")
            a3 = a3 + b3
            Dim b4 As Int32 = ds.Tables("IGNOUExpenses").Rows(i)("Furniture")
            a4 = a4 + b4
            Dim b5 As Int32 = ds.Tables("IGNOUExpenses").Rows(i)("Equipment")
            a5 = a5 + b5
            Dim b6 As Int32 = ds.Tables("IGNOUExpenses").Rows(i)("Electricity_Charges")
            a6 = a6 + b6
            Dim b7 As Int32 = ds.Tables("IGNOUExpenses").Rows(i)("Water_Charges")
            a7 = a7 + b7
            Dim b8 As Int32 = ds.Tables("IGNOUExpenses").Rows(i)("Printing_Binding")
            a8 = a8 + b8
            Dim b9 As Int32 = ds.Tables("IGNOUExpenses").Rows(i)("Entertainment")
            a9 = a9 + b9
        Next i
        Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        Dim sqlquery As String = "INSERT INTO IGEXPENSES (Postage,Telephone,Stationary,Furniture,Equipment,Electricity_Charges,Water_Charges,Printing_Binding,Entertainment)" & "VALUES (@Postage,@Telephone,@Stationary,@Furniture,@Equipment,@Electricity_Charges,@Water_Charges,@Printing_Binding,@Entertainment)"

        ' Use this form to initialize both connection and command to 
        ' avoid forgetting to set the appropriate properties....
        Using ronn = New System.Data.OleDb.OleDbConnection(cnString)
            Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, ronn)
                ronn.Open()
                cmd.Parameters.AddWithValue("@Postage", a1.ToString)
                cmd.Parameters.AddWithValue("@Telephone", a2.ToString)
                cmd.Parameters.AddWithValue("@Stationary", a3.ToString)
                cmd.Parameters.AddWithValue("@Furniture", a4.ToString)
                cmd.Parameters.AddWithValue("@Equipment", a5.ToString)
                cmd.Parameters.AddWithValue("@Electricity_Charges", a6.ToString)
                cmd.Parameters.AddWithValue("@Water_Charges", a7.ToString)
                cmd.Parameters.AddWithValue("@Printing_Binding", a8.ToString)
                cmd.Parameters.AddWithValue("@Entertainment", a9.ToString)
                Dim rowsInserted = cmd.ExecuteNonQuery()
            End Using
        End Using
        finalbillstart.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd1 As OleDbCommand = New OleDbCommand("SELECT SUM(Postage) FROM IGNOUExpenses", Con)
        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT SUM(Telephone) FROM IGNOUExpenses", Con)
        Dim cmd3 As OleDbCommand = New OleDbCommand("SELECT SUM(Stationary) FROM IGNOUExpenses", Con)
        Dim cmd4 As OleDbCommand = New OleDbCommand("SELECT SUM(Furniture) FROM IGNOUExpenses", Con)
        Dim cmd5 As OleDbCommand = New OleDbCommand("SELECT SUM(Equipment) FROM IGNOUExpenses", Con)
        Dim cmd6 As OleDbCommand = New OleDbCommand("SELECT SUM(Electricity_Charges) FROM IGNOUExpenses", Con)
        Dim cmd7 As OleDbCommand = New OleDbCommand("SELECT SUM(Water_Charges) FROM IGNOUExpenses", Con)
        Dim cmd8 As OleDbCommand = New OleDbCommand("SELECT SUM(Printing_Binding) FROM IGNOUExpenses", Con)
        Dim cmd9 As OleDbCommand = New OleDbCommand("SELECT SUM(Entertainment) FROM IGNOUExpenses", Con)
        'Dim cmd9 As OleDbCommand = New OleDbCommand("SELECT SUM(Postage),SUM(Telephone),SUM(Stationary),SUM(Furniture),SUM(Equipment),SUM(Electricity_Charges),SUM(Water_Charges),SUM(Printing_Binding),SUM(Entertainment) FROM IGNOUExpenses", Con)
        Con.Open()
        Dim a1 As Int32 = cmd1.ExecuteScalar
        Dim a2 As Int32 = cmd2.ExecuteScalar
        Dim a3 As Int32 = cmd3.ExecuteScalar
        Dim a4 As Int32 = cmd4.ExecuteScalar
        Dim a5 As Int32 = cmd5.ExecuteScalar
        Dim a6 As Int32 = cmd6.ExecuteScalar
        Dim a7 As Int32 = cmd7.ExecuteScalar
        Dim a8 As Int32 = cmd8.ExecuteScalar
        Dim a9 As Int32 = cmd9.ExecuteScalar
        Con.Close()
        Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
        Dim sqlquery As String = "INSERT INTO IGEXPENSES (Postage,Telephone,Stationary,Furniture,Equipment,Electricity_Charges,Water_Charges,Printing_Binding,Entertainment)" & "VALUES (@Postage,@Telephone,@Stationary,@Furniture,@Equipment,@Electricity_Charges,@Water_Charges,@Printing_Binding,@Entertainment)"

        ' Use this form to initialize both connection and command to 
        ' avoid forgetting to set the appropriate properties....
        Using ronn = New System.Data.OleDb.OleDbConnection(cnString)
            Using cmd = New System.Data.OleDb.OleDbCommand(sqlquery, ronn)

                ronn.Open()

                cmd.Parameters.AddWithValue("@Postage", a1.ToString)
                cmd.Parameters.AddWithValue("@Telephone", a2.ToString)
                cmd.Parameters.AddWithValue("@Stationary", a3.ToString)
                cmd.Parameters.AddWithValue("@Furniture", a4.ToString)
                cmd.Parameters.AddWithValue("@Equipment", a5.ToString)
                cmd.Parameters.AddWithValue("@Electricity_Charges", a6.ToString)
                cmd.Parameters.AddWithValue("@Water_Charges", a7.ToString)
                cmd.Parameters.AddWithValue("@Printing_Binding", a8.ToString)
                cmd.Parameters.AddWithValue("@Entertainment", a9.ToString)
                Dim rowsInserted = cmd.ExecuteNonQuery()
            End Using
        End Using
       
        finalbillstart.Show()
    End Sub
End Class