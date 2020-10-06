-- Mostrar el promedio vendido por factura.
-- Tablas: Sales.SalesOrderDetail
-- Campos: SalesOrderID, LineTotal

SELECT
    SalesOrderID,
    AVG(LineTotal) AS Promedio
FROM
    Sales.SalesOrderDetail
GROUP BY
    SalesOrderID;