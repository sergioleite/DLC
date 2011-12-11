Public Class cmImagemModelo
    Public Perspectiva As Int16
    Public NomeArquivo As String
    Public Tamanho As String

    Public Sub New(ByVal Perspectiva As Int16, ByVal NomeArquivo As String, ByVal Tamanho As String)
        Me.Perspectiva = Perspectiva
        Me.NomeArquivo = NomeArquivo
        Me.Tamanho = Tamanho
    End Sub
End Class
