﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_UsuarioNuevo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_NombreUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Acceso = New System.Windows.Forms.TextBox()
        Me.txt_Correo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_TipoUsser = New System.Windows.Forms.ComboBox()
        Me.dataUsuarios = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_Dui = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Telefono = New System.Windows.Forms.MaskedTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dataUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre: "
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(9, 25)
        Me.txt_Nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(186, 20)
        Me.txt_Nombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 216)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dui"
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(9, 98)
        Me.txt_Direccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Direccion.Multiline = True
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(186, 80)
        Me.txt_Direccion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Direccion: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 180)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Telefono"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(9, 62)
        Me.txt_Apellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(186, 20)
        Me.txt_Apellido.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 46)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Apellido:"
        '
        'txt_NombreUser
        '
        Me.txt_NombreUser.Location = New System.Drawing.Point(9, 306)
        Me.txt_NombreUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_NombreUser.Name = "txt_NombreUser"
        Me.txt_NombreUser.Size = New System.Drawing.Size(186, 20)
        Me.txt_NombreUser.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 289)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nombre Usuario"
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(9, 342)
        Me.txt_contraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña.Size = New System.Drawing.Size(186, 20)
        Me.txt_contraseña.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 326)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Contraseña"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(9, 440)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 42)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Registrar Usuario"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 362)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tipo Usuario"
        '
        'txt_Acceso
        '
        Me.txt_Acceso.Location = New System.Drawing.Point(10, 403)
        Me.txt_Acceso.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Acceso.Name = "txt_Acceso"
        Me.txt_Acceso.Size = New System.Drawing.Size(76, 20)
        Me.txt_Acceso.TabIndex = 16
        Me.txt_Acceso.Visible = False
        '
        'txt_Correo
        '
        Me.txt_Correo.Location = New System.Drawing.Point(9, 269)
        Me.txt_Correo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Correo.Name = "txt_Correo"
        Me.txt_Correo.Size = New System.Drawing.Size(186, 20)
        Me.txt_Correo.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 253)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Correo Electronico"
        '
        'cmb_TipoUsser
        '
        Me.cmb_TipoUsser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoUsser.FormattingEnabled = True
        Me.cmb_TipoUsser.Items.AddRange(New Object() {"Vendedor"})
        Me.cmb_TipoUsser.Location = New System.Drawing.Point(10, 379)
        Me.cmb_TipoUsser.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_TipoUsser.Name = "cmb_TipoUsser"
        Me.cmb_TipoUsser.Size = New System.Drawing.Size(186, 21)
        Me.cmb_TipoUsser.TabIndex = 9
        '
        'dataUsuarios
        '
        Me.dataUsuarios.AllowUserToAddRows = False
        Me.dataUsuarios.AllowUserToDeleteRows = False
        Me.dataUsuarios.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.dataUsuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.dataUsuarios.Name = "dataUsuarios"
        Me.dataUsuarios.ReadOnly = True
        Me.dataUsuarios.RowTemplate.Height = 24
        Me.dataUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataUsuarios.Size = New System.Drawing.Size(641, 492)
        Me.dataUsuarios.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.txt_Dui)
        Me.Panel1.Controls.Add(Me.txt_Telefono)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_Nombre)
        Me.Panel1.Controls.Add(Me.cmb_TipoUsser)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_Correo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_Acceso)
        Me.Panel1.Controls.Add(Me.txt_Direccion)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txt_contraseña)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_Apellido)
        Me.Panel1.Controls.Add(Me.txt_NombreUser)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 492)
        Me.Panel1.TabIndex = 19
        '
        'txt_Dui
        '
        Me.txt_Dui.Location = New System.Drawing.Point(9, 232)
        Me.txt_Dui.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Dui.Mask = "00000000-0"
        Me.txt_Dui.Name = "txt_Dui"
        Me.txt_Dui.Size = New System.Drawing.Size(186, 20)
        Me.txt_Dui.TabIndex = 5
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(9, 196)
        Me.txt_Telefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Telefono.Mask = "0000-0000"
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(186, 20)
        Me.txt_Telefono.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dataUsuarios)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(199, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(641, 492)
        Me.Panel2.TabIndex = 20
        '
        'Form_UsuarioNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 492)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_UsuarioNuevo"
        Me.Text = "Form_UsuarioNuevo"
        CType(Me.dataUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Direccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_NombreUser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Acceso As TextBox
    Friend WithEvents txt_Correo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_TipoUsser As ComboBox
    Friend WithEvents dataUsuarios As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_Dui As MaskedTextBox
    Friend WithEvents txt_Telefono As MaskedTextBox
    Friend WithEvents Panel2 As Panel
End Class
