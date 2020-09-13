-- Mostrar los representantes de ventas (vendedores) que no tienen definido el número de territorio
-- Tablas: Sales.SalesPerson
-- Campos: TerritoryID, BusinessEntityID

SELECT
    TerritoryID, BusinessEntityID
FROM
    Sales.SalesPerson
WHERE
    TerritoryID IS NULL;