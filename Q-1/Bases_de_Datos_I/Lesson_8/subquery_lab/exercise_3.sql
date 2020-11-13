-- Mostrar el o los códigos del producto mas caro
-- Tablas:Production.Product
-- Campos: ProductID,ListPrice

SELECT
    ProductID,
    ListPrice
FROM
    Production.Product
WHERE
    ListPrice = (SELECT MAX(ListPrice) FROM Production.Product)