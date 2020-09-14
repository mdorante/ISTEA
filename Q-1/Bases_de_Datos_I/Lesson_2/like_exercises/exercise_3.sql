-- Mostrar las personas que su nombre empiece con la letra 'y'.
-- tablas:Person.Person
-- campos: FirstName

SELECT
    FirstName
FROM
    Person.Person
WHERE
    FirstName LIKE 'y%';