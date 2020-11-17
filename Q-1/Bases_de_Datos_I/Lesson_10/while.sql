-- while loop

DECLARE @Index INT;
SET @Index = 0;

WHILE (@Index <= 10)
BEGIN
    PRINT 'Current value: ' + CAST(@Index AS VARCHAR(3))

    IF @Index = 7
    BEGIN
        SET @Index = @Index + 1
        WAITFOR DELAY '00:00:20'
        CONTINUE
    END

    IF @Index = 8 GOTO msg

    -- this line will never be executed because of the GOTO
    IF @Index = 9 BREAK

    SET @Index = @Index + 1
END

msg:
PRINT 'Escaped the while loop by GOTO'