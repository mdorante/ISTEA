-- Mostrar los nombre de los productos que tengan cualquier combinación de 'mountain bike'.
-- tablas: Production.Product
-- campos: Name

SELECT
    Name
FROM
    Production.Product
WHERE
    Name LIKE '%mountain bike%';