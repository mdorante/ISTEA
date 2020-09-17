-- Mostrar todos los productos cuyo color sea verde, blanco y azul
-- Tablas: Production.Product
-- Campos: Color

SELECT
    Color
FROM
    Production.Product
WHERE
    Color IN ('Green', 'White', 'Blue');