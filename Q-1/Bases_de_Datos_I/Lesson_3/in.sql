-- basic in demo

SELECT
    FirstName, MiddleName, LastName
FROM
    Person.Person
WHERE
    MiddleName IN ('A', 'D', 'R');