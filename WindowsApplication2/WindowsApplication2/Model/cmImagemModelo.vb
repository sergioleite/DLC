Imports System.Data.SqlClient

Public Class cmImagemModelo
    Public IDModelo As Int16
    Public Perspectiva As Int16
    Public NomeArquivo As String
    Public TamanhoPMG As String



    Public Function Insert() As Boolean
        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand


        Try

            cmd.CommandText = "dbo.adml_imagem_insert"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@MODELO__ID", Me.IDModelo)
            cmd.Parameters.AddWithValue("@PERSPECTIVA", Me.Perspectiva)
            cmd.Parameters.AddWithValue("@NOMEARQUIVO", Me.NomeArquivo)
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


