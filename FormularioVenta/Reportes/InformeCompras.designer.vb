<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeCompras
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DatosRepor = New SistemaDeVentas.DatosRepor()
        Me.ReporCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporCompraTableAdapter = New SistemaDeVentas.DatosReporTableAdapters.ReporCompraTableAdapter()
        CType(Me.DatosRepor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ReCompras"
        ReportDataSource1.Value = Me.ReporCompraBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaDeVentas.ReCompras.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DatosRepor
        '
        Me.DatosRepor.DataSetName = "DatosRepor"
        Me.DatosRepor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporCompraBindingSource
        '
        Me.ReporCompraBindingSource.DataMember = "ReporCompra"
        Me.ReporCompraBindingSource.DataSource = Me.DatosRepor
        '
        'ReporCompraTableAdapter
        '
        Me.ReporCompraTableAdapter.ClearBeforeFill = True
        '
        'InformeCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "InformeCompras"
        Me.Text = "InformeCompras"
        CType(Me.DatosRepor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporCompraBindingSource As BindingSource
    Friend WithEvents DatosRepor As DatosRepor
    Friend WithEvents ReporCompraTableAdapter As DatosReporTableAdapters.ReporCompraTableAdapter
End Class
