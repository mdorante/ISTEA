-- Mostrar los empleados que también son vendedores
-- Tablas: HumanResources.Employee, Sales.SalesPerson
-- Campos: BusinessEntityID

SELECT
    e.BusinessEntityID,
    e.LoginID,
    s.SalesLastYear
FROM
    HumanResources.Employee AS e INNER JOIN Sales.SalesPerson AS s
    ON e.BusinessEntityID = s.BusinessEntityID
