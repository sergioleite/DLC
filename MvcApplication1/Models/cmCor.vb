Public Class cmCor
    Public ID As Int16
    Public Nome As String
    Public URLAmigavel As String
    Public NomeArquivoAmostra As String

    Public Sub New(ByVal ID As Int16, ByVal Nome As String, ByVal URLAmigavel As String, ByVal NomeArquivoAmostra As String)
        Me.ID = ID
        Me.Nome = Nome
        Me.URLAmigavel = URLAmigavel
        Me.NomeArquivoAmostra = NomeArquivoAmostra
    End Sub
End Class
