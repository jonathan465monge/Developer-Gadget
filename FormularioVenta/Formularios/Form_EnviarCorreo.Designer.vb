<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_EnviarCorreo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_CorreoUser = New System.Windows.Forms.TextBox()
        Me.txt_PassUser = New System.Windows.Forms.TextBox()
        Me.txt_CorreoProv = New System.Windows.Forms.TextBox()
        Me.txt_Asunto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Pedido = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.btn_Examinar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_CorreoUser
        '
        Me.txt_CorreoUser.Location = New System.Drawing.Point(43, 2)
        Me.txt_CorreoUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_CorreoUser.Name = "txt_CorreoUser"
        Me.txt_CorreoUser.Size = New System.Drawing.Size(170, 20)
        Me.txt_CorreoUser.TabIndex = 0
        Me.txt_CorreoUser.TabStop = False
        '
        'txt_PassUser
        '
        Me.txt_PassUser.Location = New System.Drawing.Point(287, 2)
        Me.txt_PassUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_PassUser.Name = "txt_PassUser"
        Me.txt_PassUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_PassUser.Size = New System.Drawing.Size(160, 20)
        Me.txt_PassUser.TabIndex = 1
        '
        'txt_CorreoProv
        '
        Me.txt_CorreoProv.Location = New System.Drawing.Point(43, 37)
        Me.txt_CorreoProv.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_CorreoProv.Name = "txt_CorreoProv"
        Me.txt_CorreoProv.Size = New System.Drawing.Size(170, 20)
        Me.txt_CorreoProv.TabIndex = 2
        '
        'txt_Asunto
        '
        Me.txt_Asunto.Location = New System.Drawing.Point(287, 39)
        Me.txt_Asunto.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Asunto.Name = "txt_Asunto"
        Me.txt_Asunto.Size = New System.Drawing.Size(160, 20)
        Me.txt_Asunto.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "De: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Para: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contraseña: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 39)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Asunto: "
        '
        'txt_Pedido
        '
        Me.txt_Pedido.Location = New System.Drawing.Point(3, 121)
        Me.txt_Pedido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Pedido.Multiline = True
        Me.txt_Pedido.Name = "txt_Pedido"
        Me.txt_Pedido.Size = New System.Drawing.Size(444, 154)
        Me.txt_Pedido.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(196, 279)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Adjuntar un Archivo: "
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(113, 72)
        Me.txtRuta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(265, 20)
        Me.txtRuta.TabIndex = 11
        '
        'btn_Examinar
        '
        Me.btn_Examinar.BackColor = System.Drawing.Color.Lime
        Me.btn_Examinar.Location = New System.Drawing.Point(382, 69)
        Me.btn_Examinar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Examinar.Name = "btn_Examinar"
        Me.btn_Examinar.Size = New System.Drawing.Size(64, 25)
        Me.btn_Examinar.TabIndex = 12
        Me.btn_Examinar.Text = "Adjuntar"
        Me.btn_Examinar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Mensaje: "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.btn_Cerrar)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 32)
        Me.Panel1.TabIndex = 14
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.FlatAppearance.BorderSize = 0
        Me.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cerrar.Image = Global.SistemaDeVentas.My.Resources.Resources.iconox
        Me.btn_Cerrar.Location = New System.Drawing.Point(419, 3)
        Me.btn_Cerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(26, 28)
        Me.btn_Cerrar.TabIndex = 5
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Indigo
        Me.PictureBox1.Image = Global.SistemaDeVentas.My.Resources.Resources.icono_de_correo
        Me.PictureBox1.Location = New System.Drawing.Point(10, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_CorreoUser)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txt_PassUser)
        Me.Panel2.Controls.Add(Me.btn_Examinar)
        Me.Panel2.Controls.Add(Me.txt_CorreoProv)
        Me.Panel2.Controls.Add(Me.txtRuta)
        Me.Panel2.Controls.Add(Me.txt_Asunto)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_Pedido)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 318)
        Me.Panel2.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemaDeVentas.My.Resources.Resources.WhatsApp_Image_2021_06_11_at_10_44_39
        Me.PictureBox2.Location = New System.Drawing.Point(402, 275)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Form_EnviarCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 350)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_EnviarCorreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_EnviarCorreo"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_PassUser As TextBox
    Friend WithEvents txt_Asunto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Pedido As TextBox
    Public WithEvents txt_CorreoUser As TextBox
    Public WithEvents txt_CorreoProv As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Public WithEvents txtRuta As TextBox
    Friend WithEvents btn_Examinar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
