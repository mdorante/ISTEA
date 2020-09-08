-- aliases

SELECT
    "Name" as Product, -- Name is an SQL key word so if we want to use the table column called Name, we have to enclose it in ""
    'Hello' as Greeting -- You can also set a literal to be displayed alongside the actual table contents
FROM
    Production.Product as prod;