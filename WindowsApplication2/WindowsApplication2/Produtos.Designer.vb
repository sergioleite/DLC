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
        Me.DataGridViewModelos = New System.Windows.Forms.DataGridView()
        Me.Modelo_Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELO_LIBERADOVENDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELO_COR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonNovoModelo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewPerspectivas = New System.Windows.Forms.DataGridView()
        Me.IMAGEM_PERSPECTIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonNovaImagem = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBoxEstoque33 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxEstoque40 = New System.Windows.Forms.TextBox()
        Me.TextBoxEstoque34 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxEstoque35 = New System.Windows.Forms.TextBox()
        Me.TextBoxEstoque39 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxEstoque36 = New System.Windows.Forms.TextBox()
        Me.TextBoxEstoque38 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxEstoque37 = New System.Windows.Forms.TextBox()
        Me.ButtonExcluirModelo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonGravaNovoModelo = New System.Windows.Forms.Button()
        Me.Button_GravaAlteracaoModelo = New System.Windows.Forms.Button()
        Me.TextBox_NomeModelo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_LiberadoVenda_Nao = New System.Windows.Forms.RadioButton()
        Me.RadioButton_LiberadoVenda_Sim = New System.Windows.Forms.RadioButton()
        Me.ComboBoxCores = New System.Windows.Forms.ComboBox()
        Me.TextBox_ModeloURL = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxFabricante = New System.Windows.Forms.TextBox()
        Me.TextBoxReferencia = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecoPromocional = New System.Windows.Forms.TextBox()
        Me.TextBoxQtdeParcelas = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LabelPrecoPromocional = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxPrecoNormal = New System.Windows.Forms.TextBox()
        Me.TextBoxCategoria = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewModelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridViewPerspectivas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1008, 261)
        Me.DataGridView1.TabIndex = 0
        '
        'NOME_CATEGORIA
        '
        Me.NOME_CATEGORIA.HeaderText = "Categoria"
        Me.NOME_CATEGORIA.Name = "NOME_CATEGORIA"
        Me.NOME_CATEGORIA.ReadOnly = True
        Me.NOME_CATEGORIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ID
        '
        Me.ID.HeaderText = "Código Produto"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'NOME
        '
        Me.NOME.HeaderText = "Nome Produto"
        Me.NOME.Name = "NOME"
        Me.NOME.ReadOnly = True
        Me.NOME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PRECO_NORMAL
        '
        Me.PRECO_NORMAL.HeaderText = "Preço Normal"
        Me.PRECO_NORMAL.Name = "PRECO_NORMAL"
        Me.PRECO_NORMAL.ReadOnly = True
        Me.PRECO_NORMAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'QTDE_PARCELAS
        '
        Me.QTDE_PARCELAS.HeaderText = "Qtd.Parcelas"
        Me.QTDE_PARCELAS.Name = "QTDE_PARCELAS"
        Me.QTDE_PARCELAS.ReadOnly = True
        Me.QTDE_PARCELAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'EM_PROMOCAO
        '
        Me.EM_PROMOCAO.HeaderText = "Está em Promoção?"
        Me.EM_PROMOCAO.Name = "EM_PROMOCAO"
        Me.EM_PROMOCAO.ReadOnly = True
        Me.EM_PROMOCAO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'PRECO__PROMOCIONAL
        '
        Me.PRECO__PROMOCIONAL.HeaderText = "Preço Promocional"
        Me.PRECO__PROMOCIONAL.Name = "PRECO__PROMOCIONAL"
        Me.PRECO__PROMOCIONAL.ReadOnly = True
        Me.PRECO__PROMOCIONAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'REFERENCIA
        '
        Me.REFERENCIA.HeaderText = "Referência"
        Me.REFERENCIA.Name = "REFERENCIA"
        Me.REFERENCIA.ReadOnly = True
        Me.REFERENCIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FABRICANTE
        '
        Me.FABRICANTE.HeaderText = "Fabricante"
        Me.FABRICANTE.Name = "FABRICANTE"
        Me.FABRICANTE.ReadOnly = True
        Me.FABRICANTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ButtonNovoProduto
        '
        Me.ButtonNovoProduto.Location = New System.Drawing.Point(1, 267)
        Me.ButtonNovoProduto.Name = "ButtonNovoProduto"
        Me.ButtonNovoProduto.Size = New System.Drawing.Size(88, 25)
        Me.ButtonNovoProduto.TabIndex = 1
        Me.ButtonNovoProduto.Text = "Novo Produto"
        Me.ButtonNovoProduto.UseVisualStyleBackColor = True
        '
        'DataGridViewModelos
        '
        Me.DataGridViewModelos.AllowUserToAddRows = False
        Me.DataGridViewModelos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewModelos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Modelo_Nome, Me.MODELO_LIBERADOVENDA, Me.MODELO_COR})
        Me.DataGridViewModelos.Location = New System.Drawing.Point(0, 313)
        Me.DataGridViewModelos.MultiSelect = False
        Me.DataGridViewModelos.Name = "DataGridViewModelos"
        Me.DataGridViewModelos.Size = New System.Drawing.Size(378, 388)
        Me.DataGridViewModelos.TabIndex = 2
        '
        'Modelo_Nome
        '
        Me.Modelo_Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Modelo_Nome.HeaderText = "Nome Modelo"
        Me.Modelo_Nome.Name = "Modelo_Nome"
        Me.Modelo_Nome.ReadOnly = True
        Me.Modelo_Nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Modelo_Nome.Width = 71
        '
        'MODELO_LIBERADOVENDA
        '
        Me.MODELO_LIBERADOVENDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MODELO_LIBERADOVENDA.HeaderText = "Liberado p/ venda"
        Me.MODELO_LIBERADOVENDA.Name = "MODELO_LIBERADOVENDA"
        Me.MODELO_LIBERADOVENDA.ReadOnly = True
        Me.MODELO_LIBERADOVENDA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MODELO_LIBERADOVENDA.Width = 64
        '
        'MODELO_COR
        '
        Me.MODELO_COR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MODELO_COR.HeaderText = "Cor Predominante"
        Me.MODELO_COR.Name = "MODELO_COR"
        Me.MODELO_COR.ReadOnly = True
        Me.MODELO_COR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MODELO_COR.Width = 87
        '
        'ButtonNovoModelo
        '
        Me.ButtonNovoModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonNovoModelo.Location = New System.Drawing.Point(0, 707)
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
        Me.TabControl1.Location = New System.Drawing.Point(384, 267)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(624, 463)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(616, 437)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.ButtonExcluirModelo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ButtonGravaNovoModelo)
        Me.GroupBox3.Controls.Add(Me.Button_GravaAlteracaoModelo)
        Me.GroupBox3.Controls.Add(Me.TextBox_NomeModelo)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.ComboBoxCores)
        Me.GroupBox3.Controls.Add(Me.TextBox_ModeloURL)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(610, 322)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados do Modelo"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridViewPerspectivas)
        Me.GroupBox5.Controls.Add(Me.ButtonNovaImagem)
        Me.GroupBox5.Location = New System.Drawing.Point(259, 117)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(138, 199)
        Me.GroupBox5.TabIndex = 25
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Imagens"
        '
        'DataGridViewPerspectivas
        '
        Me.DataGridViewPerspectivas.AllowUserToAddRows = False
        Me.DataGridViewPerspectivas.AllowUserToDeleteRows = False
        Me.DataGridViewPerspectivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPerspectivas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMAGEM_PERSPECTIVA})
        Me.DataGridViewPerspectivas.Location = New System.Drawing.Point(6, 16)
        Me.DataGridViewPerspectivas.MultiSelect = False
        Me.DataGridViewPerspectivas.Name = "DataGridViewPerspectivas"
        Me.DataGridViewPerspectivas.ReadOnly = True
        Me.DataGridViewPerspectivas.Size = New System.Drawing.Size(121, 149)
        Me.DataGridViewPerspectivas.TabIndex = 0
        '
        'IMAGEM_PERSPECTIVA
        '
        Me.IMAGEM_PERSPECTIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMAGEM_PERSPECTIVA.HeaderText = "Imagens"
        Me.IMAGEM_PERSPECTIVA.Name = "IMAGEM_PERSPECTIVA"
        Me.IMAGEM_PERSPECTIVA.ReadOnly = True
        Me.IMAGEM_PERSPECTIVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IMAGEM_PERSPECTIVA.Width = 53
        '
        'ButtonNovaImagem
        '
        Me.ButtonNovaImagem.Location = New System.Drawing.Point(6, 171)
        Me.ButtonNovaImagem.Name = "ButtonNovaImagem"
        Me.ButtonNovaImagem.Size = New System.Drawing.Size(82, 23)
        Me.ButtonNovaImagem.TabIndex = 1
        Me.ButtonNovaImagem.Text = "Nova Imagem"
        Me.ButtonNovaImagem.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBoxEstoque33)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TextBoxEstoque40)
        Me.GroupBox4.Controls.Add(Me.TextBoxEstoque34)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TextBoxEstoque35)
        Me.GroupBox4.Controls.Add(Me.TextBoxEstoque39)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TextBoxEstoque36)
        Me.GroupBox4.Controls.Add(Me.TextBoxEstoque38)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TextBoxEstoque37)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 179)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(221, 135)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Estoque"
        '
        'TextBoxEstoque33
        '
        Me.TextBoxEstoque33.Location = New System.Drawing.Point(58, 17)
        Me.TextBoxEstoque33.Name = "TextBoxEstoque33"
        Me.TextBoxEstoque33.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxEstoque33.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(117, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Tam. 39"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(117, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Tam. 38"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(117, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Tam. 40"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(117, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Tam. 37"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tam. 36"
        '
        'TextBoxEstoque40
        '
        Me.TextBoxEstoque40.Location = New System.Drawing.Point(167, 80)
        Me.TextBoxEstoque40.Name = "TextBoxEstoque40"
        Me.TextBoxEstoque40.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxEstoque40.TabIndex = 11
        '
        'TextBoxEstoque34
        '
        Me.TextBoxEstoque34.Location = New System.Drawing.Point(58, 38)
        Me.TextBoxEstoque34.Name = "TextBoxEstoque34"
        Me.TextBoxEstoque34.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxEstoque34.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tam. 35"
        '
        'TextBoxEstoque35
        '
        Me.TextBoxEstoque35.Location = New System.Drawing.Point(58, 61)
        Me.TextBoxEstoque35.Name = "TextBoxEstoque35"
        Me.TextBoxEstoque35.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxEstoque35.TabIndex = 6
        '
        'TextBoxEstoque39
        '
        Me.TextBoxEstoque39.Location = New System.Drawing.Point(167, 59)
        Me.TextBoxEstoque39.Name = "TextBoxEstoque39"
        Me.TextBoxEstoque39.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxEstoque39.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tam. 34"
        '
        'TextBoxEstoque36
        '
        Me.TextBoxEstoque36.Location = New System.Drawing.Point(58, 82)
        Me.TextBoxEstoque36.Name = "TextBoxEstoque36"
        Me.TextBoxEstoque36.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxEstoque36.TabIndex = 7
        '
        'TextBoxEstoque38
        '
        Me.TextBoxEstoque38.Location = New System.Drawing.Point(167, 38)
        Me.TextBoxEstoque38.Name = "TextBoxEstoque38"
        Me.TextBoxEstoque38.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxEstoque38.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tam. 33"
        '
        'TextBoxEstoque37
        '
        Me.TextBoxEstoque37.Location = New System.Drawing.Point(167, 17)
        Me.TextBoxEstoque37.Name = "TextBoxEstoque37"
        Me.TextBoxEstoque37.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxEstoque37.TabIndex = 8
        '
        'ButtonExcluirModelo
        '
        Me.ButtonExcluirModelo.Location = New System.Drawing.Point(462, 143)
        Me.ButtonExcluirModelo.Name = "ButtonExcluirModelo"
        Me.ButtonExcluirModelo.Size = New System.Drawing.Size(142, 34)
        Me.ButtonExcluirModelo.TabIndex = 25
        Me.ButtonExcluirModelo.Text = "Excluir Modelo"
        Me.ButtonExcluirModelo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome Modelo:"
        '
        'ButtonGravaNovoModelo
        '
        Me.ButtonGravaNovoModelo.Location = New System.Drawing.Point(462, 282)
        Me.ButtonGravaNovoModelo.Name = "ButtonGravaNovoModelo"
        Me.ButtonGravaNovoModelo.Size = New System.Drawing.Size(142, 34)
        Me.ButtonGravaNovoModelo.TabIndex = 13
        Me.ButtonGravaNovoModelo.Text = "Gravar dados novo modelo"
        Me.ButtonGravaNovoModelo.UseVisualStyleBackColor = True
        Me.ButtonGravaNovoModelo.Visible = False
        '
        'Button_GravaAlteracaoModelo
        '
        Me.Button_GravaAlteracaoModelo.Location = New System.Drawing.Point(462, 210)
        Me.Button_GravaAlteracaoModelo.Name = "Button_GravaAlteracaoModelo"
        Me.Button_GravaAlteracaoModelo.Size = New System.Drawing.Size(142, 34)
        Me.Button_GravaAlteracaoModelo.TabIndex = 24
        Me.Button_GravaAlteracaoModelo.Text = "Grava alteração de dados do modelo"
        Me.Button_GravaAlteracaoModelo.UseVisualStyleBackColor = True
        Me.Button_GravaAlteracaoModelo.Visible = False
        '
        'TextBox_NomeModelo
        '
        Me.TextBox_NomeModelo.Location = New System.Drawing.Point(85, 19)
        Me.TextBox_NomeModelo.Name = "TextBox_NomeModelo"
        Me.TextBox_NomeModelo.Size = New System.Drawing.Size(436, 20)
        Me.TextBox_NomeModelo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_LiberadoVenda_Nao)
        Me.GroupBox1.Controls.Add(Me.RadioButton_LiberadoVenda_Sim)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 52)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modelo Liberado para Venda?"
        '
        'RadioButton_LiberadoVenda_Nao
        '
        Me.RadioButton_LiberadoVenda_Nao.AutoSize = True
        Me.RadioButton_LiberadoVenda_Nao.Checked = True
        Me.RadioButton_LiberadoVenda_Nao.Location = New System.Drawing.Point(79, 22)
        Me.RadioButton_LiberadoVenda_Nao.Name = "RadioButton_LiberadoVenda_Nao"
        Me.RadioButton_LiberadoVenda_Nao.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton_LiberadoVenda_Nao.TabIndex = 1
        Me.RadioButton_LiberadoVenda_Nao.TabStop = True
        Me.RadioButton_LiberadoVenda_Nao.Text = "Não"
        Me.RadioButton_LiberadoVenda_Nao.UseVisualStyleBackColor = True
        '
        'RadioButton_LiberadoVenda_Sim
        '
        Me.RadioButton_LiberadoVenda_Sim.AutoSize = True
        Me.RadioButton_LiberadoVenda_Sim.Location = New System.Drawing.Point(11, 22)
        Me.RadioButton_LiberadoVenda_Sim.Name = "RadioButton_LiberadoVenda_Sim"
        Me.RadioButton_LiberadoVenda_Sim.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton_LiberadoVenda_Sim.TabIndex = 0
        Me.RadioButton_LiberadoVenda_Sim.Text = "Sim"
        Me.RadioButton_LiberadoVenda_Sim.UseVisualStyleBackColor = True
        '
        'ComboBoxCores
        '
        Me.ComboBoxCores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCores.FormattingEnabled = True
        Me.ComboBoxCores.Items.AddRange(New Object() {"(Selecione)"})
        Me.ComboBoxCores.Location = New System.Drawing.Point(85, 47)
        Me.ComboBoxCores.Name = "ComboBoxCores"
        Me.ComboBoxCores.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCores.TabIndex = 2
        '
        'TextBox_ModeloURL
        '
        Me.TextBox_ModeloURL.Location = New System.Drawing.Point(85, 78)
        Me.TextBox_ModeloURL.Name = "TextBox_ModeloURL"
        Me.TextBox_ModeloURL.Size = New System.Drawing.Size(436, 20)
        Me.TextBox_ModeloURL.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "URL Amigável:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cor:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxFabricante)
        Me.GroupBox2.Controls.Add(Me.TextBoxReferencia)
        Me.GroupBox2.Controls.Add(Me.TextBoxPrecoPromocional)
        Me.GroupBox2.Controls.Add(Me.TextBoxQtdeParcelas)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.LabelPrecoPromocional)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TextBoxPrecoNormal)
        Me.GroupBox2.Controls.Add(Me.TextBoxCategoria)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 102)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados Compartilhados do Produto"
        '
        'TextBoxFabricante
        '
        Me.TextBoxFabricante.Location = New System.Drawing.Point(262, 75)
        Me.TextBoxFabricante.Name = "TextBoxFabricante"
        Me.TextBoxFabricante.ReadOnly = True
        Me.TextBoxFabricante.Size = New System.Drawing.Size(191, 20)
        Me.TextBoxFabricante.TabIndex = 12
        '
        'TextBoxReferencia
        '
        Me.TextBoxReferencia.Location = New System.Drawing.Point(78, 71)
        Me.TextBoxReferencia.Name = "TextBoxReferencia"
        Me.TextBoxReferencia.ReadOnly = True
        Me.TextBoxReferencia.Size = New System.Drawing.Size(92, 20)
        Me.TextBoxReferencia.TabIndex = 11
        '
        'TextBoxPrecoPromocional
        '
        Me.TextBoxPrecoPromocional.Location = New System.Drawing.Point(371, 45)
        Me.TextBoxPrecoPromocional.Name = "TextBoxPrecoPromocional"
        Me.TextBoxPrecoPromocional.ReadOnly = True
        Me.TextBoxPrecoPromocional.Size = New System.Drawing.Size(82, 20)
        Me.TextBoxPrecoPromocional.TabIndex = 10
        '
        'TextBoxQtdeParcelas
        '
        Me.TextBoxQtdeParcelas.Location = New System.Drawing.Point(236, 45)
        Me.TextBoxQtdeParcelas.Name = "TextBoxQtdeParcelas"
        Me.TextBoxQtdeParcelas.ReadOnly = True
        Me.TextBoxQtdeParcelas.Size = New System.Drawing.Size(30, 20)
        Me.TextBoxQtdeParcelas.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(189, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Fabricante:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Referência:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(164, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Qtd.Parcelas:"
        '
        'LabelPrecoPromocional
        '
        Me.LabelPrecoPromocional.AutoSize = True
        Me.LabelPrecoPromocional.Location = New System.Drawing.Point(272, 52)
        Me.LabelPrecoPromocional.Name = "LabelPrecoPromocional"
        Me.LabelPrecoPromocional.Size = New System.Drawing.Size(99, 13)
        Me.LabelPrecoPromocional.TabIndex = 4
        Me.LabelPrecoPromocional.Text = "Preço Promocional:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Preço Normal:"
        '
        'TextBoxPrecoNormal
        '
        Me.TextBoxPrecoNormal.Location = New System.Drawing.Point(78, 45)
        Me.TextBoxPrecoNormal.Name = "TextBoxPrecoNormal"
        Me.TextBoxPrecoNormal.ReadOnly = True
        Me.TextBoxPrecoNormal.Size = New System.Drawing.Size(82, 20)
        Me.TextBoxPrecoNormal.TabIndex = 2
        '
        'TextBoxCategoria
        '
        Me.TextBoxCategoria.Location = New System.Drawing.Point(78, 17)
        Me.TextBoxCategoria.Name = "TextBoxCategoria"
        Me.TextBoxCategoria.ReadOnly = True
        Me.TextBoxCategoria.Size = New System.Drawing.Size(262, 20)
        Me.TextBoxCategoria.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Categoria:"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(616, 437)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Produtos
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ButtonNovoModelo)
        Me.Controls.Add(Me.DataGridViewModelos)
        Me.Controls.Add(Me.ButtonNovoProduto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Produtos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Produtos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewModelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridViewPerspectivas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonNovoProduto As System.Windows.Forms.Button
    Friend WithEvents DataGridViewModelos As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonNovoModelo As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonNovaImagem As System.Windows.Forms.Button
    Friend WithEvents DataGridViewPerspectivas As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCores As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_NomeModelo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_LiberadoVenda_Nao As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_LiberadoVenda_Sim As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_ModeloURL As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEstoque40 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEstoque39 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEstoque38 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEstoque37 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEstoque36 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEstoque35 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEstoque34 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEstoque33 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonGravaNovoModelo As System.Windows.Forms.Button
    Friend WithEvents Button_GravaAlteracaoModelo As System.Windows.Forms.Button
    Friend WithEvents ButtonExcluirModelo As System.Windows.Forms.Button
    Friend WithEvents NOME_CATEGORIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECO_NORMAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTDE_PARCELAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EM_PROMOCAO As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PRECO__PROMOCIONAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFERENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FABRICANTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxFabricante As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxReferencia As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrecoPromocional As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxQtdeParcelas As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LabelPrecoPromocional As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPrecoNormal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents IMAGEM_PERSPECTIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Modelo_Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELO_LIBERADOVENDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELO_COR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
