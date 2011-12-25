Public Class cmModelo
    Public ID As Int16
    Public Nome As String
    Public LiberadoVenda As String
    Public URL As String
    Public NomeCor As String
    Private _Perspectivas As Collection


    Public Function Perspectivas() As Collection
        If IsNothing(Me._Perspectivas) Then
            Me._Perspectivas = cmImagensModelos.GetPerspectivasDeModelo(Me.ID)
        End If

        Return Me._Perspectivas
    End Function
End Class
