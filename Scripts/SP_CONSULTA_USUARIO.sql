

USE Examen_Coppel
IF OBJECT_ID('dbo.SP_CONSULTA_USUARIO', 'P') IS NOT NULL
	DROP PROCEDURE dbo.SP_CONSULTA_USUARIO
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
CREATE PROCEDURE SP_CONSULTA_USUARIO
	@USUARIO VARCHAR(50)
AS
BEGIN

	SET NOCOUNT ON;

	SELECT * FROM USUARIOS WHERE USUARIO_NOMBRE LIKE '%' + @USUARIO + '%'
END
GO