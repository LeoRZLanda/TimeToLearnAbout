SELECT Transacciones.Id, UsuarioId, Monto, Nota, Descripci�n
FROM Transacciones
INNER JOIN TiposTransaccion
ON Transacciones.TipoTransacciónId = TiposTransaccion.Id