Public Class Proveedor
    Private id_ As Integer
    Private nombre_, direccion_, telefono_, correo_ As String

    Public Property ProveedorId() As Integer
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

    Public Property Direccion() As String
        Get
            Return direccion_
        End Get
        Set(value As String)
            direccion_ = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return telefono_
        End Get
        Set(value As String)
            telefono_ = value
        End Set
    End Property

    Public Property Correo() As String
        Get
            Return correo_
        End Get
        Set(value As String)
            correo_ = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(provid As Integer, nombre_ As String, direccion_ As String, telefono_ As String, correo_ As String)
        ProveedorId() = provid
        Nombre() = nombre_
        Direccion() = direccion_
        Telefono() = telefono_
        Correo() = correo_
    End Sub
End Class
