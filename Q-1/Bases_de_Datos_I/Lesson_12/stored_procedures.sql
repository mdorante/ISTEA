-- execute a stored procedure or function
EXEC ('SELECT * FROM Production.Product')

-- create a stored procedure
IF OBJECT_ID('dbo.SP_Empleados', 'P') IS NOT NULL
    DROP PROCEDURE dbo.SP_Empleados
GO

CREATE PROCEDURE dbo.SP_Empleados
AS
BEGIN
    SELECT LastName, FirstName, Department
    FROM HumanResources.vEmployeeDepartmentHistory
END
GO

-- execute dbo.SP_Empleados
EXEC dbo.SP_Empleados
GO

-- create a SP that takes in parameters
IF OBJECT_ID('dbo.SP_Empleados', 'P') IS NOT NULL
    DROP PROCEDURE dbo.SP_Empleados
GO

CREATE PROCEDURE dbo.SP_Empleados
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50)
AS
BEGIN
    SELECT LastName, FirstName, Department
    FROM HumanResources.vEmployeeDepartmentHistory
    WHERE FirstName = @FirstName AND LastName = @LastName
END
GO

-- calling the SP using ordered params
EXEC dbo.SP_Empleados 'Pilar' , 'Ackerman'

-- exec using named params
EXEC dbo.SP_Empleados @FirstName = 'Pilar', @LastName = 'Ackerman'

-- create a SP with default param values
IF OBJECT_ID('dbo.SP_Empleados', 'P') IS NOT NULL
    DROP PROCEDURE dbo.SP_Empleados
GO

CREATE PROCEDURE dbo.SP_Empleados
    @FirstName VARCHAR(50) = 'Zainal',
    @LastName VARCHAR(50) = 'Arifin'
AS
BEGIN
    SELECT
        LastName, FirstName, Department
    FROM
        HumanResources.vEmployeeDepartmentHistory
    WHERE 
        FirstName = @FirstName
        AND LastName = @LastName
END
GO

-- exec using default params
EXEC dbo.SP_Empleados

-- create an SP with output values
IF OBJECT_ID('dbo.SP_Empleados', 'P') IS NOT NULL
    DROP PROCEDURE dbo.SP_Empleados
GO

CREATE PROCEDURE dbo.SP_Empleados
    @FirstName VARCHAR(50) = 'Zainal',
    @LastName VARCHAR(50) = 'Arifin',
    @Department VARCHAR(50) OUTPUT
AS
BEGIN
    SELECT
        @Department = Department
    FROM
        HumanResources.vEmployeeDepartmentHistory
    WHERE
        FirstName = @FirstName
        AND LastName = @LastName
END
GO

-- declare the variable where the output will be stored
DECLARE @DepartmentValue VARCHAR(50)

-- execute the SP, sending the output to @DepartmentValue
EXEC dbo.SP_Empleados 'Pilar', 'Ackerman', @DepartmentValue OUTPUT

SELECT @DepartmentValue AS 'Output from SP'

-- create an SP with a return value
IF OBJECT_ID('dbo.SP_Empleados', 'P') IS NOT NULL
        DROP PROCEDURE dbo.SP_Empleados
GO

CREATE PROCEDURE dbo.SP_Empleados
    @FirstName VARCHAR(50) = 'Zainal',
    @LastName VARCHAR(50) = 'Arifin'
AS
BEGIN
    DECLARE @Department VARCHAR(50)
    SELECT
        @Department = Department
    FROM
        HumanResources.vEmployeeDepartmentHistory
    WHERE
        FirstName = @FirstName
        AND LastName = @LastName

    IF @Department IS NULL
            RETURN 0
        ELSE
            RETURN 1
END
GO

-- declar a var to store the return value
DECLARE @ReturnValue TINYINT

-- call the SP to store the value in @ReturnValue
EXEC @ReturnValue = dbo.SP_Empleados 'Pilar', 'Ackerman'

SELECT @ReturnValue AS 'Value returned from an SP'

-- create an SP with output and return values
IF OBJECT_ID('dbo.SP_Empleados', 'P') IS NOT NULL
        DROP PROCEDURE dbo.SP_Empleados
GO

CREATE PROCEDURE dbo.SP_Empleados
    @FirstName VARCHAR(50) = 'Zainal',
    @LastName VARCHAR(50) = 'Arifin',
    @Department VARCHAR(50) OUTPUT
AS
BEGIN
    SELECT
        @Department = Department
    FROM
        HumanResources.vEmployeeDepartmentHistory
    WHERE
        FirstName = @FirstName
        AND LastName = @LastName

    -- if the employee doesn't have a Department
    IF @Department IS NULL
    BEGIN
        SET @Department = 'Unknown Department'
        RETURN 0
    END
    ELSE
        RETURN 1
END
GO

DECLARE @Result TINYINT
DECLARE @Dep VARCHAR(50)

EXEC @Result = dbo.SP_Empleados 'Pilar', 'Ackerman', @Dep OUTPUT

SELECT
    @Result AS 'Return value',
    @Dep AS 'Output value'

-- insert with an SP
IF OBJECT_ID('dbo.SP_Empleados', 'P') IS NOT NULL
    DROP PROCEDURE dbo.SP_Empleados
GO

CREATE PROCEDURE dbo.SP_Empleados
AS
BEGIN
    SELECT FirstName, LastName, Department
    FROM HumanResources.vEmployeeDepartmentHistory
END
GO

IF OBJECT_ID('dbo.Empleados', 'U') IS NOT NULL
    DROP TABLE dbo.Empleados
GO

CREATE TABLE dbo.Empleados
(
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Departamento VARCHAR(50)
)
GO

INSERT INTO dbo.Empleados
EXEC dbo.SP_Empleados
GO

SELECT *
FROM dbo.Empleados