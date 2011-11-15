Imports MvcApplication1.cProduto

Public Class cmVitrine                    ' ===>  Modelo da View

    Public Categorias As Collection

    Public Sub New()

        'Carrega a coleção de categorias que preencherá a vitrine
        CriaCategorias()

        'Como só há um produto por categoria, duplica calçados para encher uma linha da vitrine com 4 produtos iguais por categoria. 
        'Apenas para fins de teste de navegação.
        DuplicaProdutosNasCategorias()

    End Sub

    Private Sub CriaCategorias()

        Me.Categorias = cmCategorias.GetCategoriasParaVitrine()

        Dim c As cmCategoria
        For Each c In Me.Categorias
            c.GetProdutos_ParaVitrine()
        Next

    End Sub

    Private Sub DuplicaProdutosNasCategorias()
        Dim p As cmProduto

        Dim c As cmCategoria

        For Each c In Me.Categorias
            For i As Integer = 1 To 4 - c.Produtos.Count
                p = c.Produtos(1)
                c.Produtos.Add(p)
            Next
        Next


    End Sub

    Public Function PathToFolder_Images(ByVal target As String) As String
        Return "../../images/" & target
    End Function

    Public Function PathTo_Produto(ByVal target As String) As String
        Return "../Produto/" & target
    End Function

    Public Function PathTo_Categorias(ByVal target As String) As String
        Return "../Vitrine/" & target
    End Function


End Class


