<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.Labelusuario1 = New System.Windows.Forms.Label()
        Me.Labelpass1 = New System.Windows.Forms.Label()
        Me.Textboxusuario1 = New System.Windows.Forms.TextBox()
        Me.TextBoxpass1 = New System.Windows.Forms.TextBox()
        Me.Buttonlogin = New System.Windows.Forms.Button()
        Me.Buttonlogin1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Labelusuario1
        '
        Me.Labelusuario1.AutoSize = True
        Me.Labelusuario1.Location = New System.Drawing.Point(32, 42)
        Me.Labelusuario1.Name = "Labelusuario1"
        Me.Labelusuario1.Size = New System.Drawing.Size(43, 13)
        Me.Labelusuario1.TabIndex = 0
        Me.Labelusuario1.Text = "Usuario"
        '
        'Labelpass1
        '
        Me.Labelpass1.AutoSize = True
        Me.Labelpass1.Location = New System.Drawing.Point(32, 118)
        Me.Labelpass1.Name = "Labelpass1"
        Me.Labelpass1.Size = New System.Drawing.Size(30, 13)
        Me.Labelpass1.TabIndex = 1
        Me.Labelpass1.Text = "Pass"
        '
        'Textboxusuario1
        '
        Me.Textboxusuario1.Location = New System.Drawing.Point(124, 42)
        Me.Textboxusuario1.Name = "Textboxusuario1"
        Me.Textboxusuario1.Size = New System.Drawing.Size(175, 20)
        Me.Textboxusuario1.TabIndex = 2
        '
        'TextBoxpass1
        '
        Me.TextBoxpass1.Location = New System.Drawing.Point(124, 111)
        Me.TextBoxpass1.Name = "TextBoxpass1"
        Me.TextBoxpass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxpass1.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxpass1.TabIndex = 3
        '
        'Buttonlogin
        '
        Me.Buttonlogin.Location = New System.Drawing.Point(35, 188)
        Me.Buttonlogin.Name = "Buttonlogin"
        Me.Buttonlogin.Size = New System.Drawing.Size(120, 23)
        Me.Buttonlogin.TabIndex = 4
        Me.Buttonlogin.Text = "No eres usuario?"
        Me.Buttonlogin.UseVisualStyleBackColor = True
        '
        'Buttonlogin1
        '
        Me.Buttonlogin1.Location = New System.Drawing.Point(224, 188)
        Me.Buttonlogin1.Name = "Buttonlogin1"
        Me.Buttonlogin1.Size = New System.Drawing.Size(75, 23)
        Me.Buttonlogin1.TabIndex = 5
        Me.Buttonlogin1.Text = "Login"
        Me.Buttonlogin1.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 255)
        Me.Controls.Add(Me.Buttonlogin1)
        Me.Controls.Add(Me.Buttonlogin)
        Me.Controls.Add(Me.TextBoxpass1)
        Me.Controls.Add(Me.Textboxusuario1)
        Me.Controls.Add(Me.Labelpass1)
        Me.Controls.Add(Me.Labelusuario1)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Labelusuario1 As System.Windows.Forms.Label
    Friend WithEvents Labelpass1 As System.Windows.Forms.Label
    Friend WithEvents Textboxusuario1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxpass1 As System.Windows.Forms.TextBox
    Friend WithEvents Buttonlogin As System.Windows.Forms.Button
    Friend WithEvents Buttonlogin1 As System.Windows.Forms.Button

End Class
