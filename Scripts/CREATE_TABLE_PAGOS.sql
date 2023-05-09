
USE Examen_Coppel
IF OBJECT_ID('dbo.PAGOS', 'U') IS NOT NULL 
  DROP TABLE dbo.PAGOS; 

CREATE TABLE PAGOS (
	ID INT IDENTITY(1,1) NOT NULL,
	ID_EMPLEADO INT NOT NULL,
	ID_ROL INT NOT NULL,
	PAGO_DEL_MES INT NOT NULL,
	PAGO_DEL_YEAR INT NOT NULL,
	SALARIO_BRUTO DECIMAL(18,2),
	TOTAL_BONUS_POR_ENTREGA DECIMAL(18,2),
	TOTAL_BONUS_POR_HORA DECIMAL(18,2),
	SUBTOTAL DECIMAL(18,2),
	TOTAL_ISR DECIMAL(18,2),
	TOTAL_ISR_ADICIONAL DECIMAL(18,2),
	INGRESOS_NETOS DECIMAL(18,2),
	TOTAL_VALES_DESPENSA DECIMAL(18,2),
	PAGO_NETO DECIMAL(18,2)

	PRIMARY KEY (ID),
	FOREIGN KEY (ID_EMPLEADO) REFERENCES EMPLEADOS(ID),
	FOREIGN KEY (ID_ROL) REFERENCES ROLES(ID)
)