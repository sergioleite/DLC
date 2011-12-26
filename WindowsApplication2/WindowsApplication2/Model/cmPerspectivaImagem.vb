Public Class cmPerspectivaImagem
    Private _IDModelo As Int16
    Public Perspectiva As Int16
    Private _Imagens As Collection

    Public Function Imagens() As Collection
        If IsNothing(Me._Imagens) Then
            Me._Imagens = New Collection
        End If

        Return Me._Imagens
    End Function


    Public Property IDModelo() As Int16
        Get
            Return _IDModelo
        End Get

        Set(ByVal value As Int16)
            _IDModelo = value
            'Atualiza o ID modelo de todas as imagens vinculadas
            For Each i As cmImagemModelo In Imagens()
                i.IDModelo = _IDModelo
            Next

        End Set
    End Property

End Class
