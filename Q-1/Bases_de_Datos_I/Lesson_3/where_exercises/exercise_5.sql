-- Mostrar el nombre concatenado con el apellido de las personas cuyo apellido tengan
-- terminación española (ez)
-- Tablas: Person.Person
-- Campos: FirstName, LastName

SELECT
    FirstName + LastName as 'Concatenado' -- no spaces in between
FROM
    Person.Person
WHERE
    LastName LIKE '%ez';