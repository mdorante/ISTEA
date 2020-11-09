-- Mostrar los nombres de los productos que no son bicicletas
-- Tablas:Production.Product, Production.ProductSubcategory
-- Campos: Name, ProductSubcategoryID

SELECT
    p.Name
FROM
    Production.Product AS p LEFT JOIN Production.ProductSubcategory AS s
    ON p.ProductSubcategoryID = s.ProductSubcategoryID
WHERE
    s.Name NOT LIKE '%bike%'