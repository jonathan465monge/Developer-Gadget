<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InformeVentas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DatosRepor = New SistemaDeVentas.DatosRepor()
        Me.ReporteVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteVentaTableAdapter = New SistemaDeVentas.DatosReporTableAdapters.ReporteVentaTableAdapter()
        Me.TableAdapterManager = New SistemaDeVentas.DatosReporTableAdapters.TableAdapterManager()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DatosRepor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SistemaDeVentas.DatosReporTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ReporteVentaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaDeVentas.ReVentas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'InformeVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "InformeVentas"
        Me.Text = "RDLCVentasTotales"
        CType(Me.DatosRepor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DatosRepor As DatosRepor
    Friend WithEvents ReporteVentaBindingSource As BindingSource
    Friend WithEvents ReporteVentaTableAdapter As DatosReporTableAdapters.ReporteVentaTableAdapter
    Friend WithEvents TableAdapterManager As DatosReporTableAdapters.TableAdapterManager
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
