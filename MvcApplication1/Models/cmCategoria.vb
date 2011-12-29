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
        Me.Produtos = New Collection()

        Me.Id = dr.GetInt32(dr.GetOrdinal("ID"))
        Me.Title = dr.GetString(dr.GetOrdinal("NOME"))
        Me.href = dr.GetString(dr.GetOrdinal("WEBVIEW_URL_AMIGAVEL"))
    End Sub

    'Public Function Produtos() As Collection
    '    If _Produtos.Count = 0 Then
    '        LoadProdutos()
    '    End If

    '    Return Me._Produtos
    'End Function

    'Public Function GetProdutos_ParaVitrine() As Collection
    '    Me.Produtos = cmProdutos.getProdutosPorCategoria(Me)
    '    Return Me.Produtos
    'End Function

    Private Sub LoadProdutos()

        'retorna os produtos desta categoria - apenas os que tenham estoque?
        Dim sql As New StringBuilder()

        sql.Append("SELECT        PRODUTOS_CORES.PRODUTO_COR__ID ")
        sql.Append(" FROM            PRODUTOS INNER JOIN ")
        sql.Append(" PRODUTOS_CORES ON PRODUTOS.PRODUTO__ID = PRODUTOS_CORES.PRODUTO__ID ")
        sql.Append(" WHERE        (PRODUTOS.CATEGORIA__ID = @1) AND PRODUTOS_CORES.PRODUTO_COR__LIBERADA_VENDA = 'S'")


        sql.Replace("@1", Me.Id)

        Dim con As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand(sql.ToString(), con)

        cmd.Connection.Open()

        Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Dim p As cmProduto

        While dr.Read()

            p = New cmProduto(dr.GetInt32(dr.GetOrdinal("PRODUTO_COR__ID")))
            Me.Produtos.Add(p)

        End While


            dr.Close()
            con.Close()

    End Sub


End Class
