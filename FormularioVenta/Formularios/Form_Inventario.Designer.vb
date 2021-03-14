<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Inventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.panelBuscarProduct = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_Stck = New System.Windows.Forms.TextBox()
        Me.txt_Estd = New System.Windows.Forms.TextBox()
        Me.LblVenta = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.dataproductos = New System.Windows.Forms.DataGridView()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.panelBuscarProduct.SuspendLayout()
        CType(Me.dataproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBuscarProduct
        '
        Me.panelBuscarProduct.Controls.Add(Me.Button1)
        Me.panelBuscarProduct.Controls.Add(Me.txt_Stck)
        Me.panelBuscarProduct.Controls.Add(Me.txt_Estd)
        Me.panelBuscarProduct.Controls.Add(Me.LblVenta)
        Me.panelBuscarProduct.Controls.Add(Me.Label8)
        Me.panelBuscarProduct.Controls.Add(Me.txtbuscar)
        Me.panelBuscarProduct.Controls.Add(Me.cbocampo)
        Me.panelBuscarProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBuscarProduct.Location = New System.Drawing.Point(0, 0)
        Me.panelBuscarProduct.Name = "panelBuscarProduct"
        Me.panelBuscarProduct.Size = New System.Drawing.Size(1357, 47)
        Me.panelBuscarProduct.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.Location = New System.Drawing.Point(1270, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Stck
        '
        Me.txt_Stck.Location = New System.Drawing.Point(835, 10)
        Me.txt_Stck.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Stck.Name = "txt_Stck"
        Me.txt_Stck.Size = New System.Drawing.Size(198, 22)
        Me.txt_Stck.TabIndex = 27
        Me.txt_Stck.TabStop = False
        Me.txt_Stck.Visible = False
        '
        'txt_Estd
        '
        Me.txt_Estd.Location = New System.Drawing.Point(620, 10)
        Me.txt_Estd.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Estd.Name = "txt_Estd"
        Me.txt_Estd.Size = New System.Drawing.Size(198, 22)
        Me.txt_Estd.TabIndex = 26
        Me.txt_Estd.TabStop = False
        Me.txt_Estd.Visible = False
        '
        'LblVenta
        '
        Me.LblVenta.AutoSize = True
        Me.LblVenta.Location = New System.Drawing.Point(531, 15)
        Me.LblVenta.Name = "LblVenta"
        Me.LblVenta.Size = New System.Drawing.Size(70, 17)
        Me.LblVenta.TabIndex = 25
        Me.LblVenta.Text = "inventario"
        Me.LblVenta.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 15)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Buscar por:"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(261, 12)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(252, 22)
        Me.txtbuscar.TabIndex = 0
        Me.txtbuscar.TabStop = False
        '
        'cbocampo
        '
        Me.cbocampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"NombreProducto", "Categoria", "Proveedor"})
        Me.cbocampo.Location = New System.Drawing.Point(93, 12)
        Me.cbocampo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(160, 24)
        Me.cbocampo.TabIndex = 12
        '
        'dataproductos
        '
        Me.dataproductos.AllowUserToAddRows = False
        Me.dataproductos.AllowUserToDeleteRows = False
        Me.dataproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataproductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataproductos.Location = New System.Drawing.Point(0, 47)
        Me.dataproductos.Name = "dataproductos"
        Me.dataproductos.ReadOnly = True
        Me.dataproductos.RowHeadersVisible = False
        Me.dataproductos.RowTemplate.Height = 24
        Me.dataproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataproductos.Size = New System.Drawing.Size(1357, 608)
        Me.dataproductos.TabIndex = 27
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(617, 319)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(123, 17)
        Me.inexistente.TabIndex = 28
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        Me.inexistente.Visible = False
        '
        'Form_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 655)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.dataproductos)
        Me.Controls.Add(Me.panelBuscarProduct)
        Me.Name = "Form_Inventario"
        Me.Text = "Form_Inventario"
        Me.panelBuscarProduct.ResumeLayout(False)
        Me.panelBuscarProduct.PerformLayout()
        CType(Me.dataproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelBuscarProduct As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents dataproductos As DataGridView
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents LblVenta As Label
    Friend WithEvents txt_Stck As TextBox
    Friend WithEvents txt_Estd As TextBox
    Friend WithEvents Button1 As Button
End Class
