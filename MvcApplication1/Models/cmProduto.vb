Public Class cmProduto
    Public BackgroundImageUrl As String
    Public Href As String
    Public Title As String
    Public PrecoDe As Double
    Public PrecoPor As Double
    Public ParcelasQtde As Int16
    Public ParcelaValor As Int16
    Public Codigo As Int16


    Public Function isEmPromocao() As Boolean
        Dim bReturn As Boolean

        If Me.PrecoPor < Me.PrecoDe Then
            bReturn = True
        End If

        Return bReturn

    End Function

    Public Function isFreteGratis() As Boolean
        Dim bReturn As Boolean

        If Not isEmPromocao() Then
            bReturn = True
        End If

        Return bReturn

    End Function

    Public Function NomeProdutoURL() As String
        Return Title.Replace(" ", "-")
    End Function


End Class
