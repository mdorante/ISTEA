-- go to 10th product and only select the following 5 products

SELECT 
    ProductID
FROM 
    Production.Product
ORDER BY 
    ProductID
OFFSET 10 ROWS FETCH NEXT 5 ROWS ONLY;