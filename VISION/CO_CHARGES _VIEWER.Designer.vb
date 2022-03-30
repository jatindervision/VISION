<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_CHARGES__VIEWER
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
        Me.BCoCHARGESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.collegeDataSet1 = New VISION.collegeDataSet1()
        Me.TCoCHARGESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BCoCHARGESTableAdapter = New VISION.collegeDataSet1TableAdapters.BCoCHARGESTableAdapter()
        Me.TCoCHARGESTableAdapter = New VISION.collegeDataSet1TableAdapters.TCoCHARGESTableAdapter()
        CType(Me.BCoCHARGESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.collegeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TCoCHARGESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BCoCHARGESBindingSource
        '
        Me.BCoCHARGESBindingSource.DataMember = "BCoCHARGES"
        Me.BCoCHARGESBindingSource.DataSource = Me.collegeDataSet1
        '
        'collegeDataSet1
        '
        Me.collegeDataSet1.DataSetName = "collegeDataSet1"
        Me.collegeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TCoCHARGESBindingSource
        '
        Me.TCoCHARGESBindingSource.DataMember = "TCoCHARGES"
        Me.TCoCHARGESBindingSource.DataSource = Me.collegeDataSet1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(946, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 26)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "SHOW-REPORT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(496, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 26)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BCoCHARGESBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.TCoCHARGESBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VISION.COCHARGES.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 37)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1067, 657)
        Me.ReportViewer1.TabIndex = 19
        '
        'BCoCHARGESTableAdapter
        '
        Me.BCoCHARGESTableAdapter.ClearBeforeFill = True
        '
        'TCoCHARGESTableAdapter
        '
        Me.TCoCHARGESTableAdapter.ClearBeforeFill = True
        '
        'CO_CHARGES__VIEWER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1084, 706)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CO_CHARGES__VIEWER"
        CType(Me.BCoCHARGESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.collegeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TCoCHARGESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BCoCHARGESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents collegeDataSet1 As VISION.collegeDataSet1
    Friend WithEvents TCoCHARGESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BCoCHARGESTableAdapter As VISION.collegeDataSet1TableAdapters.BCoCHARGESTableAdapter
    Friend WithEvents TCoCHARGESTableAdapter As VISION.collegeDataSet1TableAdapters.TCoCHARGESTableAdapter
End Class
