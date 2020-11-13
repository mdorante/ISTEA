-- Mostrar todos los vendedores (nombre y apellido) que no tengan asignado un territorio de ventas
-- Tablas: Person.Person, Sales.SalesPerson
-- Campos: BusinessEntityID, TerritoryID, LastName, FirstName

SELECT
    p.FirstName,
    p.LastName,
    p.BusinessEntityID
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
            AND s.TerritoryID IS NULL
    )