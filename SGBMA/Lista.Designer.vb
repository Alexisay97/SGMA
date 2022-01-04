<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"", "                                           **Codigo Institucional: 12979 ** ", "<-- Ejemplo del Codigo 12979-5899-0001 Cod. Instituto-Rubro-Correlativo -->", "", "-6802 Afilador de Herramientas", "-6803 Ajustador de Cola", "-6804 Alineador de Dirección", "-6805 Alineador de Viela", "-6806 Asentador de Motor", "-6808 Aserrador p/Metal", "-6809 Balanceador de Llanta", "-6810 Caja de Cola", "-6811 Canteador", "-6812 Cargador de Bateria", "-6813 Cepillador", "-6816 Compresor de Aire", "-6817 Comprobador ", "-6823 Dobladora", "-6826 Elevador", "-6827 Engrasadora", "-6828 Enrinador o Desenrrinador", "-6829 Equipo de Auto Analizador Mecánico", "-6830 Escoplador", "-6831 Esmerilador", "-6832 Espichera", "-6833 Fresador Universal", "-6837 Grúa", "-6842 Lijadora", "-6844 Limpiador de Bujía", "-6845 Mármol de Ajuste", "-6846 Mármol de Trazado", "-6847 Perforador de Cilindro", "-6848 Prensa", "-6862 Rectificador", "-6863 Remachador de Fricción", "-6867 Sargento(p/Prensar)", "-6868 Sierra", "-6872 Soldador", "-6877 Tecle", "-6878 Torno", "-6880 Tope de Seguridad", "-6884 Trompo(Para moldadura de madera)", "-6885 Vacuómetro", "-6886 Vehiculo Seccionado", "-6887 Yunque", "-6888 Marco para Sierra", "-6889 Taladro", "-6890 Soplador Electrico", "-6891 Tarraja", "-6892 Cortatubo", "-6893 Llave Stilson", "-6899 Otros no Incluidos en este Rubro"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(539, 454)
        Me.ListBox1.TabIndex = 0
        '
        'Lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 485)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Lista"
        Me.Text = "Lista de Codigos Mecancia Automotriz"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
