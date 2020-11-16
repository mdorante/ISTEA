-- update a column for all rows of a table
UPDATE Person.Address
SET ModifiedDate = GETDATE()

SELECT *
FROM Person.Address;

-- update using a mathematical expression
UPDATE Production.Product
SET ListPrice = ListPrice * 2

SELECT ListPrice
FROM Production.Product

-- update multiple columns
UPDATE Sales.SalesPerson
SET BONUS = 6000, CommissionPct = 1.10, SalesQuota = NULL

SELECT *
FROM Sales.SalesPerson

-- use WHERE in order to update only the rows you want
UPDATE Production.Product
SET Color = N'Metallic Red'
WHERE Name LIKE N'Road-250%' AND Color = N'Red'

-- update using default values
UPDATE Production.Location
SET CostRate = DEFAULT
WHERE CostRate > 20.00

-- update top 10 rows
UPDATE TOP(10) HumanResources.Employee
SET VacationHours = VacationHours * 1.25

-- update the resulting rows from a query
UPDATE HumanResources.Employee
SET VacationHours = VacationHours + 8
FROM
    (SELECT TOP 10
        BusinessEntityID
    FROM HumanResources.Employee
    ORDER BY HireDate ASC ) AS t
WHERE HumanResources.Employee.BusinessEntityID = t.BusinessEntityID

-- update rows with the values of rows from another table
INSERT INTO dbo.SectoresNuevo
    (Sector, SectorNuevo)
VALUES
    ('Contaduria', 'Tesoreria')

SELECT *
FROM dbo.SectoresNuevo

UPDATE s
    SET Sector = sn.SectorNuevo
FROM
    Sectores AS s
    INNER JOIN SectoresNuevo AS sn
    ON s.Sector = sn.Sector

SELECT *
FROM dbo.Sectores