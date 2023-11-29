SELECT UsuarioId, SUM(Monto) as Suma, TipoTransacciónId, MONTH(FechaTransaccion) as MES
FROM Transacciones
GROUP BY UsuarioId, TipoTransacciónId, MONTH(FechaTransaccion)