<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MF = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ANO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DOA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Parentage = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ph = New System.Windows.Forms.TextBox()
        Me.StName = New System.Windows.Forms.TextBox()
        Me.Id = New System.Windows.Forms.TextBox()
        Me.CollegeName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CName = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TotalA = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ExitNow = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(363, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Date of Admission"
        '
        'MF
        '
        Me.MF.BackColor = System.Drawing.Color.Black
        Me.MF.ForeColor = System.Drawing.Color.Yellow
        Me.MF.FormattingEnabled = True
        Me.MF.Items.AddRange(New Object() {"Male", "Female"})
        Me.MF.Location = New System.Drawing.Point(723, 56)
        Me.MF.Name = "MF"
        Me.MF.Size = New System.Drawing.Size(60, 21)
        Me.MF.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Teal
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(725, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 16)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "Gender"
        '
        'ANO
        '
        Me.ANO.BackColor = System.Drawing.Color.Black
        Me.ANO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ANO.ForeColor = System.Drawing.Color.White
        Me.ANO.Location = New System.Drawing.Point(70, 58)
        Me.ANO.Name = "ANO"
        Me.ANO.Size = New System.Drawing.Size(96, 20)
        Me.ANO.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Teal
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(68, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 16)
        Me.Label9.TabIndex = 146
        Me.Label9.Text = "Admission - No."
        '
        'DOB
        '
        Me.DOB.BackColor = System.Drawing.Color.Black
        Me.DOB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DOB.ForeColor = System.Drawing.Color.White
        Me.DOB.Location = New System.Drawing.Point(540, 58)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(75, 20)
        Me.DOB.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Teal
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(540, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 145
        Me.Label8.Text = "DOB"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, 497)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(23, 20)
        Me.TextBox1.TabIndex = 99
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(708, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DOA
        '
        Me.DOA.BackColor = System.Drawing.Color.Black
        Me.DOA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DOA.ForeColor = System.Drawing.Color.White
        Me.DOA.Location = New System.Drawing.Point(363, 102)
        Me.DOA.Name = "DOA"
        Me.DOA.Size = New System.Drawing.Size(75, 20)
        Me.DOA.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(343, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Student Detail"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(187, 497)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(394, 17)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "For Update Record , First Search by Student ID Then Update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Maroon
        Me.DataGridView1.Location = New System.Drawing.Point(13, 214)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(770, 280)
        Me.DataGridView1.TabIndex = 151
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(362, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Parenatage"
        '
        'Parentage
        '
        Me.Parentage.BackColor = System.Drawing.Color.Black
        Me.Parentage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Parentage.ForeColor = System.Drawing.Color.White
        Me.Parentage.Location = New System.Drawing.Point(363, 58)
        Me.Parentage.Name = "Parentage"
        Me.Parentage.Size = New System.Drawing.Size(171, 20)
        Me.Parentage.TabIndex = 4
        '
        'Address
        '
        Me.Address.BackColor = System.Drawing.Color.Black
        Me.Address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Address.ForeColor = System.Drawing.Color.White
        Me.Address.Location = New System.Drawing.Point(23, 102)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(334, 20)
        Me.Address.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(18, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "SNO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(625, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Ph. No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(184, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Student Name"
        '
        'Ph
        '
        Me.Ph.BackColor = System.Drawing.Color.Black
        Me.Ph.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ph.ForeColor = System.Drawing.Color.White
        Me.Ph.Location = New System.Drawing.Point(621, 58)
        Me.Ph.Name = "Ph"
        Me.Ph.Size = New System.Drawing.Size(96, 20)
        Me.Ph.TabIndex = 7
        '
        'StName
        '
        Me.StName.BackColor = System.Drawing.Color.Black
        Me.StName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StName.ForeColor = System.Drawing.Color.White
        Me.StName.Location = New System.Drawing.Point(184, 58)
        Me.StName.Name = "StName"
        Me.StName.Size = New System.Drawing.Size(173, 20)
        Me.StName.TabIndex = 3
        '
        'Id
        '
        Me.Id.BackColor = System.Drawing.Color.Black
        Me.Id.ForeColor = System.Drawing.Color.White
        Me.Id.Location = New System.Drawing.Point(19, 58)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(33, 20)
        Me.Id.TabIndex = 1
        '
        'CollegeName
        '
        Me.CollegeName.AutoSize = True
        Me.CollegeName.BackColor = System.Drawing.Color.Black
        Me.CollegeName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollegeName.ForeColor = System.Drawing.Color.Yellow
        Me.CollegeName.Location = New System.Drawing.Point(9, 9)
        Me.CollegeName.Name = "CollegeName"
        Me.CollegeName.Size = New System.Drawing.Size(201, 18)
        Me.CollegeName.TabIndex = 140
        Me.CollegeName.Text = "Student Admission Registor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Teal
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(22, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "Address"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.VISION.My.Resources.Resources.arrow1
        Me.Panel2.Location = New System.Drawing.Point(603, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(40, 26)
        Me.Panel2.TabIndex = 148
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Teal
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(484, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 16)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "Course_Name"
        '
        'CName
        '
        Me.CName.BackColor = System.Drawing.Color.Black
        Me.CName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CName.ForeColor = System.Drawing.Color.White
        Me.CName.Location = New System.Drawing.Point(481, 102)
        Me.CName.Name = "CName"
        Me.CName.Size = New System.Drawing.Size(116, 20)
        Me.CName.TabIndex = 10
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Yellow
        Me.Button7.Location = New System.Drawing.Point(475, 172)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(300, 30)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Click On Me for Attendance Registor"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(18, 178)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(227, 24)
        Me.Label13.TabIndex = 159
        Me.Label13.Text = "Total No.of Admission="
        '
        'TotalA
        '
        Me.TotalA.BackColor = System.Drawing.Color.Black
        Me.TotalA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalA.ForeColor = System.Drawing.Color.Yellow
        Me.TotalA.Location = New System.Drawing.Point(252, 178)
        Me.TotalA.Name = "TotalA"
        Me.TotalA.Size = New System.Drawing.Size(68, 24)
        Me.TotalA.TabIndex = 160
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(446, 517)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 25)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(339, 517)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 25)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.Black
        Me.Search.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.ForeColor = System.Drawing.Color.Yellow
        Me.Search.Location = New System.Drawing.Point(239, 517)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 25)
        Me.Search.TabIndex = 14
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Yellow
        Me.Button5.Location = New System.Drawing.Point(142, 517)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 25)
        Me.Button5.TabIndex = 13
        Me.Button5.TabStop = False
        Me.Button5.Text = "Show"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ExitNow
        '
        Me.ExitNow.BackColor = System.Drawing.Color.Black
        Me.ExitNow.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitNow.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitNow.ForeColor = System.Drawing.Color.Yellow
        Me.ExitNow.Location = New System.Drawing.Point(679, 517)
        Me.ExitNow.Name = "ExitNow"
        Me.ExitNow.Size = New System.Drawing.Size(75, 25)
        Me.ExitNow.TabIndex = 18
        Me.ExitNow.Text = "&Close"
        Me.ExitNow.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Yellow
        Me.Button6.Location = New System.Drawing.Point(553, 517)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 25)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "BackUp"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(51, 517)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 25)
        Me.Button4.TabIndex = 12
        Me.Button4.TabStop = False
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Maroon
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        '
        'StudentEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(797, 544)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ExitNow)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TotalA)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MF)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ANO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DOA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Parentage)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Ph)
        Me.Controls.Add(Me.StName)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.CollegeName)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StudentEntry"
        Me.Opacity = 0.8R
        Me.Text = "StudentEntry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MF As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ANO As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DOB As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DOA As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Parentage As System.Windows.Forms.TextBox
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Ph As System.Windows.Forms.TextBox
    Friend WithEvents StName As System.Windows.Forms.TextBox
    Friend WithEvents Id As System.Windows.Forms.TextBox
    Friend WithEvents CollegeName As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CName As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TotalA As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ExitNow As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
