Imports System.Data.SqlClient

Public Class FDetalleVenta
    Inherits conexion
    Dim comando As New SqlCommand

    Public Function mostrarVenta() As DataTable
        Try
            conectado()
            comando = New SqlCommand("mostrar_detalleventa")
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

    Public Function masVendido() As DataTable
        Try
            conectado()
            comando = New SqlCommand("masVendido")
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

    Public Function mostrarVentaRecien(ByVal dts As DetalleVenta) As DataTable
        Try
            conectado()
            comando = New SqlCommand("mostrar_detalleventaRecien")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn
            comando.Parameters.AddWithValue("@idVenta", dts.VentaId)

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

    Public Function insertarDetalleVenta(ByVal dts As DetalleVenta) As Boolean
        Try
            conectado()
            comando = New SqlCommand("insertar_DetalleVentaSinDoc")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn

            comando.Parameters.AddWithValue("@cantidad", dts.Cantidad)
            comando.Parameters.AddWithValue("@precio_venta", dts.Precio)
            comando.Parameters.AddWithValue("@productoid", dts.ProductoId)
            comando.Parameters.AddWithValue("@ventaid", dts.VentaId)

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

    Public Function eliminarRegistroDetalle(ByVal dts As DetalleVenta) As Boolean
        Try
            conectado()
            comando = New SqlCommand("eliminar_detalleventa")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn
            comando.Parameters.Add("@detalle_ventaid", SqlDbType.NVarChar, 50).Value = dts.DetalleVentaId

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

    Public Function editar(dts As DetalleVenta) As Boolean
        Try
            conectado()
            comando = New SqlCommand("editarCantidadDetalleVentaRecien")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn

            comando.Parameters.AddWithValue("@id", dts.DetalleVentaId)
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
End Class