Imports System.Data.SqlClient

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

    Public Function insertarVenta() As Boolean
        Try
            conectado()
            comando = New SqlCommand("insertar_Venta")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn

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