-- Mostrar los empleados ordenados alfabéticamente por apellido y por nombre
-- Tablas: HumanResources.Employee, Person.Person
-- Campos: BusinessEntityID, LastName, FirstName

SELECT
    e.BusinessEntityID,
    p.LastName,
    p.FirstName
FROM
    HumanResources.Employee AS e LEFT JOIN Person.Person AS p
    ON e.BusinessEntityID = p.BusinessEntityID
ORDER BY
    p.LastName,
    p.FirstName
