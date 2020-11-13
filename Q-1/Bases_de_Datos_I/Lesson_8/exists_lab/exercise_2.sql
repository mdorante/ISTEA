-- Mostrar todos los productos que no fueron vendidos
-- Tablas:Production.Product, Sales.SalesOrderDetail
-- Campos: Name, ProductID

SELECT
    p.Name,
    p.ProductID
FROM
    Production.Product AS p
WHERE
    NOT EXISTS
    (
        SELECT
            s.ProductID
        FROM
            Sales.SalesOrderDetail AS s
        WHERE
            s.ProductID = p.ProductID
    )