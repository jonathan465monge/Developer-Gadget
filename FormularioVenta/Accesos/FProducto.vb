Imports System.Data.SqlClient

Public Class FProducto
    Inherits conexion

    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_ProductoIMG")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar(dts As Producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_productoSinIMG")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", dts.DescripcionProducto)
            cmd.Parameters.AddWithValue("@precioCompra", dts.PrecioCompra)
            cmd.Parameters.AddWithValue("@margen", dts.Margen)
            cmd.Parameters.AddWithValue("@precioVenta", dts.PrecioVenta)
            cmd.Parameters.AddWithValue("@stock", dts.Stock)
            cmd.Parameters.AddWithValue("@categoriaid", dts.CategoriaId)
            cmd.Parameters.AddWithValue("@proveedorid", dts.ProveedorId)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try
    End Function

    Public Function insertarIMG(dts As Producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", dts.DescripcionProducto)
            cmd.Parameters.AddWithValue("@precioCompra", dts.PrecioCompra)
            cmd.Parameters.AddWithValue("@margen", dts.Margen)
            cmd.Parameters.AddWithValue("@precioVenta", dts.PrecioVenta)
            cmd.Parameters.AddWithValue("@stock", dts.Stock)
            cmd.Parameters.AddWithValue("@imagen", dts.ImagenProducto)
            cmd.Parameters.AddWithValue("@categoriaid", dts.CategoriaId)
            cmd.Parameters.AddWithValue("@proveedorid", dts.ProveedorId)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(dts As Producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@productoId", dts.ProductoId)
            cmd.Parameters.AddWithValue("@nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", dts.DescripcionProducto)
            cmd.Parameters.AddWithValue("@precioCompra", dts.PrecioCompra)
            cmd.Parameters.AddWithValue("@margen", dts.Margen)
            cmd.Parameters.AddWithValue("@precioVenta", dts.PrecioVenta)
            cmd.Parameters.AddWithValue("@stock", dts.Stock)
            cmd.Parameters.AddWithValue("@imagen", dts.ImagenProducto)
            cmd.Parameters.AddWithValue("@categoriaid", dts.CategoriaId)
            cmd.Parameters.AddWithValue("@proveedorid", dts.ProveedorId)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editarSinIMG(dts As Producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_productoSinIMG")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@productoId", dts.ProductoId)
            cmd.Parameters.AddWithValue("@nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", dts.DescripcionProducto)
            cmd.Parameters.AddWithValue("@precioCompra", dts.PrecioCompra)
            cmd.Parameters.AddWithValue("@margen", dts.Margen)
            cmd.Parameters.AddWithValue("@precioVenta", dts.PrecioVenta)
            cmd.Parameters.AddWithValue("@stock", dts.Stock)
            cmd.Parameters.AddWithValue("@categoriaid", dts.CategoriaId)
            cmd.Parameters.AddWithValue("@proveedorid", dts.ProveedorId)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function activar(dts As Producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("activar_Producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@productoId", SqlDbType.NVarChar, 50).Value = dts.ProductoId
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function desactivar(dts As Producto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("desactivar_Producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@productoId", SqlDbType.NVarChar, 50).Value = dts.ProductoId
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class