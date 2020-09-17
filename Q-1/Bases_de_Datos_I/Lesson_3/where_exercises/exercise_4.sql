-- Mostrar las personas que la segunda letra de su apellido es una s
-- Tablas: Person.Person
-- Campos: LastName

SELECT
    LastName
FROM
    Person.Person
WHERE
    LastName LIKE '_s%';