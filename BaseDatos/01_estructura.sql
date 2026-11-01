-- Sistema Red Vial Guatemala
-- Crea la base desde cero, si ya existe la borra y la vuelve a crear
-- Despues de este correr los demas archivos en orden

USE master;
GO

IF DB_ID(N'BDRedVialGuatemala') IS NOT NULL
BEGIN
    ALTER DATABASE BDRedVialGuatemala SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE BDRedVialGuatemala;
END
GO

CREATE DATABASE BDRedVialGuatemala;
GO

USE BDRedVialGuatemala;
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

-- Tabla Departamentos
-- La cabecera es la ciudad que se usa en las rutas
CREATE TABLE Departamentos
(
    IdDepartamento     INT IDENTITY(1,1) NOT NULL,
    Nombre             NVARCHAR(100) NOT NULL,
    Cabecera           NVARCHAR(100) NOT NULL,
    DistanciaCapital   DECIMAL(10,2) NOT NULL,
    CantidadMunicipios INT NOT NULL CONSTRAINT DF_Departamentos_Cantidad DEFAULT 0,
    Region             NVARCHAR(100) NULL,

    CONSTRAINT PK_Departamentos PRIMARY KEY (IdDepartamento),
    CONSTRAINT UQ_Departamentos_Nombre UNIQUE (Nombre),
    CONSTRAINT UQ_Departamentos_Cabecera UNIQUE (Cabecera),
    CONSTRAINT CK_Departamentos_Distancia CHECK (DistanciaCapital >= 0),
    CONSTRAINT CK_Departamentos_Cantidad CHECK (CantidadMunicipios >= 0),
    CONSTRAINT CK_Departamentos_Region CHECK (Region IN (
        N'Metropolitana', N'Central', N'Norte', N'Nororiente',
        N'Suroriente', N'Suroccidente', N'Noroccidente'))
);
GO

-- Tabla Municipios
CREATE TABLE Municipios
(
    IdMunicipio       INT IDENTITY(1,1) NOT NULL,
    IdDepartamento    INT NOT NULL,
    Nombre            NVARCHAR(100) NOT NULL,
    Poblacion         INT NOT NULL,
    DistanciaCabecera DECIMAL(10,2) NOT NULL,

    CONSTRAINT PK_Municipios PRIMARY KEY (IdMunicipio),
    CONSTRAINT FK_Municipios_Departamentos
        FOREIGN KEY (IdDepartamento) REFERENCES Departamentos (IdDepartamento),
    CONSTRAINT UQ_Municipios_Departamento_Nombre UNIQUE (IdDepartamento, Nombre),
    CONSTRAINT CK_Municipios_Poblacion CHECK (Poblacion >= 0),
    CONSTRAINT CK_Municipios_Distancia CHECK (DistanciaCabecera >= 0)
);
GO

-- Tabla Rutas
-- Origen y destino tienen que ser cabeceras que existan
-- CiudadA y CiudadB ordenan el tramo para que no se repita al reves
CREATE TABLE Rutas
(
    IdRuta        INT IDENTITY(1,1) NOT NULL,
    Origen        NVARCHAR(100) NOT NULL,
    Destino       NVARCHAR(100) NOT NULL,
    Distancia     DECIMAL(10,2) NOT NULL,
    TipoRuta      NVARCHAR(100) NULL,
    Fuente        NVARCHAR(150) NULL,
    FechaConsulta DATE NULL CONSTRAINT DF_Rutas_FechaConsulta DEFAULT (CAST(GETDATE() AS DATE)),
    CiudadA AS (CASE WHEN Origen < Destino THEN Origen ELSE Destino END) PERSISTED,
    CiudadB AS (CASE WHEN Origen < Destino THEN Destino ELSE Origen END) PERSISTED,

    CONSTRAINT PK_Rutas PRIMARY KEY (IdRuta),
    CONSTRAINT FK_Rutas_Origen
        FOREIGN KEY (Origen) REFERENCES Departamentos (Cabecera),
    CONSTRAINT FK_Rutas_Destino
        FOREIGN KEY (Destino) REFERENCES Departamentos (Cabecera),
    CONSTRAINT UQ_Rutas_Tramo UNIQUE (CiudadA, CiudadB),
    CONSTRAINT CK_Rutas_Distancia CHECK (Distancia > 0),
    CONSTRAINT CK_Rutas_OrigenDestino CHECK (Origen <> Destino),
    CONSTRAINT CK_Rutas_Tipo CHECK (TipoRuta IN (
        N'Ruta principal', N'Ruta interdepartamental', N'Ruta alterna'))
);
GO

-- Tabla BitacoraRutas
-- Guarda cada alta, cambio o baja de una ruta
CREATE TABLE BitacoraRutas
(
    IdBitacora        INT IDENTITY(1,1) NOT NULL,
    IdRuta            INT NOT NULL,
    Accion            NVARCHAR(20) NOT NULL,
    Origen            NVARCHAR(100) NULL,
    Destino           NVARCHAR(100) NULL,
    DistanciaAnterior DECIMAL(10,2) NULL,
    DistanciaNueva    DECIMAL(10,2) NULL,
    Usuario           NVARCHAR(128) NOT NULL CONSTRAINT DF_Bitacora_Usuario DEFAULT (SUSER_SNAME()),
    Fecha             DATETIME2(0) NOT NULL CONSTRAINT DF_Bitacora_Fecha DEFAULT (SYSDATETIME()),

    CONSTRAINT PK_BitacoraRutas PRIMARY KEY (IdBitacora)
);
GO

-- Indices para las busquedas que mas hace el sistema
CREATE INDEX IX_Municipios_Nombre ON Municipios (Nombre);
CREATE INDEX IX_Rutas_Origen ON Rutas (Origen);
CREATE INDEX IX_Rutas_Destino ON Rutas (Destino);
GO
