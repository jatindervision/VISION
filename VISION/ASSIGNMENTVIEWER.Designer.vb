<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ASSIGNMENTVIEWER
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
        Me.ASSIGNMENTBOTTOMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASSIGNMENTTOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.collegeDataSet = New VISION.collegeDataSet()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ASSIGNMENTBOTTOMTableAdapter = New VISION.collegeDataSetTableAdapters.ASSIGNMENTBOTTOMTableAdapter()
        Me.ASSIGNMENTTOPTableAdapter = New VISION.collegeDataSetTableAdapters.ASSIGNMENTTOPTableAdapter()
        CType(Me.ASSIGNMENTBOTTOMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASSIGNMENTTOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.collegeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ASSIGNMENTBOTTOMBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.ASSIGNMENTTOPBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VISION.AssignmentReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 44)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(725, 626)
        Me.ReportViewer1.TabIndex = 7
        '
        'collegeDataSet
        '
        Me.collegeDataSet.DataSetName = "collegeDataSet"
        Me.collegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(621, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 26)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "SHOW-REPORT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(328, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 26)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ASSIGNMENTBOTTOMTableAdapter
        '
        Me.ASSIGNMENTBOTTOMTableAdapter.ClearBeforeFill = True
        '
        'ASSIGNMENTTOPTableAdapter
        '
        Me.ASSIGNMENTTOPTableAdapter.ClearBeforeFill = True
        '
        'ASSIGNMENTVIEWER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(749, 682)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ASSIGNMENTVIEWER"
        Me.Opacity = 0.75R
        Me.Text = "ASSIGNMENTS"
        CType(Me.ASSIGNMENTBOTTOMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASSIGNMENTTOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.collegeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents collegeDataSet As VISION.collegeDataSet
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ASSIGNMENTBOTTOMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASSIGNMENTTOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASSIGNMENTBOTTOMTableAdapter As VISION.collegeDataSetTableAdapters.ASSIGNMENTBOTTOMTableAdapter
    Friend WithEvents ASSIGNMENTTOPTableAdapter As VISION.collegeDataSetTableAdapters.ASSIGNMENTTOPTableAdapter
End Class
