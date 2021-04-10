Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Frm_Venta

    Private Sub ventadetalle_btn_Click(sender As Object, e As EventArgs) Handles ventadetalle_btn.Click
        If dataFact.Rows.Count <> 0 Then
            txtPagoCliente.Enabled = True
            txtCambio.Enabled = True
            btnConfirmarVenta.Enabled = True
        Else
            MessageBox.Show("No hay productos en la lista de Venta", "Ingrese productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub limpiarVenta()
        txt_nombreProd.Text = ""
        txt_prodId.Text = ""
        txt_preciototal.Text = ""
        txt_precioUnidad.Text = ""
        txtCantidad.Text = 0
        txtDescripcion.Text = ""
        txtestado.Text = ""
        txtStock.Text = ""
        txtPagoCliente.Text = 0
        txtCambio.Text = ""
        txtPagoCliente.Enabled = False
        txtCambio.Enabled = False
        btnConfirmarVenta.Enabled = False
    End Sub

    Public Sub limpiaVent()
        txt_nombreProd.Text = ""
        txt_prodId.Text = ""
        txt_preciototal.Text = ""
        txt_precioUnidad.Text = ""
        txtCantidad.Text = 0
        txtDescripcion.Text = ""
        txtestado.Text = ""
        txtStock.Text = ""
    End Sub

    Private Sub SoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPagoCliente.KeyPress, txtCantidad.KeyPress
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnConfirmarVenta.Click
        Dim dts As New DetalleVenta
        Dim funcion As New FDetalleVenta

        For Each fila As DataGridViewRow In dataFact.Rows
            Try
                dts.Cantidad = fila.Cells(5).Value()
                dts.Precio = fila.Cells(6).Value()
                dts.ProductoId = fila.Cells(1).Value()
                dts.VentaId = fila.Cells(0).Value()

                funcion.insertarDetalleVenta(dts)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
        limpiaVent()
        If MessageBox.Show("Venta realizada", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            Dim resul As DialogResult
            resul = MessageBox.Show("¿Imprimir factura?", "Imprimiendo documento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If resul = DialogResult.OK Then

                'Combox.idVenta = txt_ventaId.Text
                'Combox.totalVenta = txtTotalVenta.Text
                'Combox.cambio = txtCambio.Text
                'Combox.pago = txtPagoCliente.Text
                'Combox.fechaVenta = Label6.Text
                'Combox.permiso = "0"
                Frm_Boleta.IdVenta = txt_ventaId.Text
                Frm_Boleta.ShowDialog()

            End If
        End If
        labelVenta.Text = "1"
    End Sub

    Private Sub txtPagoCliente_TextChanged(sender As Object, e As EventArgs) Handles txtPagoCliente.TextChanged
        If txtPagoCliente.Text <> "" And txtTotalVenta.Text <> "" Then
            Dim pagoCliente As Double = txtPagoCliente.Text
            Format(pagoCliente, "##0.00")

            If pagoCliente >= txtTotalVenta.Text Then
                txtCambio.Text = CDec(txtPagoCliente.Text) - CDec(txtTotalVenta.Text)
                btnConfirmarVenta.Enabled = True
            Else
                txtCambio.Text = "Dinero insuficiente para pagar."
                btnConfirmarVenta.Enabled = False
            End If
        End If
    End Sub

    Private Sub buscarProd_btn_Click(sender As Object, e As EventArgs) Handles buscarProd_btn.Click
        If txt_ventaId.Text <> "" Then
            Combox.lblVenta = "venta"
            AddOwnedForm(Form_Inventario)
            Form_Inventario.ShowDialog()
        Else
            MessageBox.Show("Para iniciar una venta, presione el boton 'Nueva Venta'", "Nueva Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If txtCantidad.Text <> "" And txtStock.Text <> "" Then
            If Val(txtCantidad.Text) <= Val(txtStock.Text) Then
                If txt_precioUnidad.Text <> "" And txtCantidad.Text <> "" Then
                    txt_preciototal.Text = CDec(txt_precioUnidad.Text) * CDec(txtCantidad.Text)
                End If
            Else
                MessageBox.Show("Existencias insuficientes para realizar la venta", "Existencias insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub agregarListado_btn_Click(sender As Object, e As EventArgs) Handles agregarListado_btn.Click
        If labelVenta.Text = "0" Then
            If txt_ventaId.Text <> "" Then
                If txtCantidad.Text > 0 Then
                    If dataFact.Rows.Count <= 10 Then
                        dataFact.Rows.Add(txt_ventaId.Text, txt_prodId.Text, txt_nombreProd.Text, txtStock.Text, txt_precioUnidad.Text, txtCantidad.Text, txt_preciototal.Text)
                        alternarColoDatGV(dataFact)
                        Me.dataFact.ClearSelection()
                        Me.dataFact.CurrentCell = Me.dataFact.Rows(Me.dataFact.RowCount - 1).Cells(2)
                        Me.dataFact.Refresh()
                    Else
                        MessageBox.Show("El maximo de productos por boleta es de 10 elementos" & vbCrLf & "Imprima la factura de esta venta y luego añade otra", "Maximo excedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    End If
                Else
                    MessageBox.Show("Debe agregar la cantidad del producto a vender", "Ingrese una cantidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Para iniciar una venta, presione el boton 'Nueva Venta'", "Nueva Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            limpiarVenta()
        Else
            MessageBox.Show("Esta venta ya se realizo, presione el boton Nueva venta'", "Nueva Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ventaNew_btn_Click(sender As Object, e As EventArgs) Handles ventaNew_btn.Click
        If dataFact.Rows.Count <> 0 Then
            Dim resul As DialogResult
            resul = MessageBox.Show("¿Realizar nueva venta?" & vbCrLf & "Si confirma, se borrarra la venta que esta realizando actualmente", "Nueva venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If resul = DialogResult.OK Then
                Dim funcion2 As New FVenta

                txtTotalVenta.Text = 0
                Label6.Text = DateTime.Now.ToString("dd/MM/yyyy")
                If (funcion2.insertarVenta) Then
                    Dim id As String = funcion2.Idventa().ToString
                    txt_ventaId.Text = id
                End If
                limpiarVenta()
                dataFact.Rows.Clear()
            End If
        Else
            Dim funcion As New FVenta
            labelVenta.Text = "0"
            txtTotalVenta.Text = 0
            Label6.Text = DateTime.Now.ToString("dd/MM/yyyy")
            If (funcion.insertarVenta) Then
                Dim id As String = funcion.Idventa().ToString
                txt_ventaId.Text = id
            End If
            limpiarVenta()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("¿Cancelar la venta?", "Cancelando venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then
            txtTotalVenta.Text = 0
            limpiarVenta()
            dataFact.Rows.Clear()
        End If
    End Sub

    Private Sub Frm_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = DateTime.Now.ToString("dd/MM/yyyy")
        alternarColoDatGV(dataFact)
    End Sub

    Sub alternarColoDatGV(ByVal dgv As DataGridView)
        With dgv
            .RowHeadersVisible = False
            .RowsDefaultCellStyle.BackColor = Color.LightBlue
            .RowsDefaultCellStyle.SelectionBackColor = Color.DarkRed
            .RowsDefaultCellStyle.SelectionForeColor = Color.White
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).Visible = False
            .Columns(4).Width = 100
            .Columns(5).Width = 100
            .Columns(6).Width = 100
        End With
    End Sub

    Private Sub eliminardeLista_btn_Click(sender As Object, e As EventArgs) Handles eliminardeLista_btn.Click
        If dataFact.Rows.Count <> 0 Then
            For Each r As DataGridViewRow In dataFact.SelectedRows
                dataFact.Rows.Remove(r)
            Next
        Else
            MsgBox("No hay productos seleccionados para eliminar")
        End If
    End Sub
    Private Sub dataFact_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataFact.CellClick
        If dataFact.Rows.Count <> 0 Then
            Dim id = dataFact.SelectedCells.Item(1).Value
            Dim cantidad = dataFact.SelectedCells.Item(4).Value
            Dim Unidad = dataFact.SelectedCells.Item(3).Value
            Dim Total = dataFact.SelectedCells.Item(5).Value
            Dim nombre = dataFact.SelectedCells.Item(2).Value
            Dim stock = dataFact.SelectedCells.Item(3).Value

            txtStock.Text = stock
            txtCantidad.Text = cantidad
            txt_nombreProd.Text = nombre
            txt_precioUnidad.Text = Unidad
            txt_preciototal.Text = Total
            txt_prodId.Text = id
            btnAplicar.Visible = True
            btnCancelar.Visible = True
            txt_nombreProd.ReadOnly = True
        End If
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Dim row As DataGridViewRow = dataFact.CurrentRow
        row.Cells(5).Value = txtCantidad.Text
        row.Cells(6).Value = txt_preciototal.Text
        Me.dataFact.ClearSelection()
        Me.dataFact.CurrentCell = Me.dataFact.Rows(Me.dataFact.RowCount - 1).Cells(5)
        limpiarVenta()
        btnAplicar.Visible = False
        btnCancelar.Visible = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnAplicar.Visible = False
        btnCancelar.Visible = False
        limpiarVenta()
    End Sub

    Sub TotalVenta()
        Dim total As Decimal = 0
        For Each fila As DataGridViewRow In dataFact.Rows
            If fila.Cells(6).Value Is Nothing Then
                Exit Sub
            Else
                total += CDec(fila.Cells(6).Value)
            End If
        Next
        txtTotalVenta.Text = total
    End Sub

    Private Sub dataFact_CurrentCellChanged(sender As Object, e As EventArgs) Handles dataFact.CurrentCellChanged
        TotalVenta()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_ventaId_TextChanged(sender As Object, e As EventArgs) Handles txt_ventaId.TextChanged

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    If txt_ventaId.Text <> "" Then

    '        Combox.idVenta = txt_ventaId.Text
    '        Combox.totalVenta = txtTotalVenta.Text
    '        Frm_Boleta.ShowDialog()
    '    Else
    '        MessageBox.Show("Para crear la factura de una venta debe registrarla antes, presione el boton 'Nueva Venta'", "Nueva Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub
End Class