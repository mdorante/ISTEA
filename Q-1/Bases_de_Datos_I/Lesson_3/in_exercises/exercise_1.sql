-- Mostrar los códigos de venta y producto, cantidad de venta y precio unitario de los
-- artículos 750, 753 y 770
-- Tablas: Sales.SalesOrderDetail
-- Campos: SalesOrderID, OrderQty, ProductID, UnitPrice

SELECT
    SalesOrderID, OrderQty, ProductID, UnitPrice
FROM
    Sales.SalesOrderDetail
WHERE
    ProductID IN (750, 753, 770);