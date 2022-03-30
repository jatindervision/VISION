<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class assbillviewer
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.collegeDataSet2 = New VISION.collegeDataSet2()
        Me.ASSBILLTOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASSBILLTOPTableAdapter = New VISION.collegeDataSet2TableAdapters.ASSBILLTOPTableAdapter()
        CType(Me.collegeDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASSBILLTOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(583, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 26)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "SHOW-REPORT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(337, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 26)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ASSBILLTOPBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VISION.ASSIGN_BILL.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 39)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(681, 618)
        Me.ReportViewer1.TabIndex = 9
        '
        'collegeDataSet2
        '
        Me.collegeDataSet2.DataSetName = "collegeDataSet2"
        Me.collegeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ASSBILLTOPBindingSource
        '
        Me.ASSBILLTOPBindingSource.DataMember = "ASSBILLTOP"
        Me.ASSBILLTOPBindingSource.DataSource = Me.collegeDataSet2
        '
        'ASSBILLTOPTableAdapter
        '
        Me.ASSBILLTOPTableAdapter.ClearBeforeFill = True
        '
        'assbillviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 669)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "assbillviewer"
        Me.Opacity = 0.8R
        CType(Me.collegeDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASSBILLTOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ASSBILLTOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents collegeDataSet2 As VISION.collegeDataSet2
    Friend WithEvents ASSBILLTOPTableAdapter As VISION.collegeDataSet2TableAdapters.ASSBILLTOPTableAdapter
End Class
