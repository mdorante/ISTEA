-- Mostrar todas las facturas realizadas y el total facturado de cada una de ellas ordenado por número de factura
-- pero sólo de aquellas órdenes superen un total de $10.000
-- Tablas: Sales.SalesOrderDetail
-- Campos: SalesOrderID, LineTotal

SELECT
    SalesOrderID,
    SUM(LineTotal) as "Total Facturado"
FROM
    Sales.SalesOrderDetail
GROUP BY
    SalesOrderID
HAVING
    SUM(LineTotal) > 10000
