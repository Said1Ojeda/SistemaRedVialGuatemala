-- Consultas de ejemplo
-- Se pueden correr una por una para ver los datos

USE BDRedVialGuatemala;
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

-- Los 10 municipios mas poblados del pais
SELECT TOP (10) Municipio, Departamento, Poblacion
FROM vw_MunicipiosDetalle
ORDER BY Poblacion DESC;

-- Departamentos con mas de 20 municipios
SELECT d.Nombre AS Departamento, COUNT(*) AS Municipios
FROM Departamentos d
INNER JOIN Municipios m ON m.IdDepartamento = d.IdDepartamento
GROUP BY d.Nombre
HAVING COUNT(*) > 20
ORDER BY Municipios DESC;

-- El municipio mas poblado de cada departamento
WITH Ranking AS
(
    SELECT
        Departamento,
        Municipio,
        Poblacion,
        ROW_NUMBER() OVER (PARTITION BY IdDepartamento ORDER BY Poblacion DESC) AS Lugar
    FROM vw_MunicipiosDetalle
)
SELECT Departamento, Municipio, Poblacion
FROM Ranking
WHERE Lugar = 1
ORDER BY Poblacion DESC;

-- Municipios con mas gente que el promedio de su departamento
SELECT m.Nombre AS Municipio, d.Nombre AS Departamento, m.Poblacion
FROM Municipios m
INNER JOIN Departamentos d ON d.IdDepartamento = m.IdDepartamento
WHERE m.Poblacion > (SELECT AVG(m2.Poblacion)
                     FROM Municipios m2
                     WHERE m2.IdDepartamento = m.IdDepartamento)
ORDER BY d.Nombre, m.Poblacion DESC;

-- Nombres de municipio que se repiten en distintos departamentos
SELECT m.Nombre AS Municipio, COUNT(*) AS Veces,
       STRING_AGG(d.Nombre, N', ') AS Departamentos
FROM Municipios m
INNER JOIN Departamentos d ON d.IdDepartamento = m.IdDepartamento
GROUP BY m.Nombre
HAVING COUNT(*) > 1;

-- Poblacion por region
SELECT Region, Departamentos, Municipios, PoblacionTotal
FROM vw_ResumenRegiones
ORDER BY PoblacionTotal DESC;

-- Ciudades ordenadas por cantidad de conexiones directas
SELECT Origen AS Ciudad, COUNT(*) AS Conexiones
FROM vw_RutasAmbosSentidos
GROUP BY Origen
ORDER BY Conexiones DESC, Ciudad;

-- Cabeceras que no tienen ruta directa con la capital
SELECT d.Nombre AS Departamento, d.Cabecera
FROM Departamentos d
WHERE d.Cabecera <> N'Ciudad de Guatemala'
  AND NOT EXISTS (SELECT 1
                  FROM vw_RutasAmbosSentidos r
                  WHERE r.Origen = N'Ciudad de Guatemala'
                    AND r.Destino = d.Cabecera)
ORDER BY d.Nombre;

-- Funciones
SELECT dbo.fn_DistanciaCapitalMunicipio(IdMunicipio) AS Km
FROM Municipios
WHERE Nombre = N'Cobán';

SELECT * FROM dbo.fn_ConexionesDesde(N'Jutiapa');

-- Procedimientos
EXEC sp_EstadisticasRed;
EXEC sp_BuscarMunicipio @Texto = N'San Pedro';
EXEC sp_MunicipiosPorDepartamento @Departamento = N'Quetzaltenango';
EXEC sp_DistanciaCapitalMunicipio @Municipio = N'La Libertad';
EXEC sp_RutaMasCorta @Origen = N'Ciudad de Guatemala', @Destino = N'Flores';
EXEC sp_RutaMasCorta @Origen = N'San Marcos', @Destino = N'Puerto Barrios';

-- Prueba de la bitacora
-- Se hace dentro de una transaccion y al final se deshace para no tocar los datos
BEGIN TRANSACTION;

EXEC sp_ActualizarDistanciaRuta @IdRuta = 1, @Distancia = 41.00;
SELECT * FROM BitacoraRutas;

ROLLBACK TRANSACTION;
GO
