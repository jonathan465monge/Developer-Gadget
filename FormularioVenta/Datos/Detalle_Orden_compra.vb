Public Class Detalle_Orden_compra
    Private id_ As Integer
    Private cantidad_ As Integer
    Private precio_ As Double
    Private ordencompraid_ As Integer
    Private productoid_ As Integer

    Public Property DetalleCompraId() As Integer
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

    Public Property Precio() As Double
        Get
            Return precio_
        End Get
        Set(value As Double)
            precio_ = value
        End Set
    End Property

    Public Property Orden_compraId() As Integer
        Get
            Return ordencompraid_
        End Get
        Set(value As Integer)
            ordencompraid_ = value
        End Set
    End Property

    Public Property ProductoId() As Integer
        Get
            Return productoid_
        End Get
        Set(value As Integer)
            productoid_ = value
        End Set
    End Property
End Class