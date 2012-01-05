Public Class cmPerspectivaImagem
    Public _TimeStampCriacao As DateTime

    Private _IDModelo As Int16
    Public Perspectiva As Int16
    Private _Imagens As Collection

    Public Sub New()
        Me._TimeStampCriacao = Now()
    End Sub

    Public Function Imagens() As Collection
        If IsNothing(Me._Imagens) Then
            Me._Imagens = New Collection
        End If

        Return Me._Imagens
    End Function


    Public Function UploadImages() As Boolean
        Dim Timestamp As String
        Timestamp = Me._TimeStampCriacao.ToString("yyyyMMddHHmmss_")        For Each i As cmImagemModelo In Imagens()
            i.NomeArquivoRemoto = Timestamp & i.TamanhoPMG & ".jpg"
            i.Upload()
        Next

        Return True
    End Function

    Public Function Insert() As Boolean
        For Each i As cmImagemModelo In Imagens()
            i.Insert()
        Next

        Return True
    End Function

    Public Function Update() As Boolean
        For Each i As cmImagemModelo In Imagens()
            i.Update()
        Next

        Return True
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
