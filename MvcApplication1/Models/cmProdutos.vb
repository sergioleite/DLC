Imports System.Data.SqlClient

Public Class cmProdutos
    Public Shared Function GetProdutos_Categoria(ByVal CATEGORIA_ID As Int16) As Collection
        Dim produtos As New Collection

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        Try

            cmd.CommandText = "dbo.get_produtos_liberadosparavenda_categoriaunica"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CATEGORIA__ID", CATEGORIA_ID)
            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            reader = cmd.ExecuteReader()

            Dim p As cmProduto
            Dim idProduto As Int16

            While reader.Read()
                idProduto = reader.GetSqlInt32(reader.GetOrdinal("ID"))
                p = New cmProduto(idProduto)
                produtos.Add(p)
            End While

            reader.Close()
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try

        Return produtos

    End Function

    Public Shared Function GetProdutos_Categoria_Tamanho(ByVal CATEGORIA_ID As Int16, ByVal TAMANHO__WEBVIEW_URL_AMIGAVEL As String) As Collection
        Dim produtos As New Collection

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        Try

            cmd.CommandText = "dbo.get_produtos_liberadosparavenda_categoriaunica_tamanhounico"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CATEGORIA__ID", CATEGORIA_ID)
            cmd.Parameters.AddWithValue("@TAMANHO__WEBVIEW_URL_AMIGAVEL", TAMANHO__WEBVIEW_URL_AMIGAVEL)
            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            reader = cmd.ExecuteReader()

            Dim p As cmProduto
            Dim idProduto As Int16

            While reader.Read()
                idProduto = reader.GetSqlInt32(reader.GetOrdinal("ID"))
                p = New cmProduto(idProduto)
                produtos.Add(p)
            End While

            reader.Close()
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try

        Return produtos

    End Function

    Public Shared Function GetProdutos_Categoria_Cor(ByVal CATEGORIA_ID As Int16, ByVal COR__WEBVIEW_URL_AMIGAVEL As String) As Collection
        Dim produtos As New Collection

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        Try

            cmd.CommandText = "dbo.get_produtos_liberadosparavenda_categoriaunica_corunica"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CATEGORIA__ID", CATEGORIA_ID)
            cmd.Parameters.AddWithValue("@COR__WEBVIEW_URL_AMIGAVEL", COR__WEBVIEW_URL_AMIGAVEL)
            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            reader = cmd.ExecuteReader()

            Dim p As cmProduto
            Dim idProduto As Int16

            While reader.Read()
                idProduto = reader.GetSqlInt32(reader.GetOrdinal("ID"))
                p = New cmProduto(idProduto)
                produtos.Add(p)
            End While

            reader.Close()
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try

        Return produtos

    End Function

    Public Shared Function GetProdutos_Categoria_Cor_Tamanho(ByVal CATEGORIA_ID As Int16, ByVal TAMANHO__WEBVIEW_URL_AMIGAVEL As String, ByVal COR__WEBVIEW_URL_AMIGAVEL As String) As Collection
        Dim produtos As New Collection

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        Try

            cmd.CommandText = "dbo.get_produtos_liberadosparavenda_categoriaunica_tamanhounico_corunica"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CATEGORIA__ID", CATEGORIA_ID)
            cmd.Parameters.AddWithValue("@TAMANHO__WEBVIEW_URL_AMIGAVEL", TAMANHO__WEBVIEW_URL_AMIGAVEL)
            cmd.Parameters.AddWithValue("@COR__WEBVIEW_URL_AMIGAVEL", COR__WEBVIEW_URL_AMIGAVEL)
            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            reader = cmd.ExecuteReader()

            Dim p As cmProduto
            Dim idProduto As Int16

            While reader.Read()
                idProduto = reader.GetSqlInt32(reader.GetOrdinal("ID"))
                p = New cmProduto(idProduto)
                produtos.Add(p)
            End While

            reader.Close()
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try

        Return produtos

    End Function
End Class
