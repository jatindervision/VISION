<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Database
    Inherits System.Windows.Forms.Form

    'Form overrIdes dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected OverrIdes Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Database))
        Me.AUTOPROCESS1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fordatabase = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AUTOPROCESS1
        '
        Me.AUTOPROCESS1.AutoSize = True
        Me.AUTOPROCESS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AUTOPROCESS1.Location = New System.Drawing.Point(517, 119)
        Me.AUTOPROCESS1.Name = "AUTOPROCESS1"
        Me.AUTOPROCESS1.Size = New System.Drawing.Size(214, 24)
        Me.AUTOPROCESS1.TabIndex = 0
        Me.AUTOPROCESS1.Text = "Automatically Process"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(542, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "First Click On Me"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(542, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Second Click On Me"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fordatabase
        '
        Me.fordatabase.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.fordatabase.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.fordatabase.IsBalloon = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Image = Global.VISION.My.Resources.Resources.main_Pict
        Me.Label2.Location = New System.Drawing.Point(23, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 366)
        Me.Label2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Timer1
        '
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(189, 407)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 24)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(799, 443)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AUTOPROCESS1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Database"
        Me.Opacity = 0.75R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Database Creation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AUTOPROCESS1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fordatabase As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
