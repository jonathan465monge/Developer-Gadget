<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Categoria
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
        Me.btn_Activ = New System.Windows.Forms.Button()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.Inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.btn_Desact = New System.Windows.Forms.Button()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtcategoriaid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txt_Estado = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelCateg = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelCateg.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Activ
        '
        Me.btn_Activ.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Activ.Location = New System.Drawing.Point(827, 13)
        Me.btn_Activ.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Activ.Name = "btn_Activ"
        Me.btn_Activ.Size = New System.Drawing.Size(100, 28)
        Me.btn_Activ.TabIndex = 13
        Me.btn_Activ.Text = "Activar"
        Me.btn_Activ.UseVisualStyleBackColor = True
        '
        'cbocampo
        '
        Me.cbocampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"Nombre", "EstadoCategoria"})
        Me.cbocampo.Location = New System.Drawing.Point(125, 17)
        Me.cbocampo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(177, 24)
        Me.cbocampo.TabIndex = 12
        '
        'Inexistente
        '
        Me.Inexistente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Inexistente.AutoSize = True
        Me.Inexistente.Location = New System.Drawing.Point(380, 352)
        Me.Inexistente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Inexistente.Name = "Inexistente"
        Me.Inexistente.Size = New System.Drawing.Size(123, 17)
        Me.Inexistente.TabIndex = 10
        Me.Inexistente.TabStop = True
        Me.Inexistente.Text = "Datos Inexistentes"
        Me.Inexistente.Visible = False
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(310, 17)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(249, 22)
        Me.txtbuscar.TabIndex = 9
        '
        'btn_Desact
        '
        Me.btn_Desact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Desact.Location = New System.Drawing.Point(827, 13)
        Me.btn_Desact.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Desact.Name = "btn_Desact"
        Me.btn_Desact.Size = New System.Drawing.Size(100, 28)
        Me.btn_Desact.TabIndex = 8
        Me.btn_Desact.Text = "Desactivar"
        Me.btn_Desact.UseVisualStyleBackColor = True
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(3, 78)
        Me.datalistado.Margin = New System.Windows.Forms.Padding(4)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(937, 535)
        Me.datalistado.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(365, 617)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MANTENIMIENTO DE CATEGORIAS"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.txtcategoriaid)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtnombre)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btnnuevo)
        Me.Panel3.Controls.Add(Me.txt_Estado)
        Me.Panel3.Controls.Add(Me.btnguardar)
        Me.Panel3.Controls.Add(Me.btneditar)
        Me.Panel3.Controls.Add(Me.btncancelar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(4, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(357, 594)
        Me.Panel3.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 165)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de la Categoria (ID):"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(15, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'txtcategoriaid
        '
        Me.txtcategoriaid.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategoriaid.Location = New System.Drawing.Point(9, 193)
        Me.txtcategoriaid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcategoriaid.Name = "txtcategoriaid"
        Me.txtcategoriaid.ReadOnly = True
        Me.txtcategoriaid.Size = New System.Drawing.Size(344, 27)
        Me.txtcategoriaid.TabIndex = 2
        Me.txtcategoriaid.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 325)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Estado actual de la Categoria:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(9, 273)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(344, 27)
        Me.txtnombre.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 245)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nombre de la Categoria:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(17, 433)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(100, 28)
        Me.btnnuevo.TabIndex = 2
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'txt_Estado
        '
        Me.txt_Estado.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Estado.Location = New System.Drawing.Point(13, 353)
        Me.txt_Estado.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Estado.Name = "txt_Estado"
        Me.txt_Estado.ReadOnly = True
        Me.txt_Estado.Size = New System.Drawing.Size(340, 27)
        Me.txt_Estado.TabIndex = 9
        Me.txt_Estado.TabStop = False
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(127, 433)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(100, 28)
        Me.btnguardar.TabIndex = 3
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(127, 433)
        Me.btneditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(100, 28)
        Me.btneditar.TabIndex = 3
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(235, 433)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(100, 28)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelCateg)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1308, 617)
        Me.Panel1.TabIndex = 6
        '
        'PanelCateg
        '
        Me.PanelCateg.Controls.Add(Me.GroupBox3)
        Me.PanelCateg.Controls.Add(Me.GroupBox1)
        Me.PanelCateg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCateg.Location = New System.Drawing.Point(0, 0)
        Me.PanelCateg.Name = "PanelCateg"
        Me.PanelCateg.Size = New System.Drawing.Size(1308, 617)
        Me.PanelCateg.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Inexistente)
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.datalistado)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(365, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(943, 617)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LISTADO DE CATEGORIAS"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.btn_Activ)
        Me.Panel4.Controls.Add(Me.cbocampo)
        Me.Panel4.Controls.Add(Me.btn_Desact)
        Me.Panel4.Controls.Add(Me.txtbuscar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(937, 53)
        Me.Panel4.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Buscar por:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 617)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_Categoria"
        Me.Text = "Form_Categoria"
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PanelCateg.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents Inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btn_Desact As Button
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcategoriaid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_Estado As TextBox
    Friend WithEvents btn_Activ As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelCateg As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
End Class
