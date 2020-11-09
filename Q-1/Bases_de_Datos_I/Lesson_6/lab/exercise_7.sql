-- Mostrar todos los productos que tengan igual precio. Se deben mostrar de a pares, código y nombre de cada uno
-- de los dos productos y el precio de ambos.ordenar por precio en forma descendente
-- Tablas:Production.Product
-- Campos: ProductID, ListPrice, Name

SELECT
    a.ProductID AS "ID Producto 1",
    a.Name "Producto 1",
    a.ListPrice "Precio Producto 1",
    b.ProductID AS "ID Producto 2",
    b.Name "Producto 2",
    b.ListPrice "Precio Producto 2"
FROM
    Production.Product AS a INNER JOIN Production.Product AS b
    ON a.ListPrice = b.ListPrice
WHERE
    a.Name != b.Name
    AND a.ProductID != b.ProductID
ORDER BY
    a.ListPrice DESC