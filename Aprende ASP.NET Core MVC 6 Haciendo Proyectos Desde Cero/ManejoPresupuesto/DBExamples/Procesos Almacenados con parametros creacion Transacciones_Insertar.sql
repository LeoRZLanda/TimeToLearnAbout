-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Transacciones_Insertar
	-- Add the parameters for the stored procedure here
	@UsuarioId nvarchar(450),
	@FechaTransaccion DATE,
	@Monto decimal(18,2),
	@TipoTransaccion int,
	@Nota nvarchar(1000) = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Transacciones(UsuarioId, FechaTransaccion, Monto, TipoTransacciónId, Nota)
	VALUES (@UsuarioId, @FechaTransaccion, @Monto, @TipoTransaccion, @Nota)
END
GO
