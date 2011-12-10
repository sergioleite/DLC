Public Class cmProdutoDetalhamento
    Public Produto As cmProduto
    Public Categorias As Collection

    Public Sub New(ByVal id_modelo As Int16)
        produto = New cmProduto(id_modelo)
        'Carrega a coleção de categorias que preencherá a vitrine
        Categorias = cmCategorias.GetCategorias()

    End Sub

End Class
