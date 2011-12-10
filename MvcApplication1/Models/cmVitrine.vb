Imports MvcApplication1.cmProduto

Public Class cmVitrine                    ' ===>  Modelo da View

    Public Categorias As Collection

    Public Sub New()

        'Carrega a coleção de categorias que preencherá a vitrine
        Categorias = cmCategorias.GetCategorias()

        Dim c As cmCategoria

        'Carrega os produtos de cada categoria
        For Each c In Me.Categorias
            c.Produtos = cmProdutos.GetProdutos_Categoria(c.Id)
        Next

    End Sub

    'Private Sub CriaCategorias()

    '    Me.Categorias = cmCategorias.GetCategoriasParaVitrine()

    '    Dim c As cmCategoria
    '    For Each c In Me.Categorias
    '        c.GetProdutos_ParaVitrine()
    '    Next

    'End Sub

    'Private Sub CarregaProdutosDeCadaCategoria()

    '    Dim c As cmCategoria

    '    For Each c In Me.Categorias
    '        c.GetProdutos()
    '    Next

    'End Sub

    'Private Sub DuplicaProdutosNasCategorias()
    '    Dim p As cmProduto

    '    Dim c As cmCategoria

    '    For Each c In Me.Categorias
    '        For i As Integer = 1 To 4 - c.Produtos.Count
    '            p = c.Produtos(1)
    '            c.Produtos.Add(p)
    '        Next
    '    Next
    'End Sub

    Public Function PathToFolder_Images(ByVal target As String) As String
        Return "../../images/" & target
    End Function

    'Public Function PathTo_Produto(ByVal target As String) As String
    '    Return "../Produto/" & target
    'End Function

    Public Function PathTo_Produto(ByRef p As cmProduto) As String
        Return "../Produto/" & p.Href & "/" & p.Codigo
    End Function

    Public Function PathTo_Categorias(ByVal target As String) As String
        Return "../Vitrine/" & target
    End Function


End Class


