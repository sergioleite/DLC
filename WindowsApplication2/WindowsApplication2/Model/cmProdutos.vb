Imports System.Data.SqlClient

Public Class cmProdutos
    Public Shared Function GetProdutos_OrderByCategoria() As Collection
        Dim produtos As New Collection

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader



        cmd.CommandText = "dbo.adml_get_produtos"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        reader = cmd.ExecuteReader()

        Dim p As cmProduto
        Dim idProduto As Int16

        On Error Resume Next

        While reader.Read()
            idProduto = reader.GetSqlInt32(reader.GetOrdinal("ID"))

            p = New cmProduto()
            p.ID = reader.GetSqlInt32(reader.GetOrdinal("ID"))
            p.Descricao_HTML = reader.GetString(reader.GetOrdinal("WEBVIEW_DESCRICAO_PRODUTO"))
            p.Fabricante = reader.GetString(reader.GetOrdinal("FABRICANTE"))
            p.Nome = reader.GetString(reader.GetOrdinal("NOME"))
            p.ParcelasQtde = reader.GetInt32(reader.GetOrdinal("PARCELAS_QTDE"))
            p.PrecoNormal = reader.GetDecimal(reader.GetOrdinal("PRECO_NORMAL"))
            p.PrecoPromocional = reader.GetDecimal(reader.GetOrdinal("PRECO_PROMOCIONAL"))
            p.Referencia = reader.GetDecimal(reader.GetOrdinal("REFERENCIA"))
            p.Is_EmPromocao = reader.GetBoolean(reader.GetOrdinal("ESTA_EM_PROMOCAO"))
            p.Categoria = New cmCategoria()
            p.Categoria.ID = reader.GetSqlInt32(reader.GetOrdinal("CATEGORIA__ID"))
            p.Categoria.Nome = reader.GetString(reader.GetOrdinal("CATEGORIA_NOME"))

            produtos.Add(p)
        End While

        reader.Close()
        sqlConnection1.Close()

        On Error GoTo 0

        Return produtos

    End Function
End Class
