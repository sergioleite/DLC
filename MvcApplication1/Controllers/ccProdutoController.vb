Imports MvcApplication1.Vitrine


Namespace MvcApplication1
    Public Class ccProdutoController
        Inherits System.Web.Mvc.Controller

        REM Solução para erro de java script
        REM http://www.google.com/search?q=vs+2010+controller+is+calles+twice&ie=utf-8&oe=utf-8&aq=t&rls=org.mozilla:en-US:official&client=firefox-a#sclient=psy-ab&hl=en&client=firefox-a&hs=xC&rls=org.mozilla:en-US%3Aofficial&source=hp&q=vs+2010+controller+is+calles+twice+error+in+document+ready+function+error+null+document&pbx=1&oq=vs+2010+controller+is+calles+twice+error+in+document+ready+function+error+null+document&aq=f&aqi=&aql=1&gs_sm=e&gs_upl=1634601l1637670l1l1638206l20l18l0l0l0l0l764l7518l3-6.9.1.1l17l0&bav=on.2,or.r_gc.r_pw.,cf.osb&fp=f23689a26f36edf4&biw=930&bih=453
        REM http://blog.dreamlabsolutions.com/post/2009/02/24/jQuery-document-ready-and-ASP-NET-Ajax-asynchronous-postback.aspx
        REM http://blog.evereq.com/blog/index.php/2010/07/asp-net-mvc-controller-action-being-called-twice-issues/

        '
        ' GET: /Produto

        Function ProdutoDetalhamento(ByVal url_amigavel_nomeproduto As String, ByVal id_modelo As Int16) As ActionResult
            'ByVal produto As String, Optional ByVal id As Long = 0
            'Optional ByVal prodId As Long = 0

            Dim dm As New cmProdutoDetalhamento(id_modelo)

            'ViewData.Model = New cmVitrine()

            ViewData.Model = dm

            Return View()
        End Function

    End Class
End Namespace