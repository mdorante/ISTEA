-- Mostrar el nombre concatenado con el apellido de las personas cuyo apellido tengan terminación española (ez).
--tablas: Person.Person
--campos: FirstName,LastName

SELECT
    FirstName, LastName, FirstName + ' ' + LastName as 'FullName'
FROM
    Person.Person
WHERE
    LastName LIKE '%ez';