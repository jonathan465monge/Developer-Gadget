Public Class Form_Reportes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirForm(Of Report_Venta)()
    End Sub
    Private Sub AbrirForm(Of Formu As {Form, New})()
        Dim formulario As Form
        formulario = PForm.Controls.OfType(Of Formu)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New Formu()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            PForm.Controls.Add(formulario)
            PForm.Tag = formulario
            formulario.Show()
        Else
            formulario.BringToFront()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirForm(Of Report_Compras)()

    End Sub
End Class