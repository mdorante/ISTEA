-- Union demo
-- combines the result of the two SELECT statements

-- The number and order of the columns must be the same in both SELECT statements for this to work
-- Data types must be compatible

    SELECT
        BusinessEntityID
    FROM
        Sales.SalesPerson

UNION

    SELECT
        BusinessEntityID
    FROM
        HumanResources.Employee;