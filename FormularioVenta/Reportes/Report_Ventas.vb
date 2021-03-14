Public Class Report_Venta
    'variable para la fecha seleccionada 
    Public fecha, fechaI, fechaF As Date
    Private Sub Repot_Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosRepor.ReporteVenta' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub btnTotalVentas_Click(sender As Object, e As EventArgs) Handles btnTotalVentas.Click
        'variables de fechas
        fecha = dtpFecha.Value
        'se ejecuta el procedimiento del data set y llena el datagridwie 
        dgVentaTotal.DataSource = ReporteVentaTableAdapter.GetData(fecha.ToString("yyyy-MM-dd"))
        btnImprimir.Visible = True

    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'enviando la fecha al reporte
        InformeVentas.FechaRepo = fecha
        InformeVentas.ShowDialog()
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

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
            dgVentaTotal.DataSource = ReporteVentasXFechasTableAdapter.GetData(fechaI.ToString("yyyy-MM-dd"), fechaF.ToString("yyyy-MM-dd"))
            Button1.Visible = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'envio de fehas
        InformeVentasXFechas.FechaIni = fechaI
        InformeVentasXFechas.FechaFin = fechaF
        InformeVentasXFechas.Show()
    End Sub


End Class