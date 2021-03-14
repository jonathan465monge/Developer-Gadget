Imports System.Data.SqlClient
Imports iTextSharp.text

Public Class FVenta
    Inherits conexion
    Dim comando As New SqlCommand

    Function Idventa() As String
        Dim resultado As String = ""
        Try
            conectado()
            Dim consulta As String = "SELECT TOP 1 VentaId FROM Venta ORDER BY VentaId DESC "
            comando = New SqlCommand(consulta, cnn)
            Dim respuesta As SqlDataReader
            respuesta = comando.ExecuteReader
            If respuesta.Read Then
                resultado = respuesta.Item("ventaId")
            Else
                resultado = False
            End If
            respuesta.Close()
        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
        Return resultado
    End Function

    Public Function mostrarVentaHistorial() As DataTable
        Try
            conectado()
            comando = New SqlCommand("mostrar_Venta")
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

    Public Function insertarVenta(deta As List(Of DetalleVenta)) As Integer
        Dim id As Integer
        Try
            conectado()
            comando = New SqlCommand("insertar_Venta")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn
            comando.ExecuteNonQuery()
            'obtener el ultimo la compra registrada
            Dim Sql As String = "SELECT Max(VentaId) FROM Venta"
            comando = New SqlCommand(Sql, cnn)
            id = CInt(comando.ExecuteScalar())
            'ingresar detalle venta---------------------------------------------------------------------------------
            Dim dts = New List(Of DetalleVenta)
            'pasando los datos del grid al objeto
            For Each item In deta
                comando = New SqlCommand("insertar_DetalleVentaSinDoc")
                comando.CommandType = CommandType.StoredProcedure
                comando.Connection = cnn
                comando.Parameters.AddWithValue("@cantidad", item.Cantidad)
                comando.Parameters.AddWithValue("@precio_venta", item.Precio)
                comando.Parameters.AddWithValue("@productoid", item.ProductoId)
                comando.Parameters.AddWithValue("@ventaid", id)
                Try
                    comando.ExecuteNonQuery()


                Catch ex As Exception
                    MsgBox(ex.Message)

                Finally
                    desconectado()
                End Try

            Next
            '------------------------------------------------------------------------------------------------------

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
        Return id
    End Function


    '--------------------------------------------------------------------------------------------------------------------------------------
End Class