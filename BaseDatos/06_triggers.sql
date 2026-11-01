-- Triggers

USE BDRedVialGuatemala;
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

-- Mantiene al dia la cantidad de municipios de cada departamento
CREATE TRIGGER trg_Municipios_Cantidad
ON Municipios
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE d
    SET CantidadMunicipios = (SELECT COUNT(*)
                              FROM Municipios m
                              WHERE m.IdDepartamento = d.IdDepartamento)
    FROM Departamentos d
    WHERE d.IdDepartamento IN (SELECT IdDepartamento FROM inserted
                               UNION
                               SELECT IdDepartamento FROM deleted);
END
GO

-- Anota en la bitacora cada alta, cambio o baja de rutas
CREATE TRIGGER trg_Rutas_Bitacora
ON Rutas
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO BitacoraRutas (IdRuta, Accion, Origen, Destino, DistanciaAnterior, DistanciaNueva)
    SELECT
        COALESCE(i.IdRuta, d.IdRuta),
        CASE
            WHEN i.IdRuta IS NOT NULL AND d.IdRuta IS NOT NULL THEN N'Modificación'
            WHEN i.IdRuta IS NOT NULL THEN N'Alta'
            ELSE N'Baja'
        END,
        COALESCE(i.Origen, d.Origen),
        COALESCE(i.Destino, d.Destino),
        d.Distancia,
        i.Distancia
    FROM inserted i
    FULL OUTER JOIN deleted d ON d.IdRuta = i.IdRuta;
END
GO
