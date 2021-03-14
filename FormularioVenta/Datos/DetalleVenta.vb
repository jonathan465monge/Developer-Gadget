Public Class DetalleVenta
    Private id_ As Integer
    Private cantidad_ As Integer
    Private precio_ As Decimal
    Private doc_ As String
    Private prodId_ As Integer
    Private ventaId_ As Integer

    Public Property DetalleVentaId() As Integer
        Get
            Return id_
        End Get
        Set(value As Integer)
            id_ = value
        End Set
    End Property

    Public Property Cantidad() As Integer
        Get
            Return cantidad_
        End Get
        Set(value As Integer)
            cantidad_ = value
        End Set
    End Property

    Public Property Precio() As Decimal
        Get
            Return precio_
        End Get
        Set(value As Decimal)
            precio_ = value
        End Set
    End Property

    Public Property tipoDocumento() As String
        Get
            Return doc_
        End Get
        Set(value As String)
            doc_ = value
        End Set
    End Property

    Public Property ProductoId() As Integer
        Get
            Return prodId_
        End Get
        Set(value As Integer)
            prodId_ = value
        End Set
    End Property

    Public Property VentaId() As Integer
        Get
            Return ventaId_
        End Get
        Set(value As Integer)
            ventaId_ = value
        End Set
    End Property
End Class
