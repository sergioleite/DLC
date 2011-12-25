<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produto_Edit
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
        Me.ComboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBoxPromocao = New System.Windows.Forms.CheckBox()
        Me.TextBoxPrecoNormal = New System.Windows.Forms.TextBox()
        Me.TextBoxQtdeParcelas = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecoPromocional = New System.Windows.Forms.TextBox()
        Me.TextBoxReferencia = New System.Windows.Forms.TextBox()
        Me.TextBoxFabricante = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxIDProduto = New System.Windows.Forms.TextBox()
        Me.ButtonInserir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxDescricaoHTML = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxCategoria
        '
        Me.ComboBoxCategoria.FormattingEnabled = True
        Me.ComboBoxCategoria.Location = New System.Drawing.Point(105, 36)
        Me.ComboBoxCategoria.Name = "ComboBoxCategoria"
        Me.ComboBoxCategoria.Size = New System.Drawing.Size(208, 21)
        Me.ComboBoxCategoria.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Categoria:"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(105, 64)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(346, 20)
        Me.TextBoxNome.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome Produto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(451, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "(*não aparece no site)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Preço Normal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Qtde. Parcelas:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxPrecoPromocional)
        Me.GroupBox1.Controls.Add(Me.CheckBoxPromocao)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 73)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Promoção"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Preço Promocional:"
        '
        'CheckBoxPromocao
        '
        Me.CheckBoxPromocao.AutoSize = True
        Me.CheckBoxPromocao.Location = New System.Drawing.Point(5, 19)
        Me.CheckBoxPromocao.Name = "CheckBoxPromocao"
        Me.CheckBoxPromocao.Size = New System.Drawing.Size(91, 17)
        Me.CheckBoxPromocao.TabIndex = 9
        Me.CheckBoxPromocao.Text = "Em promoção"
        Me.CheckBoxPromocao.UseVisualStyleBackColor = True
        '
        'TextBoxPrecoNormal
        '
        Me.TextBoxPrecoNormal.Location = New System.Drawing.Point(105, 148)
        Me.TextBoxPrecoNormal.Name = "TextBoxPrecoNormal"
        Me.TextBoxPrecoNormal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrecoNormal.TabIndex = 10
        '
        'TextBoxQtdeParcelas
        '
        Me.TextBoxQtdeParcelas.Location = New System.Drawing.Point(105, 175)
        Me.TextBoxQtdeParcelas.Name = "TextBoxQtdeParcelas"
        Me.TextBoxQtdeParcelas.Size = New System.Drawing.Size(33, 20)
        Me.TextBoxQtdeParcelas.TabIndex = 11
        '
        'TextBoxPrecoPromocional
        '
        Me.TextBoxPrecoPromocional.Location = New System.Drawing.Point(105, 42)
        Me.TextBoxPrecoPromocional.Name = "TextBoxPrecoPromocional"
        Me.TextBoxPrecoPromocional.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrecoPromocional.TabIndex = 12
        '
        'TextBoxReferencia
        '
        Me.TextBoxReferencia.Location = New System.Drawing.Point(105, 91)
        Me.TextBoxReferencia.Name = "TextBoxReferencia"
        Me.TextBoxReferencia.Size = New System.Drawing.Size(223, 20)
        Me.TextBoxReferencia.TabIndex = 12
        '
        'TextBoxFabricante
        '
        Me.TextBoxFabricante.Location = New System.Drawing.Point(105, 118)
        Me.TextBoxFabricante.Name = "TextBoxFabricante"
        Me.TextBoxFabricante.Size = New System.Drawing.Size(346, 20)
        Me.TextBoxFabricante.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Referência:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Fabricante:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Cód.Produto:"
        '
        'TextBoxIDProduto
        '
        Me.TextBoxIDProduto.Enabled = False
        Me.TextBoxIDProduto.Location = New System.Drawing.Point(105, 6)
        Me.TextBoxIDProduto.Name = "TextBoxIDProduto"
        Me.TextBoxIDProduto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIDProduto.TabIndex = 17
        '
        'ButtonInserir
        '
        Me.ButtonInserir.Location = New System.Drawing.Point(8, 466)
        Me.ButtonInserir.Name = "ButtonInserir"
        Me.ButtonInserir.Size = New System.Drawing.Size(135, 24)
        Me.ButtonInserir.TabIndex = 18
        Me.ButtonInserir.Text = "Gravar novo produto"
        Me.ButtonInserir.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(210, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Descrição do produto no site para o cliente"
        '
        'TextBoxDescricaoHTML
        '
        Me.TextBoxDescricaoHTML.Location = New System.Drawing.Point(9, 322)
        Me.TextBoxDescricaoHTML.Multiline = True
        Me.TextBoxDescricaoHTML.Name = "TextBoxDescricaoHTML"
        Me.TextBoxDescricaoHTML.Size = New System.Drawing.Size(542, 134)
        Me.TextBoxDescricaoHTML.TabIndex = 20
        '
        'Produto_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 502)
        Me.Controls.Add(Me.TextBoxDescricaoHTML)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ButtonInserir)
        Me.Controls.Add(Me.TextBoxIDProduto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxFabricante)
        Me.Controls.Add(Me.TextBoxReferencia)
        Me.Controls.Add(Me.TextBoxQtdeParcelas)
        Me.Controls.Add(Me.TextBoxPrecoNormal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxCategoria)
        Me.Name = "Produto_Edit"
        Me.Text = "Cadastro de Produto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxPromocao As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxPrecoPromocional As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrecoNormal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxQtdeParcelas As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxReferencia As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFabricante As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxIDProduto As System.Windows.Forms.TextBox
    Friend WithEvents ButtonInserir As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescricaoHTML As System.Windows.Forms.TextBox
End Class
