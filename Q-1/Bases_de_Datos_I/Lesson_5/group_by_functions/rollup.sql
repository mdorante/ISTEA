--  ROLLUP -> shows subtotals in groups 
-- In this example, we get the subtotal up to the first group (which is 998), then we get the group for 998 and the group for 999

SELECT
    ProductID,
    MAX(LineTotal) AS Maximum
FROM
    Sales.SalesOrderDetail
WHERE
    ProductID > 995
GROUP BY
    ProductID WITH ROLLUP
HAVING
    MAX(LineTotal) > 3000
ORDER BY
    ProductID ASC;