Public Class Devoluciones

    Private Sub Devoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SIGEBMADataSet.Prestamos' Puede moverla o quitarla según sea necesario.
        Me.PrestamosTableAdapter.Fill(Me.SIGEBMADataSet.Prestamos)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.PrestamosTableAdapter.FillBy(Me.SIGEBMADataSet.Prestamos, txtNie.Text)
    End Sub

    

End Class