Imports System.Data.SqlClient

Public Class cmModelos
    Public Shared Function GetModelos_DeProduto(ByVal produto_id As Int16) As Collection
        Dim modelos As New Collection

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader



        cmd.CommandText = "dbo.adml_get_modelos_de_produto"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@produto__id", produto_id)
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        reader = cmd.ExecuteReader()

        Dim m As cmModelo

        On Error Resume Next

        While reader.Read()
            m = New cmModelo()
            m.Nome = reader.GetString(reader.GetOrdinal("NOME"))
            m.NomeCor = reader.GetString(reader.GetOrdinal("COR__NOME"))
            m.LiberadoVenda = reader.GetString(reader.GetOrdinal("LIBERADO_PARA_VENDA"))
            m.URL = reader.GetString(reader.GetOrdinal("WEBVIEW_URL_AMIGAVEL"))
            modelos.Add(m)
        End While

        reader.Close()
        sqlConnection1.Close()

        On Error GoTo 0

        Return modelos

    End Function
End Class
