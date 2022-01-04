Public Class frmPrestamos

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        ConectarBD()

        cmd.Connection = Conn

        cmd.CommandType = CommandType.Text

        sql = "INSERT INTO Prestamos (NieAlumno, NomAlumno, Seccion, NomDocente, NomHerramienta, Cantidad, FechaHoraEntrega) VALUES ('" & txtNie.Text & "', '" & txtAlum.Text & "', '" & txtSeccion.Text & "', '" & txtDocente.Text & "', '" & txtHerramienta.Text & "', '" & txtCant.Text & "', '" & txtFecha.Text & "')"

        cmd.CommandText = sql

        Try

            cmd.ExecuteNonQuery()

            MsgBox(" Guardado con exito ", MsgBoxStyle.Information, " Aviso")

            Conn.Close()

           
            txtCant.Text = " "
            txtHerramienta.Text = " "

        Catch ex As Exception

            ' MsgBox(ex.ToString)
            Conn.Close()

        End Try

    End Sub

    

    Private Sub frmPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

   
End Class