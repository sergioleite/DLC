﻿Public Class Produtos
    Public _Produtos As Collection
    Public _Categorias As Collection
    Dim _produto As cmProduto
    Dim _modelo As cmModelo
    Dim _cores As Collection

    Private Sub Produtos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me._Categorias = dmCategorias.GetCategorias()

        CarregaGridProdutos()

        'Carrega coleção de cores
        CarregaComboCores()

    End Sub

    Private Sub CarregaComboCores()
        'Carrega a coleção de cores
        Me._cores = cmCores.GetCores()

        'Popula o comobo de cores
        For Each c As cmCor In Me._cores
            ComboBoxCores.Items.Add(c.Nome)
        Next
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

        _produto = Me._Produtos.Item(DataGridView1.CurrentRow.Index + 1)

        Me.DataGridViewModelos.Rows.Clear()

        For Each m As cmModelo In _produto.Modelos()
            Me.DataGridViewModelos.Rows.Add(m.Nome, m.LiberadoVenda, m.URL, m.NomeCor)
        Next

    End Sub




    Private Sub ButtonNovaImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNovaImagem.Click
        Dim frm As New Imagem_Modelo()
        frm.ShowDialog()
    End Sub

    Private Sub ButtonNovoModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNovoModelo.Click

    End Sub

    Private Sub DataGridViewModelos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewModelos.CellContentClick

    End Sub

    Private Sub DataGridViewModelos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewModelos.SelectionChanged
        CarregaGridPerspectivas()

        CarregaFormDadosModelo()
    End Sub

    Private Sub CarregaGridPerspectivas()

        Me._modelo = Me._produto.Modelos(DataGridViewModelos.CurrentRow.Index + 1)

        Me.DataGridViewPerspectivas.Rows.Clear()

        For Each p As cmPerspectivaImagem In Me._modelo.Perspectivas()
            Me.DataGridViewPerspectivas.Rows.Add(p.Perspectiva.ToString())
        Next

    End Sub

    Private Sub CarregaFormDadosModelo()
        'NOME
        TextBox_NomeModelo.Text = Me._modelo.Nome
        'RADIO BUTTON
        If Me._modelo.LiberadoVenda = "S" Then
            Me.RadioButton_LiberadoVenda_Sim.Checked = True
        Else
            Me.RadioButton_LiberadoVenda_Nao.Checked = False
        End If

        'COR
        ComboBoxCores.Text = Me._modelo.NomeCor

        'URL AMIGAVEL MODELO
        TextBoxURL.Text = Me._modelo.URL
    End Sub
End Class