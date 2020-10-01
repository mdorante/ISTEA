-- Mostrar la cantidad y el total vendido por productos
-- Tablas: Sales.SalesOrderDetail
-- Campos: LineTotal

SELECT
    COUNT(1) AS 'Number of sales',
    SUM(LineTotal) AS 'Total (USD)'
FROM
    Sales.SalesOrderDetail;