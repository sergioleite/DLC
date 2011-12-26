Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class Imagem_Modelo

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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim request As FtpWebRequest
        request = WebRequest.Create("ftp://ftp.deboraleite.com.br/Dados/destino.jpeg")
        request.Method = WebRequestMethods.Ftp.UploadFile

        request.Credentials = New NetworkCredential("deboraleit", "tanacara")

        Dim sourceStream As New StreamReader("C:\Users\1\AppData\Roaming\Local Libraries\Local Documents\Visual Studio 2010\MvcApplication1\MvcApplication1\images\chinelo-feminino-werner-preto-site_produtos-1088044656.jpg")
        Dim fileContents As Byte()
        fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd())
        sourceStream.Close()
        request.ContentLength = fileContents.Length

        Dim requestStream As Stream
        requestStream = request.GetRequestStream()
        requestStream.Write(fileContents, 0, fileContents.Length)
        requestStream.Close()

        Dim response As FtpWebResponse
        response = request.GetResponse()

        Dim status As String
        '226 Transfer complete
        status = response.StatusDescription

        response.Close()

    End Sub

    Private Sub ButtonOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOk.Click
        AdicionaPerspectivaNaColecao()

        Me.Close()

    End Sub

    Private Sub AdicionaPerspectivaNaColecao()
        Dim p As New cmPerspectivaImagem

        p.Perspectiva = GetNumProximaPerspectiva()

        'ADICIONA AS IMAGENS DENTRO DA PERSPECTIVA
        Dim img As cmImagemModelo

        'Pequeno
        img = New cmImagemModelo
        img.NomeArquivo = PictureBoxP.ImageLocation
        img.TamanhoPMG = "P"
        img.Perspectiva = p.Perspectiva

        p.Imagens.Add(img)

        'Médio
        img = New cmImagemModelo
        img.NomeArquivo = PictureBoxM.ImageLocation
        img.TamanhoPMG = "M"
        img.Perspectiva = p.Perspectiva

        p.Imagens.Add(img)

        'Grande
        img = New cmImagemModelo
        img.NomeArquivo = PictureBoxG.ImageLocation
        img.TamanhoPMG = "G"
        img.Perspectiva = p.Perspectiva

        p.Imagens.Add(img)


        'Adiciona a nova perspectiva, com suas imagens na coleção de perspectivas do modelo
        frmPai._modelo.Perspectivas.Add(p)


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
End Class