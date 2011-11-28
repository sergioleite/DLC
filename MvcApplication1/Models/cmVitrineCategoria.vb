Public Class cmVitrineCategoria
    Public Categoria As cmCategoria
    Public TamanhosDisponiveis As Collection
    Public CoresDisponiveis As Collection

    Private Filtro As cmFiltro

    Const kFiltro_TodasCategorias As String = "todas-categorias"
    Const kFiltro_TodosTamanhos As String = "todos-tamanhos"
    Const kFiltro_TodasCores As String = "todas-cores"

    Private Sub ArmazenaParametrosFiltro(ByVal categoria As String, ByVal tamanho As String, ByVal cor As String)
        'Registra os filtro utilizados na página
        Filtro = New cmFiltro(categoria, tamanho, cor)
    End Sub

    Public Sub New(ByVal categoria As String, ByVal tamanho As String, ByVal cor As String)

        'Inicializa as coleções

        TamanhosDisponiveis = New Collection
        CoresDisponiveis = New Collection

        'Registra os filtro utilizados na página
        ArmazenaParametrosFiltro(categoria, tamanho, cor)

        'Carrega produtos da vitrine
        CarregaDadosVitrine()

#If CONFIG = "Simulacao 1" Then
        'CriaCategoria()


        'Simula tamanhos disponíveis para o filtro selecionado

        TamanhosDisponiveis.Add(New cmTamanho("33"))
        TamanhosDisponiveis.Add(New cmTamanho("34"))
        TamanhosDisponiveis.Add(New cmTamanho("35"))
        TamanhosDisponiveis.Add(New cmTamanho("36"))
        TamanhosDisponiveis.Add(New cmTamanho("37"))
        TamanhosDisponiveis.Add(New cmTamanho("38"))
        TamanhosDisponiveis.Add(New cmTamanho("39"))
        'TamanhosDisponiveis.Add(New cmTamanho("40"))

        Me.CoresDisponiveis.Add(New cmProduto_Cor("Amarelos", "cores-amarelas", "cores_amarelos.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Azuis", "cores-azuis", "cores_azuis.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Beges", "cores-beges", "cores_beges.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Brancos", "cores-brancas", "cores_brancos.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Caques", "cores-caques", "cores_caques.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Cinzas", "cores-cinzas", "cores_cinzas.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Coloridos", "cores-coloridos", "cores_coloridos.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Dourados", "cores-douradas", "cores_dourados.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Laranjas", "cores-laranhas", "cores_laranjas.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Lilás", "cores-lilases", "cores_lilases.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Marrons", "cores-marrons", "cores_marrons.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Pratas", "cores-pratas", "cores_pratas.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Pretos", "cores-pretos", "cores_pretos.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Rosas", "cores-rosas", "cores_rosas.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Verdes", "cores-verdes", "cores_verdes.gif"))
        Me.CoresDisponiveis.Add(New cmProduto_Cor("Vermelhos", "cores-vermelhos", "cores_vermelhos.gif"))

#End If

    End Sub

    Private Sub CarregaDadosVitrine()
        'Obtem a categoria baseada na URL passada como parametro na pagina
        Me.Categoria = cmCategorias.GetCategoriaByURLAmigavel(Me.Filtro.categoria_param)

        'Obtem uma coleção de produtos da categoria em questão
        Me.Categoria.GetProdutos()

    End Sub

    'Private Sub CriaCategoria()
    '    Dim c As cmCategoria
    '    Dim p As cmProduto

    '    c = New cmCategoria
    '    'c.href = "tenis-de-corrida"
    '    c.href = "Scarpins"
    '    c.Title = "Scarpins"
    '    p = New cmProduto()
    '    'p.BackgroundImageUrl = "http://static.anitaonline.com.br/arquivos/chuteira-masculina-umbro-prime-cup-site_produtos-922831559_pequena.jpg"
    '    p.BackgroundImageUrl = "../../images/sapato-carmim-zenia-23009-site_produtos-1893985385_pequena.jpg"
    '    'p.Href = "http://www.anitaonline.com.br/scarpin-carmim-nude-pastel-118674"
    '    p.Href = "Produto1"
    '    p.Title = "Scarpin Carmim Nude"
    '    p.PrecoDe = 1
    '    p.PrecoPor = 1
    '    p.ParcelasQtde = 4
    '    p.ParcelaValor = 3
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    c.Produtos.Add(p)
    '    Categorias.Add(c)


    'End Sub


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

    Public Function HTML_CoresDisponiveis() As String
        Dim c As cmProduto_Cor
        Dim html As New StringBuilder()

        For Each c In Me.CoresDisponiveis
            html.Append("<li>")
            html.Append(Chr(13))
            html.Append("<a href=""")
            html.Append(PathTo_FiltroPorCor(c.Id))
            html.Append("""")
            html.Append(" title=""" & c.Nome_Cor & """")
            html.Append(">")
            html.Append(Chr(13))
            html.Append("<img border=""0"" src=""/images/cores/" & c.Nome_Arquivo_Amostra & """ alt=""" & c.Nome_Cor & """/>")
            html.Append(Chr(13))
            html.Append("</a>")
            html.Append(Chr(13))
            html.Append("</li>")
            html.Append(Chr(13))
        Next

        Return html.ToString()

    End Function

    Public Function PathTo_ComFiltro(ByRef oFiltro As cmFiltro) As String
        Dim path As New StringBuilder()

        path.Append("/Vitrine/")
        path.Append(oFiltro.categoria_param)
        path.Append("/")
        path.Append(oFiltro.tamanho_param)
        path.Append("/")
        path.Append(oFiltro.cor_param)

        Return path.ToString()
    End Function

    Public Function PathTo_FiltroPorTamanho(ByVal tamanho As String) As String
        Dim path As New StringBuilder()
        path.Append("/Vitrine/")
        path.Append(Me.Filtro.categoria_param)
        path.Append("/")
        path.Append(tamanho)
        path.Append("/")
        path.Append(Me.Filtro.cor_param)

        Return path.ToString()
    End Function

    Public Function PathTo_FiltroPorCategoria(ByVal categoria As String) As String
        Dim path As New StringBuilder()
        path.Append("/Vitrine/")
        path.Append(categoria)
        path.Append("/")
        path.Append(Me.Filtro.tamanho_param)
        path.Append("/")
        path.Append(Me.Filtro.cor_param)

        Return path.ToString()
    End Function

    Public Function PathTo_FiltroPorCor(ByVal cor As String) As String
        Dim path As New StringBuilder()
        path.Append("/Vitrine/")
        path.Append(Me.Filtro.categoria_param)
        path.Append("/")
        path.Append(Me.Filtro.tamanho_param)
        path.Append("/")
        path.Append(cor)

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

        If Me.Filtro.isFiltradoPorCategoria() Then
            html.Append("<!-- HTML_MigalhaFiltro_Categoria -->")
            html.Append("<span class=""cada-filtro"">")

            'Cria link para retirar o filtro
            'html.Append(HTML_MigalhaFiltro_RetirarFiltro(PathTo_FiltroPorCategoria(kFiltro_TodasCategorias)))

            'Cria link para filtrar somente por 1 critério
            Dim novoFiltro As New cmFiltro(Me.Filtro.categoria_param, kFiltro_TodosTamanhos, kFiltro_TodasCores)

            'Concatena os dois links
            html.Append(HTML_MigalhaFiltro_FiltarSomentePorEsteCriterio(novoFiltro, novoFiltro.categoria_Label))

            html.Append("</span>")
            html.Append("<!-- HTML_MigalhaFiltro_Categoria FIM -->")
        End If


        Return html
    End Function

    Private Function HTML_MigalhaFiltro_Tamanho() As StringBuilder
        Dim html As New StringBuilder()

        If Me.Filtro.isFiltradoPorTamanho Then
            html.Append("<!-- HTML_MigalhaFiltro_Tamanho -->")
            html.Append("<span class=""cada-filtro"">")

            'Cria link para retirar o filtro
            html.Append(HTML_MigalhaFiltro_RetirarFiltro(PathTo_FiltroPorTamanho(kFiltro_TodosTamanhos)))

            'Cria link para filtrar somente por 1 critério
            Dim novoFiltro As New cmFiltro(kFiltro_TodasCategorias, Me.Filtro.tamanho_param, kFiltro_TodasCores)

            'Concatena os dois links
            html.Append(HTML_MigalhaFiltro_FiltarSomentePorEsteCriterio(novoFiltro, novoFiltro.tamanho_Label))

            html.Append("</span>")
            html.Append("<!-- HTML_MigalhaFiltro_Tamanho FIM -->")
        End If

        Return html
    End Function

    Private Function HTML_MigalhaFiltro_Cor() As StringBuilder
        Dim html As New StringBuilder()

        If Me.Filtro.isFiltradoPorCor Then
            html.Append("<!-- HTML_MigalhaFiltro_Cor -->")
            html.Append("<span class=""cada-filtro"">")

            'Cria link para retirar o filtro
            html.Append(HTML_MigalhaFiltro_RetirarFiltro(PathTo_FiltroPorCor(kFiltro_TodasCores)))

            'Cria link para filtrar somente por 1 critério
            Dim novoFiltro As New cmFiltro(kFiltro_TodasCategorias, kFiltro_TodosTamanhos, Me.Filtro.cor_param)

            'Concatena os dois links
            html.Append(HTML_MigalhaFiltro_FiltarSomentePorEsteCriterio(novoFiltro, novoFiltro.cor_Label))

            html.Append("</span>")
            html.Append("<!-- HTML_MigalhaFiltro_Cor FIM -->")
        End If

        Return html
    End Function
    '=================================================================================================================
    '=================================================================================================================
    '=================================================================================================================

    Private Function HTML_MigalhaFiltro_RetirarFiltro(ByVal path As String) As StringBuilder
        Dim html As New StringBuilder()
        html.Append("<!-- HTML_MigalhaFiltro_RetirarFiltro -->")
        html.Append("<span class=""cada-filtro-fechar sprite"">")
        html.Append("   <a title=""Retirar este filtro"" href=""" & path & """>x</a>")
        html.Append("</span>")
        html.Append("<!-- HTML_MigalhaFiltro_RetirarFiltro FIM-->")
        Return html
    End Function

    '=================================================================================================================
    '=================================================================================================================
    '=================================================================================================================

    Private Function HTML_MigalhaFiltro_FiltarSomentePorEsteCriterio(ByRef oFiltro As cmFiltro, ByRef label As String)
        Dim path As String
        path = PathTo_ComFiltro(oFiltro)

        Dim html As New StringBuilder()
        html.Append("<!-- HTML_MigalhaFiltro_FiltarSomentePorEsteCriterio -->")
        html.Append("<span class=""cada-filtro-nome"">")
        html.Append("   <a title=""Filtrar apenas por este"" href=""" & path & """>" & label & "</a>")
        html.Append("</span>")
        html.Append("<!-- HTML_MigalhaFiltro_FiltarSomentePorEsteCriterio FIM -->")
        Return html.ToString()
    End Function

    Public Function PathToFolder_Images(ByVal target As String) As String
        Return "/images/" & target
    End Function

    Public Function PathTo_Produto(ByVal target As String) As String
        Return "/Produto/" & target
    End Function

    Public Function PathTo_Categorias(ByVal target As String) As String
        Return "/Vitrine/" & target
    End Function

    Class cmFiltro
        '------------------------------------------------------------------------------------------
        'ATRIBUTOS DA CLASSE

        'IDs internos
        Public categoria_param As String
        Public tamanho_param As String
        Public cor_param As String

        'Strings que são exibidas para o usuário poder retirar os filtros
        Public categoria_Label As String
        Public tamanho_Label As String
        Public cor_Label As String
        '------------------------------------------------------------------------------------------

        Public Sub New(ByVal categoria As String, ByVal tamanho As String, ByVal cor As String)
            Me.categoria_param = categoria
            Me.tamanho_param = tamanho
            Me.cor_param = cor

#If CONFIG = "Simulacao 1" Then
            Me.categoria_Label = Me.categoria_param
            Me.tamanho_Label = "Número " & Me.tamanho_param
            Me.cor_Label = "Cor:" & Me.cor_param
#End If
        End Sub

        Public Function isFiltradoPorCategoria() As Boolean
            Return Me.categoria_param <> kFiltro_TodasCategorias
        End Function

        Public Function isFiltradoPorCor() As Boolean
            Return Me.cor_param <> kFiltro_TodasCores
        End Function

        Public Function isFiltradoPorTamanho() As Boolean
            Return Me.tamanho_param <> kFiltro_TodosTamanhos
        End Function

    End Class
End Class


