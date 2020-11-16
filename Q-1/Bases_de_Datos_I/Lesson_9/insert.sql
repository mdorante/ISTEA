-- insert a row of default values
INSERT INTO dbo.Sectores
DEFAULT VALUES;

-- insert a row of custom values
INSERT INTO dbo.Sectores
VALUES
    ('Finanzas', 'Contaduria')

-- insert multiple rows of values
INSERT INTO dbo.Sectores
VALUES
    ('Finanzas', 'Cobranzas'),
    ('Finanzas', 'Ventas')

-- insert values using any column order
INSERT INTO dbo.Sectores
    (Sector, Gerencia)
VALUES
    ('Legales', 'Finanzas')

-- insert custom values into the identity column
SET IDENTITY_INSERT dbo.Sectores ON;

-- CAREFUL: ID values will skip to the value you insert (100)
-- even after turning INDENTITY_INSERT off, it will continue to add IDs starting at 101 and so on...
INSERT INTO dbo.Sectores
    (SectorID, Gerencia, Sector)
VALUES
    (100, 'Recursos Humanos', DEFAULT)

SET IDENTITY_INSERT dbo.Sectores OFF;

-- insert the results of a query from another table
INSERT INTO dbo.Sectores
    (Gerencia, Sector)
SELECT
    Name,
    GroupName
FROM
    HumanResources.Department
WHERE
    DepartmentID = 1

SELECT *
FROM dbo.Sectores;