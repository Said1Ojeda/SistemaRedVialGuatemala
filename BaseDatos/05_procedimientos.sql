-- Procedimientos almacenados

USE BDRedVialGuatemala;
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

-- Busca municipios por una parte del nombre
CREATE PROCEDURE sp_BuscarMunicipio
    @Texto NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Municipio, Departamento, Region, Poblacion, DistanciaDesdeCapital
    FROM vw_MunicipiosDetalle
    WHERE Municipio LIKE N'%' + @Texto + N'%'
    ORDER BY Poblacion DESC;
END
GO

-- Municipios de un departamento con su lugar por poblacion
CREATE PROCEDURE sp_MunicipiosPorDepartamento
    @Departamento NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM Departamentos WHERE Nombre = @Departamento)
        THROW 50001, N'Ese departamento no existe.', 1;

    SELECT
        Municipio,
        Poblacion,
        DistanciaCabecera,
        DistanciaDesdeCapital,
        RANK() OVER (ORDER BY Poblacion DESC) AS LugarPorPoblacion,
        CAST(100.0 * Poblacion / NULLIF(SUM(CAST(Poblacion AS BIGINT)) OVER (), 0) AS DECIMAL(5,2)) AS PorcentajeDelDepartamento
    FROM vw_MunicipiosDetalle
    WHERE Departamento = @Departamento
    ORDER BY Poblacion DESC;
END
GO

-- Distancia de la capital a un municipio
-- Si el nombre se repite en otro departamento salen los dos
CREATE PROCEDURE sp_DistanciaCapitalMunicipio
    @Municipio NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM Municipios WHERE Nombre = @Municipio)
        THROW 50002, N'Ese municipio no existe.', 1;

    SELECT
        Municipio,
        Departamento,
        DistanciaCapital AS CapitalACabecera,
        DistanciaCabecera AS CabeceraAMunicipio,
        DistanciaDesdeCapital AS TotalAproximado
    FROM vw_MunicipiosDetalle
    WHERE Municipio = @Municipio;
END
GO

-- Camino mas corto entre dos cabeceras
-- Arma todos los caminos posibles sin repetir ciudad y se queda con el de menos kilometros
CREATE PROCEDURE sp_RutaMasCorta
    @Origen NVARCHAR(100),
    @Destino NVARCHAR(100),
    @MaxTramos INT = 10
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM Departamentos WHERE Cabecera = @Origen)
        THROW 50003, N'El origen no es una cabecera registrada.', 1;

    IF NOT EXISTS (SELECT 1 FROM Departamentos WHERE Cabecera = @Destino)
        THROW 50004, N'El destino no es una cabecera registrada.', 1;

    IF @Origen = @Destino
        THROW 50005, N'El origen y el destino son la misma ciudad.', 1;

    -- Tramos en los dos sentidos
    DECLARE @Tramos TABLE
    (
        Origen    NVARCHAR(100) NOT NULL,
        Destino   NVARCHAR(100) NOT NULL,
        Distancia DECIMAL(10,2) NOT NULL
    );

    INSERT INTO @Tramos (Origen, Destino, Distancia)
    SELECT Origen, Destino, Distancia
    FROM vw_RutasAmbosSentidos;

    WITH Caminos AS
    (
        SELECT
            r.Destino AS Actual,
            CAST(r.Distancia AS DECIMAL(10,2)) AS Total,
            1 AS Tramos,
            CAST(N'|' + r.Origen + N'|' + r.Destino + N'|' AS NVARCHAR(1000)) AS Visitados,
            CAST(r.Origen + N' > ' + r.Destino AS NVARCHAR(1000)) AS Camino
        FROM @Tramos r
        WHERE r.Origen = @Origen

        UNION ALL

        SELECT
            r.Destino,
            CAST(c.Total + r.Distancia AS DECIMAL(10,2)),
            c.Tramos + 1,
            CAST(c.Visitados + r.Destino + N'|' AS NVARCHAR(1000)),
            CAST(c.Camino + N' > ' + r.Destino AS NVARCHAR(1000))
        FROM Caminos c
        INNER JOIN @Tramos r ON r.Origen = c.Actual
        WHERE c.Actual <> @Destino
          AND c.Tramos < @MaxTramos
          AND CHARINDEX(N'|' + r.Destino + N'|', c.Visitados) = 0
    )
    SELECT TOP (1)
        Camino,
        Tramos,
        Total AS KilometrosTotales
    FROM Caminos
    WHERE Actual = @Destino
    ORDER BY Total, Tramos
    OPTION (MAXRECURSION 100);
END
GO

-- Registra una ruta nueva validando todo antes
CREATE PROCEDURE sp_RegistrarRuta
    @Origen NVARCHAR(100),
    @Destino NVARCHAR(100),
    @Distancia DECIMAL(10,2),
    @TipoRuta NVARCHAR(100) = N'Ruta interdepartamental',
    @Fuente NVARCHAR(150) = N'Google Maps'
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM Departamentos WHERE Cabecera = @Origen)
        THROW 50003, N'El origen no es una cabecera registrada.', 1;

    IF NOT EXISTS (SELECT 1 FROM Departamentos WHERE Cabecera = @Destino)
        THROW 50004, N'El destino no es una cabecera registrada.', 1;

    IF @Distancia <= 0
        THROW 50006, N'La distancia tiene que ser mayor a cero.', 1;

    IF EXISTS (SELECT 1 FROM Rutas
               WHERE (Origen = @Origen AND Destino = @Destino)
                  OR (Origen = @Destino AND Destino = @Origen))
        THROW 50007, N'Esa ruta ya esta registrada.', 1;

    DECLARE @IdRuta INT;

    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO Rutas (Origen, Destino, Distancia, TipoRuta, Fuente, FechaConsulta)
        VALUES (@Origen, @Destino, @Distancia, @TipoRuta, @Fuente, CAST(GETDATE() AS DATE));

        SET @IdRuta = SCOPE_IDENTITY();

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        THROW;
    END CATCH

    SELECT * FROM vw_RutasDetalle WHERE IdRuta = @IdRuta;
END
GO

-- Cambia la distancia de una ruta, el cambio queda en la bitacora
CREATE PROCEDURE sp_ActualizarDistanciaRuta
    @IdRuta INT,
    @Distancia DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM Rutas WHERE IdRuta = @IdRuta)
        THROW 50008, N'Esa ruta no existe.', 1;

    IF @Distancia <= 0
        THROW 50006, N'La distancia tiene que ser mayor a cero.', 1;

    UPDATE Rutas
    SET Distancia = @Distancia,
        FechaConsulta = CAST(GETDATE() AS DATE)
    WHERE IdRuta = @IdRuta;

    SELECT * FROM vw_RutasDetalle WHERE IdRuta = @IdRuta;
END
GO

-- Numeros generales de toda la red
CREATE PROCEDURE sp_EstadisticasRed
AS
BEGIN
    SET NOCOUNT ON;

    -- Totales
    SELECT
        (SELECT COUNT(*) FROM Departamentos) AS Departamentos,
        (SELECT COUNT(*) FROM Municipios) AS Municipios,
        (SELECT SUM(CAST(Poblacion AS BIGINT)) FROM Municipios) AS PoblacionTotal,
        (SELECT COUNT(*) FROM Rutas) AS Rutas,
        (SELECT SUM(Distancia) FROM Rutas) AS KilometrosRegistrados;

    -- Ciudades con mas conexiones directas
    SELECT TOP (5)
        Origen AS Ciudad,
        COUNT(*) AS Conexiones
    FROM vw_RutasAmbosSentidos
    GROUP BY Origen
    ORDER BY COUNT(*) DESC, Origen;

    -- Tramo mas largo
    SELECT TOP (1) WITH TIES
        Origen, Destino, Distancia, TipoRuta
    FROM Rutas
    ORDER BY Distancia DESC;
END
GO
