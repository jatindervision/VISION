<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_SCHEDULE_VIEWER
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.collegeDataSet1 = New VISION.collegeDataSet1()
        Me.BCoSCHEDULEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BCoSCHEDULETableAdapter = New VISION.collegeDataSet1TableAdapters.BCoSCHEDULETableAdapter()
        Me.TCoSCHEDULEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TCoSCHEDULETableAdapter = New VISION.collegeDataSet1TableAdapters.TCoSCHEDULETableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.collegeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCoSCHEDULEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TCoSCHEDULEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.BCoSCHEDULEBindingSource
        ReportDataSource4.Name = "DataSet2"
        ReportDataSource4.Value = Me.TCoSCHEDULEBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VISION.COSCHEDULE.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 38)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1041, 566)
        Me.ReportViewer1.TabIndex = 0
        '
        'collegeDataSet1
        '
        Me.collegeDataSet1.DataSetName = "collegeDataSet1"
        Me.collegeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BCoSCHEDULEBindingSource
        '
        Me.BCoSCHEDULEBindingSource.DataMember = "BCoSCHEDULE"
        Me.BCoSCHEDULEBindingSource.DataSource = Me.collegeDataSet1
        '
        'BCoSCHEDULETableAdapter
        '
        Me.BCoSCHEDULETableAdapter.ClearBeforeFill = True
        '
        'TCoSCHEDULEBindingSource
        '
        Me.TCoSCHEDULEBindingSource.DataMember = "TCoSCHEDULE"
        Me.TCoSCHEDULEBindingSource.DataSource = Me.collegeDataSet1
        '
        'TCoSCHEDULETableAdapter
        '
        Me.TCoSCHEDULETableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(943, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 26)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "SHOW-REPORT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(495, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 26)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CO_SCHEDULE_VIEWER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 648)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CO_SCHEDULE_VIEWER"
        CType(Me.collegeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCoSCHEDULEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TCoSCHEDULEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BCoSCHEDULEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents collegeDataSet1 As VISION.collegeDataSet1
    Friend WithEvents TCoSCHEDULEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BCoSCHEDULETableAdapter As VISION.collegeDataSet1TableAdapters.BCoSCHEDULETableAdapter
    Friend WithEvents TCoSCHEDULETableAdapter As VISION.collegeDataSet1TableAdapters.TCoSCHEDULETableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
