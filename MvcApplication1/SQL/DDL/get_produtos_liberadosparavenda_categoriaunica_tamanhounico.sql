USE [DLC1]
GO
/****** Object:  StoredProcedure [dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico]    Script Date: 12/01/2011 01:17:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
ALTER PROCEDURE [dbo].[get_produtos_liberadosparavenda_categoriaunica_tamanhounico]
	-- Add the parameters for the stored procedure here
	@CATEGORIA__ID int = 0,
	@TAMANHO__WEBVIEW_URL_AMIGAVEL varchar(50) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT	PC.PRODUTO_COR__ID
	FROM	dbo.PRODUTOS P, 
			dbo.PRODUTOS_CORES PC, 
			dbo.PRODUTOS_CORES_TAMANHOS PCT,
			dbo.TAMANHOS T
	WHERE	PC.PRODUTO_COR__LIBERADA_VENDA = 'S'
	AND		PC.PRODUTO_COR__ID = PCT.PRODUTO_COR__ID
	AND		PCT.TAMANHO__ID = T.TAMANHO__ID
	AND		P.CATEGORIA__ID = @CATEGORIA__ID
	AND		T.TAMANHO__WEBVIEW_URL_AMIGAVEL = @TAMANHO__WEBVIEW_URL_AMIGAVEL
	
	
END
