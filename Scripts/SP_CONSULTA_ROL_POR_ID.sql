
USE Examen_Coppel
IF OBJECT_ID('dbo.SP_CONSULTA_ROL_POR_ID', 'P') IS NOT NULL
	DROP PROCEDURE dbo.SP_CONSULTA_ROL_POR_ID
GO
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JESUS MANUEL LOPEZ BARRIOS
-- Create date: 07/05/2023
-- Description:	CONSULTA DE ROL POR ID.
-- =============================================
CREATE PROCEDURE SP_CONSULTA_ROL_POR_ID
	@ID INT
AS
BEGIN

	SET NOCOUNT ON;

	SELECT * FROM ROLES WHERE ID = @ID
END
GO
