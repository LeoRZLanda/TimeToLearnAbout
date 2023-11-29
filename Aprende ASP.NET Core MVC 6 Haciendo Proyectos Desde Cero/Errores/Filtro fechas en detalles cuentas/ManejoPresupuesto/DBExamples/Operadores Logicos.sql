SELECT *
FROM Transacciones
WHERE UsuarioId like '%pe' AND FechaTransaccion = '2023-11-15'

SELECT *
FROM Transacciones
WHERE (UsuarioId = 'Felipe' AND Monto = 1500.99) OR UsuarioId = 'abc'