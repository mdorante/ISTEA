-- Mostrar los nombre de los productos que tengan cualquier combinación de ‘mountain bike’
-- Tablas: Production.Product
-- Campos: Name

SELECT
    Name
FROM
    Production.Product
WHERE
    Name LIKE '%mountain bike%';