Imports System.Data.SqlClient

Public Class FCategoria
    Inherits conexion

    Dim comando As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            comando = New SqlCommand("mostrar_categoria")
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

    Public Function insertar(dts As Categoria) As Boolean
        Try
            conectado()
            comando = New SqlCommand("insertar_categoria")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn

            comando.Parameters.AddWithValue("@nombrecateg", dts.Nombre)

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

    Public Function editar(dts As Categoria) As Boolean
        Try
            conectado()
            comando = New SqlCommand("editar_categoria")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn

            comando.Parameters.AddWithValue("@id", dts.CategoriaId)
            comando.Parameters.AddWithValue("@nombrecateg", dts.Nombre)

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

    Public Function desactivar(dts As Categoria) As Boolean
        Try
            conectado()
            comando = New SqlCommand("desactivar_Categoria")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn
            comando.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = dts.CategoriaId
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

    Public Function activar(dts As Categoria) As Boolean
        Try
            conectado()
            comando = New SqlCommand("activar_Categoria")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cnn
            comando.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = dts.CategoriaId
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