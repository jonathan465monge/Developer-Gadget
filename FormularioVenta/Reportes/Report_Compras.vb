Public Class Report_Compras
    'variable para la fecha seleccionada 
    Public fecha, fechaI, fechaF As Date

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'enviando la fecha al reporte
        InformeCompras.FechaRepo = fecha
        InformeCompras.ShowDialog()
    End Sub

    Private Sub btnMos_Click(sender As Object, e As EventArgs) Handles btnMos.Click
        'variables de fechas
        fechaI = dtpDesde.Value
        fechaF = dtpHasta.Value
        'validacion que la fecha desde sea mas antigua que la de hasta
        If fechaI > fechaF Then
            MessageBox.Show("la fecha DESDE no tiene que ser mayor que la fecha HASTA")
        Else
            'llenado de gidview
            dgCompraTotal.DataSource = ReporteComprasXFechasTableAdapter.GetData(fechaI.ToString("yyyy-MM-dd"), fechaF.ToString("yyyy-MM-dd"))
            Button1.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'envio de fehas
        InformeComprasXFechas.FechaIni = fechaI
        InformeComprasXFechas.FechaFin = fechaF
        InformeComprasXFechas.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnTotalVentas_Click(sender As Object, e As EventArgs) Handles btnTotalVentas.Click
        'variables de fechas
        fecha = dtpFecha.Value
        'se ejecuta el procedimiento del data set y llena el datagridwie 
        dgCompraTotal.DataSource = ReporCompraTableAdapter.GetData(fecha.ToString("yyyy-MM-dd"))
        btnImprimir.Visible = True
    End Sub
End Class