-- Mostrar los productos y el total vendido de cada uno de ellos, ordenados por el total vendido
-- Tablas: Sales.SalesOrderDetail
-- Campos: ProductID, LineTotal

SELECT
    ProductID,
    SUM(LineTotal) as "Total Vendido"
FROM
    Sales.SalesOrderDetail
GROUP BY
    ProductID
ORDER BY
    "Total Vendido"