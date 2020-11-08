-- inner join
-- compare two tables and return the items that are in both tables

SELECT
    a.BusinessEntityID,
    a.FirstName,
    a.LastName,
    b.PhoneNumber
FROM
    Person.Person AS a INNER JOIN Person.PersonPhone AS b
    ON a.BusinessEntityID = b.BusinessEntityID
WHERE
    a.BusinessEntityID < 10
