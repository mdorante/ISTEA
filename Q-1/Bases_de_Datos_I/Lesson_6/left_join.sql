-- left join
-- returns all records from the left table, and the matched records from the right table

SELECT
    a.ProductID,
    a.Name,
    b.OrderQty
FROM
    Production.Product AS a LEFT JOIN Sales.SalesOrderDetail AS b
    ON a.ProductID = b.ProductID
WHERE
    a.ProductID in (389, 897)