<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Producto
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
        Me.labelFlag = New System.Windows.Forms.Label()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.panelBuscarProduct = New System.Windows.Forms.Panel()
        Me.btn_desact = New System.Windows.Forms.Button()
        Me.btn_Activar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.labelFlag2 = New System.Windows.Forms.Label()
        Me.panelBajoProd = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtEstad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dataproductos = New System.Windows.Forms.DataGridView()
        Me.panelBuscarProduct.SuspendLayout()
        Me.panelBajoProd.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelFlag
        '
        Me.labelFlag.AutoSize = True
        Me.labelFlag.Location = New System.Drawing.Point(2, 2)
        Me.labelFlag.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelFlag.Name = "labelFlag"
        Me.labelFlag.Size = New System.Drawing.Size(13, 13)
        Me.labelFlag.TabIndex = 1
        Me.labelFlag.Text = "0"
        Me.labelFlag.Visible = False
        '
        'btneditar
        '
        Me.btneditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btneditar.Location = New System.Drawing.Point(519, 20)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(75, 23)
        Me.btneditar.TabIndex = 6
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.Location = New System.Drawing.Point(438, 20)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 4
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(427, 266)
        Me.inexistente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(94, 13)
        Me.inexistente.TabIndex = 26
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        Me.inexistente.Visible = False
        '
        'panelBuscarProduct
        '
        Me.panelBuscarProduct.Controls.Add(Me.btn_desact)
        Me.panelBuscarProduct.Controls.Add(Me.btn_Activar)
        Me.panelBuscarProduct.Controls.Add(Me.Label8)
        Me.panelBuscarProduct.Controls.Add(Me.txtbuscar)
        Me.panelBuscarProduct.Controls.Add(Me.cbocampo)
        Me.panelBuscarProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBuscarProduct.Location = New System.Drawing.Point(2, 15)
        Me.panelBuscarProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.panelBuscarProduct.Name = "panelBuscarProduct"
        Me.panelBuscarProduct.Size = New System.Drawing.Size(994, 38)
        Me.panelBuscarProduct.TabIndex = 25
        '
        'btn_desact
        '
        Me.btn_desact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_desact.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_desact.Location = New System.Drawing.Point(910, 3)
        Me.btn_desact.Name = "btn_desact"
        Me.btn_desact.Size = New System.Drawing.Size(81, 32)
        Me.btn_desact.TabIndex = 32
        Me.btn_desact.Text = "Desactivar"
        Me.btn_desact.UseVisualStyleBackColor = False
        Me.btn_desact.Visible = False
        '
        'btn_Activar
        '
        Me.btn_Activar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Activar.Location = New System.Drawing.Point(910, 3)
        Me.btn_Activar.Name = "btn_Activar"
        Me.btn_Activar.Size = New System.Drawing.Size(81, 32)
        Me.btn_Activar.TabIndex = 31
        Me.btn_Activar.Text = "Activar"
        Me.btn_Activar.UseVisualStyleBackColor = True
        Me.btn_Activar.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(3, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Buscar por:"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(196, 10)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(190, 20)
        Me.txtbuscar.TabIndex = 0
        Me.txtbuscar.TabStop = False
        '
        'cbocampo
        '
        Me.cbocampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"NombreProducto", "Categoria", "Proveedor"})
        Me.cbocampo.Location = New System.Drawing.Point(70, 10)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(121, 21)
        Me.cbocampo.TabIndex = 12
        '
        'labelFlag2
        '
        Me.labelFlag2.AutoSize = True
        Me.labelFlag2.Location = New System.Drawing.Point(19, 2)
        Me.labelFlag2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelFlag2.Name = "labelFlag2"
        Me.labelFlag2.Size = New System.Drawing.Size(13, 13)
        Me.labelFlag2.TabIndex = 8
        Me.labelFlag2.Text = "0"
        Me.labelFlag2.Visible = False
        '
        'panelBajoProd
        '
        Me.panelBajoProd.Controls.Add(Me.Button1)
        Me.panelBajoProd.Controls.Add(Me.txtEstad)
        Me.panelBajoProd.Controls.Add(Me.labelFlag2)
        Me.panelBajoProd.Controls.Add(Me.btnnuevo)
        Me.panelBajoProd.Controls.Add(Me.btneditar)
        Me.panelBajoProd.Controls.Add(Me.labelFlag)
        Me.panelBajoProd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBajoProd.Location = New System.Drawing.Point(0, 489)
        Me.panelBajoProd.Margin = New System.Windows.Forms.Padding(2)
        Me.panelBajoProd.Name = "panelBajoProd"
        Me.panelBajoProd.Size = New System.Drawing.Size(998, 53)
        Me.panelBajoProd.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(357, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Refresh"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtEstad
        '
        Me.txtEstad.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtEstad.Location = New System.Drawing.Point(894, 32)
        Me.txtEstad.Name = "txtEstad"
        Me.txtEstad.ReadOnly = True
        Me.txtEstad.Size = New System.Drawing.Size(100, 20)
        Me.txtEstad.TabIndex = 33
        Me.txtEstad.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.inexistente)
        Me.GroupBox1.Controls.Add(Me.dataproductos)
        Me.GroupBox1.Controls.Add(Me.panelBuscarProduct)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(998, 489)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Productos"
        '
        'dataproductos
        '
        Me.dataproductos.AllowUserToAddRows = False
        Me.dataproductos.AllowUserToDeleteRows = False
        Me.dataproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataproductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataproductos.Location = New System.Drawing.Point(2, 53)
        Me.dataproductos.Margin = New System.Windows.Forms.Padding(2)
        Me.dataproductos.Name = "dataproductos"
        Me.dataproductos.ReadOnly = True
        Me.dataproductos.RowHeadersVisible = False
        Me.dataproductos.RowTemplate.Height = 24
        Me.dataproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataproductos.Size = New System.Drawing.Size(994, 434)
        Me.dataproductos.TabIndex = 26
        '
        'Form_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(998, 542)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panelBajoProd)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_Producto"
        Me.Text = "Prod"
        Me.panelBuscarProduct.ResumeLayout(False)
        Me.panelBuscarProduct.PerformLayout()
        Me.panelBajoProd.ResumeLayout(False)
        Me.panelBajoProd.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents labelFlag As Label
    Friend WithEvents btneditar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents panelBuscarProduct As Panel
    Friend WithEvents labelFlag2 As Label
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents btn_desact As Button
    Friend WithEvents btn_Activar As Button
    Friend WithEvents panelBajoProd As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dataproductos As DataGridView
    Friend WithEvents txtEstad As TextBox
    Friend WithEvents Button1 As Button
End Class
