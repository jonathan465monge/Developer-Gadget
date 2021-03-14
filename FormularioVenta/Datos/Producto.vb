Public Class Producto
    Private id_ As Integer
    Private nombre_ As String
    Private descripcion_ As String
    Private precioCompra_ As Decimal
    Private margen_ As Decimal
    Private precioVenta_ As Decimal
    Private stock_ As Integer
    Private foto_ As Byte()
    Private estado_ As String
    Private categid_ As Integer
    Private proveeid_ As Integer

    Public Property ProductoId() As Integer
        Get
            Return id_
        End Get
        Set(value As Integer)
            id_ = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return nombre_
        End Get
        Set(value As String)
            nombre_ = value
        End Set
    End Property

    Public Property DescripcionProducto() As String
        Get
            Return descripcion_
        End Get
        Set(value As String)
            descripcion_ = value
        End Set
    End Property

    Public Property PrecioCompra() As Decimal
        Get
            Return precioCompra_
        End Get
        Set(value As Decimal)
            precioCompra_ = value
        End Set
    End Property

    Public Property Margen() As Decimal
        Get
            Return margen_
        End Get
        Set(value As Decimal)
            margen_ = value
        End Set
    End Property

    Public Property PrecioVenta() As Decimal
        Get
            Return precioVenta_
        End Get
        Set(value As Decimal)
            precioVenta_ = value
        End Set
    End Property

    Public Property Stock() As Integer
        Get
            Return stock_
        End Get
        Set(value As Integer)
            stock_ = value
        End Set
    End Property

    Public Property ImagenProducto() As Byte()
        Get
            Return foto_
        End Get
        Set(value As Byte())
            foto_ = value
        End Set
    End Property

    Public Property EstadoProducto() As String
        Get
            Return estado_
        End Get
        Set(value As String)
            estado_ = value
        End Set
    End Property

    Public Property CategoriaId() As Integer
        Get
            Return categid_
        End Get
        Set(value As Integer)
            categid_ = value
        End Set
    End Property

    Public Property ProveedorId() As Integer
        Get
            Return proveeid_
        End Get
        Set(value As Integer)
            proveeid_ = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id_ As Integer, nombre_ As String, costo_ As Decimal, margen_ As Decimal, categid As Integer, proveeid As Integer)
        ProductoId() = id_
        Nombre() = nombre_
        PrecioCompra() = costo_
        Margen() = margen_
        CategoriaId() = categid_
        ProveedorId() = proveeid_
    End Sub
End Class