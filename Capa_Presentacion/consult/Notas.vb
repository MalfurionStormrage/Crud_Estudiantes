Public Class Notas

    Inherits Conexion

    Public Function GetIdNotas(descripcion As String)
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

    Public Sub setNotas(id_e As Integer, id_m As String, nota1 As Integer, nota2 As Integer, nota3 As Integer)
        Try
            'iniciar conexion db'
            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            'se realiza la conexion sql'
            sqlComand.Connection = connectionString
            sqlComand.CommandText = "OCGN_Proce_InsertarNotas"
            sqlComand.CommandType = CommandType.StoredProcedure
            sqlComand.Parameters.Add("@ID_E", Convert.ToInt32(id_e))
            sqlComand.Parameters.Add("@ID_M", id_m)
            sqlComand.Parameters.Add("@Nota1", nota1)
            sqlComand.Parameters.Add("@Nota2", nota2)
            sqlComand.Parameters.Add("@Nota3", nota3)
            sqlComand.ExecuteNonQuery()
            sqlComand.Parameters.Clear()
            connectionString.Close()

        Catch ex As Exception
            MsgBox("Error en la consulta sql, causa: " + ex.ToString())
        End Try
    End Sub

    Public Sub updatenotas(id_e As Integer, id_m As String, nota1 As Integer, nota2 As Integer, nota3 As Integer)
        Try
            'iniciar conexion db'
            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            'se realiza la conexion sql'
            sqlComand.Connection = connectionString
            sqlComand.CommandText = "UPDATE notas SET ID_M = '" & id_m & "', Nota1 = '" & nota1 & "', Nota2 = '" & nota2 & "' , Nota3 = '" & nota3 & "' where ID_E = '" & id_e & "'"
            sqlComand.CommandType = CommandType.Text
            sqlComand.ExecuteNonQuery()
            connectionString.Close()

        Catch ex As Exception
            MsgBox("Error en la consulta sql, causa: " + ex.ToString())
        End Try
    End Sub


    Public Function obtenerNotaPorIdDeEstudiante(id_estudiante As String)

        Dim tabla As New DataTable()

        Try

            'Iniciar conexion'
            If (connectionString.State.ToString() = "Closed") Then
                connectionString.Open()
            End If

            'realizar la consulta sql'
            sqlComand.Connection = connectionString
            sqlComand.CommandText = "OCGN_Proce_Obtener_Notas_Por_Id_De_Estudiantes"
            sqlComand.CommandType = CommandType.StoredProcedure
            sqlComand.Parameters.Add("@id", id_estudiante)
            Dim resultado = sqlComand.ExecuteReader()
            tabla.Load(resultado)
            connectionString.Close()

        Catch ex As Exception
            MsgBox("Error en la consulta, casusa: " + ex.ToString())
        End Try

        Return tabla

    End Function

End Class
