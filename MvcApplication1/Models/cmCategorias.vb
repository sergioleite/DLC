Imports System.Data.SqlClient

Public Class cmCategorias
    Public Shared Function GetCategoriasParaVitrine() As Collection
        Dim categorias As New Collection()

        Dim c As cmCategoria

        c = New cmCategoria
        c.Id = 1
        c.href = "Scarpins"
        c.Title = "Scarpins"
        categorias.Add(c)

        c = New cmCategoria
        c.Id = 2
        c.href = "Anabela"
        c.Title = "Anabela"
        categorias.Add(c)

        c = New cmCategoria
        c.Id = 3
        c.href = "PeepToe"
        c.Title = "PeepToe"
        categorias.Add(c)

        Return categorias
    End Function


    Public Shared Function GetCategoriaByURLAmigavel(ByVal URLAmigavel As String) As cmCategoria
        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        Dim c As New cmCategoria

        Try

            cmd.CommandText = "dbo.get_categoria_por_urlamigavel"
            cmd.Parameters.AddWithValue("@URLAmigavel", URLAmigavel)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            reader = cmd.ExecuteReader()

            If reader.Read() Then
                c = New cmCategoria(reader)
            End If

            reader.Close()
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try

        Return c

    End Function

    
    Public Shared Function GetCategorias() As Collection

        GetCategorias = New Collection()

        Dim produtos As New Collection

        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader

        Try

            cmd.CommandText = "dbo.get_categorias"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            reader = cmd.ExecuteReader()

            Dim c As cmCategoria

            While reader.Read()
                c = New cmCategoria(reader)
                GetCategorias.Add(c)
            End While

            reader.Close()
        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try

        Return GetCategorias

    End Function
End Class
