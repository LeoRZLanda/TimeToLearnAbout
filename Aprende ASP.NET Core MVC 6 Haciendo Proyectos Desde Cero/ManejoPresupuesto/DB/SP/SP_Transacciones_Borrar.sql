CREATE PROCEDURE Transacciones_Borrar 
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @Monto decimal (18,2);
	DECLARE @CuentaId int;
	DECLARE @TipoTransacciónId int;

	SELECT @Monto = Monto, @CuentaId = CuentaId, @TipoTransacciónId = cat.TipoTransacciónId
	FROM Transacciones
	INNER JOIN Categorías cat
	ON cat.Id = Transacciones.CategoriaId
	WHERE Transacciones.Id = @Id;

	DECLARE @FactorMultiplicativo int = 1;

	IF (@TipoTransacciónId = 2)
		SET @FactorMultiplicativo = -1;

	SET @Monto = @Monto * @FactorMultiplicativo;

	UPDATE Cuentas
	SET Balance -= @Monto
	WHERE id = @CuentaId;

	DELETE Transacciones
	WHERE Id = @Id;
END