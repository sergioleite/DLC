Public Class Produtos
    Public _Produtos As Collection
    Public _Categorias As Collection

    Private Sub Produtos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me._Categorias = dmCategorias.GetCategorias()

        CarregaGridProdutos()

    End Sub

    Private Sub ButtonNovoProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNovoProduto.Click
        Dim frmEdit As New Produto_Edit()
        frmEdit._Categorias = Me._Categorias
        If frmEdit.ShowDialog() = DialogResult.Yes Then
            CarregaGridProdutos()
        End If
    End Sub


    Private Sub CarregaGridProdutos()
        Me._Produtos = cmProdutos.GetProdutos_OrderByCategoria()

        Me.DataGridView1.Rows.Clear()

        For Each p As cmProduto In Me._Produtos
            Me.DataGridView1.Rows.Add(p.Categoria.Nome, p.ID, p.Nome, p.PrecoNormal, p.ParcelasQtde, p.Is_EmPromocao, p.PrecoPromocional, p.Referencia, p.Fabricante)
        Next
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        CarregaGridModelos()
    End Sub

    Private Sub CarregaGridModelos()
        Dim produto As cmProduto
        produto = Me._Produtos.Item(DataGridView1.CurrentRow.Index + 1)

        Me.DataGridView2.Rows.Clear()

        For Each m As cmModelo In produto.Modelos()
            Me.DataGridView2.Rows.Add(m.Nome, m.LiberadoVenda, m.URL, m.NomeCor)
        Next

    End Sub


    Private Sub ButtonNovaImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNovaImagem.Click
        Dim frm As New Imagem_Modelo()
        frm.ShowDialog()
    End Sub
End Class