-- bulk insert using SELECT INTO
-- it populates a new table with the results from a SELECT operation

SELECT
    TerritoryID,
    Name
INTO
    #Territories
FROM
    Sales.SalesTerritory
WHERE
    CountryRegionCode = 'US'


SELECT *
FROM
    #Territories
ORDER BY
    TerritoryID