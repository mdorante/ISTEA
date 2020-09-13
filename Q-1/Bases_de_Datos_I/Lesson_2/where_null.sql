-- null value demo

SELECT
    Name, Weight, Color
FROM
    Production.Product
WHERE
    Weight IS NOT NULL
    AND Color IS NULL;