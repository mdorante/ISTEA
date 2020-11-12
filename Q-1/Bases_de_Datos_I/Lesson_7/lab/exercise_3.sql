-- Eliminar si existe la tabla #Productos
-- Tablas: #Productos

IF OBJECT_ID(N'tempdb..#Productos', N'U') IS NOT NULL
    DROP TABLE #Productos
GO