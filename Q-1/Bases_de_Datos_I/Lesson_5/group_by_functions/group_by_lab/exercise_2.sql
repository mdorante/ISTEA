-- Mostrar los productos y la cantidad total vendida de cada uno de ellos
-- Tablas: Sales.SalesOrderDetail
-- Campos: ProductID, OrderQty

SELECT
    ProductID,
    SUM(OrderQty) AS Cantidad
FROM
    Sales.SalesOrderDetail
GROUP BY
    ProductID;