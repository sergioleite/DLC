Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Net
Imports System.Text


Public Class cmImagemModelo
    Public IDModelo As Int16
    Public Perspectiva As Int16
    Public NomeArquivoRemoto As String
    Public NomeArquivoLocal As String
    Public TamanhoPMG As String

    Private _Uloaded As Boolean


    Public Function Upload() As Boolean

        Dim request As FtpWebRequest
        request = WebRequest.Create("ftp://ftp.deboraleite.com.br/Web/images/" & Me.NomeArquivoRemoto)
        request.Method = WebRequestMethods.Ftp.UploadFile
        request.UseBinary = True

        request.Credentials = New NetworkCredential("deboraleit", "tanacara")

        'Dim sourceStream As New StreamReader(Me.NomeArquivoLocal)

        Dim fileContents As Byte()
        'fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd())
        fileContents = System.IO.File.ReadAllBytes(Me.NomeArquivoLocal)
        'sourceStream.Close()
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

        If status.Substring(0, 3) = "226" Then
            Me._Uloaded = True
        End If

        response.Close()
    End Function


    Public Function Insert() As Boolean
        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand


        Try

            cmd.CommandText = "dbo.adml_imagem_insert"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@MODELO__ID", Me.IDModelo)
            cmd.Parameters.AddWithValue("@PERSPECTIVA", Me.Perspectiva)
            cmd.Parameters.AddWithValue("@NOMEARQUIVO", Me.NomeArquivoRemoto)
            cmd.Parameters.AddWithValue("@TAMANHO", Me.TamanhoPMG)

            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            cmd.ExecuteNonQuery()

            Return True
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try
    End Function

    Public Function Update() As Boolean
        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand


        Try

            cmd.CommandText = "dbo.adml_imagem_update"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@MODELO__ID", Me.IDModelo)
            cmd.Parameters.AddWithValue("@PERSPECTIVA", Me.Perspectiva)
            cmd.Parameters.AddWithValue("@NOMEARQUIVO", Me.NomeArquivoRemoto)
            cmd.Parameters.AddWithValue("@TAMANHO", Me.TamanhoPMG)

            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            cmd.ExecuteNonQuery()

            Return True
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try
    End Function
End Class


