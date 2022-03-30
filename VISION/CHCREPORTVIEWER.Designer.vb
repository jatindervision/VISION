<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CHCREPORTVIEWER
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
        Me.ONETWOPLUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.collegeDataSet = New VISION.collegeDataSet()
        Me.CHCTOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ONETWOPLUSTableAdapter = New VISION.collegeDataSetTableAdapters.ONETWOPLUSTableAdapter()
        Me.CHCTOPTableAdapter = New VISION.collegeDataSetTableAdapters.CHCTOPTableAdapter()
        CType(Me.ONETWOPLUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.collegeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHCTOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ONETWOPLUSBindingSource
        '
        Me.ONETWOPLUSBindingSource.DataMember = "ONETWOPLUS"
        Me.ONETWOPLUSBindingSource.DataSource = Me.collegeDataSet
        '
        'collegeDataSet
        '
        Me.collegeDataSet.DataSetName = "collegeDataSet"
        Me.collegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CHCTOPBindingSource
        '
        Me.CHCTOPBindingSource.DataMember = "CHCTOP"
        Me.CHCTOPBindingSource.DataSource = Me.collegeDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(370, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(716, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 26)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "SHOW-REPORT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ONETWOPLUSBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.CHCTOPBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VISION.CHCREPORTFINAL.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 44)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(814, 626)
        Me.ReportViewer1.TabIndex = 3
        '
        'ONETWOPLUSTableAdapter
        '
        Me.ONETWOPLUSTableAdapter.ClearBeforeFill = True
        '
        'CHCTOPTableAdapter
        '
        Me.CHCTOPTableAdapter.ClearBeforeFill = True
        '
        'CHCREPORTVIEWER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(841, 682)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CHCREPORTVIEWER"
        Me.Opacity = 0.75R
        Me.Text = "CHC"
        CType(Me.ONETWOPLUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.collegeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHCTOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ONETWOPLUSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents collegeDataSet As VISION.collegeDataSet
    Friend WithEvents CHCTOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ONETWOPLUSTableAdapter As VISION.collegeDataSetTableAdapters.ONETWOPLUSTableAdapter
    Friend WithEvents CHCTOPTableAdapter As VISION.collegeDataSetTableAdapters.CHCTOPTableAdapter
End Class
