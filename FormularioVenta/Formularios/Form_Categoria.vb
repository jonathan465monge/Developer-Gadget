Public Class Form_Categoria
    Private dt As New DataTable

    Public Sub limpiar()

        btneditar.Visible = False
        txtnombre.Text = ""
        txtcategoriaid.Text = ""
        txt_Estado.Text = ""
        cbocampo.SelectedItem = vbNullString
    End Sub

    Sub alternarColoDatGV(ByVal dgv As DataGridView)
        If dgv.Rows.Count <> 0 Then
            With dgv
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .RowsDefaultCellStyle.SelectionBackColor = Color.DarkRed
                .RowsDefaultCellStyle.SelectionForeColor = Color.White
                .Columns(0).Width = 50
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 175
            End With
        End If
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New FCategoria
            dt = func.mostrar
            datalistado.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnguardar.Visible = True
        btneditar.Visible = False
        buscar()
    End Sub


    Private Sub buscar()
        If cbocampo.Text <> "" Then
            Try
                Dim ds As New DataSet
                ds.Tables.Add(dt.Copy)
                Dim dv As New DataView(ds.Tables(0))
                dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

                If dv.Count <> 0 Then
                    Inexistente.Visible = False
                    datalistado.DataSource = dv
                Else
                    Inexistente.Visible = True
                    datalistado.DataSource = Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If
    End Sub

    Private Sub Form_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        cbocampo.SelectedItem = vbNullString
        alternarColoDatGV(datalistado)
    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" Then
            Try
                Dim dts As New Categoria
                Dim func As New FCategoria

                dts.Nombre = txtnombre.Text
                If func.insertar(dts) Then
                    MessageBox.Show("Categoria Registrada Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Categoria no fue registrada intente de nuevo", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan Ingresar algunos Datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        alternarColoDatGV(datalistado)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs)
        If Me.ValidateChildren = True And txtnombre.Text <> "" Then
            Try
                Dim dts As New Categoria
                Dim func As New FCategoria

                dts.Nombre = txtnombre.Text
                If func.insertar(dts) Then
                    MessageBox.Show("Categoria Registrada Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Categoria no fue registrada intente de nuevo", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan Ingresar algunos Datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        alternarColoDatGV(datalistado)
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        If datalistado.Rows.Count <> 0 Then
            txtcategoriaid.Text = datalistado.SelectedCells.Item(0).Value
            txtnombre.Text = datalistado.SelectedCells.Item(1).Value
            txt_Estado.Text = datalistado.SelectedCells.Item(2).Value

            If txt_Estado.Text = "Activa" Then
                btn_Desact.Visible = True
                btn_Activ.Visible = False
            Else
                btn_Desact.Visible = False
                btn_Activ.Visible = True
            End If

            btneditar.Visible = True
            btnguardar.Visible = False
        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim resul As New DialogResult
        resul = MessageBox.Show("Realmente desea editar los datos de la categoria", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resul = DialogResult.OK Then


            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtcategoriaid.Text <> "" Then
                Try
                    Dim dts As New Categoria
                    Dim func As New FCategoria

                    dts.CategoriaId = txtcategoriaid.Text
                    dts.Nombre = txtnombre.Text
                    If func.editar(dts) Then
                        MessageBox.Show("Categoria Modificada Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Categoria no fue Modificada intente de nuevo", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Faltan Ingresar algunos Datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        alternarColoDatGV(datalistado)
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btn_Desact.Click
        For Each r As DataGridViewRow In datalistado.SelectedRows
            Dim oneKey As Integer = Convert.ToInt32(r.Cells("ID").Value)
            Dim delt As New Categoria
            Dim funcion As New FCategoria
            delt.CategoriaId = oneKey
            datalistado.Rows.Remove(r)

            funcion.desactivar(delt)
        Next
        Call mostrar()
        Call limpiar()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Activ.Click
        For Each r As DataGridViewRow In datalistado.SelectedRows
            Dim oneKey As Integer = Convert.ToInt32(r.Cells("ID").Value)
            Dim delt As New Categoria
            Dim funcion As New FCategoria
            delt.CategoriaId = oneKey
            datalistado.Rows.Remove(r)

            funcion.activar(delt)
        Next
        Call mostrar()
        Call limpiar()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Call mostrar()
        Call limpiar()
        Call alternarColoDatGV(datalistado)
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub
End Class