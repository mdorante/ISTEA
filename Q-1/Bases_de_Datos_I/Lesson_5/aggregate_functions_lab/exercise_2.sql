-- Mostrar el precio más barato de todas las bicicletas
-- Tablas: Production.Product
-- Campos: ListPrice, Name

SELECT
    MIN(ListPrice) AS 'Minimum Bike Price'
FROM
    Production.Product
WHERE
    Name LIKE '%Bike%';