-- Eliminar si existe la tabla #Personas
-- Tablas: #Personas

IF OBJECT_ID(N'tempdb..#Personas', N'U') IS NOT NULL
    DROP TABLE #Personas
GO