
USE Examen_Coppel
IF OBJECT_ID('dbo.SP_GUARDAR_PAGOS', 'P') IS NOT NULL
	DROP PROCEDURE dbo.SP_GUARDAR_PAGOS
GO
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JESUS MANUEL LOPEZ BARRIOS
-- Create date: 07/05/2023
-- Description:	PROCEDIMIENTO PARA GUARDAR EL PAGO DE LOS EMPLEADOS EN EL MES.
-- =============================================
CREATE PROCEDURE SP_GUARDAR_PAGOS

	@ID_EMPLEADO INT,
	@ID_ROL INT,
	@MES INT,
	@YEAR INT,
	@SALARIO_BRUTO DECIMAL(18,2),
	@TOTAL_BONUS_POR_ENTREGA DECIMAL(18,2),
	@TOTAL_BONUS_POR_HORA DECIMAL(18,2),
	@SUBTOTAL DECIMAL(18,2),
	@TOTAL_ISR DECIMAL(18,2),
	@TOTAL_ISR_ADICIONAL DECIMAL(18,2),
	@INGRESOS_NETOS DECIMAL(18,2),
	@TOTAL_VALES_DESPENSA DECIMAL(18,2),
	@PAGO_NETO DECIMAL(18,2)
AS
BEGIN

	SET NOCOUNT ON;

	BEGIN TRY
		INSERT INTO PAGOS(ID_EMPLEADO, ID_ROL, PAGO_DEL_MES, PAGO_DEL_YEAR, SALARIO_BRUTO, TOTAL_BONUS_POR_ENTREGA, TOTAL_BONUS_POR_HORA, SUBTOTAL, TOTAL_ISR, TOTAL_ISR_ADICIONAL, INGRESOS_NETOS, TOTAL_VALES_DESPENSA, PAGO_NETO)
		VALUES (@ID_EMPLEADO, @ID_ROL, @MES, @YEAR, @SALARIO_BRUTO, @TOTAL_BONUS_POR_ENTREGA, @TOTAL_BONUS_POR_HORA, @SUBTOTAL, @TOTAL_ISR, @TOTAL_ISR_ADICIONAL, @INGRESOS_NETOS, @TOTAL_VALES_DESPENSA, @PAGO_NETO)

		RETURN 1
	END TRY
	BEGIN CATCH
		RETURN 0
	END CATCH
END
GO