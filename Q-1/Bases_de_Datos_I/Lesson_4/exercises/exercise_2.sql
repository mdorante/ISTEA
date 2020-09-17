-- Mostrar cinco productos más caros y su nombre ordenado en forma alfabética
-- Tablas:Production.Product
-- Campos: Name, ListPrice

SELECT TOP 5
    Name, ListPrice
FROM
    Production.Product
ORDER BY
    ListPrice DESC, Name;