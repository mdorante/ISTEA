-- Mostrar el nombre, precio y precio con iva de los productos con precio distinto de cero
-- Tablas:Production.Product
-- Campos: Name, ListPrice

SELECT
    Name, ListPrice, ListPrice * 1.21 as "Con IVA"
FROM
    Production.Product
WHERE
    ListPrice <> 0;