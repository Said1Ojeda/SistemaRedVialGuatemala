-- Funciones

USE BDRedVialGuatemala;
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

-- Distancia aproximada de la capital a un municipio
-- Suma lo que hay de la capital a la cabecera y de la cabecera al municipio
CREATE FUNCTION fn_DistanciaCapitalMunicipio (@IdMunicipio INT)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @Distancia DECIMAL(10,2);

    SELECT @Distancia = d.DistanciaCapital + m.DistanciaCabecera
    FROM Municipios m
    INNER JOIN Departamentos d ON d.IdDepartamento = m.IdDepartamento
    WHERE m.IdMunicipio = @IdMunicipio;

    RETURN @Distancia;
END
GO

-- Ciudades a las que se llega directo desde una ciudad
CREATE FUNCTION fn_ConexionesDesde (@Ciudad NVARCHAR(100))
RETURNS TABLE
AS
RETURN
(
    SELECT Destino, Distancia, TipoRuta
    FROM vw_RutasAmbosSentidos
    WHERE Origen = @Ciudad
);
GO
