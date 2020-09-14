-- Mostrar todos los productos cuyo precio de lista esté entre 200 y 300.
--tablas:Production.Product
--campos: ListPrice

SELECT
    ListPrice
FROM
    Production.Product
WHERE
    ListPrice BETWEEN 200 AND 300;