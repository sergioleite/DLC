/****** Object:  ForeignKey [FK_PRODUTOS_CORES_TAMANHOS_PRODUTOS_CORES]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_TAMANHOS_PRODUTOS_CORES]') AND parent_object_id = OBJECT_ID(N'[dbo].[ESTOQUE]'))
ALTER TABLE [dbo].[ESTOQUE] DROP CONSTRAINT [FK_PRODUTOS_CORES_TAMANHOS_PRODUTOS_CORES]
GO
/****** Object:  ForeignKey [FK_PRODUTOS_CORES_TAMANHOS_TAMANHOS]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_TAMANHOS_TAMANHOS]') AND parent_object_id = OBJECT_ID(N'[dbo].[ESTOQUE]'))
ALTER TABLE [dbo].[ESTOQUE] DROP CONSTRAINT [FK_PRODUTOS_CORES_TAMANHOS_TAMANHOS]
GO
/****** Object:  ForeignKey [FK_PRODUTOS_CORES_IMAGENS_PRODUTOS_CORES]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_IMAGENS_PRODUTOS_CORES]') AND parent_object_id = OBJECT_ID(N'[dbo].[IMAGEM_MODELO]'))
ALTER TABLE [dbo].[IMAGEM_MODELO] DROP CONSTRAINT [FK_PRODUTOS_CORES_IMAGENS_PRODUTOS_CORES]
GO
/****** Object:  ForeignKey [FK_PRODUTOS_CORES_CORES1]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_CORES1]') AND parent_object_id = OBJECT_ID(N'[dbo].[MODELO]'))
ALTER TABLE [dbo].[MODELO] DROP CONSTRAINT [FK_PRODUTOS_CORES_CORES1]
GO
/****** Object:  ForeignKey [FK_PRODUTOS_CORES_PRODUTOS1]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_PRODUTOS1]') AND parent_object_id = OBJECT_ID(N'[dbo].[MODELO]'))
ALTER TABLE [dbo].[MODELO] DROP CONSTRAINT [FK_PRODUTOS_CORES_PRODUTOS1]
GO
/****** Object:  ForeignKey [FK_PRODUTOS_CATEGORIAS]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CATEGORIAS]') AND parent_object_id = OBJECT_ID(N'[dbo].[PRODUTO]'))
ALTER TABLE [dbo].[PRODUTO] DROP CONSTRAINT [FK_PRODUTOS_CATEGORIAS]
GO
/****** Object:  StoredProcedure [dbo].[adml_imagem_insert]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_imagem_insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_imagem_insert]
GO
/****** Object:  StoredProcedure [dbo].[adml_imagem_update]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_imagem_update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_imagem_update]
GO
/****** Object:  StoredProcedure [dbo].[adml_modelo_delete]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_modelo_delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_modelo_delete]
GO
/****** Object:  StoredProcedure [dbo].[adml_modelo_insert]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_modelo_insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_modelo_insert]
GO
/****** Object:  StoredProcedure [dbo].[adml_modelo_update]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_modelo_update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_modelo_update]
GO
/****** Object:  StoredProcedure [dbo].[adml_produto_delete]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_produto_delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_produto_delete]
GO
/****** Object:  StoredProcedure [dbo].[adml_get_imagens_de_perspectiva_modelo]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_get_imagens_de_perspectiva_modelo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_get_imagens_de_perspectiva_modelo]
GO
/****** Object:  StoredProcedure [dbo].[get_coresdisponiveis]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_coresdisponiveis]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_coresdisponiveis]
GO
/****** Object:  StoredProcedure [dbo].[get_imagens_modelo]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_imagens_modelo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_imagens_modelo]
GO
/****** Object:  StoredProcedure [dbo].[get_modelo]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_modelo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_modelo]
GO
/****** Object:  StoredProcedure [dbo].[get_tamanhosdisponiveis]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_tamanhosdisponiveis]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_tamanhosdisponiveis]
GO
/****** Object:  StoredProcedure [dbo].[adml_get_perspectivas_modelo]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_get_perspectivas_modelo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_get_perspectivas_modelo]
GO
/****** Object:  StoredProcedure [dbo].[get_perspectivas_imagens_modelo]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_perspectivas_imagens_modelo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_perspectivas_imagens_modelo]
GO
/****** Object:  StoredProcedure [dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico]
GO
/****** Object:  StoredProcedure [dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico_corunica]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico_corunica]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico_corunica]
GO
/****** Object:  StoredProcedure [dbo].[get_produtos_liberadosparavenda_categoriaunica]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_produtos_liberadosparavenda_categoriaunica]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_produtos_liberadosparavenda_categoriaunica]
GO
/****** Object:  StoredProcedure [dbo].[get_produtos_liberadosparavenda_categoriaunica_corunica]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_produtos_liberadosparavenda_categoriaunica_corunica]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_produtos_liberadosparavenda_categoriaunica_corunica]
GO
/****** Object:  Table [dbo].[IMAGEM_MODELO]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IMAGEM_MODELO]') AND type in (N'U'))
DROP TABLE [dbo].[IMAGEM_MODELO]
GO
/****** Object:  StoredProcedure [dbo].[get_outro_modelos_mesmo_produto]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_outro_modelos_mesmo_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_outro_modelos_mesmo_produto]
GO
/****** Object:  StoredProcedure [dbo].[adml_get_modelos_de_produto]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_get_modelos_de_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_get_modelos_de_produto]
GO
/****** Object:  Table [dbo].[ESTOQUE]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ESTOQUE]') AND type in (N'U'))
DROP TABLE [dbo].[ESTOQUE]
GO
/****** Object:  StoredProcedure [dbo].[adml_produto_insert]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_produto_insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_produto_insert]
GO
/****** Object:  StoredProcedure [dbo].[adml_produto_update]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_produto_update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_produto_update]
GO
/****** Object:  Table [dbo].[MODELO]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MODELO]') AND type in (N'U'))
DROP TABLE [dbo].[MODELO]
GO
/****** Object:  StoredProcedure [dbo].[adml_get_produtos]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_get_produtos]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_get_produtos]
GO
/****** Object:  StoredProcedure [dbo].[get_tamanho_por_urlamigavel]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_tamanho_por_urlamigavel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_tamanho_por_urlamigavel]
GO
/****** Object:  Table [dbo].[PRODUTO]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODUTO]') AND type in (N'U'))
DROP TABLE [dbo].[PRODUTO]
GO
/****** Object:  StoredProcedure [dbo].[get_categoria_por_urlamigavel]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_categoria_por_urlamigavel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_categoria_por_urlamigavel]
GO
/****** Object:  StoredProcedure [dbo].[get_categorias]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_categorias]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_categorias]
GO
/****** Object:  StoredProcedure [dbo].[get_cor_por_urlamigavel]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_cor_por_urlamigavel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_cor_por_urlamigavel]
GO
/****** Object:  StoredProcedure [dbo].[get_cores]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_cores]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[get_cores]
GO
/****** Object:  StoredProcedure [dbo].[adml_categoria_delete]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_categoria_delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_categoria_delete]
GO
/****** Object:  StoredProcedure [dbo].[adml_categoria_insert]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_categoria_insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_categoria_insert]
GO
/****** Object:  StoredProcedure [dbo].[adml_categoria_update]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_categoria_update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[adml_categoria_update]
GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CATEGORIA]') AND type in (N'U'))
DROP TABLE [dbo].[CATEGORIA]
GO
/****** Object:  Table [dbo].[COR]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[COR]') AND type in (N'U'))
DROP TABLE [dbo].[COR]
GO
/****** Object:  Table [dbo].[TAMANHO]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAMANHO]') AND type in (N'U'))
DROP TABLE [dbo].[TAMANHO]
GO
/****** Object:  Default [DF_PRODUTOS_CORES_PRODUTO_COR__LIBERADA_VENDA]    Script Date: 12/30/2011 15:53:05 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PRODUTOS_CORES_PRODUTO_COR__LIBERADA_VENDA]') AND parent_object_id = OBJECT_ID(N'[dbo].[MODELO]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PRODUTOS_CORES_PRODUTO_COR__LIBERADA_VENDA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MODELO] DROP CONSTRAINT [DF_PRODUTOS_CORES_PRODUTO_COR__LIBERADA_VENDA]
END


End
GO
/****** Object:  Table [dbo].[TAMANHO]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAMANHO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAMANHO](
	[ID] [int] NOT NULL,
	[NOME] [varchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[WEBVIEW_URL_AMIGAVEL] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_TAMANHOS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[TAMANHO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL]) VALUES (33, N'33', N'tamanho-33')
INSERT [dbo].[TAMANHO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL]) VALUES (34, N'34', N'tamanho-34')
INSERT [dbo].[TAMANHO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL]) VALUES (35, N'35', N'tamanho-35')
INSERT [dbo].[TAMANHO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL]) VALUES (36, N'36', N'tamanho-36')
INSERT [dbo].[TAMANHO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL]) VALUES (37, N'37', N'tamanho-37')
INSERT [dbo].[TAMANHO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL]) VALUES (38, N'38', N'tamanho-38')
INSERT [dbo].[TAMANHO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL]) VALUES (39, N'39', N'tamanho-39')
INSERT [dbo].[TAMANHO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL]) VALUES (40, N'40', N'tamanho-40')
INSERT [dbo].[TAMANHO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL]) VALUES (99, N'Único', N'tamanho-unico')
/****** Object:  Table [dbo].[COR]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[COR]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[COR](
	[ID] [int] NOT NULL,
	[NOME] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[WEBVIEW_URL_AMIGAVEL] [varchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[WEBVIEW_NOMEARQUIVO_AMOSTRA] [varchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_CORES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[COR]') AND name = N'IX_CORES')
CREATE UNIQUE NONCLUSTERED INDEX [IX_CORES] ON [dbo].[COR] 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
GO
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (1, N'Amarelos', N'cores-amarelas', N'cores_amarelos.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (2, N'Azuis', N'cores-azuis', N'cores_azuis.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (3, N'Beges', N'cores-beges', N'cores_beges.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (4, N'Brancos', N'cores-brancas', N'cores_brancos.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (5, N'Caques', N'cores-caques', N'cores-caques.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (6, N'Cinzas', N'cores-cinzas', N'cores-cinzas.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (7, N'Coloridos', N'cores-coloridos', N'cores-coloridos.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (8, N'Dourados', N'cores-douradas', N'cores-dourados.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (9, N'Laranjas', N'cores-laranhas', N'cores-laranhas.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (10, N'Lilás', N'cores-lilases', N'cores_lilases.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (11, N'Marrons', N'cores-marrons', N'cores_marrons.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (12, N'Pratas', N'cores-pratas', N'cores_pratas.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (13, N'Pretos', N'cores-pretos', N'cores_pretos.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (14, N'Rosas', N'cores-rosas', N'cores_rosas.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (15, N'Verdes', N'cores-verdes', N'cores_verdes.gif')
INSERT [dbo].[COR] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_NOMEARQUIVO_AMOSTRA]) VALUES (16, N'Vermelhos', N'cores-vermelhos', N'cores_vermelhos.gif')
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CATEGORIA]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CATEGORIA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[DESCRICAO] [text] COLLATE Latin1_General_CI_AS NULL,
	[WEBVIEW_URL_AMIGAVEL] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[WEBVIEW_DICA] [varchar](255) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[CATEGORIA] ON
INSERT [dbo].[CATEGORIA] ([ID], [NOME], [DESCRICAO], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_DICA]) VALUES (1, N'Anabela', N'Anabela', N'anabela', N'Anabela')
INSERT [dbo].[CATEGORIA] ([ID], [NOME], [DESCRICAO], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_DICA]) VALUES (2, N'Peep Toe', N'Peep Toe', N'peeptoe', N'          ')
INSERT [dbo].[CATEGORIA] ([ID], [NOME], [DESCRICAO], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_DICA]) VALUES (3, N'Scarpin', N'Scarpin', N'scarpin', N'          ')
INSERT [dbo].[CATEGORIA] ([ID], [NOME], [DESCRICAO], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_DICA]) VALUES (4, N'Rasteira', N'Rasteira', N'rasteira', N'          ')
INSERT [dbo].[CATEGORIA] ([ID], [NOME], [DESCRICAO], [WEBVIEW_URL_AMIGAVEL], [WEBVIEW_DICA]) VALUES (5, N'Oxford', N'Oxford', N'oxford', N'          ')
SET IDENTITY_INSERT [dbo].[CATEGORIA] OFF
/****** Object:  StoredProcedure [dbo].[adml_categoria_update]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_categoria_update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Sergio
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_categoria_update] 
	-- Add the parameters for the stored procedure here
	@id int,
	@nome varchar(255), 
	@descricao text,
	@url varchar(255),
	@dica varchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE	dbo.CATEGORIA
	SET		NOME					= @nome,
			DESCRICAO				= @descricao,
			WEBVIEW_URL_AMIGAVEL	= @url,
			WEBVIEW_DICA			= @dica
	WHERE	ID = @id 

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[adml_categoria_insert]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_categoria_insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Sergio
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_categoria_insert] 
	-- Add the parameters for the stored procedure here
	@nome varchar(255), 
	@descricao text,
	@url varchar(255),
	@dica varchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.CATEGORIA(NOME, DESCRICAO, WEBVIEW_URL_AMIGAVEL, WEBVIEW_DICA) 
	VALUES (@nome, @descricao, @url, @dica)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[adml_categoria_delete]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_categoria_delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Sergio
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_categoria_delete]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM	dbo.CATEGORIA
	WHERE	ID = @id 

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_cores]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_cores]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		SLS
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[get_cores] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure 
	
	
	SELECT	C.*
	FROM	dbo.COR C
	ORDER BY NOME	


  END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_cor_por_urlamigavel]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_cor_por_urlamigavel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[get_cor_por_urlamigavel]
  @URLAmigavel varchar(50) 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from dbo.COR WHERE WEBVIEW_URL_AMIGAVEL = @URLAmigavel  order by NOME
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_categorias]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_categorias]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[get_categorias] 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from dbo.CATEGORIA order by NOME
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_categoria_por_urlamigavel]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_categoria_por_urlamigavel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[get_categoria_por_urlamigavel]
  @URLAmigavel varchar(50) 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from dbo.CATEGORIA WHERE WEBVIEW_URL_AMIGAVEL = @URLAmigavel  order by NOME
END
' 
END
GO
/****** Object:  Table [dbo].[PRODUTO]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODUTO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PRODUTO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CATEGORIA__ID] [int] NOT NULL,
	[PRECO_NORMAL] [money] NULL,
	[PRECO_PROMOCIONAL] [money] NULL,
	[PARCELAS_QTDE] [int] NULL,
	[WEBVIEW_DESCRICAO_PRODUTO] [text] COLLATE Latin1_General_CI_AS NULL,
	[ESTA_EM_PROMOCAO] [bit] NULL,
	[REFERENCIA] [varchar](50) COLLATE Latin1_General_CI_AS NULL,
	[FABRICANTE] [varchar](100) COLLATE Latin1_General_CI_AS NULL,
	[NOME] [varchar](255) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_PRODUTOS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[PRODUTO] ON
INSERT [dbo].[PRODUTO] ([ID], [CATEGORIA__ID], [PRECO_NORMAL], [PRECO_PROMOCIONAL], [PARCELAS_QTDE], [WEBVIEW_DESCRICAO_PRODUTO], [ESTA_EM_PROMOCAO], [REFERENCIA], [FABRICANTE], [NOME]) VALUES (2, 2, 99.9000, 0.0000, 3, N'Peep Toe', NULL, NULL, NULL, NULL)
INSERT [dbo].[PRODUTO] ([ID], [CATEGORIA__ID], [PRECO_NORMAL], [PRECO_PROMOCIONAL], [PARCELAS_QTDE], [WEBVIEW_DESCRICAO_PRODUTO], [ESTA_EM_PROMOCAO], [REFERENCIA], [FABRICANTE], [NOME]) VALUES (3, 3, 159.9900, 0.0000, 3, N'<span style="color: #222222; font-family: Arial, Helvetica, sans-serif; font-size: 12px" class="Apple-style-span"><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">Entre os modelos de<span class="Apple-converted-space">&nbsp;</span><a style="text-decoration: none; color: #ff0000; border-style: none; padding: 0px; margin: 0px" href="">calçados femininos</a>, um dos mais versáteis são os<span class="Apple-converted-space">&nbsp;</span><a style="text-decoration: none; color: #ff0000; border-style: none; padding: 0px; margin: 0px" href="">scarpins</a>, que sempre transmitem sofisticação e elegância à mulher.</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">A marca<span class="Apple-converted-space">&nbsp;</span><a style="text-decoration: none; color: #ff0000; border-style: none; padding: 0px; margin: 0px" href="">Ferrette</a>, investiu em lindos modelos de scarpins nessa coleção, são calçados produzidos em couro e cores modernas.</p></span> <br><p>&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px"><strong style="font-weight: bold; border-style: none; padding: 0px; margin: 0px">Salto:</strong>&nbsp;8,0 cm aprox.</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px"><strong style="font-weight: bold; border-style: none; padding: 0px; margin: 0px">Material:</strong>&nbsp;Cabedal confeccionado em couro, com detalhe de costura, atribuindo charme ao scarpin;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">Palmilha em couro, garantinho conforto;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">Salto fachetado;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">&nbsp;</p><p style="font-family: arial, freesans, garuda, helvetica, verdana, sans-serif; font-size: 12px; border-style: none; padding: 0px; margin: 0px">Solado em microduro, garantindo durabilidade e segurança ao caminhar.</p>', 0, N'', N'', N'Scarpin Ferrete')
INSERT [dbo].[PRODUTO] ([ID], [CATEGORIA__ID], [PRECO_NORMAL], [PRECO_PROMOCIONAL], [PARCELAS_QTDE], [WEBVIEW_DESCRICAO_PRODUTO], [ESTA_EM_PROMOCAO], [REFERENCIA], [FABRICANTE], [NOME]) VALUES (4, 4, 79.9000, 69.9000, 3, N'Teste de descrição de <b>produto</b> ', 1, NULL, NULL, NULL)
INSERT [dbo].[PRODUTO] ([ID], [CATEGORIA__ID], [PRECO_NORMAL], [PRECO_PROMOCIONAL], [PARCELAS_QTDE], [WEBVIEW_DESCRICAO_PRODUTO], [ESTA_EM_PROMOCAO], [REFERENCIA], [FABRICANTE], [NOME]) VALUES (22, 5, 3.4500, 0.0000, 6, N'777', 0, N'1', N'2', N'Novo Oxford 1')
SET IDENTITY_INSERT [dbo].[PRODUTO] OFF
/****** Object:  StoredProcedure [dbo].[get_tamanho_por_urlamigavel]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_tamanho_por_urlamigavel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		SLS
-- Create date: 
-- Description:	
-- =============================================
create PROCEDURE [dbo].[get_tamanho_por_urlamigavel] 

	@URLAmigavel varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure 
	
	SELECT	T.ID, T.NOME, T.WEBVIEW_URL_AMIGAVEL
	FROM	dbo.TAMANHO T
	WHERE	WEBVIEW_URL_AMIGAVEL = @URLAmigavel


  END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[adml_get_produtos]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_get_produtos]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_get_produtos]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT	P.*, C.NOME AS CATEGORIA_NOME
	FROM	dbo.PRODUTO P,
			dbo.CATEGORIA C
	WHERE	P.CATEGORIA__ID = C.ID
	ORDER BY C.NOME, P.NOME	
END
' 
END
GO
/****** Object:  Table [dbo].[MODELO]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MODELO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MODELO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[WEBVIEW_URL_AMIGAVEL] [varchar](255) COLLATE Latin1_General_CI_AS NULL,
	[LIBERADO_PARA_VENDA] [char](1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PRODUTO__ID] [int] NOT NULL,
	[COR__ID] [int] NULL,
 CONSTRAINT [PK_PRODUTOS_CORES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[MODELO] ON
INSERT [dbo].[MODELO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [LIBERADO_PARA_VENDA], [PRODUTO__ID], [COR__ID]) VALUES (4, N'Peep Toe Meia-Pata Bege', N'peeptoe-meiapata', N'S', 2, 3)
INSERT [dbo].[MODELO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [LIBERADO_PARA_VENDA], [PRODUTO__ID], [COR__ID]) VALUES (5, N'Peep Toe Meia-Pata Vermelho', N'peeptoe_meiapata-vermelho', N'S', 2, 16)
INSERT [dbo].[MODELO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [LIBERADO_PARA_VENDA], [PRODUTO__ID], [COR__ID]) VALUES (6, N'Scarpin Ferrete Branco', N'scarpin-ferrete-branco', N'S', 3, 4)
INSERT [dbo].[MODELO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [LIBERADO_PARA_VENDA], [PRODUTO__ID], [COR__ID]) VALUES (8, N'Chinelo Werner Preto', N'chinelo-werner-preto', N'S', 4, 13)
INSERT [dbo].[MODELO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [LIBERADO_PARA_VENDA], [PRODUTO__ID], [COR__ID]) VALUES (19, N'Teste de gravação 22222', N'teste-de-gravação-22222', N'S', 3, 1)
INSERT [dbo].[MODELO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [LIBERADO_PARA_VENDA], [PRODUTO__ID], [COR__ID]) VALUES (20, N' 33333', N'-33333', N'S', 3, 1)
INSERT [dbo].[MODELO] ([ID], [NOME], [WEBVIEW_URL_AMIGAVEL], [LIBERADO_PARA_VENDA], [PRODUTO__ID], [COR__ID]) VALUES (23, N'Scarpin Ferrete Branco', N'scarpin-ferrete-branco', N'S', 3, 4)
SET IDENTITY_INSERT [dbo].[MODELO] OFF
/****** Object:  StoredProcedure [dbo].[adml_produto_update]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_produto_update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_produto_update] 
	-- Add the parameters for the stored procedure here
	@id int,
	@categoria__id int, 
	@nome varchar(255),
	@preco_normal money,
	@qtde_parcelas int,
	@esta_em_promocao bit,
	@preco_promocional money,
	@referencia varchar(50),
	@fabricante varchar(100),
	@descricao_html text
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE dbo.PRODUTO SET
						CATEGORIA__ID = @categoria__id,
						PRECO_NORMAL = @preco_normal,
						PRECO_PROMOCIONAL = @preco_promocional,
						PARCELAS_QTDE = @qtde_parcelas,
						WEBVIEW_DESCRICAO_PRODUTO = @descricao_html,
						ESTA_EM_PROMOCAO = @esta_em_promocao,
						REFERENCIA = @referencia,
						FABRICANTE = @fabricante,
						NOME = @nome
	WHERE	ID = @id
		
						
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[adml_produto_insert]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_produto_insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_produto_insert] 
	-- Add the parameters for the stored procedure here
	@id int = 0 OUTPUT, 
	@categoria__id int, 
	@nome varchar(255),
	@preco_normal money,
	@qtde_parcelas int,
	@esta_em_promocao bit,
	@preco_promocional money,
	@referencia varchar(50),
	@fabricante varchar(100),
	@descricao_html text
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.PRODUTO(
						CATEGORIA__ID,
						PRECO_NORMAL,
						PRECO_PROMOCIONAL,
						PARCELAS_QTDE,
						WEBVIEW_DESCRICAO_PRODUTO,
						ESTA_EM_PROMOCAO,
						REFERENCIA,
						FABRICANTE,
						NOME)
	VALUES ( 
						@categoria__id,
						@preco_normal,
						@preco_promocional,
						@qtde_parcelas,
						@descricao_html,
						@esta_em_promocao,
						@referencia,
						@fabricante,
						@nome)
						
	SELECT @id = SCOPE_IDENTITY() 						
						
						
END
' 
END
GO
/****** Object:  Table [dbo].[ESTOQUE]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ESTOQUE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ESTOQUE](
	[MODELO__ID] [int] NOT NULL,
	[TAMANHO__ID] [int] NOT NULL,
	[QTDE_DISPONIVEL_VENDA] [int] NOT NULL,
 CONSTRAINT [PK_PRODUTOS_CORES_TAMANHOS_1] PRIMARY KEY CLUSTERED 
(
	[MODELO__ID] ASC,
	[TAMANHO__ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (4, 34, 10)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (4, 35, 10)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (4, 36, 10)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (4, 37, 10)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (5, 34, 6)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (5, 35, 7)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (6, 33, 10)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (8, 34, 20)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (8, 35, 20)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (8, 36, 20)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (8, 37, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (19, 33, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (19, 34, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (19, 35, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (19, 36, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (19, 37, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (19, 38, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (19, 39, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (19, 40, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (20, 33, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (20, 34, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (20, 35, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (20, 36, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (20, 37, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (20, 38, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (20, 39, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (20, 40, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (23, 33, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (23, 34, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (23, 35, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (23, 36, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (23, 37, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (23, 38, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (23, 39, 0)
INSERT [dbo].[ESTOQUE] ([MODELO__ID], [TAMANHO__ID], [QTDE_DISPONIVEL_VENDA]) VALUES (23, 40, 0)
/****** Object:  StoredProcedure [dbo].[adml_get_modelos_de_produto]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_get_modelos_de_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_get_modelos_de_produto] 
	-- Add the parameters for the stored procedure here
	@produto__id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT	M.*, C.NOME AS COR__NOME
	FROM	MODELO M,
			PRODUTO P,
			COR C
	WHERE	M.PRODUTO__ID = P.ID
	AND		M.COR__ID = C.ID
	AND		M.PRODUTO__ID = @produto__id
	ORDER	BY M.NOME
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_outro_modelos_mesmo_produto]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_outro_modelos_mesmo_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[get_outro_modelos_mesmo_produto]
	@modelo_id int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT	ID
	FROM	dbo.MODELO
	WHERE	PRODUTO__ID = (SELECT PRODUTO__ID FROM dbo.MODELO WHERE ID = @modelo_id)
			AND ID <> @modelo_id
			
    

END
' 
END
GO
/****** Object:  Table [dbo].[IMAGEM_MODELO]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IMAGEM_MODELO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[IMAGEM_MODELO](
	[MODELO__ID] [int] NOT NULL,
	[PERSPECTIVA] [int] NOT NULL,
	[NOMEARQUIVO] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[TAMANHO] [char](1) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_IMAGEM_MODELO_1] PRIMARY KEY CLUSTERED 
(
	[MODELO__ID] ASC,
	[PERSPECTIVA] ASC,
	[TAMANHO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (4, 1, N'scarpin-feminino-ferrette-branco-site_produtos-1792023476_pequena.jpg', N'P')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (5, 1, N'scarpin-anzetutto-vermelho-site_produtos-1836894479_pequena.jpg', N'P')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (6, 1, N'scarpin-feminino-ferrette-branco-site_produtos-1459211714.jpg', N'G')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (6, 1, N'scarpin-feminino-ferrette-branco-site_produtos-1459211714_media.jpg', N'M')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (6, 1, N'scarpin-feminino-ferrette-branco-site_produtos-1459211714_pequena.jpg', N'P')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (6, 2, N'scarpin-feminino-ferrette-branco-site_produtos-1792023476.jpg', N'G')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (6, 2, N'scarpin-feminino-ferrette-branco-site_produtos-1792023476_media.jpg', N'M')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (6, 2, N'scarpin-feminino-ferrette-branco-site_produtos-1792023476_pequena.jpg', N'P')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (6, 3, N'scarpin-feminino-ferrette-branco-site_produtos-1627510854.jpg', N'G')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (6, 3, N'scarpin-feminino-ferrette-branco-site_produtos-1627510854_media.jpg', N'M')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (6, 3, N'scarpin-feminino-ferrette-branco-site_produtos-1627510854_pequena.jpg', N'P')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (6, 4, N'scarpin-feminino-ferrette-branco-site_produtos-214482278.jpg', N'G')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (6, 4, N'scarpin-feminino-ferrette-branco-site_produtos-214482278_media.jpg', N'M')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (6, 4, N'scarpin-feminino-ferrette-branco-site_produtos-214482278_pequena.jpg', N'P')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (8, 1, N'chinelo-feminino-werner-preto-site_produtos-1088044656.jpg', N'G')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (8, 1, N'chinelo-feminino-werner-preto-site_produtos-1088044656_media.jpg', N'M')
INSERT [dbo].[IMAGEM_MODELO] ([MODELO__ID], [PERSPECTIVA], [NOMEARQUIVO], [TAMANHO]) VALUES (8, 1, N'chinelo-feminino-werner-preto-site_produtos-1088044656_pequena.jpg', N'P')
/****** Object:  StoredProcedure [dbo].[get_produtos_liberadosparavenda_categoriaunica_corunica]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_produtos_liberadosparavenda_categoriaunica_corunica]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[get_produtos_liberadosparavenda_categoriaunica_corunica]
	-- Add the parameters for the stored procedure here
	@CATEGORIA__ID int = 0,
	@COR__WEBVIEW_URL_AMIGAVEL varchar(50) = ''''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT	M.ID
	FROM	dbo.PRODUTO P, 
			dbo.MODELO M, 
			dbo.COR C
	WHERE	P.ID = M.PRODUTO__ID
	AND		M.COR__ID = C.ID
	AND		P.CATEGORIA__ID = @CATEGORIA__ID	
	AND		M.LIBERADO_PARA_VENDA = ''S''	
	AND		C.WEBVIEW_URL_AMIGAVEL = @COR__WEBVIEW_URL_AMIGAVEL
	
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_produtos_liberadosparavenda_categoriaunica]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_produtos_liberadosparavenda_categoriaunica]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[get_produtos_liberadosparavenda_categoriaunica] 
	-- Add the parameters for the stored procedure here
	@CATEGORIA__ID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT	M.ID
	FROM	dbo.PRODUTO P, dbo.MODELO M
	WHERE	M.PRODUTO__ID = P.ID 
	AND		M.LIBERADO_PARA_VENDA = ''S''
	AND		P.CATEGORIA__ID = @CATEGORIA__ID
	
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico_corunica]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico_corunica]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico_corunica]
	-- Add the parameters for the stored procedure here
	@CATEGORIA__ID int = 0,
	@TAMANHO__WEBVIEW_URL_AMIGAVEL varchar(50) = '''',
	@COR__WEBVIEW_URL_AMIGAVEL varchar(50) = ''''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT	M.ID
	FROM	dbo.PRODUTO P, 
			dbo.MODELO M, 
			dbo.ESTOQUE E,
			dbo.TAMANHO T,
			dbo.COR C
	WHERE	P.ID = M.PRODUTO__ID
	AND		M.ID = E.MODELO__ID
	AND		E.TAMANHO__ID = T.ID
	AND		M.COR__ID = C.ID	
	AND		P.CATEGORIA__ID = @CATEGORIA__ID	
	AND		M.LIBERADO_PARA_VENDA = ''S''	
	AND		T.WEBVIEW_URL_AMIGAVEL = @TAMANHO__WEBVIEW_URL_AMIGAVEL	
	AND		C.WEBVIEW_URL_AMIGAVEL = @COR__WEBVIEW_URL_AMIGAVEL
	
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico]
	-- Add the parameters for the stored procedure here
	@CATEGORIA__ID int = 0,
	@TAMANHO__WEBVIEW_URL_AMIGAVEL varchar(50) = ''''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	SELECT	M.ID
	FROM	dbo.PRODUTO P, 
			dbo.MODELO M, 
			dbo.ESTOQUE E,
			dbo.TAMANHO T
	WHERE	P.ID = M.PRODUTO__ID
	AND		M.ID = E.MODELO__ID
	AND		E.TAMANHO__ID = T.ID	
	AND		P.CATEGORIA__ID = @CATEGORIA__ID	
	AND		M.LIBERADO_PARA_VENDA = ''S''	
	AND		T.WEBVIEW_URL_AMIGAVEL = @TAMANHO__WEBVIEW_URL_AMIGAVEL

	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_perspectivas_imagens_modelo]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_perspectivas_imagens_modelo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[get_perspectivas_imagens_modelo]
	@modelo_id int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT	DISTINCT PERSPECTIVA
    FROM	dbo.IMAGEM_MODELO IM
	WHERE	IM.MODELO__ID = @modelo_id
			
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[adml_get_perspectivas_modelo]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_get_perspectivas_modelo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_get_perspectivas_modelo] 
	-- Add the parameters for the stored procedure here
	@modelo__id int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT	DISTINCT M.MODELO__ID, M.PERSPECTIVA 
	FROM	IMAGEM_MODELO M
	WHERE	M.MODELO__ID = @modelo__id
	ORDER BY M.PERSPECTIVA
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_tamanhosdisponiveis]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_tamanhosdisponiveis]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		SLS
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[get_tamanhosdisponiveis] 
	-- Add the parameters for the stored procedure here
	@MODELO__ID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure 
	
	SELECT	E.TAMANHO__ID, M.NOME, T.WEBVIEW_URL_AMIGAVEL
	FROM	dbo.MODELO M,
			dbo.ESTOQUE E,
			dbo.TAMANHO T
	WHERE	M.ID = @MODELO__ID
	AND     E.MODELO__ID = M.ID
	AND		E.TAMANHO__ID = T.ID
	AND		E.QTDE_DISPONIVEL_VENDA > 0


  END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_modelo]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_modelo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[get_modelo]
	@modelo_id int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT	P.PRECO_NORMAL, P.PRECO_PROMOCIONAL, P.PARCELAS_QTDE, 
			M.WEBVIEW_URL_AMIGAVEL, M.NOME, C.ID, 
			C.WEBVIEW_NOMEARQUIVO_AMOSTRA, IM.NOMEARQUIVO,
			P.WEBVIEW_DESCRICAO_PRODUTO
    FROM	dbo.MODELO M,
			dbo.PRODUTO P,
			dbo.COR C,
			dbo.IMAGEM_MODELO IM
	WHERE	M.PRODUTO__ID = P.ID
	AND		M.COR__ID = C.ID
	AND		M.ID = IM.MODELO__ID
	AND		M.ID = @modelo_id
	AND		(iM.PERSPECTIVA = 1 AND iM.TAMANHO = ''P'')
			
    

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_imagens_modelo]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_imagens_modelo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[get_imagens_modelo]
	@modelo_id int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT	*
    FROM	dbo.IMAGEM_MODELO IM
	WHERE	IM.MODELO__ID = @modelo_id
	ORDER BY PERSPECTIVA, TAMANHO
			
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[get_coresdisponiveis]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_coresdisponiveis]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		SLS
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[get_coresdisponiveis] 
	-- Add the parameters for the stored procedure here
	@MODELO__ID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure 
	
	
	SELECT	DISTINCT C.*
	FROM	dbo.MODELO M,
			dbo.COR C,
			dbo.ESTOQUE E
	WHERE	M.ID = @MODELO__ID
	AND		M.COR__ID = C.ID
	AND		M.ID = E.MODELO__ID
	AND		E.QTDE_DISPONIVEL_VENDA > 0
	


  END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[adml_get_imagens_de_perspectiva_modelo]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_get_imagens_de_perspectiva_modelo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_get_imagens_de_perspectiva_modelo] 
	-- Add the parameters for the stored procedure here
	@modelo__id int = 0,
	@perspectiva int = 0 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT	DISTINCT M.MODELO__ID, M.PERSPECTIVA, M.NOMEARQUIVO, M.TAMANHO
	FROM	IMAGEM_MODELO M
	WHERE	M.MODELO__ID = @modelo__id
	AND		M.PERSPECTIVA = @perspectiva
	ORDER BY M.TAMANHO
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[adml_produto_delete]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_produto_delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		adml_modelo_insert
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_produto_delete] 
	-- Add the parameters for the stored procedure here
	@PRODUTO_ID int		
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM IMAGEM_MODELO WHERE MODELO__ID IN (SELECT	M.ID FROM	MODELO M WHERE	PRODUTO__ID = @PRODUTO_ID)

	DELETE FROM ESTOQUE WHERE MODELO__ID IN (SELECT	M.ID FROM	MODELO M WHERE	PRODUTO__ID = @PRODUTO_ID)

	DELETE FROM MODELO WHERE ID IN (SELECT	M.ID FROM	MODELO M WHERE	PRODUTO__ID = @PRODUTO_ID)
	
	DELETE FROM PRODUTO WHERE ID = @PRODUTO_ID
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[adml_modelo_update]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_modelo_update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		adml_modelo_insert
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_modelo_update] 
	-- Add the parameters for the stored procedure here
	@ID int = 0 OUTPUT, 
	@NOME varchar(255),
	@WEBVIEW_URL_AMIGAVEL varchar(255),
	@LIBERADO_PARA_VENDA char(1),
	@PRODUTO__ID int,
	@COR__ID int,
	@ESTOQUE33 int = 0,
	@ESTOQUE34 int = 0,	
	@ESTOQUE35 int = 0,
	@ESTOQUE36 int = 0,
	@ESTOQUE37 int = 0,
	@ESTOQUE38 int = 0,
	@ESTOQUE39 int = 0,
	@ESTOQUE40 int = 0
		
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE MODELO SET
		NOME = @NOME, 
		WEBVIEW_URL_AMIGAVEL = @WEBVIEW_URL_AMIGAVEL, 
		LIBERADO_PARA_VENDA = @LIBERADO_PARA_VENDA, 
		PRODUTO__ID = @PRODUTO__ID, 
		COR__ID= @COR__ID
	WHERE ID = @ID
	
	--Grava o estoque
	UPDATE ESTOQUE SET QTDE_DISPONIVEL_VENDA = @ESTOQUE33 WHERE MODELO__ID = @ID AND TAMANHO__ID = 33
	UPDATE ESTOQUE SET QTDE_DISPONIVEL_VENDA = @ESTOQUE34 WHERE MODELO__ID = @ID AND TAMANHO__ID = 34
	UPDATE ESTOQUE SET QTDE_DISPONIVEL_VENDA = @ESTOQUE35 WHERE MODELO__ID = @ID AND TAMANHO__ID = 35 
	UPDATE ESTOQUE SET QTDE_DISPONIVEL_VENDA = @ESTOQUE36 WHERE MODELO__ID = @ID AND TAMANHO__ID = 36 
	UPDATE ESTOQUE SET QTDE_DISPONIVEL_VENDA = @ESTOQUE37 WHERE MODELO__ID = @ID AND TAMANHO__ID = 37 
	UPDATE ESTOQUE SET QTDE_DISPONIVEL_VENDA = @ESTOQUE38 WHERE MODELO__ID = @ID AND TAMANHO__ID = 38
	UPDATE ESTOQUE SET QTDE_DISPONIVEL_VENDA = @ESTOQUE39 WHERE MODELO__ID = @ID AND TAMANHO__ID = 39 
	UPDATE ESTOQUE SET QTDE_DISPONIVEL_VENDA = @ESTOQUE40 WHERE MODELO__ID = @ID AND TAMANHO__ID = 40 

			
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[adml_modelo_insert]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_modelo_insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		adml_modelo_insert
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_modelo_insert] 
	-- Add the parameters for the stored procedure here
	@ID int = 0 OUTPUT, 
	@NOME varchar(255),
	@WEBVIEW_URL_AMIGAVEL varchar(255),
	@LIBERADO_PARA_VENDA char(1),
	@PRODUTO__ID int,
	@COR__ID int,
	@ESTOQUE33 int = 0,
	@ESTOQUE34 int = 0,	
	@ESTOQUE35 int = 0,
	@ESTOQUE36 int = 0,
	@ESTOQUE37 int = 0,
	@ESTOQUE38 int = 0,
	@ESTOQUE39 int = 0,
	@ESTOQUE40 int = 0
		
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO MODELO(
	NOME, 
	WEBVIEW_URL_AMIGAVEL, 
	LIBERADO_PARA_VENDA, 
	PRODUTO__ID, 
	COR__ID)
	
	VALUES(
	@NOME, 
	@WEBVIEW_URL_AMIGAVEL, 
	@LIBERADO_PARA_VENDA, 
	@PRODUTO__ID, 
	@COR__ID)
	
	SELECT @ID = SCOPE_IDENTITY() 
	
	--Grava o estoque
	INSERT INTO ESTOQUE(MODELO__ID, TAMANHO__ID, QTDE_DISPONIVEL_VENDA) VALUES(@ID, 33, @ESTOQUE33)
	INSERT INTO ESTOQUE(MODELO__ID, TAMANHO__ID, QTDE_DISPONIVEL_VENDA) VALUES(@ID, 34, @ESTOQUE34)
	INSERT INTO ESTOQUE(MODELO__ID, TAMANHO__ID, QTDE_DISPONIVEL_VENDA) VALUES(@ID, 35, @ESTOQUE35)
	INSERT INTO ESTOQUE(MODELO__ID, TAMANHO__ID, QTDE_DISPONIVEL_VENDA) VALUES(@ID, 36, @ESTOQUE36)
	INSERT INTO ESTOQUE(MODELO__ID, TAMANHO__ID, QTDE_DISPONIVEL_VENDA) VALUES(@ID, 37, @ESTOQUE37)
	INSERT INTO ESTOQUE(MODELO__ID, TAMANHO__ID, QTDE_DISPONIVEL_VENDA) VALUES(@ID, 38, @ESTOQUE38)
	INSERT INTO ESTOQUE(MODELO__ID, TAMANHO__ID, QTDE_DISPONIVEL_VENDA) VALUES(@ID, 39, @ESTOQUE39)
	INSERT INTO ESTOQUE(MODELO__ID, TAMANHO__ID, QTDE_DISPONIVEL_VENDA) VALUES(@ID, 40, @ESTOQUE40)

			
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[adml_modelo_delete]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_modelo_delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		adml_modelo_insert
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_modelo_delete] 
	-- Add the parameters for the stored procedure here
	@MODELO_ID int		
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM IMAGEM_MODELO WHERE MODELO__ID = @MODELO_ID

	DELETE FROM ESTOQUE WHERE MODELO__ID = @MODELO_ID

	DELETE FROM MODELO WHERE ID = @MODELO_ID
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[adml_imagem_update]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_imagem_update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		adml_imagem_insert
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_imagem_update] 
	-- Add the parameters for the stored procedure here
	@MODELO__ID int, 
	@PERSPECTIVA int = 0,
	@NOMEARQUIVO varchar(255),
	@TAMANHO char(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE  dbo.IMAGEM_MODELO SET
			NOMEARQUIVO = @NOMEARQUIVO
	WHERE	MODELO__ID = @MODELO__ID
	AND		PERSPECTIVA = @PERSPECTIVA
	AND		TAMANHO = @TAMANHO

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[adml_imagem_insert]    Script Date: 12/30/2011 15:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[adml_imagem_insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		adml_imagem_insert
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[adml_imagem_insert] 
	-- Add the parameters for the stored procedure here
	@MODELO__ID int = 0, 
	@PERSPECTIVA int = 0,
	@NOMEARQUIVO varchar(255),
	@TAMANHO char(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.IMAGEM_MODELO(
		MODELO__ID,
		PERSPECTIVA,
		NOMEARQUIVO,
		TAMANHO)
	VALUES( 
		@MODELO__ID,
		@PERSPECTIVA,
		@NOMEARQUIVO,
		@TAMANHO)	
END
' 
END
GO
/****** Object:  Default [DF_PRODUTOS_CORES_PRODUTO_COR__LIBERADA_VENDA]    Script Date: 12/30/2011 15:53:05 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PRODUTOS_CORES_PRODUTO_COR__LIBERADA_VENDA]') AND parent_object_id = OBJECT_ID(N'[dbo].[MODELO]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PRODUTOS_CORES_PRODUTO_COR__LIBERADA_VENDA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MODELO] ADD  CONSTRAINT [DF_PRODUTOS_CORES_PRODUTO_COR__LIBERADA_VENDA]  DEFAULT ('N') FOR [LIBERADO_PARA_VENDA]
END


End
GO
/****** Object:  ForeignKey [FK_PRODUTOS_CORES_TAMANHOS_PRODUTOS_CORES]    Script Date: 12/30/2011 15:53:05 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_TAMANHOS_PRODUTOS_CORES]') AND parent_object_id = OBJECT_ID(N'[dbo].[ESTOQUE]'))
ALTER TABLE [dbo].[ESTOQUE]  WITH CHECK ADD  CONSTRAINT [FK_PRODUTOS_CORES_TAMANHOS_PRODUTOS_CORES] FOREIGN KEY([MODELO__ID])
REFERENCES [dbo].[MODELO] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_TAMANHOS_PRODUTOS_CORES]') AND parent_object_id = OBJECT_ID(N'[dbo].[ESTOQUE]'))
ALTER TABLE [dbo].[ESTOQUE] CHECK CONSTRAINT [FK_PRODUTOS_CORES_TAMANHOS_PRODUTOS_CORES]
GO
/****** Object:  ForeignKey [FK_PRODUTOS_CORES_TAMANHOS_TAMANHOS]    Script Date: 12/30/2011 15:53:05 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_TAMANHOS_TAMANHOS]') AND parent_object_id = OBJECT_ID(N'[dbo].[ESTOQUE]'))
ALTER TABLE [dbo].[ESTOQUE]  WITH CHECK ADD  CONSTRAINT [FK_PRODUTOS_CORES_TAMANHOS_TAMANHOS] FOREIGN KEY([TAMANHO__ID])
REFERENCES [dbo].[TAMANHO] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_TAMANHOS_TAMANHOS]') AND parent_object_id = OBJECT_ID(N'[dbo].[ESTOQUE]'))
ALTER TABLE [dbo].[ESTOQUE] CHECK CONSTRAINT [FK_PRODUTOS_CORES_TAMANHOS_TAMANHOS]
GO
/****** Object:  ForeignKey [FK_PRODUTOS_CORES_IMAGENS_PRODUTOS_CORES]    Script Date: 12/30/2011 15:53:05 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_IMAGENS_PRODUTOS_CORES]') AND parent_object_id = OBJECT_ID(N'[dbo].[IMAGEM_MODELO]'))
ALTER TABLE [dbo].[IMAGEM_MODELO]  WITH CHECK ADD  CONSTRAINT [FK_PRODUTOS_CORES_IMAGENS_PRODUTOS_CORES] FOREIGN KEY([MODELO__ID])
REFERENCES [dbo].[MODELO] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_IMAGENS_PRODUTOS_CORES]') AND parent_object_id = OBJECT_ID(N'[dbo].[IMAGEM_MODELO]'))
ALTER TABLE [dbo].[IMAGEM_MODELO] CHECK CONSTRAINT [FK_PRODUTOS_CORES_IMAGENS_PRODUTOS_CORES]
GO
/****** Object:  ForeignKey [FK_PRODUTOS_CORES_CORES1]    Script Date: 12/30/2011 15:53:05 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_CORES1]') AND parent_object_id = OBJECT_ID(N'[dbo].[MODELO]'))
ALTER TABLE [dbo].[MODELO]  WITH CHECK ADD  CONSTRAINT [FK_PRODUTOS_CORES_CORES1] FOREIGN KEY([COR__ID])
REFERENCES [dbo].[COR] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_CORES1]') AND parent_object_id = OBJECT_ID(N'[dbo].[MODELO]'))
ALTER TABLE [dbo].[MODELO] CHECK CONSTRAINT [FK_PRODUTOS_CORES_CORES1]
GO
/****** Object:  ForeignKey [FK_PRODUTOS_CORES_PRODUTOS1]    Script Date: 12/30/2011 15:53:05 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_PRODUTOS1]') AND parent_object_id = OBJECT_ID(N'[dbo].[MODELO]'))
ALTER TABLE [dbo].[MODELO]  WITH CHECK ADD  CONSTRAINT [FK_PRODUTOS_CORES_PRODUTOS1] FOREIGN KEY([PRODUTO__ID])
REFERENCES [dbo].[PRODUTO] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CORES_PRODUTOS1]') AND parent_object_id = OBJECT_ID(N'[dbo].[MODELO]'))
ALTER TABLE [dbo].[MODELO] CHECK CONSTRAINT [FK_PRODUTOS_CORES_PRODUTOS1]
GO
/****** Object:  ForeignKey [FK_PRODUTOS_CATEGORIAS]    Script Date: 12/30/2011 15:53:05 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CATEGORIAS]') AND parent_object_id = OBJECT_ID(N'[dbo].[PRODUTO]'))
ALTER TABLE [dbo].[PRODUTO]  WITH CHECK ADD  CONSTRAINT [FK_PRODUTOS_CATEGORIAS] FOREIGN KEY([CATEGORIA__ID])
REFERENCES [dbo].[CATEGORIA] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTOS_CATEGORIAS]') AND parent_object_id = OBJECT_ID(N'[dbo].[PRODUTO]'))
ALTER TABLE [dbo].[PRODUTO] CHECK CONSTRAINT [FK_PRODUTOS_CATEGORIAS]
GO
