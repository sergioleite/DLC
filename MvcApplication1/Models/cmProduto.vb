Imports System.Data.SqlClient

Public Class cmProduto
    Public BackgroundImageUrl As String
    Public Href As String 'produto_cores.PRODUTO_COR__WEBVIEW_URL_AMIGAVEL
    Public Title As String 'produtos_cores.PRODUTO_COR__NOME
    Public PrecoNormal As Double 'produtos.PRODUTO__PRECO_NORMAL
    Public PrecoPromocional As Double 'produtos.PRODUTO__PRECO_PROMOCIONAL
    Public ParcelasQtde As Int16 'produtos.PRODUTO__PARCELAS_QTDE
    Public ParcelaValor As Double 'DINAMICO
    Public Codigo As Int16 'DB-> produtos_cores.produto_cor__id

    Private _Tamanhos As Collection


    Public Function isEmPromocao() As Boolean
        Dim bReturn As Boolean

        If Me.PrecoPromocional <> 0.0 Then
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

    'Public Sub New(ByRef dr As SqlDataReader)
    '    Me.Codigo = dr.GetInt32(dr.GetOrdinal("PRODUTO__ID"))
    '    Me.Title = dr.GetString(dr.GetOrdinal("CATEGORIA__NOME"))
    '    Me.Href = dr.GetString(dr.GetOrdinal("CATEGORIA_WEBVIEW_URL_AMIGAVEL"))
    'End Sub

    Public Sub New(ByRef CodigoProduto As Int16)

        Me._Tamanhos = New Collection
        Me.Codigo = CodigoProduto

        load(Me.Codigo)
    End Sub

    Private Sub load(ByVal modelo_id As Int16)

        'Carrega os dados de um produto baseado em seu ID

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        Try

            cmd.CommandText = "dbo.get_modelo"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@modelo_id", modelo_id)
            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            dr = cmd.ExecuteReader()

            If dr.Read() Then

                Me.BackgroundImageUrl = dr.GetString(dr.GetOrdinal("NOMEARQUIVO"))
                Me.Href = dr.GetString(dr.GetOrdinal("WEBVIEW_URL_AMIGAVEL"))
                Me.Title = dr.GetString(dr.GetOrdinal("NOME"))
                Me.PrecoNormal = dr.GetSqlMoney(dr.GetOrdinal("PRECO_NORMAL"))
                Me.PrecoPromocional = dr.GetSqlMoney(dr.GetOrdinal("PRECO_PROMOCIONAL"))
                Me.ParcelasQtde = dr.GetSqlInt32(dr.GetOrdinal("PARCELAS_QTDE"))
                If (PrecoPromocional <> 0) Then
                    ParcelaValor = Me.PrecoPromocional / Me.ParcelasQtde
                Else
                    ParcelaValor = Me.PrecoNormal / Me.ParcelasQtde
                End If
            End If

            dr.Close()
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try

    End Sub



    Private Sub LoadTamanhosDisponiveis()
        Me._Tamanhos = cmTamanhos.GetTamanhosDisponiveis_ProdutoCor(Me.Codigo)
    End Sub

    Public Function TamanhosDisponiveis() As Collection

        If Me._Tamanhos.Count = 0 Then
            LoadTamanhosDisponiveis()
        End If

        Return Me._Tamanhos

    End Function
End Class
