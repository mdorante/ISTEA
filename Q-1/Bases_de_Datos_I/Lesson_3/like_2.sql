-- get all entries where lastname starts with an A but does not have B as second char

SELECT
    FirstName, LastName
FROM
    Person.Person
WHERE
    LastName LIKE 'A[^B]%';