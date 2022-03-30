<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmissionBackup
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TransferButton = New System.Windows.Forms.Button()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.DataGrid2 = New System.Windows.Forms.DataGrid()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(37, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(37, 479)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 28)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "&Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TransferButton
        '
        Me.TransferButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransferButton.ForeColor = System.Drawing.Color.Yellow
        Me.TransferButton.Location = New System.Drawing.Point(193, 238)
        Me.TransferButton.Name = "TransferButton"
        Me.TransferButton.Size = New System.Drawing.Size(130, 33)
        Me.TransferButton.TabIndex = 13
        Me.TransferButton.Text = "Transfer Data"
        '
        'LoadButton
        '
        Me.LoadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadButton.ForeColor = System.Drawing.Color.Yellow
        Me.LoadButton.Location = New System.Drawing.Point(37, 0)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(117, 34)
        Me.LoadButton.TabIndex = 12
        Me.LoadButton.Text = "Load Data"
        '
        'DataGrid2
        '
        Me.DataGrid2.AlternatingBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DataGrid2.BackColor = System.Drawing.Color.White
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid2.CaptionBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DataGrid2.CaptionFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid2.CaptionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.FlatMode = True
        Me.DataGrid2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGrid2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGrid2.GridLineColor = System.Drawing.Color.Peru
        Me.DataGrid2.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid2.HeaderBackColor = System.Drawing.Color.Maroon
        Me.DataGrid2.HeaderFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid2.HeaderForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DataGrid2.LinkColor = System.Drawing.Color.Maroon
        Me.DataGrid2.Location = New System.Drawing.Point(37, 277)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ParentRowsBackColor = System.Drawing.Color.BurlyWood
        Me.DataGrid2.ParentRowsForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGrid2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGrid2.SelectionForeColor = System.Drawing.Color.GhostWhite
        Me.DataGrid2.Size = New System.Drawing.Size(755, 192)
        Me.DataGrid2.TabIndex = 11
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.Black
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.DataGrid1.ForeColor = System.Drawing.Color.Black
        Me.DataGrid1.GridLineColor = System.Drawing.Color.Silver
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.Black
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGrid1.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGrid1.Location = New System.Drawing.Point(37, 40)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGrid1.Size = New System.Drawing.Size(755, 192)
        Me.DataGrid1.TabIndex = 10
        '
        'AdmissionBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(846, 533)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TransferButton)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdmissionBackup"
        Me.Opacity = 0.8R
        Me.Text = "AdmisionBackup"
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TransferButton As System.Windows.Forms.Button
    Friend WithEvents LoadButton As System.Windows.Forms.Button
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
End Class
