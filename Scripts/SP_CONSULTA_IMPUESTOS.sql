
USE Examen_Coppel
IF OBJECT_ID('dbo.SP_CONSULTA_IMPUESTOS', 'P') IS NOT NULL
	DROP PROCEDURE dbo.SP_CONSULTA_IMPUESTOS
GO
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JESUS MANUEL LOPEZ BARRIOS
-- Create date: 07/05/2023
-- Description:	CONSULTA LOS IMPUESTOS.
-- =============================================
CREATE PROCEDURE SP_CONSULTA_IMPUESTOS
AS
BEGIN

	SET NOCOUNT ON;

	SELECT TOP 1 * FROM IMPUESTOS
END
GO