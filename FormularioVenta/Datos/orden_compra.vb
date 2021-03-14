Public Class orden_compra
    Private id_ As Integer
    Private fecha_ As Date
    Private estado_ As Integer
    Private proveedorid_ As Integer

    Public Property OrdenId() As Integer
        Get
            Return id_
        End Get
        Set(value As Integer)
            id_ = value

        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return fecha_
        End Get
        Set(value As Date)
            fecha_ = value

        End Set
    End Property
    Public Property Estado() As Integer
        Get
            Return estado_

        End Get
        Set(value As Integer)
            estado_ = value
        End Set
    End Property
    Public Property ProveedorId() As Integer
        Get
            Return proveedorid_
        End Get
        Set(value As Integer)
            proveedorid_ = value
        End Set
    End Property
End Class
