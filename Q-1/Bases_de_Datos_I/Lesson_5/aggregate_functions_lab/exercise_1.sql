-- Mostrar la fecha más reciente de venta
-- Tablas: Sales.SalesOrderHeader
-- Campos: OrderDate

SELECT
    MAX(OrderDate) AS 'Most Recent Sale'
FROM
    Sales.SalesOrderHeader;