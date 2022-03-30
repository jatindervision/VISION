Imports System.Data
Imports System.Data.OleDb
Public Class MixedIGNOUExcel
    Dim cnString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Private Form3 As New IgnouStStart
    WithEvents bsData As New BindingSource
    Private ConnectionNoHeader As String = "provider= Microsoft.ACE.OLEDB.12.0; data source='{0}';Extended Properties=""Excel 12.0; HDR=Yes;"""
    Private FileName As String = IgnouStStart.TextBox2.Text.Trim()
    Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
    Dim SchemaTable As DataTable
    Dim connString As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Private Sub MixedIGNOUExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mixedignou()
        Me.CenterToScreen()
        Me.TopMost = True
        Try
            Using MyConnection As New OleDbConnection(String.Format(ConnectionNoHeader, FileName))
                Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
                Dim DtSet As System.Data.DataSet

                MyCommand = New System.Data.OleDb.OleDbDataAdapter _
                    ("select * from [Sheet1$]", MyConnection)
                MyCommand.TableMappings.Add("Table", "TestTable")
                DtSet = New System.Data.DataSet
                MyCommand.Fill(DtSet)
                Dim dt As New DataTable


                DataGridView1.DataSource = DtSet.Tables(0)

            End Using

            Label1.Text = DataGridView1.Columns(0).HeaderText
            Label2.Text = DataGridView1.Columns(1).HeaderText
            Label3.Text = DataGridView1.Columns(2).HeaderText
            Label4.Text = DataGridView1.Columns(3).HeaderText
            Label5.Text = DataGridView1.Columns(4).HeaderText
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
     
    End Sub
  
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        disp_all_tables.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox(" :::ENTER PROGRAM NAME ie BCA2:::")
            Exit Sub
        End If
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "TEMPTABLE"})
            If SchemaTable1.Rows.Count = 0 Then

                MsgBox(" FIRST Use Save BUTTON 1 ")
                AccessConnection.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable

            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()

            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "" & TextBox1.Text.Trim() & ""})

            If SchemaTable1.Rows.Count <> 0 Then
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table " & TextBox1.Text.Trim() & "")

                cmd7.Connection = AccessConnection

                cmd7.ExecuteNonQuery()
                MsgBox(" Name Already Exists Now Deleted, Use Save Records Again")
                AccessConnection.Close()
                Exit Sub
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text

                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [" & TextBox1.Text.Trim() & "] ([" & Label1.Text & "] INTEGER,[" & Label2.Text & "] TEXT(50),[" & Label3.Text & "] TEXT(50),[" & Label4.Text & "] TEXT(50),[" & Label5.Text & "] TEXT(50), [CRS1] TEXT(10), [CRS2] TEXT(10), [CRS3] TEXT(10), [CRS4] TEXT(10), [CRS5] TEXT(10), [CRS6] TEXT(10), [CRS7] TEXT(10), [CRS8] TEXT(10), [CRS9] TEXT(10), [CRS10] TEXT(10), [CRS11] TEXT(10), [CRS12] TEXT(10), [CRS13] TEXT(10))", Conn)
                    cmd1.Connection = Conn
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
                    Conn.Close()
                    AccessConnection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If
            ' AccessConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da = New OleDbDataAdapter("Select * from [TEMPTABLE]", MyConn)
            da.Fill(ds, "TEMPTABLE")
            Dim sql As String
            '  For I As Integer = 0 To ds.Tables("TEMPTABLE").Rows.Count - 1 Step 1
            sql = "insert into [" & TextBox1.Text.Trim() & "](" & Label1.Text & "," & Label2.Text & "," & Label3.Text & "," & Label4.Text & "," & Label5.Text & ", CRS1, CRS2, CRS3, CRS4, CRS5, CRS6, CRS7, CRS8, CRS9, CRS10, CRS11, CRS12, CRS13) SELECT " & Label1.Text & "," & Label2.Text & "," & Label3.Text & "," & Label4.Text & "," & Label5.Text & ", CRS1, CRS2, CRS3, CRS4, CRS5, CRS6, CRS7, CRS8, CRS9, CRS10, CRS11, CRS12, CRS13 FROM TEMPTABLE"

            Dim comm As New OleDb.OleDbCommand
            comm.CommandText = sql
            comm.Connection = MyConn
            comm.ExecuteNonQuery()
            '  Next I
            MyConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        ccname()
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [" & TextBox1.Text.Trim() & "]", MyConn)
        da.Fill(ds, "" & TextBox1.Text.Trim() & "")
        ' Filling a employee table 
        Dim dt As DataTable = ds.Tables("" & TextBox1.Text.Trim() & "")
        dt = RemoveDuplicateRows(dt, "SNO")
        DataGridView2.DataSource = ds.Tables("" & TextBox1.Text.Trim() & "").DefaultView
        TextBox1.Text = ""
        MsgBox(" .....SUCCESS..... ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox13.Text = "" Or TextBox14.Text = "" Or TextBox15.Text = "" Then
            MsgBox(" DONT LEAVE ANY FIELD EMPTY , IF ANY FIELD DOES NOT REQUIRE THEN PUT 0 IN THEM")
            Exit Sub
        End If
        Try
            Dim AccessConnection As New System.Data.OleDb.OleDbConnection()
            Dim SchemaTable1 As DataTable
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable1 = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "TEMPTABLE"})

            If SchemaTable1.Rows.Count <> 0 Then
                Dim cmd7 As New OleDb.OleDbCommand("DROP  Table TEMPTABLE")
                cmd7.Connection = AccessConnection
                cmd7.ExecuteNonQuery()
                MsgBox(" Name Already Exists Now Deleted, Use Save BUTTON 1 Again")
                AccessConnection.Close()
                Exit Sub
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd1 As New OleDb.OleDbCommand("CREATE TABLE [TEMPTABLE] ([" & Label1.Text & "] INTEGER,[" & Label2.Text & "] TEXT(50),[" & Label3.Text & "] TEXT(50),[" & Label4.Text & "] TEXT(50),[" & Label5.Text & "] TEXT(50), [CRS1] TEXT(10), [CRS2] TEXT(10), [CRS3] TEXT(10), [CRS4] TEXT(10), [CRS5] TEXT(10), [CRS6] TEXT(10), [CRS7] TEXT(10), [CRS8] TEXT(10), [CRS9] TEXT(10), [CRS10] TEXT(10), [CRS11] TEXT(10), [CRS12] TEXT(10), [CRS13] TEXT(10))", Conn)
                    cmd1.Connection = Conn
                    Conn.Open()
                    cmd1.ExecuteNonQuery()
                    Dim SN As Integer
                    For i As Integer = 0 To Me.DataGridView1.RowCount - 1
                        Dim a As String = Me.DataGridView1.Item(0, i).Value
                        Dim b As String = Me.DataGridView1.Item(1, i).Value
                        Dim c As String = Me.DataGridView1.Item(2, i).Value
                        Dim d As String = Me.DataGridView1.Item(3, i).Value
                        Dim f As String = Me.DataGridView1.Item(4, i).Value
                        Dim sql As String
                        SN = SN + 1
                        sql = "insert into [TEMPTABLE](" & Label1.Text & "," & Label2.Text & "," & Label3.Text & "," & Label4.Text & "," & Label5.Text & ", CRS1, CRS2, CRS3, CRS4, CRS5, CRS6, CRS7, CRS8, CRS9, CRS10, CRS11, CRS12, CRS13) VALUES (TRIM('" & a & "'),TRIM('" & b & "'),TRIM('" & c & "'),TRIM('" & d & "'),TRIM('" & f & "'),'" & TextBox3.Text.Trim() & "','" & TextBox4.Text.Trim() & "','" & TextBox5.Text.Trim() & "','" & TextBox6.Text.Trim() & "','" & TextBox7.Text.Trim() & "','" & TextBox8.Text.Trim() & "','" & TextBox9.Text.Trim() & "','" & TextBox10.Text.Trim() & "','" & TextBox11.Text.Trim() & "','" & TextBox12.Text.Trim() & "','" & TextBox13.Text.Trim() & "','" & TextBox14.Text.Trim() & "','" & TextBox15.Text.Trim() & "')"
                        Dim comm As New OleDb.OleDbCommand
                        comm.CommandText = sql
                        comm.Connection = Conn
                        comm.ExecuteNonQuery()
                    Next i
                    Conn.Close()
                    AccessConnection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message & " -  " & ex.Source)
                End Try
            End If
          

            ' AccessConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " -  " & ex.Source)
        End Try
        DELETE()
        CLEAR()
        MsgBox("::: SUCCESS::: NOW USE SAVE RECORDS BUTS BUT PROVIDE PROGRAM NAME IN TOP FIELD IF EMPTY:::")
    End Sub
    Private Sub ccname()
        Dim COURSE As String
        COURSE = Convert.ToString(TextBox1.Text.Trim())
        Try
            AccessConnection.ConnectionString = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
            AccessConnection.Open()
            SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, "ALL_COURSES"})
            If SchemaTable.Rows.Count <> 0 Then
                Dim ABC = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim DEF As String = "INSERT INTO ALL_COURSES" & "(COURSE_NAME)" & "VALUES (@COURSE_NAME)"
                Using JAT = New System.Data.OleDb.OleDbConnection(ABC)
                    Using TOM = New System.Data.OleDb.OleDbCommand(DEF, JAT)
                        JAT.Open()
                        TOM.Parameters.AddWithValue("@COURSE_NAME", Course)
                        TOM.ExecuteNonQuery()
                    End Using
                End Using
            Else
                Try
                    Dim ConStr As String = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                    Dim Conn As New OleDb.OleDbConnection(ConStr)
                    Dim createTable As New OleDb.OleDbCommand
                    createTable.Connection = Conn
                    createTable.CommandType = CommandType.Text
                    Dim cmd As New OleDb.OleDbCommand("CREATE TABLE [ALL_COURSES] ([COURSE_NAME] TEXT(15))", Conn)
                    cmd.Connection = Conn
                    Conn.Open()
                    cmd.ExecuteNonQuery()
                    Conn.Close()
                Catch ex As Exception
                End Try

                Dim ABC = "ProvIder=Microsoft.ACE.OLEDB.12.0;Data Source=c:\Database\college.accdb;"
                Dim DEF As String = "INSERT INTO ALL_COURSES" & "(COURSE_NAME)" & "VALUES (@COURSE_NAME)"
                Using JAT = New System.Data.OleDb.OleDbConnection(ABC)
                    Using TOM = New System.Data.OleDb.OleDbCommand(DEF, JAT)
                        JAT.Open()
                        TOM.Parameters.AddWithValue("@COURSE_NAME", Course)
                        TOM.ExecuteNonQuery()
                    End Using
                End Using
            End If
            AccessConnection.Close()
        Catch ex As Exception
            MsgBox("Can't load Course Name " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub DELETE()
        Dim Str As String
        Try
            MyConn = New OleDbConnection
            MyConn.ConnectionString = connString
            ds = New DataSet
            tables = ds.Tables
            MyConn.Open()
            da = New OleDbDataAdapter("Select * from [TEMPTABLE]", MyConn)
            da.Fill(ds, "TEMPTABLE")
            '  For I As Integer = 0 To ds.Tables("TEMPTABLE").Rows.Count - 1 Step 1
            Str = "delete from TEMPTABLE where PROGRAM  <> '" & TextBox1.Text.Trim() & "'"
            Cmd = New OleDbCommand(Str, MyConn)
            Cmd.ExecuteNonQuery()
            ' Next I
            MyConn.Close()
        Catch ex As Exception
            MsgBox(vbCrLf & ex.Message)
        End Try
    End Sub
    Public Function RemoveDuplicateRows(dTable As DataTable, colName As String) As DataTable
        Dim hTable As New Hashtable()
        Dim duplicateList As New ArrayList()
        'Add list of all the unique item value to hashtable, which stores combination of key, value pair.
        'And add duplicate item value in arraylist.
        For Each drow__1 As DataRow In dTable.Rows
            If hTable.Contains(drow__1(colName)) Then
                duplicateList.Add(drow__1)
            Else
                hTable.Add(drow__1(colName), String.Empty)
            End If
        Next
        'Removing a list of duplicate items from datatable.
        For Each dRow__2 As DataRow In duplicateList
            dTable.Rows.Remove(dRow__2)
        Next
        'Datatable which contains unique records will be return as output.

        Return dTable

    End Function
    Private Sub CLEAR()
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
    End Sub
End Class