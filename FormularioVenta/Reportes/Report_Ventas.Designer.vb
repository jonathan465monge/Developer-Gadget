<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report_Venta
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
        Me.components = New System.ComponentModel.Container()
        Me.btnTotalVentas = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMos = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnIm = New System.Windows.Forms.Button()
        Me.DatosRepor = New SistemaDeVentas.DatosRepor()
        Me.ReporteVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteVentaTableAdapter = New SistemaDeVentas.DatosReporTableAdapters.ReporteVentaTableAdapter()
        Me.dgVentaTotal = New System.Windows.Forms.DataGridView()
        Me.ReporteVentasXFechasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteVentasXFechasTableAdapter = New SistemaDeVentas.DatosReporTableAdapters.ReporteVentasXFechasTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DatosRepor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVentaTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteVentasXFechasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTotalVentas
        '
        Me.btnTotalVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalVentas.Location = New System.Drawing.Point(307, 49)
        Me.btnTotalVentas.Name = "btnTotalVentas"
        Me.btnTotalVentas.Size = New System.Drawing.Size(133, 39)
        Me.btnTotalVentas.TabIndex = 1
        Me.btnTotalVentas.Text = "Monstrar"
        Me.btnTotalVentas.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(872, 149)
        Me.TabControl1.TabIndex = 2
        Me.TabControl1.Tag = ""
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.dtpFecha)
        Me.TabPage1.Controls.Add(Me.btnImprimir)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnTotalVentas)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(864, 114)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ventas Realizadas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(46, 62)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(157, 28)
        Me.dtpFecha.TabIndex = 4
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(581, 49)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(133, 39)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        Me.btnImprimir.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Reporte de las ventas realizadas"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.btnMos)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dtpHasta)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.dtpDesde)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(864, 114)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ventas Realizadas entre Fechas"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(652, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 38)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btnMos
        '
        Me.btnMos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMos.Location = New System.Drawing.Point(518, 54)
        Me.btnMos.Name = "btnMos"
        Me.btnMos.Size = New System.Drawing.Size(106, 38)
        Me.btnMos.TabIndex = 8
        Me.btnMos.Text = "Mostrar"
        Me.btnMos.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(260, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(345, 58)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(140, 28)
        Me.dtpHasta.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Desde:"
        '
        'dtpDesde
        '
        Me.dtpDesde.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(99, 58)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(140, 28)
        Me.dtpDesde.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Reportes de ventas por fechas"
        '
        'btnIm
        '
        Me.btnIm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIm.Location = New System.Drawing.Point(648, 54)
        Me.btnIm.Name = "btnIm"
        Me.btnIm.Size = New System.Drawing.Size(108, 38)
        Me.btnIm.TabIndex = 1
        Me.btnIm.Text = "Imprimir"
        Me.btnIm.UseVisualStyleBackColor = True
        '
        'DatosRepor
        '
        Me.DatosRepor.DataSetName = "DatosRepor"
        Me.DatosRepor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporteVentaBindingSource
        '
        Me.ReporteVentaBindingSource.DataMember = "ReporteVenta"
        Me.ReporteVentaBindingSource.DataSource = Me.DatosRepor
        '
        'ReporteVentaTableAdapter
        '
        Me.ReporteVentaTableAdapter.ClearBeforeFill = True
        '
        'dgVentaTotal
        '
        Me.dgVentaTotal.AllowUserToAddRows = False
        Me.dgVentaTotal.AllowUserToDeleteRows = False
        Me.dgVentaTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgVentaTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentaTotal.Location = New System.Drawing.Point(8, 157)
        Me.dgVentaTotal.Name = "dgVentaTotal"
        Me.dgVentaTotal.ReadOnly = True
        Me.dgVentaTotal.RowHeadersWidth = 62
        Me.dgVentaTotal.RowTemplate.Height = 28
        Me.dgVentaTotal.Size = New System.Drawing.Size(862, 306)
        Me.dgVentaTotal.TabIndex = 3
        '
        'ReporteVentasXFechasBindingSource
        '
        Me.ReporteVentasXFechasBindingSource.DataMember = "ReporteVentasXFechas"
        Me.ReporteVentasXFechasBindingSource.DataSource = Me.DatosRepor
        '
        'ReporteVentasXFechasTableAdapter
        '
        Me.ReporteVentasXFechasTableAdapter.ClearBeforeFill = True
        '
        'Report_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 492)
        Me.Controls.Add(Me.dgVentaTotal)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Report_Venta"
        Me.Text = "Repot_Compra"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DatosRepor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVentaTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteVentasXFechasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTotalVentas As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnImprimir As Button
    Friend WithEvents DatosRepor As DatosRepor
    Friend WithEvents ReporteVentaBindingSource As BindingSource
    Friend WithEvents ReporteVentaTableAdapter As DatosReporTableAdapters.ReporteVentaTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnMos As Button
    Friend WithEvents btnIm As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgVentaTotal As DataGridView
    Friend WithEvents ReporteVentasXFechasBindingSource As BindingSource
    Friend WithEvents ReporteVentasXFechasTableAdapter As DatosReporTableAdapters.ReporteVentasXFechasTableAdapter
End Class
