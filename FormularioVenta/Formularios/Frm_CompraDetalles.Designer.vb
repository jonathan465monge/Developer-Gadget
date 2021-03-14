<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CompraDetalles
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dataDetallesCompra = New System.Windows.Forms.DataGridView()
        Me.txtCodigoCompra = New System.Windows.Forms.TextBox()
        Me.txtEstadoCompra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dataDetallesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 45)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 496)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(535, 50)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dataDetallesCompra)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(535, 451)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtEstadoCompra)
        Me.Panel4.Controls.Add(Me.txtCodigoCompra)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(535, 40)
        Me.Panel4.TabIndex = 0
        '
        'dataDetallesCompra
        '
        Me.dataDetallesCompra.AllowUserToAddRows = False
        Me.dataDetallesCompra.AllowUserToDeleteRows = False
        Me.dataDetallesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataDetallesCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataDetallesCompra.Location = New System.Drawing.Point(0, 40)
        Me.dataDetallesCompra.Name = "dataDetallesCompra"
        Me.dataDetallesCompra.ReadOnly = True
        Me.dataDetallesCompra.RowTemplate.Height = 24
        Me.dataDetallesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataDetallesCompra.Size = New System.Drawing.Size(535, 411)
        Me.dataDetallesCompra.TabIndex = 1
        '
        'txtCodigoCompra
        '
        Me.txtCodigoCompra.Location = New System.Drawing.Point(166, 9)
        Me.txtCodigoCompra.Name = "txtCodigoCompra"
        Me.txtCodigoCompra.ReadOnly = True
        Me.txtCodigoCompra.Size = New System.Drawing.Size(100, 22)
        Me.txtCodigoCompra.TabIndex = 0
        '
        'txtEstadoCompra
        '
        Me.txtEstadoCompra.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoCompra.Location = New System.Drawing.Point(388, 7)
        Me.txtEstadoCompra.Name = "txtEstadoCompra"
        Me.txtEstadoCompra.ReadOnly = True
        Me.txtEstadoCompra.Size = New System.Drawing.Size(135, 27)
        Me.txtEstadoCompra.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo de la Compra: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Estado: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Detalles de la Compra: "
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.SistemaDeVentas.My.Resources.Resources.iconox
        Me.Button1.Location = New System.Drawing.Point(478, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_CompraDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 546)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_CompraDetalles"
        Me.Text = "Frm_Compra"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dataDetallesCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dataDetallesCompra As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEstadoCompra As TextBox
    Friend WithEvents txtCodigoCompra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
