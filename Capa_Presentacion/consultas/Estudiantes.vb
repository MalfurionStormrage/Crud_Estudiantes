Public Class Estudiantes
    Inherits Conexion

    Public Function getEstudiantes()
        Dim tabla As New DataTable()
        Try

            'Iniciar conexion'
            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            'realizar la consulta sql'
            sqlComand.Connection = connectionString
            sqlComand.CommandText = "OCGN_Porce_ObtenerEstudaintesConCarreras"
            'sqlComand.CommandText = "OCGN_Proce_ObtenerEstudiantes"
            sqlComand.CommandType = CommandType.Text
            Dim resultado = sqlComand.ExecuteReader()
            tabla.Load(resultado)
            connectionString.Close()

        Catch ex As Exception
            MsgBox("Error en la consulta, casusa: " + ex.ToString())
        End Try

        Return tabla

    End Function

    Public Function getEstudiantesPorFiltro(codigo As String)
        Dim tabla As New DataTable()
        Try

            'Iniciar conexion'
            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            'realizar la consulta sql'
            sqlComand.Connection = connectionString
            sqlComand.CommandText = "SELECT iD_E as identificacion , Nombre , Edad FROM estudiantes where carrera = '" & codigo & "'"
            'sqlComand.CommandText = "OCGN_Proce_ObtenerEstudiantes"
            sqlComand.CommandType = CommandType.Text
            Dim resultado = sqlComand.ExecuteReader()
            tabla.Load(resultado)
            sqlComand.Parameters.Clear()
            connectionString.Close()

        Catch ex As Exception
            MsgBox("Error en la consulta, casusa: " + ex.ToString())
        End Try

        Return tabla

    End Function

    Public Sub insertarEstudiante(id As String, nombre As String, edad As String, carrera As String, usuario As String)
        Try
            'Iniciar conexion db'
            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            'Consulta sql'
            sqlComand.Connection = connectionString
            sqlComand.CommandText = "ORGN_Proce_InsertarEstudiante"
            sqlComand.CommandType = CommandType.StoredProcedure
            sqlComand.Parameters.Add("@ID_E", id)
            sqlComand.Parameters.Add("@NOMBRE", nombre)
            sqlComand.Parameters.Add("@edad", edad)
            sqlComand.Parameters.Add("@carrera", carrera)
            sqlComand.Parameters.Add("@usuario", usuario)
            sqlComand.Parameters.Add("@fecha", Date.Now)
            sqlComand.ExecuteNonQuery()
            connectionString.Close() 'cerrar conexion'

        Catch ex As Exception
            MsgBox("Error en la consulta sql, causa: " + ex.ToString())
        End Try
    End Sub

End Class
