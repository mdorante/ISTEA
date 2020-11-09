-- Mostrar el código de logueo, número de territorio y sueldo básico de los vendedores
-- Tablas: HumanResources.Employee, Sales.SalesPerson
-- Campos: LoginID, TerritoryID, Bonus, BusinessEntityID

SELECT
    e.LoginID,
    s.TerritoryID,
    s.Bonus,
    s.BusinessEntityID
FROM
    HumanResources.Employee AS e RIGHT JOIN Sales.SalesPerson AS s
    ON e.BusinessEntityID = s.BusinessEntityID