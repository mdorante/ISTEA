-- Mostrar precio y nombre de los productos 776, 777, 778
-- Tablas:Production.Product
-- Campos: ProductID, Name, ListPrice

SELECT
    ProductID, Name, ListPrice
FROM
    Production.Product
WHERE
    ProductID IN (776, 777, 778);