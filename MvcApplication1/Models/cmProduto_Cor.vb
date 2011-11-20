Public Class cmProduto_Cor
    Public Nome_Arquivo_Amostra As String
    Public Nome_Cor As String
    Public Id As String

    Public Sub New(ByVal Nome As String, ByVal id As String, ByVal arquivo_sem_path As String)
        Me.Nome_Cor = Nome
        Me.Id = id
        Me.Nome_Arquivo_Amostra = arquivo_sem_path
    End Sub


End Class
