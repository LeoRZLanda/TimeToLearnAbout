CREATE PROCEDURE Transacciones_Insertar
	@UsuarioId int,
	@FechaTransaccion date,
	@Monto decimal(18,2),
	@CategoriaId int,
	@CuentaId int,
	@Nota nvarchar(1000)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Transacciones(UsuarioId, FechaTransacción, Monto, CategoriaId, CuentaId, Nota)
	VALUES (@UsuarioId, @FechaTransaccion, ABS(@Monto), @CategoriaId, @CuentaId, @Nota)

    UPDATE Cuentas
	SET Balance += @Monto
	WHERE Id = @CuentaId;

	SELECT SCOPE_IDENTITY();
END
GO