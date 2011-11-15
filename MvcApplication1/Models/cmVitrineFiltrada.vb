Public Class cmVitrineFiltrada

    Class Tamanho
        Dim id As Int16
        Dim nome As String

        Public Sub New(ByVal id As Int16, ByVal nome As String)
            Me.id = id
            Me.nome = nome
        End Sub
    End Class

    Dim tamanhosDisponiveis As Collection

    Public Sub New()
        CarregaTamanhosDisponiveis()
    End Sub

    Private Sub CarregaTamanhosDisponiveis()
        tamanhosDisponiveis = New Collection()
        tamanhosDisponiveis.Add(New Tamanho(33, "33"))
        tamanhosDisponiveis.Add(New Tamanho(33, "34"))
        tamanhosDisponiveis.Add(New Tamanho(33, "35"))
        tamanhosDisponiveis.Add(New Tamanho(33, "36"))
        tamanhosDisponiveis.Add(New Tamanho(33, "37"))
        tamanhosDisponiveis.Add(New Tamanho(33, "38"))
    End Sub


End Class
