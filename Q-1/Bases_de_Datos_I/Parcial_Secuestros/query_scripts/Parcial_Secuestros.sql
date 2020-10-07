USE Secuestros;

-- Punto 1
-- Se solicita una consulta que retorne los tipos de delitos (Tabla: TiposDelitos, Campo: TipoDelito). Solo
-- debe retornar los registros cuyo campo [tipodelito] contenga la palabra “ley” pero no contenga el
-- numero “24769”
-- (resultado esperado: 14 registros)

SELECT
    TipoDelito
FROM
    TipoDelitos
WHERE
    TipoDelito LIKE '%Ley%' AND
    TipoDelito NOT LIKE '%24769%';

-- Punto 2
-- Se solicita una consulta que retorne los juzgados que no registren secuestros
-- Resultado Esperado: 10 registros

SELECT J.Juzgado
FROM
    Secuestros AS S
    RIGHT JOIN Juzgados AS J ON S.JuzgadoID = J.JuzgadoID
WHERE
    S.JuzgadoID IS NULL;

-- Punto 3
-- Se solicita una consulta que retorne la cantidad de secuestros agrupados por tipo y subtipo de bien
-- Resultado esperado: 44 registros

SELECT
    TB.TipoBien,
    STB.SubTipoBien,
    COUNT(S.JuzgadoID) AS Secuestros
FROM
    Secuestros AS S
    JOIN Bienes AS B ON S.BienID = B.BienID
    RIGHT JOIN SubTipoBienes AS STB ON B.SubTipoBienID = STB.SubTipoBienID
    RIGHT JOIN TipoBienes AS TB ON STB.TipoBienID = TB.TipoBienID
WHERE
    S.JuzgadoID IS NOT NULL
GROUP BY
    TB.TipoBien,
    STB.SubTipoBien;

-- Punto 4
-- Al resultado obtenido en el punto 3. Listar los secuestros que registren fecha de secuestro (que le fecha
-- no sea nula)
-- Resultado esperado: 11 registros

SELECT
    TB.TipoBien,
    STB.SubTipoBien,
    COUNT(S.JuzgadoID) AS Secuestros
FROM
    Secuestros AS S
    JOIN Bienes AS B ON S.BienID = B.BienID
    RIGHT JOIN SubTipoBienes AS STB ON B.SubTipoBienID = STB.SubTipoBienID
    RIGHT JOIN TipoBienes AS TB ON STB.TipoBienID = TB.TipoBienID
WHERE
    S.JuzgadoID IS NOT NULL
    AND S.Fecha IS NOT NULL
GROUP BY
    TB.TipoBien,
    STB.SubTipoBien;

-- Punto 5
-- Al resultado obtenido en el punto 4. Listar solo secuestros se superen el promedio de cantidad de
-- secuestros. El promedio (53) debe calcularse en la consulta y no harcodearse.
-- Resultado esperado: 3 registros

WITH
    Secuestros_CTE (TipoBien, SubTipoBien, Secuestros)
    AS
    (
        SELECT
            TB.TipoBien,
            STB.SubTipoBien,
            COUNT(S.JuzgadoID) AS Secuestros
        FROM
            Secuestros AS S
            JOIN Bienes AS B ON S.BienID = B.BienID
            RIGHT JOIN SubTipoBienes AS STB ON B.SubTipoBienID = STB.SubTipoBienID
            RIGHT JOIN TipoBienes AS TB ON STB.TipoBienID = TB.TipoBienID
        WHERE
            S.JuzgadoID IS NOT NULL
            AND S.Fecha IS NOT NULL
        GROUP BY
            TB.TipoBien,
            STB.SubTipoBien
    )
SELECT
    TipoBien,
    SubTipoBien,
    Secuestros,
    (Select AVG(Secuestros) from Secuestros_CTE) AS Promedio
FROM
    Secuestros_CTE
WHERE
    Secuestros > (Select AVG(Secuestros) from Secuestros_CTE);

-- Punto 6
-- Se solicita una consulta que retorne la cantidad de secuestros agrupados por medidas. Contar solo los
-- secuestros cuyo tipo de delito comiencen con “Homicidio”. Listar todas las medidas por mas que no
-- registros secuestros.
-- Resultado esperado: 4 registros

WITH
    TCE (TipoDelito, MedidaID, BienID) 
    AS
    (
        SELECT
            TD.TipoDelito, 
            S.MedidaID, 
            S.BienID
        FROM 
            Secuestros AS S
            JOIN TipoDelitos AS TD ON S.TipoDelitoID = TD.TipoDelitoID
        WHERE 
            TD.TipoDelito LIKE 'Homicidio%'
    )
SELECT 
    M.Medida, 
    COUNT(TCE.BienID) AS Secuestros
FROM 
    TCE
    RIGHT JOIN Medidas AS M ON TCE.MedidaID = M.MedidaID
GROUP BY M.Medida;