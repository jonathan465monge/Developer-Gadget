Imports System.IO
Imports System.Runtime.InteropServices

Public Class Frm_CompraDetalles

    Dim dt As New DataTable
    Private Sub Frm_CompraDetalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddOwnedForm(Form_Compras)
        txtCodigoCompra.Text = Combox.idCompra
        txtEstadoCompra.Text = Combox.estadoCompra

        If txtEstadoCompra.Text = "Recibido" Then
            txtEstadoCompra.BackColor = Color.LightGreen
        ElseIf txtEstadoCompra.Text = "Cancelado" Then
            txtEstadoCompra.BackColor = Color.DarkRed
        ElseIf txtEstadoCompra.Text = "En espera..." Then
            txtEstadoCompra.BackColor = Color.LightBlue
        End If
        Dim funcion As New FDetalleOrdenCompra
        Dim dts As New Detalle_Orden_compra

        dts.Orden_compraId = txtCodigoCompra.Text
        Try
            dt = funcion.mostrardetallesCompra(dts)
            dataDetallesCompra.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        alternarColoDatGV(dataDetallesCompra)
    End Sub

    Sub alternarColoDatGV(ByVal dgv As DataGridView)
        If dgv.Rows.Count <> 0 Then
            With dgv
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .RowsDefaultCellStyle.SelectionBackColor = Color.DarkRed
                .RowsDefaultCellStyle.SelectionForeColor = Color.White
                .Columns(0).Width = 75
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 40
                .Columns(3).Width = 60
                .Columns(4).Width = 100
            End With
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lparam As Integer)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class