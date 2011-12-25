Public Class Categorias

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DLC1DataSet.CATEGORIA' table. You can move, or remove it, as needed.
        Me.CATEGORIATableAdapter.Fill(Me.DLC1DataSet.CATEGORIA)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.CATEGORIATableAdapter.Update(Me.DLC1DataSet.CATEGORIA)
        'DLC1DataSet.CATEGORIA.AcceptChanges()

    End Sub

    Private Sub Inserido(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs)

    End Sub

    Private Sub UserAddedRow_Evento(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)

    End Sub


    Private Sub Validated_Evento(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Validating_Evento(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub DataGridView1_RowValidated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Me.CATEGORIATableAdapter.Update(Me.DLC1DataSet.CATEGORIA)
    End Sub

    Private Sub DataGridView1_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
        'Me.CATEGORIATableAdapter.Update(Me.DLC1DataSet.CATEGORIA)
    End Sub

    Private Sub DataGridView1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Validated

    End Sub

    Private Sub DataGridView1_UserDeletedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        Me.CATEGORIATableAdapter.Update(Me.DLC1DataSet.CATEGORIA)
    End Sub

    Private Sub DataGridView1_CellValidated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValidated
        Me.CATEGORIATableAdapter.Update(Me.DLC1DataSet.CATEGORIA)
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Edit(e.RowIndex)
    End Sub

    Private Sub ButtonNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNovo.Click
        Dim frmEdit As New Categoria_Edit()
        frmEdit.Operacao = "I"
        frmEdit.ShowDialog()
        Me.CATEGORIATableAdapter.Fill(Me.DLC1DataSet.CATEGORIA)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Edit(e.RowIndex)
    End Sub

    Sub Edit(ByVal RowIndex As Int16)
        Dim frmEdit As New Categoria_Edit()

        frmEdit.Operacao = "U"


        frmEdit.ID.Text = Me.CATEGORIATableAdapter.GetData(RowIndex).ID
        frmEdit.Nome.Text = Me.CATEGORIATableAdapter.GetData(RowIndex).NOME
        frmEdit.Descricao.Text = Me.CATEGORIATableAdapter.GetData(RowIndex).DESCRICAO
        frmEdit.URL.Text = Me.CATEGORIATableAdapter.GetData(RowIndex).WEBVIEW_URL_AMIGAVEL
        frmEdit.Dica.Text = Me.CATEGORIATableAdapter.GetData(RowIndex).WEBVIEW_DICA

        frmEdit.ParentRow = RowIndex

        frmEdit.ShowDialog()

        Me.CATEGORIATableAdapter.Fill(Me.DLC1DataSet.CATEGORIA)
    End Sub
End Class
