-- Mostrar los diferentes productos vendidos
-- Tablas: Sales.SalesOrderDetail
-- Campos: ProductID

SELECT DISTINCT
    ProductID
FROM
    Sales.SalesOrderDetail;