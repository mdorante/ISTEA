-- declare a variable
DECLARE @Contador INT;

-- declare multiple variables in the same line
DECLARE @Contador2 INT, @Edad INT;

-- initialize a variable
DECLARE @Contador3 INT = 11;

-- assign a value after declaration
DECLARE @Mensaje VARCHAR(50);

-- using SET
SET @Mensaje = 'Sup homies';

-- using SELECT
SELECT @Mensaje = 'Hi';

-- declare a table as a var
DECLARE @TableVar TABLE
(
    ID INT NOT NULL,
    Apellido VARCHAR(50),
    Nombre VARCHAR(50)
);
