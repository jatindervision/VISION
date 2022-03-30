<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billviewerpage1
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.collegeDataSet2 = New VISION.collegeDataSet2()
        Me.TOPBILLP1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TOPBILLP1TableAdapter = New VISION.collegeDataSet2TableAdapters.TOPBILLP1TableAdapter()
        Me.P1BOTTOMBILLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P1BOTTOMBILLTableAdapter = New VISION.collegeDataSet2TableAdapters.P1BOTTOMBILLTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.collegeDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOPBILLP1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1BOTTOMBILLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TOPBILLP1BindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.P1BOTTOMBILLBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VISION.billpageone.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(4, 36)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(724, 621)
        Me.ReportViewer1.TabIndex = 0
        '
        'collegeDataSet2
        '
        Me.collegeDataSet2.DataSetName = "collegeDataSet2"
        Me.collegeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TOPBILLP1BindingSource
        '
        Me.TOPBILLP1BindingSource.DataMember = "TOPBILLP1"
        Me.TOPBILLP1BindingSource.DataSource = Me.collegeDataSet2
        '
        'TOPBILLP1TableAdapter
        '
        Me.TOPBILLP1TableAdapter.ClearBeforeFill = True
        '
        'P1BOTTOMBILLBindingSource
        '
        Me.P1BOTTOMBILLBindingSource.DataMember = "P1BOTTOMBILL"
        Me.P1BOTTOMBILLBindingSource.DataSource = Me.collegeDataSet2
        '
        'P1BOTTOMBILLTableAdapter
        '
        Me.P1BOTTOMBILLTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(610, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 26)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "SHOW-REPORT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(303, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 26)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'billviewerpage1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 669)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "billviewerpage1"
        CType(Me.collegeDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOPBILLP1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1BOTTOMBILLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TOPBILLP1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents collegeDataSet2 As VISION.collegeDataSet2
    Friend WithEvents P1BOTTOMBILLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TOPBILLP1TableAdapter As VISION.collegeDataSet2TableAdapters.TOPBILLP1TableAdapter
    Friend WithEvents P1BOTTOMBILLTableAdapter As VISION.collegeDataSet2TableAdapters.P1BOTTOMBILLTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
