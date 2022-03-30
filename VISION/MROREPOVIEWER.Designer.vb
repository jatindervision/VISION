<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MROREPOVIEWER
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
        Me.MROBOTTOMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.collegeDataSet2 = New VISION.collegeDataSet()
        Me.MROTOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CHCTOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.collegeDataSet = New VISION.collegeDataSet()
        Me.ONETWOPLUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CHCTOPTableAdapter = New VISION.collegeDataSetTableAdapters.CHCTOPTableAdapter()
        Me.ONETWOPLUSTableAdapter = New VISION.collegeDataSetTableAdapters.ONETWOPLUSTableAdapter()
        Me.MROBOTTOMTableAdapter = New VISION.collegeDataSetTableAdapters.MROBOTTOMTableAdapter()
        Me.MROTOPTableAdapter = New VISION.collegeDataSetTableAdapters.MROTOPTableAdapter()
        CType(Me.MROBOTTOMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.collegeDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MROTOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHCTOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.collegeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ONETWOPLUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MROBOTTOMBindingSource
        '
        Me.MROBOTTOMBindingSource.DataMember = "MROBOTTOM"
        Me.MROBOTTOMBindingSource.DataSource = Me.collegeDataSet2
        '
        'collegeDataSet2
        '
        Me.collegeDataSet2.DataSetName = "collegeDataSet2"
        Me.collegeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MROTOPBindingSource
        '
        Me.MROTOPBindingSource.DataMember = "MROTOP"
        Me.MROTOPBindingSource.DataSource = Me.collegeDataSet2
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MROBOTTOMBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.MROTOPBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VISION.MROREPO.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 42)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(636, 626)
        Me.ReportViewer1.TabIndex = 7
        '
        'CHCTOPBindingSource
        '
        Me.CHCTOPBindingSource.DataMember = "CHCTOP"
        Me.CHCTOPBindingSource.DataSource = Me.collegeDataSet
        '
        'collegeDataSet
        '
        Me.collegeDataSet.DataSetName = "collegeDataSet"
        Me.collegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ONETWOPLUSBindingSource
        '
        Me.ONETWOPLUSBindingSource.DataMember = "ONETWOPLUS"
        Me.ONETWOPLUSBindingSource.DataSource = Me.collegeDataSet
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(534, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 26)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "SHOW-REPORT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(346, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 26)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CHCTOPTableAdapter
        '
        Me.CHCTOPTableAdapter.ClearBeforeFill = True
        '
        'ONETWOPLUSTableAdapter
        '
        Me.ONETWOPLUSTableAdapter.ClearBeforeFill = True
        '
        'MROBOTTOMTableAdapter
        '
        Me.MROBOTTOMTableAdapter.ClearBeforeFill = True
        '
        'MROTOPTableAdapter
        '
        Me.MROTOPTableAdapter.ClearBeforeFill = True
        '
        'MROREPOVIEWER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(657, 685)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MROREPOVIEWER"
        Me.Opacity = 0.75R
        Me.Text = "MRO"
        CType(Me.MROBOTTOMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.collegeDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MROTOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHCTOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.collegeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ONETWOPLUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CHCTOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents collegeDataSet As VISION.collegeDataSet
    Friend WithEvents ONETWOPLUSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CHCTOPTableAdapter As VISION.collegeDataSetTableAdapters.CHCTOPTableAdapter
    Friend WithEvents ONETWOPLUSTableAdapter As VISION.collegeDataSetTableAdapters.ONETWOPLUSTableAdapter
    Friend WithEvents MROBOTTOMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents collegeDataSet2 As VISION.collegeDataSet
    Friend WithEvents MROTOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MROBOTTOMTableAdapter As VISION.collegeDataSetTableAdapters.MROBOTTOMTableAdapter
    Friend WithEvents MROTOPTableAdapter As VISION.collegeDataSetTableAdapters.MROTOPTableAdapter
End Class
