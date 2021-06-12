Imports System.IO
Public Class Form_Backup
    Public usu As String
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub btnConectar_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnRutaGuardar_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub
    Private Sub btnRutaRestaurar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form_Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usu = "admid" Then
            pnlCopia.Enabled = True
            pnlRestaurar.Visible = True
        ElseIf usu = "vendedor" Then
            pnlCopia.Enabled = True
            pnlRestaurar.Visible = False
        End If
    End Sub

    Private Sub btnConectar_Click_1(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim conString As String = "data source=(local);initial catalog=SysLibreria;integrated security=true"

        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = conString

        conexion.Open()

        Dim cmd As New SqlClient.SqlCommand("SELECT name from sys.databases", conexion)
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            For Each fila In ds.Tables(0).Rows
                cboBaseDatos.Items.Add(fila(0).ToString)
            Next

            cboBaseDatos.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnRutaGuardar_Click_1(sender As Object, e As EventArgs) Handles btnRutaGuardar.Click
        SaveFileDialog1.Filter = "SQL Backup files|*.bak"
        SaveFileDialog1.FileName = cboBaseDatos.Text & "-" & Today.Date.ToString("dd-MM-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ".bak"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtRutaGuardar.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub btnBackup_Click_1(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            'Verifica que exista la carpeta, en caso contrario la crea
            If Not Directory.Exists("C:\Backup") Then
                Directory.CreateDirectory("C:\Backup")
            End If

            Process.Start("cmd", "/k" & "sqlcmd -S localhost\SQLEXPRESS -E -Q ""BACKUP DATABASE [" & cboBaseDatos.Text & "] TO DISK='" & txtRutaGuardar.Text & "'""")

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub btnRutaRestaurar_Click_1(sender As Object, e As EventArgs) Handles btnRutaRestaurar.Click
        OpenFileDialog1.Filter = "SQL Backup Files|*.bak"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtRutaRestaurar.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnRestaurar_Click_1(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Process.Start("cmd", "/k" & "Sqlcmd -S localhost\SQLEXPRESS -E -Q ""RESTORE DATABASE [" & txtBaseRestaurar.Text & "] FROM DISK = '" & txtRutaRestaurar.Text & "'""")

    End Sub
End Class