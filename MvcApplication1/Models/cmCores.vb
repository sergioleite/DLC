Imports System.Data.SqlClient

Public Class cmCores

    Public Shared Function GetCorByURLAmigavel(ByVal URLAmigavel As String) As cmCor
        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        Dim c As cmCor

        Try

            cmd.CommandText = "dbo.get_cor_por_urlamigavel"
            cmd.Parameters.AddWithValue("@URLAmigavel", URLAmigavel)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            reader = cmd.ExecuteReader()

            If reader.Read() Then
                c = New cmCor( _
                    reader.GetSqlInt32(reader.GetOrdinal("ID")), _
                    reader.GetSqlString(reader.GetOrdinal("NOME")), _
                    reader.GetSqlString(reader.GetOrdinal("WEBVIEW_URL_AMIGAVEL")), _
                    reader.GetSqlString(reader.GetOrdinal("WEBVIEW_NOMEARQUIVO_AMOSTRA")) _
                 )

            End If

            reader.Close()
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try

        Return c

    End Function


    Public Shared Function GetCoresDisponiveis(ByVal MODELO_ID As Int16) As Collection
        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        Dim c As cmCor
        Dim cores As New Collection

        Try

            cmd.CommandText = "dbo.get_coresdisponiveis"
            cmd.Parameters.AddWithValue("@MODELO__ID", MODELO_ID)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            reader = cmd.ExecuteReader()

            If reader.Read() Then
                c = New cmCor( _
                    reader.GetSqlInt32(reader.GetOrdinal("ID")), _
                    reader.GetSqlString(reader.GetOrdinal("NOME")), _
                    reader.GetSqlString(reader.GetOrdinal("WEBVIEW_URL_AMIGAVEL")), _
                    reader.GetSqlString(reader.GetOrdinal("WEBVIEW_NOMEARQUIVO_AMOSTRA")) _
                 )
                cores.Add(c)
            End If

            reader.Close()
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try

        Return cores

    End Function

End Class
