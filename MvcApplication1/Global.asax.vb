' Note: For instructions on enabling IIS6 or IIS7 classic mode,
' visit http://go.microsoft.com/?LinkId=9394802
' alterei o comentario

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        ' MapRoute takes the following parameters, in order:
        ' (1) Route name
        ' (2) URL with parameters
        ' (3) Parameter defaults

        'routes.MapRoute( _
        '    "Produto", _
        '    "Produto/{url_amigavel_nomeproduto}/{id_modelo}", _
        '    New With {.controller = "ccProduto", .action = "ProdutoDetalhamento", .url_amigavel_nomeproduto = "", .id_modelo = 0} _
        ')

        'routes.MapRoute( _
        '    "Vitrine", _
        '    "Vitrine/{categoria}/{tamanho}/{cor}", _
        '    New With {.controller = "ccHome", .action = "VitrineCategoria", .categoria = "todas-categorias", .tamanho = "todos-tamanhos", .cor = "todas-cores"} _
        ')

        'routes.MapRoute( _
        '    "Default1", _
        '    "{controller}/{action}/{id}", _
        '    New With {.controller = "ccHome", .action = "Vitrine", .id = UrlParameter.Optional} _
        ')

        routes.MapRoute( _
            "Default1", _
            "{controller}/{action}/{id}", _
            New With {.controller = "ccHome", .action = "Inauguracao", .id = UrlParameter.Optional} _
        )



    End Sub

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()

        RegisterRoutes(RouteTable.Routes)

    End Sub
End Class
