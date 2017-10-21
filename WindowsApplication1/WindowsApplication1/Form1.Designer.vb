<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DBLKSDataSet6 = New WindowsApplication1.DBLKSDataSet6()
        Me.View_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_1TableAdapter = New WindowsApplication1.DBLKSDataSet6TableAdapters.View_1TableAdapter()
        CType(Me.DBLKSDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.View_1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(790, 509)
        Me.ReportViewer1.TabIndex = 0
        '
        'DBLKSDataSet6
        '
        Me.DBLKSDataSet6.DataSetName = "DBLKSDataSet6"
        Me.DBLKSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_1BindingSource
        '
        Me.View_1BindingSource.DataMember = "View_1"
        Me.View_1BindingSource.DataSource = Me.DBLKSDataSet6
        '
        'View_1TableAdapter
        '
        Me.View_1TableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 509)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DBLKSDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents View_1BindingSource As BindingSource
    Friend WithEvents DBLKSDataSet6 As DBLKSDataSet6
    Friend WithEvents View_1TableAdapter As DBLKSDataSet6TableAdapters.View_1TableAdapter
End Class
