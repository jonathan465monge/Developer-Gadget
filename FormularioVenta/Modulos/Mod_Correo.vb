Imports System.Net
Imports System.Net.Mail

Module Correo

    Private correos As New MailMessage
    Private envios As New SmtpClient

    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal destinatario As String, ByVal asunto As String, ByVal mensaje As String, ByVal ruta As String)
        Try
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))

            If ruta <> "" Then
                Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(ruta)
                correos.Attachments.Add(archivo)
            End If

            correos.From = New MailAddress(emisor)

            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.Credentials = New NetworkCredential(emisor, password)
            envios.EnableSsl = True

            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
