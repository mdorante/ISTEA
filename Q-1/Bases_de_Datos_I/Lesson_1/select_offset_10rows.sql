-- selects all products except the top 10

SELECT
    ProductID
FROM
    Production.Product
ORDER BY 
    ProductID
OFFSET 10 ROWS;