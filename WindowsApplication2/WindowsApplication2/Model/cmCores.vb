Imports System.Data.SqlClient

Public Class cmCores
    Public Shared Function GetCores() As Collection
        Dim cores As New Collection

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        cmd.CommandText = "dbo.get_cores"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        reader = cmd.ExecuteReader()

        Dim c As cmCor

        On Error Resume Next

        While reader.Read()
            c = New cmCor()
            c.ID = reader.GetInt32(reader.GetOrdinal("ID"))
            c.Nome = reader.GetString(reader.GetOrdinal("NOME"))
            c.WEBVIEW_NOMEARQUIVO_AMOSTRA = reader.GetString(reader.GetOrdinal("WEBVIEW_NOMEARQUIVO_AMOSTRA"))
            c.WEBVIEW_URL_AMIGAVEL = reader.GetString(reader.GetOrdinal("WEBVIEW_URL_AMIGAVEL"))
            cores.Add(c, c.Nome)
        End While

        reader.Close()
        sqlConnection1.Close()

        On Error GoTo 0

        Return cores

    End Function
End Class
