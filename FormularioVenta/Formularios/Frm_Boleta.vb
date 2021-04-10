Public Class Frm_Boleta

    Public IdVenta As Integer
    Private Sub Frm_Boleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosRepor.mostrar_detalleventaRecien' Puede moverla o quitarla según sea necesario.
        Me.mostrar_detalleventaRecienTableAdapter.Fill(Me.DatosRepor.mostrar_detalleventaRecien, IdVenta)


        'Dim dts As New DetalleVenta
        'Dim funcion As New FDetalleVenta

        'dts.VentaId = lblIdVenta.Text
        'Try
        '    dt = funcion.mostrarVentaRecien(dts)
        '    dataBoleta.DataSource = dt
        '    alternarColoDatGV(dataBoleta)
        '    Me.dataBoleta.ClearSelection()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'If lblPermiso.Text = "VerDetalles" Then
        'Else
        '    Timer1.Start()
        'End If

        Me.ReportViewer1.RefreshReport()
    End Sub

   

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        'PrintForm1.Print()
        'Timer1.Stop()
    End Sub
End Class