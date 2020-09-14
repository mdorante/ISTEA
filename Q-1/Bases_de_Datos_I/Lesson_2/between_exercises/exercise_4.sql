-- Mostrar todos los productos cuyo precio de lista  no esté entre 50 y 70.
--tablas:Production.Product
--campos: ListPrice

SELECT
    ListPrice
FROM
    Production.Product
WHERE
    ListPrice NOT BETWEEN 50 AND 70;