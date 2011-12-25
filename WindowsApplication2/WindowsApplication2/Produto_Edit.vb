
Public Class Produto_Edit
    Public _Categorias As Collection
    Public _Operacao As New String("")

    Private Sub Produto_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulaComboCategoria()
    End Sub


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

    Private Sub ButtonInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInserir.Click
        Dim p As New cmProduto()
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

        If p.Insert() Then
            MsgBox("Produto criado.", MsgBoxStyle.Information, "Aviso")
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        Else
            MsgBox("Erro ao criar produto.", MsgBoxStyle.Critical, "Aviso")
            Me.DialogResult = Windows.Forms.DialogResult.No
        End If

        Me.Close()
    End Sub
End Class