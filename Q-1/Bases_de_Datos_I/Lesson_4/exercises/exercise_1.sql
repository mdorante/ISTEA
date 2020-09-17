-- Mostrar las personas ordenadas primero por su apellido y luego por su nombre
-- Tablas:Person.Person
-- Campos: Firstname, Lastname

SELECT
    FirstName, LastName
FROM
    Person.Person
ORDER BY
    LastName ASC, FirstName ASC;