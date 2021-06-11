<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Proveedor
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
        Me.btn_Activ = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.btn_Desact = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txt_Estado = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtproveedorid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Activ
        '
        Me.btn_Activ.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Activ.Location = New System.Drawing.Point(653, 12)
        Me.btn_Activ.Name = "btn_Activ"
        Me.btn_Activ.Size = New System.Drawing.Size(75, 23)
        Me.btn_Activ.TabIndex = 13
        Me.btn_Activ.Text = "Activar"
        Me.btn_Activ.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Buscar por: "
        '
        'cbocampo
        '
        Me.cbocampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"Nombre", "Direccion", "Telefono", "CorreoElectronico"})
        Me.cbocampo.Location = New System.Drawing.Point(90, 15)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(125, 21)
        Me.cbocampo.TabIndex = 12
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(220, 15)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(170, 20)
        Me.txtbuscar.TabIndex = 9
        '
        'btn_Desact
        '
        Me.btn_Desact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Desact.Location = New System.Drawing.Point(653, 12)
        Me.btn_Desact.Name = "btn_Desact"
        Me.btn_Desact.Size = New System.Drawing.Size(75, 23)
        Me.btn_Desact.TabIndex = 8
        Me.btn_Desact.Text = "Desactivar"
        Me.btn_Desact.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtcorreo)
        Me.GroupBox1.Controls.Add(Me.txt_Estado)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtproveedorid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 574)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MANTENIMIENTO DE PROVEEDORES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaDeVentas.My.Resources.Resources.WhatsApp_Image_2021_06_11_at_10_44_39
        Me.PictureBox1.Location = New System.Drawing.Point(5, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Estado del proveedor: "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 17)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Correo del proveedor: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Telefono del proveedor: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Direccion del proveedor: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Nombre del Proveedor: "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(6, 345)
        Me.txtcorreo.MaxLength = 100
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(241, 20)
        Me.txtcorreo.TabIndex = 32
        '
        'txt_Estado
        '
        Me.txt_Estado.Location = New System.Drawing.Point(6, 393)
        Me.txt_Estado.Name = "txt_Estado"
        Me.txt_Estado.ReadOnly = True
        Me.txt_Estado.Size = New System.Drawing.Size(241, 20)
        Me.txt_Estado.TabIndex = 30
        Me.txt_Estado.TabStop = False
        Me.txt_Estado.Visible = False
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(6, 305)
        Me.txttelefono.MaxLength = 9
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(241, 20)
        Me.txttelefono.TabIndex = 3
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(6, 264)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(241, 20)
        Me.txtdireccion.TabIndex = 2
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(175, 419)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 6
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(94, 419)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(75, 23)
        Me.btneditar.TabIndex = 5
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(94, 462)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 5
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(9, 419)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 4
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(6, 206)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(241, 20)
        Me.txtnombre.TabIndex = 1
        '
        'txtproveedorid
        '
        Me.txtproveedorid.Location = New System.Drawing.Point(108, 65)
        Me.txtproveedorid.Name = "txtproveedorid"
        Me.txtproveedorid.ReadOnly = True
        Me.txtproveedorid.Size = New System.Drawing.Size(116, 20)
        Me.txtproveedorid.TabIndex = 0
        Me.txtproveedorid.TabStop = False
        Me.txtproveedorid.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo del Proveedor (ID): "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(996, 574)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Inexistente)
        Me.GroupBox3.Controls.Add(Me.datalistado)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(256, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(740, 574)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LISTADO DE PROVEEDORES"
        '
        'Inexistente
        '
        Me.Inexistente.AutoSize = True
        Me.Inexistente.Location = New System.Drawing.Point(334, 292)
        Me.Inexistente.Name = "Inexistente"
        Me.Inexistente.Size = New System.Drawing.Size(94, 13)
        Me.Inexistente.TabIndex = 34
        Me.Inexistente.TabStop = True
        Me.Inexistente.Text = "Datos Inexistentes"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistado.Location = New System.Drawing.Point(2, 64)
        Me.datalistado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowTemplate.Height = 24
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(736, 508)
        Me.datalistado.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btn_Activ)
        Me.Panel2.Controls.Add(Me.txtbuscar)
        Me.Panel2.Controls.Add(Me.btn_Desact)
        Me.Panel2.Controls.Add(Me.cbocampo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(2, 15)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(736, 49)
        Me.Panel2.TabIndex = 14
        '
        'Form_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 574)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_Proveedor"
        Me.Text = "Form_Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btn_Desact As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtproveedorid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_Estado As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents btn_Activ As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Inexistente As LinkLabel
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
End Class
