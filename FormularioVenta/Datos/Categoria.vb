Public Class Categoria
    Private id_ As Integer
    Private nombre_ As String

    Public Property CategoriaId() As Integer
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

    Public Sub New()

    End Sub

    Public Sub New(id_ As Integer, nombre_ As String)
        CategoriaId() = nombre_
        Nombre() = nombre_
    End Sub
End Class