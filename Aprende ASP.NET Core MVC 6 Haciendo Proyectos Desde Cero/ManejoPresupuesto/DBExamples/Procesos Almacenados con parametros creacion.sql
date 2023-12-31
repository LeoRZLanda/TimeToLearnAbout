USE [ManejoPresupuesto]
GO
/****** Object:  StoredProcedure [dbo].[Transacciones_SelectConTipoOperacion]    Script Date: 16/11/2023 11:16:52 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Transacciones_SelectConTipoOperacion]
	@fecha DATE
AS
BEGIN

	SET NOCOUNT ON;

	SELECT Transacciones.Id, UsuarioId, Monto, Nota, Descripción
	FROM Transacciones
	INNER JOIN TiposTransaccion
	ON Transacciones.TipoTransacciónId = TiposTransaccion.Id
	WHERE FechaTransaccion = @fecha
END
