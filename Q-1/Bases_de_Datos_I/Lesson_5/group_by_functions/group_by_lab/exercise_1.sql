-- Mostrar el código de subcategoría y el precio del producto más barato de cada una de ellas
-- Tablas: Production.Product
-- Campos: ProductSubcategoryID, ListPrice

SELECT
    ProductSubcategoryID,
    MIN(ListPrice) AS 'Minimum Price'
FROM
    Production.Product
GROUP BY
    ProductSubcategoryID
ORDER BY
    ProductSubcategoryID ASC;
