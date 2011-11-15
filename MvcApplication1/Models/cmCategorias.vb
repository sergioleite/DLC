Public Class cmCategorias
    Public Shared Function GetCategoriasParaVitrine() As Collection
        Dim categorias As New Collection()

        Dim c As cmCategoria

        c = New cmCategoria
        c.Id = 1
        c.href = "Scarpins"
        c.Title = "Scarpins"
        categorias.Add(c)

        c = New cmCategoria
        c.Id = 2
        c.href = "Anabela"
        c.Title = "Anabela"
        categorias.Add(c)

        c = New cmCategoria
        c.Id = 3
        c.href = "PeepToe"
        c.Title = "PeepToe"
        categorias.Add(c)

        Return categorias
    End Function

End Class
