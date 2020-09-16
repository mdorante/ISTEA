-- get all entries with last names that have an A as 1st and 3rd chars

SELECT
    FirstName, LastName
FROM
    Person.Person
WHERE
    LastName LIKE 'A_A%';