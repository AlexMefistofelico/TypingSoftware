CREATE DATABASE TYPING

GO 

USE TYPING

CREATE TABLE USUARIO(
	UsuarioID INT NOT NULL,
	Modo INT,
	Nombre VARCHAR(50),
	PRIMARY KEY (UsuarioID)
);

CREATE TABLE LECCION(
	LeccionID INT NOT NULL,
	Parrafo VARCHAR(600),
	PPM INT,
	PRIMARY KEY (LeccionID)
);

CREATE TABLE NIVEL(
	NivelID INT NOT NULL,
	UsuarioID INT,
	LeccionID INT,
	PRIMARY KEY(NivelID),
	FOREIGN KEY(UsuarioID) REFERENCES USUARIO,
	FOREIGN KEY(LeccionID) REFERENCES LECCION
);

ALTER TABLE <TABLE_NAME>
ADD CONSTRAINT <CONSTRAINT_NAME> PRIMARY KEY(<COLUMN_NAME>)

DROP TABLE PROGRESO

Create TABLE PROGRESO(
	ProgresoID INT NOT NULL,
	UsuarioID INT,
	Fecha DATETIME,
	PPMC INT,
	Leccion INT,
	Nivel INT,
	PRIMARY KEY(ProgresoID),
	FOREIGN KEY(UsuarioID) REFERENCES USUARIO
);

SELECT * FROM USUARIO
SELECT * FROM LECCION
SELECT * FROM NIVEL
SELECT * FROM PROGRESO
