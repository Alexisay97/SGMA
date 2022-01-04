Public Class LoggIn

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Usuario As String
        Dim Clave As String

        Usuario = txtUser.Text
        Clave = txtContra.Text

        Login(Usuario, Clave)

    End Sub

   
    Private Sub LoggIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class