-- Datos del sistema
-- 22 departamentos, 340 municipios y 33 rutas
-- Las distancias de las rutas se tomaron de Google Maps

USE BDRedVialGuatemala;
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

-- Departamentos
-- Se ponen los id a mano para que los municipios caigan en su departamento
SET IDENTITY_INSERT Departamentos ON;

INSERT INTO Departamentos (IdDepartamento, Nombre, Cabecera, DistanciaCapital, CantidadMunicipios, Region)
VALUES
    (1, N'Guatemala', N'Ciudad de Guatemala', 0.00, 17, N'Metropolitana'),
    (2, N'El Progreso', N'Guastatoya', 75.00, 8, N'Nororiente'),
    (3, N'Sacatepéquez', N'Antigua Guatemala', 45.00, 16, N'Central'),
    (4, N'Chimaltenango', N'Chimaltenango', 54.00, 16, N'Central'),
    (5, N'Escuintla', N'Escuintla', 58.00, 14, N'Central'),
    (6, N'Santa Rosa', N'Cuilapa', 65.00, 14, N'Suroriente'),
    (7, N'Sololá', N'Sololá', 140.00, 19, N'Suroccidente'),
    (8, N'Totonicapán', N'Totonicapán', 203.00, 8, N'Suroccidente'),
    (9, N'Quetzaltenango', N'Quetzaltenango', 206.00, 24, N'Suroccidente'),
    (10, N'Suchitepéquez', N'Mazatenango', 165.00, 21, N'Suroccidente'),
    (11, N'Retalhuleu', N'Retalhuleu', 190.00, 9, N'Suroccidente'),
    (12, N'San Marcos', N'San Marcos', 252.00, 30, N'Suroccidente'),
    (13, N'Huehuetenango', N'Huehuetenango', 266.00, 33, N'Noroccidente'),
    (14, N'Quiché', N'Santa Cruz del Quiché', 164.00, 21, N'Noroccidente'),
    (15, N'Baja Verapaz', N'Salamá', 151.00, 8, N'Norte'),
    (16, N'Alta Verapaz', N'Cobán', 219.00, 17, N'Norte'),
    (17, N'Petén', N'Flores', 488.00, 14, N'Norte'),
    (18, N'Izabal', N'Puerto Barrios', 297.00, 5, N'Nororiente'),
    (19, N'Zacapa', N'Zacapa', 148.00, 11, N'Nororiente'),
    (20, N'Chiquimula', N'Chiquimula', 174.00, 11, N'Nororiente'),
    (21, N'Jalapa', N'Jalapa', 101.00, 7, N'Suroriente'),
    (22, N'Jutiapa', N'Jutiapa', 118.00, 17, N'Suroriente');

SET IDENTITY_INSERT Departamentos OFF;
GO

-- Municipios por departamento

-- GUATEMALA
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (1, N'Guatemala', 995393, 0.00),
    (1, N'Santa Catarina Pinula', 80582, 11.00),
    (1, N'San José Pinula', 79844, 22.00),
    (1, N'San José del Golfo', 6924, 28.00),
    (1, N'Palencia', 70973, 30.00),
    (1, N'Chinautla', 98317, 12.00),
    (1, N'San Pedro Ayampuc', 49712, 23.00),
    (1, N'Mixco', 465773, 18.00),
    (1, N'San Pedro Sacatepéquez', 49589, 25.00),
    (1, N'San Juan Sacatepéquez', 218156, 31.00),
    (1, N'San Raymundo', 32456, 43.00),
    (1, N'Chuarrancho', 12638, 36.00),
    (1, N'Fraijanes', 58922, 27.00),
    (1, N'Amatitlán', 116711, 27.00),
    (1, N'Villa Nueva', 618397, 16.00),
    (1, N'Villa Canales', 155422, 22.00),
    (1, N'San Miguel Petapa', 135447, 20.00);

-- EL PROGRESO
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (2, N'Guastatoya', 24000, 0.00),
    (2, N'Morazán', 12000, 31.00),
    (2, N'San Agustín Acasaguastlán', 43000, 22.00),
    (2, N'San Cristóbal Acasaguastlán', 9000, 29.00),
    (2, N'El Jícaro', 12000, 31.00),
    (2, N'Sansare', 14000, 27.00),
    (2, N'Sanarate', 41000, 20.00),
    (2, N'San Antonio La Paz', 23000, 34.00);

-- SACATEPEQUEZ
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (3, N'Antigua Guatemala', 46000, 0.00),
    (3, N'Jocotenango', 21000, 3.00),
    (3, N'Pastores', 17000, 6.00),
    (3, N'Sumpango', 45000, 24.00),
    (3, N'Santo Domingo Xenacoj', 11000, 29.00),
    (3, N'Santiago Sacatepéquez', 28000, 17.00),
    (3, N'San Bartolomé Milpas Altas', 9000, 12.00),
    (3, N'San Lucas Sacatepéquez', 28000, 14.00),
    (3, N'Santa Lucía Milpas Altas', 16000, 9.00),
    (3, N'Magdalena Milpas Altas', 12000, 12.00),
    (3, N'Santa María de Jesús', 22000, 10.00),
    (3, N'Ciudad Vieja', 41000, 5.00),
    (3, N'San Miguel Dueñas', 12000, 10.00),
    (3, N'Alotenango', 28000, 12.00),
    (3, N'San Antonio Aguas Calientes', 11000, 8.00),
    (3, N'Santa Catarina Barahona', 4000, 9.00);

-- CHIMALTENANGO
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (4, N'Chimaltenango', 120000, 0.00),
    (4, N'San José Poaquil', 26000, 47.00),
    (4, N'San Martín Jilotepeque', 87000, 23.00),
    (4, N'San Juan Comalapa', 48000, 28.00),
    (4, N'Santa Apolonia', 18000, 39.00),
    (4, N'Tecpán Guatemala', 90000, 35.00),
    (4, N'Patzún', 59000, 30.00),
    (4, N'Pochuta', 13000, 70.00),
    (4, N'Patzicía', 38000, 17.00),
    (4, N'Santa Cruz Balanyá', 9000, 20.00),
    (4, N'Acatenango', 24000, 32.00),
    (4, N'Yepocapa', 36000, 41.00),
    (4, N'San Andrés Itzapa', 32000, 7.00),
    (4, N'Parramos', 16000, 7.00),
    (4, N'Zaragoza', 30000, 13.00),
    (4, N'El Tejar', 25000, 5.00);

-- ESCUINTLA
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (5, N'Escuintla', 170000, 0.00),
    (5, N'Santa Lucía Cotzumalguapa', 125000, 34.00),
    (5, N'La Democracia', 25000, 35.00),
    (5, N'Siquinalá', 24000, 25.00),
    (5, N'Masagua', 45000, 15.00),
    (5, N'Tiquisate', 62000, 90.00),
    (5, N'La Gomera', 59000, 58.00),
    (5, N'Guanagazapa', 18000, 26.00),
    (5, N'San José', 55000, 51.00),
    (5, N'Iztapa', 13000, 65.00),
    (5, N'Palín', 72000, 17.00),
    (5, N'San Vicente Pacaya', 17000, 25.00),
    (5, N'Nueva Concepción', 69000, 95.00),
    (5, N'Sipacate', 23000, 89.00);

-- SANTA ROSA
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (6, N'Cuilapa', 38000, 0.00),
    (6, N'Barberena', 53000, 10.00),
    (6, N'Santa Rosa de Lima', 18000, 29.00),
    (6, N'Casillas', 25000, 39.00),
    (6, N'San Rafael Las Flores', 13000, 52.00),
    (6, N'Oratorio', 24000, 24.00),
    (6, N'San Juan Tecuaco', 10000, 68.00),
    (6, N'Chiquimulilla', 56000, 42.00),
    (6, N'Taxisco', 23000, 55.00),
    (6, N'Santa María Ixhuatán', 24000, 22.00),
    (6, N'Guazacapán', 16000, 47.00),
    (6, N'Santa Cruz Naranjo', 15000, 21.00),
    (6, N'Pueblo Nuevo Viñas', 24000, 41.00),
    (6, N'Nueva Santa Rosa', 36000, 29.00);

-- SOLOLA
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (7, N'Sololá', 65000, 0.00),
    (7, N'San José Chacayá', 6000, 7.00),
    (7, N'Santa María Visitación', 3000, 15.00),
    (7, N'Santa Lucía Utatlán', 25000, 12.00),
    (7, N'Nahualá', 75000, 35.00),
    (7, N'Santa Catarina Ixtahuacán', 50000, 40.00),
    (7, N'Santa Clara La Laguna', 12000, 20.00),
    (7, N'Concepción', 8000, 8.00),
    (7, N'San Andrés Semetabaj', 14000, 17.00),
    (7, N'Panajachel', 15000, 8.00),
    (7, N'Santa Catarina Palopó', 6000, 12.00),
    (7, N'San Antonio Palopó', 14000, 19.00),
    (7, N'San Lucas Tolimán', 32000, 45.00),
    (7, N'Santa Cruz La Laguna', 8000, 13.00),
    (7, N'San Pablo La Laguna', 7000, 24.00),
    (7, N'San Marcos La Laguna', 3000, 22.00),
    (7, N'San Juan La Laguna', 13000, 25.00),
    (7, N'San Pedro La Laguna', 12000, 27.00),
    (7, N'Santiago Atitlán', 50000, 50.00);

-- TOTONICAPAN
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (8, N'Totonicapán', 135000, 0.00),
    (8, N'San Cristóbal Totonicapán', 38000, 12.00),
    (8, N'San Francisco El Alto', 65000, 18.00),
    (8, N'San Andrés Xecul', 35000, 16.00),
    (8, N'Momostenango', 120000, 36.00),
    (8, N'Santa María Chiquimula', 45000, 20.00),
    (8, N'Santa Lucía La Reforma', 25000, 44.00),
    (8, N'San Bartolo', 15000, 45.00);

-- QUETZALTENANGO
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (9, N'Quetzaltenango', 180000, 0.00),
    (9, N'Salcajá', 19000, 9.00),
    (9, N'Olintepeque', 38000, 8.00),
    (9, N'San Carlos Sija', 42000, 24.00),
    (9, N'Sibilia', 9000, 33.00),
    (9, N'Cabricán', 25000, 45.00),
    (9, N'Cajolá', 22000, 18.00),
    (9, N'San Miguel Sigüilá', 9000, 15.00),
    (9, N'San Juan Ostuncalco', 60000, 14.00),
    (9, N'San Mateo', 10000, 10.00),
    (9, N'Concepción Chiquirichapa', 22000, 17.00),
    (9, N'San Martín Sacatepéquez', 32000, 24.00),
    (9, N'Almolonga', 18000, 5.00),
    (9, N'Cantel', 42000, 12.00),
    (9, N'Huitán', 14000, 42.00),
    (9, N'Zunil', 15000, 9.00),
    (9, N'Colomba', 45000, 44.00),
    (9, N'San Francisco La Unión', 12000, 18.00),
    (9, N'El Palmar', 28000, 35.00),
    (9, N'Coatepeque', 110000, 60.00),
    (9, N'Génova', 40000, 72.00),
    (9, N'Flores Costa Cuca', 22000, 55.00),
    (9, N'La Esperanza', 32000, 6.00),
    (9, N'Palestina de Los Altos', 14000, 32.00);

-- SUCHITEPEQUEZ
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (10, N'Mazatenango', 103000, 0.00),
    (10, N'Cuyotenango', 52000, 8.00),
    (10, N'San Francisco Zapotitlán', 21000, 7.00),
    (10, N'San Bernardino', 15000, 6.00),
    (10, N'San José El Ídolo', 11000, 22.00),
    (10, N'Santo Domingo Suchitepéquez', 38000, 7.00),
    (10, N'San Lorenzo', 15000, 9.00),
    (10, N'Samayac', 23000, 7.00),
    (10, N'San Pablo Jocopilas', 22000, 9.00),
    (10, N'San Antonio Suchitepéquez', 55000, 10.00),
    (10, N'San Miguel Panán', 9000, 20.00),
    (10, N'San Gabriel', 7000, 3.00),
    (10, N'Chicacao', 50000, 38.00),
    (10, N'Patulul', 40000, 55.00),
    (10, N'Santa Bárbara', 25000, 40.00),
    (10, N'San Juan Bautista', 11000, 45.00),
    (10, N'Santo Tomás La Unión', 13000, 18.00),
    (10, N'Zunilito', 9000, 12.00),
    (10, N'Pueblo Nuevo', 14000, 16.00),
    (10, N'Río Bravo', 25000, 36.00),
    (10, N'San José La Máquina', 28000, 42.00);

-- RETALHULEU
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (11, N'Retalhuleu', 90000, 0.00),
    (11, N'San Sebastián', 32000, 4.00),
    (11, N'Santa Cruz Muluá', 13000, 9.00),
    (11, N'San Martín Zapotitlán', 13000, 12.00),
    (11, N'San Felipe', 28000, 15.00),
    (11, N'San Andrés Villa Seca', 42000, 20.00),
    (11, N'Champerico', 37000, 39.00),
    (11, N'Nuevo San Carlos', 36000, 24.00),
    (11, N'El Asintal', 42000, 18.00);

-- SAN MARCOS
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (12, N'San Marcos', 60000, 0.00),
    (12, N'San Pedro Sacatepéquez', 79000, 2.00),
    (12, N'San Antonio Sacatepéquez', 22000, 9.00),
    (12, N'Comitancillo', 80000, 34.00),
    (12, N'San Miguel Ixtahuacán', 42000, 65.00),
    (12, N'Concepción Tutuapa', 75000, 63.00),
    (12, N'Tacaná', 95000, 72.00),
    (12, N'Sibinal', 18000, 80.00),
    (12, N'Tajumulco', 52000, 45.00),
    (12, N'Tejutla', 38000, 32.00),
    (12, N'San Rafael Pie de la Cuesta', 17000, 28.00),
    (12, N'Nuevo Progreso', 42000, 55.00),
    (12, N'El Tumbador', 50000, 50.00),
    (12, N'El Rodeo', 22000, 40.00),
    (12, N'Malacatán', 110000, 52.00),
    (12, N'Catarina', 35000, 58.00),
    (12, N'Ayutla', 46000, 78.00),
    (12, N'Ocós', 18000, 92.00),
    (12, N'San Pablo', 55000, 45.00),
    (12, N'El Quetzal', 27000, 42.00),
    (12, N'La Reforma', 22000, 44.00),
    (12, N'Pajapita', 25000, 70.00),
    (12, N'Ixchiguán', 28000, 58.00),
    (12, N'San José Ojetenam', 21000, 54.00),
    (12, N'San Cristóbal Cucho', 19000, 10.00),
    (12, N'Sipacapa', 19000, 50.00),
    (12, N'Esquipulas Palo Gordo', 13000, 7.00),
    (12, N'Río Blanco', 8000, 12.00),
    (12, N'San Lorenzo', 13000, 9.00),
    (12, N'La Blanca', 32000, 94.00);

-- HUEHUETENANGO
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (13, N'Huehuetenango', 120000, 0.00),
    (13, N'Chiantla', 105000, 7.00),
    (13, N'Malacatancito', 23000, 18.00),
    (13, N'Cuilco', 65000, 75.00),
    (13, N'Nentón', 45000, 120.00),
    (13, N'San Pedro Necta', 40000, 55.00),
    (13, N'Jacaltenango', 45000, 115.00),
    (13, N'Soloma', 60000, 75.00),
    (13, N'San Ildefonso Ixtahuacán', 42000, 48.00),
    (13, N'Santa Bárbara', 28000, 25.00),
    (13, N'La Libertad', 43000, 65.00),
    (13, N'La Democracia', 52000, 72.00),
    (13, N'San Miguel Acatán', 32000, 124.00),
    (13, N'San Rafael La Independencia', 14000, 104.00),
    (13, N'Todos Santos Cuchumatán', 40000, 45.00),
    (13, N'San Juan Atitán', 25000, 36.00),
    (13, N'Santa Eulalia', 55000, 88.00),
    (13, N'San Mateo Ixtatán', 43000, 125.00),
    (13, N'Colotenango', 38000, 36.00),
    (13, N'San Sebastián Huehuetenango', 30000, 23.00),
    (13, N'Tectitán', 9000, 105.00),
    (13, N'Concepción Huista', 24000, 110.00),
    (13, N'San Juan Ixcoy', 33000, 75.00),
    (13, N'San Antonio Huista', 18000, 98.00),
    (13, N'San Sebastián Coatán', 27000, 108.00),
    (13, N'Barillas', 130000, 150.00),
    (13, N'Aguacatán', 57000, 24.00),
    (13, N'San Rafael Petzal', 10000, 30.00),
    (13, N'San Gaspar Ixchil', 8000, 44.00),
    (13, N'Santiago Chimaltenango', 9000, 68.00),
    (13, N'Santa Ana Huista', 10000, 95.00),
    (13, N'Unión Cantinil', 18000, 78.00),
    (13, N'Petatán', 17000, 100.00);

-- QUICHE
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (14, N'Santa Cruz del Quiché', 95000, 0.00),
    (14, N'Chiché', 35000, 11.00),
    (14, N'Chinique', 13000, 20.00),
    (14, N'Zacualpa', 45000, 41.00),
    (14, N'Chajul', 70000, 110.00),
    (14, N'Chichicastenango', 145000, 18.00),
    (14, N'Patzité', 7000, 12.00),
    (14, N'San Antonio Ilotenango', 25000, 15.00),
    (14, N'San Pedro Jocopilas', 35000, 10.00),
    (14, N'Cunén', 50000, 68.00),
    (14, N'San Juan Cotzal', 35000, 105.00),
    (14, N'Joyabaj', 85000, 53.00),
    (14, N'Nebaj', 95000, 85.00),
    (14, N'San Andrés Sajcabajá', 32000, 36.00),
    (14, N'Uspantán', 85000, 98.00),
    (14, N'Sacapulas', 55000, 50.00),
    (14, N'San Bartolomé Jocotenango', 12000, 38.00),
    (14, N'Canillá', 14000, 70.00),
    (14, N'Chicamán', 42000, 78.00),
    (14, N'Ixcán', 110000, 170.00),
    (14, N'Pachalum', 12000, 78.00);

-- BAJA VERAPAZ
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (15, N'Salamá', 65000, 0.00),
    (15, N'San Miguel Chicaj', 30000, 9.00),
    (15, N'Rabinal', 45000, 27.00),
    (15, N'Cubulco', 65000, 47.00),
    (15, N'Granados', 14000, 64.00),
    (15, N'Santa Cruz el Chol', 12000, 52.00),
    (15, N'San Jerónimo', 25000, 10.00),
    (15, N'Purulhá', 46000, 50.00);

-- ALTA VERAPAZ
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (16, N'Cobán', 250000, 0.00),
    (16, N'Santa Cruz Verapaz', 35000, 15.00),
    (16, N'San Cristóbal Verapaz', 70000, 24.00),
    (16, N'Tactic', 40000, 30.00),
    (16, N'Tamahú', 18000, 43.00),
    (16, N'Tucurú', 45000, 60.00),
    (16, N'Panzós', 65000, 127.00),
    (16, N'Senahú', 80000, 98.00),
    (16, N'San Pedro Carchá', 260000, 8.00),
    (16, N'San Juan Chamelco', 75000, 8.00),
    (16, N'Lanquín', 35000, 63.00),
    (16, N'Cahabón', 70000, 95.00),
    (16, N'Chisec', 95000, 82.00),
    (16, N'Chahal', 30000, 150.00),
    (16, N'Fray Bartolomé de las Casas', 75000, 110.00),
    (16, N'Santa Catalina La Tinta', 45000, 93.00),
    (16, N'Raxruhá', 45000, 120.00);

-- PETEN
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (17, N'Flores', 65000, 0.00),
    (17, N'San José', 7000, 23.00),
    (17, N'San Benito', 75000, 2.00),
    (17, N'San Andrés', 55000, 22.00),
    (17, N'La Libertad', 90000, 32.00),
    (17, N'San Francisco', 18000, 18.00),
    (17, N'Santa Ana', 30000, 21.00),
    (17, N'Dolores', 65000, 80.00),
    (17, N'San Luis', 85000, 118.00),
    (17, N'Sayaxché', 120000, 65.00),
    (17, N'Melchor de Mencos', 25000, 93.00),
    (17, N'Poptún', 75000, 100.00),
    (17, N'Las Cruces', 40000, 75.00),
    (17, N'El Chal', 35000, 45.00);

-- IZABAL
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (18, N'Puerto Barrios', 110000, 0.00),
    (18, N'Livingston', 65000, 30.00),
    (18, N'El Estor', 90000, 120.00),
    (18, N'Morales', 110000, 55.00),
    (18, N'Los Amates', 65000, 95.00);

-- ZACAPA
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (19, N'Zacapa', 80000, 0.00),
    (19, N'Estanzuela', 12000, 8.00),
    (19, N'Río Hondo', 20000, 14.00),
    (19, N'Gualán', 45000, 36.00),
    (19, N'Teculután', 18000, 29.00),
    (19, N'Usumatlán', 12000, 40.00),
    (19, N'Cabañas', 12000, 35.00),
    (19, N'San Diego', 7000, 65.00),
    (19, N'La Unión', 30000, 75.00),
    (19, N'Huité', 10000, 52.00),
    (19, N'San Jorge', 8000, 10.00);

-- CHIQUIMULA
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (20, N'Chiquimula', 100000, 0.00),
    (20, N'San José La Arada', 9000, 13.00),
    (20, N'San Juan Ermita', 14000, 20.00),
    (20, N'Jocotán', 65000, 32.00),
    (20, N'Camotán', 65000, 36.00),
    (20, N'Olopa', 28000, 43.00),
    (20, N'Esquipulas', 65000, 52.00),
    (20, N'Concepción Las Minas', 15000, 56.00),
    (20, N'Quezaltepeque', 28000, 26.00),
    (20, N'San Jacinto', 12000, 17.00),
    (20, N'Ipala', 25000, 34.00);

-- JALAPA
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (21, N'Jalapa', 160000, 0.00),
    (21, N'San Pedro Pinula', 70000, 20.00),
    (21, N'San Luis Jilotepeque', 30000, 42.00),
    (21, N'San Manuel Chaparrón', 12000, 35.00),
    (21, N'San Carlos Alzatate', 20000, 50.00),
    (21, N'Monjas', 30000, 23.00),
    (21, N'Mataquescuintla', 45000, 42.00);

-- JUTIAPA
INSERT INTO Municipios (IdDepartamento, Nombre, Poblacion, DistanciaCabecera)
VALUES
    (22, N'Jutiapa', 160000, 0.00),
    (22, N'El Progreso', 22000, 11.00),
    (22, N'Santa Catarina Mita', 30000, 34.00),
    (22, N'Agua Blanca', 18000, 42.00),
    (22, N'Asunción Mita', 50000, 30.00),
    (22, N'Yupiltepeque', 18000, 22.00),
    (22, N'Atescatempa', 16000, 34.00),
    (22, N'Jerez', 7000, 45.00),
    (22, N'El Adelanto', 6000, 26.00),
    (22, N'Zapotitlán', 9000, 32.00),
    (22, N'Comapa', 40000, 41.00),
    (22, N'Jalpatagua', 28000, 42.00),
    (22, N'Conguaco', 22000, 62.00),
    (22, N'Moyuta', 45000, 55.00),
    (22, N'Pasaco', 10000, 90.00),
    (22, N'San José Acatempa', 13000, 28.00),
    (22, N'Quesada', 22000, 18.00);
GO

-- Rutas entre cabeceras
INSERT INTO Rutas (Origen, Destino, Distancia, TipoRuta, Fuente, FechaConsulta)
VALUES
    (N'Ciudad de Guatemala', N'Antigua Guatemala', 40.00, N'Ruta principal', N'Google Maps', '2026-05-27'),
    (N'Ciudad de Guatemala', N'Chimaltenango', 54.00, N'Ruta principal', N'Google Maps', '2026-05-27'),
    (N'Ciudad de Guatemala', N'Escuintla', 58.00, N'Ruta principal', N'Google Maps', '2026-05-27'),
    (N'Ciudad de Guatemala', N'Cuilapa', 64.00, N'Ruta principal', N'Google Maps', '2026-05-27'),
    (N'Ciudad de Guatemala', N'Guastatoya', 75.00, N'Ruta principal', N'Google Maps', '2026-05-27'),
    (N'Ciudad de Guatemala', N'Jalapa', 101.00, N'Ruta principal', N'Google Maps', '2026-05-27'),
    (N'Ciudad de Guatemala', N'Jutiapa', 118.00, N'Ruta principal', N'Google Maps', '2026-05-27'),
    (N'Antigua Guatemala', N'Chimaltenango', 22.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Chimaltenango', N'Sololá', 86.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Sololá', N'Totonicapán', 63.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Totonicapán', N'Quetzaltenango', 28.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Quetzaltenango', N'San Marcos', 50.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Quetzaltenango', N'Retalhuleu', 74.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Retalhuleu', N'Mazatenango', 38.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Mazatenango', N'Escuintla', 110.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Guastatoya', N'Zacapa', 73.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Zacapa', N'Chiquimula', 31.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Chiquimula', N'Jutiapa', 73.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Jalapa', N'Jutiapa', 39.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Jalapa', N'Chiquimula', 84.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Cuilapa', N'Jutiapa', 54.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Cuilapa', N'Escuintla', 82.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Guastatoya', N'Salamá', 85.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Salamá', N'Cobán', 70.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Cobán', N'Flores', 269.00, N'Ruta principal', N'Google Maps', '2026-05-27'),
    (N'Cobán', N'Puerto Barrios', 185.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Zacapa', N'Puerto Barrios', 149.00, N'Ruta principal', N'Google Maps', '2026-05-27'),
    (N'Santa Cruz del Quiché', N'Chimaltenango', 110.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Santa Cruz del Quiché', N'Sololá', 82.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Santa Cruz del Quiché', N'Huehuetenango', 102.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Huehuetenango', N'San Marcos', 96.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Huehuetenango', N'Quetzaltenango', 90.00, N'Ruta interdepartamental', N'Google Maps', '2026-05-27'),
    (N'Flores', N'Puerto Barrios', 330.00, N'Ruta alterna', N'Google Maps', '2026-05-27');
GO
