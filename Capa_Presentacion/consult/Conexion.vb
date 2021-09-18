Imports System.Data.SqlClient
Imports System.Configuration

Public MustInherit Class Conexion

    'variables'
    Protected tabla As New DataTable()
    Protected sqlComand As New SqlCommand()
    'conexion db'
    Protected ReadOnly connectionString As New SqlConnection(ConfigurationManager.ConnectionStrings("StringConnectionDB").ToString())

End Class
