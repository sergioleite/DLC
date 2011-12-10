'Imports MvcApplication1.Entities
Imports MvcApplication1.Vitrine

<HandleError()> _
Public Class ccHomeController
    Inherits System.Web.Mvc.Controller



    Function Vitrine() As ActionResult
        'http://www.asp.net/mvc/tutorials/creating-model-classes-with-the-entity-framework-cs

        Dim aVitrine As New cmVitrine()

        ViewData.Model = aVitrine

        Return View()

    End Function

    Function VitrineCategoria(ByVal categoria As String, ByVal tamanho As String, ByVal cor As String) As ActionResult
        'http://www.asp.net/mvc/tutorials/creating-model-classes-with-the-entity-framework-cs

        ViewData.Model = New cmVitrineCategoria(categoria, tamanho, cor)

        Return View()

    End Function


    'Function Produto() As ActionResult
    '    'http://www.asp.net/mvc/tutorials/creating-model-classes-with-the-entity-framework-cs

    '    ViewData.Model = New cmVitrine()

    '    Return View()

    'End Function

    'Function Produto1() As ActionResult
    '    'http://www.asp.net/mvc/tutorials/creating-model-classes-with-the-entity-framework-cs

    '    ViewData.Model = New cmVitrine()

    '    Return View()

    'End Function

    'Function Produto2(Optional ByVal prodId As Long = 0) As ActionResult
    '    'http://www.asp.net/mvc/tutorials/creating-model-classes-with-the-entity-framework-cs

    '    ViewData.Model = New cmVitrine()

    '    Return View()

    'End Function

    'Function VitrineFiltrada(ByVal categoria As String, ByVal tamanho As String, ByVal cor As String) As ActionResult
    '    ViewData.Model = categoria & tamanho & cor
    '    Return View()
    'End Function


End Class
