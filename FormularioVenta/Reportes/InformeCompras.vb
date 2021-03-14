Public Class InformeCompras
    Public FechaRepo As Date
    Private Sub InformeCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosRepor.ReporCompra' Puede moverla o quitarla según sea necesario.
        'Me.ReporCompraTableAdapter.Fill(Me.DatosRepor.ReporCompra)

        Me.ReporCompraTableAdapter.Fill(Me.DatosRepor.ReporCompra, FechaRepo.ToString("yyyy-MM-dd"))
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class