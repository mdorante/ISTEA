-- Mostrar los nombres de los productos que terminen en un número
-- Tablas: Production.Product
-- Campos: Name

SELECT
    Name
FROM
    Production.Product
WHERE
    Name LIKE '%[0-9]';