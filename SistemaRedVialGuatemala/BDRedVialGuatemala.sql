CREATE DATABASE BDRedVialGuatemala;
GO
USE BDRedVialGuatemala;


USE BDRedVialGuatemala;
GO
--Julian Galvez 1
CREATE TABLE Departamentos
(
    IdDepartamento INT IDENTITY(1,1) NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    DistanciaCapital DECIMAL(10,2) NOT NULL,
    CantidadMunicipios INT NOT NULL,
    Region NVARCHAR(100) NULL,

    CONSTRAINT PK_Departamentos PRIMARY KEY (IdDepartamento)
);
GO

--Said Ojeda

CREATE TABLE Municipios
(
    IdMunicipio INT IDENTITY(1,1) NOT NULL,
    IdDepartamento INT NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Poblacion INT NOT NULL,
    DistanciaCabecera DECIMAL(10,2) NOT NULL,

    CONSTRAINT PK_Municipios PRIMARY KEY (IdMunicipio),
    CONSTRAINT FK_Municipios_Departamentos 
        FOREIGN KEY (IdDepartamento) 
        REFERENCES Departamentos(IdDepartamento)
);
GO
--- Josue Herrera 
CREATE   TABLE Rutas
(
    IdRuta INT IDENTITY(1,1) NOT NULL,
    Origen NVARCHAR(100) NOT NULL,
    Destino NVARCHAR(100) NOT NULL,
    Distancia DECIMAL(10,2) NOT NULL,
    TipoRuta NVARCHAR(100) NULL,
    

    CONSTRAINT PK_Rutas PRIMARY KEY (IdRuta)
);
GO
---en el nombre de dios   +





------INSERCION DE DEPTOS Julio y Benjas  11 y 11 cada quien



INSERT INTO Departamentos (Nombre, DistanciaCapital, CantidadMunicipios, Region)
VALUES
('Guatemala', 0.00, 17, 'Metropolitana'),
('El Progreso', 75.00, 8, 'Nororiente'),
('Sacatepéquez', 45.00, 16, 'Central'),
('Chimaltenango', 54.00, 16, 'Central'),
('Escuintla', 58.00, 14, 'Central'),
('Santa Rosa', 65.00, 14, 'Suroriente'),
('Sololá', 140.00, 19, 'Suroccidente'),
('Totonicapán', 203.00, 8, 'Suroccidente'),
('Quetzaltenango', 206.00, 24, 'Suroccidente'),
('Suchitepéquez', 165.00, 21, 'Suroccidente'),
('Retalhuleu', 190.00, 9, 'Suroccidente'),
('San Marcos', 252.00, 30, 'Suroccidente'),
('Huehuetenango', 266.00, 33, 'Noroccidente'),
('Quiché', 164.00, 21, 'Noroccidente'),
('Baja Verapaz', 151.00, 8, 'Norte'),
('Alta Verapaz', 219.00, 17, 'Norte'),
('Petén', 488.00, 14, 'Norte'),
('Izabal', 297.00, 5, 'Nororiente'),
('Zacapa', 148.00, 11, 'Nororiente'),
('Chiquimula', 174.00, 11, 'Nororiente'),
('Jalapa', 101.00, 7, 'Suroriente'),
('Jutiapa', 118.00, 17, 'Suroriente');
GO




SELECT * FROM Departamentos;

--- vamoa ver q los deptos hayan quedado tuanis donde correspinde solo id, name y no de municipios


SELECT IdDepartamento, Nombre, CantidadMunicipios
FROM Departamentos
ORDER BY IdDepartamento;



----------------------------------hacemos la prueba de fire pa insertar municipios de Guate ---------
--por id 

-------- GUATE - IdDepartamento 1

    INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
    VALUES
    (1, 'Guatemala', 995393, 0.00),
    (1, 'Santa Catarina Pinula', 80582, 11.00),
    (1, 'San José Pinula', 79844, 22.00),
    (1, 'San José del Golfo', 6924, 28.00),
    (1, 'Palencia', 70973, 30.00),
    (1, 'Chinautla', 98317, 12.00),
    (1, 'San Pedro Ayampuc', 49712, 23.00),
    (1, 'Mixco', 465773, 18.00),
    (1, 'San Pedro Sacatepéquez', 49589, 25.00),
    (1, 'San Juan Sacatepéquez', 218156, 31.00),
    (1, 'San Raymundo', 32456, 43.00),
    (1, 'Chuarrancho', 12638, 36.00),
    (1, 'Fraijanes', 58922, 27.00),
    (1, 'Amatitlán', 116711, 27.00),
    (1, 'Villa Nueva', 618397, 16.00),
    (1, 'Villa Canales', 155422, 22.00),
    (1, 'San Miguel Petapa', 135447, 20.00);
    GO







    ---------miramos que hay aquedado tuanis 


    SELECT *
FROM Municipios
WHERE IdDepartamento = 1;





INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES

-- EL PROGRESO - IdDepartamento 2
(2, 'Guastatoya', 24000, 0.00),
(2, 'Morazán', 12000, 31.00),
(2, 'San Agustín Acasaguastlán', 43000, 22.00),
(2, 'San Cristóbal Acasaguastlán', 9000, 29.00),
(2, 'El Jícaro', 12000, 31.00),
(2, 'Sansare', 14000, 27.00),
(2, 'Sanarate', 41000, 20.00),
(2, 'San Antonio La Paz', 23000, 34.00),

-- SACATEPÉQUEZ - IdDepartamento 3
(3, 'Antigua Guatemala', 46000, 0.00),
(3, 'Jocotenango', 21000, 3.00),
(3, 'Pastores', 17000, 6.00),
(3, 'Sumpango', 45000, 24.00),
(3, 'Santo Domingo Xenacoj', 11000, 29.00),
(3, 'Santiago Sacatepéquez', 28000, 17.00),
(3, 'San Bartolomé Milpas Altas', 9000, 12.00),
(3, 'San Lucas Sacatepéquez', 28000, 14.00),
(3, 'Santa Lucía Milpas Altas', 16000, 9.00),
(3, 'Magdalena Milpas Altas', 12000, 12.00),
(3, 'Santa María de Jesús', 22000, 10.00),
(3, 'Ciudad Vieja', 41000, 5.00),
(3, 'San Miguel Dueñas', 12000, 10.00),
(3, 'Alotenango', 28000, 12.00),
(3, 'San Antonio Aguas Calientes', 11000, 8.00),
(3, 'Santa Catarina Barahona', 4000, 9.00),

-- CHIMALTENANGO - IdDepartamento 4
(4, 'Chimaltenango', 120000, 0.00),
(4, 'San José Poaquil', 26000, 47.00),
(4, 'San Martín Jilotepeque', 87000, 23.00),
(4, 'San Juan Comalapa', 48000, 28.00),
(4, 'Santa Apolonia', 18000, 39.00),
(4, 'Tecpán Guatemala', 90000, 35.00),
(4, 'Patzún', 59000, 30.00),
(4, 'Pochuta', 13000, 70.00),
(4, 'Patzicía', 38000, 17.00),
(4, 'Santa Cruz Balanyá', 9000, 20.00),
(4, 'Acatenango', 24000, 32.00),
(4, 'Yepocapa', 36000, 41.00),
(4, 'San Andrés Itzapa', 32000, 7.00),
(4, 'Parramos', 16000, 7.00),
(4, 'Zaragoza', 30000, 13.00),
(4, 'El Tejar', 25000, 5.00),

-- ESCUINTLA - IdDepartamento 5
(5, 'Escuintla', 170000, 0.00),
(5, 'Santa Lucía Cotzumalguapa', 125000, 34.00),
(5, 'La Democracia', 25000, 35.00),
(5, 'Siquinalá', 24000, 25.00),
(5, 'Masagua', 45000, 15.00),
(5, 'Tiquisate', 62000, 90.00),
(5, 'La Gomera', 59000, 58.00),
(5, 'Guanagazapa', 18000, 26.00),
(5, 'San José', 55000, 51.00),
(5, 'Iztapa', 13000, 65.00),
(5, 'Palín', 72000, 17.00),
(5, 'San Vicente Pacaya', 17000, 25.00),
(5, 'Nueva Concepción', 69000, 95.00),
(5, 'Sipacate', 23000, 89.00);
GO

USE BDRedVialGuatemala;
GO





INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES

-- SANTA ROSA - IdDepartamento 6
(6, 'Cuilapa', 38000, 0.00),
(6, 'Barberena', 53000, 10.00),
(6, 'Santa Rosa de Lima', 18000, 29.00),
(6, 'Casillas', 25000, 39.00),
(6, 'San Rafael Las Flores', 13000, 52.00),
(6, 'Oratorio', 24000, 24.00),
(6, 'San Juan Tecuaco', 10000, 68.00),
(6, 'Chiquimulilla', 56000, 42.00),
(6, 'Taxisco', 23000, 55.00),
(6, 'Santa María Ixhuatán', 24000, 22.00),
(6, 'Guazacapán', 16000, 47.00),
(6, 'Santa Cruz Naranjo', 15000, 21.00),
(6, 'Pueblo Nuevo Viñas', 24000, 41.00),
(6, 'Nueva Santa Rosa', 36000, 29.00),

-- SOLOLÁ - IdDepartamento 7
(7, 'Sololá', 65000, 0.00),
(7, 'San José Chacayá', 6000, 7.00),
(7, 'Santa María Visitación', 3000, 15.00),
(7, 'Santa Lucía Utatlán', 25000, 12.00),
(7, 'Nahualá', 75000, 35.00),
(7, 'Santa Catarina Ixtahuacán', 50000, 40.00),
(7, 'Santa Clara La Laguna', 12000, 20.00),
(7, 'Concepción', 8000, 8.00),
(7, 'San Andrés Semetabaj', 14000, 17.00),
(7, 'Panajachel', 15000, 8.00),
(7, 'Santa Catarina Palopó', 6000, 12.00),
(7, 'San Antonio Palopó', 14000, 19.00),
(7, 'San Lucas Tolimán', 32000, 45.00),
(7, 'Santa Cruz La Laguna', 8000, 13.00),
(7, 'San Pablo La Laguna', 7000, 24.00),
(7, 'San Marcos La Laguna', 3000, 22.00),
(7, 'San Juan La Laguna', 13000, 25.00),
(7, 'San Pedro La Laguna', 12000, 27.00),
(7, 'Santiago Atitlán', 50000, 50.00),

-- TOTONICAPÁN - IdDepartamento 8
(8, 'Totonicapán', 135000, 0.00),
(8, 'San Cristóbal Totonicapán', 38000, 12.00),
(8, 'San Francisco El Alto', 65000, 18.00),
(8, 'San Andrés Xecul', 35000, 16.00),
(8, 'Momostenango', 120000, 36.00),
(8, 'Santa María Chiquimula', 45000, 20.00),
(8, 'Santa Lucía La Reforma', 25000, 44.00),
(8, 'San Bartolo', 15000, 45.00),

-- QUETZALTENANGO - IdDepartamento 9
(9, 'Quetzaltenango', 180000, 0.00),
(9, 'Salcajá', 19000, 9.00),
(9, 'Olintepeque', 38000, 8.00),
(9, 'San Carlos Sija', 42000, 24.00),
(9, 'Sibilia', 9000, 33.00),
(9, 'Cabricán', 25000, 45.00),
(9, 'Cajolá', 22000, 18.00),
(9, 'San Miguel Sigüilá', 9000, 15.00),
(9, 'San Juan Ostuncalco', 60000, 14.00),
(9, 'San Mateo', 10000, 10.00),
(9, 'Concepción Chiquirichapa', 22000, 17.00),
(9, 'San Martín Sacatepéquez', 32000, 24.00),
(9, 'Almolonga', 18000, 5.00),
(9, 'Cantel', 42000, 12.00),
(9, 'Huitán', 14000, 42.00),
(9, 'Zunil', 15000, 9.00),
(9, 'Colomba', 45000, 44.00),
(9, 'San Francisco La Unión', 12000, 18.00),
(9, 'El Palmar', 28000, 35.00),
(9, 'Coatepeque', 110000, 60.00),
(9, 'Génova', 40000, 72.00),
(9, 'Flores Costa Cuca', 22000, 55.00),
(9, 'La Esperanza', 32000, 6.00),
(9, 'Palestina de Los Altos', 14000, 32.00),

-- SUCHITEPÉQUEZ - IdDepartamento 10
(10, 'Mazatenango', 103000, 0.00),
(10, 'Cuyotenango', 52000, 8.00),
(10, 'San Francisco Zapotitlán', 21000, 7.00),
(10, 'San Bernardino', 15000, 6.00),
(10, 'San José El Ídolo', 11000, 22.00),
(10, 'Santo Domingo Suchitepéquez', 38000, 7.00),
(10, 'San Lorenzo', 15000, 9.00),
(10, 'Samayac', 23000, 7.00),
(10, 'San Pablo Jocopilas', 22000, 9.00),
(10, 'San Antonio Suchitepéquez', 55000, 10.00),
(10, 'San Miguel Panán', 9000, 20.00),
(10, 'San Gabriel', 7000, 3.00),
(10, 'Chicacao', 50000, 38.00),
(10, 'Patulul', 40000, 55.00),
(10, 'Santa Bárbara', 25000, 40.00),
(10, 'San Juan Bautista', 11000, 45.00),
(10, 'Santo Tomás La Unión', 13000, 18.00),
(10, 'Zunilito', 9000, 12.00),
(10, 'Pueblo Nuevo', 14000, 16.00),
(10, 'Río Bravo', 25000, 36.00),
(10, 'San José La Máquina', 28000, 42.00);
GO






INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES

-- RETALHULEU - IdDepartamento 11
(11, 'Retalhuleu', 90000, 0.00),
(11, 'San Sebastián', 32000, 4.00),
(11, 'Santa Cruz Muluá', 13000, 9.00),
(11, 'San Martín Zapotitlán', 13000, 12.00),
(11, 'San Felipe', 28000, 15.00),
(11, 'San Andrés Villa Seca', 42000, 20.00),
(11, 'Champerico', 37000, 39.00),
(11, 'Nuevo San Carlos', 36000, 24.00),
(11, 'El Asintal', 42000, 18.00),

-- SAN MARCOS - IdDepartamento 12
(12, 'San Marcos', 60000, 0.00),
(12, 'San Pedro Sacatepéquez', 79000, 2.00),
(12, 'San Antonio Sacatepéquez', 22000, 9.00),
(12, 'Comitancillo', 80000, 34.00),
(12, 'San Miguel Ixtahuacán', 42000, 65.00),
(12, 'Concepción Tutuapa', 75000, 63.00),
(12, 'Tacaná', 95000, 72.00),
(12, 'Sibinal', 18000, 80.00),
(12, 'Tajumulco', 52000, 45.00),
(12, 'Tejutla', 38000, 32.00),
(12, 'San Rafael Pie de la Cuesta', 17000, 28.00),
(12, 'Nuevo Progreso', 42000, 55.00),
(12, 'El Tumbador', 50000, 50.00),
(12, 'El Rodeo', 22000, 40.00),
(12, 'Malacatán', 110000, 52.00),
(12, 'Catarina', 35000, 58.00),
(12, 'Ayutla', 46000, 78.00),
(12, 'Ocós', 18000, 92.00),
(12, 'San Pablo', 55000, 45.00),
(12, 'El Quetzal', 27000, 42.00),
(12, 'La Reforma', 22000, 44.00),
(12, 'Pajapita', 25000, 70.00),
(12, 'Ixchiguán', 28000, 58.00),
(12, 'San José Ojetenam', 21000, 54.00),
(12, 'San Cristóbal Cucho', 19000, 10.00),
(12, 'Sipacapa', 19000, 50.00),
(12, 'Esquipulas Palo Gordo', 13000, 7.00),
(12, 'Río Blanco', 8000, 12.00),
(12, 'San Lorenzo', 13000, 9.00),
(12, 'La Blanca', 32000, 94.00),

-- HUEHUETENANGO - IdDepartamento 13
(13, 'Huehuetenango', 120000, 0.00),
(13, 'Chiantla', 105000, 7.00),
(13, 'Malacatancito', 23000, 18.00),
(13, 'Cuilco', 65000, 75.00),
(13, 'Nentón', 45000, 120.00),
(13, 'San Pedro Necta', 40000, 55.00),
(13, 'Jacaltenango', 45000, 115.00),
(13, 'Soloma', 60000, 75.00),
(13, 'San Ildefonso Ixtahuacán', 42000, 48.00),
(13, 'Santa Bárbara', 28000, 25.00),
(13, 'La Libertad', 43000, 65.00),
(13, 'La Democracia', 52000, 72.00),
(13, 'San Miguel Acatán', 32000, 124.00),
(13, 'San Rafael La Independencia', 14000, 104.00),
(13, 'Todos Santos Cuchumatán', 40000, 45.00),
(13, 'San Juan Atitán', 25000, 36.00),
(13, 'Santa Eulalia', 55000, 88.00),
(13, 'San Mateo Ixtatán', 43000, 125.00),
(13, 'Colotenango', 38000, 36.00),
(13, 'San Sebastián Huehuetenango', 30000, 23.00),
(13, 'Tectitán', 9000, 105.00),
(13, 'Concepción Huista', 24000, 110.00),
(13, 'San Juan Ixcoy', 33000, 75.00),
(13, 'San Antonio Huista', 18000, 98.00),
(13, 'San Sebastián Coatán', 27000, 108.00),
(13, 'Barillas', 130000, 150.00),
(13, 'Aguacatán', 57000, 24.00),
(13, 'San Rafael Petzal', 10000, 30.00),
(13, 'San Gaspar Ixchil', 8000, 44.00),
(13, 'Santiago Chimaltenango', 9000, 68.00),
(13, 'Santa Ana Huista', 10000, 95.00),
(13, 'Unión Cantinil', 18000, 78.00),
(13, 'Petatán', 17000, 100.00),

-- QUICHÉ - IdDepartamento 14
(14, 'Santa Cruz del Quiché', 95000, 0.00),
(14, 'Chiché', 35000, 11.00),
(14, 'Chinique', 13000, 20.00),
(14, 'Zacualpa', 45000, 41.00),
(14, 'Chajul', 70000, 110.00),
(14, 'Chichicastenango', 145000, 18.00),
(14, 'Patzité', 7000, 12.00),
(14, 'San Antonio Ilotenango', 25000, 15.00),
(14, 'San Pedro Jocopilas', 35000, 10.00),
(14, 'Cunén', 50000, 68.00),
(14, 'San Juan Cotzal', 35000, 105.00),
(14, 'Joyabaj', 85000, 53.00),
(14, 'Nebaj', 95000, 85.00),
(14, 'San Andrés Sajcabajá', 32000, 36.00),
(14, 'Uspantán', 85000, 98.00),
(14, 'Sacapulas', 55000, 50.00),
(14, 'San Bartolomé Jocotenango', 12000, 38.00),
(14, 'Canillá', 14000, 70.00),
(14, 'Chicamán', 42000, 78.00),
(14, 'Ixcán', 110000, 170.00),
(14, 'Pachalum', 12000, 78.00),

-- BAJA VERAPAZ - IdDepartamento 15
(15, 'Salamá', 65000, 0.00),
(15, 'San Miguel Chicaj', 30000, 9.00),
(15, 'Rabinal', 45000, 27.00),
(15, 'Cubulco', 65000, 47.00),
(15, 'Granados', 14000, 64.00),
(15, 'Santa Cruz el Chol', 12000, 52.00),
(15, 'San Jerónimo', 25000, 10.00),
(15, 'Purulhá', 46000, 50.00);
GO





-------------------------------






INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES

-- ALTA VERAPAZ - IdDepartamento 16
(16, 'Cobán', 250000, 0.00),
(16, 'Santa Cruz Verapaz', 35000, 15.00),
(16, 'San Cristóbal Verapaz', 70000, 24.00),
(16, 'Tactic', 40000, 30.00),
(16, 'Tamahú', 18000, 43.00),
(16, 'Tucurú', 45000, 60.00),
(16, 'Panzós', 65000, 127.00),
(16, 'Senahú', 80000, 98.00),
(16, 'San Pedro Carchá', 260000, 8.00),
(16, 'San Juan Chamelco', 75000, 8.00),
(16, 'Lanquín', 35000, 63.00),
(16, 'Cahabón', 70000, 95.00),
(16, 'Chisec', 95000, 82.00),
(16, 'Chahal', 30000, 150.00),
(16, 'Fray Bartolomé de las Casas', 75000, 110.00),
(16, 'Santa Catalina La Tinta', 45000, 93.00),
(16, 'Raxruhá', 45000, 120.00),

-- PETÉN - IdDepartamento 17
(17, 'Flores', 65000, 0.00),
(17, 'San José', 7000, 23.00),
(17, 'San Benito', 75000, 2.00),
(17, 'San Andrés', 55000, 22.00),
(17, 'La Libertad', 90000, 32.00),
(17, 'San Francisco', 18000, 18.00),
(17, 'Santa Ana', 30000, 21.00),
(17, 'Dolores', 65000, 80.00),
(17, 'San Luis', 85000, 118.00),
(17, 'Sayaxché', 120000, 65.00),
(17, 'Melchor de Mencos', 25000, 93.00),
(17, 'Poptún', 75000, 100.00),
(17, 'Las Cruces', 40000, 75.00),
(17, 'El Chal', 35000, 45.00),

-- IZABAL - IdDepartamento 18
(18, 'Puerto Barrios', 110000, 0.00),
(18, 'Livingston', 65000, 30.00),
(18, 'El Estor', 90000, 120.00),
(18, 'Morales', 110000, 55.00),
(18, 'Los Amates', 65000, 95.00),

-- ZACAPA - IdDepartamento 19
(19, 'Zacapa', 80000, 0.00),
(19, 'Estanzuela', 12000, 8.00),
(19, 'Río Hondo', 20000, 14.00),
(19, 'Gualán', 45000, 36.00),
(19, 'Teculután', 18000, 29.00),
(19, 'Usumatlán', 12000, 40.00),
(19, 'Cabañas', 12000, 35.00),
(19, 'San Diego', 7000, 65.00),
(19, 'La Unión', 30000, 75.00),
(19, 'Huité', 10000, 52.00),
(19, 'San Jorge', 8000, 10.00),

-- CHIQUIMULA - IdDepartamento 20
(20, 'Chiquimula', 100000, 0.00),
(20, 'San José La Arada', 9000, 13.00),
(20, 'San Juan Ermita', 14000, 20.00),
(20, 'Jocotán', 65000, 32.00),
(20, 'Camotán', 65000, 36.00),
(20, 'Olopa', 28000, 43.00),
(20, 'Esquipulas', 65000, 52.00),
(20, 'Concepción Las Minas', 15000, 56.00),
(20, 'Quezaltepeque', 28000, 26.00),
(20, 'San Jacinto', 12000, 17.00),
(20, 'Ipala', 25000, 34.00),

-- JALAPA - IdDepartamento 21
(21, 'Jalapa', 160000, 0.00),
(21, 'San Pedro Pinula', 70000, 20.00),
(21, 'San Luis Jilotepeque', 30000, 42.00),
(21, 'San Manuel Chaparrón', 12000, 35.00),
(21, 'San Carlos Alzatate', 20000, 50.00),
(21, 'Monjas', 30000, 23.00),
(21, 'Mataquescuintla', 45000, 42.00),

-- JUTIAPA - IdDepartamento 22
(22, 'Jutiapa', 160000, 0.00),
(22, 'El Progreso', 22000, 11.00),
(22, 'Santa Catarina Mita', 30000, 34.00),
(22, 'Agua Blanca', 18000, 42.00),
(22, 'Asunción Mita', 50000, 30.00),
(22, 'Yupiltepeque', 18000, 22.00),
(22, 'Atescatempa', 16000, 34.00),
(22, 'Jerez', 7000, 45.00),
(22, 'El Adelanto', 6000, 26.00),
(22, 'Zapotitlán', 9000, 32.00),
(22, 'Comapa', 40000, 41.00),
(22, 'Jalpatagua', 28000, 42.00),
(22, 'Conguaco', 22000, 62.00),
(22, 'Moyuta', 45000, 55.00),
(22, 'Pasaco', 10000, 90.00),
(22, 'San José Acatempa', 13000, 28.00),
(22, 'Quesada', 22000, 18.00);
GO
-------------------------------

SELECT IdDepartamento, COUNT(*) AS CantidadMunicipios
FROM Municipios
GROUP BY IdDepartamento
ORDER BY IdDepartamento;



-----total de munis
SELECT COUNT(*) AS TotalMunicipios
FROM Municipios;





------------------------------------------PARA LAS RUTAS 

---a josue se le olvido poner estos dos campos en la tabla

ALTER TABLE Rutas
ADD Fuente NVARCHAR(150) NULL,
    FechaConsulta DATE NULL;
GO



--Se insertan las rutas , Julio busca en waze o google maps


USE BDRedVialGuatemala;
GO

INSERT INTO Rutas (Origen, Destino, Distancia, TipoRuta, Fuente, FechaConsulta)
VALUES
('Ciudad de Guatemala', 'Antigua Guatemala', 40.00, 'Ruta principal', 'Google Maps', '2026-05-27'),
('Ciudad de Guatemala', 'Chimaltenango', 54.00, 'Ruta principal', 'Google Maps', '2026-05-27'),
('Ciudad de Guatemala', 'Escuintla', 58.00, 'Ruta principal', 'Google Maps', '2026-05-27'),
('Ciudad de Guatemala', 'Cuilapa', 64.00, 'Ruta principal', 'Google Maps', '2026-05-27'),
('Ciudad de Guatemala', 'Guastatoya', 75.00, 'Ruta principal', 'Google Maps', '2026-05-27'),
('Ciudad de Guatemala', 'Jalapa', 101.00, 'Ruta principal', 'Google Maps', '2026-05-27'),
('Ciudad de Guatemala', 'Jutiapa', 118.00, 'Ruta principal', 'Google Maps', '2026-05-27'),

('Antigua Guatemala', 'Chimaltenango', 22.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Chimaltenango', 'Sololá', 86.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Sololá', 'Totonicapán', 63.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Totonicapán', 'Quetzaltenango', 28.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Quetzaltenango', 'San Marcos', 50.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Quetzaltenango', 'Retalhuleu', 74.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Retalhuleu', 'Mazatenango', 38.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Mazatenango', 'Escuintla', 110.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),

('Guastatoya', 'Zacapa', 73.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Zacapa', 'Chiquimula', 31.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Chiquimula', 'Jutiapa', 73.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Jalapa', 'Jutiapa', 39.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Jalapa', 'Chiquimula', 84.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Cuilapa', 'Jutiapa', 54.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Cuilapa', 'Escuintla', 82.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),

('Guastatoya', 'Salamá', 85.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Salamá', 'Cobán', 70.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Cobán', 'Flores', 269.00, 'Ruta principal', 'Google Maps', '2026-05-27'),
('Cobán', 'Puerto Barrios', 185.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Zacapa', 'Puerto Barrios', 149.00, 'Ruta principal', 'Google Maps', '2026-05-27'),

('Santa Cruz del Quiché', 'Chimaltenango', 110.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Santa Cruz del Quiché', 'Sololá', 82.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Santa Cruz del Quiché', 'Huehuetenango', 102.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Huehuetenango', 'San Marcos', 96.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),
('Huehuetenango', 'Quetzaltenango', 90.00, 'Ruta interdepartamental', 'Google Maps', '2026-05-27'),

('Flores', 'Puerto Barrios', 330.00, 'Ruta alterna', 'Google Maps', '2026-05-27');
GO


SELECT * from Rutas;

