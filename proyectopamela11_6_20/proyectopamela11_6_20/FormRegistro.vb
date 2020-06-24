Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class FormRegistro

    Private Sub botonaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonaceptar.Click

        Dim conexion As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader

        Dim Comprobador As String

        Try


            conexion.ConnectionString = "server=localhost;database=usuarios_roles;Uid=root;Pwd=;"
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandText = "Select count(*) From Usuarios where nombre = '" + TextBoxusuario.Text + "';"

            reader = cmd.ExecuteReader()

            If reader.Read Then
                Comprobador = reader.GetString(0)

                reader.Close()

                If Comprobador.Equals("1") Then
                    MsgBox("El Usuario ya existe")
                ElseIf Comprobador.Equals("0") Then
                    cmd.CommandText = "INSERT INTO usuarios (nombre, pass, activo, idrol) VALUES ('" + TextBoxusuario.Text + "', '" + TextBoxpass.Text + "', 0, 3);"
                    cmd.ExecuteNonQuery()

                    MsgBox("Usuario ingresado")
                    TextBoxusuario.Text = ""
                    TextBoxpass.Text = ""
                Else
                    MsgBox("Mas de un usuario con ese nombre? Contactar con administrador")
                End If
            End If

            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class