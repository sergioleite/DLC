Imports System.Data.SqlClient

Public Class cmModelo
    Public ID As Int16
    Public Produto_ID As Int16
    Public Nome As String
    Public LiberadoVenda As String
    Public URL As String
    Public NomeCor As String
    Private _Perspectivas As Collection
    Public CorID As Int16
    Public Estoque_33 As Int16
    Public Estoque_34 As Int16
    Public Estoque_35 As Int16
    Public Estoque_36 As Int16
    Public Estoque_37 As Int16
    Public Estoque_38 As Int16
    Public Estoque_39 As Int16
    Public Estoque_40 As Int16


    Public Function Perspectivas() As Collection
        If IsNothing(Me._Perspectivas) Then
            Me._Perspectivas = cmImagensModelos.GetPerspectivasDeModelo(Me.ID)
        End If

        Return Me._Perspectivas
    End Function


    Public Function Update() As Boolean
        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand


        Try

            cmd.CommandText = "dbo.adml_modelo_update"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", Me.ID)
            cmd.Parameters.AddWithValue("@NOME", Me.Nome)
            cmd.Parameters.AddWithValue("@WEBVIEW_URL_AMIGAVEL", Me.URL)
            cmd.Parameters.AddWithValue("@LIBERADO_PARA_VENDA", Me.LiberadoVenda)
            cmd.Parameters.AddWithValue("@PRODUTO__ID", Me.Produto_ID)
            cmd.Parameters.AddWithValue("@COR__ID", Me.CorID)

            cmd.Parameters.AddWithValue("@ESTOQUE33", Me.Estoque_33)
            cmd.Parameters.AddWithValue("@ESTOQUE34", Me.Estoque_34)
            cmd.Parameters.AddWithValue("@ESTOQUE35", Me.Estoque_35)
            cmd.Parameters.AddWithValue("@ESTOQUE36", Me.Estoque_36)
            cmd.Parameters.AddWithValue("@ESTOQUE37", Me.Estoque_37)
            cmd.Parameters.AddWithValue("@ESTOQUE38", Me.Estoque_38)
            cmd.Parameters.AddWithValue("@ESTOQUE39", Me.Estoque_39)
            cmd.Parameters.AddWithValue("@ESTOQUE40", Me.Estoque_40)

            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            cmd.ExecuteNonQuery()

            Me.ID = Convert.ToInt16(cmd.Parameters("@ID").Value)

            Return True
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try

    End Function

    Public Function Insert() As Boolean
        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand


        Try

            cmd.CommandText = "dbo.adml_modelo_insert"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", Me.ID)
            cmd.Parameters("@ID").Direction = ParameterDirection.Output
            cmd.Parameters.AddWithValue("@NOME", Me.Nome)
            cmd.Parameters.AddWithValue("@WEBVIEW_URL_AMIGAVEL", Me.URL)
            cmd.Parameters.AddWithValue("@LIBERADO_PARA_VENDA", Me.LiberadoVenda)
            cmd.Parameters.AddWithValue("@PRODUTO__ID", Me.Produto_ID)
            cmd.Parameters.AddWithValue("@COR__ID", Me.CorID)

            cmd.Parameters.AddWithValue("@ESTOQUE33", Me.Estoque_33)
            cmd.Parameters.AddWithValue("@ESTOQUE34", Me.Estoque_34)
            cmd.Parameters.AddWithValue("@ESTOQUE35", Me.Estoque_35)
            cmd.Parameters.AddWithValue("@ESTOQUE36", Me.Estoque_36)
            cmd.Parameters.AddWithValue("@ESTOQUE37", Me.Estoque_37)
            cmd.Parameters.AddWithValue("@ESTOQUE38", Me.Estoque_38)
            cmd.Parameters.AddWithValue("@ESTOQUE39", Me.Estoque_39)
            cmd.Parameters.AddWithValue("@ESTOQUE40", Me.Estoque_40)

            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            cmd.ExecuteNonQuery()

            Me.ID = Convert.ToInt16(cmd.Parameters("@ID").Value)

            AtualizaIDModeloNasPerspectivas()

            Return True
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try
    End Function

    Public Function Delete() As Boolean
        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand


        Try

            cmd.CommandText = "dbo.adml_modelo_delete"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@MODELO_ID", Me.ID)
            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            cmd.ExecuteNonQuery()

            Return True
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try
    End Function

    Private Sub AtualizaIDModeloNasPerspectivas()
        For Each p As cmPerspectivaImagem In Perspectivas()
            p.IDModelo = Me.ID
        Next
    End Sub

End Class
