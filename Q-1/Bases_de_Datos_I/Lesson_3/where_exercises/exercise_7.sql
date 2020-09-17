-- Mostrar las personas cuyo nombre tenga una C o c como primer carácter,
-- cualquier otro como segundo carácter, ni d ni e ni f ni g como tercer carácter,
-- cualquiera entre j y r o entre s y w como cuarto carácter y el resto sin restricciones
-- Tablas: Person.Person
-- Campos: FirstName

SELECT
    FirstName
FROM
    Person.Person
WHERE
    FirstName LIKE '[Cc]_[^d-g][j-w]%';