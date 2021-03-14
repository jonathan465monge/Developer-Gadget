Imports System.Runtime.InteropServices
Imports System.Data.SqlClient

Public Class Form_Multi

    Dim dt As DataTable
    Private Sub Form_Multi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Pan1()
        Me.Pan2()
        Me.Pan3()
        If LabelFlagAcceso.Text = "admin" Then
            btn_ventas.Visible = False
            btn_reporte.Visible = False
            btn_inventario.Visible = False
            btnInicioVend.Visible = False
            Combox.correo = correoUser.Text
            Combox.labelFlag = "0"

        ElseIf LabelFlagAcceso.Text = "ventas" Then
            btn_Inv.Visible = False
            btnInicio.Visible = False
            btn_Compras.Visible = False
            btn_AdminProv.Visible = False
            btn_AdminProductos.Visible = False
            btn_AdminCateg.Visible = False
            btn_Usuarios.Visible = False
            btn_RepAdmin.Visible = False
            Combox.labelFlag = "Inventario"
            LabelFlagAcceso.Text = Combox.labelFlag
            Combox.vendedor = NombreUser.Text

            Panel15.Visible = False
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Panel8.Visible = False
            Panel9.Visible = False
            Panel10.Visible = False
            Panel11.Visible = False
        End If

        Try
            Dim funcion As New FDetalleVenta
            dt = funcion.masVendido()
            dataMasVendidos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        alternarColoDatGV(dataMasVendidos)
    End Sub

    Sub alternarColoDatGV(ByVal dgv As DataGridView)
        If dgv.Rows.Count <> 0 Then
            With dgv
                .RowHeadersVisible = False
                .EnableHeadersVisualStyles = False
                .ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 192))
                .BackgroundColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 192))
                .RowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 192))
                .RowsDefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 192))
                .RowsDefaultCellStyle.SelectionForeColor = Color.Black
                .Columns(0).Width = 100
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 100
            End With
        End If
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lparam As Integer)
    End Sub

    Private Sub panelEncabezado_MouseMove(sender As Object, e As MouseEventArgs) Handles panelEncabezado.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer
    Private Sub btn_Maximizar_Click(sender As Object, e As EventArgs) Handles btn_Maximizar.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        btn_Restaurar.Visible = True
        btn_Maximizar.Visible = False
    End Sub

    Private Sub btn_Restaurar_Click(sender As Object, e As EventArgs) Handles btn_Restaurar.Click
        btn_Restaurar.Visible = False
        btn_Maximizar.Visible = True
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR.Tick
        If panelInicio.Width <= 60 Then
            Me.tmOCULTAR.Enabled = False
        Else
            Me.panelInicio.Width = panelInicio.Width - 40
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMOSTRAR.Tick
        If panelInicio.Width >= 220 Then
            Me.tmMOSTRAR.Enabled = False
        Else
            Me.panelInicio.Width = panelInicio.Width + 40
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If panelInicio.Width = 220 Then
            tmOCULTAR.Enabled = True
        ElseIf panelInicio.Width = 60 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub

    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.panelPrincipal.Region = region
        Me.Invalidate()
    End Sub

    Private Sub Pan1()
        Dim con As New SqlConnection
        con = New SqlConnection("data source=(local);initial catalog=SysLibreria;integrated security=true")
        Dim consulta As String = "SELECT COUNT(*) AS Cuenta FROM Producto"
        Dim comando As New SqlCommand(consulta, con)

        Dim drd As SqlDataReader

        con.Open()
        drd = comando.ExecuteReader()

        If drd.Read() Then
            Me.label_CountP1.Text() = "Existen " & drd.Item("Cuenta").ToString() & " productos registrados actualmente. "
        End If

        drd.Close()
        con.Close()
    End Sub

    Private Sub Pan2()
        Dim con As New SqlConnection
        con = New SqlConnection("data source=(local);initial catalog=SysLibreria;integrated security=true")
        Dim consulta As String = "SELECT COUNT(*) AS Cuenta FROM Proveedor"
        Dim comando As New SqlCommand(consulta, con)

        Dim drd As SqlDataReader

        con.Open()
        drd = comando.ExecuteReader()

        If drd.Read() Then
            Me.label_CountP2.Text() = "Existen " & drd.Item("Cuenta").ToString() & " proveedores registrados actualmente. "
        End If

        drd.Close()
        con.Close()
    End Sub

    Private Sub Pan3()
        Dim con As New SqlConnection
        con = New SqlConnection("data source=(local);initial catalog=SysLibreria;integrated security=true")
        Dim consulta As String = "SELECT COUNT(*) AS Cuenta FROM Categoria"
        Dim comando As New SqlCommand(consulta, con)

        Dim drd As SqlDataReader

        con.Open()
        drd = comando.ExecuteReader()

        If drd.Read() Then
            Me.label_CountP3.Text() = "Existen " & drd.Item("Cuenta").ToString() & " categorias registradas actualmente. "
        End If

        drd.Close()
        con.Close()
    End Sub


    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click
        Panel7.BackColor = Color.Green
        Panel6.BackColor = Color.Gold
        Panel5.BackColor = Color.Gold
        Panel16.BackColor = Color.Gold
        AbrirForm(Of Frm_Venta)()
    End Sub

    Private Sub btn_inventario_Click(sender As Object, e As EventArgs) Handles btn_inventario.Click
        Panel6.BackColor = Color.Green
        Panel7.BackColor = Color.Gold
        Panel5.BackColor = Color.Gold
        Panel16.BackColor = Color.Gold
        AbrirForm(Of Form_Inventario)()
    End Sub

    Private Sub btn_AdminProductos_Click(sender As Object, e As EventArgs) Handles btn_AdminProductos.Click
        PanMul.Visible = False
        Panel15.BackColor = Color.Gold
        Panel9.BackColor = Color.Gold
        Panel1.BackColor = Color.Red
        Panel2.BackColor = Color.Gold
        Panel3.BackColor = Color.Gold
        Panel8.BackColor = Color.Gold
        Panel10.BackColor = Color.Gold
        Panel11.BackColor = Color.Gold
        AbrirForm(Of Form_Producto)()
    End Sub

    Private Sub btn_AdminCateg_Click(sender As Object, e As EventArgs) Handles btn_AdminCateg.Click
        PanMul.Visible = False
        Panel15.BackColor = Color.Gold
        Panel9.BackColor = Color.Gold
        Panel1.BackColor = Color.Gold
        Panel2.BackColor = Color.Red
        Panel3.BackColor = Color.Gold
        Panel8.BackColor = Color.Gold
        Panel10.BackColor = Color.Gold
        Panel11.BackColor = Color.Gold
        AbrirForm(Of Form_Categoria)()
    End Sub

    Private Sub btn_AdminProv_Click(sender As Object, e As EventArgs) Handles btn_AdminProv.Click
        PanMul.Visible = False
        Panel15.BackColor = Color.Gold
        Panel9.BackColor = Color.Gold
        Panel1.BackColor = Color.Gold
        Panel2.BackColor = Color.Gold
        Panel3.BackColor = Color.Red
        Panel8.BackColor = Color.Gold
        Panel10.BackColor = Color.Gold
        Panel11.BackColor = Color.Gold
        AbrirForm(Of Form_Proveedor)()
    End Sub

    Private Sub btn_Inv_Click(sender As Object, e As EventArgs) Handles btn_Inv.Click
        PanMul.Visible = False
        Panel15.BackColor = Color.Gold
        Panel9.BackColor = Color.Gold
        Panel1.BackColor = Color.Gold
        Panel2.BackColor = Color.Gold
        Panel3.BackColor = Color.Gold
        Panel8.BackColor = Color.Gold
        Panel10.BackColor = Color.Gold
        Panel11.BackColor = Color.Red
        AbrirForm(Of Form_Inventario)()
    End Sub

    Private Sub btn_CerrarSesion_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("¿Desea Cerrar Sesión?", "Cerrando Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Form_Login.txt_Pass.Text = "Ingrese aqui su contraseña..."
            Form_Login.txt_Pass.PasswordChar = ""
            Form_Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_Compras_Click(sender As Object, e As EventArgs) Handles btn_Compras.Click
        PanMul.Visible = False
        Panel9.BackColor = Color.Gold
        Panel1.BackColor = Color.Gold
        Panel2.BackColor = Color.Gold
        Panel3.BackColor = Color.Gold
        Panel8.BackColor = Color.Gold
        Panel10.BackColor = Color.Red
        Panel15.BackColor = Color.Gold
        Panel11.BackColor = Color.Gold
        AbrirForm(Of Form_Compras)()
    End Sub

    Private Sub btn_Usuarios_Click(sender As Object, e As EventArgs) Handles btn_Usuarios.Click
        PanMul.Visible = False
        Panel15.BackColor = Color.Gold
        Panel9.BackColor = Color.Red
        Panel1.BackColor = Color.Gold
        Panel2.BackColor = Color.Gold
        Panel3.BackColor = Color.Gold
        Panel8.BackColor = Color.Gold
        Panel10.BackColor = Color.Gold
        Panel11.BackColor = Color.Gold
        AbrirForm(Of Form_UsuarioNuevo)()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("¿Desea Cerrar Sesión?", "Cerrando Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Form_Login.txt_Pass.Text = "Ingrese aqui su contraseña..."
            Form_Login.txt_Pass.PasswordChar = ""
            Form_Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_RepAdmin_Click(sender As Object, e As EventArgs) Handles btn_RepAdmin.Click
        PanMul.Visible = False
        Panel9.BackColor = Color.Gold
        Panel15.BackColor = Color.Gold
        Panel1.BackColor = Color.Gold
        Panel2.BackColor = Color.Gold
        Panel3.BackColor = Color.Gold
        Panel8.BackColor = Color.Red
        Panel10.BackColor = Color.Gold
        Panel11.BackColor = Color.Gold
        AbrirForm(Of Form_Reportes)()
    End Sub

    Private Sub btn_reporte_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click
        Panel7.BackColor = Color.Gold
        Panel6.BackColor = Color.Gold
        Panel5.BackColor = Color.Green
        Panel16.BackColor = Color.Gold
        AbrirForm(Of Form_RptVenta)()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PanMul.Visible = False
        Panel15.BackColor = Color.Gold
        Panel9.BackColor = Color.Gold
        Panel1.BackColor = Color.Red
        Panel2.BackColor = Color.Gold
        Panel3.BackColor = Color.Gold
        Panel8.BackColor = Color.Gold
        Panel10.BackColor = Color.Gold
        Panel11.BackColor = Color.Gold
        AbrirForm(Of Form_Producto)()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PanMul.Visible = False
        Panel15.BackColor = Color.Gold
        Panel9.BackColor = Color.Gold
        Panel1.BackColor = Color.Gold
        Panel2.BackColor = Color.Red
        Panel3.BackColor = Color.Gold
        Panel8.BackColor = Color.Gold
        Panel10.BackColor = Color.Gold
        Panel11.BackColor = Color.Gold
        AbrirForm(Of Form_Categoria)()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PanMul.Visible = False
        Panel15.BackColor = Color.Gold
        Panel9.BackColor = Color.Gold
        Panel1.BackColor = Color.Gold
        Panel2.BackColor = Color.Gold
        Panel3.BackColor = Color.Red
        Panel8.BackColor = Color.Gold
        Panel10.BackColor = Color.Gold
        Panel11.BackColor = Color.Gold
        Panel15.BackColor = Color.Gold
        AbrirForm(Of Form_Proveedor)()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnInicio.Click
        PanMul.Visible = True
        PanMul.BringToFront()
        Panel15.BackColor = Color.Red
        Panel9.BackColor = Color.Gold
        Panel1.BackColor = Color.Gold
        Panel2.BackColor = Color.Gold
        Panel3.BackColor = Color.Gold
        Panel8.BackColor = Color.Gold
        Panel10.BackColor = Color.Gold
        Panel11.BackColor = Color.Gold
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnInicioVend.Click
        Panel7.BackColor = Color.Gold
        Panel6.BackColor = Color.Gold
        Panel5.BackColor = Color.Gold
        Panel16.BackColor = Color.Green
        PanMul.Visible = True
        PanMul.BringToFront()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(64, 64, 64))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    Private Sub AbrirForm(Of Formu As {Form, New})()
        Dim formulario As Form
        formulario = panelFormularios.Controls.OfType(Of Formu)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New Formu()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            panelFormularios.Controls.Add(formulario)
            panelFormularios.Tag = formulario
            formulario.Show()
        Else
            formulario.BringToFront()
        End If
    End Sub
End Class