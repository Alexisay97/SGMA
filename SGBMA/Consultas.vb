Public Class Consultas

    Private Sub Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SIGEBMA1DataSet.HerramientasDañadas' Puede moverla o quitarla según sea necesario.
        Me.HerramientasDañadasTableAdapter.Fill(Me.SIGEBMA1DataSet.HerramientasDañadas)
        'TODO: esta línea de código carga datos en la tabla 'SIGEBMA1DataSet.Prestamos' Puede moverla o quitarla según sea necesario.
        Me.PrestamosTableAdapter.Fill(Me.SIGEBMA1DataSet.Prestamos)
        'TODO: esta línea de código carga datos en la tabla 'SIGEBMA1DataSet.Herramientas' Puede moverla o quitarla según sea necesario.
        Me.HerramientasTableAdapter.Fill(Me.SIGEBMA1DataSet.Herramientas)

    End Sub
End Class