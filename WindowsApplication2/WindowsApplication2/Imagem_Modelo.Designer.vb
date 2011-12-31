<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imagem_Modelo
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
        Me.PictureBoxP = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBoxM = New System.Windows.Forms.PictureBox()
        Me.PictureBoxG = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        CType(Me.PictureBoxP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxP
        '
        Me.PictureBoxP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBoxP.Location = New System.Drawing.Point(1, 31)
        Me.PictureBoxP.Name = "PictureBoxP"
        Me.PictureBoxP.Size = New System.Drawing.Size(120, 120)
        Me.PictureBoxP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxP.TabIndex = 0
        Me.PictureBoxP.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Imagem Pequena"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(128, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Imagem Média"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBoxM
        '
        Me.PictureBoxM.Location = New System.Drawing.Point(128, 31)
        Me.PictureBoxM.Name = "PictureBoxM"
        Me.PictureBoxM.Size = New System.Drawing.Size(350, 350)
        Me.PictureBoxM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxM.TabIndex = 3
        Me.PictureBoxM.TabStop = False
        '
        'PictureBoxG
        '
        Me.PictureBoxG.Location = New System.Drawing.Point(496, 31)
        Me.PictureBoxG.Name = "PictureBoxG"
        Me.PictureBoxG.Size = New System.Drawing.Size(500, 500)
        Me.PictureBoxG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxG.TabIndex = 4
        Me.PictureBoxG.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(496, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Imagem Grande"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonOk
        '
        Me.ButtonOk.Location = New System.Drawing.Point(12, 501)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOk.TabIndex = 7
        Me.ButtonOk.Text = "OK"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(108, 501)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 8
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Imagem_Modelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 536)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBoxG)
        Me.Controls.Add(Me.PictureBoxM)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBoxP)
        Me.Name = "Imagem_Modelo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imagens de uma perspectiva"
        CType(Me.PictureBoxP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBoxP As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBoxM As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxG As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
End Class
