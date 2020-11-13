--  SELECT subquery
SELECT
    ProductID,
    ListPrice,
    (
        SELECT
            AVG(ListPrice) AS "AVG ListPrice"
        FROM
            Production.Product
    )
FROM
    Production.Product

-- FROM subquery
SELECT
    p.ProductID,
    p.ListPrice,
    s.Promedio
FROM
    Production.Product AS p
    INNER JOIN
    (
        SELECT
            ProductID,
            AVG(LineTotal) AS Promedio
        FROM
            Sales.SalesOrderDetail
        GROUP BY
                ProductID
    ) AS s
    ON p.ProductID = s.ProductID

-- WHERE subquery
SELECT
    ProductID,
    ListPrice
FROM
    Production.Product
WHERE
    ListPrice < (SELECT AVG(LineTotal) FROM Sales.SalesOrderDetail)

-- another WHERE subquery
SELECT
    p1.ProductSubcategoryID,
    p1.ProductID,
    p1.ListPrice
FROM
    Production.Product AS p1
WHERE
    ListPrice = 
    (
        SELECT
            MIN(ListPrice)
        FROM
            Production.Product AS p2
        WHERE
            p2.ProductSubcategoryID = p1.ProductSubcategoryID
    )
ORDER BY
    p1.ProductSubcategoryID

-- IN / NOT IN subquery
SELECT
    FirstName,
    MiddleName,
    LastName
FROM
    Person.Person
WHERE
    BusinessEntityID IN 
    (
        SELECT
            BusinessEntityID
        FROM
            Sales.SalesPerson
    )

-- EXISTS subquery
SELECT
    FirstName,
    LastName
FROM
    Person.Person AS p
WHERE
    EXISTS
    (
        SELECT
            s.BusinessEntityID
        FROM
            Sales.SalesPerson AS s
        WHERE
            s.BusinessEntityID = p.BusinessEntityID
    )

-- ANY / ALL

-- ANY is equivalent to EXISTS
SELECT
    Name,
    ListPrice
FROM
    Production.Product
WHERE
    ListPrice > ANY 
    (
        SELECT
            AVG(ListPrice) AS Promedio
        FROM
            Production.Product
    )

-- ALL is equivalent to NOT EXISTS
SELECT
    Name,
    ListPrice
FROM
    Production.Product
WHERE
    ListPrice <> ALL 
    (
        SELECT
            AVG(ListPrice) AS Promedio
        FROM
            Production.Product
    )
