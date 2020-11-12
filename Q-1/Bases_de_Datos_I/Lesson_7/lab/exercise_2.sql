-- Clonar solo estructura de los campos identificador, nombre y apellido de la tabla person.person en una tabla
-- llamada #Personas
-- Tablas: Person.Person
-- Campos: BusinessEntityID, FirstName, LastName

SELECT
    BusinessEntityID,
    FirstName,
    LastName
INTO
    #Personas
FROM
    Person.Person
WHERE 
    -- this will always return false, that way we only create the data structure 
    -- without actually inserting data into #Personas
    1 = 2

SELECT *
FROM #Personas