-- Mostrar las personas cuyo nombre empiece con la letra “y”
-- Tablas: Person.Person
-- Campos: FirstName

SELECT
    FirstName
FROM
    Person.Person
WHERE
    FirstName LIKE 'Y%';