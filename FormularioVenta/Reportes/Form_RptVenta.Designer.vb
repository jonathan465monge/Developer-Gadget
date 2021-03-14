<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_RptVenta
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtVentaId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dataListaVentas = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dataListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 74)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Imprimir Boleta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(6, 31)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(110, 22)
        Me.txtFecha.TabIndex = 1
        Me.txtFecha.Visible = False
        '
        'txtVentaId
        '
        Me.txtVentaId.Location = New System.Drawing.Point(6, 3)
        Me.txtVentaId.Name = "txtVentaId"
        Me.txtVentaId.Size = New System.Drawing.Size(110, 22)
        Me.txtVentaId.TabIndex = 0
        Me.txtVentaId.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dataListaVentas)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 653)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Historial de Boletas"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtVentaId)
        Me.Panel1.Controls.Add(Me.txtFecha)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(363, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(119, 632)
        Me.Panel1.TabIndex = 3
        '
        'dataListaVentas
        '
        Me.dataListaVentas.AllowUserToAddRows = False
        Me.dataListaVentas.AllowUserToDeleteRows = False
        Me.dataListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListaVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataListaVentas.Location = New System.Drawing.Point(3, 18)
        Me.dataListaVentas.Name = "dataListaVentas"
        Me.dataListaVentas.ReadOnly = True
        Me.dataListaVentas.RowTemplate.Height = 24
        Me.dataListaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListaVentas.Size = New System.Drawing.Size(360, 632)
        Me.dataListaVentas.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(485, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(660, 653)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte de Ventas"
        '
        'Form_RptVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 653)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_RptVenta"
        Me.Text = "Form_RptVenta"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dataListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtVentaId As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dataListaVentas As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
End Class
