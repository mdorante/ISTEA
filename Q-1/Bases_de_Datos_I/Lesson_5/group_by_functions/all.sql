-- ALL -> includes all groups and result sets, 
-- even the ones that have rows that DON'T meet the WEHRE conditions
-- it returns NULL for said groups


SELECT
    ProductID,
    MAX(LineTotal) AS Maximum
FROM
    Sales.SalesOrderDetail
WHERE
    ProductID <> 707
GROUP BY ALL
    ProductID;