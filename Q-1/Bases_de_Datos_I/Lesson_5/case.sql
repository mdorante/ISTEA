-- CASE demo

SELECT
    ProductLine,
    Category = CASE ProductLine -- depending on the value for ProductLine, we will give a value to Category (Category doesn't exist in the table)
                    WHEN 'R' THEN 'Road'
                    WHEN 'M' THEN 'Mountain'
                    WHEN 'T' THEN 'Touring'
                    ELSE 'Not for sale'
                END
FROM
    Production.Product;