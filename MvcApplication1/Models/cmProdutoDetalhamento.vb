Public Class cmProdutoDetalhamento
    Public Produto As cmProduto
    Public Categorias As Collection
    Public OutrosModelos_MesmoProduto As Collection

    Public Sub New(ByVal id_modelo As Int16)
        Me.Produto = New cmProduto(id_modelo)
        'Carrega a coleção de categorias que preencherá a vitrine
        Categorias = cmCategorias.GetCategorias()
        Me.OutrosModelos_MesmoProduto = cmProdutos.Get_OutrosModelos_MesmoProduto(Me.Produto)

    End Sub

    Public Function GetCategorias() As Collection
        Return cmCategorias.GetCategorias()
    End Function

    Public Function PathTo_Categorias(ByVal target As String) As String
        Return "/Vitrine/" & target
    End Function


    Public Function GetNomeArquivoImagem(ByVal Perspectiva As Int16, ByVal TamanhoImagem As String) As String
        Dim sReturn As String

        Try
            Dim i As cmImagemModelo
            i = Me.Produto.Imagens(Perspectiva.ToString() & TamanhoImagem)

            sReturn = "/images/" & i.NomeArquivo

        Catch ex As Exception

            sReturn = "/images/nophoto.jpg"

        End Try

        Return sReturn

    End Function

    Public Shared Function PathTo_Produto(ByRef p As cmProduto) As String
        Return "/Produto/" & p.Href & "/" & p.Codigo
    End Function



End Class
