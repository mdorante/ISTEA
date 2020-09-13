-- Mostrar precio y nombre de los productos 776, 777, 778
-- Tablas:Production.Product
-- Campos: ProductID, Name, ListPrice

SELECT
    ProductID, Name, ListPrice
FROM
    Production.Product
WHERE
    ProductID = 776
    OR ProductID = 777
    OR ProductID = 778;