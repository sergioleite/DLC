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
        Me.MODELO_URL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonNovoModelo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxURL = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxEstoque40 = New System.Windows.Forms.TextBox()
        Me.TextBoxEstoque39 = New System.Windows.Forms.TextBox()
        Me.TextBoxEstoque38 = New System.Windows.Forms.TextBox()
        Me.TextBoxEstoque37 = New System.Windows.Forms.TextBox()
        Me.TextBoxEstoque36 = New System.Windows.Forms.TextBox()
        Me.TextBoxEstoque35 = New System.Windows.Forms.TextBox()
        Me.TextBoxEstoque34 = New System.Windows.Forms.TextBox()
        Me.TextBoxEstoque33 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxCores = New System.Windows.Forms.ComboBox()
        Me.TextBox_NomeModelo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_LiberadoVenda_Nao = New System.Windows.Forms.RadioButton()
        Me.RadioButton_LiberadoVenda_Sim = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonNovaImagem = New System.Windows.Forms.Button()
        Me.DataGridViewPerspectivas = New System.Windows.Forms.DataGridView()
        Me.IMAGEM_PERSPECTIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewModelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewPerspectivas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Size = New System.Drawing.Size(1008, 163)
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
        'DataGridViewModelos
        '
        Me.DataGridViewModelos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewModelos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Modelo_Nome, Me.MODELO_LIBERADOVENDA, Me.MODELO_COR, Me.MODELO_URL})
        Me.DataGridViewModelos.Location = New System.Drawing.Point(0, 200)
        Me.DataGridViewModelos.MultiSelect = False
        Me.DataGridViewModelos.Name = "DataGridViewModelos"
        Me.DataGridViewModelos.Size = New System.Drawing.Size(417, 492)
        Me.DataGridViewModelos.TabIndex = 2
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
        Me.ButtonNovoModelo.Location = New System.Drawing.Point(0, 698)
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
        Me.TabControl1.Size = New System.Drawing.Size(525, 409)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.TextBoxURL)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.TextBoxEstoque40)
        Me.TabPage1.Controls.Add(Me.TextBoxEstoque39)
        Me.TabPage1.Controls.Add(Me.TextBoxEstoque38)
        Me.TabPage1.Controls.Add(Me.TextBoxEstoque37)
        Me.TabPage1.Controls.Add(Me.TextBoxEstoque36)
        Me.TabPage1.Controls.Add(Me.TextBoxEstoque35)
        Me.TabPage1.Controls.Add(Me.TextBoxEstoque34)
        Me.TabPage1.Controls.Add(Me.TextBoxEstoque33)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ComboBoxCores)
        Me.TabPage1.Controls.Add(Me.TextBox_NomeModelo)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ButtonNovaImagem)
        Me.TabPage1.Controls.Add(Me.DataGridViewPerspectivas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(517, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(4, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 44)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Gravar dados novo modelo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxURL
        '
        Me.TextBoxURL.Location = New System.Drawing.Point(92, 295)
        Me.TextBoxURL.Name = "TextBoxURL"
        Me.TextBoxURL.Size = New System.Drawing.Size(316, 20)
        Me.TextBoxURL.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 302)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "URL Amigável:"
        '
        'TextBoxEstoque40
        '
        Me.TextBoxEstoque40.Location = New System.Drawing.Point(349, 150)
        Me.TextBoxEstoque40.Name = "TextBoxEstoque40"
        Me.TextBoxEstoque40.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxEstoque40.TabIndex = 22
        '
        'TextBoxEstoque39
        '
        Me.TextBoxEstoque39.Location = New System.Drawing.Point(349, 129)
        Me.TextBoxEstoque39.Name = "TextBoxEstoque39"
        Me.TextBoxEstoque39.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxEstoque39.TabIndex = 21
        '
        'TextBoxEstoque38
        '
        Me.TextBoxEstoque38.Location = New System.Drawing.Point(349, 108)
        Me.TextBoxEstoque38.Name = "TextBoxEstoque38"
        Me.TextBoxEstoque38.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxEstoque38.TabIndex = 20
        '
        'TextBoxEstoque37
        '
        Me.TextBoxEstoque37.Location = New System.Drawing.Point(349, 87)
        Me.TextBoxEstoque37.Name = "TextBoxEstoque37"
        Me.TextBoxEstoque37.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxEstoque37.TabIndex = 19
        '
        'TextBoxEstoque36
        '
        Me.TextBoxEstoque36.Location = New System.Drawing.Point(349, 65)
        Me.TextBoxEstoque36.Name = "TextBoxEstoque36"
        Me.TextBoxEstoque36.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxEstoque36.TabIndex = 18
        '
        'TextBoxEstoque35
        '
        Me.TextBoxEstoque35.Location = New System.Drawing.Point(349, 44)
        Me.TextBoxEstoque35.Name = "TextBoxEstoque35"
        Me.TextBoxEstoque35.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxEstoque35.TabIndex = 17
        '
        'TextBoxEstoque34
        '
        Me.TextBoxEstoque34.Location = New System.Drawing.Point(349, 21)
        Me.TextBoxEstoque34.Name = "TextBoxEstoque34"
        Me.TextBoxEstoque34.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxEstoque34.TabIndex = 16
        '
        'TextBoxEstoque33
        '
        Me.TextBoxEstoque33.Location = New System.Drawing.Point(349, 0)
        Me.TextBoxEstoque33.Name = "TextBoxEstoque33"
        Me.TextBoxEstoque33.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxEstoque33.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(265, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Estoque No 40"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(265, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Estoque No 39"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(265, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Estoque No 38"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(265, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Estoque No 37"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(265, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Estoque No 36"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(265, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Estoque No 35"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estoque No 34"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Estoque No 33"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cor:"
        '
        'ComboBoxCores
        '
        Me.ComboBoxCores.FormattingEnabled = True
        Me.ComboBoxCores.Location = New System.Drawing.Point(40, 265)
        Me.ComboBoxCores.Name = "ComboBoxCores"
        Me.ComboBoxCores.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCores.TabIndex = 5
        '
        'TextBox_NomeModelo
        '
        Me.TextBox_NomeModelo.Location = New System.Drawing.Point(79, 197)
        Me.TextBox_NomeModelo.Name = "TextBox_NomeModelo"
        Me.TextBox_NomeModelo.Size = New System.Drawing.Size(312, 20)
        Me.TextBox_NomeModelo.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_LiberadoVenda_Nao)
        Me.GroupBox1.Controls.Add(Me.RadioButton_LiberadoVenda_Sim)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 40)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modelo Liberado para Venda?"
        '
        'RadioButton_LiberadoVenda_Nao
        '
        Me.RadioButton_LiberadoVenda_Nao.AutoSize = True
        Me.RadioButton_LiberadoVenda_Nao.Checked = True
        Me.RadioButton_LiberadoVenda_Nao.Location = New System.Drawing.Point(75, 17)
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
        Me.RadioButton_LiberadoVenda_Sim.Location = New System.Drawing.Point(7, 17)
        Me.RadioButton_LiberadoVenda_Sim.Name = "RadioButton_LiberadoVenda_Sim"
        Me.RadioButton_LiberadoVenda_Sim.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton_LiberadoVenda_Sim.TabIndex = 0
        Me.RadioButton_LiberadoVenda_Sim.Text = "Sim"
        Me.RadioButton_LiberadoVenda_Sim.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome Modelo:"
        '
        'ButtonNovaImagem
        '
        Me.ButtonNovaImagem.Location = New System.Drawing.Point(7, 164)
        Me.ButtonNovaImagem.Name = "ButtonNovaImagem"
        Me.ButtonNovaImagem.Size = New System.Drawing.Size(82, 23)
        Me.ButtonNovaImagem.TabIndex = 1
        Me.ButtonNovaImagem.Text = "Nova Imagem"
        Me.ButtonNovaImagem.UseVisualStyleBackColor = True
        '
        'DataGridViewPerspectivas
        '
        Me.DataGridViewPerspectivas.AllowUserToAddRows = False
        Me.DataGridViewPerspectivas.AllowUserToDeleteRows = False
        Me.DataGridViewPerspectivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPerspectivas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMAGEM_PERSPECTIVA})
        Me.DataGridViewPerspectivas.Location = New System.Drawing.Point(7, 7)
        Me.DataGridViewPerspectivas.MultiSelect = False
        Me.DataGridViewPerspectivas.Name = "DataGridViewPerspectivas"
        Me.DataGridViewPerspectivas.ReadOnly = True
        Me.DataGridViewPerspectivas.Size = New System.Drawing.Size(245, 150)
        Me.DataGridViewPerspectivas.TabIndex = 0
        '
        'IMAGEM_PERSPECTIVA
        '
        Me.IMAGEM_PERSPECTIVA.HeaderText = "Perspectiva"
        Me.IMAGEM_PERSPECTIVA.Name = "IMAGEM_PERSPECTIVA"
        Me.IMAGEM_PERSPECTIVA.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(517, 383)
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
        Me.Text = "Produtos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewModelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewPerspectivas, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridViewModelos As System.Windows.Forms.DataGridView
    Friend WithEvents Modelo_Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELO_LIBERADOVENDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELO_COR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELO_URL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonNovoModelo As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonNovaImagem As System.Windows.Forms.Button
    Friend WithEvents DataGridViewPerspectivas As System.Windows.Forms.DataGridView
    Friend WithEvents IMAGEM_PERSPECTIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCores As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_NomeModelo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_LiberadoVenda_Nao As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_LiberadoVenda_Sim As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxURL As System.Windows.Forms.TextBox
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
