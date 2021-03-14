Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form_AdmProductos
    Public _frmProd As Form_Producto
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(frmProd As Form_Producto)
        Me.New()
        _frmProd = frmProd
    End Sub
    Private Sub Form_AdmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcion As New FCategoria
        Categ_cmb.DataSource = funcion.mostrar
        Categ_cmb.DisplayMember = "Nombre"
        Categ_cmb.ValueMember = "ID"

        Dim func As New FProveedor
        prov_cmb.DataSource = func.mostrar
        prov_cmb.DisplayMember = "Nombre"
        prov_cmb.ValueMember = "ID"

        If btn_Aplicar.Text = "Aplicar cambios" Then
            prov_cmb.Text = Combox.proveedor
            Categ_cmb.Text = Combox.categoria
        End If
    End Sub

    Private Sub SoloNumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstock.KeyPress, txtprecioCompra.KeyPress, txtmargen.KeyPress
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

    Public Sub limpiar()
        txtnombre.Text = ""
        txtproductoid.Text = ""
        txtnombre.Text = ""
        txtdescripcion.Text = ""
        txtprecioCompra.Text = ""
        txtmargen.Text = ""
        txtPrecioVenta.Text = ""
        txtstock.Text = "0"
        txt_Estado.Text = ""
        Categ_cmb.SelectedItem = vbNullString
        prov_cmb.SelectedItem = vbNullString
        ProdImagen.Image = Nothing
    End Sub

    Private Sub btn_AddImg_Click(sender As Object, e As EventArgs) Handles btn_AddImg.Click
        Dim ImagenProducto As New OpenFileDialog
        ImagenProducto.ShowDialog()
        ProdImagen.ImageLocation = ImagenProducto.FileName
    End Sub

    Private Sub btn_dltImg_Click(sender As Object, e As EventArgs) Handles btn_dltImg.Click
        ProdImagen.Image = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_Aplicar.Click
        If btn_Aplicar.Text = "Aplicar cambios" Then
            Dim resul As DialogResult
            resul = MessageBox.Show("Realmente desea editar los datos del producto", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If resul = DialogResult.OK Then
                If Me.ValidateChildren = True And txtnombre.Text <> "" And txtproductoid.Text <> "" And txtprecioCompra.Text <> "" And txtmargen.Text <> "" And txtPrecioVenta.Text <> "" And txtstock.Text >= 0 And Categ_cmb.Text <> "" And prov_cmb.Text <> "" Then
                    Try
                        Dim dts As New Producto
                        Dim func As New FProducto

                        dts.ProductoId = txtproductoid.Text
                        dts.Nombre = txtnombre.Text
                        dts.DescripcionProducto = txtdescripcion.Text
                        dts.PrecioCompra = txtprecioCompra.Text
                        dts.Margen = txtmargen.Text
                        dts.PrecioVenta = txtPrecioVenta.Text
                        dts.Stock = txtstock.Text
                        dts.CategoriaId = Categ_cmb.SelectedValue
                        dts.ProveedorId = prov_cmb.SelectedValue

                        If ProdImagen.Image Is Nothing Then
                            If func.editarSinIMG(dts) Then
                                MessageBox.Show("Producto modificado Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                _frmProd.mostrar()
                                limpiar()
                            Else
                                MessageBox.Show("El producto no fue modificado, intente de nuevo", "Cancelando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                _frmProd.mostrar()
                                limpiar()
                            End If
                        Else
                            Dim imagenes As New MemoryStream
                            Me.ProdImagen.Image.Save(imagenes, Me.ProdImagen.Image.RawFormat)
                            dts.ImagenProducto = imagenes.GetBuffer
                            If func.editar(dts) Then
                                MessageBox.Show("Producto modificado Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                _frmProd.mostrar()
                                limpiar()
                            Else
                                MessageBox.Show("El producto no fue modificado, intente de nuevo", "Cancelando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                _frmProd.mostrar()
                                limpiar()
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MessageBox.Show("Faltan Ingresar algunos Datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        ElseIf btn_Aplicar.Text = "Agregar" Then
            Dim resul As DialogResult
            resul = MessageBox.Show("Guardando nuevo Registro de Producto", "Guardando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If resul = DialogResult.OK Then
                If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdescripcion.Text <> "" And txtprecioCompra.Text <> "" And txtmargen.Text <> "" And txtPrecioVenta.Text <> "" And txtstock.Text <> "" Then
                    Try
                        Dim dts As New Producto
                        Dim func As New FProducto

                        dts.Nombre = txtnombre.Text
                        dts.DescripcionProducto = txtdescripcion.Text
                        dts.PrecioCompra = txtprecioCompra.Text
                        dts.Margen = txtmargen.Text
                        dts.PrecioVenta = txtPrecioVenta.Text
                        dts.Stock = txtstock.Text
                        dts.CategoriaId = Categ_cmb.SelectedValue
                        dts.ProveedorId = prov_cmb.SelectedValue

                        If ProdImagen.Image Is Nothing Then
                            If func.insertar(dts) Then
                                MessageBox.Show("Producto registrado Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                _frmProd.mostrar()
                                limpiar()
                            Else
                                MessageBox.Show("El producto no fue registrado, intente de nuevo", "Cancelando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                _frmProd.mostrar()
                                limpiar()
                            End If
                        Else
                            Dim imagenes As New MemoryStream
                            Me.ProdImagen.Image.Save(imagenes, Me.ProdImagen.Image.RawFormat)
                            dts.ImagenProducto = imagenes.GetBuffer
                            If func.insertarIMG(dts) Then
                                MessageBox.Show("Producto registrado Correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                _frmProd.mostrar()
                                limpiar()
                            Else
                                MessageBox.Show("El producto no fue registrado, intente de nuevo", "Cancelando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                _frmProd.mostrar()
                                limpiar()
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MessageBox.Show("Faltan Ingresar algunos Datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Cancelando el registro", "Cancelando Registros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub txtprecioCompra_TextChanged(sender As Object, e As EventArgs) Handles txtprecioCompra.TextChanged
        If txtprecioCompra.Text <> "" And txtmargen.Text <> "" Then
            txtPrecioVenta.Text = CDec(txtprecioCompra.Text) + CDec(txtmargen.Text)
        End If
    End Sub

    Private Sub txtmargen_TextChanged(sender As Object, e As EventArgs) Handles txtmargen.TextChanged
        If txtprecioCompra.Text <> "" And txtmargen.Text <> "" Then
            txtPrecioVenta.Text = CDec(txtprecioCompra.Text) + CDec(txtmargen.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Cancelar registro?", "Cancelando...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resultado = DialogResult.OK Then
            Me.Close()
        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class