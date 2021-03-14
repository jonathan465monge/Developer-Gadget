Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form_EnviarCorreo

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

    Private Sub Form_EnviarCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddOwnedForm(Form_Compras)
        txt_CorreoUser.Text = Combox.correo
        txt_CorreoProv.Text = Combox.ProvCompra
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ValidateChildren And txt_CorreoProv.Text <> "" And txt_CorreoUser.Text <> "" And txt_Asunto.Text <> "" And txt_PassUser.Text <> "" And txt_Pedido.Text <> "" Then
            If MessageBox.Show("¿Desea enviar el correo?", "Confirmacion...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                enviarCorreo(txt_CorreoUser.Text, txt_PassUser.Text, txt_CorreoProv.Text, txt_Asunto.Text, txt_Pedido.Text, txtRuta.Text)
            End If
        Else
            MessageBox.Show("Asegurese de rellenar todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Examinar.Click
        Try
            Me.OpenFileDialog1.FileName = ""
            Me.OpenFileDialog1.Filter = "Archivos pdf (*.pdf)|*.pdf"
            Me.OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                txtRuta.Text = Me.OpenFileDialog1.FileName
            Else
                txtRuta.Text = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub
End Class