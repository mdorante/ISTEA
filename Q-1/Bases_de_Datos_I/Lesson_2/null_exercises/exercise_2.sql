-- Mostrar el peso de todos los artículos. si el peso no estuviese definido, reemplazar por cero
-- Tablas:Production.Product
-- Campos: Weight

SELECT
    ISNULL(Weight, 0) -- if null, the value will be replaced with 0
FROM
    Production.Product
