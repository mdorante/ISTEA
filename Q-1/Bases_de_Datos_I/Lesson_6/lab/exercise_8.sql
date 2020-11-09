-- Mostrar el nombre de los productos y de los proveedores cuya subcategoría es 15, ordenados por nombre de
-- proveedor
-- Tablas: Production.Product, Purchasing.ProductVendor, Purchasing.Vendor
-- Campos: Name ,ProductID, BusinessEntityID, ProductSubcategoryID

SELECT
    p.Name AS "Product Name",
    v.Name AS "Vendor Name"
FROM
    Production.Product AS p LEFT JOIN Purchasing.ProductVendor AS pv
    ON p.ProductID = pv.ProductID
    RIGHT JOIN Purchasing.Vendor AS v
    ON pv.BusinessEntityID = v.BusinessEntityID
WHERE
    p.ProductSubcategoryID = 15
ORDER BY
    v.Name
