Imports MvcApplication1.Produto
Imports System.Data.SqlClient

Public Class cmCategoria
    Public href As String
    Public Title As String
    Public Produtos As Collection
    Public Id As Int16

    Public Sub New()
        Me.Produtos = New Collection()

    End Sub

    Public Sub New(ByRef dr As SqlDataReader)
        Me.Id = dr.GetInt32(dr.GetOrdinal("CATEGORIA__ID"))
        Me.Title = dr.GetString(dr.GetOrdinal("CATEGORIA__NOME"))
        Me.href = dr.GetString(dr.GetOrdinal("CATEGORIA__WEBVIEW_URL_AMIGAVEL"))
    End Sub


    'Public Function GetProdutos_ParaVitrine() As Collection
    '    Me.Produtos = cmProdutos.getProdutosPorCategoria(Me)
    '    Return Me.Produtos
    'End Function

    Public Function GetProdutos() As Collection
        'retorna os produtos desta categoria - apenas os que tenham estoque?

        Me.Produtos = New Collection

        Dim sql As New StringBuilder()

        sql.Append("SELECT        PRODUTOS_CORES.PRODUTO_COR__ID ")
        sql.Append(" FROM            PRODUTOS INNER JOIN ")
        sql.Append(" PRODUTOS_CORES ON PRODUTOS.PRODUTO__ID = PRODUTOS_CORES.PRODUTO__ID ")
        sql.Append(" WHERE        (PRODUTOS.CATEGORIA__ID = @1)")

        sql.Replace("@1", Me.Id)

        Dim con As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand(sql.ToString(), con)

        cmd.Connection.Open()

        Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Dim p As cmProduto

        If dr.Read() Then

            p = New cmProduto(dr.GetInt32(dr.GetOrdinal("PRODUTO_COR__ID")))
            Me.Produtos.Add(p)

        End If


        dr.Close()
        con.Close()

        Return Me.Produtos
    End Function


End Class
