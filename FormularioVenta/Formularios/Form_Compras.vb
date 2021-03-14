Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Form_Compras

    Dim dt As New DataTable
    Private Sub Form_Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcion As New FProveedor
        Dim dts As New Proveedor
        Label3.Text = DateTime.Now.ToString("dd/MM/yyyy")
        compraRecien()
        cmb_Prove.DataSource = funcion.mostrar
        cmb_Prove.DisplayMember = "Nombre"
        cmb_Prove.ValueMember = "ID"
        cmb_Prove.SelectedItem = vbNullString

        mostrarHistorial()
        mostrarOrdenCompras()
    End Sub

    Public Sub Limpiar()
        txtCantidad.Text = ""
        txt_prodId.Text = ""
        txt_nombreProd.Text = ""
        txt_preciototal.Text = ""
        txt_precioUnidad.Text = ""
        pb_Prodimg.Image = Nothing
    End Sub

    Sub alternarColoDatGV(ByVal dgv As DataGridView)
        With dgv
            .RowHeadersVisible = False
            .RowsDefaultCellStyle.BackColor = Color.LightBlue
            .RowsDefaultCellStyle.SelectionBackColor = Color.DarkRed
            .RowsDefaultCellStyle.SelectionForeColor = Color.White
            .Columns(0).Width = 50
            .Columns(1).Width = 85
            .Columns(2).Width = 150
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
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

    Public Sub limpiarCompra()
        txt_nombreProd.Text = ""
        txt_prodId.Text = ""
        txt_preciototal.Text = ""
        txt_precioUnidad.Text = ""
        txtCantidad.Text = 0
        pb_Prodimg.Image = Nothing
    End Sub

    Private Sub compraRecien()
        Try
            Dim dtv = dataCompraRecien
            With dtv
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .RowsDefaultCellStyle.SelectionBackColor = Color.DarkRed
                .RowsDefaultCellStyle.SelectionForeColor = Color.White
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(3).Width = 90
                .Columns(4).Width = 90
                .Columns(5).Width = 90
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostrarHistorial()
        Try
            Dim funcionDC As New FDetalleOrdenCompra
            dt = funcionDC.mostrarCompraHistorial()
            dataCompraHistorial.DataSource = dt
            alternarColoDatGV(dataCompraHistorial)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostrarOrdenCompras()
        Try
            Dim funcionOC As New Forden_compra
            dt = funcionOC.mostrarEstado1()
            dataEstadoPedido.DataSource = dt
            Dim dgvs = dataEstadoPedido
            With dgvs
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .RowsDefaultCellStyle.SelectionBackColor = Color.DarkRed
                .RowsDefaultCellStyle.SelectionForeColor = Color.White
                .Columns(0).Width = 50
                .Columns(1).Width = 85
                .Columns(2).Width = 100
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscarProd_btn_Click(sender As Object, e As EventArgs) Handles buscarProd_btn.Click
        btnEdit.Visible = False
        btnCancelEdit.Visible = False

        Combox.labelFlag2 = "1"
        Combox.proveProdComp = cmb_Prove.Text
        AddOwnedForm(Form_Producto)
        Form_Producto.ShowDialog()
    End Sub

    Private Sub btn_pedido_Click(sender As Object, e As EventArgs) Handles btn_pedido.Click
        Dim funcion As New Forden_compra
        Dim dts As New orden_compra
        Dim func As New FProveedor
        Dim dtss As New Proveedor
        dtss.ProveedorId = cmb_Prove.SelectedValue
        dts.ProveedorId = cmb_Prove.SelectedValue
        Dim Correo = func.Correo(dtss)
        If cmb_Prove.Text <> "" Then
            If (funcion.HacerPedido(dts)) Then
                Dim id As String = funcion.IdCompra()
                Me.txt_id.Text = id
            End If
            Combox.ProvCompra = Correo
            mostrarOrdenCompras()
            mostrarHistorial()
            cmb_Prove.Enabled = False
            panelDetallesCompra.Enabled = True
            PanelDetalles.Enabled = True
            panelConfirmar.Enabled = True
        Else
            MsgBox("Seleccione un proveedor para su pedido")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_AddLista.Click
        If txt_id.Text <> "" Then
            If txtCantidad.Text <> "" Then
                If txtCantidad.Text > 0 Then
                    dataCompraRecien.Rows.Add(txt_id.Text, txt_prodId.Text, txt_nombreProd.Text, txtCantidad.Text, txt_preciototal.Text, txt_precioUnidad.Text)
                    compraRecien()
                    Me.dataCompraRecien.ClearSelection()
                    Me.dataCompraRecien.CurrentCell = Me.dataCompraRecien.Rows(Me.dataCompraRecien.RowCount - 1).Cells(3)
                    Me.dataCompraRecien.Refresh()
                    limpiarCompra()
                Else
                    MessageBox.Show("Debe agregar la cantidad del producto a comprar", "Ingrese una cantidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Debe agregar la cantidad del producto a comprar", "Ingrese una cantidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Para iniciar una compra, seleccione un proveedor y presione el boton 'Nueva Pedido'", "Nuevo Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_EvniarCompra.Click
        Dim frmComp As Form_EnviarCorreo = TryCast(Owner, Form_EnviarCorreo)

        Form_EnviarCorreo.Show()
        limpiarCompra()
    End Sub

    Private Sub txtCostoT_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If txt_precioUnidad.Text <> "" And txtCantidad.Text <> "" Then
            txt_preciototal.Text = CDec(txt_precioUnidad.Text) * CDec(txtCantidad.Text)
        End If
    End Sub

    Public Function getColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub ExportarPdf(ByVal document As Document)
        Dim datatable As New PdfPTable(dataCompraRecien.ColumnCount)
        datatable.DefaultCell.Padding = 3
        Dim headerswidths As Single() = getColumnasSize(dataCompraRecien)
        datatable.SetWidths(headerswidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        Dim Encabezado As New Paragraph("Pedido de Productos", New Font(Font.Name = "Arial", 20, Font.Bold))
        Dim texto As New Phrase("Pedido de Productos realizado de fecha" & Now.Date(), New Font(Font.Name = "Arial", 14, Font.Bold))

        For i As Integer = 0 To dataCompraRecien.ColumnCount - 1
            datatable.AddCell(dataCompraRecien.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To dataCompraRecien.RowCount - 1
            For j As Integer = 0 To dataCompraRecien.ColumnCount - 1
                datatable.AddCell(dataCompraRecien(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        document.Add(Encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If dataCompraRecien.Rows.Count <> Nothing Then
            Dim SaveFileDialog As New SaveFileDialog
            Dim ruta As String
            With SaveFileDialog
                .Title = "Guardar"
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
                .FileName = "Archivo"
                .Filter = "Archivos pdf (*.pdf)|*.pdf"
                .OverwritePrompt = True
                .CheckPathExists = True
            End With
            If SaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                ruta = SaveFileDialog.FileName
            Else
                ruta = String.Empty
            End If
            Try
                Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
                PdfWriter.GetInstance(doc, New System.IO.FileStream(ruta, System.IO.FileMode.Create))

                doc.Open()
                ExportarPdf(doc)
                doc.Close()

                Dim dts As New Detalle_Orden_compra
                Dim funcion As New FDetalleOrdenCompra

                For Each fila As DataGridViewRow In dataCompraRecien.Rows
                    Try
                        dts.Cantidad = fila.Cells(3).Value
                        dts.Precio = fila.Cells(4).Value
                        dts.ProductoId = fila.Cells(1).Value
                        dts.Orden_compraId = fila.Cells(0).Value
                        funcion.insertarDetalleOrden(dts)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Next
                dataCompraRecien.Rows.Clear()
                txtTotalVenta.Text = 0
                cmb_Prove.Enabled = True
                limpiarCompra()
                PanelDetalles.Enabled = False
                panelDetallesCompra.Enabled = False
                cmb_Prove.SelectedItem = vbNullString
                MsgBox("¡Documento guardado correctamente!" & vbCrLf & "Puede enviarlo al proveedor a traves de correo electronico")
            Catch ex As Exception
                MsgBox("No se pudo generar el documento PDF :(")
            End Try
        Else
            MsgBox("La lista esta vacia, asegurese de solicitar productos :)")
        End If
    End Sub

    Private Sub btn_Confirmar_Click(sender As Object, e As EventArgs) Handles btn_Confirmar.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("¿Desea confirmar que ha recibido el pedido?" & vbCrLf & "Esto añadirá automaticamente la cantidad del producto recibido al inventario", "Confirmando pedido...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If resul = DialogResult.OK Then
            For Each r As DataGridViewRow In dataEstadoPedido.SelectedRows
                Dim oneKey As Integer = Convert.ToInt32(r.Cells("ID").Value)
                Dim delt As New orden_compra
                Dim funcion As New Forden_compra
                delt.OrdenId = oneKey
                dataEstadoPedido.Rows.Remove(r)
                funcion.confirmarpedido(delt)
            Next
        End If
        mostrarOrdenCompras()
        mostrarHistorial()
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("¿Desea cancelar el pedido?", "Cancelando pedido...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then
            For Each r As DataGridViewRow In dataEstadoPedido.SelectedRows
                Dim oneKey As Integer = Convert.ToInt32(r.Cells("ID").Value)
                Dim delt As New orden_compra
                Dim funcion As New Forden_compra
                delt.OrdenId = oneKey
                dataEstadoPedido.Rows.Remove(r)
                funcion.cancelarpedido(delt)
            Next
        End If
        mostrarOrdenCompras()
        mostrarHistorial()
    End Sub

    Private Sub txt_precioUnidad_TextChanged(sender As Object, e As EventArgs) Handles txt_precioUnidad.TextChanged
        If txt_precioUnidad.Text <> "" And txtCantidad.Text <> "" Then
            txt_preciototal.Text = CDec(txt_precioUnidad.Text) * CDec(txtCantidad.Text)
        End If
    End Sub

    Private Sub dataCompraRecien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataCompraRecien.CellClick
        If dataCompraRecien.Rows.Count <> 0 Then
            Dim CodProd = dataCompraRecien.SelectedCells.Item(1).Value
            Dim Nombre = dataCompraRecien.SelectedCells.Item(2).Value
            Dim Cantidad = dataCompraRecien.SelectedCells.Item(3).Value
            Dim Unidad = dataCompraRecien.SelectedCells.Item(5).Value
            Dim TotalEstimado = dataCompraRecien.SelectedCells.Item(4).Value
            txt_prodId.Text = CodProd
            txt_nombreProd.Text = Nombre
            txtCantidad.Text = Cantidad
            txt_precioUnidad.Text = Unidad
            txt_preciototal.Text = TotalEstimado
            txt_nombreProd.ReadOnly = True
            btnEdit.Visible = True
            btnCancelEdit.Visible = True
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim row As DataGridViewRow = dataCompraRecien.CurrentRow
        row.Cells(3).Value = txtCantidad.Text
        row.Cells(4).Value = txt_preciototal.Text
        Me.dataCompraRecien.ClearSelection()
        Me.dataCompraRecien.CurrentCell = Me.dataCompraRecien.Rows(Me.dataCompraRecien.RowCount - 1).Cells(5)
        limpiarCompra()
        btnEdit.Visible = False
        btnCancelEdit.Visible = False
    End Sub

    Private Sub btnCancelEdit_Click(sender As Object, e As EventArgs) Handles btnCancelEdit.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("¿Cancelar la modificacion del pedido?", "Cancelando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then
            Limpiar()
            txt_nombreProd.ReadOnly = False
            compraRecien()
            btnEdit.Visible = False
            btnCancelEdit.Visible = False
        End If
    End Sub

    Sub TotalCompra()
        Dim total As Decimal = 0
        For Each fila As DataGridViewRow In dataCompraRecien.Rows
            If fila.Cells(4).Value Is Nothing Then
                Exit Sub
            Else
                total += CDec(fila.Cells(4).Value)
            End If
        Next
        txtTotalVenta.Text = total
    End Sub

    Private Sub dataCompraRecien_CurrentCellChanged(sender As Object, e As EventArgs) Handles dataCompraRecien.CurrentCellChanged
        TotalCompra()
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("¿Cancelar el pedido?" & vbCrLf & "Si desea realizar un pedido tendra que iniciar uno nuevo.", "Cancelando pedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then
            limpiarCompra()
            txt_id.Text = ""
            txtTotalVenta.Text = 0
            dataCompraRecien.Rows.Clear()
            cmb_Prove.Enabled = True
            panelDetallesCompra.Enabled = False
            PanelDetalles.Enabled = False
            panelConfirmar.Enabled = False
        End If
    End Sub

    Private Sub dataEstadoPedido_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataEstadoPedido.CellDoubleClick
        If dataEstadoPedido.Rows.Count <> 0 Then
            Dim Codigo = dataEstadoPedido.SelectedCells.Item(0).Value
            Dim estado = dataEstadoPedido.SelectedCells.Item(2).Value
            Combox.estadoCompra = estado
            Combox.idCompra = Codigo
            Frm_CompraDetalles.ShowDialog()
        End If
    End Sub

    Private Sub dataCompraHistorial_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataCompraHistorial.CellDoubleClick
        If dataCompraHistorial.Rows.Count <> 0 Then
            Dim Codigo = dataCompraHistorial.SelectedCells.Item(0).Value
            Dim estado = dataCompraHistorial.SelectedCells.Item(2).Value
            Combox.estadoCompra = estado
            Combox.idCompra = Codigo
            Frm_CompraDetalles.ShowDialog()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If dataCompraRecien.Rows.Count <> 0 Then
            For Each r As DataGridViewRow In dataCompraRecien.SelectedRows
                dataCompraRecien.Rows.Remove(r)
            Next
        Else
            MsgBox("No hay productos seleccionados para eliminar")
        End If
    End Sub

    Private Sub cmb_Prove_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Prove.SelectedIndexChanged

    End Sub
End Class