Public Class Frm_Boleta

    Dim dt As DataTable
    Private Sub Frm_Boleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIdVenta.Text = Combox.idVenta
        lbVended.Text = Combox.vendedor
        txtTotal.Text = Combox.totalVenta
        txtCancelo.Text = Combox.pago
        txtvuelto.Text = Combox.cambio
        lblPermiso.Text = Combox.permiso
        lblFecha.Text = Combox.fechaVenta
        'lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        Dim dts As New DetalleVenta
        Dim funcion As New FDetalleVenta

        dts.VentaId = lblIdVenta.Text
        Try
            dt = funcion.mostrarVentaRecien(dts)
            dataBoleta.DataSource = dt
            alternarColoDatGV(dataBoleta)
            Me.dataBoleta.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If lblPermiso.Text = "VerDetalles" Then
        Else
            Timer1.Start()
        End If
    End Sub

    Sub alternarColoDatGV(ByVal dgv As DataGridView)
        If dgv.Rows.Count <> 0 Then
            With dgv
                .BackgroundColor = Color.LightBlue
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue
                .RowsDefaultCellStyle.SelectionForeColor = Color.Black
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PrintForm1.Print()
        Timer1.Stop()
    End Sub
End Class