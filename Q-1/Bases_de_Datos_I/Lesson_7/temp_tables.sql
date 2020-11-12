-- creates a local temp table
CREATE TABLE #Provincias
(
    ProvinciaID INT NOT NULL,
    Ciudad VARCHAR(40) NOT NULL
);

-- creates a global temp table
CREATE TABLE ##Provincias
(
    ProvinciaID INT NOT NULL,
    Ciudad VARCHAR(40) NOT NULL
);