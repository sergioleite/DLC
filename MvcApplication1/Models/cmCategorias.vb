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
        Dim con As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand("select * from dbo.CATEGORIAS where CATEGORIA__WEBVIEW_URL_AMIGAVEL = '" & URLAmigavel & "'", con)

        cmd.Connection.Open()

        Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Dim c As cmCategoria

        If dr.Read() Then
            c = New cmCategoria(dr)
        End If

        dr.Close()
        con.Close()

        Return c

    End Function

    Public Shared Function GetCategorias() As Collection

        GetCategorias = New Collection()

        Dim con As New SqlConnection(My.Settings.db_connection_string)
        Dim cmd As New SqlCommand("select * from dbo.CATEGORIAS order by CATEGORIA__NOME", con)

        cmd.Connection.Open()

        Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Dim c As cmCategoria

        If dr.Read() Then
            c = New cmCategoria(dr)
            GetCategorias.Add(c)
        End If

        dr.Close()
        con.Close()

        Return GetCategorias

    End Function
End Class
