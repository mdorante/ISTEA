-- Mostrar el producto más barato de cada subcategoría. mostrar subcategoría, código de producto
-- y el precio de lista más barato ordenado por subcategoría
-- Tablas:Production.Product
-- Campos: ProductSubcategoryID, ProductID, ListPrice

SELECT
    p1.ProductSubcategoryID,
    p1.ProductID,
    p1.ListPrice
FROM
    Production.Product AS p1
WHERE
    ListPrice = 
    (
        SELECT
            MIN(p2.ListPrice)
        FROM
            Production.Product AS p2
        WHERE
            p1.ProductSubcategoryID = p2.ProductSubcategoryID
    )
ORDER BY
    p1.ProductSubcategoryID