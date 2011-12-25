Public Class Categoria_Edit
    Public ParentRow As Int16
    Public Operacao As New String("")



    'Public Original_ID As Int16
    'Public Original_Nome As String
    'Public Original_Descricao As String
    'Public Original_URL As String
    'Public Original_Dica As String

    Private Sub Categoria_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Nome_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nome.Validated
        Me.Descricao.Text = Me.Nome.Text
        Me.URL.Text = Me.Nome.Text.Replace(" ", "-").ToLower()
        Me.Dica.Text = Me.Nome.Text
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInserir.Click
        Dim c As New cmCategoria()
        c.Nome = Me.Nome.Text
        c.Descricao = Me.Descricao.Text
        c.URLAmigavel = Me.URL.Text
        c.Dica = Me.Dica.Text

        If c.Insert() Then
            MsgBox("Categoria criada.", MsgBoxStyle.Information, "Aviso")
        Else
            MsgBox("Erro ao criar a categoria", MsgBoxStyle.Critical, "Aviso")
        End If

        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAlterar.Click
        Dim c As New cmCategoria()
        c.ID = Me.ID.Text
        c.Nome = Me.Nome.Text
        c.Descricao = Me.Descricao.Text
        c.URLAmigavel = Me.URL.Text
        c.Dica = Me.Dica.Text

        If c.Update() Then
            MsgBox("Categoria alterada.", MsgBoxStyle.Information, "Aviso")
        Else
            MsgBox("Erro ao alterar a categoria", MsgBoxStyle.Critical, "Aviso")
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExcluir.Click
        Dim c As New cmCategoria()
        c.ID = Me.ID.Text

        If MsgBox("Exclui a categoria?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmação") = MsgBoxResult.Yes Then
            If c.Delete() Then
                MsgBox("Categoria excluída.", MsgBoxStyle.Information, "Aviso")
            Else
                MsgBox("Erro ao excluir a categoria", MsgBoxStyle.Critical, "Aviso")
            End If
        End If

        Me.Close()

    End Sub

    Private Sub Categoria_Edit_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Me.Operacao = "U" Then
            Me.Descricao.Focus()
        End If
    End Sub
End Class