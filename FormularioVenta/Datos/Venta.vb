Public Class Venta
    Private id_ As Integer
    Private fecha_ As Date

    Public Property VentaId() As Integer
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

    Public Sub New()

    End Sub

    Public Sub New(id_ As Integer, fecha_ As Date)
        VentaId() = id_
        Fecha() = fecha_
    End Sub

End Class