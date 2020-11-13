-- Mostrar los nombres de todos los productos presentes en la subcategoría de ruedas
-- Tablas:Production.Product, Production.ProductSubcategory
-- Campos: ProductSubcategoryID, Name

SELECT
    p.ProductSubcategoryID,
    p.Name
FROM
    Production.Product AS p
WHERE
    EXISTS 
    (
        SELECT
            s.ProductSubcategoryID
        FROM
            Production.ProductSubcategory AS s
        WHERE
            p.ProductSubcategoryID = s.ProductSubcategoryID
    )