Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Forden_compra
    Inherits conexion

    Dim comando As New SqlCommand

    Public Function IdCompra() As String
        Dim resultado As String = ""
        Try
            conectado()
            Dim consulta As String = "SELECT TOP 1 CompraId FROM Compra ORDER BY CompraId DESC"
            Dim comando As New SqlCommand(consulta, cnn)
            Dim drd As SqlDataReader
            drd = comando.ExecuteReader()
            If drd.Read() Then
                resultado = drd.Item("CompraId").ToString()
            Else
                resultado = False
            End If
            drd.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()
        End Try
        Return resultado
    End Function

    Public Function mostrarEstado1() As DataTable
        Try
            conectado()
            comando = New SqlCommand("mostrar_OrdCompEstado1")
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

    Public Function HacerPedido(delt As orden_compra) As Boolean
        Try
            conectado()
            comando = New SqlCommand("insertar_OrdComp")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn
            comando.Parameters.AddWithValue("@ProveedorId", delt.ProveedorId)

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

    Public Function confirmarpedido(delt As orden_compra) As Boolean
        Try
            conectado()
            comando = New SqlCommand("editarOrdEst2")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn
            comando.Parameters.AddWithValue("@OrdenId", delt.OrdenId)

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

    Public Function cancelarpedido(delt As orden_compra) As Boolean
        Try
            conectado()
            comando = New SqlCommand("editarOrdEst3")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn
            comando.Parameters.AddWithValue("@OrdenId", delt.OrdenId)

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