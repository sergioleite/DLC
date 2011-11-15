Imports MvcApplication1.Produto

Public Class cmCategoria
    Public href As String
    Public Title As String
    Public Produtos As Collection
    Public Id As Int16

    Public Sub New()
        Me.Produtos = New Collection()

    End Sub

    Public Function GetProdutos_ParaVitrine() As Collection
        Me.Produtos = cmProdutos.getProdutosPorCategoria(Me)
        Return Me.Produtos
    End Function




End Class
