Public Class cmVitrineCategoria
    Public Categorias As Collection
    Public categoria_filtro As String
    Public tamanho_filtro As String
    Public cor_filtro As String
    Public TamanhosDisponiveis As Collection


    Public Sub New(ByVal categoria As String, ByVal tamanho As String, ByVal cor As String)

        Categorias = New Collection()

        'Registra os filtro utilizados na página
        Me.categoria_filtro = categoria
        Me.tamanho_filtro = tamanho
        Me.cor_filtro = cor

        CriaCategorias()

#If CONFIG = "Simulacao 1" Then
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

    Public Function PathTo_FiltroPorTamanho(ByVal tamanho As String) As String
        Dim path As New StringBuilder()
        path.Append("""")
        path.Append(Me.categoria_filtro)
        path.Append("/")
        path.Append(tamanho)
        path.Append("/")
        path.Append(Me.cor_filtro)
        path.Append("""")
        Return path.ToString()
    End Function

    Public Function PathTo_FiltroPorCategoria(ByVal categoria As String) As String
        Dim path As New StringBuilder()
        path.Append("""")
        path.Append(categoria)
        path.Append("/")
        path.Append(Me.tamanho_filtro)
        path.Append("/")
        path.Append(Me.cor_filtro)
        path.Append("""")
        Return path.ToString()
    End Function

    Public Function PathTo_FiltroPorCor(ByVal cor As String) As String
        Dim path As New StringBuilder()
        path.Append("""")
        path.Append(Me.categoria_filtro)
        path.Append("/")
        path.Append(Me.tamanho_filtro)
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
End Class


