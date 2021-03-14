Public Class InformeVentas
    Public FechaRepo As Date

    Private Sub RDLCVentasTotales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenando la tabla adapter

        Me.ReporteVentaTableAdapter.Fill(Me.DatosRepor.ReporteVenta, FechaRepo.ToString("yyyy-MM-dd"))
        Me.ReportViewer1.RefreshReport()

    End Sub


End Class
