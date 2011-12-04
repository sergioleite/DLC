Imports System.Data.SqlClient

Public Class cmTamanhos

    Public Shared Function GetTamanhosDisponiveis_ProdutoCor(ByVal modelo_id As Int16) As Collection
        Dim tamanhos As New Collection

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        Try

            cmd.CommandText = "dbo.get_tamanhosdisponiveis"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@MODELO__ID", modelo_id)
            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            reader = cmd.ExecuteReader()

            Dim t As cmTamanho

            While reader.Read()
                t = New cmTamanho( _
                    reader.GetSqlInt32(reader.GetOrdinal("TAMANHO__ID")), _
                    reader.GetSqlString(reader.GetOrdinal("NOME")), _
                    reader.GetSqlString(reader.GetOrdinal("WEBVIEW_URL_AMIGAVEL")) _
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

    Public Shared Function GetTamanhoByURLAmigavel(ByVal URLAmigavel As String) As cmTamanho

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        Dim t As cmTamanho

        Try

            cmd.CommandText = "dbo.get_tamanho_por_urlamigavel"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@URLAmigavel", URLAmigavel)
            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            reader = cmd.ExecuteReader()

            If reader.Read() Then
                t = New cmTamanho( _
                    reader.GetSqlInt32(reader.GetOrdinal("ID")), _
                    reader.GetSqlString(reader.GetOrdinal("NOME")), _
                    reader.GetSqlString(reader.GetOrdinal("WEBVIEW_URL_AMIGAVEL")) _
                )

            End If

            reader.Close()

        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try

        Return t

    End Function

    
End Class
