-- Mostrar todos los productos cuyo color no sea verde, blanco y azul.
--tablas: Production.Product
--campos: Color

SELECT
    Color
FROM
    Production.Product
WHERE
    Color NOT IN ('Green', 'White', 'Blue');