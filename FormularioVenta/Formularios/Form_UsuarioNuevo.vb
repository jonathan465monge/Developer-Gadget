Public Class Form_UsuarioNuevo

    Dim dt As New DataTable

    Sub alternarColoDatGV(ByVal dgv As DataGridView)
        If dgv.Rows.Count <> 0 Then
            With dgv
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .RowsDefaultCellStyle.SelectionBackColor = Color.DarkRed
                .RowsDefaultCellStyle.SelectionForeColor = Color.White
                '.Columns(0).Width = 50
                '.Columns(1).Width = 85
                '.Columns(2).Width = 150
                '.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim funcion As New FUsser
        Dim dts As New Usser

        dts.Nombre = txt_Nombre.Text
        dts.Apellido = txt_Apellido.Text
        dts.Dui = txt_Dui.Text
        dts.Direccion = txt_Direccion.Text
        dts.Telefono = txt_Telefono.Text
        dts.Nombreuser = txt_NombreUser.Text
        dts.Pass = txt_contraseña.Text
        dts.Correo = txt_Correo.Text
        If cmb_TipoUsser.Text = "Vendedor" Then
            txt_Acceso.Text = 2
            dts.Acceso = txt_Acceso.Text
        End If

        If funcion.insertUsser(dts) Then
            MsgBox("¡Usuario Registrado Correctamente!")
            mostrar()
        End If
    End Sub

    Private Sub mostrar()
        Try
            Dim funcion As New FUsser
            dt = funcion.mostrar
            dataUsuarios.DataSource = dt
            alternarColoDatGV(dataUsuarios)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form_UsuarioNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
End Class