Public Class InformeComprasXFechas
    Public FechaIni, FechaFin As Date
    Private Sub InformeComprasXFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosRepor.ReporteComprasXFechas' Puede moverla o quitarla según sea necesario.
        'Me.ReporteComprasXFechasTableAdapter.Fill(Me.DatosRepor.ReporteComprasXFechas)
        ReporteComprasXFechasTableAdapter.Fill(DatosRepor.ReporteComprasXFechas, FechaIni.ToString("yyyy-MM-dd"), FechaFin.ToString("yyyy-MM-dd"))
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class