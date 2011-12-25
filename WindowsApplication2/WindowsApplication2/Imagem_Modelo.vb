Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class Imagem_Modelo

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
End Class