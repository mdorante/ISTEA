SELECT
    FirstName, MiddleName, LastName
FROM
    Person.Person
WHERE
    MiddleName NOT IN ('A', 'D', 'R');