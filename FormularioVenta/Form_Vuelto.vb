Imports System.Data.SqlClient

Public Class Form_Vuelto

    Dim _frmVenta As Form_Ventas
    Private Sub Form_Vuelto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPagar.Text = Combox.vuelto
    End Sub

    Private Sub SoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPago.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = (".") Or e.KeyChar = (",") Then
            If e.KeyChar = (".") Then e.KeyChar = (",")
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Introduzca solo valores numéricos")
        End If
    End Sub

    Private Sub txtPago_TextChanged(sender As Object, e As EventArgs) Handles txtPago.TextChanged
        If txtPago.Text <> "" Then
            If txtPago.Text > txtPagar.Text Then
                lblCambio.Visible = False
                txtCambio.Text = CDec(txtPago.Text) - CDec(txtPagar.Text)
                btnRealizarVenta.Enabled = True
            Else
                lblCambio.Text = "Dinero insuficiente para pagar."
                lblCambio.Visible = True
                btnRealizarVenta.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnRealizarVenta_Click(sender As Object, e As EventArgs) Handles btnRealizarVenta.Click
        Dim frmVenta As New Form_Ventas

        MessageBox.Show("¡Venta realizada correctamente!" & vbCrLf & "¡Se añadió al reporte de ventas!", "Guardando Registros...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmVenta.ventaRecien()
        frmVenta.limpiarVenta()
        Dim funcion As New FVenta

        frmVenta.Label6.Text = DateTime.Now.ToString("dd/MM/yyyy")

        'If (funcion.insertarVenta) Then

        '    Dim con As New SqlConnection
        '    con = New SqlConnection("data source=(local);initial catalog=SysLibreria;integrated security=true")
        '    Dim consulta As String = "SELECT TOP 1 VentaId FROM Venta ORDER BY VentaId DESC"
        '    Dim comando As New SqlCommand(consulta, con)
        '    Dim drd As SqlDataReader

        '    con.Open()
        '    drd = comando.ExecuteReader()

        '    If drd.Read() Then
        '        frmVenta.txt_ventaId.Text() = drd.Item("VentaId").ToString()
        '    End If
        '    drd.Close()
        '    con.Close()
        'End If
        frmVenta.dataFact.DataSource = Nothing
        Dim frmProd As New Form_Producto
        frmProd.mostrar()
        Me.Close()
    End Sub
End Class