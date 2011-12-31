
Public Class Produto_Edit
    Public _Categorias As Collection
    Public _Operacao As New String("")
    Public _frmPai As Produtos
    Public _produtoEditar As cmProduto

    Private Sub Produto_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulaComboCategoria()

        If Me._Operacao = "U" Then
            Me._frmPai._produtoEditado = Me._produtoEditar
            CarregaDadosParaForm()
            Me.ButtonExcluirProduto.Visible = True
            Me.ButtonSaveEdit.Visible = True
            Me.ButtonInserir.Visible = False
        Else
            Me.ButtonExcluirProduto.Visible = False
            Me.ButtonSaveEdit.Visible = False
            Me.ButtonInserir.Visible = True
        End If
    End Sub

    Private Sub CarregaDadosParaForm()
        ' Carrega os dados
        TextBoxIDProduto.Text = Me._produtoEditar.ID
        'Categoria        
        ComboBoxCategoria.SelectedIndex = GetIndexCategoria(Me._produtoEditar.Categoria.ID)
        TextBoxNome.Text = Me._produtoEditar.Nome
        TextBoxReferencia.Text = Me._produtoEditar.Referencia
        TextBoxFabricante.Text = Me._produtoEditar.Fabricante
        TextBoxPrecoNormal.Text = Me._produtoEditar.PrecoNormal
        TextBoxQtdeParcelas.Text = Me._produtoEditar.ParcelasQtde
        CheckBoxPromocao.Checked = Me._produtoEditar.Is_EmPromocao
        TextBoxPrecoPromocional.Text = Me._produtoEditar.PrecoPromocional
        TextBoxDescricaoHTML.Text = Me._produtoEditar.Descricao_HTML

        'Habilita/desabilita controles
        If Me._produtoEditar.Is_EmPromocao Then
            TextBoxPrecoPromocional.Enabled = True
        Else
            TextBoxPrecoPromocional.Enabled = False
        End If

    End Sub

    Private Function GetIndexCategoria(ByVal ID As Int16) As Int16
        Dim i As Int16

        For Each c As cmCategoria In Me._Categorias
            If c.ID = ID Then
                Return i
            End If
            i = i + 1
        Next

        Return -1
    End Function

    Private Sub PopulaComboCategoria()
        For Each c As cmCategoria In Me._Categorias
            ComboBoxCategoria.Items.Add(c.Nome)
        Next
    End Sub

    Private Sub PostLoad()
        If Me._Operacao = "I" Then
            TextBoxPrecoPromocional.Enabled = False
        End If
    End Sub

    Private Sub TextBoxPrecoPromocional_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPrecoPromocional.TextChanged

    End Sub

    Private Sub MoveDadosFormParaObjeto(ByRef p As cmProduto)
        p.Categoria = Me._Categorias.Item(ComboBoxCategoria.SelectedIndex + 1)
        p.Descricao_HTML = Me.TextBoxDescricaoHTML.Text
        p.Fabricante = Me.TextBoxFabricante.Text
        p.Is_EmPromocao = Me.CheckBoxPromocao.Checked
        p.Nome = Me.TextBoxNome.Text
        p.ParcelasQtde = Me.TextBoxQtdeParcelas.Text
        p.PrecoNormal = Me.TextBoxPrecoNormal.Text

        If Me.TextBoxPrecoPromocional.Text.Length = 0 Then
            p.PrecoPromocional = 0.0
        Else
            p.PrecoPromocional = Me.TextBoxPrecoPromocional.Text
        End If
        p.Referencia = Me.TextBoxReferencia.Text
    End Sub

    Private Sub ButtonInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInserir.Click
        If ValidaDados() Then


            Dim p As New cmProduto()

            MoveDadosFormParaObjeto(p)

            Me.Cursor = Cursors.WaitCursor
            If p.Insert() Then
                Me.Cursor = Cursors.Default
                Me.TextBoxIDProduto.Text = p.ID
                MsgBox("Produto criado.", MsgBoxStyle.Information, "Aviso")
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            Else
                Me.Cursor = Cursors.Default
                MsgBox("Erro ao criar produto.", MsgBoxStyle.Critical, "Aviso")
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If

            Me._frmPai._produtoEditado = p

            Me.Close()
        End If
    End Sub


    Private Function ValidaDados() As Boolean
        If Me.ComboBoxCategoria.SelectedIndex < 0 Then
            MsgBox("selecione uma categoria.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
            Me.ComboBoxCategoria.Focus()
            Return False
        End If

        If Me.TextBoxNome.Text.Trim().Length = 0 Then
            MsgBox("Informe um nome.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
            Me.TextBoxNome.Focus()
            Return False
        End If

        If Me.TextBoxPrecoNormal.Text.Trim().Length = 0 Then
            MsgBox("Informe o preço normal do produto.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
            Me.TextBoxPrecoNormal.Focus()
            Return False
        Else
            If Not IsNumeric(Me.TextBoxPrecoNormal.Text) Then
                MsgBox("Preço normal do produto inválido.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
                Me.TextBoxPrecoNormal.Focus()
                Return False
            Else
                If CType(Me.TextBoxPrecoNormal.Text, Double) < 0 Then
                    MsgBox("O preço normal do produto não pode ser negativo.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
                    Me.TextBoxPrecoNormal.Focus()
                    Return False
                End If
            End If
        End If

        If Me.TextBoxQtdeParcelas.Text.Trim().Length = 0 Then
            MsgBox("Informe a quantidade de parcelas.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
            Me.TextBoxQtdeParcelas.Focus()
            Return False
        Else
            If CType(Me.TextBoxQtdeParcelas.Text, Int16) < 1 Or CType(Me.TextBoxQtdeParcelas.Text, Int16) > 12 Then
                MsgBox("A quantidade de parcelas deve estar entre 1 e 12", MsgBoxStyle.Exclamation, "Impossível prosseguir")
                Me.TextBoxQtdeParcelas.Focus()
                Return False
            End If
        End If

        If CheckBoxPromocao.Checked Then
            If Me.TextBoxPrecoPromocional.Text.Trim().Length = 0 Then
                MsgBox("Informe o preço promocional do produto.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
                Me.TextBoxPrecoPromocional.Focus()
                Return False
            Else
                If Not IsNumeric(Me.TextBoxPrecoPromocional.Text) Then
                    MsgBox("Preço promocional do produto inválido.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
                    Me.TextBoxPrecoPromocional.Focus()
                    Return False
                Else
                    If CType(Me.TextBoxPrecoPromocional.Text, Double) < 0 Then
                        MsgBox("O preço promocional do produto não pode ser negativo.", MsgBoxStyle.Exclamation, "Impossível prosseguir")
                        Me.TextBoxPrecoPromocional.Focus()
                        Return False
                    End If
                End If
            End If
        End If

        Return True

    End Function

    Private Sub TextBoxPrecoNormal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPrecoNormal.KeyPress
        TrataEntradaPreco(sender, e)

        Me.OnKeyPress(e)

    End Sub


    Private Sub TrataEntradaPreco(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPrecoNormal.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        Else
            If Not Char.IsNumber(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "," Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CheckBoxPromocao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxPromocao.CheckedChanged
        If Me.CheckBoxPromocao.Checked Then
            Me.TextBoxPrecoPromocional.Enabled = True
        Else
            Me.TextBoxPrecoPromocional.Enabled = False
            Me.TextBoxPrecoPromocional.Clear()
        End If
    End Sub

    Private Sub TextBoxPrecoPromocional_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPrecoPromocional.KeyPress
        TrataEntradaPreco(sender, e)

        Me.OnKeyPress(e)
    End Sub

    Private Sub ButtonSaveEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveEdit.Click

        If ValidaDados() Then

            Me.Cursor = Cursors.WaitCursor
            MoveDadosFormParaObjeto(Me._produtoEditar)

            If _produtoEditar.Update() Then
                Me.Cursor = Cursors.Default
                MsgBox("Produto alterado.", MsgBoxStyle.Information, "Aviso")
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            Else
                Me.Cursor = Cursors.Default
                MsgBox("Erro ao alterar produto.", MsgBoxStyle.Critical, "Aviso")
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If

            Me.Cursor = Cursors.Default

            Me.Close()
        End If
    End Sub

    Private Sub ButtonExcluirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExcluirProduto.Click
        If MsgBox("Confirma a exclusão deste produto com todos os seus modelos?", MsgBoxStyle.YesNo + vbQuestion, "Confirmação") = vbYes Then
            Me.Cursor = Cursors.WaitCursor
            If Me._produtoEditar.Delete() Then
                _frmPai.DataGridView1.ClearSelection()
                Me.Cursor = Cursors.Default
                MsgBox("Produto excluído.", MsgBoxStyle.Information, "Aviso")
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            Else
                Me.Cursor = Cursors.Default
                MsgBox("Erro ao excluir produto.", MsgBoxStyle.Critical, "Aviso")
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class