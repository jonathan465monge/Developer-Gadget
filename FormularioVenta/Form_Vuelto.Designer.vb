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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCambio = New System.Windows.Forms.TextBox()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.txtPagar = New System.Windows.Forms.TextBox()
        Me.lblCambio = New System.Windows.Forms.Label()
        Me.btnRealizarVenta = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 35)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRealizarVenta)
        Me.Panel2.Controls.Add(Me.lblCambio)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtCambio)
        Me.Panel2.Controls.Add(Me.txtPago)
        Me.Panel2.Controls.Add(Me.txtPagar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(343, 259)
        Me.Panel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cambio: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Paga con: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total a pagar: "
        '
        'txtCambio
        '
        Me.txtCambio.Location = New System.Drawing.Point(17, 137)
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.ReadOnly = True
        Me.txtCambio.Size = New System.Drawing.Size(314, 22)
        Me.txtCambio.TabIndex = 2
        Me.txtCambio.Text = "0"
        '
        'txtPago
        '
        Me.txtPago.Location = New System.Drawing.Point(17, 84)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(314, 22)
        Me.txtPago.TabIndex = 1
        '
        'txtPagar
        '
        Me.txtPagar.Location = New System.Drawing.Point(17, 31)
        Me.txtPagar.Name = "txtPagar"
        Me.txtPagar.ReadOnly = True
        Me.txtPagar.Size = New System.Drawing.Size(314, 22)
        Me.txtPagar.TabIndex = 0
        '
        'lblCambio
        '
        Me.lblCambio.AutoSize = True
        Me.lblCambio.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambio.Location = New System.Drawing.Point(12, 162)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(94, 25)
        Me.lblCambio.TabIndex = 6
        Me.lblCambio.Text = "Cambio: "
        Me.lblCambio.Visible = False
        '
        'btnRealizarVenta
        '
        Me.btnRealizarVenta.Enabled = False
        Me.btnRealizarVenta.Location = New System.Drawing.Point(78, 207)
        Me.btnRealizarVenta.Name = "btnRealizarVenta"
        Me.btnRealizarVenta.Size = New System.Drawing.Size(170, 40)
        Me.btnRealizarVenta.TabIndex = 7
        Me.btnRealizarVenta.Text = "Confirmar Venta"
        Me.btnRealizarVenta.UseVisualStyleBackColor = True
        '
        'Form_Vuelto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 294)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
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
