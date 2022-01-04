Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data
Imports System
Public Class Devoluciones

    Private Sub Devoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SIGEBMA1DataSet.Prestamos' Puede moverla o quitarla según sea necesario.




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        consultarPrestamos(grilla, txtBuscar.Text)
        
    End Sub

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        '    Try
        '    ConectarBD()
        '
        '  For Each fila As DataRow In grilla.Rows


        'Por ejemplo si tu datagridview posee 3 columnas, tendría la siguiente estructura
        '  Dim cmd As New SqlCommand("INSERT INTO Devoluciones VALUES(@param1,@param2,@param3, @param4, @param5 ,@param6, @param7) WHERE NieAlumno='" & txtBuscar.Text & "'", Conn)
        'El comando recibe los parametros, Columna 
        '  cmd.Parameters.Add("@param1", SqlDbType.Int).Value = Convert.ToInt32(fila.Item(0).ToString())
        'El comando recibe los parametros, Columna 
        ' cmd.Parameters.Add("@param2", SqlDbType.NVarChar, 50).Value = fila.Item(1).ToString()
        'El comando recibe los parametros, Columna 
        '' cmd.Parameters.Add("@param3", SqlDbType.NChar, 10).Value = fila.Item(2).ToString()
        'El comando recibe los parametros, Columna 
        ' cmd.Parameters.Add("@param4", SqlDbType.NVarChar, 50).Value = fila.Item(3).ToString()
        'El comando recibe los parametros, Columna
        '   cmd.Parameters.Add("@param5", SqlDbType.NVarChar, 50).Value = fila.Item(4).ToString()
        'El comando recibe los parametros, Columna 
        '  cmd.Parameters.Add("@param6", SqlDbType.Int).Value = Convert.ToInt32(fila.Item(5).ToString())
        'El comando recibe los parametros, Columna 
        '   cmd.Parameters.Add("@param7", SqlDbType.DateTime).Value = Convert.ToDateTime(fila.Item(6).ToString())

        'Abrimos conexion
        ' Conn.Open()

        'Ejecutamos el comando
        '  cmd.ExecuteNonQuery()

        'Cerramos conexion
        'Conn.Close()

        'MsgBox("Devuelto Correctamente", MsgBoxStyle.Exclamation, "Informe")

        '  Next

        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        '  End Try

    End Sub
End Class