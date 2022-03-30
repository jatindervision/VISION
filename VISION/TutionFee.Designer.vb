<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutionFee
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Amount = New System.Windows.Forms.TextBox()
        Me.StudentName = New System.Windows.Forms.TextBox()
        Me.Id = New System.Windows.Forms.TextBox()
        Me.ExitNow = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.Last = New System.Windows.Forms.Button()
        Me.Forward = New System.Windows.Forms.Button()
        Me.Previous = New System.Windows.Forms.Button()
        Me.First = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(328, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(559, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Fee/Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(290, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Student Name"
        '
        'Amount
        '
        Me.Amount.BackColor = System.Drawing.Color.Maroon
        Me.Amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Amount.ForeColor = System.Drawing.Color.White
        Me.Amount.Location = New System.Drawing.Point(139, 73)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(136, 20)
        Me.Amount.TabIndex = 3
        '
        'StudentName
        '
        Me.StudentName.BackColor = System.Drawing.Color.Maroon
        Me.StudentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentName.ForeColor = System.Drawing.Color.White
        Me.StudentName.Location = New System.Drawing.Point(423, 44)
        Me.StudentName.Name = "StudentName"
        Me.StudentName.Size = New System.Drawing.Size(211, 20)
        Me.StudentName.TabIndex = 2
        '
        'Id
        '
        Me.Id.BackColor = System.Drawing.Color.Maroon
        Me.Id.ForeColor = System.Drawing.Color.White
        Me.Id.Location = New System.Drawing.Point(141, 42)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(136, 20)
        Me.Id.TabIndex = 1
        '
        'ExitNow
        '
        Me.ExitNow.BackColor = System.Drawing.Color.Black
        Me.ExitNow.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitNow.ForeColor = System.Drawing.Color.Yellow
        Me.ExitNow.Location = New System.Drawing.Point(436, 178)
        Me.ExitNow.Name = "ExitNow"
        Me.ExitNow.Size = New System.Drawing.Size(75, 30)
        Me.ExitNow.TabIndex = 15
        Me.ExitNow.Text = "&Close"
        Me.ExitNow.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.Black
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.ForeColor = System.Drawing.Color.Yellow
        Me.Search.Location = New System.Drawing.Point(225, 178)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 30)
        Me.Search.TabIndex = 12
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = False
        '
        'Last
        '
        Me.Last.BackColor = System.Drawing.Color.Black
        Me.Last.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last.Location = New System.Drawing.Point(423, 102)
        Me.Last.Name = "Last"
        Me.Last.Size = New System.Drawing.Size(37, 23)
        Me.Last.TabIndex = 9
        Me.Last.Text = ">>>"
        Me.Last.UseVisualStyleBackColor = False
        '
        'Forward
        '
        Me.Forward.BackColor = System.Drawing.Color.Black
        Me.Forward.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forward.Location = New System.Drawing.Point(337, 102)
        Me.Forward.Name = "Forward"
        Me.Forward.Size = New System.Drawing.Size(37, 23)
        Me.Forward.TabIndex = 8
        Me.Forward.Text = ">"
        Me.Forward.UseVisualStyleBackColor = False
        '
        'Previous
        '
        Me.Previous.BackColor = System.Drawing.Color.Black
        Me.Previous.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Previous.Location = New System.Drawing.Point(237, 102)
        Me.Previous.Name = "Previous"
        Me.Previous.Size = New System.Drawing.Size(37, 23)
        Me.Previous.TabIndex = 7
        Me.Previous.Text = "<"
        Me.Previous.UseVisualStyleBackColor = False
        '
        'First
        '
        Me.First.BackColor = System.Drawing.Color.Black
        Me.First.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First.Location = New System.Drawing.Point(166, 102)
        Me.First.Name = "First"
        Me.First.Size = New System.Drawing.Size(37, 23)
        Me.First.TabIndex = 6
        Me.First.Text = "<<<"
        Me.First.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(8, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Enrollment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 19)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "College Students Tution Fee"
        '
        'DateT
        '
        Me.DateT.BackColor = System.Drawing.Color.Maroon
        Me.DateT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DateT.ForeColor = System.Drawing.Color.White
        Me.DateT.Location = New System.Drawing.Point(421, 76)
        Me.DateT.Name = "DateT"
        Me.DateT.Size = New System.Drawing.Size(89, 20)
        Me.DateT.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(288, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Date And Time"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(258, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Calculate Fee"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(135, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(363, 18)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "For Update Record , First Search by Enrollment Then Update"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Yellow
        Me.Button5.Location = New System.Drawing.Point(120, 178)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 30)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(279, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "DISPLAY"
        '
        'DataGridView1
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Location = New System.Drawing.Point(11, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(617, 382)
        Me.DataGridView1.TabIndex = 65
        '
        'TutionFee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(643, 629)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ExitNow)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateT)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Amount)
        Me.Controls.Add(Me.StudentName)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.Last)
        Me.Controls.Add(Me.Forward)
        Me.Controls.Add(Me.Previous)
        Me.Controls.Add(Me.First)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TutionFee"
        Me.Opacity = 0.75R
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Amount As System.Windows.Forms.TextBox
    Friend WithEvents StudentName As System.Windows.Forms.TextBox
    Friend WithEvents Id As System.Windows.Forms.TextBox
    Friend WithEvents ExitNow As System.Windows.Forms.Button
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents Last As System.Windows.Forms.Button
    Friend WithEvents Forward As System.Windows.Forms.Button
    Friend WithEvents Previous As System.Windows.Forms.Button
    Friend WithEvents First As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
