Imports System.Data.SqlClient

Public Class dmCategorias


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
