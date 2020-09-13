-- Mostrar los empleados que tienen más de 90 horas de vacaciones
-- Tablas: HumanResources.Employee
-- Campos: VacationHours, BusinessEntityID

SELECT
    VacationHours, BusinessEntityID
FROM 
    HumanResources.Employee
WHERE
    VacationHours > 90;