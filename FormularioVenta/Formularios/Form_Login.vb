Public Class Form_Login

    Private Sub txt_Pass_Enter(sender As Object, e As EventArgs) Handles txt_Pass.Enter
        If txt_Pass.Text = "Ingrese aqui su contraseña..." Then
            txt_Pass.Text = ""
            txt_Pass.PasswordChar = "*"
            txt_Pass.BackColor = Color.Khaki
            txt_Pass.ForeColor = Color.Black
        End If
        lbl_PassInc.Text = ""
        lbl_PassInc.Visible = False
    End Sub

    Private Sub txt_Pass_Leave(sender As Object, e As EventArgs) Handles txt_Pass.Leave
        If txt_Pass.Text = "" Then
            txt_Pass.Text = "Ingrese aqui su contraseña..."
            txt_Pass.PasswordChar = ""
            txt_Pass.BackColor = Color.LemonChiffon
            txt_Pass.ForeColor = Color.DimGray
        ElseIf txt_Pass.Text <> "" Then
            txt_Pass.BackColor = Color.LemonChiffon
            txt_Pass.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txt_Usuario_Enter(sender As Object, e As EventArgs) Handles txt_Usuario.Enter
        If txt_Usuario.Text = "Ingrese aqui su nombre de usuario..." Then
            txt_Usuario.Text = ""
            txt_Usuario.BackColor = Color.Khaki
            txt_Usuario.ForeColor = Color.Black
        End If
        lbl_UserInc.Text = ""
        lbl_UserInc.Visible = False
    End Sub

    Private Sub txt_Usuario_Leave(sender As Object, e As EventArgs) Handles txt_Usuario.Leave
        If txt_Usuario.Text = "" Then
            txt_Usuario.Text = "Ingrese aqui su nombre de usuario..."
            txt_Usuario.BackColor = Color.LemonChiffon
            txt_Usuario.ForeColor = Color.DimGray
        ElseIf txt_Usuario.Text <> "" Then
            txt_Usuario.BackColor = Color.LemonChiffon
            txt_Usuario.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub btn_MInimizar_Click(sender As Object, e As EventArgs) Handles btn_MInimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim funcion As New FUsser

        If txt_Usuario.Text = "Ingrese aqui su nombre de usuario..." Or txt_Usuario.Text = "" Then
                lbl_UserInc.Text = "Ingrese su nombre de Usuario"
                lbl_UserInc.Visible = True
            ElseIf txt_Usuario.Text <> "" Then
                If funcion.Usuario(txt_Usuario.Text) = True Then
                    Dim contra As String = funcion.Contraseña(txt_Usuario.Text)
                    If txt_Pass.Text = "" Or txt_Pass.Text = "Ingrese aqui su contraseña..." Then
                        lbl_PassInc.Text = "Ingrese su contraseña"
                        lbl_PassInc.Visible = True
                    ElseIf txt_Pass.Text <> "" Then
                        If contra.Equals(txt_Pass.Text) = True Then
                            If funcion.TipoUser(txt_Usuario.Text) = "1" Then
                            Form_Multi.LabelFlagAcceso.Text = "admin"
                            Form_Multi.NombreUser.Text = funcion.NombreUser(txt_Usuario.Text) & " " & funcion.ApellidoUser(txt_Usuario.Text)
                            Form_Multi.correoUser.Text = funcion.CorreoUser(txt_Usuario.Text)
                            Form_Multi.puestoUser.Text = "Administrador"
                            Form_Multi.Show()
                            ElseIf funcion.TipoUser(txt_Usuario.Text) = "2" Then
                            Form_Multi.LabelFlagAcceso.Text = "ventas"
                            Form_Multi.NombreUser.Text = funcion.NombreUser(txt_Usuario.Text) & " " & funcion.ApellidoUser(txt_Usuario.Text)
                            Form_Multi.correoUser.Text = funcion.CorreoUser(txt_Usuario.Text)
                            Form_Multi.puestoUser.Text = "Vendedor"
                            Form_Multi.Show()
                            End If
                            Me.Hide()
                        Else
                            lbl_PassInc.Text = "Contraseña incorrecta"
                            lbl_PassInc.Visible = True
                        End If
                    End If
                Else
                    lbl_UserInc.Text = "Usuario no registrado"
                    lbl_UserInc.Visible = True
                End If
            End If

    End Sub

    Private Sub btn_Cerrar_MouseHover(sender As Object, e As EventArgs) Handles btn_Cerrar.MouseHover
        btn_Cerrar.BackColor = Color.Red
    End Sub

    Private Sub btn_MInimizar_MouseHover(sender As Object, e As EventArgs) Handles btn_MInimizar.MouseHover
        btn_MInimizar.BackColor = Color.DimGray
    End Sub

    Private Sub btn_MInimizar_MouseLeave(sender As Object, e As EventArgs) Handles btn_MInimizar.MouseLeave
        btn_MInimizar.BackColor = Color.LemonChiffon
    End Sub

    Private Sub btn_Cerrar_MouseLeave(sender As Object, e As EventArgs) Handles btn_Cerrar.MouseLeave
        btn_Cerrar.BackColor = Color.LemonChiffon
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class