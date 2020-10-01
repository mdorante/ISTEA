--  HAVING -> to be used with Group By to filter groups

SELECT
    ProductID,
    MAX(LineTotal) AS Maximum
FROM
    Sales.SalesOrderDetail
WHERE
    ProductID > 995
GROUP BY
    ProductID
HAVING
    MAX(LineTotal) > 3000
ORDER BY
    ProductID ASC;