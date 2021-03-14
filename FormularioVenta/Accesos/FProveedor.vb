Imports System.Data.SqlClient

Public Class FProveedor
    Inherits conexion
    Dim cmd As New SqlCommand
    Dim respuesta As SqlDataReader

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_proveedor")
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

    Function Correo(dts As Proveedor) As String
        Dim resultado As String = ""
        Try
            conectado()
            Dim consulta As String = "Select CorreoProveedor From Proveedor Where ProveedorId = @correo"
            cmd = New SqlCommand(consulta, cnn)
            cmd.Parameters.AddWithValue("@correo", dts.ProveedorId)
            respuesta = cmd.ExecuteReader()
            If respuesta.Read Then
                resultado = respuesta.Item("CorreoProveedor")
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

    Public Function insertar(dts As Proveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@direccion", dts.Direccion)
            cmd.Parameters.AddWithValue("@telefono", dts.Telefono)
            cmd.Parameters.AddWithValue("@correo", dts.Correo)

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

    Public Function editar(dts As Proveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id", dts.ProveedorId)
            cmd.Parameters.AddWithValue("@nombre", dts.Nombre)
            cmd.Parameters.AddWithValue("@direccion", dts.Direccion)
            cmd.Parameters.AddWithValue("@telefono", dts.Telefono)
            cmd.Parameters.AddWithValue("@correo", dts.Correo)
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

    Public Function desactivar(dts As Proveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("desactivar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = dts.ProveedorId

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function activar(dts As Proveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("activar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = dts.ProveedorId

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class