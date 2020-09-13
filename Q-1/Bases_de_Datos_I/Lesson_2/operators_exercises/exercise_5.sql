-- Mostrar todos los productos cuyo precio sea inferior a 150$ de color rojo o cuyo precio sea mayor a 500$ de color negro
-- Tablas:Production.Product
-- Campos: ListPrice, Color

SELECT
    ListPrice, Color
FROM
    Production.Product
WHERE
    (
        ListPrice < 150
    AND Color = 'Red'
    )
    OR
    (
        ListPrice > 500
    AND Color = 'Black'
    );