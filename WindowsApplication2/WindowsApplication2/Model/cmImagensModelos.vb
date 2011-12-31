Imports System.Data.SqlClient

Public Class cmImagensModelos
    Public Shared Function GetPerspectivasDeModelo(ByVal IdModelo As Int16) As Collection
        Dim perspectivas As New Collection

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader



        cmd.CommandText = "dbo.adml_get_perspectivas_modelo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@modelo__id", IdModelo)
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        reader = cmd.ExecuteReader()

        Dim p As cmPerspectivaImagem


        On Error Resume Next

        While reader.Read()
            p = New cmPerspectivaImagem()
            p.IDModelo = IdModelo
            p.Perspectiva = reader.GetInt32(reader.GetOrdinal("PERSPECTIVA"))
            perspectivas.Add(p)
        End While

        reader.Close()
        sqlConnection1.Close()

        On Error GoTo 0

        Return perspectivas

    End Function

    Public Shared Function GetImagensDePerspectivas(ByVal IdModelo As Int16, ByVal IdPerspectiva As Int16) As Collection
        Dim imagens As New Collection

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader



        cmd.CommandText = "dbo.adml_get_imagens_de_perspectiva_modelo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@modelo__id", IdModelo)
        cmd.Parameters.AddWithValue("@perspectiva", IdPerspectiva)
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        reader = cmd.ExecuteReader()

        Dim img As cmImagemModelo


        On Error Resume Next

        While reader.Read()
            img = New cmImagemModelo()
            img.IDModelo = IdModelo
            img.NomeArquivoRemoto = reader.GetString(reader.GetOrdinal("NOMEARQUIVO"))
            img.TamanhoPMG = reader.GetString(reader.GetOrdinal("TAMANHO"))
            img.Perspectiva = reader.GetString(reader.GetOrdinal("PERSPECTIVA"))
            imagens.Add(img)
        End While

        reader.Close()
        sqlConnection1.Close()

        On Error GoTo 0

        Return imagens

    End Function

End Class
