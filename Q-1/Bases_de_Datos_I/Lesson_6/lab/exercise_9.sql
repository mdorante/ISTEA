-- Mostrar todas las personas (nombre y apellido) y en el caso que sean empleados mostrar también el login id, sino
-- mostrar null
-- Tablas: Person.Person, HumanResources.Employee
-- Campos: FirstName, LastName, LoginID, BusinessEntityID

SELECT
    p.FirstName,
    p.LastName,
    e.LoginID
FROM
    Person.Person AS p LEFT JOIN HumanResources.Employee AS e
    ON p.BusinessEntityID = e.BusinessEntityID