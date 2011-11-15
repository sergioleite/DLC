<%@ Import Namespace="MvcApplication1" %>
<%@ Import Namespace="Vitrine" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <title>
        Calçados femininos, calçados masculinos, tênis e acessórios - Anita Online - A sua loja de calçados 	online
    </title>
    <link rel="shortcut icon" href="http://www.anitaonline.com.br/favicon.ico" type="image/x-icon"/>
    
    <script src="../../js/jqzoom.js" type="text/javascript"></script>

    <link type="text/css" rel="stylesheet" href="../../geral.css"/>
    <link type="text/css" rel="stylesheet" href="../../padrao_20110802a.css"/>
    <link type="text/css" rel="stylesheet" href="../../padrao_20110906a.css"/>
    <link type="text/css" rel="stylesheet" href="../../produtos_300711a.css"/>
    <link type="text/css" rel="stylesheet" href="../../thickbox.css"/>

</head>

<body>
    <!-- principal -->
	<div id="principal">
    	<!-- topo -->
        <div id="topo2009">
        	<!-- Logo -->
        	<h1 id="logoNovo">
            	<a href="http://www.anitaonline.com.br/" title="Anita Online">Calçados femininos, calçados masculinos, tênis e esporte - Anita Online - A sua loja de calçados online
                </a>
            </h1>
            <!-- //Logo -->
            <!-- MENU AUXILIAR-->
            <div id="menuAuxiliar">
            	<ul>
                	<li id="menuAuxiliar5" class="sprite"><a href="contato.php" title="Contato">Contato</a></li>
                    <li id="menuAuxiliar4" class="sprite"><a href="institucional.php" title="Institucional">Institucional</a></li>
                    <li id="menuAuxiliar3" class="sprite"><a href="receba_novidades.php" title="Receba Novidades">Receba Novidades</a> </li>
                    <li id="menuAuxiliar2" class="sprite"><a href="atendimento" title="Dúvidas Frequentes">Dúvidas Frequentes</a></li>
                    <li id="menuAuxiliar6" style="height:15px;margin:3px 15px 0px 0px;" class="sprite"><a href="http://www.anitaonline.com.br/atendimento/?action=answer&amp;cat=201871&amp;id=3431881&amp;GroupIdentifier=19055187&amp;match_number=1&amp;question=Como+fa%E7o+uma+troca%3F" title="Troca fácil">Troca fácil</a></li><li id="menuAuxiliar1" class="sprite">Televendas</li>
                </ul>
            </div>
            <!-- //Menu Auxiliar -->
		</div>
        <!-- //Topo -->
        <div id="conteudoPrincipal">
 
            <div id="contEsquerda2009">
            
	            <!-- MENU-->   	
	                                                                                                                                                <div id="menuEsquerdo">	
		        <!-- MENU DEPARTAMENTOS -->

      	        <!-- FILTROS --> 
      	      		        <!-- MENU TAGS -->
                <ul class="nivel1">
                    <li>
                        <h2 class="titulos">Navegue por aqui</h2>
                        <ul class="nivel2">
                            <li><h3><a href="novidades" title="Novidades">Novidades</a></h3></li>
                            <li><h3><a href="promocoes" title="Promoções">Promoções</a></h3></li>
                        </ul>
                    </li>
                </ul>
    
    
            <!-- /MENU TAGS -->      	      		
                <ul class="nivel1">
                    <li>
                        <h2 class="titulos"><a href="calcados-femininos">Feminino</a></h2>
                        <ul class="nivel2">
                        <%
                            Dim v As Vitrine
                            v = ViewData.Model

                            For Each c As Vitrine.Categoria In v.Categorias
                        %>
                    	    <li><a href=<%= c.href %>><%= c.Title%></a></li> 
                        <%Next%>
                        </ul>
                    </li>
                </ul>
    
            <!-- /MENU MARCAS -->      	      	
      	
	        </div>

	            <!--// MENU-->


    
       
                <!-- Início do Botão do Atendimento ao Vivo! -->
                <div id="chatAoVivo"></div>
                <!-- Fim do Botão do Atendimento ao Vivo! -->

	            <!-- BANNERS -->
	            <div id="bannersEsquerda">
                </div>
            </div>
            <div id="contProdutoMeio">
                <div id="containerAll" style="clear:both;overflow:hidden;display:block">
                    <div style="float:left; display:block; overflow:hidden; width:410px;height:480px; ">
                        <div class="viewProdutoFoto2">
                            <div id="fotoMedia" style="height:410px;width:412px;text-align:center;">
                                <div id="loadingFoto" style="display: none;">
                                    <span style="color:#999999;">
                                        <img border="0" src="http://static.anitaonline.com.br/images/loadingFoto.gif">
                                        <br>
                                        Carregando
                                    </span>
                                </div>
                                <span class="tozoom">
                                    <img id="fotoMediaId" class="jqzoom" height="410px" onclick="javascript:displayBoxNovo('i1', true);return false;" style="display: inline;" alt="http://static.anitaonline.com.br/arquivos/site_produtos_1335259841.jpg" src="http://static.anitaonline.com.br/arquivos/site_produtos_1335259841_media.jpg">
                                </span>
                            </div>
                            <table>
                                <tbody>
                                <tr>
                                <td class="fotoMiniatura">
                                <a alt="http://static.anitaonline.com.br/arquivos/sandalia-feminina-luz-da-lua-ouro-site_produtos-1531597702_media.jpg">
                                    <img src="http://static.anitaonline.com.br/arquivos/sandalia-feminina-luz-da-lua-ouro-site_produtos-1531597702_pequena.jpg" height="50px;" width="50px;">
                                    </a>
                                </td>
                
                                            <td width="4px;"></td>
                                <td class="fotoMiniatura">
                                    <a alt="http://static.anitaonline.com.br/arquivos/sandalia-feminina-luz-da-lua-ouro-site_produtos-43661658_media.jpg">
                                        <img src="http://static.anitaonline.com.br/arquivos/sandalia-feminina-luz-da-lua-ouro-site_produtos-43661658_pequena.jpg" height="50px;" width="50px;">
                                    </a>
                                </td>
                                
                                                <td width="4px;"></td>
                                <td class="fotoMiniatura">
                                    <a alt="http://static.anitaonline.com.br/arquivos/sandalia-feminina-luz-da-lua-ouro-site_produtos-334778169_media.jpg">
                                    <img src="http://static.anitaonline.com.br/arquivos/sandalia-feminina-luz-da-lua-ouro-site_produtos-334778169_pequena.jpg" height="50px;" width="50px;">
                                    </a>
                                </td>
                    
                                                <td width="4px;"></td>
                                <td class="fotoMiniaturaSelect">
                                    <a alt="http://static.anitaonline.com.br/arquivos/sandalia-feminina-luz-da-lua-ouro-site_produtos-744000826_media.jpg">
                                        <img src="http://static.anitaonline.com.br/arquivos/sandalia-feminina-luz-da-lua-ouro-site_produtos-744000826_pequena.jpg" height="50px;" width="50px;">
                                    </a>
                                </td>
                              </tr>
                            </tbody>
                        </div>
                    </div>

                    <div style="float: right; display:block; overflow:hidden; height:100%; width:390px;">
                    </div>
                </div>
            </div>
        </div>
            <!--// BANNERS -->
    </div>
    <!-- // principal -->
</body>
</html>