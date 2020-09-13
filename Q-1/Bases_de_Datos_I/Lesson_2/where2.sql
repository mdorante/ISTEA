-- another select using where, conditions evaluated with AND and OR

SELECT
    WeightUnitMeasureCode, ProductID
FROM
    Production.Product
WHERE
    (
        WeightUnitMeasureCode='G'
    OR WeightUnitMeasureCode='LB'
    )
    AND
    (
        ProductID = 513
    OR ProductID = 739
    );