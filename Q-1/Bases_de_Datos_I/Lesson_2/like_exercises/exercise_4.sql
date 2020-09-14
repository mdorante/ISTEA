-- Mostrar las personas que la segunda letra de su apellido es una s.
--tablas:Person.Person
--campos: LastName

SELECT
    LastName
FROM
    Person.Person
WHERE
    LastName LIKE '_s%';