-- Mostrar todos los productos vendidos y ordenados
-- Tablas: Sales.SalesOrderDetail, Production.WorkOrder
-- Campos: ProductID

    SELECT
        ProductID
    FROM
        Sales.SalesOrderDetail
UNION ALL

    SELECT
        ProductID
    FROM
        Production.WorkOrder;