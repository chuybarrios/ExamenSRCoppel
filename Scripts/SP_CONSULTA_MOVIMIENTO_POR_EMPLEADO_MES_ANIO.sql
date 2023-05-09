
USE Examen_Coppel
IF OBJECT_ID('dbo.SP_CONSULTA_MOVIMIENTO_POR_EMPLEADO_MES_ANIO', 'P') IS NOT NULL
	DROP PROCEDURE dbo.SP_CONSULTA_MOVIMIENTO_POR_EMPLEADO_MES_ANIO
GO
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JESUS MANUEL LOPEZ BARRIOS
-- Create date: 07/05/2023
-- Description:	CONSULTA DEL ID MOVIMEINTOS POR EMPLEADO, MES Y A�O.
-- =============================================
CREATE PROCEDURE SP_CONSULTA_MOVIMIENTO_POR_EMPLEADO_MES_ANIO
	@ID_EMPLEADO INT,
	@MES INT,
	@YEAR INT
AS
BEGIN

	SET NOCOUNT ON;

	SELECT ID FROM MOVIMIENTOS WHERE ID_EMPLEADO = @ID_EMPLEADO AND MES_MOVIMIENTO = @MES AND YEAR_MOVIMIENTO = @YEAR
END
GO
