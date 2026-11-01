-- Vistas del sistema

USE BDRedVialGuatemala;
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

-- Municipios con su departamento y la distancia aproximada desde la capital
CREATE VIEW vw_MunicipiosDetalle
AS
SELECT
    m.IdMunicipio,
    m.Nombre AS Municipio,
    d.IdDepartamento,
    d.Nombre AS Departamento,
    d.Region,
    m.Poblacion,
    m.DistanciaCabecera,
    d.DistanciaCapital,
    d.DistanciaCapital + m.DistanciaCabecera AS DistanciaDesdeCapital
FROM Municipios m
INNER JOIN Departamentos d ON d.IdDepartamento = m.IdDepartamento;
GO

-- Resumen de cada departamento
CREATE VIEW vw_ResumenDepartamentos
AS
SELECT
    d.IdDepartamento,
    d.Nombre AS Departamento,
    d.Cabecera,
    d.Region,
    d.DistanciaCapital,
    COUNT(m.IdMunicipio) AS Municipios,
    ISNULL(SUM(CAST(m.Poblacion AS BIGINT)), 0) AS PoblacionTotal,
    (SELECT TOP (1) m2.Nombre
     FROM Municipios m2
     WHERE m2.IdDepartamento = d.IdDepartamento
     ORDER BY m2.Poblacion DESC) AS MunicipioMasPoblado
FROM Departamentos d
LEFT JOIN Municipios m ON m.IdDepartamento = d.IdDepartamento
GROUP BY d.IdDepartamento, d.Nombre, d.Cabecera, d.Region, d.DistanciaCapital;
GO

-- Totales por region
CREATE VIEW vw_ResumenRegiones
AS
SELECT
    d.Region,
    COUNT(DISTINCT d.IdDepartamento) AS Departamentos,
    COUNT(m.IdMunicipio) AS Municipios,
    ISNULL(SUM(CAST(m.Poblacion AS BIGINT)), 0) AS PoblacionTotal
FROM Departamentos d
LEFT JOIN Municipios m ON m.IdDepartamento = d.IdDepartamento
GROUP BY d.Region;
GO

-- Rutas con el departamento de cada punta
CREATE VIEW vw_RutasDetalle
AS
SELECT
    r.IdRuta,
    r.Origen,
    dOrigen.Nombre AS DepartamentoOrigen,
    r.Destino,
    dDestino.Nombre AS DepartamentoDestino,
    r.Distancia,
    r.TipoRuta,
    r.Fuente,
    r.FechaConsulta
FROM Rutas r
INNER JOIN Departamentos dOrigen ON dOrigen.Cabecera = r.Origen
INNER JOIN Departamentos dDestino ON dDestino.Cabecera = r.Destino;
GO

-- Cada ruta en los dos sentidos
-- Es la misma idea del grafo no dirigido que arma el programa
CREATE VIEW vw_RutasAmbosSentidos
AS
SELECT IdRuta, Origen, Destino, Distancia, TipoRuta
FROM Rutas
UNION ALL
SELECT IdRuta, Destino, Origen, Distancia, TipoRuta
FROM Rutas;
GO
