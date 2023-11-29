SELECT *
FROM Transacciones
WHERE FechaTransaccion > '2023-11-1' AND FechaTransaccion < '2023-11-30'

SELECT *
FROM Transacciones
WHERE MONTH(FechaTransaccion) = 11