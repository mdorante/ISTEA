-- full join
-- returns all records when there is a match in either left or right table

SELECT
    c.CurrencyRateID,
    s.SalesOrderID
FROM
    Sales.SalesOrderHeader AS s FULL JOIN Sales.CurrencyRate AS c
    ON c.CurrencyRateID = s.CurrencyRateID
WHERE
    c.CurrencyRateID = 2705
    OR s.SalesOrderID IN (56358, 56359)