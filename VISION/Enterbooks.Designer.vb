<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enterbooks
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Code = New System.Windows.Forms.TextBox()
        Me.BookName = New System.Windows.Forms.TextBox()
        Me.Id = New System.Windows.Forms.TextBox()
        Me.ExitNow = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.Last = New System.Windows.Forms.Button()
        Me.Forward = New System.Windows.Forms.Button()
        Me.Previous = New System.Windows.Forms.Button()
        Me.First = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Library Books "
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(28, 281)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(28, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(504, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(384, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(64, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Book Name"
        '
        'Code
        '
        Me.Code.BackColor = System.Drawing.Color.Black
        Me.Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Code.ForeColor = System.Drawing.Color.White
        Me.Code.Location = New System.Drawing.Point(378, 51)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(78, 20)
        Me.Code.TabIndex = 3
        '
        'BookName
        '
        Me.BookName.BackColor = System.Drawing.Color.Black
        Me.BookName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BookName.ForeColor = System.Drawing.Color.White
        Me.BookName.Location = New System.Drawing.Point(67, 51)
        Me.BookName.Name = "BookName"
        Me.BookName.Size = New System.Drawing.Size(305, 20)
        Me.BookName.TabIndex = 2
        '
        'Id
        '
        Me.Id.BackColor = System.Drawing.Color.Black
        Me.Id.ForeColor = System.Drawing.Color.White
        Me.Id.Location = New System.Drawing.Point(7, 51)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(47, 20)
        Me.Id.TabIndex = 1
        '
        'ExitNow
        '
        Me.ExitNow.BackColor = System.Drawing.Color.Black
        Me.ExitNow.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitNow.ForeColor = System.Drawing.Color.Yellow
        Me.ExitNow.Location = New System.Drawing.Point(28, 378)
        Me.ExitNow.Name = "ExitNow"
        Me.ExitNow.Size = New System.Drawing.Size(75, 30)
        Me.ExitNow.TabIndex = 13
        Me.ExitNow.Text = "&Close"
        Me.ExitNow.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.Black
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.ForeColor = System.Drawing.Color.Yellow
        Me.Search.Location = New System.Drawing.Point(28, 169)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 30)
        Me.Search.TabIndex = 5
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = False
        '
        'Last
        '
        Me.Last.BackColor = System.Drawing.Color.Black
        Me.Last.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last.ForeColor = System.Drawing.Color.Yellow
        Me.Last.Location = New System.Drawing.Point(328, 81)
        Me.Last.Name = "Last"
        Me.Last.Size = New System.Drawing.Size(40, 30)
        Me.Last.TabIndex = 12
        Me.Last.Text = ">>>"
        Me.Last.UseVisualStyleBackColor = False
        '
        'Forward
        '
        Me.Forward.BackColor = System.Drawing.Color.Black
        Me.Forward.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forward.ForeColor = System.Drawing.Color.Yellow
        Me.Forward.Location = New System.Drawing.Point(242, 81)
        Me.Forward.Name = "Forward"
        Me.Forward.Size = New System.Drawing.Size(40, 30)
        Me.Forward.TabIndex = 11
        Me.Forward.Text = ">"
        Me.Forward.UseVisualStyleBackColor = False
        '
        'Previous
        '
        Me.Previous.BackColor = System.Drawing.Color.Black
        Me.Previous.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Previous.ForeColor = System.Drawing.Color.Yellow
        Me.Previous.Location = New System.Drawing.Point(142, 81)
        Me.Previous.Name = "Previous"
        Me.Previous.Size = New System.Drawing.Size(40, 30)
        Me.Previous.TabIndex = 10
        Me.Previous.Text = "<"
        Me.Previous.UseVisualStyleBackColor = False
        '
        'First
        '
        Me.First.BackColor = System.Drawing.Color.Black
        Me.First.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First.ForeColor = System.Drawing.Color.Yellow
        Me.First.Location = New System.Drawing.Point(71, 81)
        Me.First.Name = "First"
        Me.First.Size = New System.Drawing.Size(40, 30)
        Me.First.TabIndex = 9
        Me.First.Text = "<<<"
        Me.First.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(4, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "BookID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(627, 396)
        Me.DataGridView1.TabIndex = 41
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(-2, 1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(59, 30)
        Me.Button4.TabIndex = 42
        Me.Button4.TabStop = False
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(283, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Display of All Records"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Search)
        Me.Panel1.Controls.Add(Me.ExitNow)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(659, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(128, 569)
        Me.Panel1.TabIndex = 44
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Yellow
        Me.Button5.Location = New System.Drawing.Point(63, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(59, 30)
        Me.Button5.TabIndex = 43
        Me.Button5.TabStop = False
        Me.Button5.Text = "Show"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(152, 543)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(319, 17)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "For Update Record , First Search by BookID Then Update"
        '
        'Enterbooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(787, 569)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Code)
        Me.Controls.Add(Me.BookName)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.Last)
        Me.Controls.Add(Me.Forward)
        Me.Controls.Add(Me.Previous)
        Me.Controls.Add(Me.First)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Enterbooks"
        Me.Opacity = 0.75R
        Me.Text = "All About Library"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Code As System.Windows.Forms.TextBox
    Friend WithEvents BookName As System.Windows.Forms.TextBox
    Friend WithEvents Id As System.Windows.Forms.TextBox
    Friend WithEvents ExitNow As System.Windows.Forms.Button
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents Last As System.Windows.Forms.Button
    Friend WithEvents Forward As System.Windows.Forms.Button
    Friend WithEvents Previous As System.Windows.Forms.Button
    Friend WithEvents First As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
