-- Mostrar los nombres de los productos que terminen en un número.
--tablas: Production.Product
--campos: Name

SELECT
    Name
FROM
    Production.Product
WHERE
    Name LIKE '%[0-9]';