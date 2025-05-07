-- Crear base de datos
CREATE DATABASE Comercio;
GO

-- Usar la base
USE Comercio;
GO

-- Crear tabla Categorias
CREATE TABLE Categorias (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50)
);

-- Crear tabla Productos
CREATE TABLE Productos (
    Codigo INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Descripcion NVARCHAR(255),
    Precio DECIMAL(10,2),
    Stock INT,
    CategoriaId INT,
    FOREIGN KEY (CategoriaId) REFERENCES Categorias(Id)
);

-- Crear tabla contactos
CREATE TABLE Contactos (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50),
    Apellido NVARCHAR(50),
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100),
    Categoria NVARCHAR(50)
);


-- Insertar categorías
INSERT INTO Categorias (Nombre) VALUES ('Tecnología'), ('Hogar'), ('Ropa');

-- Insertar productos
INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) VALUES
('Notebook Lenovo', 'Notebook i5 8GB RAM', 850000, 10, 1),
('Licuadora Philips', '600W, vaso de vidrio', 320000, 5, 2),
('Camisa Blanca', 'Manga larga, algodón', 180000, 15, 3);

-- Insertar contactos
INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo, Categoria) VALUES
('Bruno', 'Delgado', '1145789632', 'bruno.delgado@mail.com', 'Cliente'),
('Valeria', 'Acosta', '1178945632', 'valeria.acosta@mail.com', 'Proveedor'),
('Ignacio', 'Ruiz', '1154368974', 'ignacio.ruiz@mail.com', 'Empleado');