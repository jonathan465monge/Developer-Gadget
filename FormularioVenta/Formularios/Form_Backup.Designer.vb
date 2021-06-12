<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Backup
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Backup))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pnlRestaurar = New System.Windows.Forms.Panel()
        Me.txtBaseRestaurar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnRutaRestaurar = New System.Windows.Forms.Button()
        Me.txtRutaRestaurar = New System.Windows.Forms.TextBox()
        Me.pnlCopia = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRutaGuardar = New System.Windows.Forms.TextBox()
        Me.btnRutaGuardar = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBaseDatos = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlRestaurar.SuspendLayout()
        Me.pnlCopia.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 29)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Copias de Seguridad"
        '
        'SaveFileDialog1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pnlRestaurar
        '
        Me.pnlRestaurar.Controls.Add(Me.txtBaseRestaurar)
        Me.pnlRestaurar.Controls.Add(Me.Label1)
        Me.pnlRestaurar.Controls.Add(Me.Label4)
        Me.pnlRestaurar.Controls.Add(Me.btnRestaurar)
        Me.pnlRestaurar.Controls.Add(Me.btnRutaRestaurar)
        Me.pnlRestaurar.Controls.Add(Me.txtRutaRestaurar)
        Me.pnlRestaurar.Location = New System.Drawing.Point(31, 267)
        Me.pnlRestaurar.Name = "pnlRestaurar"
        Me.pnlRestaurar.Size = New System.Drawing.Size(782, 146)
        Me.pnlRestaurar.TabIndex = 49
        '
        'txtBaseRestaurar
        '
        Me.txtBaseRestaurar.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseRestaurar.Location = New System.Drawing.Point(300, 56)
        Me.txtBaseRestaurar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBaseRestaurar.Name = "txtBaseRestaurar"
        Me.txtBaseRestaurar.Size = New System.Drawing.Size(465, 35)
        Me.txtBaseRestaurar.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 29)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Ruta restaurar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(287, 29)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Base de datos a restaurar"
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Location = New System.Drawing.Point(300, 97)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(188, 44)
        Me.btnRestaurar.TabIndex = 50
        Me.btnRestaurar.Text = "Restaurar"
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'btnRutaRestaurar
        '
        Me.btnRutaRestaurar.Image = CType(resources.GetObject("btnRutaRestaurar.Image"), System.Drawing.Image)
        Me.btnRutaRestaurar.Location = New System.Drawing.Point(667, 5)
        Me.btnRutaRestaurar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRutaRestaurar.Name = "btnRutaRestaurar"
        Me.btnRutaRestaurar.Size = New System.Drawing.Size(98, 40)
        Me.btnRutaRestaurar.TabIndex = 48
        Me.btnRutaRestaurar.Text = "Ruta"
        Me.btnRutaRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRutaRestaurar.UseVisualStyleBackColor = True
        '
        'txtRutaRestaurar
        '
        Me.txtRutaRestaurar.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaRestaurar.Location = New System.Drawing.Point(180, 5)
        Me.txtRutaRestaurar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRutaRestaurar.Name = "txtRutaRestaurar"
        Me.txtRutaRestaurar.Size = New System.Drawing.Size(465, 35)
        Me.txtRutaRestaurar.TabIndex = 49
        '
        'pnlCopia
        '
        Me.pnlCopia.Controls.Add(Me.Label3)
        Me.pnlCopia.Controls.Add(Me.cboBaseDatos)
        Me.pnlCopia.Controls.Add(Me.txtRutaGuardar)
        Me.pnlCopia.Controls.Add(Me.Label5)
        Me.pnlCopia.Controls.Add(Me.btnRutaGuardar)
        Me.pnlCopia.Controls.Add(Me.btnConectar)
        Me.pnlCopia.Controls.Add(Me.btnBackup)
        Me.pnlCopia.Location = New System.Drawing.Point(31, 55)
        Me.pnlCopia.Name = "pnlCopia"
        Me.pnlCopia.Size = New System.Drawing.Size(782, 160)
        Me.pnlCopia.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 29)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Ruta guardar"
        '
        'txtRutaGuardar
        '
        Me.txtRutaGuardar.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaGuardar.Location = New System.Drawing.Point(180, 66)
        Me.txtRutaGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRutaGuardar.Name = "txtRutaGuardar"
        Me.txtRutaGuardar.Size = New System.Drawing.Size(465, 35)
        Me.txtRutaGuardar.TabIndex = 56
        '
        'btnRutaGuardar
        '
        Me.btnRutaGuardar.Image = CType(resources.GetObject("btnRutaGuardar.Image"), System.Drawing.Image)
        Me.btnRutaGuardar.Location = New System.Drawing.Point(667, 13)
        Me.btnRutaGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRutaGuardar.Name = "btnRutaGuardar"
        Me.btnRutaGuardar.Size = New System.Drawing.Size(98, 40)
        Me.btnRutaGuardar.TabIndex = 55
        Me.btnRutaGuardar.Text = "Ruta"
        Me.btnRutaGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRutaGuardar.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(310, 111)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(188, 44)
        Me.btnBackup.TabIndex = 54
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(487, 12)
        Me.btnConectar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(135, 43)
        Me.btnConectar.TabIndex = 53
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 29)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Base de datos"
        '
        'cboBaseDatos
        '
        Me.cboBaseDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaseDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBaseDatos.FormattingEnabled = True
        Me.cboBaseDatos.Location = New System.Drawing.Point(180, 13)
        Me.cboBaseDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboBaseDatos.Name = "cboBaseDatos"
        Me.cboBaseDatos.Size = New System.Drawing.Size(285, 37)
        Me.cboBaseDatos.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(262, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(351, 29)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Restaruar Copias de Seguridad"
        '
        'Form_Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 436)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnlCopia)
        Me.Controls.Add(Me.pnlRestaurar)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form_Backup"
        Me.Text = "Form_Backup"
        Me.pnlRestaurar.ResumeLayout(False)
        Me.pnlRestaurar.PerformLayout()
        Me.pnlCopia.ResumeLayout(False)
        Me.pnlCopia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pnlRestaurar As Panel
    Friend WithEvents txtBaseRestaurar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnRutaRestaurar As Button
    Friend WithEvents txtRutaRestaurar As TextBox
    Friend WithEvents pnlCopia As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cboBaseDatos As ComboBox
    Friend WithEvents txtRutaGuardar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRutaGuardar As Button
    Friend WithEvents btnConectar As Button
    Friend WithEvents btnBackup As Button
    Friend WithEvents Label6 As Label
End Class
