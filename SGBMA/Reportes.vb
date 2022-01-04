Public Class Reportes

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SIGEBMA1DataSet1.HerramientasDañadas' Puede moverla o quitarla según sea necesario.
        Me.HerramientasDañadasTableAdapter.Fill(Me.SIGEBMA1DataSet1.HerramientasDañadas)
        'TODO: esta línea de código carga datos en la tabla 'SIGEBMA1DataSet.Herramientas' Puede moverla o quitarla según sea necesario.
        Me.HerramientasTableAdapter.Fill(Me.SIGEBMA1DataSet.Herramientas)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class