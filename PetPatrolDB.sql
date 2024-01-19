create database PetPatrol
use PetPatrol

-- Creación de la tabla Animales
CREATE TABLE Animales (
    ID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100),
    Especie VARCHAR(50),
    Raza VARCHAR(50),
    Sexo VARCHAR(20),
    Color VARCHAR(50),
    Edad INT,
    Tamanio VARCHAR(50),
    Descripcion VARCHAR(200),
    Perdido BIT,
    FechaPerdida DATETIME,
    FechaEncontrada DATETIME,
    FechaAdopcion DATETIME,
    Castrado BIT
);

-- Creación de la tabla Roles 
CREATE TABLE Roles (
    RolId INT PRIMARY KEY IDENTITY,
    NombreRol VARCHAR(50)
);

-- Creación de la tabla Usuarios
CREATE TABLE Usuarios (
    ID INT PRIMARY KEY IDENTITY,
    NombreUsuario VARCHAR(100),
    Contrasena VARCHAR(100),
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Direccion VARCHAR(255),
    Telefono INT,
    Email VARCHAR(100),
    RoleId INT
);

-- Creación de la tabla Publicaciones
CREATE TABLE Publicaciones (
    ID INT PRIMARY KEY IDENTITY,
    Titulo VARCHAR(100),
    Descripcion VARCHAR(200),
    FechaPublicacion DATETIME,
    TipoPublicacion VARCHAR(50),
    Estado VARCHAR(50),
    UsuarioID INT,
    AnimalID INT,
    LocalizacionID INT,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(ID),
    FOREIGN KEY (AnimalID) REFERENCES Animales(ID)
);

-- Creación de la tabla Imagenes
CREATE TABLE Imagenes (
    Id INT PRIMARY KEY IDENTITY,
    ImagenURL VARCHAR(255),
    IdEntidad INT,
    TipoEntidad VARCHAR(50)
);

-- Creación de la tabla Localizaciones
CREATE TABLE Localizaciones (
    ID INT PRIMARY KEY IDENTITY,
    Calles VARCHAR(255),
    Provincia VARCHAR(50),
    Barrio VARCHAR(50),
    Coordenadas VARCHAR(100)
);

-- Actualización de la tabla Publicaciones para añadir la referencia a Localizaciones
ALTER TABLE Publicaciones
ADD FOREIGN KEY (LocalizacionID) REFERENCES Localizaciones(ID);

-- Actualizar la tabla Usuarios para establecer una clave foránea con Roles
ALTER TABLE Usuarios
ADD FOREIGN KEY (RoleId) REFERENCES Roles(RolId);

-- Creación de la tabla Comentarios
CREATE TABLE Comentarios (
    ID INT PRIMARY KEY IDENTITY,
    Texto VARCHAR(200),
    Fecha DATETIME,
    UsuarioID INT,
    PublicacionID INT,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(ID),
    FOREIGN KEY (PublicacionID) REFERENCES Publicaciones(ID)
);

-- Creación de la tabla Notificaciones
CREATE TABLE Notificaciones (
    ID INT PRIMARY KEY IDENTITY,
    Texto VARCHAR(100),
    Fecha DATETIME,
    UsuarioID INT,
    PublicacionID INT,
    Estado BIT,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(ID),
    FOREIGN KEY (PublicacionID) REFERENCES Publicaciones(ID)
);

-- Insertar roles básicos
INSERT INTO Roles (NombreRol) VALUES ('Usuario');
INSERT INTO Roles (NombreRol) VALUES ('Administrador');
