Imports System.Data.SqlClient

Public Class FUsser
    Inherits conexion

    Dim comando As New SqlCommand
    Dim respuesta As SqlDataReader

    Function Usuario(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conectado()
            Dim consulta As String = "Select * from Usser where NombreUser = @nombreUsuario"
            comando = New SqlCommand(consulta, cnn)
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
            respuesta = comando.ExecuteReader
            If respuesta.Read Then
                resultado = True
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

    Function Contraseña(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            conectado()
            Dim consulta As String = "Select convert(varchar, Pass) As Pass From Usser Where NombreUser = @nombreUsuario"
            comando = New SqlCommand(consulta, cnn)
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
            respuesta = comando.ExecuteReader
            If respuesta.Read Then
                resultado = respuesta.Item("Pass")
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

    Function TipoUser(ByVal TipoUsuario As String) As String
        Dim resultado As String = ""
        Try
            conectado()
            Dim consulta As String = "Select Acceso from Usser where NombreUser = @nombreUsuario"
            comando = New SqlCommand(consulta, cnn)
            comando.Parameters.AddWithValue("@nombreUsuario", TipoUsuario)
            respuesta = comando.ExecuteReader
            If respuesta.Read Then
                resultado = respuesta.Item("Acceso")
            Else
                resultado = False
            End If
            Return resultado
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return resultado
        Finally
            desconectado()
        End Try
    End Function

    Function NombreUser(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            conectado()
            Dim consulta As String = "Select Nombre From Usser Where NombreUser = @nombreUsuario"
            comando = New SqlCommand(consulta, cnn)
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
            respuesta = comando.ExecuteReader
            If respuesta.Read Then
                resultado = respuesta.Item("Nombre")
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

    Function ApellidoUser(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            conectado()
            Dim consulta As String = "Select Apellido From Usser Where NombreUser = @nombreUsuario"
            comando = New SqlCommand(consulta, cnn)
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
            respuesta = comando.ExecuteReader
            If respuesta.Read Then
                resultado = respuesta.Item("Apellido")
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

    Function CorreoUser(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            conectado()
            Dim consulta As String = "Select Correo From Usser Where NombreUser = @nombreUsuario"
            comando = New SqlCommand(consulta, cnn)
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
            respuesta = comando.ExecuteReader
            If respuesta.Read Then
                resultado = respuesta.Item("Correo")
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

    Public Function insertUsser(dts As Usser) As Boolean
        Try
            conectado()
            Dim consulta As String = "insert into Usser values(@nombre, @apellido, @dui, @direccion, @telefono, @nameUser, convert(varbinary , @pass), @acceso, @correo)"
            comando = New SqlCommand(consulta, cnn)

            comando.Parameters.AddWithValue("@nombre", dts.Nombre)
            comando.Parameters.AddWithValue("@apellido", dts.Apellido)
            comando.Parameters.AddWithValue("@dui", dts.Dui)
            comando.Parameters.AddWithValue("direccion", dts.Direccion)
            comando.Parameters.AddWithValue("@telefono", dts.Telefono)
            comando.Parameters.AddWithValue("@nameUser", dts.Nombreuser)
            comando.Parameters.AddWithValue("@pass", dts.Pass)
            comando.Parameters.AddWithValue("@acceso", dts.Acceso)
            comando.Parameters.AddWithValue("@correo", dts.Correo)

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

    Public Function mostrar() As DataTable
        Try
            conectado()
            comando = New SqlCommand("ver_Usuarios")
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
End Class