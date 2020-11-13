-- Listar todos las productos cuyo precio sea inferior al precio promedio de todos los productos
-- Tablas:Production.Product
-- Campos: Name, ListPrice

SELECT
    Name,
    ListPrice
FROM
    Production.Product
WHERE
    ListPrice < 
    (
        SELECT
            AVG(ListPrice) AS Promedio
        FROM
            Production.Product
    )
ORDER BY
    ListPrice