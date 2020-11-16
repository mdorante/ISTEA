-- delete all rows from a table
DELETE FROM Sales.SalesPersonQuotaHistory

SELECT *
FROM Sales.SalesPersonQuotaHistory
-- NOTE: if you want to delete all the rows from a table, you should use TRUNCATE TABLE <table name>
-- which is faster than delete and optimized for these operations

-- delete specified rows
DELETE FROM Production.ProductCostHistory
WHERE StandardCost > 1000

DELETE FROM Production.ProductCostHistory
WHERE
    StandardCost BETWEEN 12 AND 14
    AND EndDate IS NULL

-- use a join to delete rows resulting from the join
DELETE s
FROM
    dbo.Sectores AS s
    INNER JOIN dbo.SectoresNuevo AS sn
    ON s.Sector = sn.Sector

SELECT * FROM dbo.Sectores
