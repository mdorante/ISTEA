-- Mostrar todos los empleados que nacieron entre 1970 y 1985.
--tablas: HumanResources.Employee
--campos: BirthDate

SELECT
    BirthDate
FROM
    HumanResources.Employee
WHERE
    YEAR(BirthDate) BETWEEN 1970 AND 1985; -- YEAR() returns the year from a datetime object