-- Usar la base de datos
USE db_catalogo;
GO

-- Crear tabla Estados
CREATE TABLE Estados (
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Nombre] NVARCHAR(50) NOT NULL
);
GO

-- Crear tabla Categorias
CREATE TABLE Categorias (
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Categoria] NVARCHAR(50) NOT NULL
);
GO

-- Crear tabla Fabricantes
CREATE TABLE Fabricantes (
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Nombre] NVARCHAR(100) NOT NULL,
    [Contacto] NVARCHAR(100) NULL
);
GO

-- Crear tabla Productos
CREATE TABLE Productos (
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Codigo] NVARCHAR(50) NOT NULL,
    [Nombre] NVARCHAR(100) NOT NULL,
    [Fabricante] INT REFERENCES Fabricantes([Id]),
    [Categoria] INT REFERENCES Categorias([Id]),
    [Cantidad] INT NOT NULL,
    [Precio] DECIMAL(10, 2) NOT NULL
);
GO

-- Crear tabla Publicaciones
CREATE TABLE Publicaciones (
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Producto] INT REFERENCES Productos([Id]),
    [Estado] INT REFERENCES Estados([Id]),
    [Fecha] SMALLDATETIME NOT NULL,
    [Titulo] NVARCHAR(255) NOT NULL,
    [Descripcion] TEXT NULL,
    [Costo] DECIMAL(10, 2) NULL
);
GO

-- Crear tabla Imagenes
CREATE TABLE Imagenes (
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Producto] INT REFERENCES Productos([Id]),
    [Archivo] NVARCHAR(255) NOT NULL,
    [Informacion] TEXT NULL
);
GO

-- Insertar datos en la tabla Estados
INSERT INTO Estados ([Nombre]) VALUES ('Disponible');
INSERT INTO Estados ([Nombre]) VALUES ('No Disponible');
GO

-- Insertar datos en la tabla Categorias
INSERT INTO Categorias ([Categoria]) VALUES ('Electrónica');
INSERT INTO Categorias ([Categoria]) VALUES ('Hogar');
GO

-- Insertar datos en la tabla Fabricantes
INSERT INTO Fabricantes ([Nombre], [Contacto]) VALUES ('Sony', 'contacto@sony.com');
INSERT INTO Fabricantes ([Nombre], [Contacto]) VALUES ('Samsung', 'contacto@samsung.com');
GO

-- Insertar datos en la tabla Productos
INSERT INTO Productos ([Codigo], [Nombre], [Fabricante], [Categoria], [Cantidad], [Precio])
VALUES ('P001', 'Televisor LED', 1, 1, 50, 999.99);
INSERT INTO Productos ([Codigo], [Nombre], [Fabricante], [Categoria], [Cantidad], [Precio])
VALUES ('P002', 'Refrigerador', 2, 2, 30, 799.99);
GO

-- Insertar datos en la tabla Publicaciones
INSERT INTO Publicaciones ([Producto], [Estado], [Fecha], [Titulo], [Descripcion], [Costo])
VALUES (1, 1, GETDATE(), 'Venta de Televisores', 'Oferta en televisores LED Sony', 950.00);
INSERT INTO Publicaciones ([Producto], [Estado], [Fecha], [Titulo], [Descripcion], [Costo])
VALUES (2, 2, GETDATE(), 'Refrigeradores en stock', 'Refrigeradores Samsung a buen precio', 750.00);
GO

-- Insertar datos en la tabla Imagenes
INSERT INTO Imagenes ([Producto], [Archivo], [Informacion])
VALUES (1, 'televisor_sony.jpg', 'Imagen de un televisor LED Sony');
INSERT INTO Imagenes ([Producto], [Archivo], [Informacion])
VALUES (2, 'refrigerador_samsung.jpg', 'Imagen de un refrigerador Samsung');
GO
