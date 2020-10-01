-- Mostrar la fecha de nacimiento del empleado más joven
-- Tablas: HumanResources.Employee
-- Campos: BirthDate

SELECT
    MAX(BirthDate) as 'Youngest Employee Birthdate'
FROM
    HumanResources.Employee;