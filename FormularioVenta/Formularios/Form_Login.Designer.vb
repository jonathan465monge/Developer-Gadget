<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.txt_Pass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_UserInc = New System.Windows.Forms.Label()
        Me.lbl_PassInc = New System.Windows.Forms.Label()
        Me.btn_MInimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_MInimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(247, 284)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaDeVentas.My.Resources.Resources.WhatsApp_Image_2021_06_11_at_10_44_39
        Me.PictureBox1.Location = New System.Drawing.Point(33, 59)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(412, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicia Sesión"
        '
        'txt_Usuario
        '
        Me.txt_Usuario.BackColor = System.Drawing.Color.FloralWhite
        Me.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Usuario.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Usuario.ForeColor = System.Drawing.Color.DimGray
        Me.txt_Usuario.Location = New System.Drawing.Point(308, 82)
        Me.txt_Usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(323, 25)
        Me.txt_Usuario.TabIndex = 1
        Me.txt_Usuario.Text = "Ingrese aqui su nombre de usuario..."
        '
        'txt_Pass
        '
        Me.txt_Pass.BackColor = System.Drawing.Color.FloralWhite
        Me.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Pass.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pass.ForeColor = System.Drawing.Color.DimGray
        Me.txt_Pass.Location = New System.Drawing.Point(308, 141)
        Me.txt_Pass.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Pass.Name = "txt_Pass"
        Me.txt_Pass.Size = New System.Drawing.Size(323, 25)
        Me.txt_Pass.TabIndex = 2
        Me.txt_Pass.Text = "Ingrese aqui su contraseña..."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(386, 199)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Iniciar Sesión"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbl_UserInc
        '
        Me.lbl_UserInc.AutoSize = True
        Me.lbl_UserInc.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UserInc.ForeColor = System.Drawing.Color.Brown
        Me.lbl_UserInc.Location = New System.Drawing.Point(304, 109)
        Me.lbl_UserInc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_UserInc.Name = "lbl_UserInc"
        Me.lbl_UserInc.Size = New System.Drawing.Size(48, 17)
        Me.lbl_UserInc.TabIndex = 8
        Me.lbl_UserInc.Text = "Label2"
        Me.lbl_UserInc.Visible = False
        '
        'lbl_PassInc
        '
        Me.lbl_PassInc.AutoSize = True
        Me.lbl_PassInc.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PassInc.ForeColor = System.Drawing.Color.Brown
        Me.lbl_PassInc.Location = New System.Drawing.Point(305, 167)
        Me.lbl_PassInc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_PassInc.Name = "lbl_PassInc"
        Me.lbl_PassInc.Size = New System.Drawing.Size(48, 17)
        Me.lbl_PassInc.TabIndex = 9
        Me.lbl_PassInc.Text = "Label3"
        Me.lbl_PassInc.Visible = False
        '
        'btn_MInimizar
        '
        Me.btn_MInimizar.Image = Global.SistemaDeVentas.My.Resources.Resources.iconfinder_icon_minus_round_211863
        Me.btn_MInimizar.Location = New System.Drawing.Point(631, 10)
        Me.btn_MInimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_MInimizar.Name = "btn_MInimizar"
        Me.btn_MInimizar.Size = New System.Drawing.Size(31, 26)
        Me.btn_MInimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_MInimizar.TabIndex = 7
        Me.btn_MInimizar.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Image = Global.SistemaDeVentas.My.Resources.Resources.iconfinder_No_984759
        Me.btn_Cerrar.Location = New System.Drawing.Point(666, 10)
        Me.btn_Cerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(28, 26)
        Me.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cerrar.TabIndex = 6
        Me.btn_Cerrar.TabStop = False
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(702, 284)
        Me.Controls.Add(Me.lbl_PassInc)
        Me.Controls.Add(Me.lbl_UserInc)
        Me.Controls.Add(Me.btn_MInimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_Pass)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_MInimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents txt_Pass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents btn_MInimizar As PictureBox
    Friend WithEvents lbl_UserInc As Label
    Friend WithEvents lbl_PassInc As Label
End Class
