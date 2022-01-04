Public Class DescargoHerrameintas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        ConectarBD()

        cmd.Connection = Conn
        cmd.CommandType = CommandType.Text


        sql = "INSERT INTO HerramientasDañadas(CodHerramienta, NomHerramienta, Marca, DescripcionDaño) VALUES ('" & txtCod.Text & "','" & txtHerramienta.Text & "', '" & txtMarca.Text & "','" & txtDescripcion.Text & "')"

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Ingresado Correctamente", MsgBoxStyle.Information, "Aviso")
            Conn.Close()
        Catch ex As Exception

            MsgBox(ex.ToString)

            Conn.Close()
        End Try


        sql = "DELETE IdHerramienta, TipoCargo, CodHerramienta, NomHerramienta, Marca, Modelo, Serie, FechaAdquisicion, Estado, Valor FROM Herramientas WHERE CodHerramienta = '" & txtCod.Text & "'"

        cmd.CommandText = sql

        Try
            Conn.Open()
            cmd.ExecuteNonQuery()

            MsgBox("Proceso ejecutado con exito", MsgBoxStyle.Exclamation, "Exito")
            Conn.Close()
        Catch ex As Exception

            MsgBox(ex.ToString)

            Conn.Close()

        End Try



    End Sub

    Private Sub DescargoHerrameintas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        cmd.Connection = Conn
        Conn.Open()
        cmd.CommandType = CommandType.Text


        sql = "SELECT CodHerramienta, NomHerramienta, Marca, Estado FROM Herramientas WHERE CodHerramienta= '" & txtCod.Text & "'"

        cmd.CommandText = sql

        Try

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()

                txtHerramienta.Text = dr(1).ToString
                txtMarca.Text = dr(2).ToString

                dr.Close()
                Conn.Close()

            Else

                MsgBox("No se encontro la herramienta", MsgBoxStyle.Exclamation, "ERROR /.\")


            End If

            dr.Close()
            Conn.Close()


            MsgBox("Archivo encontrado")
        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Consultas.ShowDialog()
    End Sub
End Class