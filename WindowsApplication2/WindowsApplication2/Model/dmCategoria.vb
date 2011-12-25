Imports System.Data.SqlClient

Public Class cmCategoria
    Public ID As String
    Public Nome As String
    Public Descricao As String
    Public URLAmigavel As String
    Public Dica As String

    Public Sub New()

    End Sub

    Public Sub New(ByRef dr As SqlDataReader)
        Me.ID = dr.GetInt32(dr.GetOrdinal("ID"))
        Me.Nome = dr.GetString(dr.GetOrdinal("NOME"))
        Me.Descricao = dr.GetString(dr.GetOrdinal("DESCRICAO"))
        Me.URLAmigavel = dr.GetString(dr.GetOrdinal("WEBVIEW_URL_AMIGAVEL"))
        Me.Dica = dr.GetString(dr.GetOrdinal("WEBVIEW_DICA"))
    End Sub

    Public Function Insert() As Boolean
        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand


        Try

            cmd.CommandText = "dbo.adml_categoria_insert"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nome", Me.Nome)
            cmd.Parameters.AddWithValue("@descricao", Me.Descricao)
            cmd.Parameters.AddWithValue("@url", Me.URLAmigavel)
            cmd.Parameters.AddWithValue("@dica", Me.Dica)

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

            cmd.CommandText = "dbo.adml_categoria_update"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", Me.ID)
            cmd.Parameters.AddWithValue("@nome", Me.Nome)
            cmd.Parameters.AddWithValue("@descricao", Me.Descricao)
            cmd.Parameters.AddWithValue("@url", Me.URLAmigavel)
            cmd.Parameters.AddWithValue("@dica", Me.Dica)

            cmd.Connection = sqlConnection1

            sqlConnection1.Open()

            cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception

        Finally
            sqlConnection1.Close()
        End Try
    End Function

    Public Function Delete() As Boolean
        Dim sqlConnection1 As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand


        Try

            cmd.CommandText = "dbo.adml_categoria_delete"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", Me.ID)

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
