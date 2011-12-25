<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categoria_Edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Nome = New System.Windows.Forms.TextBox()
        Me.Descricao = New System.Windows.Forms.TextBox()
        Me.URL = New System.Windows.Forms.TextBox()
        Me.Dica = New System.Windows.Forms.TextBox()
        Me.ButtonInserir = New System.Windows.Forms.Button()
        Me.ButtonAlterar = New System.Windows.Forms.Button()
        Me.CategoriaTableAdapter = New WindowsApplication2.DLC1DataSetTableAdapters.CATEGORIATableAdapter()
        Me.ButtonExcluir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ID
        '
        Me.ID.Enabled = False
        Me.ID.Location = New System.Drawing.Point(105, 12)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(100, 20)
        Me.ID.TabIndex = 0
        '
        'Nome
        '
        Me.Nome.Location = New System.Drawing.Point(105, 39)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(261, 20)
        Me.Nome.TabIndex = 1
        '
        'Descricao
        '
        Me.Descricao.Location = New System.Drawing.Point(105, 69)
        Me.Descricao.Name = "Descricao"
        Me.Descricao.Size = New System.Drawing.Size(260, 20)
        Me.Descricao.TabIndex = 2
        '
        'URL
        '
        Me.URL.Location = New System.Drawing.Point(105, 102)
        Me.URL.Name = "URL"
        Me.URL.Size = New System.Drawing.Size(259, 20)
        Me.URL.TabIndex = 3
        '
        'Dica
        '
        Me.Dica.Location = New System.Drawing.Point(105, 134)
        Me.Dica.Name = "Dica"
        Me.Dica.Size = New System.Drawing.Size(258, 20)
        Me.Dica.TabIndex = 4
        '
        'ButtonInserir
        '
        Me.ButtonInserir.Location = New System.Drawing.Point(33, 179)
        Me.ButtonInserir.Name = "ButtonInserir"
        Me.ButtonInserir.Size = New System.Drawing.Size(135, 24)
        Me.ButtonInserir.TabIndex = 5
        Me.ButtonInserir.Text = "Gravar nova categoria"
        Me.ButtonInserir.UseVisualStyleBackColor = True
        '
        'ButtonAlterar
        '
        Me.ButtonAlterar.Location = New System.Drawing.Point(33, 209)
        Me.ButtonAlterar.Name = "ButtonAlterar"
        Me.ButtonAlterar.Size = New System.Drawing.Size(135, 23)
        Me.ButtonAlterar.TabIndex = 6
        Me.ButtonAlterar.Text = "Gravar alterações"
        Me.ButtonAlterar.UseVisualStyleBackColor = True
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'ButtonExcluir
        '
        Me.ButtonExcluir.Location = New System.Drawing.Point(190, 179)
        Me.ButtonExcluir.Name = "ButtonExcluir"
        Me.ButtonExcluir.Size = New System.Drawing.Size(128, 23)
        Me.ButtonExcluir.TabIndex = 7
        Me.ButtonExcluir.Text = "Excluir categoria"
        Me.ButtonExcluir.UseVisualStyleBackColor = True
        '
        'Categoria_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 262)
        Me.Controls.Add(Me.ButtonExcluir)
        Me.Controls.Add(Me.ButtonAlterar)
        Me.Controls.Add(Me.ButtonInserir)
        Me.Controls.Add(Me.Dica)
        Me.Controls.Add(Me.URL)
        Me.Controls.Add(Me.Descricao)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.ID)
        Me.Name = "Categoria_Edit"
        Me.Text = "Categoria_Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents Nome As System.Windows.Forms.TextBox
    Friend WithEvents Descricao As System.Windows.Forms.TextBox
    Friend WithEvents URL As System.Windows.Forms.TextBox
    Friend WithEvents Dica As System.Windows.Forms.TextBox
    Friend WithEvents ButtonInserir As System.Windows.Forms.Button
    Friend WithEvents ButtonAlterar As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DLC1DataSet As WindowsApplication2.DLC1DataSet
    Friend WithEvents CategoriaTableAdapter As WindowsApplication2.DLC1DataSetTableAdapters.CATEGORIATableAdapter
    Friend WithEvents ButtonExcluir As System.Windows.Forms.Button
End Class
