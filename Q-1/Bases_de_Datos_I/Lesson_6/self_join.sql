-- self join
-- joins a table with itself in order to establish relations between columns of the same table

-- let's create a new table
IF OBJECT_ID('dbo.Empleados', 'U') IS NOT NULL
    DROP TABLE dbo.Empleados

CREATE TABLE Empleados
(
    Codigo INT,
    Nombre VARCHAR(50),
    Puesto VARCHAR(50),
    Supervisor INT
);

INSERT INTO dbo.Empleados
VALUES
    (1, 'Juan' , 1, NULL)
,
    (2, 'Pedro' , 1, 1)
,
    (3, 'Maria' , 2, NULL)
,
    (4, 'Martin', 2, 3)
,
    (5, 'Matias', 3, 3);


--  Returns employees with their corresponding supervisors
SELECT
    p2.Puesto,
    p2.Nombre,
    p2.Codigo,
    p1.Nombre AS Supervisor
FROM
    Empleados AS p1 INNER JOIN Empleados AS p2
    ON p1.Codigo = p2.Supervisor;