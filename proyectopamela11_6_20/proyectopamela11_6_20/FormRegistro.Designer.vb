<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistro
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
        Me.botonaceptar = New System.Windows.Forms.Button()
        Me.TextBoxpass = New System.Windows.Forms.TextBox()
        Me.TextBoxusuario = New System.Windows.Forms.TextBox()
        Me.labelpass = New System.Windows.Forms.Label()
        Me.labelusuario = New System.Windows.Forms.Label()
        Me.labelregistro = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'botonaceptar
        '
        Me.botonaceptar.Location = New System.Drawing.Point(201, 227)
        Me.botonaceptar.Name = "botonaceptar"
        Me.botonaceptar.Size = New System.Drawing.Size(75, 23)
        Me.botonaceptar.TabIndex = 10
        Me.botonaceptar.Text = "Aceptar"
        Me.botonaceptar.UseVisualStyleBackColor = True
        '
        'TextBoxpass
        '
        Me.TextBoxpass.Location = New System.Drawing.Point(101, 165)
        Me.TextBoxpass.Name = "TextBoxpass"
        Me.TextBoxpass.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxpass.TabIndex = 9
        '
        'TextBoxusuario
        '
        Me.TextBoxusuario.Location = New System.Drawing.Point(101, 96)
        Me.TextBoxusuario.Name = "TextBoxusuario"
        Me.TextBoxusuario.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxusuario.TabIndex = 8
        '
        'labelpass
        '
        Me.labelpass.AutoSize = True
        Me.labelpass.Location = New System.Drawing.Point(9, 172)
        Me.labelpass.Name = "labelpass"
        Me.labelpass.Size = New System.Drawing.Size(30, 13)
        Me.labelpass.TabIndex = 7
        Me.labelpass.Text = "Pass"
        '
        'labelusuario
        '
        Me.labelusuario.AutoSize = True
        Me.labelusuario.Location = New System.Drawing.Point(9, 96)
        Me.labelusuario.Name = "labelusuario"
        Me.labelusuario.Size = New System.Drawing.Size(43, 13)
        Me.labelusuario.TabIndex = 6
        Me.labelusuario.Text = "Usuario"
        '
        'labelregistro
        '
        Me.labelregistro.AutoSize = True
        Me.labelregistro.Location = New System.Drawing.Point(9, 24)
        Me.labelregistro.Name = "labelregistro"
        Me.labelregistro.Size = New System.Drawing.Size(46, 13)
        Me.labelregistro.TabIndex = 11
        Me.labelregistro.Text = "Registro"
        '
        'FormRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 263)
        Me.Controls.Add(Me.labelregistro)
        Me.Controls.Add(Me.botonaceptar)
        Me.Controls.Add(Me.TextBoxpass)
        Me.Controls.Add(Me.TextBoxusuario)
        Me.Controls.Add(Me.labelpass)
        Me.Controls.Add(Me.labelusuario)
        Me.Name = "FormRegistro"
        Me.Text = "FormRegistro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents botonaceptar As System.Windows.Forms.Button
    Friend WithEvents TextBoxpass As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxusuario As System.Windows.Forms.TextBox
    Friend WithEvents labelpass As System.Windows.Forms.Label
    Friend WithEvents labelusuario As System.Windows.Forms.Label
    Friend WithEvents labelregistro As System.Windows.Forms.Label
End Class
