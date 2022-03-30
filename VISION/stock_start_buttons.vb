Imports System
Imports ADOX
Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Public Class stock_start_buttons
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim da1 As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim da3 As OleDbDataAdapter
    Dim da4 As OleDbDataAdapter
    Dim ds As DataSet
    Dim db_reader As OleDbDataReader
    Dim source1 As New BindingSource
    Dim DT As DataTable
    Dim tables As DataTableCollection
    Dim qty1 As Integer
    Dim qty2 As Integer
    Dim tot As Integer
    Private Sub stock_start_buttons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        STOCKFI()
        Me.CenterToScreen()
        Me.TopMost = True
        OneGive3dLook()
        TwoGive3dLook()
        ThreeGive3dLook()
        FIVEGive3dLook()


    End Sub
    Private Sub OneGive3dLook()
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Dim grPath As GraphicsPath = New GraphicsPath()
        grPath.AddEllipse(0, 0, Button1.Width - 2, Button1.Height - 2)
        Button1.Region = New Region(grPath)


        Dim newbitmap As Bitmap
        newbitmap = New Bitmap(Button1.Width, Button1.Height, PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(newbitmap)

        Dim brish As LinearGradientBrush
        Dim rect As New Rectangle(0, 0, Button1.Width, Button1.Height)
        brish = New LinearGradientBrush(rect, Color.FromArgb(134, 179, 209), Color.FromArgb(127, 151, 173), LinearGradientMode.Vertical)
        g.FillEllipse(brish, New Rectangle(0, 0, Button1.Width, Button1.Height))


        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, Button1.Width, Button1.Height)
        Dim pthGrBrush As New PathGradientBrush(path)
        pthGrBrush.CenterColor = Color.White

        Dim colors As Color() = {Color.FromArgb(134, 179, 209)}
        pthGrBrush.SurroundColors = colors
        g.FillEllipse(pthGrBrush, New Rectangle(6, 0, Button1.Width - 12, Button1.Height - 5))

        Button1.BackgroundImage = newbitmap
    End Sub
    Private Sub TwoGive3dLook()
        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Dim grPath As GraphicsPath = New GraphicsPath()
        grPath.AddEllipse(0, 0, Button2.Width - 2, Button2.Height - 2)
        Button2.Region = New Region(grPath)


        Dim newbitmap As Bitmap
        newbitmap = New Bitmap(Button2.Width, Button2.Height, PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(newbitmap)

        Dim brish As LinearGradientBrush
        Dim rect As New Rectangle(0, 0, Button2.Width, Button2.Height)
        brish = New LinearGradientBrush(rect, Color.FromArgb(134, 179, 209), Color.FromArgb(127, 151, 173), LinearGradientMode.Vertical)
        g.FillEllipse(brish, New Rectangle(0, 0, Button2.Width, Button2.Height))


        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, Button2.Width, Button2.Height)
        Dim pthGrBrush As New PathGradientBrush(path)
        pthGrBrush.CenterColor = Color.White

        Dim colors As Color() = {Color.FromArgb(134, 179, 209)}
        pthGrBrush.SurroundColors = colors
        g.FillEllipse(pthGrBrush, New Rectangle(6, 0, Button2.Width - 12, Button2.Height - 5))

        Button2.BackgroundImage = newbitmap
    End Sub
    Private Sub ThreeGive3dLook()
        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.BorderSize = 0
        Dim grPath As GraphicsPath = New GraphicsPath()
        grPath.AddEllipse(0, 0, Button3.Width - 2, Button3.Height - 2)
        Button3.Region = New Region(grPath)


        Dim newbitmap As Bitmap
        newbitmap = New Bitmap(Button3.Width, Button3.Height, PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(newbitmap)

        Dim brish As LinearGradientBrush
        Dim rect As New Rectangle(0, 0, Button3.Width, Button3.Height)
        brish = New LinearGradientBrush(rect, Color.FromArgb(134, 179, 209), Color.FromArgb(127, 151, 173), LinearGradientMode.Vertical)
        g.FillEllipse(brish, New Rectangle(0, 0, Button3.Width, Button3.Height))


        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, Button3.Width, Button3.Height)
        Dim pthGrBrush As New PathGradientBrush(path)
        pthGrBrush.CenterColor = Color.White

        Dim colors As Color() = {Color.FromArgb(134, 179, 209)}
        pthGrBrush.SurroundColors = colors
        g.FillEllipse(pthGrBrush, New Rectangle(6, 0, Button3.Width - 12, Button3.Height - 5))

        Button3.BackgroundImage = newbitmap
    End Sub
    Private Sub FIVEGive3dLook()
        Button5.FlatStyle = FlatStyle.Flat
        Button5.FlatAppearance.BorderSize = 0
        Dim grPath As GraphicsPath = New GraphicsPath()
        grPath.AddEllipse(0, 0, Button5.Width - 2, Button5.Height - 2)
        Button5.Region = New Region(grPath)


        Dim newbitmap As Bitmap
        newbitmap = New Bitmap(Button1.Width, Button1.Height, PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(newbitmap)

        Dim brish As LinearGradientBrush
        Dim rect As New Rectangle(0, 0, Button5.Width, Button5.Height)
        brish = New LinearGradientBrush(rect, Color.FromArgb(134, 179, 209), Color.FromArgb(127, 151, 173), LinearGradientMode.Vertical)
        g.FillEllipse(brish, New Rectangle(0, 0, Button5.Width, Button5.Height))


        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, Button5.Width, Button5.Height)
        Dim pthGrBrush As New PathGradientBrush(path)
        pthGrBrush.CenterColor = Color.White

        Dim colors As Color() = {Color.FromArgb(134, 179, 209)}
        pthGrBrush.SurroundColors = colors
        g.FillEllipse(pthGrBrush, New Rectangle(6, 0, Button5.Width - 12, Button5.Height - 5))

        Button5.BackgroundImage = newbitmap
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "FILLSTOCK"})
            If SchemaTable1.Rows.Count <> 0 Then
                ' DELETE RECORD FROM BOTH 
                '    INSERT RECORD IN BOTH
                MsgBox("Exists and Now Packed , USE BUTTON ONE AGAIN")
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table FILLSTOCK")
                cmd7.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                AccessConnection.Close()
                Exit Sub
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [FILLSTOCK] ([SNo] INTEGER,[Item_Name] TEXT(30),[Qty] INTEGER,[Issue_Name] TEXT(30),[Issue_Item] Text(30),[Issue_Qty] INTEGER,[Stock_Date] Text(10),[Item_Purchased] TEXT(50),[P_Rate] INTEGER,[P_Qty] INTEGER,[Amount] INTEGER,[Purchase_Date] TEXT(10))", Conn)
                    Dim cmd2 As New OleDb.OleDbCommand("INSERT INTO FILLSTOCK SELECT * FROM StockR", Conn)
                    cmd1.Connection = Conn
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                    Conn.Close()
                    MsgBox("Success")
                Catch ex As Exception
                End Try
            End If
            AccessConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Try
            Dim com As OleDbCommand
            com = New OleDb.OleDbCommand("delete from FILLSTOCK where Item_Name =@sno and Qty =@sno and Issue_Name =@sno and Issue_Item =@sno and Issue_Qty =@sno and Item_Purchased =@sno and Amount =@sno", Con)
            Con.Open()
            com.Parameters.AddWithValue("@sno", "" & 0 & "")
            com.ExecuteNonQuery()
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        clear()
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [FILLSTOCK]", MyConn)
            da.Fill(ds, "FILLSTOCK")
            Dim i As Integer = 0
            'Item_Name,Qty,Issue_Name,Issue_Item,Issue_Qty,Item_Purchased,P_Qty
            For i = i To ds.Tables("FILLSTOCK").Rows.Count - 1 Step 1
                ListBox4.Items.Add(ds.Tables("FILLSTOCK").Rows(i).Item(1))
                ListBox5.Items.Add(ds.Tables("FILLSTOCK").Rows(i).Item(2))
                ListBox6.Items.Add(ds.Tables("FILLSTOCK").Rows(i).Item(7))
                ListBox7.Items.Add(ds.Tables("FILLSTOCK").Rows(i).Item(9))

                ListBox8.Items.Add(ds.Tables("FILLSTOCK").Rows(i).Item(3))
                ListBox9.Items.Add(ds.Tables("FILLSTOCK").Rows(i).Item(4))
                ListBox1.Items.Add(ds.Tables("FILLSTOCK").Rows(i).Item(5))

            Next i

        Catch ex As Exception
        End Try
        emitzero()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox10.Items.Clear()
        ListBox11.Items.Clear()
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("Select * from [BFILLSTOCK]", MyConn)
            da.Fill(ds, "BFILLSTOCK")
            Dim i As Integer = 0
            'Item_Name,Qty,Issue_Name,Issue_Item,Issue_Qty,Item_Purchased,P_Qty
            For i = i To ds.Tables("BFILLSTOCK").Rows.Count - 1 Step 1
                ListBox10.Items.Add(ds.Tables("BFILLSTOCK").Rows(i).Item(0))
                ListBox11.Items.Add(ds.Tables("BFILLSTOCK").Rows(i).Item(1))

            Next i

        Catch ex As Exception
        End Try

    End Sub
    Public Sub emitzero()
        For i As Integer = ListBox4.Items.Count - 1 To 0 Step -1
            If ListBox4.Items.Item(i) = "" & 0 & "" Then
                ListBox4.Items.RemoveAt(i)
            End If
        Next
        For i As Integer = ListBox5.Items.Count - 1 To 0 Step -1
            If ListBox5.Items.Item(i) = "" & 0 & "" Then
                ListBox5.Items.RemoveAt(i)
            End If
        Next
        For i As Integer = ListBox6.Items.Count - 1 To 0 Step -1
            If ListBox6.Items.Item(i) = "" & 0 & "" Then
                ListBox6.Items.RemoveAt(i)
            End If
        Next
        For i As Integer = ListBox7.Items.Count - 1 To 0 Step -1
            If ListBox7.Items.Item(i) = "" & 0 & "" Then
                ListBox7.Items.RemoveAt(i)
            End If
        Next
        For i As Integer = ListBox8.Items.Count - 1 To 0 Step -1
            If ListBox8.Items.Item(i) = "" & 0 & "" Then
                ListBox8.Items.RemoveAt(i)
            End If
        Next
        For i As Integer = ListBox9.Items.Count - 1 To 0 Step -1
            If ListBox9.Items.Item(i) = "" & 0 & "" Then
                ListBox9.Items.RemoveAt(i)
            End If
        Next
        For i As Integer = ListBox9.Items.Count - 1 To 0 Step -1
            If ListBox9.Items.Item(i) = "" & 0 & "" Then
                ListBox9.Items.RemoveAt(i)
            End If
        Next
        For i As Integer = ListBox1.Items.Count - 1 To 0 Step -1
            If ListBox1.Items.Item(i) = "" & 0 & "" Then
                ListBox1.Items.RemoveAt(i)
            End If
        Next
        For i As Integer = ListBox10.Items.Count - 1 To 0 Step -1
            If ListBox10.Items.Item(i) = "" & 0 & "" Then
                ListBox10.Items.RemoveAt(i)
            End If
        Next
        For i As Integer = ListBox11.Items.Count - 1 To 0 Step -1
            If ListBox11.Items.Item(i) = "" & 0 & "" Then
                ListBox11.Items.RemoveAt(i)
            End If
        Next
        For i As Integer = ListBox12.Items.Count - 1 To 0 Step -1
            If ListBox12.Items.Item(i) = "" & 0 & "" Then
                ListBox12.Items.RemoveAt(i)
            End If
        Next
        For i As Integer = ListBox13.Items.Count - 1 To 0 Step -1
            If ListBox13.Items.Item(i) = "" & 0 & "" Then
                ListBox13.Items.RemoveAt(i)
            End If
        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox12.Items.Clear()
        ListBox13.Items.Clear()
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da3 = New OleDbDataAdapter("Select * from [BFILLSTOCK]", MyConn)
        da3.Fill(ds, "BFILLSTOCK")
        da4 = New OleDbDataAdapter("Select * from [StockR]", MyConn)
        da4.Fill(ds, "StockR")
        Try
            For i As Integer = 0 To ds.Tables("BFILLSTOCK").Rows.Count Step 1
                For j As Integer = 0 To ds.Tables("StockR").Rows.Count - 1 Step 1
                    If ds.Tables("BFILLSTOCK").Rows(i).Item(0) = ds.Tables("StockR").Rows(j).Item(4) Then
                        qty1 = ds.Tables("BFILLSTOCK").Rows(i).Item(1)
                        qty2 = ds.Tables("StockR").Rows(j).Item(5)
                        tot = qty1 - qty2
                        ListBox12.Items.Add(ds.Tables("BFILLSTOCK").Rows(i).Item(0))
                        ListBox13.Items.Add(tot)
                    End If
                Next j
            Next i
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        emitzero()
    End Sub
    Private Sub clear()
        ListBox1.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()
        ListBox9.Items.Clear()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Private Sub total()
        Try
            For i As Integer = 0 To ds.Tables("FILLSTOCK").Rows.Count Step 1
                For j As Integer = 0 To ds.Tables("FILLSTOCK").Rows.Count - 1 Step 1
                    If ds.Tables("FILLSTOCK").Rows(i).Item(1) = ds.Tables("FILLSTOCK").Rows(j).Item(7) Then
                        qty1 = ds.Tables("FILLSTOCK").Rows(i).Item(2)
                        qty2 = ds.Tables("FILLSTOCK").Rows(j).Item(9)
                        tot = qty1 + qty2
                        ListBox10.Items.Add(ds.Tables("FILLSTOCK").Rows(i).Item(1))
                        ListBox11.Items.Add(tot)
                    End If
                Next j
            Next i
        Catch ex As Exception
        End Try
        emitzero()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label1.Visible = False
        LineShape1.Visible = False
        Me.TopMost = False

        With Me.PrintForm1
            .PrintAction = Printing.PrintAction.PrintToPreview
            Dim MyMargins As New Margins
            With MyMargins
                .Left = 0.5
                .Right = 0.2
                .Top = 0.5
                .Bottom = 0.5
            End With
            .PrinterSettings.DefaultPageSettings.Margins = MyMargins
            .PrinterSettings.DefaultPageSettings.Landscape = True
            .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)

        End With
        Button5.Visible = True
    End Sub


End Class