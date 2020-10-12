-- Mostrar las subcategorías de los productos que tienen dos o más productos que cuestan menos de $150
-- Tablas: Production.Product
-- Campos: ProductSubcategoryID, ListPrice

SELECT
    ProductSubcategoryID,
    COUNT(ProductSubcategoryID) AS Cantidad
FROM
    Production.Product
WHERE
    ListPrice > 150
GROUP BY
    COUNT(ProductSubcategoryID)
HAVING
    COUNT(ProductSubcategoryID) >= 2;