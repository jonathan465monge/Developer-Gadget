<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Ventas
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
        Me.panel_detalleVenta = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dataFact = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ventadetalle_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.eliminardeLista_btn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.agregarListado_btn = New System.Windows.Forms.Button()
        Me.pb_ProdImg = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ventaNew_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ventaId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_preciototal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.buscarProd_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombreProd = New System.Windows.Forms.TextBox()
        Me.txt_precioUnidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_prodId = New System.Windows.Forms.TextBox()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.CodigoDetalleVenta = New System.Windows.Forms.TextBox()
        Me.panel_detalleVenta.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataFact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb_ProdImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_detalleVenta
        '
        Me.panel_detalleVenta.Controls.Add(Me.GroupBox3)
        Me.panel_detalleVenta.Controls.Add(Me.GroupBox2)
        Me.panel_detalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_detalleVenta.Location = New System.Drawing.Point(0, 0)
        Me.panel_detalleVenta.Name = "panel_detalleVenta"
        Me.panel_detalleVenta.Size = New System.Drawing.Size(1179, 589)
        Me.panel_detalleVenta.TabIndex = 1
        Me.panel_detalleVenta.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dataFact)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(382, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(797, 589)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista de Productos"
        '
        'dataFact
        '
        Me.dataFact.AllowUserToAddRows = False
        Me.dataFact.AllowUserToDeleteRows = False
        Me.dataFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataFact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataFact.Location = New System.Drawing.Point(3, 75)
        Me.dataFact.Name = "dataFact"
        Me.dataFact.ReadOnly = True
        Me.dataFact.RowTemplate.Height = 24
        Me.dataFact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataFact.Size = New System.Drawing.Size(791, 413)
        Me.dataFact.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtTotalVenta)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.ventadetalle_btn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 488)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(791, 98)
        Me.Panel2.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(601, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "TOTAL:"
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalVenta.Location = New System.Drawing.Point(665, 11)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.ReadOnly = True
        Me.txtTotalVenta.Size = New System.Drawing.Size(117, 22)
        Me.txtTotalVenta.TabIndex = 26
        Me.txtTotalVenta.TabStop = False
        Me.txtTotalVenta.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(314, 54)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Imprimir Documento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 17)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Generar Documento:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(151, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(179, 24)
        Me.ComboBox1.TabIndex = 23
        '
        'ventadetalle_btn
        '
        Me.ventadetalle_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventadetalle_btn.Location = New System.Drawing.Point(665, 44)
        Me.ventadetalle_btn.Name = "ventadetalle_btn"
        Me.ventadetalle_btn.Size = New System.Drawing.Size(117, 48)
        Me.ventadetalle_btn.TabIndex = 8
        Me.ventadetalle_btn.Text = "Registrar venta"
        Me.ventadetalle_btn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.eliminardeLista_btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 57)
        Me.Panel1.TabIndex = 26
        '
        'eliminardeLista_btn
        '
        Me.eliminardeLista_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.eliminardeLista_btn.Location = New System.Drawing.Point(617, 11)
        Me.eliminardeLista_btn.Name = "eliminardeLista_btn"
        Me.eliminardeLista_btn.Size = New System.Drawing.Size(165, 40)
        Me.eliminardeLista_btn.TabIndex = 10
        Me.eliminardeLista_btn.Text = "Eliminar de la Lista"
        Me.eliminardeLista_btn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CodigoDetalleVenta)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnAplicar)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.agregarListado_btn)
        Me.GroupBox2.Controls.Add(Me.pb_ProdImg)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ventaNew_btn)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_ventaId)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_preciototal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.buscarProd_btn)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_nombreProd)
        Me.GroupBox2.Controls.Add(Me.txt_precioUnidad)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_prodId)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(382, 589)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(82, 168)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidad.TabIndex = 23
        '
        'agregarListado_btn
        '
        Me.agregarListado_btn.Location = New System.Drawing.Point(213, 405)
        Me.agregarListado_btn.Name = "agregarListado_btn"
        Me.agregarListado_btn.Size = New System.Drawing.Size(117, 51)
        Me.agregarListado_btn.TabIndex = 10
        Me.agregarListado_btn.Text = "Agregar al Listado"
        Me.agregarListado_btn.UseVisualStyleBackColor = True
        '
        'pb_ProdImg
        '
        Me.pb_ProdImg.ErrorImage = Nothing
        Me.pb_ProdImg.InitialImage = Nothing
        Me.pb_ProdImg.Location = New System.Drawing.Point(14, 242)
        Me.pb_ProdImg.Name = "pb_ProdImg"
        Me.pb_ProdImg.Size = New System.Drawing.Size(135, 121)
        Me.pb_ProdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_ProdImg.TabIndex = 22
        Me.pb_ProdImg.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Imagen del Producto:"
        '
        'ventaNew_btn
        '
        Me.ventaNew_btn.Location = New System.Drawing.Point(14, 405)
        Me.ventaNew_btn.Name = "ventaNew_btn"
        Me.ventaNew_btn.Size = New System.Drawing.Size(117, 51)
        Me.ventaNew_btn.TabIndex = 10
        Me.ventaNew_btn.Text = "Nueva venta"
        Me.ventaNew_btn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(267, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_ventaId
        '
        Me.txt_ventaId.Location = New System.Drawing.Point(110, 20)
        Me.txt_ventaId.Name = "txt_ventaId"
        Me.txt_ventaId.ReadOnly = True
        Me.txt_ventaId.Size = New System.Drawing.Size(94, 22)
        Me.txt_ventaId.TabIndex = 0
        Me.txt_ventaId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Precio Total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo Venta:"
        '
        'txt_preciototal
        '
        Me.txt_preciototal.Location = New System.Drawing.Point(282, 168)
        Me.txt_preciototal.Name = "txt_preciototal"
        Me.txt_preciototal.ReadOnly = True
        Me.txt_preciototal.Size = New System.Drawing.Size(91, 22)
        Me.txt_preciototal.TabIndex = 19
        Me.txt_preciototal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Producto:"
        '
        'buscarProd_btn
        '
        Me.buscarProd_btn.Location = New System.Drawing.Point(316, 84)
        Me.buscarProd_btn.Name = "buscarProd_btn"
        Me.buscarProd_btn.Size = New System.Drawing.Size(57, 29)
        Me.buscarProd_btn.TabIndex = 17
        Me.buscarProd_btn.Text = "..."
        Me.buscarProd_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buscarProd_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad:"
        '
        'txt_nombreProd
        '
        Me.txt_nombreProd.Location = New System.Drawing.Point(82, 88)
        Me.txt_nombreProd.Name = "txt_nombreProd"
        Me.txt_nombreProd.Size = New System.Drawing.Size(230, 22)
        Me.txt_nombreProd.TabIndex = 16
        '
        'txt_precioUnidad
        '
        Me.txt_precioUnidad.Location = New System.Drawing.Point(299, 129)
        Me.txt_precioUnidad.Name = "txt_precioUnidad"
        Me.txt_precioUnidad.ReadOnly = True
        Me.txt_precioUnidad.Size = New System.Drawing.Size(74, 22)
        Me.txt_precioUnidad.TabIndex = 4
        Me.txt_precioUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Codigo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Precio Unitario:"
        '
        'txt_prodId
        '
        Me.txt_prodId.Location = New System.Drawing.Point(82, 129)
        Me.txt_prodId.Name = "txt_prodId"
        Me.txt_prodId.ReadOnly = True
        Me.txt_prodId.Size = New System.Drawing.Size(100, 22)
        Me.txt_prodId.TabIndex = 6
        Me.txt_prodId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(213, 246)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(117, 51)
        Me.btnAplicar.TabIndex = 24
        Me.btnAplicar.Text = "Aplicar cambios a la venta"
        Me.btnAplicar.UseVisualStyleBackColor = True
        Me.btnAplicar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(213, 303)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 51)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar edicion"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'CodigoDetalleVenta
        '
        Me.CodigoDetalleVenta.Location = New System.Drawing.Point(82, 53)
        Me.CodigoDetalleVenta.Name = "CodigoDetalleVenta"
        Me.CodigoDetalleVenta.ReadOnly = True
        Me.CodigoDetalleVenta.Size = New System.Drawing.Size(100, 22)
        Me.CodigoDetalleVenta.TabIndex = 26
        Me.CodigoDetalleVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CodigoDetalleVenta.Visible = False
        '
        'Form_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1179, 589)
        Me.Controls.Add(Me.panel_detalleVenta)
        Me.Name = "Form_Ventas"
        Me.Text = "Form1"
        Me.panel_detalleVenta.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dataFact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pb_ProdImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_detalleVenta As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ventaId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ventadetalle_btn As Button
    Friend WithEvents ventaNew_btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents buscarProd_btn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_preciototal As TextBox
    Friend WithEvents agregarListado_btn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents eliminardeLista_btn As Button
    Public WithEvents txt_nombreProd As TextBox
    Public WithEvents txt_prodId As TextBox
    Public WithEvents txt_precioUnidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents pb_ProdImg As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Public WithEvents txtCantidad As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dataFact As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAplicar As Button
    Public WithEvents CodigoDetalleVenta As TextBox
End Class
