Public Class Carreras

    Inherits Conexion

    Public Function obtenerIdCarrerasPorDescripcion(des As String)
        Dim tabla As New DataTable()
        Try
            'Iniciar conexion db'
            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            'consulta sql'
            sqlComand.Connection = connectionString
            sqlComand.CommandText = "OCGN_Proce_ObtenerIdCarrerasPorDescripcion"
            sqlComand.CommandType = CommandType.StoredProcedure
            sqlComand.Parameters.Add("@des", des)
            Dim resultado = sqlComand.ExecuteReader()
            tabla.Load(resultado)
            connectionString.Close()

            'retornar tabla con datos'
        Catch ex As Exception
            MsgBox("Error en la consulta, casusa: " + ex.ToString())
        End Try

        Return tabla

    End Function

    Public Function ObtenerDesCarreras()
        Dim tabla As New DataTable()
        Try
            'Iniciar conexion db'
            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            'consulta sql'
            sqlComand.Connection = connectionString
            sqlComand.CommandText = "OCGN_Proce_ObtenerDesCarreras"
            sqlComand.CommandType = CommandType.StoredProcedure
            Dim resultado = sqlComand.ExecuteReader()
            tabla.Load(resultado)
            connectionString.Close()

            'retornar tabla con datos'
        Catch ex As Exception
            MsgBox("Error en la consulta, casusa: " + ex.ToString())
        End Try

        Return tabla

    End Function

    Public Function ObtenerIdCarreras()
        Dim tabla As New DataTable()
        Try
            'Iniciar conexion db'
            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            'consulta sql'
            sqlComand.Connection = connectionString
            sqlComand.CommandText = "OCGN_Proce_ObtenerIdCarrerasPorDescripcion"
            sqlComand.CommandType = CommandType.StoredProcedure
            Dim resultado = sqlComand.ExecuteReader()
            tabla.Load(resultado)
            connectionString.Close()

            'retornar tabla con datos'
        Catch ex As Exception
            MsgBox("Error en la consulta, casusa: " + ex.ToString())
        End Try

        Return tabla

    End Function
End Class
