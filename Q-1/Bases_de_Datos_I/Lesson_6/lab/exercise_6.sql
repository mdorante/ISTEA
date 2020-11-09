-- Mostrar los precios de venta de aquellos productos donde el precio de venta sea inferior al precio de lista
-- recomendado para ese producto ordenados por nombre de producto
-- Tablas: Sales.SalesOrderDetail, Production.Product
-- Campos: ProductID, Name, ListPrice, UnitPrice

SELECT DISTINCT
    p.Name,
    s.UnitPrice AS "Precio de venta",
    p.ListPrice AS "Precio de lista recomendado"
FROM
    Sales.SalesOrderDetail AS s LEFT JOIN Production.Product AS p
    ON s.ProductID = p.ProductID
WHERE
    s.UnitPrice < p.ListPrice
ORDER BY
    p.Name
