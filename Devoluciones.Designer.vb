<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Devoluciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNie = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SIGEBMADataSet = New SGBMA.SIGEBMADataSet()
        Me.PrestamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrestamosTableAdapter = New SGBMA.SIGEBMADataSetTableAdapters.PrestamosTableAdapter()
        Me.IdHerramientaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NieAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDocenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomHerramientaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaHoraEntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIGEBMADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtNie)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(311, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Devolver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(202, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(103, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtNie
        '
        Me.txtNie.Location = New System.Drawing.Point(53, 13)
        Me.txtNie.Name = "txtNie"
        Me.txtNie.Size = New System.Drawing.Size(132, 20)
        Me.txtNie.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nie no."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(623, 191)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdHerramientaDataGridViewTextBoxColumn, Me.NieAlumnoDataGridViewTextBoxColumn, Me.NomAlumnoDataGridViewTextBoxColumn, Me.SeccionDataGridViewTextBoxColumn, Me.NomDocenteDataGridViewTextBoxColumn, Me.NomHerramientaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.FechaHoraEntregaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PrestamosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(608, 173)
        Me.DataGridView1.TabIndex = 0
        '
        'SIGEBMADataSet
        '
        Me.SIGEBMADataSet.DataSetName = "SIGEBMADataSet"
        Me.SIGEBMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrestamosBindingSource
        '
        Me.PrestamosBindingSource.DataMember = "Prestamos"
        Me.PrestamosBindingSource.DataSource = Me.SIGEBMADataSet
        '
        'PrestamosTableAdapter
        '
        Me.PrestamosTableAdapter.ClearBeforeFill = True
        '
        'IdHerramientaDataGridViewTextBoxColumn
        '
        Me.IdHerramientaDataGridViewTextBoxColumn.DataPropertyName = "IdHerramienta"
        Me.IdHerramientaDataGridViewTextBoxColumn.HeaderText = "IdHerramienta"
        Me.IdHerramientaDataGridViewTextBoxColumn.Name = "IdHerramientaDataGridViewTextBoxColumn"
        Me.IdHerramientaDataGridViewTextBoxColumn.ReadOnly = True
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
        'NomHerramientaDataGridViewTextBoxColumn
        '
        Me.NomHerramientaDataGridViewTextBoxColumn.DataPropertyName = "NomHerramienta"
        Me.NomHerramientaDataGridViewTextBoxColumn.HeaderText = "NomHerramienta"
        Me.NomHerramientaDataGridViewTextBoxColumn.Name = "NomHerramientaDataGridViewTextBoxColumn"
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
        'Devoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 261)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Devoluciones"
        Me.Text = "Devoluciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIGEBMADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtNie As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SIGEBMADataSet As SGBMA.SIGEBMADataSet
    Friend WithEvents PrestamosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrestamosTableAdapter As SGBMA.SIGEBMADataSetTableAdapters.PrestamosTableAdapter
    Friend WithEvents IdHerramientaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NieAlumnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomAlumnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomDocenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomHerramientaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaHoraEntregaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
