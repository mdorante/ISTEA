-- get all entries where LastName is either Zhang or Zheng

SELECT
    FirstName, LastName
FROM
    Person.Person
WHERE
    LastName LIKE 'Zh[ae]ng';