-- basic where

SELECT
    Name, ListPrice, MakeFlag
FROM
    Production.Product
WHERE
    ListPrice > 0 AND ListPrice < 40 AND MakeFlag > 0;