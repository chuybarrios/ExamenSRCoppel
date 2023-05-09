
USE Examen_Coppel
IF OBJECT_ID('dbo.SP_CONSULTA_ROLES', 'P') IS NOT NULL
	DROP PROCEDURE dbo.SP_CONSULTA_ROLES
GO
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JESUS MANUEL LOPEZ BARRIOS
-- Create date: 07/05/2023
-- Description:	CONSULTA DE ROLES
-- =============================================
CREATE PROCEDURE SP_CONSULTA_ROLES
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM ROLES
END
GO