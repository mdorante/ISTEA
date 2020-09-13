-- Mostrar el código, fecha de ingreso y horas de vacaciones de los empleados ingresaron a partir del año 2000
-- Tablas: HumanResources.Employee
-- Campos: BusinessEntityID, HireDate, VacationHours

SELECT
    BusinessEntityID, HireDate, VacationHours
FROM
    HumanResources.Employee
WHERE
    HireDate > '2000-01-01';