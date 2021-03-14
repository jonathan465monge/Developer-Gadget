Public Class Form_Inventario
    Dim dt As New DataTable

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

    Public Sub mostrar()
        Try
            Dim funcion As New FProducto
            dt = funcion.mostrar
            dataproductos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscar()
    End Sub

    Private Sub dataproductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataproductos.CellDoubleClick
        If LblVenta.Text = "venta" Then
            If dataproductos.Rows.Count <> 0 Then
                txt_Estd.Text = dataproductos.SelectedCells.Item(1).Value
                txt_Stck.Text = dataproductos.SelectedCells.Item(2).Value
                If txt_Estd.Text = "Activo" Then
                    If txt_Stck.Text > 0 Then
                        Dim frmVent As Frm_Venta = TryCast(Owner, Frm_Venta)
                        Dim Id = dataproductos.SelectedCells.Item(0).Value
                        Dim Nombre = dataproductos.SelectedCells.Item(3).Value
                        Dim Precio = dataproductos.SelectedCells.Item(6).Value
                        Dim IMG = dataproductos.SelectedCells.Item(10).FormattedValue
                        Dim Stock = dataproductos.SelectedCells.Item(2).Value
                        Dim estado = dataproductos.SelectedCells.Item(1).Value
                        Dim descripcion = dataproductos.SelectedCells.Item(4).Value

                        frmVent.txtestado.Text = estado
                        frmVent.txtStock.Text = Stock
                        frmVent.txtDescripcion.Text = descripcion
                        frmVent.txt_prodId.Text = Id
                        frmVent.txt_nombreProd.Text = Nombre
                        frmVent.txt_precioUnidad.Text = Precio
                        frmVent.pb_ProdImg.Image = IMG
                        frmVent.txtCantidad.Text = 0
                        frmVent.txt_preciototal.Text = 0
                        Combox.lblVenta = "inventario"
                        LblVenta.Text = Combox.lblVenta
                        Me.Close()
                    Else
                        MessageBox.Show("Ya no hay existencias disponibles de este producto", "Sin existencias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Este producto no se encuentra disponible para realizar la venta", "Producto no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub Form_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblVenta.Text = Combox.lblVenta
        mostrar()
        alternarColoDatGV(dataproductos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        mostrar()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub
End Class