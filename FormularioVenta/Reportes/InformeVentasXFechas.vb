Public Class InformeVentasXFechas
    Public FechaIni, FechaFin As Date



    Private Sub InformeVentasXFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenando la tabla adapter
        ReporteVentasXFechasTableAdapter.Fill(DatosRepor.ReporteVentasXFechas, FechaIni.ToString("yyyy-MM-dd"), FechaFin.ToString("yyyy-MM-dd"))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class