Imports System.Data.OleDb


Public Class Expenses
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim ds1 As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim tables1 As DataTableCollection
    Dim source2 As New BindingSource
    Dim source3 As New BindingSource
    Private StatusDate As String
    Dim TOT As Integer
    Dim Qt As Integer

    Private Sub Expenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForExpenses()
        Me.CenterToScreen()
        Me.TopMost = True
        DateT.Text = DateTimePicker2.Value.ToShortDateString
        D.Text = DateTimePicker2.Value.ToShortDateString
        TextBox7.Text = "" & 0 & ""
        TextBox7.Visible = False

        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "BFILLSTOCK"})
            If SchemaTable1.Rows.Count <> 0 Then
               
                AccessConnection.Close()
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [BFILLSTOCK] ([TItem_Name] TEXT(30),[TQty] INTEGER)", Conn)


                    cmd1.Connection = Conn
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
                    Conn.Close()
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try

        num2()
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select SNo,Item_Purchased,P_Rate,P_Qty,Amount,Purchase_Date from [Expenses]", MyConn)
            da.Fill(ds, "Expenses")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            
        
     
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da2 = New OleDbDataAdapter("Select SNo,Item_Purchased,P_Rate,P_Qty,Amount,Purchase_Date from [StockR]", MyConn)
            da2.Fill(ds, "StockR")
            Dim view3 As New DataView(tables(0))
            source3.DataSource = view3
            DataGridView2.DataSource = view3


        Catch ex As Exception
        End Try
        
    End Sub
    Private Sub num2()
        Try
            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)
            Dim cmd As New OleDb.OleDbCommand("Select count(SNo) from StockR", Conn)
            Dim number As Integer = 1
            Conn.Open()
            If IsDBNull(cmd.ExecuteScalar) Then

                Label19.Text = number
                Label20.Text = number

            Else
                number = cmd.ExecuteScalar

                Label19.Text = number + 1
                Label20.Text = number + 1
            End If
            Conn.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub num3()
        Try
            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)
            Dim cmd As New OleDb.OleDbCommand("Select count(SNo) from Expenses", Conn)
            Dim number As Integer = 1
            Conn.Open()
            If IsDBNull(cmd.ExecuteScalar) Then

                Label19.Text = number
                Label20.Text = number

            Else
                number = cmd.ExecuteScalar

                Label19.Text = number + 1
                Label20.Text = number + 1
            End If
            Conn.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ShowData(ByVal CurrentRow)
        Try

            ItemName.Text = Dst.Tables("Expenses").Rows(CurrentRow)("Item_Name")
            Rate.Text = Dst.Tables("Expenses").Rows(CurrentRow)("Rate")
            Qty.Text = Dst.Tables("Expenses").Rows(CurrentRow)("Qty")
            Amount.Text = Dst.Tables("Expenses").Rows(CurrentRow)("Amount")
            DateT.Text = Dst.Tables("Expenses").Rows(CurrentRow)("Date")

        Catch ex As Exception
        End Try
    End Sub
    Private Sub Clear()

        I.Text = ""
        R.Text = ""
        Q.Text = ""
        Camount.Text = ""

        ItemName.Text = ""
        Amount.Text = ""
        DateT.Text = DateTimePicker2.Value.ToShortDateString
        D.Text = DateTimePicker2.Value.ToShortDateString
       
        

    End Sub
   

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da2 = New OleDbDataAdapter("Select * from [BFILLSTOCK]", MyConn)
        da2.Fill(ds, "BFILLSTOCK")
        If CheckBox3.Checked = False And CheckBox4.Checked = False Then
            MsgBox("YOU HAVE NOT SELECTED  STOCK OR NON STOCK")
            Exit Sub
        End If
        If CheckBox3.Checked = True And CheckBox4.Checked = True Then
            MsgBox("YOU HAVE SELECTED BOTH  STOCK OR NON STOCK")
            Exit Sub
        End If
        If CheckBox3.Checked = True And CheckBox4.Checked = False Then
            MsgBox(" YOU HAVE CHOOSED IT AS STOCK ITEM")
            Dim sn As Integer = 0
            num2()
            Me.TopMost = False
            StatusDate = InputBox("Enter QUANTITY ?", "{e.g 10", "  ")
            Qt = Convert.ToString(StatusDate)
            For K As Integer = 0 To ds.Tables("BFILLSTOCK").Rows.Count - 1 Step 1
                If ds.Tables("BFILLSTOCK").Rows(K).Item(0) = ItemName.Text.Trim() Then
                    Dim qq As Integer
                    Dim AQQ As Integer
                    qq = Convert.ToInt32(Qt)
                    AQQ = Convert.ToInt32(ds.Tables("BFILLSTOCK").Rows(K).Item(1))
                    TOT = qq + AQQ
                    Try
                        Dim Str As String
                        Con.Open()
                        Str = "update BFILLSTOCK set TQty="
                        Str += """" & TOT & """"
                        Str += " where TItem_Name="
                        Str += """" & ItemName.Text.Trim() & """"
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Con.Close()
                        GoTo Label20
                    Catch ex As Exception
                        MsgBox(ex.Message & ",")
                    End Try
                End If
            Next K
            For L As Integer = 0 To ds.Tables("BFILLSTOCK").Rows.Count - 1 Step 1
                If ds.Tables("BFILLSTOCK").Rows(L).Item(0) <> ItemName.Text.Trim() Then
                    Dim Str As String
                    Dim QTQT As Integer
                    QTQT = Convert.ToInt32(Qt)
                    Str = "insert into BFILLSTOCK values("
                    Str += """" & ItemName.Text.Trim() & """"
                    Str += ","
                    Str += """" & QTQT & """"
                    Str += ")"
                    Con.Open()
                    Cmd = New OleDbCommand(Str, Con)
                    Cmd.ExecuteNonQuery()
                    Con.Close()
                    MsgBox("Record inserted successfully...")
                    GoTo Label20
                End If
            Next L
Label20:    Try
                texts()
                Dim Str As String
                Dim Rt As Integer

                Rt = 0
                Me.TopMost = False

                ' Qt = 0
                Rate.Text = Convert.ToString(Rt)
                Qty.Text = Convert.ToString(Qt)


                Str = "insert into StockR values("
                Str += Label20.Text.Trim()
                Str += ","
                Str += """" & TextBox1.Text.Trim() & """"
                Str += ","
                Str += """" & TextBox2.Text.Trim() & """"
                Str += ","
                Str += """" & TextBox3.Text.Trim() & """"
                Str += ","
                Str += """" & TextBox4.Text.Trim() & """"
                Str += ","
                Str += """" & TextBox5.Text.Trim() & """"
                Str += ","
                Str += """" & TextBox6.Text.Trim() & """"
                Str += ","
                Str += """" & ItemName.Text.Trim() & """"
                Str += ","
                Str += Rate.Text.Trim()
                Str += ","
                Str += Qty.Text.Trim()
                Str += ","
                Str += Amount.Text.Trim()
                Str += ","
                Str += """" & DateT.Text.Trim() & """"
                Str += ")"
                Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;")
                Con.Open()
                Cmd = New OleDbCommand(Str, Con)
                Cmd.ExecuteNonQuery()
                MsgBox("Record inserted successfully...")
                Clear()
            Catch ex As Exception
                MessageBox.Show("Could Not Insert Record!!!")
                MsgBox(ex.Message & " Some Thing Wrong  ")
                Con.Close()
            End Try
        ElseIf CheckBox3.Checked = False And CheckBox4.Checked = True Then
            MsgBox(" YOU HAVE CHOOSED IT AS NON STOCK ITEM")
            num3()
            Try
                Dim Str As String
                Dim Rt As Integer
                Dim Qt As Integer
                Rt = 0
                Qt = 0
                Rate.Text = Convert.ToString(Rt)
                Qty.Text = Convert.ToString(Qt)
                Str = "insert into Expenses values("
                Str += Label20.Text.Trim()
                Str += ","
                Str += """" & ItemName.Text.Trim() & """"
                Str += ","
                Str += Rate.Text.Trim()
                Str += ","
                Str += Qty.Text.Trim()
                Str += ","
                Str += Amount.Text.Trim()
                Str += ","
                Str += """" & DateT.Text.Trim() & """"
                Str += ")"
                Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;")
                Con.Open()
                Cmd = New OleDbCommand(Str, Con)
                Cmd.ExecuteNonQuery()
                MsgBox("Record inserted successfully...")
                Clear()
            Catch ex As Exception
                MessageBox.Show("Could Not Insert Record!!!")
                MsgBox(ex.Message & " Some Thing Wrong  ")
                Con.Close()
            End Try
        End If
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select SNo,Item_Purchased,P_Rate,P_Qty,Amount,Purchase_Date from [Expenses]", MyConn)
            da.Fill(ds, "Expenses")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view



            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da2 = New OleDbDataAdapter("Select SNo,Item_Purchased,P_Rate,P_Qty,Amount,Purchase_Date from [StockR]", MyConn)
            da2.Fill(ds, "StockR")
            Dim view3 As New DataView(tables(0))
            source3.DataSource = view3
            DataGridView2.DataSource = view3


        Catch ex As Exception
        End Try
        num2()
        ItemName.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        ShowExpenses.Show()
    End Sub
   

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da2 = New OleDbDataAdapter("Select * from [BFILLSTOCK]", MyConn)
        da2.Fill(ds, "BFILLSTOCK")
       
        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MsgBox("YOU HAVE NOT SELECTED  STOCK OR NON STOCK")
            Exit Sub
        End If
        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            MsgBox("YOU HAVE SELECTED BOTH  STOCK OR NON STOCK")
            Exit Sub
        End If

        If CheckBox1.Checked = True And CheckBox2.Checked = False Then
            MsgBox(" YOU HAVE CHOOSED IT AS STOCK ITEM")
            texts()
            num2()

            For K As Integer = 0 To ds.Tables("BFILLSTOCK").Rows.Count - 1 Step 1
                If ds.Tables("BFILLSTOCK").Rows(K).Item(0) = I.Text.Trim() Then
                    Dim qq As Integer
                    Dim AQQ As Integer
                    qq = Convert.ToInt32(Q.Text.Trim())
                    AQQ = Convert.ToInt32(ds.Tables("BFILLSTOCK").Rows(K).Item(1))
                    TOT = qq + AQQ
                    Try
                        Dim Str As String
                        Con.Open()
                        Str = "update BFILLSTOCK set TQty="
                        Str += """" & TOT & """"
                        Str += " where TItem_Name="
                        Str += """" & I.Text.Trim() & """"
                        Cmd = New OleDbCommand(Str, Con)
                        Cmd.ExecuteNonQuery()
                        Con.Close()
                        GoTo Label20
                    Catch ex As Exception
                        MsgBox(ex.Message & ",")
                    End Try
                End If
            Next K
            For L As Integer = 0 To ds.Tables("BFILLSTOCK").Rows.Count - 1 Step 1
                If ds.Tables("BFILLSTOCK").Rows(L).Item(0) <> I.Text.Trim() Then
                    Dim Str As String
                    Dim QTQT As Integer
                    QTQT = Convert.ToInt32(Q.Text.Trim())
                    Str = "insert into BFILLSTOCK values("
                    Str += """" & I.Text.Trim() & """"
                    Str += ","
                    Str += """" & QTQT & """"
                    Str += ")"
                    Con.Open()
                    Cmd = New OleDbCommand(Str, Con)
                    Cmd.ExecuteNonQuery()
                    Con.Close()
                    MsgBox("Record inserted successfully...")
                    GoTo Label20
                End If
            Next L
LABEL20:    Try
                Dim Str As String

                Dim totalAmount As Integer
                totalAmount = 0

                totalAmount = totalAmount + (Convert.ToInt32(R.Text)) * (Convert.ToInt32(Q.Text))
                Dim multi As String
                multi = Convert.ToString(totalAmount)
                Camount.Text = multi


                Str = "insert into StockR values("
                Str += Label19.Text.Trim()
                Str += ","
                Str += """" & TextBox1.Text.Trim() & """"
                Str += ","
                Str += """" & TextBox2.Text.Trim() & """"
                Str += ","
                Str += """" & TextBox3.Text.Trim() & """"
                Str += ","
                Str += """" & TextBox4.Text.Trim() & """"
                Str += ","
                Str += """" & TextBox5.Text.Trim() & """"
                Str += ","
                Str += """" & TextBox6.Text.Trim() & """"
                Str += ","
                Str += """" & I.Text.Trim() & """"
                Str += ","
                Str += R.Text.Trim()
                Str += ","
                Str += Q.Text.Trim()
                Str += ","
                Str += multi
                Str += ","
                Str += """" & D.Text.Trim() & """"
                Str += ")"
                Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;")
                Con.Open()
                Cmd = New OleDbCommand(Str, Con)
                Cmd.ExecuteNonQuery()
                Camount.Text = multi
                MsgBox("Record inserted successfully...")
                Clear()
            Catch ex As Exception
                MessageBox.Show("Could Not Insert Record!!!")
                MsgBox(ex.Message & " Some Thing Wrong  ")
                Con.Close()
            End Try
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True Then
            MsgBox(" YOU HAVE CHOOSED IT AS NON STOCK ITEM")
            num3()
            Try
                Dim Str As String

                Dim totalAmount As Integer
                totalAmount = 0

                totalAmount = totalAmount + (Convert.ToInt32(R.Text)) * (Convert.ToInt32(Q.Text))
                Dim multi As String
                multi = Convert.ToString(totalAmount)
                Camount.Text = multi
                Str = "insert into Expenses values("
                Str += Label19.Text.Trim()
                Str += ","
                Str += """" & I.Text.Trim() & """"
                Str += ","
                Str += R.Text.Trim()
                Str += ","
                Str += Q.Text.Trim()
                Str += ","
                Str += multi
                Str += ","
                Str += """" & D.Text.Trim() & """"
                Str += ")"
                Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;")
                Con.Open()
                Cmd = New OleDbCommand(Str, Con)
                Cmd.ExecuteNonQuery()
                Camount.Text = multi
                MsgBox("Record inserted successfully...")
                Clear()
            Catch ex As Exception
                MessageBox.Show("Could Not Insert Record!!!")
                MsgBox(ex.Message & " Some Thing Wrong  ")
                Con.Close()
            End Try

        End If
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select SNo,Item_Purchased,P_Rate,P_Qty,Amount,Purchase_Date from [Expenses]", MyConn)
            da.Fill(ds, "Expenses")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view



            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da2 = New OleDbDataAdapter("Select SNo,Item_Purchased,P_Rate,P_Qty,Amount,Purchase_Date from [StockR]", MyConn)
            da2.Fill(ds, "StockR")
            Dim view2 As New DataView(tables(0))
            source3.DataSource = view2
            DataGridView2.DataSource = view2


        Catch ex As Exception
        End Try
        num2()
        I.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label7.Text = ""
        Dim cmd1 As OleDbCommand = New OleDbCommand("SELECT SUM(Amount) FROM Expenses", Con)
        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT SUM(Amount) FROM StockR", Con)
        Con.Open()
        Dim tot1 As Int32 = cmd1.ExecuteScalar
        Dim tot2 As Int32 = cmd2.ExecuteScalar
        Dim totall = tot1 + tot2
        'MessageBox.Show(tot1)
        Label7.Text = totall.ToString("Rs:##############.00")
        con.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Clear()
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub ExitNow_Click(sender As Object, e As EventArgs) Handles ExitNow.Click

        Me.Close()
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [Expenses]", MyConn)
            da.Fill(ds, "Expenses")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
          
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "exprepo"})
          
            If SchemaTable1.Rows.Count <> 0 
                '    INSERT RECORD IN BOTH
                MsgBox("Exists and Now Packed , Press Button 1 Again ")
                Dim cmd1 As New OleDb.OleDbCommand("DROP  Table exprepo")
                cmd1.Connection = AccessConnection
                cmd1.ExecuteNonQuery()
                Exit Sub
                AccessConnection.Close()
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [exprepo] ([Item_Name] TEXT(60),[Rate] TEXT(10),[Qty] TEXT(10),[Amount] Double,[Date_of_Purchase] TEXT(10))", Conn)
                    cmd1.Connection = Conn
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
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
            MyConn.Open()
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("SELECT * FROM  Expenses", MyConn)
            da.Fill(ds, "Expenses")

            Dim i As Integer = 0

            For i = i To ds.Tables("Expenses").Rows.Count - 1 Step 1

                ListBox2.Items.Add(ds.Tables("Expenses").Rows(i)("Item_Purchased"))
                ListBox3.Items.Add(ds.Tables("Expenses").Rows(i)("P_Rate"))
                ListBox4.Items.Add(ds.Tables("Expenses").Rows(i)("P_Qty"))
                ListBox5.Items.Add(ds.Tables("Expenses").Rows(i)("Amount"))
                ListBox6.Items.Add(ds.Tables("Expenses").Rows(i)("Purchase_Date"))

            Next i
            da = New OleDbDataAdapter("SELECT * FROM  StockR", MyConn)
            da.Fill(ds, "StockR")
            Dim J As Integer
            ' i = i + Convert.ToInt32(Recmin)
            For J = J To ds.Tables("StockR").Rows.Count - 1 Step 1

                ListBox2.Items.Add(ds.Tables("StockR").Rows(J)("Item_Purchased"))
                ListBox3.Items.Add(ds.Tables("StockR").Rows(J)("P_Rate"))
                ListBox4.Items.Add(ds.Tables("StockR").Rows(J)("P_Qty"))
                ListBox5.Items.Add(ds.Tables("StockR").Rows(J)("Amount"))
                ListBox6.Items.Add(ds.Tables("StockR").Rows(J)("Purchase_Date"))

            Next J
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Try
            Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            Dim Conn As New OleDb.OleDbConnection(ConStr)

            Dim i As Integer
            Dim Str1 As String
            Con.Open()


            For i = 0 To ListBox2.Items.Count - 1

                Str1 = "INSERT INTO [exprepo] VALUES('" & ListBox2.Items.Item(i) & "','" & ListBox3.Items.Item(i) & "','" & ListBox4.Items.Item(i) & "','" & ListBox5.Items.Item(i) & "','" & ListBox6.Items.Item(i) & "')"
                Dim TOP As OleDbCommand = New OleDbCommand(Str1, Con)
                TOP.ExecuteNonQuery()
            Next i
            Con.Close()
        Catch ex As Exception
        End Try
        EXPALL.Show()
    End Sub
    Private Sub texts()
        TextBox1.Text = "" & 0 & ""
        TextBox2.Text = "" & 0 & ""
        TextBox3.Text = "" & 0 & ""
        TextBox4.Text = "" & 0 & ""
        TextBox5.Text = "" & 0 & ""
        TextBox6.Text = "" & 0 & ""
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ListBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox6.SelectedIndexChanged

    End Sub
End Class
