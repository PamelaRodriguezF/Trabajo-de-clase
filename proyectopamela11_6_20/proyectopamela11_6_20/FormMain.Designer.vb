<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TablaVerUsuarios = New System.Windows.Forms.DataGridView()
        Me.BotonActivarUsuario = New System.Windows.Forms.Button()
        Me.BotonCambiarClave = New System.Windows.Forms.Button()
        Me.NuevaClaveTexto = New System.Windows.Forms.TextBox()
        CType(Me.TablaVerUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaVerUsuarios
        '
        Me.TablaVerUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaVerUsuarios.Location = New System.Drawing.Point(-1, 75)
        Me.TablaVerUsuarios.Name = "TablaVerUsuarios"
        Me.TablaVerUsuarios.Size = New System.Drawing.Size(502, 248)
        Me.TablaVerUsuarios.TabIndex = 0
        '
        'BotonActivarUsuario
        '
        Me.BotonActivarUsuario.Location = New System.Drawing.Point(12, 12)
        Me.BotonActivarUsuario.Name = "BotonActivarUsuario"
        Me.BotonActivarUsuario.Size = New System.Drawing.Size(126, 23)
        Me.BotonActivarUsuario.TabIndex = 1
        Me.BotonActivarUsuario.Text = "Activar"
        Me.BotonActivarUsuario.UseVisualStyleBackColor = True
        '
        'BotonCambiarClave
        '
        Me.BotonCambiarClave.Location = New System.Drawing.Point(12, 41)
        Me.BotonCambiarClave.Name = "BotonCambiarClave"
        Me.BotonCambiarClave.Size = New System.Drawing.Size(126, 23)
        Me.BotonCambiarClave.TabIndex = 2
        Me.BotonCambiarClave.Text = "Cambiar clave"
        Me.BotonCambiarClave.UseVisualStyleBackColor = True
        '
        'NuevaClaveTexto
        '
        Me.NuevaClaveTexto.Location = New System.Drawing.Point(144, 43)
        Me.NuevaClaveTexto.Name = "NuevaClaveTexto"
        Me.NuevaClaveTexto.Size = New System.Drawing.Size(346, 20)
        Me.NuevaClaveTexto.TabIndex = 3
        Me.NuevaClaveTexto.Visible = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 335)
        Me.Controls.Add(Me.NuevaClaveTexto)
        Me.Controls.Add(Me.BotonCambiarClave)
        Me.Controls.Add(Me.BotonActivarUsuario)
        Me.Controls.Add(Me.TablaVerUsuarios)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        CType(Me.TablaVerUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TablaVerUsuarios As DataGridView
    Friend WithEvents BotonActivarUsuario As Button
    Friend WithEvents BotonCambiarClave As Button
    Friend WithEvents NuevaClaveTexto As TextBox
End Class
