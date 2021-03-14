<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_AdmProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Aplicar = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btn_dltImg = New System.Windows.Forms.Button()
        Me.txt_Estado = New System.Windows.Forms.TextBox()
        Me.btn_AddImg = New System.Windows.Forms.Button()
        Me.prov_cmb = New System.Windows.Forms.ComboBox()
        Me.Categ_cmb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmargen = New System.Windows.Forms.TextBox()
        Me.txtprecioCompra = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtproductoid = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProdImagen = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ProdImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 45)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaDeVentas.My.Resources.Resources.icono_producto
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.SistemaDeVentas.My.Resources.Resources.iconox
        Me.Button1.Location = New System.Drawing.Point(694, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_Aplicar)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 404)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(743, 66)
        Me.Panel2.TabIndex = 1
        '
        'btn_Aplicar
        '
        Me.btn_Aplicar.Location = New System.Drawing.Point(627, 7)
        Me.btn_Aplicar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Aplicar.Name = "btn_Aplicar"
        Me.btn_Aplicar.Size = New System.Drawing.Size(112, 55)
        Me.btn_Aplicar.TabIndex = 51
        Me.btn_Aplicar.Text = "Guardar"
        Me.btn_Aplicar.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(4, 7)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(114, 55)
        Me.btnCancel.TabIndex = 50
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btn_dltImg
        '
        Me.btn_dltImg.Location = New System.Drawing.Point(606, 267)
        Me.btn_dltImg.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_dltImg.Name = "btn_dltImg"
        Me.btn_dltImg.Size = New System.Drawing.Size(77, 28)
        Me.btn_dltImg.TabIndex = 49
        Me.btn_dltImg.Text = "Eliminar"
        Me.btn_dltImg.UseVisualStyleBackColor = True
        '
        'txt_Estado
        '
        Me.txt_Estado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_Estado.Location = New System.Drawing.Point(11, 35)
        Me.txt_Estado.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Estado.Name = "txt_Estado"
        Me.txt_Estado.ReadOnly = True
        Me.txt_Estado.Size = New System.Drawing.Size(158, 22)
        Me.txt_Estado.TabIndex = 47
        Me.txt_Estado.TabStop = False
        '
        'btn_AddImg
        '
        Me.btn_AddImg.Location = New System.Drawing.Point(606, 231)
        Me.btn_AddImg.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_AddImg.Name = "btn_AddImg"
        Me.btn_AddImg.Size = New System.Drawing.Size(77, 28)
        Me.btn_AddImg.TabIndex = 45
        Me.btn_AddImg.Text = "Examinar"
        Me.btn_AddImg.UseVisualStyleBackColor = True
        '
        'prov_cmb
        '
        Me.prov_cmb.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.prov_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prov_cmb.FormattingEnabled = True
        Me.prov_cmb.Location = New System.Drawing.Point(231, 318)
        Me.prov_cmb.Name = "prov_cmb"
        Me.prov_cmb.Size = New System.Drawing.Size(323, 24)
        Me.prov_cmb.TabIndex = 31
        Me.prov_cmb.TabStop = False
        '
        'Categ_cmb
        '
        Me.Categ_cmb.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Categ_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Categ_cmb.FormattingEnabled = True
        Me.Categ_cmb.Location = New System.Drawing.Point(231, 288)
        Me.Categ_cmb.Name = "Categ_cmb"
        Me.Categ_cmb.Size = New System.Drawing.Size(323, 24)
        Me.Categ_cmb.TabIndex = 32
        Me.Categ_cmb.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(387, 8)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Código del producto:"
        '
        'txtmargen
        '
        Me.txtmargen.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtmargen.Location = New System.Drawing.Point(404, 229)
        Me.txtmargen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmargen.MaxLength = 9
        Me.txtmargen.Name = "txtmargen"
        Me.txtmargen.Size = New System.Drawing.Size(150, 22)
        Me.txtmargen.TabIndex = 37
        '
        'txtprecioCompra
        '
        Me.txtprecioCompra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtprecioCompra.Location = New System.Drawing.Point(175, 229)
        Me.txtprecioCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprecioCompra.Name = "txtprecioCompra"
        Me.txtprecioCompra.Size = New System.Drawing.Size(139, 22)
        Me.txtprecioCompra.TabIndex = 36
        '
        'txtnombre
        '
        Me.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtnombre.Location = New System.Drawing.Point(11, 85)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.MaxLength = 100
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(543, 22)
        Me.txtnombre.TabIndex = 35
        '
        'txtproductoid
        '
        Me.txtproductoid.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtproductoid.Location = New System.Drawing.Point(391, 35)
        Me.txtproductoid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtproductoid.Name = "txtproductoid"
        Me.txtproductoid.ReadOnly = True
        Me.txtproductoid.Size = New System.Drawing.Size(163, 22)
        Me.txtproductoid.TabIndex = 33
        Me.txtproductoid.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtstock)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtdescripcion)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtPrecioVenta)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btn_dltImg)
        Me.Panel3.Controls.Add(Me.txtproductoid)
        Me.Panel3.Controls.Add(Me.txt_Estado)
        Me.Panel3.Controls.Add(Me.txtnombre)
        Me.Panel3.Controls.Add(Me.btn_AddImg)
        Me.Panel3.Controls.Add(Me.txtprecioCompra)
        Me.Panel3.Controls.Add(Me.ProdImagen)
        Me.Panel3.Controls.Add(Me.txtmargen)
        Me.Panel3.Controls.Add(Me.prov_cmb)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Categ_cmb)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(743, 359)
        Me.Panel3.TabIndex = 2
        '
        'txtstock
        '
        Me.txtstock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtstock.Location = New System.Drawing.Point(404, 259)
        Me.txtstock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstock.MaxLength = 9
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(150, 22)
        Me.txtstock.TabIndex = 62
        Me.txtstock.Text = "0"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(338, 259)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 20)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Stock :"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtdescripcion.Location = New System.Drawing.Point(11, 135)
        Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescripcion.MaxLength = 200
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(543, 86)
        Me.txtdescripcion.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 111)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 20)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Descripción del producto:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 259)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Precio de Venta:"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtPrecioVenta.Location = New System.Drawing.Point(175, 259)
        Me.txtPrecioVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.ReadOnly = True
        Me.txtPrecioVenta.Size = New System.Drawing.Size(139, 22)
        Me.txtPrecioVenta.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(562, 184)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 40)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Imagen del producto:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Opcional)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 318)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(190, 20)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Proveedor del producto:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 288)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 20)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Categoria del producto:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 231)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Margen :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 229)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Precio de Compra:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 61)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 20)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Nombre del producto:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Estado del producto:"
        '
        'ProdImagen
        '
        Me.ProdImagen.ErrorImage = Nothing
        Me.ProdImagen.Location = New System.Drawing.Point(561, 9)
        Me.ProdImagen.Name = "ProdImagen"
        Me.ProdImagen.Size = New System.Drawing.Size(170, 170)
        Me.ProdImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProdImagen.TabIndex = 43
        Me.ProdImagen.TabStop = False
        '
        'Form_AdmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(743, 470)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_AdmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_AdmProductos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ProdImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_Aplicar As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btn_dltImg As Button
    Friend WithEvents txt_Estado As TextBox
    Friend WithEvents btn_AddImg As Button
    Friend WithEvents ProdImagen As PictureBox
    Friend WithEvents prov_cmb As ComboBox
    Friend WithEvents Categ_cmb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmargen As TextBox
    Friend WithEvents txtprecioCompra As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtproductoid As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtstock As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
