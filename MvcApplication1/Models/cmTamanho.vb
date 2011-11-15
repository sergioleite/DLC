Public Class cmTamanho
    Public Sigla As String
    Public ID As String

    Public Sub New(ByVal ID As String)
        Me.ID = ID
        Me.Sigla = ID
    End Sub

    Public Sub New(ByVal ID As String, ByVal Sigla As String)
        Me.ID = ID
        Me.Sigla = Sigla
    End Sub
End Class
