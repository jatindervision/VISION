<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportview
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
        Me.BOTTOMADMISSIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.collegeDataSet = New VISION.collegeDataSet()
        Me.TOPADMISSIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BOTTOMADMISSIONTableAdapter = New VISION.collegeDataSetTableAdapters.BOTTOMADMISSIONTableAdapter()
        Me.TOPADMISSIONTableAdapter = New VISION.collegeDataSetTableAdapters.TOPADMISSIONTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.BOTTOMADMISSIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.collegeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOPADMISSIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BOTTOMADMISSIONBindingSource
        '
        Me.BOTTOMADMISSIONBindingSource.DataMember = "BOTTOMADMISSION"
        Me.BOTTOMADMISSIONBindingSource.DataSource = Me.collegeDataSet
        '
        'collegeDataSet
        '
        Me.collegeDataSet.DataSetName = "collegeDataSet"
        Me.collegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TOPADMISSIONBindingSource
        '
        Me.TOPADMISSIONBindingSource.DataMember = "TOPADMISSION"
        Me.TOPADMISSIONBindingSource.DataSource = Me.collegeDataSet
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.BOTTOMADMISSIONBindingSource
        ReportDataSource4.Name = "DataSet2"
        ReportDataSource4.Value = Me.TOPADMISSIONBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VISION.ATTEN-PRINTING.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 43)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(658, 626)
        Me.ReportViewer1.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(546, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 26)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "SHOW-REPORT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(111, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 26)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BOTTOMADMISSIONTableAdapter
        '
        Me.BOTTOMADMISSIONTableAdapter.ClearBeforeFill = True
        '
        'TOPADMISSIONTableAdapter
        '
        Me.TOPADMISSIONTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(316, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 26)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "GOTO ATTENDANCE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'reportview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(673, 683)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "reportview"
        Me.Opacity = 0.75R
        Me.Text = "ATTENDANCE"
        CType(Me.BOTTOMADMISSIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.collegeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOPADMISSIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents collegeDataSet As VISION.collegeDataSet
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BOTTOMADMISSIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TOPADMISSIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOTTOMADMISSIONTableAdapter As VISION.collegeDataSetTableAdapters.BOTTOMADMISSIONTableAdapter
    Friend WithEvents TOPADMISSIONTableAdapter As VISION.collegeDataSetTableAdapters.TOPADMISSIONTableAdapter
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
