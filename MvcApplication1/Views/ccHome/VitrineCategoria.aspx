<%@ Import Namespace="MvcApplication1" %>
<%@ Import Namespace="Vitrine" %>

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
                <div id="barraVermelha">
                    <div id="carrinho">
                        <a title="Ir para o carrinho" href="carrinho.php"> Vazio</a>
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
                        <a title="Login" href="https://www.anitaonline.com.br/login.php?goto=">aqui</a>
                        para identificar-se.
                    </div>
                    <ul id="topoBotoes">
                        <li id="meusPedidos">
                            <a title="Meus Pedidos" href="http://www.anitaonline.com.br/requests.php">Meus Pedidos</a>
                        </li>
                        <li id="minhaConta">
                            <a title="Minha Conta" href="http://www.anitaonline.com.br/account.php">Minha Conta</a>
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
                            <span class="cada-filtro">
                                <span class="cada-filtro-fechar sprite">
                                    <a title="Retirar este filtro" href="">x</a>
                                </span>
                                <span class="cada-filtro-nome">
                                    <a title="Filtrar apenas por este" href="calcados-femininos">Feminino</a>
                                </span>
                            </span>
                            <span class="cada-filtro">
    	               	        <span class="cada-filtro-fechar sprite">
                                    <a title="Retirar este filtro" href="calcados-femininos">x</a>
                                </span>
	                            <span class="cada-filtro-nome">
                                    <a title="Filtrar apenas por este" href="peep-toe">Peep Toe</a>
                                </span>
        	                </span>
                        </div>

                        <div id="tituloCatalogo">
        					<h1>Peep Toe</h1>

            	    		<!-- ORDENAÇÂO-->
	                        <div id="ordenacao">
	                            <select style="width:100px" class="formpadrao" name="ordenar" onchange="document.location.href = 'http://www.anitaonline.com.br/'+this.value">
	                                <option selected="" value="peep-toe/49-0-0-0-0-0-0-0+40+data">Mais novos</option>
	                                <option value="peep-toe/49-0-0-0-0-0-0-0+40+valor">Menor preço</option>
	                                <option value="peep-toe/49-0-0-0-0-0-0-0+40+vendas">Mais vendidos</option>
	                                <option value="peep-toe/49-0-0-0-0-0-0-0+40+vistos">Mais vistos</option>
	                             </select>
		                    </div>
		                    <!-- //ORDENAÇÂO-->
	    	
	                    </div>

                        <div id="mensagem" style="display: none;">
					        <strong>Tudo isso!</strong> Utilizando alguns filtros ficará mais fácil de encontrar o que procura.<br>Que tal filtrar pelo seu <b>número</b>?
			            </div>

                        <!-- Faz slide down da mensagem -->
<%--                        <script type="text/javascript">
                            $(document).ready(function () {
                                $("#mensagem").slideDown();
                            });
                        </script>--%>

                        <!---------------------------- -->
                        <div class="linhaProdutos linhaProdutosSimples">
                            <ul>
                                <li>
                                    <h3 class="newlink sprite" style="background-image:url(http://static.anitaonline.com.br/arquivos/peep-toe-carmim-vermelho-site_produtos-619844015_pequena.jpg);">
    	                                <a href="peep-toe-carmim-vermelho-coral-120052" title="Peep Toe Carmim Vermelho">Peep Toe Carmim Vermelho</a>
                                    </h3>
    
	                                <a href="peep-toe-carmim-vermelho-coral-120052" title="Peep Toe Carmim Vermelho">
		                                <div class="titulo">Peep Toe Carmim Vermelho</div>
	                                </a>
				                    <span class="preco">R$ 379,99</span>
            		    		        <span class="parcelamento">ou 10X de <b>R$ 37,99</b></span>
    		                        <span class="semjuros"></span>
                        
        
		                            <span class="vejamaistitle"></span>
        		                    <div class="vejamais">
							            + <a href="carmim" class="cinza_9" title="Mais produtos da marca Carmim">Carmim</a>
                                        <br>+ <a href="peep-toe/49-0-100-0-0-0-0" class="cinza_9" title="Mais da marca Carmim na categoria Peep Toe">Peep Toe nesta marca</a>
					                </div>
		                            <!-- Botoes--> 
                                    <!-- dica -->
        		                    <!-- Frete Gratis -->
                                    <div class="iconFrete">
                                        <a href="peep-toe-carmim-vermelho-coral-120052" title="Frete Grátis">Frete Grátis</a>
                                    </div>
                                </li>

                                <li>
                                    <h3 class="newlink sprite" style="background-image:url(http://static.anitaonline.com.br/arquivos/peep-toe-carmim-vermelho-site_produtos-619844015_pequena.jpg);">
    	                                <a href="peep-toe-carmim-vermelho-coral-120052" title="Peep Toe Carmim Vermelho">Peep Toe Carmim Vermelho</a>
                                    </h3>
    
	                                <a href="peep-toe-carmim-vermelho-coral-120052" title="Peep Toe Carmim Vermelho">
		                                <div class="titulo">Peep Toe Carmim Vermelho</div>
	                                </a>
				                    <span class="preco">R$ 379,99</span>
            		    		        <span class="parcelamento">ou 10X de <b>R$ 37,99</b></span>
    		                        <span class="semjuros"></span>
                        
        
		                            <span class="vejamaistitle"></span>
        		                    <div class="vejamais">
							            + <a href="carmim" class="cinza_9" title="Mais produtos da marca Carmim">Carmim</a>
                                        <br>+ <a href="peep-toe/49-0-100-0-0-0-0" class="cinza_9" title="Mais da marca Carmim na categoria Peep Toe">Peep Toe nesta marca</a>
					                </div>
		                            <!-- Botoes--> 
                                    <!-- dica -->
        		                    <!-- Frete Gratis -->
                                    <div class="iconFrete">
                                        <a href="peep-toe-carmim-vermelho-coral-120052" title="Frete Grátis">Frete Grátis</a>
                                    </div>
                                </li>

                                <li>
                                    <h3 class="newlink sprite" style="background-image:url(http://static.anitaonline.com.br/arquivos/peep-toe-carmim-vermelho-site_produtos-619844015_pequena.jpg);">
    	                                <a href="peep-toe-carmim-vermelho-coral-120052" title="Peep Toe Carmim Vermelho">Peep Toe Carmim Vermelho</a>
                                    </h3>
    
	                                <a href="peep-toe-carmim-vermelho-coral-120052" title="Peep Toe Carmim Vermelho">
		                                <div class="titulo">Peep Toe Carmim Vermelho</div>
	                                </a>
				                    <span class="preco">R$ 379,99</span>
            		    		        <span class="parcelamento">ou 10X de <b>R$ 37,99</b></span>
    		                        <span class="semjuros"></span>
                        
        
		                            <span class="vejamaistitle"></span>
        		                    <div class="vejamais">
							            + <a href="carmim" class="cinza_9" title="Mais produtos da marca Carmim">Carmim</a>
                                        <br>+ <a href="peep-toe/49-0-100-0-0-0-0" class="cinza_9" title="Mais da marca Carmim na categoria Peep Toe">Peep Toe nesta marca</a>
					                </div>
		                            <!-- Botoes--> 
                                    <!-- dica -->
        		                    <!-- Frete Gratis -->
                                    <div class="iconFrete">
                                        <a href="peep-toe-carmim-vermelho-coral-120052" title="Frete Grátis">Frete Grátis</a>
                                    </div>
                                </li>

                                <li>
                                    <h3 class="newlink sprite" style="background-image:url(http://static.anitaonline.com.br/arquivos/peep-toe-carmim-vermelho-site_produtos-619844015_pequena.jpg);">
    	                                <a href="peep-toe-carmim-vermelho-coral-120052" title="Peep Toe Carmim Vermelho">Peep Toe Carmim Vermelho</a>
                                    </h3>
    
	                                <a href="peep-toe-carmim-vermelho-coral-120052" title="Peep Toe Carmim Vermelho">
		                                <div class="titulo">Peep Toe Carmim Vermelho</div>
	                                </a>
				                    <span class="preco">R$ 379,99</span>
            		    		        <span class="parcelamento">ou 10X de <b>R$ 37,99</b></span>
    		                        <span class="semjuros"></span>
                        
        
		                            <span class="vejamaistitle"></span>
        		                    <div class="vejamais">
							            + <a href="carmim" class="cinza_9" title="Mais produtos da marca Carmim">Carmim</a>
                                        <br>+ <a href="peep-toe/49-0-100-0-0-0-0" class="cinza_9" title="Mais da marca Carmim na categoria Peep Toe">Peep Toe nesta marca</a>
					                </div>
		                            <!-- Botoes--> 
                                    <!-- dica -->
        		                    <!-- Frete Gratis -->
                                    <div class="iconFrete">
                                        <a href="peep-toe-carmim-vermelho-coral-120052" title="Frete Grátis">Frete Grátis</a>
                                    </div>
                                </li>

                            </ul>
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
                          <ul class="nivel1">
        		                    <li>
    	    		        		                     <h2 class="titulos"><a href="peep-toe">Peep Toe</a></h2>

                                        <ul class="nivel2">
                           						                    
                    						                    </ul>
								                    </li>
			 				 			                    </ul>
	 			                    <ul class="nivel2">
	 			                    <li><a href="calcados-femininos">Voltar para Feminino</a></li>
	 			                    </ul>

	 			                    <ul class="nivel1">
 			                     </ul>          <ul class="nivel1">
                            <li>
                                <span class="titulos">Tamanho</span>
    
                                <ul class="menuTamanhos">
                                <%
                                    
                                    Dim v As cmVitrineCategoria
                                    v = ViewData.Model
                                    Response.Write(v.HTML_TamanhosDisponiveis)
                                %>
<%--                                    <li><a href="peep-toe/49-0-0-33-0-0-0">33</a></li>
                                    <li><a href="peep-toe/49-0-0-34-0-0-0">34</a></li>
                                    <li><a href="peep-toe/49-0-0-35-0-0-0">35</a></li>
                                    <li><a href="peep-toe/49-0-0-36-0-0-0">36</a></li>
                                    <li><a href="peep-toe/49-0-0-37-0-0-0">37</a></li>
                                    <li><a href="peep-toe/49-0-0-38-0-0-0">38</a></li>
                                    <li><a href="peep-toe/49-0-0-39-0-0-0">39</a></li>
                                    <li><a href="peep-toe/49-0-0-40-0-0-0">40</a></li>
                                    <li><a href="peep-toe/49-0-0-41-0-0-0">41</a></li>
                                    <li><a href="peep-toe/49-0-0-42-0-0-0">42</a></li>
                                    <li><a href="peep-toe/49-0-0-43-0-0-0">43</a></li>--%>
                                </ul>
                            </li>
                        </ul>
    
    
                          <!-- MENU CORES -->
                        <ul class="nivel1">
                        <li>
                            <span class="titulos">Cores</span>
			                    <ul class="menuTamanhos">
		        		            		                                    <li><a href="peep-toe/49-16-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_vermelhos.gif" alt="Vermelhos" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-13-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_pretos.gif" alt="Pretos" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-7-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_coloridos.gif" alt="Coloridos" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-2-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_azuis.gif" alt="Azuis" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-6-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_cinzas.gif" alt="Cinzas" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-9-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_laranjas.gif" alt="Laranjas" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-11-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_marrons.gif" alt="Marrons" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-12-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_pratas.gif" alt="Pratas" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-4-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_brancos.gif" alt="Brancos" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-3-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_beges.gif" alt="Beges" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-10-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_lilases.gif" alt="Lilases" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-8-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_dourados.gif" alt="Dourados" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-15-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_verdes.gif" alt="Verdes" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-14-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_rosas.gif" alt="Rosas" border="0"></a></li>
		            		        		            		                                    <li><a href="peep-toe/49-1-0-0-0-0-0"><img src="http://static.anitaonline.com.br/images/cores/cores_amarelos.gif" alt="Amarelos" border="0"></a></li>
		            		        	                            </ul>
                        </li>
                        </ul>
    
                        <!-- /MENU CORES -->          <ul class="nivel1">
                            <li>
                                <span class="titulos">Faixa de preço</span>
                                 <ul class="menuPrecos">
                                                                     <li><a href="peep-toe/49-0-0-0-0-1-0"> até R$ 99,90</a></li>
                                                                                     <li><a href="peep-toe/49-0-0-0-0-100-0">de R$ 100 até R$ 199,90</a></li>
                                                                                     <li><a href="peep-toe/49-0-0-0-0-200-0">de R$ 200 até R$ 299,90</a></li>
                                                                                     <li><a href="peep-toe/49-0-0-0-0-300-0">de R$ 300 até R$ 399,90</a></li>
                                                                                     <li><a href="peep-toe/49-0-0-0-0-400-0">de R$ 400 até R$ 499,90</a></li>
                                                             </ul>
                            </li>
                        </ul>
    
    
                          <!-- MENU TAGS -->
                    <!-- /MENU TAGS -->      <!-- MENU MARCAS -->
	                    <ul class="nivel1">
                            <li>
                                <span class="titulos">Marcas</span>
                                <ul class="nivel2">
                                                            <li><a href="peep-toe/49-0-441-0-0-0-0" title="Amuleto">Amuleto</a></li>
                                                                        <li><a href="peep-toe/49-0-106-0-0-0-0" title="Anzetutto">Anzetutto</a></li>
                                                                        <li><a href="peep-toe/49-0-416-0-0-0-0" title="Azaleia">Azaleia</a></li>
                                                                        <li><a href="peep-toe/49-0-244-0-0-0-0" title="Beira Rio">Beira Rio</a></li>
                                                                        <li><a href="peep-toe/49-0-456-0-0-0-0" title="Belmira Mattos">Belmira Mattos</a></li>
                                                                        <li><a href="peep-toe/49-0-158-0-0-0-0" title="Bottero">Bottero</a></li>
                                                                        <li><a href="peep-toe/49-0-99-0-0-0-0" title="Capodarte">Capodarte</a></li>
                                                                        <li><a href="peep-toe/49-0-100-0-0-0-0" title="Carmim">Carmim</a></li>
                                                                        <li><a href="peep-toe/49-0-248-0-0-0-0" title="Cecconello">Cecconello</a></li>
                                                                        <li><a href="peep-toe/49-0-139-0-0-0-0" title="Charmant">Charmant</a></li>
                                                                        <li><a href="peep-toe/49-0-16-0-0-0-0" title="Claudina">Claudina</a></li>
                                                                        <li><a href="peep-toe/49-0-89-0-0-0-0" title="Dakota">Dakota</a></li>
                                                                        <li><a href="peep-toe/49-0-327-0-0-0-0" title="De Fiore">De Fiore</a></li>
                                                                        <li><a href="peep-toe/49-0-366-0-0-0-0" title="Di Mariotti">Di Mariotti</a></li>
                                                                        <li><a href="peep-toe/49-0-113-0-0-0-0" title="Ferrette">Ferrette</a></li>
                                                                        <li><a href="peep-toe/49-0-427-0-0-0-0" title="Firezzi">Firezzi</a></li>
                                                                        <li><a href="peep-toe/49-0-74-0-0-0-0" title="Jorge Bischoff">Jorge Bischoff</a></li>
                                                                        <li><a href="peep-toe/49-0-208-0-0-0-0" title="Julia Mezzetti">Julia Mezzetti</a></li>
                                                                        <li><a href="peep-toe/49-0-22-0-0-0-0" title="Laura Porto">Laura Porto</a></li>
                                                                        <li><a href="peep-toe/49-0-108-0-0-0-0" title="Lorraci">Lorraci</a></li>
                                                                        <li><a href="peep-toe/49-0-30-0-0-0-0" title="Luz da Lua">Luz da Lua</a></li>
                                                                        <li><a href="peep-toe/49-0-365-0-0-0-0" title="Mariotti">Mariotti</a></li>
                                                                        <li><a href="peep-toe/49-0-59-0-0-0-0" title="Marlinês">Marlinês</a></li>
                                                                        <li><a href="peep-toe/49-0-43-0-0-0-0" title="Masiero">Masiero</a></li>
                                                                        <li><a href="peep-toe/49-0-69-0-0-0-0" title="Mezzo Punto">Mezzo Punto</a></li>
                                                                        <li><a href="peep-toe/49-0-234-0-0-0-0" title="Moleca">Moleca</a></li>
                                                                        <li><a href="peep-toe/49-0-145-0-0-0-0" title="Naturezza">Naturezza</a></li>
                                                                        <li><a href="peep-toe/49-0-37-0-0-0-0" title="Piccadilly">Piccadilly</a></li>
                                                                        <li><a href="peep-toe/49-0-28-0-0-0-0" title="Ramarim">Ramarim</a></li>
                                                                        <li><a href="peep-toe/49-0-131-0-0-0-0" title="Renata Moraes">Renata Moraes</a></li>
                                                                        <li><a href="peep-toe/49-0-125-0-0-0-0" title="Rendeira">Rendeira</a></li>
                                                                        <li><a href="peep-toe/49-0-319-0-0-0-0" title="Rima">Rima</a></li>
                                                                        <li><a href="peep-toe/49-0-320-0-0-0-0" title="Suzy">Suzy</a></li>
                                                                        <li><a href="peep-toe/49-0-19-0-0-0-0" title="Tabita">Tabita</a></li>
                                                                        <li><a href="peep-toe/49-0-169-0-0-0-0" title="Tanara">Tanara</a></li>
                                                                        <li><a href="peep-toe/49-0-24-0-0-0-0" title="Usaflex">Usaflex</a></li>
                                                                        <li><a href="peep-toe/49-0-227-0-0-0-0" title="Via Marte">Via Marte</a></li>
                                                                        <li><a href="peep-toe/49-0-18-0-0-0-0" title="Via Uno">Via Uno</a></li>
                                                                        <li><a href="peep-toe/49-0-70-0-0-0-0" title="Vizzano">Vizzano</a></li>
                                                                        <li><a href="peep-toe/49-0-68-0-0-0-0" title="Werner">Werner</a></li>
                                                                        <li><a href="peep-toe/49-0-225-0-0-0-0" title="Why Wait">Why Wait</a></li>
                                                        </ul>
                            </li>
                        </ul>
    
                        <!-- /MENU MARCAS -->    </div>
                    <!--// MENU-->

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
					<div id="navItemEsporte"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-e-esporte')" title="Tênis e Esporte">Tênis e Esporte</span></div>
					<ul>
						<li>
							<div class="navContainerMaster">
								<div id="navItemEsporteOver"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-e-esporte')" title="Tênis e Esporte"></span></div>
								<div class="navContainer" style="width:700px; height:300px;">

									<div class="navBorder">
										
										
                                        <ul class="navListagem" style="left:0px; position:relative;float:left; padding-top:10px;">
                                            <li class="navListagemDestaque"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis+e+esporte/4-0-0-0-4-0')" title="Lançamentos">Lançamentos</span></li>
                                            <li class="navListagemDestaque"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/acessorios-esportivos')" title="Acessórios">Acessórios</span></li> 
                                                     
                                                  
                                        	<li class="navListagemTitulo">Tênis e Esporte</li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-academia')" title="Academia">Academia</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/asics')" title="Asics">Asics</span></li>

                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-de-aventura')" title="Aventura">Aventura</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-casual')" title="Casual">Casual</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-de-corrida')" title="Corrida">Corrida</span></li>                                            
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/especial-tenis')" title="Especial Tênis">Especial Tênis</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/futebol')" title="Futebol">Futebol</span></li>                                 
                                    	  	<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-de-quadra')" title="Quadra">Quadra</span></li>
                                        </ul>

                                        
                                        <ul class="navListagem" style="left:0px; position:relative;float:left; "> 
                                        	<li class="navListagemTitulo">Marcas</li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/adidas')" title="Adidas">Adidas</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/asics')" title="Asics">Asics</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/braddock')" title="Braddock">Braddock</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/boots-company')" title="Boots Company">Boots Company</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/bull-terrier')" title="Bull Terrier">Bull Terrier</span></li>

                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/caterpillar')" title="Caterpillar">Caterpillar</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/cavalera')" title="Cavalera">Cavalera</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/coca-cola')" title="Coca Cola">Coca Cola</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/converse-all-star')" title="Converse All Star">Converse All Star</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/dal-ponte')" title="Dal Ponte">Dal Ponte</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/diadora')" title="Diadora">Diadora</span></li>

                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/ecko')" title="Ecko">Ecko</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/kolosh')" title="Kolosh">Kolosh</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/lacoste')" title="Lacoste">Lacoste</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/lotto')" title="Lotto">Lotto</span></li>
                                            
                                            
                                            
                                        </ul>
                                       
                                         <ul class="navListagem last" style="left:0px; position:relative;float:left; padding-top:15px;  ">
                                         	<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/mac-boot')" title="Mac Boot">Mac Boot</span></li>

                                        	<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/mary-jane')" title="Mary Jane">Mary Jane</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/mizuno')" title="Mizuno">Mizuno</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/new-balance')" title="New Balance">New Balance</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/nike')" title="Nike">Nike</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/olympikus')" title="Olympikus">Olympikus</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/penalty')" title="Penalty">Penalty</span></li>

                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/puma')" title="Puma">Puma</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/qix')" title="Qix">Qix</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/rainha')" title="Rainha">Rainha</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/reebok')" title="Reebok">Reebok</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/stadium')" title="Stadium">Stadium</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/schio')" title="Schio">Schio</span></li>

                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/skechers')" title="Skechers">Skechers</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/sneakers')" title="Sneakers">Sneakers</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/timberland')" title="Timberland">Timberland</span></li>
                                         </ul>
                                         
                                         <ul class="navListagem last" style="left:0px; position:relative;float:left;">
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/topper')" title="Topper">Topper</span></li>
                                          	<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/umbro')" title="Umbro">Umbro</span></li>

                                         	<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/wilson')" title="Wilson">Wilson</span></li>
                                        	 <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/yonex')" title="Yonex">Yonex</span></li>
                                            <li class="navListagemTitulo">Faixa de pre&ccedil;o</li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-e-esporte/4-0-0-0-0-1-0')" title="Calçados esportivos até R$99,99"> at&eacute; R$ 99,90</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-e-esporte/4-0-0-0-0-100-0')" title="Calçados esportivos de R$ 100 a R$ 199,90">R$ 100 a R$ 199,90</span></li>

                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-e-esporte/4-0-0-0-0-200-0')" title="Calçados esportivos de R$ 200 a R$ 299,90">R$ 200 a R$ 299,90</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-e-esporte/4-0-0-0-0-300-0')" title="Calçados esportivos de R$ 300 a R$ 399,90">R$ 300 a R$ 399,90</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-e-esporte/4-0-0-0-0-400-0')" title="Calçados esportivos de R$ 400 a R$ 499,90">R$ 400 a R$ 499,90</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tenis-e-esporte/4-0-0-0-0-500-0')" title="Calçados esportivos de R$ 500 aR$ 599,90">R$ 500 aR$ 599,90</span></li>
                                   		 </ul>               
                                       
                                          
									
										
									</div>
								</div>

								<div class="navShadow" style="width:700px;height:300px;"></div>
							</div>
						</li>
					</ul>
				</li>
				
				<li class="navSpace"></li>
				<li>
					<div id="navItemFeminino"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-femininos')" title="Calçados Femininos">Calçados Femininos</span></div>

					<ul id="navHidden">
						<li>
							<div class="navContainerMaster">
								<div id="navItemFemininoOver"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-femininos')" title="Departamento Feminino"></span></div>
								<div class="navContainer" style="width:720px;height:295px;">
									<div class="navBorder">
										
                                     <ul class="navListagem" style="left:0px; position:relative;float:left; padding-top:10px; ">                                             
                                        <li class="navListagemDestaque"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/novidades-feminino')" title="Novidades Feminino">Novidades Feminino</span></li>
                                        <li class="navListagemDestaque"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-femininos/6-0-0-0-8')" title="Promo&ccedil;&otilde;es Feminino">Promo&ccedil;&otilde;es Feminino</span></li>                                       
                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/anabelas')" title="Anabela">Anabela</span></li>

                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/bolsas-e-acessorios')" title="Bolsas">Bolsas</span></li>
                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/botas')" title="Botas">Botas</span></li>  
                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/carteira-')" title="Carteiras">Carteiras</span></li>
                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/cinto-feminino')" title="Cintos">Cintos</span></li>                  
                                        <!--<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-de-festa')" title="Festa">Festa</span></li>-->
                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/noiva')" title="Noiva">Noiva</span></li>
                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/peep-toe')" title="Peep Toe">Peep Toe</span></li>

                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/rasteiras')" title="Rasteiras">Rasteiras</span></li>
                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/sandalias-femininas')" title="Sand&aacute;lias">Sand&aacute;lias</span></li>
                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/sapatilhas')" title="Sapatilhas">Sapatilhas</span></li>
                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/sapatos-femininos')" title="Sapatos">Sapatos</span></li>
                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/sapato-oxford')" title="Sapato Oxford">Oxford</span></li>
                                        <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/scarpins')" title="Scarpins">Scarpins</span></li>

                                    </ul> 
                                    
                                    <ul class="navListagem" style="left:0px; position:relative;float:left; ">  
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/open-boot')" title="Open Boot">Open Boot</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tamancos')" title="Tamancos">Tamancos</span></li>                                           
                                      <li class="navListagemTitulo">Marcas</li>   
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/beira-rio')" title="Beira Rio">Beira Rio</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/bottero')" title="Bottero">Bottero</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/carmim')" title="Carmim">Carmim</span></li>

                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/capodarte')" title="Capodarte">Capodarte</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/charmant')" title="Charmant">Charmant</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/claudina')" title="Claudina">Claudina</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/dakota')" title="Dakota">Dakota</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/ferrette')" title="Ferrette">Ferrette</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/jorge-bischoff')" title="Jorge Bischoff">Jorge Bischoff</span></li>

                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/julia-mezzetti')" title="Julia Mezzetti">Julia Mezzetti</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/laori')" title="Laôri">Laôri</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/laura-porto')" title="Laura Porto">Laura Porto</span></li>                             
                                    </ul> 
                                    

                                    <ul class="navListagem" style="left:0px; position:relative;float:left;padding-top:15px;">
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/lille')" title="Lille">Lille</span></li>  
									  <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/luz-da-lua')" title="Luz da Lua">Luz da Lua</span></li>  
                                      <!--<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/luiza-barcelos" title="Luiza Barcelos">Luiza Barcelos</span></li>-->

                                      
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/masiero')" title="Masiero">Masiero</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/mezzo-punto')" title="Mezzo Punto">Mezzo Punto</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/miezko')" title="Miezko">Miezko</span></li>   
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/ramarim')" title="Ramarim">Ramarim</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/rendeira')" title="Rendeira">Rendeira</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/ricarelly')" title="Ricarelly">Ricarelly</span></li>

                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/tabita')" title="Tabita">Tabita</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/usaflex')" title="Usaflex">Usaflex</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/via-mart')" title="Via Marte">Via Marte</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/Vizzano')" title="Vizzano">Vizzano</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/via-uno')" title="Calçados Via Uno">Via Uno</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/werner')" title="Werner">Werner</span></li>                                                                   
                                    </ul>                                          
                                                                            
									 
                                     <ul class="navListagem" style="left:0px; position:relative;float:left; padding-top:15px; ">                                      
                                      <li class="navListagemTitulo">Faixa de Preço</li>                 
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-femininos/6-0-0-0-0-1-0')" title="Produtos femininos até R$ 99,99"> at&eacute; R$ 99,90</span></li>

                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-femininos/6-0-0-0-0-100-0')" title="Produtos femininos de R$ 100 a R$ 199,90">R$ 100 a R$ 199,90</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-femininos/6-0-0-0-0-200-0')" title="Produtos femininos de R$ 200 a R$ 299,90">R$ 200 a R$ 299,90</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-femininos/6-0-0-0-0-300-0')" title="Produtos femininos de R$ 300 a R$ 399,90">R$ 300 a R$ 399,90</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-femininos/6-0-0-0-0-400-0')" title="Produtos femininos de R$ 400 a R$ 499,90">R$ 400 a R$ 499,90</span></li>
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-femininos/6-0-0-0-0-500-0')" title="Produtos femininos de R$ 500 a R$ 599,90">R$ 500 a R$ 599,90</span></li>   
                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-femininos/6-0-0-0-0-600-0')" title="Produtos femininos de R$ 600 a R$ 699,90">R$ 600 a R$ 699,90</span></li>

                                      <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-femininos/6-0-0-0-0-700-0')" title="Produtos femininos de R$ 700 a R$ 799,90">R$ 700 a R$ 799,90</span></li>              
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
					<div id="navItemMasculino"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-masculinos')" title="Calçados Masculinos">Calçados Masculinos</span></div>
					<ul>
						<li>
							<div class="navContainerMaster">
								<div id="navItemMasculinoOver"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-masculinos')" title="Sapatos Masculinos"></span></div>
								<div class="navContainer" style="width:560px; height:220px;">
									<div class="navBorder">

                                    	
                                                                                  
                                     <ul class="navListagem" style="left:0px; position:relative;float:left; padding-top:10px; ">
                                       <li class="navListagemDestaque"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/novidades-masculino')" title="Novidades">Novidades</span></li>
                                       <li class="navListagemDestaque"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-masculino/2-0-0-0-9')" title="Promo&ccedil;&otilde;es">Promo&ccedil;&otilde;es</span></li>
										
                                        
                                       <li class="navListagemTitulo">Calçados Masculinos</li>
                                       <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/exclusiva-democrata')" title="Exclusiva Democrata">Exclusiva Democrata</span></li>
                                       <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/exclusiva-ferracini')" title="Exclusiva Ferracini">Exclusiva Ferracini</span></li>

                                       <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/exclusiva-freeway')" title="Exclusiva Freeway">Exclusiva Freeway</span></li>
                                       <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/acessorios-masculinos')" title="Botas">Acessórios</span></li>
                                       <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/botas-masculinas')" title="Botas">Botas</span></li>
                                       <!--<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/carteiras')" title="Carteiras">Carteiras</span></li>-->
                                       <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/chinelos')" title="Chinelos">Chinelos</span></li>
                                       <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/cintos')" title="Cintos">Cintos</span></li>	
                                       <!--<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/sandalias-masculinas" title="Sand&aacute;lias">Sand&aacute;lias</span></li>--> 
                                      </ul> 
                                       
                                       
                                        <ul class="navListagem" style="left:0px; position:relative;float:left; padding-top:10px; ">

                                          <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/sapatos-masculinos')" title="Sapatos">Sapatos</span></li>
                                          <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/sapatenis')" title="Sapat&ecirc;nis">Sapat&ecirc;nis</span></li>	
                                          <li class="navListagemTitulo">Marcas</li> 
                                          <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/adidas')" title="Adidas">Adidas</span></li>
                                          <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/democrata')" title="Democrata">Democrata</span></li>
                                          <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/ferracini')" title="Ferracini">Ferracini</span></li>

                                          <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/goyazes')" title="Goyazes">Goyazes</span></li>
                                          <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/italianinho')" title="Italianinho">Italianinho</span></li>
                                          <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/macboot')" title="Macboot">Macboot</span></li>
                                          <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/opananken')" title="Opananken">Opananken</span></li>
                                          <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/pegada')" title="Pegada">Pegada</span></li>
                                            
                                         
                                        </ul> 
                                        
                                         
                                        <ul class="navListagem" style="left:0px; position:relative;float:left; padding-top:10px; ">

                                       
                                         <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/picolotto')" title="Picolotto">Picolotto</span></li> 
                                         <li class="navListagemTitulo">Faixa de pre&ccedil;o</li>
        
                                         <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-masculinos/2-0-0-0-0-1-0')" title="Calçados masculinos at&eacute; R$ 99,90"> at&eacute; R$ 99,90</span></li>
                                         <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-masculinos/2-0-0-0-0-100-0')" title="Calçados masculinos de R$ 100 R$ 199,90">R$ 100 R$ 199,90</span></li>
                                         <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-masculinos/2-0-0-0-0-200-0')" title="Calçados masculinos de R$ 200 R$ 299,90">R$ 200 R$ 299,90</span></li>

                                         <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-masculinos/2-0-0-0-0-300-0')" title="Calçados masculinos de R$ 300 R$ 399,90">R$ 300 R$ 399,90</span></li>
                                       
                                         </ul> 
                                         
                                         
                                    </div>
								</div>
								<div class="navShadow" style="width:560px; height:190px;"></div>
							</div>
						</li>
					</ul>
				</li>

				<li class="navSpace"></li>
				<li>
					<div id="navItemKids"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-infantis')" title="Calçados Infantis">Calçados Infantis</span></div>
					<ul>
						<li>
							<div class="navContainerMaster">
								<div id="navItemKidsOver"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-infantis')" title="Kids"></span></div>
								<div class="navContainer" style="width:350px; height:280px;">

									<div class="navBorder">
                                    	
                                                                                  
                                       <ul class="navListagem" style="left:0px; position:relative;float:left; padding-top:10px; ">
                                       
                                            <li class="navListagemDestaque"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/Kids/90-0-0-0-34')" title="Novidades">Novidades</span></li>
                                            <li class="navListagemDestaque"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/Kids/90-0-0-0-35')" title="Promo&ccedil;&otilde;es">Promo&ccedil;&otilde;es</span></li>
                                            
                                            <li class="navListagemTitulo">Calcados Infantis</li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/acessorios-infantis')" title="Acessórios">Acessórios</span></li>  
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/baby')" title="Baby">Baby</span></li>

                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/casual-infantil')" title="Casual">Casual</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/esporte-infantil')" title="Esporte">Esporte</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/menina')" title="Menina">Menina</span></li>
                                            <li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/menino')" title="Menino">Menino</span></li>
											<li class="navListagemTitulo">Faixa de pre&ccedil;o</li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-infantis/90-0-0-0-0-1-0')" title="Calçados infantis at&eacute; R$ 99,90"> at&eacute; R$ 99,90</span></li>

											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-infantis/90-0-0-0-0-100-0')" title="Calçados infantis de R$ 100 R$ 199,90">R$ 100 R$ 199,90</span></li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-infantis/90-0-0-0-0-200-0')" title="Calçados infantis de R$ 200 R$ 299,90">R$ 200 R$ 299,90</span></li>
                                       
                                      </ul>
                                       
                                       
                                        <ul class="navListagem" style="left:0px; position:relative;float:left; padding-top:10px; ">
										
											<li class="navListagemTitulo">Marcas</li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-infantis/90-0-4-0-0-0-0')" title="Adidas">Adidas</span></li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/bee-happy')" title="Bee Happy">Bee Happy</span></li>

											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/bibi')" title="Bibi">Bibi</span></li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/casual-infantil/92-0-11-0-0-0-0')" title="Converse All Star">Converse All Star</span></li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/ferrettinha')" title="Ferrettinha">Ferrettinha</span></li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/gambo')" title="Gambo Baby">Gambo Baby</span></li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/calcados-infantis/90-0-213-0-0-0-0')" title="Grendene">Grendene</span></li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/havaianas-infantil')" title="Havaianas">Havaianas</span></li>

											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/hokibaby')" title="Hokibaby">Hokibaby</span></li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/ortope')" title="Ortopé">Ortopé</span></li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/Kids/90-0-1-0-32-0')" title="Nike">Nike</span></li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/pe-com-pe')" title="Pé com Pé">Pé com Pé</span></li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/sonho-de-crianca')" title="Sonho de Criança">Sonho de Criança</span></li>
											<li class="navListagemNormal"><span onclick="abrePaginaMenu('http://www.anitaonline.com.br/esporte-infantil/91-0-14-0-0-0-0')" title="Umbro">Umbro</span></li>

											
                                         </ul>

                                    </div>
								</div>
								<div class="navShadow" style="width:350px; height:280px;"></div>
							</div>
						</li>
					</ul>
				</li>

				<li class="navSpace"></li>
				
				<li>
					<div id="navItemNovidades"><span onclick="abrePaginaMenu('novidades')" title="Novidades">Lançamentos de Calçados</span></div>
				</li>
				
				<li class="navSpace"></li>
				
				<li>
					<div id="navItemPromocoes"><span onclick="abrePaginaMenu('promocoes')" title="Promoção de Calçados">Calçados em Promoção</span></div>

				</li>
				
			</ul>
        </div>
	    <!--// MENU PRINCIPAL -->

    </div>
    <!-- // principal -->

    <div id="rodape2009" style="background:url(http://static.anitaonline.com.br/images/2011/bg-rodape-prov-2.png) repeat-x">
        <div id="containerRodapeNovo">
            <!--Busca Rodape-->
            <div id="buscaNovo" style="margin-top:25px;">
                <form method="GET" onsubmit="return enviaBusca(document.getElementById('buscaRodape').value)">
                    <input id="buscaRodape" class="buscaInputNovo" style="border:none;float:left" type="text">
                    <input src="../../images/btn-buscar-novo.png" style="float:right;margin-top:3px;margin-right:5px;" type="image">
                </form>
            </div>
            <!--   <ul id="maisBuscadosNovo"><li><span>+Buscados:</span></li><li><a href="#">Sandálias,</a></li><li><a href="#">Nike Shox,</a></li><li><a href="#">Nike Shox,</a></li><li><a href="#">Nike Shox,</a></li></ul>--><!--Busca Rodape-->
            <div id="blocoBaixoRodapeNovo">
                <!--Container Esquerda-->
                <div id="containerEsquerdaRodape">
                    <div id="rodapeNovoAtencdimento">
                        <span>Central de Atendimento e Televendas:</span>
                        <strong>(11) 4063-5001</strong>
                        <strong>(21) 4063-5001</strong><br>
                        <strong>(67) 3389-4290</strong>
                        <p>Horário de atendimento:<br>Segunda à Sexta, das 09:00 às 18:00 e aos Sábados das 09:00 às 13:00 (horário de Brasília).</p>
                    </div>
                    <div id="rodapeNovoOutrosAtt">
                        <h3>Mais opções de Atendimento:</h3>
                        <ul>
                            <li><a href="contato.php">Central de Atendimento</a></li>
                            <li><a onclick=" window.open('http://anitaonline.mysuite.com.br/clientvivo.php?param=sochat_chatdep&amp;inf=&amp;sl=ant&amp;redirect=http://anitaonline.mysuite.com.br/empresas/ant/atendimento.php','Atendimento','toolbar=no,location=no,status=no,menubar=no,scrollbars=no,resizable=no,width=600,height=450');" href="javascript:void(false);">Chat ao Vivo</a></li>
                            <li><a href="atendimento" title="Dúvidas Frequentes">Dúvidas Frequentes</a></li>
                        </ul>
                    </div>
                </div>
                <!--Container Esquerda-->
                <!--Container Meio-->
                <div id="containerMeioRodape">
                    <div id="rodapeNovoInstitucional">
                        <h3>Institucional:</h3>
                        <ul style="border-right:1px solid #DDD;">
                            <li><a href="institucional.php" title="Empresa">Empresa</a></li>
                            <li><a href="lojas.php" title="Lojas">Lojas</a></li>
                            <li><a href="trabalhe_conosco.php" title="Trabalhe Conosco">Trabalhe Conosco</a></li>
                        </ul>
                        <ul style="width:178px;margin-left:20px;">
                            <li><a href="politica_de_uso.php" title="Política de Uso">Política de Uso</a></li>
                            <li><a href="politica_de_devolucao.php" title="Política de troca e devolução">Política de troca e devolução</a></li><li><a href="seguranca_e_privacidade.php" title="Segurança e Privacidade">Segurança e Privacidade</a></li>
                        </ul>
                    </div>
                    <div id="rodapeNovoNewsletter">
                        <h3>Receba ofertas exclusivas:</h3>
                        <form action="receba_novidades.php" method="POST">
                            <input name="act" value="registering" type="Hidden">
                            <input name="nome" id="nome" value="Nome" class="formRodapeNovo" onfocus="focar('Nome',this);" onblur="desfocar('Nome',this);" style="margin-top:5px;" type="text">
                            <div> 
                                <input name="email" id="email" value="Email" class="formRodapeNovo" onfocus="focar('Email',this);" onblur="desfocar('Email',this);" style="display:block;margin-top:5px;float:left" type="text"> 
                                <input src="../../images/BTN-OK.png" style="margin-top:5px;float:left;margin-left:10px" type="image">
                            </div>
                            <div class="clear">
                            </div>
                            <input name="sexo" value="Masculino" id="idMasculino" class="formpadrao_radio" style="border:none;" type="radio">
                            <label for="idMasculino" class="cadastro_label_dentro" style="font-weight: normal;">Masculino</label>
                            <input name="sexo" checked="checked" value="Feminino" id="idFeminino" class="formpadrao_radio" style="border:none;" type="radio"><label for="idFeminino" class="cadastro_label_dentro" style="font-weight: normal;">Feminino</label>
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
                    <p>Acompanhe a AnitaOnline nas Redes Sociais</p>
                    <ul class="linksSocial">
                        <li class="sprite" id="twitterNovo"><a href="http://twitter.com/siteAnitaOnline" title="Twitter" target="_blank">Twitter</a></li><li class="sprite" id="facebookNovo"><a href="http://www.facebook.com/AnitaOnlineOficial" title="Facebook" target="_blank">Facebook</a></li><li class="sprite" id="youtubeNovo"><a href="http://www.youtube.com/user/AnitaOnlineOficial" title="Youtube" target="_blank">Youtube</a></li>
                        <li class="sprite" id="orkutNovo"><a href="http://www.orkut.com.br/Main#Community.aspx?cmm=73750109" title="Orkut" target="_blank">Orkut</a></li><li class="sprite" id="blogNovo"><a href="http://www.anitaonline.com.br/anitaacontece/" title="Blog Anita Acontece" target="_blank">Anita Acontece</a></li>
                    </ul>
                </div>
                <div id="rodapeFormasNovo">
                    <h3>Meios de Pagamento</h3>
                </div>
                <div id="rodapeSegurancaNovo">
                    <h3>Compre com segurança</h3>
                </div>
                <div id="rodapeEmpresaAmigoNovo" class="sprite">
                    <a href="http://www.aacc-ms.org.br/view/home/" target="_blank">Empresa Amiga</a>
                </div>
            </div>
            <div id="creditos"><a href="http://www.maisempresas.com/" title="Desenvolvimento de Sites">Tecnologia: Mais Empresas</a>
            </div>
        </div>
    </div>
</body>
</html>