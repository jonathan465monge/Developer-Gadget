Public Class Usser
    Private nombre_ As String
    Private apellido_ As String
    Private dui_ As String
    Private direccion_ As String
    Private telefono_ As String
    Private nameUser_ As String
    Private pass_ As String
    Private acceso_ As String
    Private correo_ As String

    Public Property Nombre() As String
        Get
            Return nombre_
        End Get
        Set(value As String)
            nombre_ = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return apellido_
        End Get
        Set(value As String)
            apellido_ = value
        End Set
    End Property

    Public Property Dui() As String
        Get
            Return dui_
        End Get
        Set(value As String)
            dui_ = value
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

    Public Property Telefono() As String
        Get
            Return telefono_
        End Get
        Set(value As String)
            telefono_ = value
        End Set
    End Property

    Public Property Nombreuser() As String
        Get
            Return nameUser_
        End Get
        Set(value As String)
            nameUser_ = value
        End Set
    End Property

    Public Property Pass() As String
        Get
            Return pass_
        End Get
        Set(value As String)
            pass_ = value
        End Set
    End Property

    Public Property Acceso() As String
        Get
            Return acceso_
        End Get
        Set(value As String)
            acceso_ = value
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
End Class
