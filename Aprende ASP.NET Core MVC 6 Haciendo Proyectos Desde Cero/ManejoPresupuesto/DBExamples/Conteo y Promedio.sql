SELECT UsuarioId, AVG(Monto) as Monto, TipoTransacciónId, Count(Id) as Total, MONTH(FechaTransaccion) as Mes
FROM Transacciones
GROUP BY UsuarioId, TipoTransacciónId, MONTH(FechaTransaccion)

