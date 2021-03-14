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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.txt_Pass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_UserInc = New System.Windows.Forms.Label()
        Me.lbl_PassInc = New System.Windows.Forms.Label()
        Me.btn_MInimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_MInimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 437)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(618, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicia Sesión"
        '
        'txt_Usuario
        '
        Me.txt_Usuario.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Usuario.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Usuario.ForeColor = System.Drawing.Color.DimGray
        Me.txt_Usuario.Location = New System.Drawing.Point(462, 126)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(484, 34)
        Me.txt_Usuario.TabIndex = 1
        Me.txt_Usuario.Text = "Ingrese aqui su nombre de usuario..."
        '
        'txt_Pass
        '
        Me.txt_Pass.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Pass.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pass.ForeColor = System.Drawing.Color.DimGray
        Me.txt_Pass.Location = New System.Drawing.Point(462, 217)
        Me.txt_Pass.Name = "txt_Pass"
        Me.txt_Pass.Size = New System.Drawing.Size(484, 34)
        Me.txt_Pass.TabIndex = 2
        Me.txt_Pass.Text = "Ingrese aqui su contraseña..."
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(579, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(266, 49)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Iniciar Sesión"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_UserInc
        '
        Me.lbl_UserInc.AutoSize = True
        Me.lbl_UserInc.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UserInc.ForeColor = System.Drawing.Color.Brown
        Me.lbl_UserInc.Location = New System.Drawing.Point(456, 168)
        Me.lbl_UserInc.Name = "lbl_UserInc"
        Me.lbl_UserInc.Size = New System.Drawing.Size(70, 25)
        Me.lbl_UserInc.TabIndex = 8
        Me.lbl_UserInc.Text = "Label2"
        Me.lbl_UserInc.Visible = False
        '
        'lbl_PassInc
        '
        Me.lbl_PassInc.AutoSize = True
        Me.lbl_PassInc.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PassInc.ForeColor = System.Drawing.Color.Brown
        Me.lbl_PassInc.Location = New System.Drawing.Point(458, 257)
        Me.lbl_PassInc.Name = "lbl_PassInc"
        Me.lbl_PassInc.Size = New System.Drawing.Size(70, 25)
        Me.lbl_PassInc.TabIndex = 9
        Me.lbl_PassInc.Text = "Label3"
        Me.lbl_PassInc.Visible = False
        '
        'btn_MInimizar
        '
        Me.btn_MInimizar.Image = Global.SistemaDeVentas.My.Resources.Resources.iconfinder_icon_minus_round_211863
        Me.btn_MInimizar.Location = New System.Drawing.Point(947, 15)
        Me.btn_MInimizar.Name = "btn_MInimizar"
        Me.btn_MInimizar.Size = New System.Drawing.Size(46, 40)
        Me.btn_MInimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_MInimizar.TabIndex = 7
        Me.btn_MInimizar.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Image = Global.SistemaDeVentas.My.Resources.Resources.iconfinder_No_984759
        Me.btn_Cerrar.Location = New System.Drawing.Point(999, 15)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(42, 40)
        Me.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cerrar.TabIndex = 6
        Me.btn_Cerrar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaDeVentas.My.Resources.Resources.Libro1pequeño
        Me.PictureBox1.Location = New System.Drawing.Point(50, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 263)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1053, 437)
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
        Me.Name = "Form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btn_MInimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
