<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EXPALL
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
        Me.collegeDataSet3 = New VISION.collegeDataSet3()
        Me.exprepoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.exprepoTableAdapter = New VISION.collegeDataSet3TableAdapters.exprepoTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.collegeDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exprepoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(557, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 31)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "SHOW REPORT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'collegeDataSet3
        '
        Me.collegeDataSet3.DataSetName = "collegeDataSet3"
        Me.collegeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'exprepoBindingSource
        '
        Me.exprepoBindingSource.DataMember = "exprepo"
        Me.exprepoBindingSource.DataSource = Me.collegeDataSet3
        '
        'exprepoTableAdapter
        '
        Me.exprepoTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.exprepoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VISION.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 60)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(676, 536)
        Me.ReportViewer1.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 31)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "CLOSE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EXPALL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 630)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EXPALL"
        CType(Me.collegeDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exprepoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents exprepoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents collegeDataSet3 As VISION.collegeDataSet3
    Friend WithEvents exprepoTableAdapter As VISION.collegeDataSet3TableAdapters.exprepoTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
