-- Mostrar el promedio del listado de precios de productos
-- Tablas: Production.Product
-- Campos: ListPrice

SELECT
    AVG(ListPrice) AS 'Average Product Price'
FROM
    Production.Product;