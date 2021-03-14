Imports System.Data.SqlClient

Public Class FDetalleOrdenCompra
    Inherits conexion

    Dim comando As New SqlCommand
    Public Function insertarDetalleOrden(ByVal dts As Detalle_Orden_compra) As Boolean
        Try
            conectado()
            comando = New SqlCommand("insertar_DetalleOrdComp")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn

            comando.Parameters.AddWithValue("@ordencompraid", dts.Orden_compraId)
            comando.Parameters.AddWithValue("@productoid", dts.ProductoId)
            comando.Parameters.AddWithValue("@cantidad", dts.Cantidad)
            comando.Parameters.AddWithValue("@precio", dts.Precio)

            If comando.ExecuteNonQuery Then
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

    Public Function mostrardetallesCompra(dts As Detalle_Orden_compra) As DataTable
        Try
            conectado()
            comando = New SqlCommand("mostrarDetalleCompraSeleccionado")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn
            comando.Parameters.AddWithValue("@id", dts.Orden_compraId)
            If comando.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comando)
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

    Public Function mostrarCompraRecien(ByVal dts As Detalle_Orden_compra) As DataTable
        Try
            conectado()
            comando = New SqlCommand("mostrarDetalleCompraRecien")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn
            comando.Parameters.AddWithValue("@id", dts.Orden_compraId)

            If comando.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comando)
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

    Public Function mostrarCompraHistorial() As DataTable
        Try
            conectado()
            comando = New SqlCommand("mostrarDetalleCompra2")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn

            If comando.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comando)
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

    Public Function editar(dts As Detalle_Orden_compra) As Boolean
        Try
            conectado()
            comando = New SqlCommand("editarCantidadDetalleCompraRecien")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn

            comando.Parameters.AddWithValue("@id", dts.DetalleCompraId)
            comando.Parameters.AddWithValue("@cantidad", dts.Cantidad)

            If comando.ExecuteNonQuery Then
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