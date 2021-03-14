Imports System.IO

Public Class Form_Producto

    Dim dt As New DataTable
    Public _formVenta As Form_Ventas
    Public _formAdmProd As Form_AdmProductos
    Public _formMulti As Form_Multi
    Public _formVuelto As Form_Vuelto

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmVenta As Form_Ventas)
        Me.New()
        _formVenta = frmVenta
    End Sub

    Public Sub New(frmAdmProd As Form_AdmProductos)
        Me.New()
        _formAdmProd = frmAdmProd
    End Sub
    Public Sub New(frmMulti As Form_Multi)
        Me.New()
        _formMulti = frmMulti
    End Sub

    Public Sub New(frmVuelto As Form_Vuelto)
        Me.New()
        _formVuelto = frmVuelto
    End Sub

    Private Sub Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbocampo.SelectedItem = vbNullString
        mostrar()
        labelFlag.Text = Combox.labelFlag
        labelFlag2.Text = Combox.labelFlag2
        If labelFlag.Text = "Inventario" Then
            Me.panelBajoProd.Visible = False
            Me.btn_Activar.Visible = False
            Me.btn_desact.Visible = False
        End If
        If labelFlag2.Text = "1" Then
            Me.cbocampo.Text = "Proveedor"
            txtbuscar.ReadOnly = True
            txtbuscar.Text = Combox.proveProdComp
            mostrar()
        End If
        'If labelFlag2.Text = "2" Then
        '    Me.panelBajoProd.Visible = False
        '    Me.btn_Activar.Visible = False
        '    Me.btn_desact.Visible = False
        '    Me.cbocampo.Text = "Proveedor"
        '    txtbuscar.ReadOnly = True
        '    txtbuscar.Text = Combox.ProvCompra
        'End If

        Dim funcion As New FCategoria
        Dim func As New FProveedor

        alternarColoDatGV(dataproductos)
    End Sub

    Private Sub SoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = (".") Or e.KeyChar = (",") Then
            If e.KeyChar = (".") Then e.KeyChar = (",")
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Introduzca solo valores numéricos")
        End If
    End Sub

    Public Sub mostrar()
        Try
            Dim funcion As New FProducto
            dt = funcion.mostrar
            dataproductos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        btnnuevo.Visible = True
        btneditar.Visible = True
        buscar()
    End Sub

    Private Sub dataproductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataproductos.CellDoubleClick
        If labelFlag2.Text = "1" Then
            Combox.labelFlag2 = "0"
            labelFlag2.Text = "0"
            Dim frmCompra As Form_Compras = TryCast(Owner, Form_Compras)
            Dim Id = dataproductos.SelectedCells.Item(0).Value
            Dim Nombre = dataproductos.SelectedCells.Item(3).Value
            Dim Precio = dataproductos.SelectedCells.Item(5).Value
            Dim IMG = dataproductos.SelectedCells.Item(10).FormattedValue

            frmCompra.txt_prodId.Text = Id
            frmCompra.txt_nombreProd.Text = Nombre
            frmCompra.txt_precioUnidad.Text = Precio
            frmCompra.pb_Prodimg.Image = IMG
            Me.Close()
        End If
    End Sub


    Private Sub buscar()
        If cbocampo.Text <> "" Then
            Try
                Dim ds As New DataSet
                ds.Tables.Add(dt.Copy)
                Dim dv As New DataView(ds.Tables(0))
                dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

                If dv.Count <> 0 Then
                    inexistente.Visible = False
                    dataproductos.DataSource = dv
                Else
                    inexistente.Visible = True
                    dataproductos.DataSource = Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Call alternarColoDatGV(dataproductos)
        End If
    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Dim Nuevoprod As New Form_AdmProductos(Me)
        With Nuevoprod
            .btn_Aplicar.Text = "Agregar"
            .limpiar()
            .ShowDialog()
        End With
        alternarColoDatGV(dataproductos)
    End Sub

    Sub alternarColoDatGV(ByVal dgv As DataGridView)
        If dgv.Rows.Count <> 0 Then
            With dgv
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .RowsDefaultCellStyle.SelectionBackColor = Color.DarkRed
                .RowsDefaultCellStyle.SelectionForeColor = Color.White
                .Columns(0).Width = 25
                .Columns(1).Width = 50
                .Columns(2).Width = 60
                .Columns(3).Width = 200
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(5).Width = 75
                .Columns(6).Width = 75
                .Columns(7).Width = 75
                .Columns(8).Width = 125
                .Columns(9).Width = 125
                .Columns(10).Visible = False
            End With
        End If
    End Sub

    Private Sub dataproductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataproductos.CellClick
        If dataproductos.Rows.Count <> 0 Then
            txtEstad.Text = dataproductos.SelectedCells.Item(1).Value
            If txtEstad.Text = "Activo" Then
                btn_Activar.Visible = False
                btn_desact.Visible = True
            Else
                btn_Activar.Visible = True
                btn_desact.Visible = False
            End If
            btneditar.Visible = True
        End If
    End Sub

    Public Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        If txtEstad.Text <> "" Then
            Dim AdmProd As New Form_AdmProductos
            Dim ID = dataproductos.SelectedCells.Item(0).Value
            Dim nombre = dataproductos.SelectedCells.Item(3).Value
            Dim descripcion = dataproductos.SelectedCells.Item(4).Value
            Dim precioCompra = dataproductos.SelectedCells.Item(5).Value
            Dim margen = dataproductos.SelectedCells.Item(7).Value
            Dim precioVenta = dataproductos.SelectedCells.Item(6).Value
            Dim stock = dataproductos.SelectedCells.Item(2).Value
            Dim imagen = dataproductos.SelectedCells.Item(10).FormattedValue
            Dim estado = dataproductos.SelectedCells.Item(1).Value
            Dim categoria = dataproductos.SelectedCells.Item(8).Value
            Dim proveedor = dataproductos.SelectedCells.Item(9).Value
            Combox.categoria = dataproductos.SelectedCells.Item(8).Value
            Combox.proveedor = dataproductos.SelectedCells.Item(9).Value

            Form_AdmProductos.Categ_cmb.Text = categoria
            Form_AdmProductos.prov_cmb.Text = proveedor
            With AdmProd
                .txtproductoid.Text = ID
                .txtnombre.Text = nombre
                .txtdescripcion.Text = descripcion
                .txtprecioCompra.Text = precioCompra
                .txtmargen.Text = margen
                .txtPrecioVenta.Text = precioVenta
                .txtstock.Text = stock
                .ProdImagen.Image = imagen
                .txt_Estado.Text = estado
                .btn_Aplicar.Text = "Aplicar cambios"
                .ShowDialog()
            End With
        Else
            If dataproductos.Rows.Count <> 0 Then
                MessageBox.Show("Debe seleccionar un producto para poder editarlo.", "Seleccione un producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se encuentra ningun producto en la lista, puede agregar un nuevo registro presionando el boton 'Nuevo'", "Agregue registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        alternarColoDatGV(dataproductos)
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btn_Activar.Click
        For Each r As DataGridViewRow In dataproductos.SelectedRows
            Dim oneKey As Integer = Convert.ToInt32(r.Cells("ID").Value)
            Dim delt As New Producto
            Dim funcion As New FProducto
            delt.ProductoId = oneKey
            dataproductos.Rows.Remove(r)

            funcion.activar(delt)
        Next
        Call mostrar()
        Call alternarColoDatGV(dataproductos)
    End Sub

    Private Sub btn_desact_Click(sender As Object, e As EventArgs) Handles btn_desact.Click
        For Each r As DataGridViewRow In dataproductos.SelectedRows
            Dim oneKey As Integer = Convert.ToInt32(r.Cells("ID").Value)
            Dim delt As New Producto
            Dim funcion As New FProducto
            delt.ProductoId = oneKey
            dataproductos.Rows.Remove(r)

            funcion.desactivar(delt)
        Next
        Call mostrar()
        Call alternarColoDatGV(dataproductos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mostrar()
        alternarColoDatGV(dataproductos)
    End Sub

    Private Sub Dataproductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataproductos.CellContentClick

    End Sub
End Class