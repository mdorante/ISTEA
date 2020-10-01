-- GROUP BY -> to be combined with aggregate functions, groups results by specified columns

SELECT
    ProductID,
    MAX(LineTotal) AS Maximum
FROM
    Sales.SalesOrderDetail
WHERE
    ProductID > 995
GROUP BY
    ProductID
ORDER BY
    ProductID ASC;