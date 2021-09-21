Public Class Materias

    Inherits Conexion

    Public Function getDescripcionPorId(id As String)
        Try
            'iniciar conexion db'
            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            'consulta sql'
            sqlComand.Connection = connectionString
            sqlComand.CommandText = "select descripcion from materias where ID_M = '" & id & "'"
            sqlComand.CommandType = CommandType.Text

            Dim resultado = sqlComand.ExecuteReader()
            tabla.Load(resultado)
            connectionString.Close()

            'se retorna la tabla con datos'
            Return tabla

        Catch ex As Exception
            MsgBox("Error en la consulta, casusa: " + ex.ToString())
        End Try
    End Function

    Public Function GetIdMateria(descripcion As String)
        Try
            'iniciar conexion db'
            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            'consulta sql'
            sqlComand.Connection = connectionString
            sqlComand.CommandText = "OCGN_Proce_ObtenerIdMaterias"
            sqlComand.CommandType = CommandType.StoredProcedure
            sqlComand.Parameters.Add("@Des", descripcion)
            Dim resultado = sqlComand.ExecuteReader()
            tabla.Load(resultado)
            connectionString.Close()
            sqlComand.Parameters.Clear()

            'se retorna la tabla con datos'
            Return tabla

        Catch ex As Exception
            MsgBox("Error en la consulta, casusa: " + ex.ToString())
        End Try

    End Function

    Public Function GetDescripcionMaterias()
        Try
            'iniciar conexion db'
            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            'consulta sql'
            sqlComand.Connection = connectionString
            sqlComand.CommandText = "OCGN_Proce_ObtenerDesMaterias"
            sqlComand.CommandType = CommandType.StoredProcedure

            Dim resultado = sqlComand.ExecuteReader()
            tabla.Load(resultado)
            connectionString.Close()

            'se retorna la tabla con datos'
            Return tabla

        Catch ex As Exception
            MsgBox("Error en la consulta, casusa: " + ex.ToString())
        End Try

    End Function

End Class
