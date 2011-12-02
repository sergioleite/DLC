Imports System.Data.SqlClient

Public Class cmTamanhos

    Public Shared Function GetTamanhosDisponiveis_ProdutoCor(ByVal PRODUTO_COR__ID As Int16) As Collection
        Dim tamanhos As New Collection

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        Try

            cmd.CommandText = "dbo.get_tamanhosdisponiveis"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@PRODUTO_COR__ID", PRODUTO_COR__ID)
            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            reader = cmd.ExecuteReader()

            Dim t As cmTamanho

            While reader.Read()
                t = New cmTamanho( _
                    reader.GetSqlInt32(reader.GetOrdinal("TAMANHO__ID")), _
                    reader.GetSqlString(reader.GetOrdinal("TAMANHO__NOME")), _
                    reader.GetSqlString(reader.GetOrdinal("TAMANHO__WEBVIEW_URL_AMIGAVEL")) _
                )

                tamanhos.Add(t)

            End While

            reader.Close()
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try

        Return tamanhos

    End Function

    
End Class
