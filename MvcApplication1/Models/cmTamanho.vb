Public Class cmTamanho
    Public Sigla As String
    Public ID As String
    Public URL_Amigavel As String

    Public Sub New(ByVal ID As String)
        Me.ID = ID
        Me.Sigla = ID
    End Sub

    Public Sub New(ByVal ID As String, ByVal Sigla As String, ByVal URL_Amigavel As String)
        Me.ID = ID
        Me.Sigla = Sigla
        Me.URL_Amigavel = URL_Amigavel
    End Sub
End Class
