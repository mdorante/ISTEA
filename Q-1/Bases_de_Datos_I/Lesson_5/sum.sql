--  SUM -> sums all the values (skips NULL values)

SELECT
    SUM(ListPrice) AS Total
FROM
    Production.Product;