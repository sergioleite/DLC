Imports System.Data.SqlClient

Public Class cmProduto
    Public BackgroundImageUrl As String
    Public Href As String 'produto_cores.PRODUTO_COR__WEBVIEW_URL_AMIGAVEL
    Public Title As String 'produtos_cores.PRODUTO_COR__NOME
    Public PrecoNormal As Double 'produtos.PRODUTO__PRECO_NORMAL
    Public PrecoPromocional As Double 'produtos.PRODUTO__PRECO_PROMOCIONAL
    Public ParcelasQtde As Int16 'produtos.PRODUTO__PARCELAS_QTDE
    Public ParcelaValor As Double 'DINAMICO
    Public Codigo As Int16 'DB-> produtos_cores.produto_cor__id


    Public Function isEmPromocao() As Boolean
        Dim bReturn As Boolean

        If Me.PrecoPromocional <> 0.0 Then
            bReturn = True
        End If

        Return bReturn

    End Function

    Public Function isFreteGratis() As Boolean
        Dim bReturn As Boolean

        If Not isEmPromocao() Then
            bReturn = True
        End If

        Return bReturn

    End Function

    Public Function NomeProdutoURL() As String
        Return Title.Replace(" ", "-")
    End Function

    'Public Sub New(ByRef dr As SqlDataReader)
    '    Me.Codigo = dr.GetInt32(dr.GetOrdinal("PRODUTO__ID"))
    '    Me.Title = dr.GetString(dr.GetOrdinal("CATEGORIA__NOME"))
    '    Me.Href = dr.GetString(dr.GetOrdinal("CATEGORIA_WEBVIEW_URL_AMIGAVEL"))
    'End Sub

    Public Sub New(ByRef CodigoProduto As Int16)

        Me.Codigo = CodigoProduto

        Dim sql As String
        sql = " SELECT        PRODUTOS.PRODUTO__PRECO_NORMAL, PRODUTOS.PRODUTO__PRECO_PROMOCIONAL, PRODUTOS.PRODUTO__PARCELAS_QTDE, " & _
                " PRODUTOS_CORES.PRODUTO_COR__WEBVIEW_URL_AMIGAVEL, PRODUTOS_CORES.PRODUTO_COR__NOME, PRODUTOS_CORES.PRODUTO_COR__ID, " & _
        " PRODUTOS_CORES_IMAGENS.PRODUTO_COR_IMAGEM__NOMEARQUIVO " & _
" FROM            PRODUTOS INNER JOIN" & _
                         " PRODUTOS_CORES ON PRODUTOS.PRODUTO__ID = PRODUTOS_CORES.PRODUTO__ID INNER JOIN " & _
                         " PRODUTOS_CORES_IMAGENS ON PRODUTOS_CORES.PRODUTO_COR__ID = PRODUTOS_CORES_IMAGENS.PRODUTO_COR__ID " & _
" WHERE        (PRODUTOS_CORES.PRODUTO_COR__ID = @1) AND (PRODUTOS_CORES_IMAGENS.PRODUTO_COR_IMAGEM__PERSPECTIVA = 1) AND  " & _
                         " (PRODUTOS_CORES_IMAGENS.PRODUTO_COR_IMAGEM__TAMANHO = 'P') "

        sql = sql.Replace("@1", Me.Codigo)

        Dim con As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand(sql, con)

        cmd.Connection.Open()

        Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        If dr.Read() Then

            Me.BackgroundImageUrl = dr.GetString(dr.GetOrdinal("PRODUTO_COR_IMAGEM__NOMEARQUIVO"))
            Me.Href = dr.GetString(dr.GetOrdinal("PRODUTO_COR__WEBVIEW_URL_AMIGAVEL"))
            Me.Title = dr.GetString(dr.GetOrdinal("PRODUTO_COR__NOME"))
            Me.PrecoNormal = dr.GetSqlMoney(dr.GetOrdinal("PRODUTO__PRECO_NORMAL"))
            Me.PrecoPromocional = dr.GetSqlMoney(dr.GetOrdinal("PRODUTO__PRECO_PROMOCIONAL"))
            Me.ParcelasQtde = dr.GetSqlInt32(dr.GetOrdinal("PRODUTO__PARCELAS_QTDE"))
            If (PrecoPromocional <> 0) Then
                ParcelaValor = Me.PrecoPromocional / Me.ParcelasQtde
            Else
                ParcelaValor = Me.PrecoNormal / Me.ParcelasQtde
            End If

        End If

        dr.Close()
        con.Close()

    End Sub
End Class
