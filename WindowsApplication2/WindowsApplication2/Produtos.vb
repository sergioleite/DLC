Public Class Produtos
    Public _Produtos As Collection
    Public _Categorias As Collection
    Public _produto As cmProduto
    Public _modelo As cmModelo
    Public _cores As Collection
    Public _produtoEditado As cmProduto

    Public _SubFormModelo_OperacaoCRUD As String

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
        frmEdit._Operacao = "C"
        frmEdit._frmPai = Me

        If frmEdit.ShowDialog() = DialogResult.Yes Then
            CarregaGridProdutos()

            ResaltaProdutoEditado()
        End If
    End Sub

    Private Sub ResaltaProdutoEditado()
        Dim i As Int16

        For Each p As cmProduto In Me._Produtos
            i = i + 1
            If p.ID = Me._produtoEditado.ID Then
                DataGridView1.ClearSelection()
                DataGridView1.Rows(i - 1).Selected = True
                DataGridView1.FirstDisplayedScrollingRowIndex = i - 1
                Return
            End If
        Next
    End Sub

    Private Sub CarregaGridProdutos()

        DesabilitaCreateUpdateModelo()

        Me._Produtos = cmProdutos.GetProdutos_OrderByCategoria()

        Me.DataGridView1.Rows.Clear()

        For Each p As cmProduto In Me._Produtos
            Me._produto = p
            Me.DataGridView1.Rows.Add(p.Categoria.Nome, p.ID, p.Nome, p.PrecoNormal, p.ParcelasQtde, p.Is_EmPromocao, p.PrecoPromocional, p.Referencia, p.Fabricante)
        Next
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        CarregaGridModelos()
    End Sub

    Private Sub DesabilitaCreateUpdateModelo()
        Me.ButtonGravaNovoModelo.Visible = False
        Me.Button_GravaAlteracaoModelo.Visible = False
        Me.ButtonExcluirModelo.Visible = False
        Me._SubFormModelo_OperacaoCRUD = "R"
        HabilitaDesabilita_DesabilitaControlesModelo(False)
    End Sub

    Private Sub HabilitaDesabilita_DesabilitaControlesModelo(ByVal bEnabled As Boolean)
        Me.TextBox_NomeModelo.Enabled = bEnabled
        Me.RadioButton_LiberadoVenda_Nao.Enabled = bEnabled
        Me.RadioButton_LiberadoVenda_Sim.Enabled = bEnabled
        Me.ComboBoxCores.Enabled = bEnabled
        Me.TextBox_ModeloURL.Enabled = bEnabled
        Me.TextBoxEstoque33.Enabled = bEnabled
        Me.TextBoxEstoque34.Enabled = bEnabled
        Me.TextBoxEstoque35.Enabled = bEnabled
        Me.TextBoxEstoque36.Enabled = bEnabled
        Me.TextBoxEstoque37.Enabled = bEnabled
        Me.TextBoxEstoque38.Enabled = bEnabled
        Me.TextBoxEstoque39.Enabled = bEnabled
        Me.TextBoxEstoque40.Enabled = bEnabled
        Me.ButtonNovaImagem.Enabled = bEnabled
    End Sub

    Private Sub CarregaGridModelos()

        Me.Cursor = Cursors.WaitCursor

        Me.DataGridViewModelos.Rows.Clear()

        DesabilitaCreateUpdateModelo()

        LimpaDados_ObjetoModelo_Tela()

        If Me._Produtos.Count > 0 Then
            _produto = Me._Produtos.Item(DataGridView1.CurrentRow.Index + 1)

            For Each m As cmModelo In _produto.Modelos()
                Me.DataGridViewModelos.Rows.Add(m.Nome, m.LiberadoVenda, m.NomeCor)
            Next
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ButtonNovaImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNovaImagem.Click
        Dim frm As New Imagem_Modelo()
        frm.frmPai = Me
        frm.Text = "Seleção de Imagens para o modelo " & Me.TextBox_NomeModelo.Text
        If frm.ShowDialog() = DialogResult.Yes Then
            CarregaGridPerspectivas()
        End If
    End Sub

    Private Sub ButtonNovoModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNovoModelo.Click
        Me._modelo = New cmModelo()
        PreparaTela_CriacaoNovoModelo()
        HabilitaDesabilita_DesabilitaControlesModelo(True)
        Me.TextBox_NomeModelo.Focus()
        Me.TextBox_NomeModelo.SelectionStart = Me.TextBox_NomeModelo.Text.Length() + 1
    End Sub

    Private Sub PreparaTela_CriacaoNovoModelo()
        CarregaDados_ObjetoProduto_Tela()
        Me.TextBox_NomeModelo.Text = Me._produto.Nome & " "
        Me.ComboBoxCores.SelectedIndex = 0
        Me._SubFormModelo_OperacaoCRUD = "C"
        Me.ButtonGravaNovoModelo.Visible = True
        Me.DataGridViewPerspectivas.Rows.Clear()
    End Sub



    Private Sub DataGridViewModelos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewModelos.SelectionChanged
        TrataClickGridModelos()
    End Sub

    Private Sub TrataClickGridModelos()
        DesabilitaCreateUpdateModelo()

        If DataGridViewModelos.RowCount > 0 Then

            CarregaGridPerspectivas()

            CarregaDados_ObjetoModelo_Tela()
        End If
    End Sub

    Private Sub CarregaGridPerspectivas()

        Me.Cursor = Cursors.WaitCursor

        If Me._produto.Modelos.Count > 0 Then
            Try
                Me._modelo = Me._produto.Modelos(DataGridViewModelos.CurrentRow.Index + 1)

                Me.DataGridViewPerspectivas.Rows.Clear()

                For Each p As cmPerspectivaImagem In Me._modelo.Perspectivas()
                    Me.DataGridViewPerspectivas.Rows.Add(p.Perspectiva.ToString())
                Next

            Catch ex As Exception

            End Try
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub CarregaDados_ObjetoProduto_Tela()
        'Dados compartilhados do produto
        Me.TextBoxCategoria.Text = Me._produto.Categoria.Nome
        Me.TextBoxPrecoNormal.Text = Me._produto.PrecoNormal
        Me.TextBoxQtdeParcelas.Text = Me._produto.ParcelasQtde
        Me.TextBoxPrecoPromocional.Text = Me._produto.PrecoPromocional
        Me.TextBoxReferencia.Text = Me._produto.Referencia
        Me.TextBoxFabricante.Text = Me._produto.Fabricante
    End Sub


    Private Sub CarregaDados_ObjetoModelo_Tela()
        CarregaDados_ObjetoProduto_Tela()
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
        TextBox_ModeloURL.Text = Me._modelo.URL
    End Sub

    Private Sub LimpaDados_ObjetoModelo_Tela()
        'NOME
        TextBox_NomeModelo.Text = ""
        'RADIO BUTTON
        Me.RadioButton_LiberadoVenda_Nao.Checked = False
        'COR
        ComboBoxCores.SelectedIndex = 0
        'URL AMIGAVEL MODELO
        TextBox_ModeloURL.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGravaNovoModelo.Click

        If ConsisteDados_InsertModelo() Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If GravaNovoModelo() Then
                Me.Cursor = Cursors.Default
                MsgBox("Modelo criado.", MsgBoxStyle.Information, "Aviso")
                Me._produto._Modelos = Nothing 'Limpa a coleção de modelos do produto para forçar seu recarregamento.
                Me.Cursor = Cursors.WaitCursor
                CarregaGridModelos()
                ResaltaModeloEditado()
                Me.Cursor = Cursors.Default
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If

    End Sub

    Private Function GravaAlteracaoModelo() As Boolean
        If GravaNovoModelo_UploadImagens() Then
            Return GravaAlteracaoModelo_DadosSQL()
        End If
    End Function


    Private Function GravaNovoModelo() As Boolean
        If GravaNovoModelo_UploadImagens() Then
            Return GravaNovoModelo_DadosSQL()
        End If
    End Function

    Private Function GravaNovoModelo_UploadImagens() As Boolean
        For Each p As cmPerspectivaImagem In Me._modelo.Perspectivas
            p.UploadImages()
        Next

        Return True
    End Function

    Private Function GravaAlteracaoModelo_DadosSQL() As Boolean
        MoveDados_Tela_ObjetoModelo()

        Me._modelo.Update()

        '-------------------------------------------------------------------------------------------------------
        'Persiste todas as imagens (PMG) de uma perspectiva
        '-------------------------------------------------------------------------------------------------------
        For Each p As cmPerspectivaImagem In Me._modelo.Perspectivas
            p.IDModelo = Me._modelo.ID
            p.Update()
        Next
        '-------------------------------------------------------------------------------------------------------

        Return True

    End Function


    Private Function GravaNovoModelo_DadosSQL() As Boolean
        MoveDados_Tela_ObjetoModelo()

        Me._modelo.Insert()

        '-------------------------------------------------------------------------------------------------------
        'Persiste todas as imagens (PMG) de uma perspectiva
        '-------------------------------------------------------------------------------------------------------
        For Each p As cmPerspectivaImagem In Me._modelo.Perspectivas
            p.IDModelo = Me._modelo.ID
            p.Insert()
        Next
        '-------------------------------------------------------------------------------------------------------

        Return True
    End Function

    Private Sub MoveDados_Tela_ObjetoModelo()
        Dim cor As cmCor

        Me._modelo.Nome = TextBox_NomeModelo.Text
        Me._modelo.Produto_ID = Me._produto.ID

        cor = Me._cores(Me.ComboBoxCores.SelectedIndex())
        Me._modelo.CorID = cor.ID

        If RadioButton_LiberadoVenda_Sim.Checked Then
            Me._modelo.LiberadoVenda = "S"
        Else
            Me._modelo.LiberadoVenda = "N"
        End If

        Me._modelo.URL = TextBox_ModeloURL.Text

        Me._modelo.Estoque_33 = TextBoxEstoque33.Text
        Me._modelo.Estoque_34 = TextBoxEstoque34.Text
        Me._modelo.Estoque_35 = TextBoxEstoque35.Text
        Me._modelo.Estoque_36 = TextBoxEstoque36.Text
        Me._modelo.Estoque_37 = TextBoxEstoque37.Text
        Me._modelo.Estoque_38 = TextBoxEstoque38.Text
        Me._modelo.Estoque_39 = TextBoxEstoque39.Text
        Me._modelo.Estoque_40 = TextBoxEstoque40.Text

    End Sub

    Private Function ConsisteDados_InsertModelo() As Boolean

        If Me.TextBox_NomeModelo.Text.Trim().Length = 0 Then
            MsgBox("Informe o nome do modelo.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
            Me.TextBox_NomeModelo.Focus()
            Return False
        End If

        If Me.ComboBoxCores.SelectedIndex < 1 Then
            MsgBox("Informe a cor predominante no modelo.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
            Me.ComboBoxCores.Focus()
            Return False
        End If

        If Me.TextBox_NomeModelo.Text.Trim().Length = 0 Then
            MsgBox("A URL amigável não pode ficar em branco.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
            Me.TextBox_NomeModelo.Focus()
            Return False
        End If

        Dim bReturn As Boolean

        If ConsisteDados_InsertModelo_Estoque(TextBoxEstoque33, "Estoque No 33") Then
            If ConsisteDados_InsertModelo_Estoque(TextBoxEstoque34, "Estoque No 34") Then
                If ConsisteDados_InsertModelo_Estoque(TextBoxEstoque35, "Estoque No 35") Then
                    If ConsisteDados_InsertModelo_Estoque(TextBoxEstoque36, "Estoque No 36") Then
                        If ConsisteDados_InsertModelo_Estoque(TextBoxEstoque37, "Estoque No 37") Then
                            If ConsisteDados_InsertModelo_Estoque(TextBoxEstoque38, "Estoque No 38") Then
                                If ConsisteDados_InsertModelo_Estoque(TextBoxEstoque39, "Estoque No 39") Then
                                    If ConsisteDados_InsertModelo_Estoque(TextBoxEstoque40, "Estoque No 40") Then
                                        bReturn = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If Not bReturn Then
            Return False
        End If

        If Me._modelo.Perspectivas.Count = 0 Then
            If MsgBox("Não foi selecionada nenhuma imagem para este produto. Deseja prosseguir com sua inclusão?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pergunta") = vbNo Then
                Return False
            End If
        End If

        Return bReturn

    End Function

    Private Function ConsisteDados_InsertModelo_Estoque(ByRef tb As TextBox, ByVal label As String) As Boolean
        If tb.Text.Trim().Length = 0 Then
            MsgBox("Informe o " & label, MsgBoxStyle.Exclamation, "Impossível prosseguir")
            tb.Focus()
            Return False
        Else
            If Not IsNumeric(tb.Text) Then
                MsgBox(label & "inválido.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
                tb.Focus()
                Return False
            Else
                If CType(tb.Text, Double) < 0 Then
                    MsgBox(label & "não pode ser negativo.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
                    tb.Focus()
                    Return False
                End If
            End If
        End If

        Return True
    End Function


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DataGridView1.ClearSelection()
        DataGridView1.Rows(3).Selected = True
        DataGridView1.FirstDisplayedScrollingRowIndex = 3
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim frmEdit As New Produto_Edit()
        frmEdit._Categorias = Me._Categorias
        frmEdit._Operacao = "U"
        frmEdit._frmPai = Me
        frmEdit._produtoEditar = Me._produto

        If frmEdit.ShowDialog() = DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor

            CarregaGridProdutos()

            ResaltaProdutoEditado()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub TextBox_NomeModelo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_NomeModelo.TextChanged
        Dim s As String
        s = Me.TextBox_NomeModelo.Text.Replace("-", "")
        s = s.Replace(" ", "-")
        Me.TextBox_ModeloURL.Text = s.ToLower()
    End Sub

    Private Sub ResaltaModeloEditado()
        Dim i As Int16

        For Each m As cmModelo In Me._produto.Modelos
            i = i + 1
            If m.ID = Me._modelo.ID Then
                DataGridViewModelos.ClearSelection()
                DataGridViewModelos.Rows(i - 1).Selected = True
                DataGridViewModelos.FirstDisplayedScrollingRowIndex = i - 1
                Return
            End If
        Next
    End Sub

    Private Sub DataGridViewPerspectivas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewPerspectivas.DoubleClick
        Dim frm As New Imagem_Modelo
        frm._OperacaoCRUD = "U"
        frm.Text = "Seleção de Imagens para o modelo " & Me.TextBox_NomeModelo.Text
        frm._Perspectiva = Me._modelo.Perspectivas(DataGridViewModelos.CurrentRow.Index + 1)

        If frm.ShowDialog() = DialogResult.Yes Then
            CarregaGridPerspectivas()
        End If
    End Sub

    Private Sub DataGridViewModelos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewModelos.DoubleClick
        Me._SubFormModelo_OperacaoCRUD = "U"
        Me.Button_GravaAlteracaoModelo.Visible = True
        Me.ButtonExcluirModelo.Visible = True
        CarregaDados_ObjetoModelo_Tela()
        HabilitaDesabilita_DesabilitaControlesModelo(True)
    End Sub

    Private Sub DataGridViewModelos_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridViewModelos.RowsRemoved
        LimpaDados_ObjetoModelo_Tela()
    End Sub

    Private Sub Button_GravaAlteracaoModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_GravaAlteracaoModelo.Click
        If ConsisteDados_InsertModelo() Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If GravaAlteracaoModelo() Then
                Me.Cursor = Cursors.Default
                MsgBox("Modelo alterado.", MsgBoxStyle.Information, "Aviso")
                Me.Cursor = Cursors.WaitCursor
                Me._produto._Modelos = Nothing 'Limpa a coleção de modelos do produto para forçar seu recarregamento.
                CarregaGridModelos()
                ResaltaModeloEditado()
                Me.Cursor = Cursors.Default
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub ButtonExcluirModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExcluirModelo.Click
        If MsgBox("Confirma a exclusão deste modelo?", MsgBoxStyle.YesNo + vbQuestion, "Confirmação") = vbYes Then
            Me.Cursor = Cursors.WaitCursor
            If Me._modelo.Delete() Then
                Me._produto._Modelos = Nothing 'Limpa a coleção de modelos do produto para forçar seu recarregamento.
                Me.Cursor = Cursors.Default
                MsgBox("Modelo excluído.", MsgBoxStyle.Information, "Aviso")
                Me.Cursor = Cursors.WaitCursor
                CarregaGridModelos()
                Me.Cursor = Cursors.Default
            Else
                Me.Cursor = Cursors.Default
                MsgBox("Erro ao excluir modelo.", MsgBoxStyle.Critical, "Aviso")
            End If

        End If

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'CarregaGridModelos()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        'CarregaGridModelos()
    End Sub

    Private Sub DataGridViewModelos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewModelos.CellClick
        'TrataClickGridModelos()
    End Sub

    Private Sub DataGridViewModelos_RowHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewModelos.RowHeaderMouseClick
        'TrataClickGridModelos()
    End Sub
End Class