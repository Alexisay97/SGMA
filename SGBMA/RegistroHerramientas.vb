Public Class RegistroHerramientas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ConectarBD()
        cmd.Connection = Conn
        cmd.CommandType = CommandType.Text

        sql = "INSERT INTO Herramientas(TipoCargo, CodHerramienta, NomHerramienta, Marca, Modelo, Serie, FechaAdquisicion, Estado, Valor) VALUES ('" & txtCargo.Text & "', '" & txtCod.Text & "','" & txtNom.Text & "','" & txtMarca.Text & "','" & txtModelo.Text & "','" & txtSerie.Text & "','" & txtEstado.Text & "','" & txtFecha.Text & "','" & txtValor.Text & "')"

        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()

            MsgBox("Ingresado Correctamente", MsgBoxStyle.Information, "Aviso")

            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Conn.Close()
        End Try

    End Sub

    Private Sub RegistroHerramientas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Lista.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Consultas.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class