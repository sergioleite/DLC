USE [DLC1]
GO
/****** Object:  StoredProcedure [dbo].[get_produtos_liberadosparavenda_categoriaunica]    Script Date: 12/01/2011 01:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
ALTER PROCEDURE [dbo].[get_produtos_liberadosparavenda_categoriaunica] 
	-- Add the parameters for the stored procedure here
	@CATEGORIA__ID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT	PC.PRODUTO_COR__ID
	FROM	dbo.PRODUTOS P, dbo.PRODUTOS_CORES PC
	WHERE	PC.PRODUTO_COR__LIBERADA_VENDA = 'S'
	AND		P.CATEGORIA__ID = @CATEGORIA__ID
	
	
END
