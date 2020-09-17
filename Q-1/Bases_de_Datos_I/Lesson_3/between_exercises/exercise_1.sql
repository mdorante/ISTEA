-- Mostrar todos los productos cuyo precio de lista esté entre 200 y 300
-- Tablas: Production.Product
-- Campos: ListPrice

SELECT
    ListPrice
FROM
    Production.Product
WHERE
    ListPrice BETWEEN 200 AND 300;