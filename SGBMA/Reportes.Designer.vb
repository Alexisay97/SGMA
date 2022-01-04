<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.HerramientasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIGEBMA1DataSet = New SGBMA.SIGEBMA1DataSet()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HerramientasTableAdapter = New SGBMA.SIGEBMA1DataSetTableAdapters.HerramientasTableAdapter()
        Me.SIGEBMA1DataSet1 = New SGBMA.SIGEBMA1DataSet1()
        Me.HerramientasDañadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HerramientasDañadasTableAdapter = New SGBMA.SIGEBMA1DataSet1TableAdapters.HerramientasDañadasTableAdapter()
        CType(Me.HerramientasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIGEBMA1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SIGEBMA1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerramientasDañadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HerramientasBindingSource
        '
        Me.HerramientasBindingSource.DataMember = "Herramientas"
        Me.HerramientasBindingSource.DataSource = Me.SIGEBMA1DataSet
        '
        'SIGEBMA1DataSet
        '
        Me.SIGEBMA1DataSet.DataSetName = "SIGEBMA1DataSet"
        Me.SIGEBMA1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(818, 415)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(810, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.HerramientasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SGBMA.ReporteInventario.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 6)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(798, 380)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(810, 389)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Herramientas Dañadas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.HerramientasDañadasBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "SGBMA.Report1.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(6, 6)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(798, 377)
        Me.ReportViewer2.TabIndex = 0
        '
        'HerramientasTableAdapter
        '
        Me.HerramientasTableAdapter.ClearBeforeFill = True
        '
        'SIGEBMA1DataSet1
        '
        Me.SIGEBMA1DataSet1.DataSetName = "SIGEBMA1DataSet1"
        Me.SIGEBMA1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HerramientasDañadasBindingSource
        '
        Me.HerramientasDañadasBindingSource.DataMember = "HerramientasDañadas"
        Me.HerramientasDañadasBindingSource.DataSource = Me.SIGEBMA1DataSet1
        '
        'HerramientasDañadasTableAdapter
        '
        Me.HerramientasDañadasTableAdapter.ClearBeforeFill = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(843, 440)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        CType(Me.HerramientasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIGEBMA1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.SIGEBMA1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerramientasDañadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents HerramientasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SIGEBMA1DataSet As SGBMA.SIGEBMA1DataSet
    Friend WithEvents HerramientasTableAdapter As SGBMA.SIGEBMA1DataSetTableAdapters.HerramientasTableAdapter
    Friend WithEvents HerramientasDañadasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SIGEBMA1DataSet1 As SGBMA.SIGEBMA1DataSet1
    Friend WithEvents HerramientasDañadasTableAdapter As SGBMA.SIGEBMA1DataSet1TableAdapters.HerramientasDañadasTableAdapter
End Class
