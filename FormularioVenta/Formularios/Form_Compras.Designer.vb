﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Compras
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
        Me.components = New System.ComponentModel.Container()
        Me.tmCompraUP = New System.Windows.Forms.Timer(Me.components)
        Me.tmCompraDOWN = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.comprar = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dataCompraRecien = New System.Windows.Forms.DataGridView()
        Me.CompraID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelConfirmar = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_EvniarCompra = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelDetalles = New System.Windows.Forms.Panel()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_AddLista = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_prodId = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_preciototal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pb_Prodimg = New System.Windows.Forms.PictureBox()
        Me.CodigoDetalle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.buscarProd_btn = New System.Windows.Forms.Button()
        Me.btnCancelEdit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_precioUnidad = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txt_nombreProd = New System.Windows.Forms.TextBox()
        Me.panelDetallesCompra = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_pedido = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_Prove = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelee = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.pedidos = New System.Windows.Forms.TabPage()
        Me.dataEstadoPedido = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_Confirmar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.historial = New System.Windows.Forms.TabPage()
        Me.dataCompraHistorial = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.comprar.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dataCompraRecien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelConfirmar.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelDetalles.SuspendLayout()
        CType(Me.pb_Prodimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDetallesCompra.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pedidos.SuspendLayout()
        CType(Me.dataEstadoPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.historial.SuspendLayout()
        CType(Me.dataCompraHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.comprar)
        Me.TabControl1.Controls.Add(Me.pedidos)
        Me.TabControl1.Controls.Add(Me.historial)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1485, 798)
        Me.TabControl1.TabIndex = 0
        '
        'comprar
        '
        Me.comprar.Controls.Add(Me.Panel4)
        Me.comprar.Controls.Add(Me.Panel3)
        Me.comprar.Location = New System.Drawing.Point(4, 29)
        Me.comprar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comprar.Name = "comprar"
        Me.comprar.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comprar.Size = New System.Drawing.Size(1477, 765)
        Me.comprar.TabIndex = 0
        Me.comprar.Text = "Realizar Compra"
        Me.comprar.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dataCompraRecien)
        Me.Panel4.Controls.Add(Me.panelConfirmar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(455, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1019, 757)
        Me.Panel4.TabIndex = 5
        '
        'dataCompraRecien
        '
        Me.dataCompraRecien.AllowUserToAddRows = False
        Me.dataCompraRecien.AllowUserToDeleteRows = False
        Me.dataCompraRecien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataCompraRecien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompraID, Me.ProductoID, Me.NombreProducto, Me.Cantidad, Me.PrecioTotal, Me.PrecioUnidad})
        Me.dataCompraRecien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataCompraRecien.Location = New System.Drawing.Point(0, 0)
        Me.dataCompraRecien.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dataCompraRecien.Name = "dataCompraRecien"
        Me.dataCompraRecien.ReadOnly = True
        Me.dataCompraRecien.RowHeadersWidth = 62
        Me.dataCompraRecien.RowTemplate.Height = 24
        Me.dataCompraRecien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataCompraRecien.Size = New System.Drawing.Size(1019, 648)
        Me.dataCompraRecien.TabIndex = 40
        '
        'CompraID
        '
        Me.CompraID.HeaderText = "CompraID"
        Me.CompraID.MinimumWidth = 8
        Me.CompraID.Name = "CompraID"
        Me.CompraID.ReadOnly = True
        Me.CompraID.Width = 150
        '
        'ProductoID
        '
        Me.ProductoID.HeaderText = "ProductoID"
        Me.ProductoID.MinimumWidth = 8
        Me.ProductoID.Name = "ProductoID"
        Me.ProductoID.ReadOnly = True
        Me.ProductoID.Width = 150
        '
        'NombreProducto
        '
        Me.NombreProducto.HeaderText = "NombreProducto"
        Me.NombreProducto.MinimumWidth = 8
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.ReadOnly = True
        Me.NombreProducto.Width = 150
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 8
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 150
        '
        'PrecioTotal
        '
        Me.PrecioTotal.HeaderText = "PrecioTotal"
        Me.PrecioTotal.MinimumWidth = 8
        Me.PrecioTotal.Name = "PrecioTotal"
        Me.PrecioTotal.ReadOnly = True
        Me.PrecioTotal.Width = 150
        '
        'PrecioUnidad
        '
        Me.PrecioUnidad.HeaderText = "PrecioUnidad"
        Me.PrecioUnidad.MinimumWidth = 8
        Me.PrecioUnidad.Name = "PrecioUnidad"
        Me.PrecioUnidad.ReadOnly = True
        Me.PrecioUnidad.Width = 150
        '
        'panelConfirmar
        '
        Me.panelConfirmar.Controls.Add(Me.Panel7)
        Me.panelConfirmar.Controls.Add(Me.Panel2)
        Me.panelConfirmar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelConfirmar.Enabled = False
        Me.panelConfirmar.Location = New System.Drawing.Point(0, 648)
        Me.panelConfirmar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelConfirmar.Name = "panelConfirmar"
        Me.panelConfirmar.Size = New System.Drawing.Size(1019, 109)
        Me.panelConfirmar.TabIndex = 39
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Controls.Add(Me.txtTotalVenta)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(515, 109)
        Me.Panel7.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(187, 20)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "TOTAL DE LA COMPRA:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(43, 48)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(412, 55)
        Me.Button1.TabIndex = 38
        Me.Button1.TabStop = False
        Me.Button1.Text = "Guardar Pedido"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtTotalVenta.Location = New System.Drawing.Point(232, 10)
        Me.txtTotalVenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.ReadOnly = True
        Me.txtTotalVenta.Size = New System.Drawing.Size(219, 26)
        Me.txtTotalVenta.TabIndex = 41
        Me.txtTotalVenta.TabStop = False
        Me.txtTotalVenta.Text = "0"
        Me.txtTotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.btn_EvniarCompra)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(515, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(504, 109)
        Me.Panel2.TabIndex = 43
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(57, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(388, 30)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Puede enviar su pedido desde aqui:"
        '
        'btn_EvniarCompra
        '
        Me.btn_EvniarCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btn_EvniarCompra.Location = New System.Drawing.Point(63, 48)
        Me.btn_EvniarCompra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_EvniarCompra.Name = "btn_EvniarCompra"
        Me.btn_EvniarCompra.Size = New System.Drawing.Size(378, 55)
        Me.btn_EvniarCompra.TabIndex = 37
        Me.btn_EvniarCompra.TabStop = False
        Me.btn_EvniarCompra.Text = "Enviar pedido al proveedor..."
        Me.btn_EvniarCompra.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PanelDetalles)
        Me.Panel3.Controls.Add(Me.panelDetallesCompra)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(3, 4)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(452, 757)
        Me.Panel3.TabIndex = 4
        '
        'PanelDetalles
        '
        Me.PanelDetalles.Controls.Add(Me.eliminar)
        Me.PanelDetalles.Controls.Add(Me.Label9)
        Me.PanelDetalles.Controls.Add(Me.btn_AddLista)
        Me.PanelDetalles.Controls.Add(Me.Label4)
        Me.PanelDetalles.Controls.Add(Me.txt_prodId)
        Me.PanelDetalles.Controls.Add(Me.Label10)
        Me.PanelDetalles.Controls.Add(Me.Label11)
        Me.PanelDetalles.Controls.Add(Me.txt_preciototal)
        Me.PanelDetalles.Controls.Add(Me.Label6)
        Me.PanelDetalles.Controls.Add(Me.pb_Prodimg)
        Me.PanelDetalles.Controls.Add(Me.CodigoDetalle)
        Me.PanelDetalles.Controls.Add(Me.Label7)
        Me.PanelDetalles.Controls.Add(Me.Label8)
        Me.PanelDetalles.Controls.Add(Me.buscarProd_btn)
        Me.PanelDetalles.Controls.Add(Me.btnCancelEdit)
        Me.PanelDetalles.Controls.Add(Me.Label5)
        Me.PanelDetalles.Controls.Add(Me.txt_precioUnidad)
        Me.PanelDetalles.Controls.Add(Me.txtCantidad)
        Me.PanelDetalles.Controls.Add(Me.btnEdit)
        Me.PanelDetalles.Controls.Add(Me.txt_nombreProd)
        Me.PanelDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetalles.Enabled = False
        Me.PanelDetalles.Location = New System.Drawing.Point(0, 179)
        Me.PanelDetalles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelDetalles.Name = "PanelDetalles"
        Me.PanelDetalles.Size = New System.Drawing.Size(452, 489)
        Me.PanelDetalles.TabIndex = 44
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(200, 326)
        Me.eliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(217, 62)
        Me.eliminar.TabIndex = 43
        Me.eliminar.TabStop = False
        Me.eliminar.Text = "Eliminar del listado"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(246, 30)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Detalles de la compra:"
        '
        'btn_AddLista
        '
        Me.btn_AddLista.Location = New System.Drawing.Point(3, 408)
        Me.btn_AddLista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_AddLista.Name = "btn_AddLista"
        Me.btn_AddLista.Size = New System.Drawing.Size(440, 71)
        Me.btn_AddLista.TabIndex = 5
        Me.btn_AddLista.Text = "Agregar producto a la lista"
        Me.btn_AddLista.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Precio Total:"
        '
        'txt_prodId
        '
        Me.txt_prodId.Location = New System.Drawing.Point(92, 111)
        Me.txt_prodId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_prodId.Name = "txt_prodId"
        Me.txt_prodId.ReadOnly = True
        Me.txt_prodId.Size = New System.Drawing.Size(112, 26)
        Me.txt_prodId.TabIndex = 24
        Me.txt_prodId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 20)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Imagen del producto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(212, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 20)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Codigo del detalle:"
        Me.Label11.Visible = False
        '
        'txt_preciototal
        '
        Me.txt_preciototal.Location = New System.Drawing.Point(336, 159)
        Me.txt_preciototal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_preciototal.Name = "txt_preciototal"
        Me.txt_preciototal.ReadOnly = True
        Me.txt_preciototal.Size = New System.Drawing.Size(109, 26)
        Me.txt_preciototal.TabIndex = 30
        Me.txt_preciototal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Precio Unitario:"
        '
        'pb_Prodimg
        '
        Me.pb_Prodimg.ErrorImage = Nothing
        Me.pb_Prodimg.Location = New System.Drawing.Point(11, 246)
        Me.pb_Prodimg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_Prodimg.Name = "pb_Prodimg"
        Me.pb_Prodimg.Size = New System.Drawing.Size(156, 154)
        Me.pb_Prodimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Prodimg.TabIndex = 34
        Me.pb_Prodimg.TabStop = False
        '
        'CodigoDetalle
        '
        Me.CodigoDetalle.Location = New System.Drawing.Point(359, 205)
        Me.CodigoDetalle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CodigoDetalle.Name = "CodigoDetalle"
        Me.CodigoDetalle.ReadOnly = True
        Me.CodigoDetalle.Size = New System.Drawing.Size(86, 26)
        Me.CodigoDetalle.TabIndex = 40
        Me.CodigoDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CodigoDetalle.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Producto:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Codigo:"
        '
        'buscarProd_btn
        '
        Me.buscarProd_btn.Location = New System.Drawing.Point(381, 68)
        Me.buscarProd_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buscarProd_btn.Name = "buscarProd_btn"
        Me.buscarProd_btn.Size = New System.Drawing.Size(64, 36)
        Me.buscarProd_btn.TabIndex = 28
        Me.buscarProd_btn.Text = "..."
        Me.buscarProd_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buscarProd_btn.UseVisualStyleBackColor = True
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.Location = New System.Drawing.Point(317, 246)
        Me.btnCancelEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(126, 60)
        Me.btnCancelEdit.TabIndex = 39
        Me.btnCancelEdit.Text = "Cancelar Edicion"
        Me.btnCancelEdit.UseVisualStyleBackColor = True
        Me.btnCancelEdit.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Cantidad:"
        '
        'txt_precioUnidad
        '
        Me.txt_precioUnidad.Location = New System.Drawing.Point(336, 111)
        Me.txt_precioUnidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_precioUnidad.Name = "txt_precioUnidad"
        Me.txt_precioUnidad.ReadOnly = True
        Me.txt_precioUnidad.Size = New System.Drawing.Size(109, 26)
        Me.txt_precioUnidad.TabIndex = 22
        Me.txt_precioUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(91, 159)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(113, 26)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.Text = "0"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(184, 246)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(126, 60)
        Me.btnEdit.TabIndex = 38
        Me.btnEdit.Text = "Aplicar cambios"
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'txt_nombreProd
        '
        Me.txt_nombreProd.Location = New System.Drawing.Point(92, 69)
        Me.txt_nombreProd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nombreProd.Name = "txt_nombreProd"
        Me.txt_nombreProd.ReadOnly = True
        Me.txt_nombreProd.Size = New System.Drawing.Size(282, 26)
        Me.txt_nombreProd.TabIndex = 27
        '
        'panelDetallesCompra
        '
        Me.panelDetallesCompra.Controls.Add(Me.Button2)
        Me.panelDetallesCompra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelDetallesCompra.Enabled = False
        Me.panelDetallesCompra.Location = New System.Drawing.Point(0, 668)
        Me.panelDetallesCompra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelDetallesCompra.Name = "panelDetallesCompra"
        Me.panelDetallesCompra.Size = New System.Drawing.Size(452, 89)
        Me.panelDetallesCompra.TabIndex = 43
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 14)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(440, 62)
        Me.Button2.TabIndex = 42
        Me.Button2.TabStop = False
        Me.Button2.Text = "Cancelar Pedido"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.btn_pedido)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.cmb_Prove)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.labelee)
        Me.Panel6.Controls.Add(Me.txt_id)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(452, 179)
        Me.Panel6.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha: "
        '
        'btn_pedido
        '
        Me.btn_pedido.Location = New System.Drawing.Point(11, 118)
        Me.btn_pedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_pedido.Name = "btn_pedido"
        Me.btn_pedido.Size = New System.Drawing.Size(432, 42)
        Me.btn_pedido.TabIndex = 0
        Me.btn_pedido.Text = "Nuevo Pedido"
        Me.btn_pedido.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione un proveedor para solicitar productos: "
        '
        'cmb_Prove
        '
        Me.cmb_Prove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Prove.FormattingEnabled = True
        Me.cmb_Prove.Location = New System.Drawing.Point(11, 80)
        Me.cmb_Prove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_Prove.Name = "cmb_Prove"
        Me.cmb_Prove.Size = New System.Drawing.Size(432, 28)
        Me.cmb_Prove.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 4
        '
        'labelee
        '
        Me.labelee.Location = New System.Drawing.Point(11, 19)
        Me.labelee.Name = "labelee"
        Me.labelee.Size = New System.Drawing.Size(150, 21)
        Me.labelee.TabIndex = 35
        Me.labelee.Text = "Codigo de Compra:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(168, 15)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(64, 26)
        Me.txt_id.TabIndex = 36
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pedidos
        '
        Me.pedidos.Controls.Add(Me.dataEstadoPedido)
        Me.pedidos.Controls.Add(Me.Panel5)
        Me.pedidos.Location = New System.Drawing.Point(4, 29)
        Me.pedidos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pedidos.Name = "pedidos"
        Me.pedidos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pedidos.Size = New System.Drawing.Size(1477, 765)
        Me.pedidos.TabIndex = 1
        Me.pedidos.Text = "Listado de Pedidos"
        Me.pedidos.UseVisualStyleBackColor = True
        '
        'dataEstadoPedido
        '
        Me.dataEstadoPedido.AllowUserToAddRows = False
        Me.dataEstadoPedido.AllowUserToDeleteRows = False
        Me.dataEstadoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataEstadoPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataEstadoPedido.Location = New System.Drawing.Point(3, 4)
        Me.dataEstadoPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dataEstadoPedido.Name = "dataEstadoPedido"
        Me.dataEstadoPedido.ReadOnly = True
        Me.dataEstadoPedido.RowHeadersWidth = 62
        Me.dataEstadoPedido.RowTemplate.Height = 24
        Me.dataEstadoPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataEstadoPedido.Size = New System.Drawing.Size(1307, 757)
        Me.dataEstadoPedido.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_Confirmar)
        Me.Panel5.Controls.Add(Me.btn_Cancelar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1310, 4)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(164, 757)
        Me.Panel5.TabIndex = 3
        '
        'btn_Confirmar
        '
        Me.btn_Confirmar.Location = New System.Drawing.Point(10, 155)
        Me.btn_Confirmar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Confirmar.Name = "btn_Confirmar"
        Me.btn_Confirmar.Size = New System.Drawing.Size(148, 120)
        Me.btn_Confirmar.TabIndex = 1
        Me.btn_Confirmar.Text = "Confirmar Pedido"
        Me.btn_Confirmar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(10, 440)
        Me.btn_Cancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(148, 119)
        Me.btn_Cancelar.TabIndex = 2
        Me.btn_Cancelar.Text = "Cancelar Pedido"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'historial
        '
        Me.historial.Controls.Add(Me.dataCompraHistorial)
        Me.historial.Location = New System.Drawing.Point(4, 29)
        Me.historial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.historial.Name = "historial"
        Me.historial.Size = New System.Drawing.Size(1477, 765)
        Me.historial.TabIndex = 2
        Me.historial.Text = "Historial de Compras"
        Me.historial.UseVisualStyleBackColor = True
        '
        'dataCompraHistorial
        '
        Me.dataCompraHistorial.AllowUserToAddRows = False
        Me.dataCompraHistorial.AllowUserToDeleteRows = False
        Me.dataCompraHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataCompraHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataCompraHistorial.Location = New System.Drawing.Point(0, 0)
        Me.dataCompraHistorial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dataCompraHistorial.Name = "dataCompraHistorial"
        Me.dataCompraHistorial.ReadOnly = True
        Me.dataCompraHistorial.RowHeadersWidth = 62
        Me.dataCompraHistorial.RowTemplate.Height = 24
        Me.dataCompraHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataCompraHistorial.Size = New System.Drawing.Size(1477, 765)
        Me.dataCompraHistorial.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1485, 798)
        Me.Panel1.TabIndex = 1
        '
        'Form_Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1485, 798)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form_Compras"
        Me.Text = "Form_Compras"
        Me.TabControl1.ResumeLayout(False)
        Me.comprar.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dataCompraRecien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelConfirmar.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.PanelDetalles.ResumeLayout(False)
        Me.PanelDetalles.PerformLayout()
        CType(Me.pb_Prodimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDetallesCompra.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.pedidos.ResumeLayout(False)
        CType(Me.dataEstadoPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.historial.ResumeLayout(False)
        CType(Me.dataCompraHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmCompraUP As Timer
    Friend WithEvents tmCompraDOWN As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents comprar As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmb_Prove As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_pedido As Button
    Friend WithEvents pedidos As TabPage
    Friend WithEvents historial As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_AddLista As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_preciototal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents buscarProd_btn As Button
    Friend WithEvents Label5 As Label
    Public WithEvents txt_nombreProd As TextBox
    Public WithEvents txt_precioUnidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Public WithEvents txt_prodId As TextBox
    Friend WithEvents pb_Prodimg As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents labelee As Label
    Public WithEvents txt_id As TextBox
    Friend WithEvents btn_EvniarCompra As Button
    Public WithEvents txtCantidad As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dataCompraHistorial As DataGridView
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Confirmar As Button
    Friend WithEvents dataCompraRecien As DataGridView
    Friend WithEvents panelConfirmar As Panel
    Friend WithEvents dataEstadoPedido As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancelEdit As Button
    Public WithEvents CodigoDetalle As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CompraID As DataGridViewTextBoxColumn
    Friend WithEvents ProductoID As DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotal As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidad As DataGridViewTextBoxColumn
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents panelDetallesCompra As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PanelDetalles As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents eliminar As Button
End Class
