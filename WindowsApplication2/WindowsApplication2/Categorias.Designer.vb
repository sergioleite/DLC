<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categorias
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRICAODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WEBVIEWURLAMIGAVELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WEBVIEWDICADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DLC1DataSet = New WindowsApplication2.DLC1DataSet()
        Me.CATEGORIATableAdapter = New WindowsApplication2.DLC1DataSetTableAdapters.CATEGORIATableAdapter()
        Me.ButtonNovo = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DLC1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NOMEDataGridViewTextBoxColumn, Me.DESCRICAODataGridViewTextBoxColumn, Me.WEBVIEWURLAMIGAVELDataGridViewTextBoxColumn, Me.WEBVIEWDICADataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CATEGORIABindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(695, 403)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'NOMEDataGridViewTextBoxColumn
        '
        Me.NOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME"
        Me.NOMEDataGridViewTextBoxColumn.HeaderText = "Nome Categoria"
        Me.NOMEDataGridViewTextBoxColumn.Name = "NOMEDataGridViewTextBoxColumn"
        Me.NOMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DESCRICAODataGridViewTextBoxColumn
        '
        Me.DESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO"
        Me.DESCRICAODataGridViewTextBoxColumn.HeaderText = "Descrição"
        Me.DESCRICAODataGridViewTextBoxColumn.Name = "DESCRICAODataGridViewTextBoxColumn"
        Me.DESCRICAODataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCRICAODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'WEBVIEWURLAMIGAVELDataGridViewTextBoxColumn
        '
        Me.WEBVIEWURLAMIGAVELDataGridViewTextBoxColumn.DataPropertyName = "WEBVIEW_URL_AMIGAVEL"
        Me.WEBVIEWURLAMIGAVELDataGridViewTextBoxColumn.HeaderText = "URL Amigável"
        Me.WEBVIEWURLAMIGAVELDataGridViewTextBoxColumn.Name = "WEBVIEWURLAMIGAVELDataGridViewTextBoxColumn"
        Me.WEBVIEWURLAMIGAVELDataGridViewTextBoxColumn.ReadOnly = True
        Me.WEBVIEWURLAMIGAVELDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'WEBVIEWDICADataGridViewTextBoxColumn
        '
        Me.WEBVIEWDICADataGridViewTextBoxColumn.DataPropertyName = "WEBVIEW_DICA"
        Me.WEBVIEWDICADataGridViewTextBoxColumn.HeaderText = "Dica ponteiro mouse"
        Me.WEBVIEWDICADataGridViewTextBoxColumn.Name = "WEBVIEWDICADataGridViewTextBoxColumn"
        Me.WEBVIEWDICADataGridViewTextBoxColumn.ReadOnly = True
        Me.WEBVIEWDICADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CATEGORIABindingSource
        '
        Me.CATEGORIABindingSource.DataMember = "CATEGORIA"
        Me.CATEGORIABindingSource.DataSource = Me.BindingSource1
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.DLC1DataSet
        Me.BindingSource1.Position = 0
        '
        'DLC1DataSet
        '
        Me.DLC1DataSet.DataSetName = "DLC1DataSet"
        Me.DLC1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CATEGORIATableAdapter
        '
        Me.CATEGORIATableAdapter.ClearBeforeFill = True
        '
        'ButtonNovo
        '
        Me.ButtonNovo.Location = New System.Drawing.Point(1, 421)
        Me.ButtonNovo.Name = "ButtonNovo"
        Me.ButtonNovo.Size = New System.Drawing.Size(113, 23)
        Me.ButtonNovo.TabIndex = 2
        Me.ButtonNovo.Text = "Nova categoria"
        Me.ButtonNovo.UseVisualStyleBackColor = True
        '
        'Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 456)
        Me.Controls.Add(Me.ButtonNovo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Categorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Categorias"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DLC1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DLC1DataSet As WindowsApplication2.DLC1DataSet
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CATEGORIABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CATEGORIATableAdapter As WindowsApplication2.DLC1DataSetTableAdapters.CATEGORIATableAdapter
    Friend WithEvents ButtonNovo As System.Windows.Forms.Button
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRICAODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WEBVIEWURLAMIGAVELDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WEBVIEWDICADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
