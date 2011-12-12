<%@ Import Namespace="MvcApplication1" %>
<%@ Import Namespace="Vitrine" %>
<%@ Import Namespace="cmProdutoDetalhamento" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <title>
        Calçados femininos, calçados masculinos, tênis e acessórios - Anita Online - A sua loja de calçados 	online
    </title>

    <link rel="shortcut icon" href="/images/favicon.ico" type="image/x-icon"/>

    <link rel="stylesheet" type="text/css" href="/padrao_20110923a.css"/>
    <link rel="stylesheet" type="text/css" href="/padrao_20110802a.css"/>
    <link href="/departamentos_20110818.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="/theme.css"/>
    
    <script src="/js/jquery-1.6.js" type="text/javascript"></script>

    <script src="/js/funcoesMenu.js" type="text/javascript"></script>
</head>

<body>
    <!-- principal -->
	<div id="principal">
    	<!-- topo -->
        <div id="topo2009">
            <div id="topo2009">
        	    <!-- Logo -->
        	    <h1 id="logoNovo">
            	    <a href="/" title="Débora Leite">Calçados femininos e acessórios - Débora Leite - A moda online em calçados 
                    </a>
                </h1>
                <!-- //Logo -->
                <!-- MENU AUXILIAR-->
                <!-- TODO: Checar a montagem do menu -->
                <div id="menuAuxiliar">
            	    <ul>
                	    <li id="menuAuxiliar5" class="sprite"><a href="/" title="Contato">Contato</a></li>
                        <li id="menuAuxiliar4" class="sprite"><a href="/" title="Institucional">Institucional</a></li>
                        <li id="menuAuxiliar3" class="sprite"><a href="/" title="Receba Novidades">Receba Novidades</a> </li>
                        <li id="menuAuxiliar2" class="sprite"><a href="/" title="Dúvidas Frequentes">Dúvidas Frequentes</a></li>
                        <li id="menuAuxiliar6" style="height:15px;margin:3px 15px 0px 0px;" class="sprite"><a href="/" title="Troca fácil">Troca fácil</a></li><li id="menuAuxiliar1" class="sprite">Televendas</li>
                    </ul>
                </div>
                <!-- //Menu Auxiliar -->
                <div id="barraVermelha">
                    <div id="carrinho">
                        <a title="Ir para o carrinho" href="/"> Vazio</a>
                    </div>
                    <div id="busca">
                        <fieldset id="buscaFildset">
                            <form onsubmit="return enviaBusca(document.getElementById('texto').value)" method="GET">
                                <input id="texto" type="text" name="srch">
                                <div id="botaoBuscar" class="sprite" onclick="enviaBusca(document.getElementById('texto').value);">
                                    Buscar
                                </div>
                            </form>
                        </fieldset>
                    </div>
                </div>     
                <div style="float:right;overflow:hidden;width:790px;padding-top:3px;">
                    <div id="usuario">
                        Seja bem vindo! Clique 
                        <a title="Login" href="/">aqui</a>
                        para identificar-se.
                    </div>
                    <ul id="topoBotoes">
                        <li id="meusPedidos">
                            <a title="Meus Pedidos" href="/">Meus Pedidos</a>
                        </li>
                        <li id="minhaConta">
                            <a title="Minha Conta" href="/">Minha Conta</a>
                        </li>
                    </ul>
                    <div id="logoutAction"></div>
		        </div>
            </div>
        </div>
        <!-- //Topo -->
        <div id="conteudoPrincipal">
            <div id="superdestaque">
            </div>
    	    <div class="clear">
        	    <div id="contentRight">
                    <!-- TODO: Tratar filtros -->
            	    <!-- MEIO -->
                    <div id="contMeio">
                        <div id="migalhas" style="display:block">
                        <%
                            Dim v As cmVitrineCategoria
                            v = ViewData.Model
                            Response.Write(v.HTML_MigalhasDeManipulacaoDeFiltro())
                         %>
                        </div>

                	    <!-- Divisão de Categorias -->
                    <% 
                        Dim c As cmCategoria
                        c = v.Categoria
                        
                    %>
                        <div id="tituloCatalogo">
                        	<h1>
							    <a href="<%= v.PathTo_Categorias(c.href)%>" title="<%= c.Title%>"><%=c.Title%></a>
                            </h1>
                        </div>
                        <div class="linhaProdutos linhaProdutosSimples">
                            <ul>
                            <%
                                For Each p As cmProduto In c.Produtos%>
                        	    <li>
                        		    <h3 class="newlink sprite" style="background-image:url(<%= v.PathToFolder_Images(p.BackgroundImageUrl) %>);">
                        			    <a href="<%= cmProdutoDetalhamento.PathTo_Produto(p) %>" title="<%= p.Title %>"><%= p.Title%></a>
    							    </h3>
    							    <a href="<%= cmProdutoDetalhamento.PathTo_Produto(p) %>" title="<%= p.Title %>">
									    <div class="titulo"><%= p.Title %></div>
								    </a>
                                    <%If p.isEmPromocao() Then%>
								    <span class="de">De: R$ <del><%= FormatNumber(p.PrecoNormal, 2)%></del></span>
								    <span class="preco">Por: R$ <%= FormatNumber(p.PrecoPromocional, 2)%></span>
                                    <%Else%>
								    <span class="preco">R$ <%= FormatNumber(p.PrecoNormal, 2)%></span>
                                    <%End If%>
								    <span class="parcelamento">ou <%= p.ParcelasQtde%>X de <b>R$ <%= FormatNumber(p.ParcelaValor, 2)%></b></span>
								    <span class="semjuros"></span>
    <%--								<span class="vejamaistitle"></span>
								    <div class="vejamais">
									    + <a href="umbro" class="cinza_9" title="Mais produtos da marca Umbro">Umbro</a>
									    + <a href="futebol" class="cinza_9" title="Mais produtos da categoria Futebol">Futebol</a>
									    <br>
									    + <a href="futebol/54-0-14-0-0-0-0" class="cinza_9" title="Mais da marca Umbro na categoria Futebol">Futebol nesta marca</a>
								    </div>--%>
								    <!-- Botoes-->
								    <!-- dica -->
                                    <%If p.isEmPromocao() Then%>
								    <div class="iconPromocao">
           							    <a href="<%= cmProdutoDetalhamento.PathTo_Produto(p) %>" title="Item em Promoção">Promoção</a>
        						    </div>
                                    <%End If%>
                                    <%If p.isFreteGratis() Then%>
                                    <div class="iconFrete">
                                        <a title="Frete Grátis" href="<%= cmProdutoDetalhamento.PathTo_Produto(p) %>">Frete Grátis</a>
                                    </div>
                                    <% End If%>
                                </li>
                                <%
                                Next
                                %>

                            </ul>
                            <!--// PRODUTOS DA CATEGORIA -->
                        </div>



                    </div>
            

                    <div id="contDireita">

                    </div>

            	    <!-- // MEIO -->
                </div>
            
                <div id="contEsquerda2009">
                    <!-- MENU-->   		
                    <div id="menuEsquerdo">	
                      <!-- MENU DEPARTAMENTOS -->
                      <!-- FILTROS --> 
                          <!-- Categoria --->
                        <% c = v.Categoria%>
                        <ul class="nivel1">
       		                <li>
        		      	        <h2 class="titulos"> <a href="<%= v.PathTo_Categorias(c.href)%>" title="<%= c.Title%>"><%=c.Title%></a></h2>
                                <ul class="nivel2">
                                </ul>
						    </li>
	                    </ul>
	                    <ul class="nivel2">
		                    <li><a href="/">Voltar para Feminino</a></li>
	 			        </ul>
                        
                        <!-- TAMANHO -->
                        <ul class="nivel1">
                        </ul>
                        <ul class="nivel1">
                            <li>
                                <span class="titulos">Tamanho</span>
    
                                <ul class="menuTamanhos">
                                <%
                                    v = ViewData.Model
                                    Response.Write(v.HTML_TamanhosDisponiveis)
                                %>
                                </ul>
                            </li>
                        </ul>
    
    
                        <!-- MENU CORES -->
                        <ul class="nivel1">
                        <li>
                            <span class="titulos">Cores</span>
			                    <ul class="menuTamanhos">
                                <%
                                    
                                    v = ViewData.Model
                                    Response.Write(v.HTML_CoresDisponiveis)
                                %>
 		            		    </ul>
                        </li>
                        </ul>

                    </div> <!--// MENU-->

                    <!-- Início do Botão do Atendimento ao Vivo! -->
                      <div id="chatAoVivo"></div>
                    <!-- Fim do Botão do Atendimento ao Vivo! -->
                </div>

	            <!-- BANNERS -->
	            <div id="bannersEsquerda">
                </div>
                <!--// BANNERS -->
            </div>
        </div>
        <!-- MENU PRINCIPAL-->         
        <div id="menuPrincipal" >
			<ul id="navMenu">				
				<li class="navSpace"></li>
				<li>
					<div id="navItemFeminino"><span onclick="abrePaginaMenu('')" title="Calçados Femininos">Calçados Femininos</span></div>

					<ul id="navHidden">
						<li>
							<div class="navContainerMaster">
								<div id="navItemFemininoOver"><span onclick="abrePaginaMenu('')" title="Departamento Feminino"></span></div>
								<div class="navContainer" style="width:720px;height:295px;">
									<div class="navBorder">
										
                                         <ul class="navListagem" style="left:0px; position:relative;float:left; padding-top:10px; "> 
                                     <%For Each categoriaMenu As cmCategoria In v.GetCategorias()%>                                            
                                                <li class="navListagemNormal"><span onclick="abrePaginaMenu('/Vitrine/<%=categoriaMenu.href%>')" title="<%=categoriaMenu.Title %>"><%=categoriaMenu.Title %></span></li>
                                     <%Next%>
                                        </ul> 
                                    </div>
                                </div>  
								<div class="navShadow" style="width:720px;height:295px;"></div>
							</div>
						</li>
					</ul>
				</li>
				
				<li class="navSpace"></li>
				
				<li>
					<div id="navItemNovidades"><span onclick="abrePaginaMenu('/')" title="Novidades">Lançamentos de Calçados</span></div>
				</li>
				
				<li class="navSpace"></li>
				
				<li>
					<div id="navItemPromocoes"><span onclick="abrePaginaMenu('/')" title="Promoção de Calçados">Calçados em Promoção</span></div>

				</li>
				
			</ul>
        </div>
	    <!--// MENU PRINCIPAL -->

    </div>
    <!-- // principal -->

    <div id="rodape2009" style="background:url(/images/2011/bg-rodape-prov-2.png) repeat-x">
        <div id="containerRodapeNovo">
            <!--Busca Rodape-->
            <div id="buscaNovo" style="margin-top:25px;">
                <form method="GET" onsubmit="return enviaBusca(document.getElementById('buscaRodape').value)">
                    <input id="buscaRodape" class="buscaInputNovo" style="border:none;float:left" type="text">
                    <input src="/images/btn-buscar-novo.png" style="float:right;margin-top:3px;margin-right:5px;" type="image">
                </form>
            </div>
            <!--   <ul id="maisBuscadosNovo"><li><span>+Buscados:</span></li><li><a href="#">Sandálias,</a></li><li><a href="#">Nike Shox,</a></li><li><a href="#">Nike Shox,</a></li><li><a href="#">Nike Shox,</a></li></ul>--><!--Busca Rodape-->
            <div id="blocoBaixoRodapeNovo">
                <!--Container Esquerda-->
                <div id="containerEsquerdaRodape">
                    <div id="rodapeNovoAtencdimento">
                        <span>Central de Atendimento e Televendas:</span>
                        <strong>(XX) XXXX-XXXX</strong><br>
                        <strong>(XX) XXXX-XXXX</strong><br>
                        <strong>(XX) XXXX-XXXX</strong>
                        <p>Horário de atendimento:<br>Segunda à Sexta, das 09:00 às 18:00 e aos Sábados das 09:00 às 13:00 (horário de Brasília).</p>
                    </div>
                    <div id="rodapeNovoOutrosAtt">
                        <h3>Mais opções de Atendimento:</h3>
                        <ul>
                            <li><a href="/">Central de Atendimento</a></li>
                            <li><a onclick=" window.open('/','Atendimento','toolbar=no,location=no,status=no,menubar=no,scrollbars=no,resizable=no,width=600,height=450');" href="javascript:void(false);">Chat ao Vivo</a></li>
                            <li><a href="/" title="Dúvidas Frequentes">Dúvidas Frequentes</a></li>
                        </ul>
                    </div>
                </div>
                <!--Container Esquerda-->
                <!--Container Meio-->
                <div id="containerMeioRodape">
                    <div id="rodapeNovoInstitucional">
                        <h3>Institucional:</h3>
                        <ul style="border-right:1px solid #DDD;">
                            <li><a href="/" title="Empresa">Empresa</a></li>
                            <li><a href="/" title="Lojas">Lojas</a></li>
                            <li><a href="/" title="Trabalhe Conosco">Trabalhe Conosco</a></li>
                        </ul>
                        <ul style="width:178px;margin-left:20px;">
                            <li><a href="/" title="Política de Uso">Política de Uso</a></li>
                            <li><a href="/" title="Política de troca e devolução">Política de troca e devolução</a></li><li><a href="/" title="Segurança e Privacidade">Segurança e Privacidade</a></li>
                        </ul>
                    </div>
                    <div id="rodapeNovoNewsletter">
                        <h3>Receba ofertas exclusivas:</h3>
                        <form action="/" method="POST">
                            <input name="act" value="registering" type="Hidden">
                            <input name="nome" id="nome" value="Nome" class="formRodapeNovo" onfocus="focar('Nome',this);" onblur="desfocar('Nome',this);" style="margin-top:5px;" type="text">
                            <div> 
                                <input name="email" id="email" value="Email" class="formRodapeNovo" onfocus="focar('Email',this);" onblur="desfocar('Email',this);" style="display:block;margin-top:5px;float:left" type="text"> 
                                <input src="/images/BTN-OK.png" style="margin-top:5px;float:left;margin-left:10px" type="image">
                            </div>
                            <div class="clear">
                            </div>
                        </form>
                    </div>
                </div>
                <!--Container Meio-->
                <!--Container Direta -->
<%--                <div id="containerDireitaRodape">
                    <div style="float:left;display:block;overflow:hidden">
                        <div style="float:left;display:block;overflow:hidden;margin-bottom:5px;width:105px">
                            <a href="http://twitter.com/share" data-text="www.anitaonline.com.br - A sua loja de calçados" class="twitter-share-button" data-count="horizontal" data-url="www.anitaonline.com.br" data-via="siteAnitaOnline">Tweet</a>
                            <script type="text/javascript" src="http://platform.twitter.com/widgets.js"></script>
                        </div>
                            
                        <div style="float:left;width:72px">
                            <!-- Inclua esta tag onde desejar que o botão +1 seja exibido -->
                            <div style="height: 20px; width: 90px; display: inline-block; text-indent: 0pt; margin: 0pt; padding: 0pt; background: none repeat scroll 0% 0% transparent; border-style: none; float: none; line-height: normal; font-size: 1px; vertical-align: baseline;" id="___plusone_0">
                                <iframe allowtransparency="true" hspace="0" id="I1_1317149787712" marginheight="0" marginwidth="0" name="I1_1317149787712" src="https://plusone.google.com/u/0/_/+1/fastbutton?url=http%3A%2F%2Fwww.anitaonline.com.br%2F&amp;size=medium&amp;count=true&amp;annotation=&amp;hl=pt-BR&amp;jsh=r%3Bgc%2F23980661-3686120e#id=I1_1317149787712&amp;parent=http%3A%2F%2Fwww.anitaonline.com.br&amp;rpctoken=287962935&amp;_methods=onPlusOne%2C_ready%2C_close%2C_open%2C_resizeMe" style="position: static; left: 0pt; top: 0pt; width: 90px; margin: 0px; border-style: none; height: 20px; visibility: visible;" tabindex="-1" vspace="0" title="+1" frameborder="0" scrolling="no" width="100%">
                                </iframe>
                            </div>
                        </div>
                        <iframe src="http://www.facebook.com/plugins/like.php?app_id=129020930522995&amp;href=www.anitaonline.com.br&amp;send=false&amp;layout=button_count&amp;width=57&amp;show_faces=true&amp;action=like&amp;colorscheme=light&amp;font=arial&amp;height=21" style="border:none; overflow:hidden; width:57px; height:21px;float:left" allowtransparency="true" frameborder="0" scrolling="no">
                        </iframe>
                    </div>
                    <div style="clear:both;">
                        <iframe src="http://www.facebook.com/plugins/likebox.php?href=http%3A%2F%2Fwww.facebook.com%2FAnitaOnlineOficial&amp;width=237&amp;colorscheme=light&amp;show_faces=true&amp;stream=false&amp;header=false&amp;height=210" style="border:none; overflow:hidden; width:237px; height:210px;clear:both" allowtransparency="true" frameborder="0" scrolling="no"></iframe>
                    </div>
                </div>--%>
                <!--Container Direta -->
            </div>
            <div id="blocoBaixoRodapeNovo2" style="border-bottom:1px solid #F3F3F3;">
                <div id="rodapeRedeSocialNovo">
                    <h3>Redes Sociais</h3>
                    <p>Acompanhe Débora Leite Calçados nas Redes Sociais</p>
                    <ul class="linksSocial">
                        <li class="sprite" id="twitterNovo"><a href="http://twitter.com/DeboraLeiteCalcados" title="Twitter" target="_blank">Twitter</a></li><li class="sprite" id="facebookNovo"><a href="http://www.facebook.com/DeboraLeite" title="Facebook" target="_blank">Facebook</a></li><li class="sprite" id="youtubeNovo"><a href="http://www.youtube.com/user/DeboraLeite" title="Youtube" target="_blank">Youtube</a></li>
                        <li class="sprite" id="orkutNovo"><a href="http://www.orkut.com.br/Main#Community.aspx?cmm=0" title="Orkut" target="_blank">Orkut</a></li><li class="sprite" id="blogNovo"><a href="/" title="Débora Leite Calçados - Blog" target="_blank">Débora Leite Calçados - Blog</a></li>
                    </ul>
                </div>
                <div id="rodapeFormasNovo">
                    <h3>Meios de Pagamento</h3>
                </div>
                <div id="rodapeSegurancaNovo">
                    <h3>Compre com segurança</h3>
                </div>
<%--                <div id="rodapeEmpresaAmigoNovo" class="sprite">
                    <a href="http://www.aacc-ms.org.br/view/home/" target="_blank">Empresa Amiga</a>
                </div>--%>
            </div>
            <%--<div id="creditos"><a href="http://www.maisempresas.com/" title="Desenvolvimento de Sites">Tecnologia: Mais Empresas</a>--%>
            </div>
        </div>
</body>
</html>