-- Mostrar la cantidad de facturas que vendieron más de 20 unidades
-- Tablas: Sales.SalesOrderDetail
-- Campos: SalesOrderID, OrderQty

SELECT
    SalesOrderID,
    SUM(OrderQty) AS Cantidad
FROM
    Sales.SalesOrderDetail
GROUP BY
    SalesOrderID
HAVING
    SUM(OrderQty) > 20;