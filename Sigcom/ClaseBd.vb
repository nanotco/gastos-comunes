Imports MySql.Data.MySqlClient
Public Class ClaseBd
    Dim CadConex = "server=localhost;user id=administrador;password=miclave;database=condominio"
    Public Conex As New MySqlConnection(CadConex)
    Public Comando As New MySqlCommand("", Conex)
    Public Rec As MySqlDataReader
    Public Sub AbrirConexion()
        If Conex.State = ConnectionState.Closed Then
            Conex.Open()
        End If
    End Sub
    Public Sub CerrarConexion()
        If Conex.State = ConnectionState.Open Then
            Conex.Close()
        End If
    End Sub
    Public Function EjecutarIUD(ByVal CadSql As String) As Integer
        Dim Resultado As Integer = 0
        Try
            AbrirConexion()
            Comando.CommandType = CommandType.Text
            Comando.CommandText = CadSql
            Resultado = Comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CerrarConexion()
        End Try
        Return (Resultado)
    End Function
    Public Function EjecutarConsulta(ByVal CadSql As String) As MySqlDataReader
        Try
            AbrirConexion()
            Comando.CommandType = CommandType.Text
            Comando.CommandText = CadSql
            Rec = Comando.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            Rec = Nothing
        End Try
        Return (Rec)
    End Function
End Class