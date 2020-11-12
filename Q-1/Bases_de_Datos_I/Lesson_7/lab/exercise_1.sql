-- Clonar estructura y datos de los campos nombre, color y precio de lista de la tabla production.product en una
-- tabla llamada #Productos
-- Tablas:Production.Product
-- Campos: Name, ListPrice, Color

SELECT
    Name,
    Color,
    ListPrice
INTO
    #Productos
FROM
    Production.Product

SELECT *
FROM #Productos