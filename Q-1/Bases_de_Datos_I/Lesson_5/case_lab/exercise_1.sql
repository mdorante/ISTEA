-- Obtener el id y una columna denominada sexo cuyo valores disponibles sean “Masculino” y ”Femenino”
-- Tablas: HumanResources.Employee
-- Campos: BusinessEntityID, Gender

SELECT
    BusinessEntityID,
    -- Gender only has 'F' or 'M' as values, with those values, I'll create a column called Sexo with these values
    CASE 
        WHEN Gender = 'F' THEN 'Femenino'
        ELSE 'Masculino'
    END Sexo
FROM
    HumanResources.Employee