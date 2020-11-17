-- if/else statements
DECLARE @MyVar INT;
SET @MyVar = 100;

IF @MyVar < 10
    PRINT 'Value below 10'
ELSE
    PRINT 'Value over 10'
