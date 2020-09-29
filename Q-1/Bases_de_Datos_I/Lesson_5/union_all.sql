-- UNION ALL (includes duplicated values)

    SELECT
        BusinessEntityID
    FROM
        Sales.SalesPerson

UNION ALL

    SELECT
        BusinessEntityID
    FROM
        HumanResources.Employee;