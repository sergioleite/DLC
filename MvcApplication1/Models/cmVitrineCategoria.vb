Public Class cmVitrineCategoria
    Public Categorias As Collection
    Public TamanhosDisponiveis As Collection
    Private Filtro As cmFiltro

    Const kFiltro_TodasCategorias As String = "todas-categorias"
    Const kFiltro_TodosTamanhos As String = "todos-tamanhos"
    Const kFiltro_TodasCores As String = "todas-cores"


    Public Sub New(ByVal categoria As String, ByVal tamanho As String, ByVal cor As String)

        Categorias = New Collection()

        'Registra os filtro utilizados na página
        Filtro = New cmFiltro(categoria, tamanho, cor)

        CriaCategorias()

#If CONFIG = "Simulacao 1" Then
        'Simula tamanhos disponíveis para o filtro selecionado
        TamanhosDisponiveis = New Collection
        TamanhosDisponiveis.Add(New cmTamanho("33"))
        TamanhosDisponiveis.Add(New cmTamanho("34"))
        TamanhosDisponiveis.Add(New cmTamanho("35"))
        TamanhosDisponiveis.Add(New cmTamanho("36"))
        TamanhosDisponiveis.Add(New cmTamanho("37"))
        TamanhosDisponiveis.Add(New cmTamanho("38"))
        TamanhosDisponiveis.Add(New cmTamanho("39"))
        'TamanhosDisponiveis.Add(New cmTamanho("40"))
#End If

    End Sub

    Private Sub CriaCategorias()
        Dim c As cmCategoria
        Dim p As cmProduto

        c = New cmCategoria
        'c.href = "tenis-de-corrida"
        c.href = "Scarpins"
        c.Title = "Scarpins"
        p = New cmProduto()
        'p.BackgroundImageUrl = "http://static.anitaonline.com.br/arquivos/chuteira-masculina-umbro-prime-cup-site_produtos-922831559_pequena.jpg"
        p.BackgroundImageUrl = "../../images/sapato-carmim-zenia-23009-site_produtos-1893985385_pequena.jpg"
        'p.Href = "http://www.anitaonline.com.br/scarpin-carmim-nude-pastel-118674"
        p.Href = "Produto1"
        p.Title = "Scarpin Carmim Nude"
        p.PrecoDe = 1
        p.PrecoPor = 1
        p.ParcelasQtde = 4
        p.ParcelaValor = 3
        c.Produtos.Add(p)
        c.Produtos.Add(p)
        c.Produtos.Add(p)
        c.Produtos.Add(p)
        c.Produtos.Add(p)
        c.Produtos.Add(p)
        c.Produtos.Add(p)
        c.Produtos.Add(p)
        Categorias.Add(c)

    End Sub


    Public Function HTML_TamanhosDisponiveis() As String
        Dim t As cmTamanho
        Dim html As New StringBuilder()

        For Each t In Me.TamanhosDisponiveis
            html.Append("<li><a href=")
            html.Append(PathTo_FiltroPorTamanho(t.ID))
            html.Append(">")
            html.Append(t.Sigla)
            html.Append("</a></li>")
            html.Append(Chr(13))
        Next

        Return html.ToString()

    End Function

    Public Function PathTo_ComFiltro(ByRef oFiltro As cmFiltro) As String
        Dim path As New StringBuilder()
        path.Append("""")
        path.Append(oFiltro.categoria_param)
        path.Append("/")
        path.Append(oFiltro.tamanho_param)
        path.Append("/")
        path.Append(oFiltro.cor_param)
        path.Append("""")
        Return path.ToString()
    End Function

    Public Function PathTo_FiltroPorTamanho(ByVal tamanho As String) As String
        Dim path As New StringBuilder()
        path.Append("""")
        path.Append(Me.Filtro.categoria_param)
        path.Append("/")
        path.Append(tamanho)
        path.Append("/")
        path.Append(Me.Filtro.cor_param)
        path.Append("""")
        Return path.ToString()
    End Function

    Public Function PathTo_FiltroPorCategoria(ByVal categoria As String) As String
        Dim path As New StringBuilder()
        path.Append("""")
        path.Append(categoria)
        path.Append("/")
        path.Append(Me.Filtro.tamanho_param)
        path.Append("/")
        path.Append(Me.Filtro.cor_param)
        path.Append("""")
        Return path.ToString()
    End Function

    Public Function PathTo_FiltroPorCor(ByVal cor As String) As String
        Dim path As New StringBuilder()
        path.Append("""")
        path.Append(Me.Filtro.categoria_param)
        path.Append("/")
        path.Append(Me.Filtro.tamanho_param)
        path.Append("/")
        path.Append(cor)
        path.Append("""")
        Return path.ToString()
    End Function

    Public Function HTML_EliminarFiltros() As String
        Dim t As cmTamanho
        Dim html As New StringBuilder()



        For Each t In Me.TamanhosDisponiveis
            html.Append("<span class=""""cada-filtro"""">")
            html.Append("   <span class=""""cada-filtro-fechar sprite"""">")
            html.Append("       <a title=""""Retirar este filtro"""" href="""""""">x</a>")
            html.Append("   </span>")
            html.Append("   <span class=""""cada-filtro-nome"""">")
            html.Append("        <a title=""""Filtrar apenas por este"""" href=""""calcados-femininos"""">Feminino</a>")
            html.Append("   </span>")
            html.Append("</span>")
        Next

        Return html.ToString()

    End Function

    '=================================================================================================================

    Public Function HTML_MigalhasDeManipulacaoDeFiltro() As String
        Dim html As New StringBuilder()

        html.Append(HTML_MigalhaFiltro_Categoria())
        html.Append(HTML_MigalhaFiltro_Tamanho())
        html.Append(HTML_MigalhaFiltro_Cor())

        Return html.ToString()
    End Function

    Private Function HTML_MigalhaFiltro_Categoria() As StringBuilder
        Dim html As New StringBuilder()

        html.Append("<span class=""""cada-filtro"""">")

        'Cria link para retirar o filtro
        html = HTML_MigalhaFiltro_RetirarFiltro(PathTo_FiltroPorCategoria(kFiltro_TodasCategorias))

        'Cria link para filtrar somente por 1 critério
        Dim novoFiltro As New cmFiltro(Me.Filtro.categoria_param, kFiltro_TodosTamanhos, kFiltro_TodasCores)

        'Concatena os dois links
        html.Append(HTML_MigalhaFiltro_FiltarSomentePorEsteCriterio(novoFiltro, novoFiltro.categoria_Label))

        html.Append("</span>")

        Return html
    End Function

    Private Function HTML_MigalhaFiltro_Tamanho() As StringBuilder
        Dim html As New StringBuilder()

        html.Append("<span class=""""cada-filtro"""">")

        'Cria link para retirar o filtro
        html = HTML_MigalhaFiltro_RetirarFiltro(PathTo_FiltroPorTamanho(kFiltro_TodosTamanhos))

        'Cria link para filtrar somente por 1 critério
        Dim novoFiltro As New cmFiltro(kFiltro_TodasCategorias, Me.Filtro.tamanho_param, kFiltro_TodasCores)

        'Concatena os dois links
        html.Append(HTML_MigalhaFiltro_FiltarSomentePorEsteCriterio(novoFiltro, novoFiltro.categoria_Label))

        html.Append("</span>")

        Return html
    End Function

    Private Function HTML_MigalhaFiltro_Cor() As StringBuilder
        Dim html As New StringBuilder()

        html.Append("<span class=""""cada-filtro"""">")

        'Cria link para retirar o filtro
        html = HTML_MigalhaFiltro_RetirarFiltro(PathTo_FiltroPorCor(kFiltro_TodasCores))

        'Cria link para filtrar somente por 1 critério
        Dim novoFiltro As New cmFiltro(kFiltro_TodasCategorias, kFiltro_TodosTamanhos, Me.Filtro.cor_param)

        'Concatena os dois links
        html.Append(HTML_MigalhaFiltro_FiltarSomentePorEsteCriterio(novoFiltro, novoFiltro.categoria_Label))

        html.Append("</span>")

        Return html
    End Function
    '=================================================================================================================
    '=================================================================================================================
    '=================================================================================================================

    Private Function HTML_MigalhaFiltro_RetirarFiltro(ByVal path As String) As StringBuilder
        Dim html As New StringBuilder()
        html.Append("<span class=""""cada-filtro-fechar sprite"""">")
        html.Append("   <a title=""""Retirar este filtro"""" href=""" & path & """>x</a>")
        html.Append("</span>")
    End Function

    '=================================================================================================================
    '=================================================================================================================
    '=================================================================================================================

    Private Function HTML_MigalhaFiltro_FiltarSomentePorEsteCriterio(ByRef oFiltro As cmFiltro, ByRef label As String)
        Dim path As String
        path = PathTo_ComFiltro(oFiltro)

        Dim html As New StringBuilder()
        html.Append("<span class=""""cada-filtro-nome"""">")
        html.Append("   <a title=""""Filtrar apenas por este"""" href=""" & path & """>" & label & "</a>")
        html.Append("</span>")
        Return html.ToString()
    End Function


    Class cmFiltro
        Public categoria_param As String
        Public tamanho_param As String
        Public cor_param As String
        'String que é exibida para o usuário poder retirar os filtros
        Public categoria_Label As String
        Public tamanho_Label As String
        Public cor_Label As String

        Public Sub New(ByVal categoria As String, ByVal tamanho As String, ByVal cor As String)
            Me.categoria_param = categoria
            Me.tamanho_param = tamanho
            Me.cor_param = cor

#If CONFIG = "Simulacao 1" Then
            Me.categoria_Label = "Minha categoria filtro"
            Me.tamanho_Label = Me.tamanho_param
            Me.cor_Label = Me.cor_param
#End If
        End Sub



    End Class
End Class


