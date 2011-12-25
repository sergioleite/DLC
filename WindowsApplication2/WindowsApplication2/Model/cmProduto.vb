Imports System.Data.SqlClient

Public Class cmProduto
    Public ID As Int16
    Public Nome As String 'produtos_cores.PRODUTO_COR__NOME
    Public PrecoNormal As Double 'produtos.PRODUTO__PRECO_NORMAL
    Public PrecoPromocional As Double 'produtos.PRODUTO__PRECO_PROMOCIONAL
    Public ParcelasQtde As Int16 'produtos.PRODUTO__PARCELAS_QTDE
    Public ParcelaValor As Double 'DINAMICO
    Public Descricao_HTML As String 'Descricao do produto em HTML
    Public Referencia As String
    Public Fabricante As String
    Public Is_EmPromocao As Boolean
    Public Categoria As cmCategoria

    Public _Modelos As Collection

    Public Function Insert() As Boolean
        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand


        Try

            cmd.CommandText = "dbo.adml_produto_insert"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@categoria__id", Me.Categoria.ID)
            cmd.Parameters.AddWithValue("@nome", Me.Nome)
            cmd.Parameters.AddWithValue("@preco_normal", Me.PrecoNormal)
            cmd.Parameters.AddWithValue("@qtde_parcelas", Me.ParcelasQtde)
            cmd.Parameters.AddWithValue("@esta_em_promocao", Me.Is_EmPromocao)
            cmd.Parameters.AddWithValue("@preco_promocional", Me.PrecoPromocional)
            cmd.Parameters.AddWithValue("@referencia", Me.Referencia)
            cmd.Parameters.AddWithValue("@fabricante", Me.Fabricante)
            cmd.Parameters.AddWithValue("@descricao_html", Me.Descricao_HTML)

            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            cmd.ExecuteNonQuery()

            Return True
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try
    End Function

    Public Sub New()

    End Sub

    Public Function Modelos() As Collection
        If IsNothing(Me._Modelos) Then
            Me._Modelos = cmModelos.GetModelos_DeProduto(Me.ID)
        End If

        Return Me._Modelos
    End Function
End Class
