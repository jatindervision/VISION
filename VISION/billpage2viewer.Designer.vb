<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billpage2viewer
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.P2BOTTOMBILLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.collegeDataSet2 = New VISION.collegeDataSet2()
        Me.TOPBILLP2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.P2BOTTOMBILLTableAdapter = New VISION.collegeDataSet2TableAdapters.P2BOTTOMBILLTableAdapter()
        Me.TOPBILLP2TableAdapter = New VISION.collegeDataSet2TableAdapters.TOPBILLP2TableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.P2BOTTOMBILLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.collegeDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOPBILLP2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P2BOTTOMBILLBindingSource
        '
        Me.P2BOTTOMBILLBindingSource.DataMember = "P2BOTTOMBILL"
        Me.P2BOTTOMBILLBindingSource.DataSource = Me.collegeDataSet2
        '
        'collegeDataSet2
        '
        Me.collegeDataSet2.DataSetName = "collegeDataSet2"
        Me.collegeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TOPBILLP2BindingSource
        '
        Me.TOPBILLP2BindingSource.DataMember = "TOPBILLP2"
        Me.TOPBILLP2BindingSource.DataSource = Me.collegeDataSet2
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.P2BOTTOMBILLBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.TOPBILLP2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VISION.BILLPAGE2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(5, 47)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(697, 612)
        Me.ReportViewer1.TabIndex = 0
        '
        'P2BOTTOMBILLTableAdapter
        '
        Me.P2BOTTOMBILLTableAdapter.ClearBeforeFill = True
        '
        'TOPBILLP2TableAdapter
        '
        Me.TOPBILLP2TableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(584, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 26)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "SHOW-REPORT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(341, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 26)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'billpage2viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 671)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "billpage2viewer"
        Me.Text = "billpage2viewer"
        CType(Me.P2BOTTOMBILLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.collegeDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOPBILLP2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents P2BOTTOMBILLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents collegeDataSet2 As VISION.collegeDataSet2
    Friend WithEvents TOPBILLP2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P2BOTTOMBILLTableAdapter As VISION.collegeDataSet2TableAdapters.P2BOTTOMBILLTableAdapter
    Friend WithEvents TOPBILLP2TableAdapter As VISION.collegeDataSet2TableAdapters.TOPBILLP2TableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
