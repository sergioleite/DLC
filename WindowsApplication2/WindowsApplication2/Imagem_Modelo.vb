Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class Imagem_Modelo

    Public _OperacaoCRUD As String
    Public _Perspectiva As cmPerspectivaImagem

    Public frmPai As Produtos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBoxP.ImageLocation = OpenFileDialog1.FileName()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBoxM.ImageLocation = OpenFileDialog1.FileName()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBoxG.ImageLocation = OpenFileDialog1.FileName()
        End If
    End Sub




    Private Sub ButtonOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOk.Click
        AdicionaPerspectivaNaColecao()

        Me.DialogResult = DialogResult.Yes

        Me.Close()

    End Sub

    Private Sub AdicionaPerspectivaNaColecao()
        Dim perspectiva As New cmPerspectivaImagem

        perspectiva.Perspectiva = GetNumProximaPerspectiva()

        'ADICIONA AS IMAGENS DENTRO DA PERSPECTIVA
        Dim img As cmImagemModelo

        'Pequeno
        img = New cmImagemModelo
        img.NomeArquivoLocal = PictureBoxP.ImageLocation
        img.TamanhoPMG = "P"
        img.Perspectiva = perspectiva.Perspectiva

        perspectiva.Imagens.Add(img)

        'Médio
        img = New cmImagemModelo
        img.NomeArquivoLocal = PictureBoxM.ImageLocation
        img.TamanhoPMG = "M"
        img.Perspectiva = perspectiva.Perspectiva

        perspectiva.Imagens.Add(img)

        'Grande
        img = New cmImagemModelo
        img.NomeArquivoLocal = PictureBoxG.ImageLocation
        img.TamanhoPMG = "G"
        img.Perspectiva = perspectiva.Perspectiva

        perspectiva.Imagens.Add(img)


        'Adiciona a nova perspectiva, com suas imagens na coleção de perspectivas do modelo
        frmPai._modelo.Perspectivas.Add(perspectiva)


    End Sub

    Private Function GetNumProximaPerspectiva() As Int16

        Dim prox As Int16

        For Each p As cmPerspectivaImagem In frmPai._modelo.Perspectivas
            If p.Perspectiva > prox Then
                prox = p.Perspectiva
            End If
        Next

        prox = prox + 1

        Return prox
    End Function

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub Imagem_Modelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me._OperacaoCRUD = "U" Then
            LoadImagensLocaisParaTela()
        End If
    End Sub

    Private Sub LoadImagensLocaisParaTela()
        For Each i As cmImagemModelo In Me._Perspectiva.Imagens
            If i.TamanhoPMG.ToUpper() = "P" Then
                Me.PictureBoxP.ImageLocation = i.NomeArquivoLocal
            End If
            If i.TamanhoPMG.ToUpper() = "M" Then
                Me.PictureBoxM.ImageLocation = i.NomeArquivoLocal
            End If
            If i.TamanhoPMG.ToUpper() = "G" Then
                Me.PictureBoxG.ImageLocation = i.NomeArquivoLocal
            End If
        Next
    End Sub

End Class