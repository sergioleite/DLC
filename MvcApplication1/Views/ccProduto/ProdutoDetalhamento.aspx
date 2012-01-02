<%@ Import Namespace="br.com.deboraleite" %>
<%=""%>

<%
    Dim v As cmProdutoDetalhamento
    v = ViewData.Model
    Dim categoria As cmCategoria
%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <!-- http://www.anitaonline.com.br/scarpin-ferrette-branco-offwht-119361?utm_campaign=Destaques-calcados-femininos&utm_medium=Anitaonline-Site&utm_source=calcados-femininos-Linha-1&utm_content=calcados-femininos-Linha-1-Posicao-4-scarpin-ferrette-branco&utm_term= -->
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <title>
        Calçados femininos e acessórios - Débora Leite - A moda online em calçados
    </title>
    <link rel="shortcut icon" href="../../images/favicon.ico" type="image/x-icon"/>
    
    <script src="../../js/jquery-1.6.js" type="text/javascript"></script>
    <script src="../../js/jquery.jqzoom-core.js" type="text/javascript"></script>
    <link href="../../jquery.jqzoom.css" rel="stylesheet" type="text/css" />

    <link type="text/css" rel="stylesheet" href="../../geral.css"/>
    <link type="text/css" rel="stylesheet" href="../../padrao_20110906a.css"/>
    <link type="text/css" rel="stylesheet" href="../../produtos_300711a.css"/>
    <link href="../../padrao_20110923a.css" rel="stylesheet" type="text/css" />
    <link type="text/css" rel="stylesheet" href="../../thickbox.css"/>
    
    <script src="../../js/funcoesMenu.js" type="text/javascript"></script>
    
    <script type="text/javascript">

        $(document).ready(function () {
            $('.jqzoom').jqzoom({
                zoomType: 'standard',
                lens: false,
                preloadImages: true,
                alwaysOn: false,
                zoomWidth: 388,
                zoomHeight: 388,
                title: false,
                xOffset: 0,
                preloadText: 'Carregando...'
            });


            $('.jqzoom').mouseover(function () {
                //alert("oi");
                $("#Temp").width(800);
                $("#fotoMedia").width(800);
                $("#Ola").hide();
            });


            $('.jqzoom').mouseout(function () {
                //alert("oi");
                $("#Temp").width(410);
                $("#fotoMedia").width(410);
                $("#Ola").show();
            });


            $('td.fotoMiniatura a').mouseover(function () {
                $(this).click();

            });

            $('td.fotoMiniatura a img').mouseover(function () {
                $(this).css("border", "0px solid #FF0000")
            });


            $('td.fotoMiniatura a img').mouseout(function () {
                $(this).css("border", "0px solid #FFFFFF")
            });

            // Trata o clique sobre a numeração dos sapatos



        });



        function ToggleClass(sender, tamanho) {
//            $('.numeracao a').each(function(id) {
//                $(sender).parent().removeClass("selecionado");
//                $(sender).parent().removeClass("naoSelecionado");
//            });

            $('.numeracao div').removeClass("selecionado naoSelecionado")
            $('.numeracao div').addClass("naoSelecionado");
            $(sender).parent().addClass("selecionado");
            $('#tamanho').text(tamanho)
        }

    </script>

    <script src="../../js/micoxAjax.js" type="text/javascript"></script>

   

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
                            <li><h3><a href="/" title="Novidades">Novidades</a></h3></li>
                            <li><h3><a href="/" title="Promoções">Promoções</a></h3></li> <!-- TODO SLS -->
                        </ul>
                    </li>
                </ul>
    
    
            <!-- /MENU TAGS -->      	      		
                <ul class="nivel1">
                    <li>
                        <h2 class="titulos"><a href="/">Feminino</a></h2>
                            <ul class="nivel2">
                        <%  For Each categoria In v.Categorias%>
                    	        <li><a href=<%=v.PathTo_Categorias(categoria.href) %>> <%= categoria.Title%></a></li> 
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
                
                <!-- TODO SLS -->
                <!--
                <div id="migalhasProduto">
                    <a href="http://www.deboraleite.com.br/index.php">Página Inicial </a>
                    &nbsp; &gt;
                    <a href="calcados-femininos">Feminino</a>
                    &nbsp; &gt;
                    <a href="scarpins">Scarpins</a>
                    &nbsp; &gt;
                    <a href="ferrette">Marca: Ferrette</a>
                </div>
                -->

                <div id="containerAll" style="clear:both;overflow:hidden;display:block">
                    <div id="Temp" style="float:left; display:block; overflow:hidden; width:410px;height:480px; ">
                        <div class="viewProdutoFoto2">
                            <div id="fotoMedia" style="height:410px;width:412px;text-align:center;">
                                <div id="loadingFoto" style="display: none;">
                                    <span style="color:#999999;">
                                        <img border="0" src="../../images/zoomloader.gif">
                                        <br>
                                        Carregando
                                    </span>
                                </div>
                                <span class="tozoom">
                                            <!--<a href="../../images/scarpin-feminino-ferrette-branco-site_produtos-1459211714.jpg" class="jqzoom" rel='gal1'> -->
                                            <a href="<%=v.GetNomeArquivoImagem(1,"G") %>" class="jqzoom" rel='gal1'> 
                                                <img src="<%=v.GetNomeArquivoImagem(1,"M") %>"  title="triumph"  style="border: 0px solid #666;" height="410px"; width="410px">
                                            </a>
                                </span>
                            </div>

                            <table>
                                <tr>
                                <%  
                                    Dim img As cmImagemModelo
                                    Dim imgIndex As Int16
                                    Dim nomeClass = New String("fotoMiniaturaSelect")
                                    Dim perspectiva As Object
                                    Dim arquivo_pequeno As String
                                    Dim arquivo_medio As String
                                    Dim arquivo_grande As String

                                    For Each perspectiva In v.Produto.Perspectivas
                                        arquivo_pequeno = v.GetNomeArquivoImagem(perspectiva.ToString(), "P")
                                        arquivo_medio = v.GetNomeArquivoImagem(perspectiva.ToString(), "M")
                                        arquivo_grande = v.GetNomeArquivoImagem(perspectiva.ToString(), "G")
                                        %>
                                        <td class="<%=nomeClass %>">
                                            <a alt="Foto" href='javascript:void(0);' rel="{gallery: 'gal1', smallimage: '<%=arquivo_medio%>',largeimage: '<%=arquivo_grande%>'}">
                                                <img src='<%=arquivo_pequeno%>'  width="50px" height="50px"/>
                                            </a>
                                        </td>
                
                                        <td width="4px;"></td>
                                <%  
                                    nomeClass = "fotoMiniatura"
                                    Next
                                %>
<%--
                                <td class="fotoMiniatura">
                                    <a alt="Foto"  href='javascript:void(0);' rel="{gallery: 'gal1', smallimage: '../../images/scarpin-feminino-ferrette-branco-site_produtos-214482278_media.jpg',largeimage: '../../images/scarpin-feminino-ferrette-branco-site_produtos-214482278.jpg'}">
                                        <img src='../../images/scarpin-feminino-ferrette-branco-site_produtos-214482278_pequena.jpg'  width="50px" height="50px"/>
                                    </a>
                                </td>
                                
                                <td width="4px;"></td>

                                <td class="fotoMiniatura">
                                    <a alt="Foto"  href='javascript:void(0);' rel="{gallery: 'gal1', smallimage: '../../images/scarpin-feminino-ferrette-branco-site_produtos-1627510854_media.jpg',largeimage: '../../images/scarpin-feminino-ferrette-branco-site_produtos-1627510854.jpg'}">
                                        <img src='../../images/scarpin-feminino-ferrette-branco-site_produtos-1627510854_pequena.jpg'  width="50px" height="50px"/>
                                    </a>
                                </td>

                                <td class="fotoMiniatura">
                                    <a alt="Foto"  href='javascript:void(0);' rel="{gallery: 'gal1', smallimage: '../../images/scarpin-feminino-ferrette-branco-site_produtos-1792023476_media.jpg',largeimage: '../../images/scarpin-feminino-ferrette-branco-site_produtos-1792023476.jpg'}">
                                        <img src='../../images/scarpin-feminino-ferrette-branco-site_produtos-1792023476_pequena.jpg'  width="50px" height="50px"/>
                                    </a>
                                </td>
--%>
                              </tr>
                            </table>
                        </div>
                    </div>
                    <div id="Ola"style="float: right; display:block; overflow:hidden; height:100%; width:390px;">
                        <h1 class="viewProdutoTitulo"><%=v.Produto.Title%>  </h1>
                        <div class="viewProdutoInfo">
                            <!-- preco promocional -->
                            <div class="containerPrecos">
                                <%If v.Produto.PrecoPromocional <> 0.0 Then%>
                                <div class="viewProdutoDe">
                                    de: R$ <%= v.Produto.PrecoNormal%> &nbsp
                                </div>  
                                <%End If%>


                                <!-- Preco normal -->
                                <div class="viewProdutoPor">
                                    por: 
                                    <%If v.Produto.PrecoPromocional <> 0.0 Then%>
                                        <span class="preco">R$ <%= FormatNumber(v.Produto.PrecoPromocional, 2)%> </span> <!-- subst-->
                                    <%Else%>
                                        <span class="preco">R$ <%= FormatNumber(v.Produto.PrecoNormal, 2)%> </span> <!-- subst-->
                                    <%End If%>
                                </div>  
                                            
                                <!-- Qtde parcelas -->          
                                <div class="viewProdutoParcelas">
                                    &nbsp
                                    Em <%=v.Produto.ParcelasQtde%>x de <!-- subst-->
                                    <strong>R$ <%= FormatNumber(v.Produto.ParcelaValor, 2)%> </strong> <!-- subst-->
                                    sem juros no cartão
                                </div>
                            </div>
                            
                            <!-- Passo Um -->
                            <div class="produtoPassoUm">
                                <div class="viewProdutoOpcoes">
                                    Mais opções deste modelo
                                </div>
                                <div class="viewProdutoOpcoesFotos"> <!-- subst -->
                                <%
                                    Dim outrosModelos As Collection
                                    outrosModelos = cmProdutos.Get_OutrosModelos_MesmoProduto(v.Produto)
                                    Dim modelo As cmProduto
                                    
                                    For Each modelo In outrosModelos
                                %>
                                    <a title="<%=modelo.Title %>" class="cada-opcao-cor" href="<%=v.PathTo_Produto(modelo) %>">
                                        <img width="60" height="60" alt="<%=modelo.Title %>" style="margin-top:3px;" src="<%="/images/" & modelo.BackgroundImageUrl %>">
                                    </a>                                
                                <%  Next%>
                                </div>
                            </div>

                            <!-- Passo Dois -->
                            <div class="produtoPassoDois">
                                <div class="viewProdutoOpcoes">
                                    <img id="txtTamanhos" alt="TAMANHOS DISPONÍVEIS" src="http://static.anitaonline.com.br/images/txt_tamanhos_disponiveis.gif">
                                    <input id="focus" type="text" style="display:none" name="focus">
                                    <input id="tamanho" type="text" style="display:none" name="tamanho">
                                    <%
                                        Dim tamanho As cmTamanho
                                        For Each tamanho In v.Produto.TamanhosDisponiveis
                                    %>
                                    <div id="num_<%=tamanho.ID%>" class="numeracao">
                                        <div  class="naoSelecionado">
                                           <a href="javascript:void(0);" onclick="ToggleClass(this,<%=tamanho.ID%>);">
                                            <%= tamanho.ID%> 
                                            </a>
                                        </div>
                                    </div>
                                    <%Next%>
                                </div>
                            </div>
                            
                            <!-- Passo Três --> 
                            <div style="display:block; overflow:hidden; clear:both; ">
        	                    <div class="produtoPassoTres">
                                    <div id="idQuantidade"><input id="idQt" name="QuantidadeDesteProduto" value="1" type="hidden"></div>                                
                                    <div style="display:block;clear:both;overflow:hidden;">
                                        <div id="btnComprar" style="float:left;" onclick="javascript:comprarProduto();"></div>
                                        <div id="trocaGratis"></div>
                                    </div>   
         	                    </div>
                            </div>
                            <!-- //Passo Três --> 

                            <!-- Receba as novidades -->
                            <div style="padding:15px 0px 0px 0px;clear:both;">
                                <script type="text/javascript" >

                                    function recebaNovidades() {
                                        if ($('#containerRecebaNovidades').is(":hidden")) {
                                            $('#containerRecebaNovidades').fadeIn();
                                        }
                                        else {
                                            $('#containerRecebaNovidades').fadeOut();
                                        }
                                    }

                                    function novidades(email, sexo) {

                                        if (email == '') {
                                            document.getElementById('erroMsgNovidades').innerHTML = '<div class="semProdutoSpan">Erro: Digite seu e-mail</div>';
                                            return false;
                                        }

                                        if (sexo == 'null') {
                                            document.getElementById('erroMsgNovidades').innerHTML = '<div class="semProdutoSpan">Erro: Selecione Feminino<br>ou Masculino</div>';
                                            return false;
                                        }

                                        var url = "vars=" + email + "--" + sexo;

                                        ajaxGet("includes/novidades.php?" + url, document.getElementById("ajax"), true);
                                        document.getElementById('email').value = '';
                                        //document.getElementById('recebaNovidadesRadios').innerHTML = '';
                                        document.getElementById('enviarRecebeNovidades').innerHTML = '';

                                    }


                                    function Normal() {
                                        ajaxGet("includes/normal.php", document.getElementById("ajax"), true);

                                    }

                                    function enviaNovidades() {
                                        if (document.getElementById('radio_feminino').checked == true) {
                                            sexo = 'feminino';
                                        } else if (document.getElementById('radio_masculino').checked == true) {
                                            sexo = 'masculino';
                                        } else {
                                            sexo = 'null';
                                        }

                                        if (sexo != null) {
                                            document.getElementById('erroMsgNovidades').innerHTML = '';
                                            novidades(document.getElementById('email').value, sexo)
                                        }
                                    }

                                    $(document).ready(function () {
                                        $('#loadingFoto').hide();
                                        $('#fotoMedia').children('.tozoom').children('img').show();
                                        $('#fotoMedia').children('.tozoom').children('img').attr('alt', $('.fotoMiniaturaSelect').children('a').attr('alt').replace('_media.', '.'));

                                        $('.fotoMiniatura, .fotoMiniaturaSelect').mouseover(function () {
                                            /* ESCONDE FOTO E MOSTRA CARREGANDO */
                                            $('#fotoMedia').children('.tozoom').children('img').hide();
                                            $('#loadingFoto').attr('style', 'margin-top:150px;');
                                            $('#loadingFoto').show();

                                            var novoHref = $(this).children('a').attr('alt').replace('_media.', '.');

                                            $('.fotoMiniaturaSelect').attr('class', 'fotoMiniatura');
                                            $(this).attr('class', 'fotoMiniaturaSelect');
                                            $('#fotoMedia').children('.tozoom').children('img').attr('alt', novoHref);
                                            $('#fotoMedia').children('.tozoom').children('img').attr('src', $(this).children('a').attr('alt'));

                                            /* MOSTRA FOTO E ESCONDE CARREGANDO */
                                            $('#loadingFoto').attr('style', '');
                                            $('#loadingFoto').hide();
                                            $('#fotoMedia').children('.tozoom').children('img').show();
                                        });

                                        var options = {
                                            xzoom: 420,
                                            yzoom: 420,
                                            offset: 0,
                                            position: "right"
                                        };

                                        $('img.jqzoom').jqueryzoom(options);

                                        $('img.jqzoom').mouseover(function () {
                                            var margin = ((410 - $(this).attr('width')) / 2) + 6;
                                            $('div.zoomdiv').css('margin-left', margin + 'px');
                                        });

                                    });

                                    function abreFormeEmail() {
                                        $("#btnAviseme").click(function () {
                                            $("#aviseme").css("display", "block");
                                        });
                                    }
                                </script>

                                <div style="padding:15px 0px 0px 0px;clear:both;">
                                    <div style="cursor:pointer;" onclick="javascript:recebaNovidades();">
                                        <img alt="Receba Novidades" src="http://static.anitaonline.com.br/images/botao_recebaNovidades.jpg">
                                    </div>
                                    <div id="containerRecebaNovidades" style="background-image:url('http://static.anitaonline.com.br/images/recebaNovidadesSprites.png'); height: 210px; width: 350px; top: -64px; position: relative; display:none">
                                        <div id="mensagem" style="position:absolute; top:10px; right:10px; width:170px; color:#DFCD01;" name="mensagem"></div>
                                        <div onclick="recebaNovidades()" style=" height:70px; width:320px; display:block; cursor:pointer;">&nbsp;</div>
                                        <form id="formail" name="formail">
                                            <div id="ajax" class="micoxajax" style=" padding-left:15px; display:block;">
                                                <div id="recebaNovidadesEmail" style="background-image:url(http://static.anitaonline.com.br/images/recebaNovidadesSprites.png); display:block; background-position:-5px -215px; height:20px; text-indent:-500px; width:150px; border:0px solid; ">Digite seu e-mail</div>
                                                <div id="recebaNovidadesCampoEmail" style="height:30px; width:250px; border:0px solid; display:block; ">
                                                    <input id="Text1" type="text" style=" width:240px; font-size:16px; padding:4px;" name="email">
                                                </div>
                                                <div id="recebaNovidadesRadios" style="display:block; border:0px solid; padding-top:15px; ">
                                                    <div style="width:25px; padding-top:5px; float:left; border:0px solid;">
                                                        <input type="radio" id="radio_masculino" value="Masculino" name="rsexo">
                                                    </div>
                                                    <div style=" float:left; background-image:url(http://static.anitaonline.com.br/images/recebaNovidadesSprites.png); background-position:-8px -235px; height:20px; width:80px; border:0px solid; cursor:pointer;">&nbsp;</div>
                                                    <div style="width:25px; float:left; border:0px solid; padding-left:30px; padding-top:5px;">
                                                        <input id="radio_feminino" type="radio" value="Feminino" name="rsexo">
                                                    </div>
                                                    <div style=" float:left; background-image:url(http://static.anitaonline.com.br/images/recebaNovidadesSprites.png); background-position:-95px -235px; height:20px; width:75px; border:0px solid; cursor:pointer;">&nbsp;</div>
                                                </div>
                                                <div onclick="enviaNovidades();" style=" background-image:url(http://static.anitaonline.com.br/images/recebaNovidadesSprites.png); margin-left:15px; margin-top:35px; clear:both; display:block; background-position:-180px -220px; height:26px; width:106px; border:0px solid; cursor:pointer;">&nbsp;</div>
                                            </div>
                                        </form>
                                    </div>
                                </div>
                            </div>
                            <!-- //Receba as novidades -->
                        </div>
                    </div>
                </div>
                
                <div style=" clear:both; display:block; overflow:hidden; height:100%; ">
                    <div id="produtoAbas" style="width:836px;margin-top:40px;">
                        <a id="abaDescricao" onclick="mostraDescricao();" name="descricao">DESCRIÇÃO DO PRODUTO</a>
                    </div>
                    <div id="contentDescricao" class="abaContent" style="display:block;float:left;margin-bottom:20px">
                        <strong>Código:</strong> <%=v.Produto.Codigo %><br><br>

                        <%=v.Produto.Descricao_HTML %>
<%--                        <span style="color: #222222; font-family: Arial, Helvetica, sans-serif; font-size: 12px" class="Apple-style-span"><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">Entre os modelos de<span class="Apple-converted-space">&nbsp;</span><a style="text-decoration: none; color: #ff0000; border-style: none; padding: 0px; margin: 0px" href="http://www.anitaonline.com.br/calcados-femininos">calçados femininos</a>, um dos mais versáteis são os<span class="Apple-converted-space">&nbsp;</span><a style="text-decoration: none; color: #ff0000; border-style: none; padding: 0px; margin: 0px" href="http://www.anitaonline.com.br/scarpins">scarpins</a>, que sempre transmitem sofisticação e elegância à mulher.</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">A marca<span class="Apple-converted-space">&nbsp;</span><a style="text-decoration: none; color: #ff0000; border-style: none; padding: 0px; margin: 0px" href="http://www.anitaonline.com.br/ferrette">Ferrette</a>, investiu em lindos modelos de scarpins nessa coleção, são calçados produzidos em couro e cores modernas.</p></span> <br><p>&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px"><strong style="font-weight: bold; border-style: none; padding: 0px; margin: 0px">Salto:</strong>&nbsp;8,0 cm aprox.</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px"><strong style="font-weight: bold; border-style: none; padding: 0px; margin: 0px">Material:</strong>&nbsp;Cabedal confeccionado em couro, com detalhe de costura, atribuindo charme ao scarpin;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">Palmilha em couro, garantinho conforto;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">Salto fachetado;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">Solado em microduro, garantindo durabilidade e segurança ao caminhar.</p>
--%>
                        <br>
                    
                        <div style="border-top:solid 1px #e4e4e4;padding-top:10px;margin-top:12px;">          
                            <h2 style="font-size:12px;height:20px;">A primeira troca é por nossa conta.</h2>
                            Caso precise de mais detalhes referente às medidas do calçado, entre em contato conosco.<br>
                            Obtenha mais informações sobre <a href="http://www.deboraleite.com.br/seguranca_e_privacidade.php" title="Segurança e Privacidade">Segurança e Privacidade</a> ao realizar uma compra na Débora Leite Calçados. 
                        </div>
                        <div style="border-top:solid 1px #e4e4e4;padding-top:10px;margin-top:12px;">
                            <strong>Informações: (11) XXXX-XXXX - E-mail: contato@deboraleite.com.br</strong><br>
                            Os preços, as <a href="http://www.deboraleite.com.br/promocoes" title="Calçados em promoção">promoções</a>, o frete de entrega e as condições de pagamento informados no site www.deboraleite.com.br, são válidos apenas para compras via Internet vinculado a disponibilidade de estoque.
          			    </div>
                    </div>
                </div>
            </div>
        </div>
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