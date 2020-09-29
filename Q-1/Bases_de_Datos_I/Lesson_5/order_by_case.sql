-- CASE inside of an ORDER BY

SELECT
    LastName,
    CountryRegionName
FROM
    Sales.vSalesPerson
WHERE
    TerritoryName IS NOT NULL
ORDER BY 
    -- if CountryRegionName == 'United States' orders by LastName DESC
    CASE WHEN CountryRegionName = 'United States' THEN LastName 
    END DESC,
    -- if CountryRegionName != 'United States' orders by LastName ASC
    CASE WHEN CountryRegionName != 'United States' THEN LastName 
    END ASC;