-- Mostrar todos los productos cuyo Subtotal no esté entre 50 y 70
-- Tablas: Sales.SalesOrderHeader
-- Campos: OrderDate, AccountNumber, SubTotal

SELECT
    OrderDate, AccountNumber, SubTotal
FROM
    Sales.SalesOrderHeader
WHERE
    SubTotal NOT BETWEEN 50 AND 70
ORDER BY
    SubTotal;