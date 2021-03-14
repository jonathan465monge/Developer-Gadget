Imports System.ComponentModel

Public Class Form_Proveedor
    Private dt As New DataTable
    Private Sub frmproveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        cbocampo.SelectedItem = vbNullString
        alternarColoDatGV(datalistado)
    End Sub

    Sub alternarColoDatGV(ByVal dgv As DataGridView)
        If dgv.Rows.Count <> 0 Then
            With dgv
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .RowsDefaultCellStyle.SelectionBackColor = Color.DarkRed
                .RowsDefaultCellStyle.SelectionForeColor = Color.White
                .Columns(0).Width = 50
                .Columns(1).Width = 200
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(3).Width = 75
                .Columns(4).Width = 200
                .Columns(5).Width = 75
            End With
        End If
    End Sub

    Private Sub SoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress, MyBase.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = (".") Or e.KeyChar = ("-") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Introduzca solo valores numéricos")
        End If
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtproveedorid.Text = ""
        txtnombre.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txt_Estado.Text = ""
        txtcorreo.Text = ""
        cbocampo.SelectedItem = vbNullString
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New FProveedor
            dt = func.mostrar

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                Inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                Inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        btnnuevo.Visible = True
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
        End If
    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
        alternarColoDatGV(datalistado)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" Then
            Try
                Dim dts As New Proveedor
                Dim func As New FProveedor

                dts.Nombre = txtnombre.Text
                dts.Direccion = txtdireccion.Text
                dts.Telefono = txttelefono.Text
                dts.Correo = txtcorreo.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Proveedor Registrado Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()

                Else
                    MessageBox.Show("Proveedor no fue registrado intente de nuevo", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            txtproveedorid.Text = datalistado.SelectedCells.Item(0).Value
            txtnombre.Text = datalistado.SelectedCells.Item(1).Value
            txtdireccion.Text = datalistado.SelectedCells.Item(2).Value
            txttelefono.Text = datalistado.SelectedCells.Item(3).Value
            txtcorreo.Text = datalistado.SelectedCells.Item(4).Value
            txt_Estado.Text = datalistado.SelectedCells.Item(5).Value

            If txt_Estado.Text = "Activo" Then
                btn_Desact.Visible = True
                btn_Activ.Visible = False
            ElseIf txt_Estado.Text = "Inactivo" Then
                btn_Desact.Visible = False
                btn_Activ.Visible = True
            End If

            btneditar.Visible = True
            btnguardar.Visible = False
        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("Realmente desea editar los datos del proveedor", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resul = DialogResult.OK Then
            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtproveedorid.Text <> "" Then
                Try
                    Dim dts As New Proveedor
                    Dim func As New FProveedor

                    dts.ProveedorId = txtproveedorid.Text
                    dts.Nombre = txtnombre.Text
                    dts.Direccion = txtdireccion.Text
                    dts.Telefono = txttelefono.Text
                    dts.Correo = txtcorreo.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Proveedor Modificado Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Proveedor no fue Modificado intente de nuevo", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Dim delt As New Proveedor
            Dim funcion As New FProveedor
            delt.ProveedorId = oneKey
            datalistado.Rows.Remove(r)

            funcion.desactivar(delt)
        Next
        Call mostrar()
        Call limpiar()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub btn_Activ_Click(sender As Object, e As EventArgs) Handles btn_Activ.Click
        For Each r As DataGridViewRow In datalistado.SelectedRows
            Dim oneKey As Integer = Convert.ToInt32(r.Cells("ID").Value)
            Dim delt As New Proveedor
            Dim funcion As New FProveedor
            delt.ProveedorId = oneKey
            datalistado.Rows.Remove(r)

            funcion.activar(delt)
        Next
        Call limpiar()
        Call mostrar()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        alternarColoDatGV(datalistado)
        limpiar()
        mostrar()
    End Sub
End Class