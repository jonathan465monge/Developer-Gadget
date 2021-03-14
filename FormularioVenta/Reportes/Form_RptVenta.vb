Public Class Form_RptVenta
    Dim dt As DataTable
    Private Sub Form_RptVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim funcion As New FVenta
            dt = funcion.mostrarVentaHistorial()
            dataListaVentas.DataSource = dt
            alternarColoDatGV(dataListaVentas)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub alternarColoDatGV(ByVal dgv As DataGridView)
        If dgv.Rows.Count <> 0 Then
            With dgv
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .RowsDefaultCellStyle.SelectionBackColor = Color.DarkRed
                .RowsDefaultCellStyle.SelectionForeColor = Color.White
                .Columns(0).Width = 100
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        End If
    End Sub

    Private Sub dataListaVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListaVentas.CellClick
        Dim fecha = dataListaVentas.SelectedCells.Item(1).Value
        Dim id = dataListaVentas.SelectedCells.Item(0).Value

        txtVentaId.Text = id
        txtFecha.Text = fecha
    End Sub

    Private Sub dataListaVentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListaVentas.CellDoubleClick
        If dataListaVentas.Rows.Count <> 0 Then
            'Combox.idVenta = txtVentaId.Text
            'Combox.fechaVenta = txtFecha.Text
            'Combox.permiso = "VerDetalles"
            Frm_Boleta.IdVenta = txtVentaId.Text
            Frm_Boleta.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("¿Imprimir boleta?", "Imprimiendo documento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then

            'Combox.idVenta = txtVentaId.Text
            'Combox.fechaVenta = txtFecha.Text
            'Combox.permiso = "0"
            Frm_Boleta.IdVenta = txtVentaId.Text
            Frm_Boleta.ShowDialog()
        End If
    End Sub
End Class