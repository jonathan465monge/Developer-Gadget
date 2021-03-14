<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Vuelto
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
        Me.btnRealizarVenta = New System.Windows.Forms.Button()
        Me.lblCambio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCambio = New System.Windows.Forms.TextBox()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.txtPagar = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 28)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.btnRealizarVenta)
        Me.Panel2.Controls.Add(Me.lblCambio)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtCambio)
        Me.Panel2.Controls.Add(Me.txtPago)
        Me.Panel2.Controls.Add(Me.txtPagar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(257, 211)
        Me.Panel2.TabIndex = 1
        '
        'btnRealizarVenta
        '
        Me.btnRealizarVenta.BackColor = System.Drawing.Color.Blue
        Me.btnRealizarVenta.Enabled = False
        Me.btnRealizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRealizarVenta.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRealizarVenta.Location = New System.Drawing.Point(58, 168)
        Me.btnRealizarVenta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRealizarVenta.Name = "btnRealizarVenta"
        Me.btnRealizarVenta.Size = New System.Drawing.Size(128, 32)
        Me.btnRealizarVenta.TabIndex = 7
        Me.btnRealizarVenta.Text = "Confirmar Venta"
        Me.btnRealizarVenta.UseVisualStyleBackColor = False
        '
        'lblCambio
        '
        Me.lblCambio.AutoSize = True
        Me.lblCambio.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambio.Location = New System.Drawing.Point(9, 132)
        Me.lblCambio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(73, 20)
        Me.lblCambio.TabIndex = 6
        Me.lblCambio.Text = "Cambio: "
        Me.lblCambio.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cambio: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Paga con: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total a pagar: "
        '
        'txtCambio
        '
        Me.txtCambio.Location = New System.Drawing.Point(13, 111)
        Me.txtCambio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.ReadOnly = True
        Me.txtCambio.Size = New System.Drawing.Size(236, 20)
        Me.txtCambio.TabIndex = 2
        Me.txtCambio.Text = "0"
        '
        'txtPago
        '
        Me.txtPago.Location = New System.Drawing.Point(13, 68)
        Me.txtPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(236, 20)
        Me.txtPago.TabIndex = 1
        '
        'txtPagar
        '
        Me.txtPagar.Location = New System.Drawing.Point(13, 25)
        Me.txtPagar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPagar.Name = "txtPagar"
        Me.txtPagar.ReadOnly = True
        Me.txtPagar.Size = New System.Drawing.Size(236, 20)
        Me.txtPagar.TabIndex = 0
        '
        'Form_Vuelto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 239)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_Vuelto"
        Me.Text = "Form_Vuelto"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCambio As TextBox
    Friend WithEvents txtPago As TextBox
    Friend WithEvents txtPagar As TextBox
    Friend WithEvents lblCambio As Label
    Friend WithEvents btnRealizarVenta As Button
End Class
