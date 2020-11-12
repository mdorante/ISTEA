-- Crear una CTE con las órdenes de venta
-- Tablas: Sales.SalesOrderHeader
-- Campos: SalesPersonID, SalesOrderID, OrderDate

WITH
    Orders_CTE (SalesPersonID, SalesOrderID, OrderDate)
    AS
    (
        SELECT
            SalesPersonID,
            SalesOrderID,
            OrderDate
        FROM
            Sales.SalesOrderHeader
        WHERE
            SalesPersonID IS NOT NULL
    )

SELECT *
FROM
    Orders_CTE