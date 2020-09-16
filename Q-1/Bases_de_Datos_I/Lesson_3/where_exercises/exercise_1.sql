-- Mostrar el nombre, precio y color de los accesorios para asientos de las bicicletas cuyo
-- precio sea mayor a 100 pesos
-- Tablas: Production.Product
-- Campos: Name, ListPrice, Color

SELECT
    Name, ListPrice, Color
FROM
    Production.Product
WHERE
    ListPrice > 100;