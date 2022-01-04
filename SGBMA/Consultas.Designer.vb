<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HerramientasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIGEBMA1DataSet = New SGBMA.SIGEBMA1DataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NieAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDocenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomHerramientaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaHoraEntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrestamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.CodHerramientaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomHerramientaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDañoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HerramientasDañadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HerramientasTableAdapter = New SGBMA.SIGEBMA1DataSetTableAdapters.HerramientasTableAdapter()
        Me.PrestamosTableAdapter = New SGBMA.SIGEBMA1DataSetTableAdapters.PrestamosTableAdapter()
        Me.HerramientasDañadasTableAdapter = New SGBMA.SIGEBMA1DataSetTableAdapters.HerramientasDañadasTableAdapter()
        Me.TipoCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodHerramientaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomHerramientaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAdquisicionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerramientasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIGEBMA1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerramientasDañadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(815, 343)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(807, 312)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoCargoDataGridViewTextBoxColumn, Me.CodHerramientaDataGridViewTextBoxColumn, Me.NomHerramientaDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.FechaAdquisicionDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HerramientasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(795, 305)
        Me.DataGridView1.TabIndex = 0
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(807, 312)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Prestamos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NieAlumnoDataGridViewTextBoxColumn, Me.NomAlumnoDataGridViewTextBoxColumn, Me.SeccionDataGridViewTextBoxColumn, Me.NomDocenteDataGridViewTextBoxColumn, Me.NomHerramientaDataGridViewTextBoxColumn1, Me.CantidadDataGridViewTextBoxColumn, Me.FechaHoraEntregaDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.PrestamosBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(3, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(798, 308)
        Me.DataGridView2.TabIndex = 0
        '
        'NieAlumnoDataGridViewTextBoxColumn
        '
        Me.NieAlumnoDataGridViewTextBoxColumn.DataPropertyName = "NieAlumno"
        Me.NieAlumnoDataGridViewTextBoxColumn.HeaderText = "NieAlumno"
        Me.NieAlumnoDataGridViewTextBoxColumn.Name = "NieAlumnoDataGridViewTextBoxColumn"
        '
        'NomAlumnoDataGridViewTextBoxColumn
        '
        Me.NomAlumnoDataGridViewTextBoxColumn.DataPropertyName = "NomAlumno"
        Me.NomAlumnoDataGridViewTextBoxColumn.HeaderText = "NomAlumno"
        Me.NomAlumnoDataGridViewTextBoxColumn.Name = "NomAlumnoDataGridViewTextBoxColumn"
        '
        'SeccionDataGridViewTextBoxColumn
        '
        Me.SeccionDataGridViewTextBoxColumn.DataPropertyName = "Seccion"
        Me.SeccionDataGridViewTextBoxColumn.HeaderText = "Seccion"
        Me.SeccionDataGridViewTextBoxColumn.Name = "SeccionDataGridViewTextBoxColumn"
        '
        'NomDocenteDataGridViewTextBoxColumn
        '
        Me.NomDocenteDataGridViewTextBoxColumn.DataPropertyName = "NomDocente"
        Me.NomDocenteDataGridViewTextBoxColumn.HeaderText = "NomDocente"
        Me.NomDocenteDataGridViewTextBoxColumn.Name = "NomDocenteDataGridViewTextBoxColumn"
        '
        'NomHerramientaDataGridViewTextBoxColumn1
        '
        Me.NomHerramientaDataGridViewTextBoxColumn1.DataPropertyName = "NomHerramienta"
        Me.NomHerramientaDataGridViewTextBoxColumn1.HeaderText = "NomHerramienta"
        Me.NomHerramientaDataGridViewTextBoxColumn1.Name = "NomHerramientaDataGridViewTextBoxColumn1"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'FechaHoraEntregaDataGridViewTextBoxColumn
        '
        Me.FechaHoraEntregaDataGridViewTextBoxColumn.DataPropertyName = "FechaHoraEntrega"
        Me.FechaHoraEntregaDataGridViewTextBoxColumn.HeaderText = "FechaHoraEntrega"
        Me.FechaHoraEntregaDataGridViewTextBoxColumn.Name = "FechaHoraEntregaDataGridViewTextBoxColumn"
        '
        'PrestamosBindingSource
        '
        Me.PrestamosBindingSource.DataMember = "Prestamos"
        Me.PrestamosBindingSource.DataSource = Me.SIGEBMA1DataSet
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(807, 312)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Herramientas Dañadas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodHerramientaDataGridViewTextBoxColumn1, Me.NomHerramientaDataGridViewTextBoxColumn2, Me.MarcaDataGridViewTextBoxColumn1, Me.DescripcionDañoDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.HerramientasDañadasBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(795, 305)
        Me.DataGridView3.TabIndex = 0
        '
        'CodHerramientaDataGridViewTextBoxColumn1
        '
        Me.CodHerramientaDataGridViewTextBoxColumn1.DataPropertyName = "CodHerramienta"
        Me.CodHerramientaDataGridViewTextBoxColumn1.HeaderText = "CodHerramienta"
        Me.CodHerramientaDataGridViewTextBoxColumn1.Name = "CodHerramientaDataGridViewTextBoxColumn1"
        Me.CodHerramientaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NomHerramientaDataGridViewTextBoxColumn2
        '
        Me.NomHerramientaDataGridViewTextBoxColumn2.DataPropertyName = "NomHerramienta"
        Me.NomHerramientaDataGridViewTextBoxColumn2.HeaderText = "NomHerramienta"
        Me.NomHerramientaDataGridViewTextBoxColumn2.Name = "NomHerramientaDataGridViewTextBoxColumn2"
        Me.NomHerramientaDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'MarcaDataGridViewTextBoxColumn1
        '
        Me.MarcaDataGridViewTextBoxColumn1.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.Name = "MarcaDataGridViewTextBoxColumn1"
        Me.MarcaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DescripcionDañoDataGridViewTextBoxColumn
        '
        Me.DescripcionDañoDataGridViewTextBoxColumn.DataPropertyName = "DescripcionDaño"
        Me.DescripcionDañoDataGridViewTextBoxColumn.HeaderText = "DescripcionDaño"
        Me.DescripcionDañoDataGridViewTextBoxColumn.Name = "DescripcionDañoDataGridViewTextBoxColumn"
        Me.DescripcionDañoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HerramientasDañadasBindingSource
        '
        Me.HerramientasDañadasBindingSource.DataMember = "HerramientasDañadas"
        Me.HerramientasDañadasBindingSource.DataSource = Me.SIGEBMA1DataSet
        '
        'HerramientasTableAdapter
        '
        Me.HerramientasTableAdapter.ClearBeforeFill = True
        '
        'PrestamosTableAdapter
        '
        Me.PrestamosTableAdapter.ClearBeforeFill = True
        '
        'HerramientasDañadasTableAdapter
        '
        Me.HerramientasDañadasTableAdapter.ClearBeforeFill = True
        '
        'TipoCargoDataGridViewTextBoxColumn
        '
        Me.TipoCargoDataGridViewTextBoxColumn.DataPropertyName = "TipoCargo"
        Me.TipoCargoDataGridViewTextBoxColumn.HeaderText = "TipoCargo"
        Me.TipoCargoDataGridViewTextBoxColumn.Name = "TipoCargoDataGridViewTextBoxColumn"
        '
        'CodHerramientaDataGridViewTextBoxColumn
        '
        Me.CodHerramientaDataGridViewTextBoxColumn.DataPropertyName = "CodHerramienta"
        Me.CodHerramientaDataGridViewTextBoxColumn.HeaderText = "CodHerramienta"
        Me.CodHerramientaDataGridViewTextBoxColumn.Name = "CodHerramientaDataGridViewTextBoxColumn"
        '
        'NomHerramientaDataGridViewTextBoxColumn
        '
        Me.NomHerramientaDataGridViewTextBoxColumn.DataPropertyName = "NomHerramienta"
        Me.NomHerramientaDataGridViewTextBoxColumn.HeaderText = "NomHerramienta"
        Me.NomHerramientaDataGridViewTextBoxColumn.Name = "NomHerramientaDataGridViewTextBoxColumn"
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "Serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        '
        'FechaAdquisicionDataGridViewTextBoxColumn
        '
        Me.FechaAdquisicionDataGridViewTextBoxColumn.DataPropertyName = "FechaAdquisicion"
        Me.FechaAdquisicionDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.FechaAdquisicionDataGridViewTextBoxColumn.Name = "FechaAdquisicionDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(839, 367)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Consultas"
        Me.Text = "Consultas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerramientasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIGEBMA1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerramientasDañadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SIGEBMA1DataSet As SGBMA.SIGEBMA1DataSet
    Friend WithEvents HerramientasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HerramientasTableAdapter As SGBMA.SIGEBMA1DataSetTableAdapters.HerramientasTableAdapter
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents PrestamosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrestamosTableAdapter As SGBMA.SIGEBMA1DataSetTableAdapters.PrestamosTableAdapter
    Friend WithEvents IdHerramientaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NieAlumnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomAlumnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomDocenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomHerramientaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaHoraEntregaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents HerramientasDañadasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HerramientasDañadasTableAdapter As SGBMA.SIGEBMA1DataSetTableAdapters.HerramientasDañadasTableAdapter
    Friend WithEvents CodHerramientaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomHerramientaDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDañoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCargoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodHerramientaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomHerramientaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAdquisicionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
