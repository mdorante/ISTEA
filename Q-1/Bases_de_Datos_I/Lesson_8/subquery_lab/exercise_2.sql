-- Listar el nombre, precio de lista, precio promedio y diferencia de precios entre cada producto
-- y el valor promedio general
-- Tablas:Production.Product
-- Campos: Name, ListPrice

SELECT
    Name,
    ListPrice,
    (SELECT AVG(ListPrice) FROM Production.Product) AS "Precio Promedio",
    ListPrice - (SELECT AVG(ListPrice) FROM Production.Product) AS "Diferencia de Precio"
FROM
    Production.Product

    