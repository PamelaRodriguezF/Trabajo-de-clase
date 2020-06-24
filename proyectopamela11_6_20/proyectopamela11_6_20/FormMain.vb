Imports MySql.Data.MySqlClient

Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargadatos()
    End Sub


    Sub cargadatos()
        Dim conexion As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim reader As New MySqlDataAdapter
        Dim ds As New DataSet
        Try
            conexion.ConnectionString = "server=localhost;database=usuarios_roles;Uid=root;Pwd=;"
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandText = "SELECT u.nombre AS NOMBRE, r.nombre AS ROL, u.pass AS CLAVE, u.activo AS ACTIVO FROM usuarios u JOIN roles r ON u.idrol = r.idrol;"

            reader.SelectCommand = cmd

            reader.Fill(ds)

            conexion.Close()

            TablaVerUsuarios.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CambiarDatos(query As String)

        Dim conexion As New MySqlConnection
        Dim cmd As New MySqlCommand

        Try
            conexion.ConnectionString = "server=localhost;database=usuarios_roles;Uid=root;Pwd=;"
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandText = query

            cmd.ExecuteNonQuery()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BotonActivarUsuario_Click(sender As Object, e As EventArgs) Handles BotonActivarUsuario.Click
        Dim query As String = "UPDATE usuarios SET activo = 1 WHERE nombre = '" + TablaVerUsuarios.Item(0, TablaVerUsuarios.CurrentCell.RowIndex).Value.ToString + "'"

        CambiarDatos(query)
        cargadatos()
    End Sub

    Dim NuevaClave As Boolean = False
    Private Sub BotonCambiarClave_Click(sender As Object, e As EventArgs) Handles BotonCambiarClave.Click

        If NuevaClave Then
            If Not NuevaClaveTexto.Text.Equals("") Then
                Dim query As String = "UPDATE usuarios SET pass = " + NuevaClaveTexto.Text + " WHERE nombre = '" + TablaVerUsuarios.Item(0, TablaVerUsuarios.CurrentCell.RowIndex).Value.ToString + "'"
                CambiarDatos(query)
            Else
                MsgBox("Ingrese texto")
            End If
        ElseIf Not NuevaClave Then
            NuevaClaveTexto.Visible = True
            NuevaClave = True
        End If
        cargadatos()

    End Sub
End Class