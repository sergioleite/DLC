<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produtos
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NOME_CATEGORIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECO_NORMAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTDE_PARCELAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_PROMOCAO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PRECO__PROMOCIONAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFERENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FABRICANTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonNovoProduto = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Modelo_Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELO_LIBERADOVENDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELO_COR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELO_URL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonNovoModelo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.ButtonNovaImagem = New System.Windows.Forms.Button()
        Me.IMAGEM_PERSPECTIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOME_CATEGORIA, Me.ID, Me.NOME, Me.PRECO_NORMAL, Me.QTDE_PARCELAS, Me.EM_PROMOCAO, Me.PRECO__PROMOCIONAL, Me.REFERENCIA, Me.FABRICANTE})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(978, 163)
        Me.DataGridView1.TabIndex = 0
        '
        'NOME_CATEGORIA
        '
        Me.NOME_CATEGORIA.HeaderText = "Categoria"
        Me.NOME_CATEGORIA.Name = "NOME_CATEGORIA"
        Me.NOME_CATEGORIA.ReadOnly = True
        '
        'ID
        '
        Me.ID.HeaderText = "Código Produto"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'NOME
        '
        Me.NOME.HeaderText = "Nome Produto"
        Me.NOME.Name = "NOME"
        Me.NOME.ReadOnly = True
        '
        'PRECO_NORMAL
        '
        Me.PRECO_NORMAL.HeaderText = "Preço Normal"
        Me.PRECO_NORMAL.Name = "PRECO_NORMAL"
        Me.PRECO_NORMAL.ReadOnly = True
        '
        'QTDE_PARCELAS
        '
        Me.QTDE_PARCELAS.HeaderText = "Qtd.Parcelas"
        Me.QTDE_PARCELAS.Name = "QTDE_PARCELAS"
        Me.QTDE_PARCELAS.ReadOnly = True
        '
        'EM_PROMOCAO
        '
        Me.EM_PROMOCAO.HeaderText = "Está em Promoção?"
        Me.EM_PROMOCAO.Name = "EM_PROMOCAO"
        Me.EM_PROMOCAO.ReadOnly = True
        Me.EM_PROMOCAO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EM_PROMOCAO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PRECO__PROMOCIONAL
        '
        Me.PRECO__PROMOCIONAL.HeaderText = "Preço Promocional"
        Me.PRECO__PROMOCIONAL.Name = "PRECO__PROMOCIONAL"
        Me.PRECO__PROMOCIONAL.ReadOnly = True
        '
        'REFERENCIA
        '
        Me.REFERENCIA.HeaderText = "Referência"
        Me.REFERENCIA.Name = "REFERENCIA"
        Me.REFERENCIA.ReadOnly = True
        '
        'FABRICANTE
        '
        Me.FABRICANTE.HeaderText = "Fabricante"
        Me.FABRICANTE.Name = "FABRICANTE"
        Me.FABRICANTE.ReadOnly = True
        '
        'ButtonNovoProduto
        '
        Me.ButtonNovoProduto.Location = New System.Drawing.Point(0, 169)
        Me.ButtonNovoProduto.Name = "ButtonNovoProduto"
        Me.ButtonNovoProduto.Size = New System.Drawing.Size(88, 25)
        Me.ButtonNovoProduto.TabIndex = 1
        Me.ButtonNovoProduto.Text = "Novo Produto"
        Me.ButtonNovoProduto.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Modelo_Nome, Me.MODELO_LIBERADOVENDA, Me.MODELO_COR, Me.MODELO_URL})
        Me.DataGridView2.Location = New System.Drawing.Point(0, 200)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(417, 274)
        Me.DataGridView2.TabIndex = 2
        '
        'Modelo_Nome
        '
        Me.Modelo_Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Modelo_Nome.HeaderText = "Nome Modelo"
        Me.Modelo_Nome.Name = "Modelo_Nome"
        Me.Modelo_Nome.ReadOnly = True
        Me.Modelo_Nome.Width = 90
        '
        'MODELO_LIBERADOVENDA
        '
        Me.MODELO_LIBERADOVENDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MODELO_LIBERADOVENDA.HeaderText = "Liberado p/ venda"
        Me.MODELO_LIBERADOVENDA.Name = "MODELO_LIBERADOVENDA"
        Me.MODELO_LIBERADOVENDA.ReadOnly = True
        Me.MODELO_LIBERADOVENDA.Width = 83
        '
        'MODELO_COR
        '
        Me.MODELO_COR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MODELO_COR.HeaderText = "Cor Predominante"
        Me.MODELO_COR.Name = "MODELO_COR"
        Me.MODELO_COR.ReadOnly = True
        Me.MODELO_COR.Width = 106
        '
        'MODELO_URL
        '
        Me.MODELO_URL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MODELO_URL.HeaderText = "URL"
        Me.MODELO_URL.Name = "MODELO_URL"
        Me.MODELO_URL.ReadOnly = True
        Me.MODELO_URL.Width = 54
        '
        'ButtonNovoModelo
        '
        Me.ButtonNovoModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonNovoModelo.Location = New System.Drawing.Point(0, 480)
        Me.ButtonNovoModelo.Name = "ButtonNovoModelo"
        Me.ButtonNovoModelo.Size = New System.Drawing.Size(88, 23)
        Me.ButtonNovoModelo.TabIndex = 3
        Me.ButtonNovoModelo.Text = "Novo Modelo"
        Me.ButtonNovoModelo.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(452, 171)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(525, 331)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonNovaImagem)
        Me.TabPage1.Controls.Add(Me.DataGridView3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(517, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(517, 305)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMAGEM_PERSPECTIVA})
        Me.DataGridView3.Location = New System.Drawing.Point(7, 7)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(245, 150)
        Me.DataGridView3.TabIndex = 0
        '
        'ButtonNovaImagem
        '
        Me.ButtonNovaImagem.Location = New System.Drawing.Point(7, 164)
        Me.ButtonNovaImagem.Name = "ButtonNovaImagem"
        Me.ButtonNovaImagem.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNovaImagem.TabIndex = 1
        Me.ButtonNovaImagem.Text = "Button1"
        Me.ButtonNovaImagem.UseVisualStyleBackColor = True
        '
        'IMAGEM_PERSPECTIVA
        '
        Me.IMAGEM_PERSPECTIVA.HeaderText = "Perspectiva"
        Me.IMAGEM_PERSPECTIVA.Name = "IMAGEM_PERSPECTIVA"
        Me.IMAGEM_PERSPECTIVA.ReadOnly = True
        '
        'Produtos
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 512)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ButtonNovoModelo)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ButtonNovoProduto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Produtos"
        Me.Text = "Produtos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NOME_CATEGORIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECO_NORMAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTDE_PARCELAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EM_PROMOCAO As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PRECO__PROMOCIONAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFERENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FABRICANTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonNovoProduto As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Modelo_Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELO_LIBERADOVENDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELO_COR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELO_URL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonNovoModelo As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonNovaImagem As System.Windows.Forms.Button
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents IMAGEM_PERSPECTIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
