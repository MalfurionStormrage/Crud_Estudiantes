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

    Public Sub updataEstudiante(id_Es, Nombre, Edad, Carrera, Usuario_Edita)
        Try

            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            sqlComand.Connection = connectionString
            sqlComand.CommandText = "UPDATE estudiantes SET Nombre='" & Nombre & "' , Edad ='" & Edad & "' , Carrera = '" & Carrera & "' , Usuario_Modificacion = '" & Usuario_Edita & "' , F_Modificacion = '" & (Date.Today()) & "' where ID_E = '" & id_Es & "'"
            sqlComand.CommandType = CommandType.Text
            sqlComand.ExecuteNonQuery()

            connectionString.Close()
        Catch ex As Exception
            MsgBox("Error en la accion sql , causa: " + ex.ToString())
        End Try
    End Sub


    Public Sub deleteEstudiante(id As String)
        Try

            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            sqlComand.Connection = connectionString
            sqlComand.CommandText = "DELETE FROM notas WHERE ID_E = '" & id & "'"
            sqlComand.CommandType = CommandType.Text
            sqlComand.ExecuteNonQuery()

            sqlComand.CommandText = "DELETE FROM estudiantes WHERE ID_E = '" & id & "'"
            sqlComand.ExecuteNonQuery()

            connectionString.Close()
        Catch ex As Exception

            MsgBox("Error en la consulta sql, causa: " + ex.ToString())
        End Try
    End Sub

End Class
