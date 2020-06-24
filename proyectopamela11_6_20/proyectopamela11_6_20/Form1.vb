
Imports MySql.Data.MySqlClient

Public Class FormLogin
    
    Private Sub Buttonlogin1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonlogin1.Click
        Dim conexion As New MySqlConnection
        Dim cmd As New MySqlCommand

        Try
            conexion.ConnectionString = "server=localhost;database=usuarios_roles;Uid=root;Pwd=;"
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandText = "select nombre From usuarios where nombre= @nombre and pass= @pass and activo=1"
            cmd.Prepare()
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre", Textboxusuario1.Text)
            cmd.Parameters.AddWithValue("@pass", TextBoxpass1.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then

                FormMain.Show()
                Me.Hide()

            Else
                MsgBox("Debe crearse una cuenta")

            End If

            reader.Close()
            conexion.Close()


        Catch ex As Exception

            MsgBox(ex.Message)


        End Try
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Buttonlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonlogin.Click
      

        FormRegistro.Show()
        Me.Hide()



    End Sub
End Class
