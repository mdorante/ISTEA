-- Mostrar el nombre, precio y color de los accesorios para asientos de las bicicletas cuyo precio sea  mayor a 100 pesos.
--tablas: Production.Product
--campos: Name, ListPrice, Color

SELECT
    Name, ListPrice, Color
FROM
    Production.Product
WHERE
    Name LIKE '%Seat%' -- with like, we can use a pattern to search for matching items
    AND ListPrice > 100;