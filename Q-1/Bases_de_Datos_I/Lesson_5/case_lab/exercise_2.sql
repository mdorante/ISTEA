-- Mostrar el id de los empleados si tiene salario deberá mostrarse descendente de lo contrario ascendente
-- Tablas:HumanResources.Employee
-- Campos: BusinessEntityID, SalariedFlag

SELECT
    BusinessEntityID
FROM
    HumanResources.Employee
ORDER BY
    CASE WHEN SalariedFlag = 1 THEN BusinessEntityID
    END DESC,
    CASE WHEN SalariedFlag = 0 THEN BusinessEntityID
    END ASC;
        
