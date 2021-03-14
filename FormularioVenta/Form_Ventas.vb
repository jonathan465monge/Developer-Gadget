Imports System.Data.SqlClient

Public Class Form_Ventas

    Private dt As New DataTable
    Public _frmProd As Form_Producto
    Public _frmVuelto As Form_Vuelto

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmVuelto As Form_Vuelto)
        Me.New()
        _frmVuelto = frmVuelto
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcion As New FVenta

        Label6.Text = DateTime.Now.ToString("dd/MM/yyyy")

        If (funcion.insertarVenta) Then
            panel_detalleVenta.Visible = True

            Dim id As String = funcion.Idventa().ToString
            txt_ventaId.Text = id

        Else
            panel_detalleVenta.Visible = False
        End If
    End Sub

    Sub alternarColoDatGV(ByVal dgv As DataGridView)
        If dataFact.Rows.Count <> 0 Then
            With dgv
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .RowsDefaultCellStyle.SelectionBackColor = Color.DarkRed
                .RowsDefaultCellStyle.SelectionForeColor = Color.White
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Visible = False
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(4).Width = 100
                .Columns(5).Width = 75
                .Columns(6).Width = 100
            End With
        End If
    End Sub

    Private Sub SoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = (".") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Introduzca solo valores numéricos")
        End If
    End Sub

    Public Sub limpiarVenta()
        txt_nombreProd.Text = ""
        txt_prodId.Text = ""
        txt_preciototal.Text = ""
        txt_precioUnidad.Text = ""
        txtCantidad.Text = 0
    End Sub

    Public Sub ventaRecien()
        Try
            Dim funcion As New FDetalleVenta
            Dim idventa As New DetalleVenta
            idventa.VentaId = txt_ventaId.Text
            dt = funcion.mostrarVentaRecien(idventa)
            dataFact.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ventadetalle_btn_Click(sender As Object, e As EventArgs) Handles ventadetalle_btn.Click
        If dataFact.Rows.Count <> 0 Then
            Combox.vuelto = txtTotalVenta.Text
            Form_Vuelto.Show()
        Else
            MessageBox.Show("No hay ningun producto en la lista de venta", "Ingrese registros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub buscarProd_btn_Click(sender As Object, e As EventArgs) Handles buscarProd_btn.Click
        Combox.lblVenta = "venta"
        AddOwnedForm(Form_Inventario)
        Form_Inventario.ShowDialog()
    End Sub

    Private Sub ventaNew_btn_Click(sender As Object, e As EventArgs) Handles ventaNew_btn.Click
        Dim funcion As New FVenta

        Label6.Text = DateTime.Now.ToString("dd/MM/yyyy")

        If (funcion.insertarVenta) Then
            Dim id As String = funcion.Idventa().ToString
            txt_ventaId.Text = id
        End If
        limpiarVenta()
    End Sub

    Private Sub agregarListado_btn_Click(sender As Object, e As EventArgs) Handles agregarListado_btn.Click
        If Me.ValidateChildren = True And txt_nombreProd.Text <> "" And txtCantidad.Text <> "" And txt_precioUnidad.Text <> "" Then
            If txtCantidad.Text > 0 Then
                Try
                    Dim dts As New DetalleVenta
                    Dim funcion As New FDetalleVenta

                    dts.Cantidad = txtCantidad.Text
                    dts.Precio = txt_preciototal.Text
                    dts.ProductoId = txt_prodId.Text
                    dts.VentaId = txt_ventaId.Text

                    If funcion.insertarDetalleVenta(dts) Then
                        limpiarVenta()
                        ventaRecien()
                    Else
                        MessageBox.Show("Ocurrio un problema al añadir el producto a la orden...", "Intente de Nuevo :/", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Dbe agregar la cantidad del producto a vender", "ingrese una cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
                MsgBox("Asegurese de rellenar todos los campos necesarios")
            End If
            Dim _frmProd As New Form_Producto(Me)
            _frmProd.mostrar()
            alternarColoDatGV(dataFact)
    End Sub

    Private Sub eliminardeLista_btn_Click(sender As Object, e As EventArgs) Handles eliminardeLista_btn.Click
        For Each r As DataGridViewRow In dataFact.SelectedRows
            Dim oneKey As Integer = Convert.ToInt32(r.Cells("DetalleVentaId").Value)
            Dim delt As New DetalleVenta
            Dim funcion As New FDetalleVenta
            delt.DetalleVentaId = oneKey
            dataFact.Rows.Remove(r)

            funcion.eliminarRegistroDetalle(delt)
        Next
    End Sub

    Private Sub txtCostoT_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If txt_precioUnidad.Text <> "" And txtCantidad.Text <> "" Then
            txt_preciototal.Text = CDec(txt_precioUnidad.Text) * CDec(txtCantidad.Text)
            If txt_preciototal.Text <> "" Then
                txtTotalVenta.Text = CDec(txtTotalVenta.Text) + CDec(txt_preciototal.Text)
            End If
        End If
    End Sub

    Private Sub dataFact_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataFact.CellClick
        Dim ventaDetalleId = dataFact.SelectedCells.Item(0).Value
        Dim id = dataFact.SelectedCells.Item(2).Value
        Dim cantidad = dataFact.SelectedCells.Item(5).Value
        Dim Unidad = dataFact.SelectedCells.Item(4).Value
        Dim Total = dataFact.SelectedCells.Item(6).Value
        Dim nombre = dataFact.SelectedCells.Item(3).Value

        txtCantidad.Text = cantidad
        txt_nombreProd.Text = nombre
        txt_precioUnidad.Text = Unidad
        txt_preciototal.Text = Total
        txt_prodId.Text = id
        CodigoDetalleVenta.Text = ventaDetalleId
        btnAplicar.Visible = True
        btnCancelar.Visible = True
        txt_nombreProd.ReadOnly = True
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("Editando la cantidad de la venta...", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then
            If Me.ValidateChildren = True And txtCantidad.Text > 0 Then
                Try
                    Dim dts As New DetalleVenta
                    Dim func As New FDetalleVenta

                    dts.DetalleVentaId = CodigoDetalleVenta.Text
                    dts.Cantidad = txtCantidad.Text
                    dts.Precio = txt_preciototal.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Cantidad modificada correctamente", "Guardando pedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        limpiarVenta()
                        txt_nombreProd.ReadOnly = False
                        ventaRecien()
                        btnAplicar.Visible = False
                        btnCancelar.Visible = False
                    Else
                        MessageBox.Show("La cantidad no pudo ser modificada...", "intente de nuevo...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("La cantidad debe ser diferente de cero", "Ingrese la cantidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            ventaRecien()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("¿Cancelar la modificacion del pedido?", "Cancelando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then
            limpiarVenta()
            txt_nombreProd.ReadOnly = False
            ventaRecien()
            btnAplicar.Visible = False
            btnCancelar.Visible = False
        End If
    End Sub
End Class