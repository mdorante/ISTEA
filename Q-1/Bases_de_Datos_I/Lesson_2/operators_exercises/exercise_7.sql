-- Mostrar el nombre, número de producto, precio de lista y el precio de lista incrementado en un 10% de los
-- productos cuya fecha de fin de venta sea anterior al día de hoy
-- Tablas:Production.Product
-- Campos: Name, ProductNumber, ListPrice, SellEndDate

SELECT
    Name, ProductNumber, ListPrice, ListPrice * 1.1 as 'Price after end', SellEndDate
FROM
    Production.Product
WHERE
    SellEndDate < GETDATE(); -- GETDATE() function gets today's date