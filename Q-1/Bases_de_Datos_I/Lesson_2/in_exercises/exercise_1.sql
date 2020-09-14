-- Mostrar los códigos de venta y producto, cantidad de venta y precio unitario de los artículos 750, 753 y 770.
--tablas: Sales.SalesOrderDetail
--campos: SalesOrderID, ProductID, OrderQty, UnitPrice

SELECT
    SalesOrderID, ProductID, OrderQty, UnitPrice
FROM
    Sales.SalesOrderDetail
WHERE
    ProductID IN (750, 753, 770);