-- delete all data from a table
TRUNCATE TABLE dbo.Sectores
GO

SELECT
    COUNT(*) AS CantidadRegistros
FROM
    dbo.Sectores