-- Mostrar el la fecha,numero de version y subtotal de las ventas efectuadas en los años 2012 y 2013.
--tablas: Sales.SalesOrderHeader
--campos: OrderDate, AccountNumber, SubTotal

SELECT
    OrderDate, AccountNumber, SubTotal
FROM
    Sales.SalesOrderHeader
WHERE
    YEAR(OrderDate) BETWEEN 2012 AND 2013;