-- Mostrar la cantidad de personas que no son vendedores
-- Tablas: Person.Person, Sales.SalesPerson
-- Campos: BusinessEntityID

SELECT
    COUNT(p.BusinessEntityID) AS "Cantidad de personas"
FROM
    Person.Person AS p
WHERE
    NOT EXISTS
    (
        SELECT
            s.BusinessEntityID
        FROM
            Sales.SalesPerson AS s
        WHERE
            s.BusinessEntityID = p.BusinessEntityID
    )