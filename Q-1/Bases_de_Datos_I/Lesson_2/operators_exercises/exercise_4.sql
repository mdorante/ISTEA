-- Mostrar el nombre concatenado con el apellido de las personas cuyo apellido sea johnson
-- Tablas:Person.Person
-- Campos: FirstName, LastName

SELECT
    FirstName, LastName
FROM 
    Person.Person
WHERE
    LastName = 'Johnson';