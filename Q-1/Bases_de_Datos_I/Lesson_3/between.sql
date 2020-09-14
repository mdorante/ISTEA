-- basic between demo

SELECT
    Name, ListPrice
FROM
    Production.Product
WHERE
    ListPrice BETWEEN 0 AND 50;