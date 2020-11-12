-- Common Table Expression

WITH
    Sales_CTE (SalesPersonID, SalesOrderID, SalesYear)
    AS
    (
        SELECT
            SalesPersonID, SalesOrderID, YEAR(OrderDate) AS SalesYear
        FROM
            sales.SalesOrderHeader
        WHERE
        SalesOrderID = 43659
    )

SELECT
    *
FROM
    Sales_CTE