--  Create a test table
IF OBJECT_ID(N'dbo.Sectores', N'U') IS NOT NULL
    DROP TABLE dbo.Sectores
GO

CREATE TABLE dbo.Sectores
(
    SectorID TINYINT NOT NULL IDENTITY(1,1),
    Gerencia VARCHAR(50),
    Sector VARCHAR(50) DEFAULT 'Sin Sector'
)

IF OBJECT_ID(N'dbo.SectoresNuevo', N'U') IS NOT NULL
    DROP TABLE dbo.SectoresNuevo
GO

CREATE TABLE dbo.SectoresNuevo
(
    Sector VARCHAR(50),
    SectorNuevo VARCHAR(50)
)