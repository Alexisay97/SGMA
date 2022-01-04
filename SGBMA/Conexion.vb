Imports System.Data.SqlClient

Module Conexion

    Public Conn As New SqlConnection("Data Source=DESKTOP-P676JMO\SQLEXPRESS;Initial Catalog=SIGEBMA1;Integrated Security=True")

    Public cmd As New SqlCommand

    Public dr As SqlDataReader

    Public sql As String = " "

    Public adaptador = New SqlDataAdapter

    Public Sub ConectarBD()


        Try
            Conn.Open()
            'MsgBox("Conectado")

        Catch ex As Exception

            MsgBox(ex.ToString)

            Conn.Close()
        End Try

    End Sub

    Sub consultarPrestamos(ByVal tabla As DataGridView, ByRef NAlumno As String)
        adaptador = New SqlDataAdapter("select * from Prestamos WHERE NieAlumno='" & NAlumno & "'", Conn)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Prestamos")
        tabla.DataSource = dataS.Tables("Prestamos")
    End Sub

    Public Sub Login(ByVal usuario As String, ByVal contraseña As String)

        ConectarBD()

        cmd.Connection = Conn
        cmd.CommandType = CommandType.Text

        sql = "SELECT IdUsuario, Usuario, Clave FROM Usuarios  WHERE Usuario ='" + usuario + "' and Clave = '" + contraseña + "'"
        ' MsgBox(sql)

        cmd.CommandText = sql

        Try


            dr = cmd.ExecuteReader



            If dr.HasRows Then

                dr.Read()

                MsgBox("Acceso consedido")

                dr.Close()
                Conn.Close()
                LoggIn.Hide()
                Form1.Show()

            Else

                MsgBox("Verifique sus datos y vuelva a intentar", MsgBoxStyle.Critical, "USUARIO NO VALIDO")

                dr.Close()
                Conn.Close()
            End If


        Catch ex As Exception

            MsgBox(ex.ToString)
        End Try

    End Sub



End Module
