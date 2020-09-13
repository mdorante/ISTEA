SELECT
    ProductID, ListPrice, Color
FROM
    Production.Product
WHERE
    (
        ListPrice < 60
    AND Color = 'Yellow'
    )
    OR
    (
        ListPrice > 2318
    AND Color = 'Silver'
    );