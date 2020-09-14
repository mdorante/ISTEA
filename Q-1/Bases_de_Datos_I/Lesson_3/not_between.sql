-- basic not between demo

SELECT
    Name, ListPrice
FROM
    Production.Product
WHERE
    ListPrice NOT BETWEEN 0 AND 50;