-- right join
-- returns all records from the right table, and the matched records from the left table

SELECT
    s.SalesOrderID,
    c.CustomerID
FROM
    Sales.SalesOrderHeader AS s RIGHT JOIN Sales.Customer AS c
    ON s.CustomerID = c.CustomerID
WHERE
    c.CustomerID IN (701, 11000)