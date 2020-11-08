-- cross join
-- joins every row from the left table with every row from the right table

SELECT
    sd.SalesOrderID,
    sh.SalesOrderID
FROM
    Sales.SalesOrderDetail AS sd CROSS JOIN sales.SalesOrderHeader AS sh
WHERE
    sd.SalesOrderID = 43665
    AND sh.SalesOrderID IN (43662, 43668)