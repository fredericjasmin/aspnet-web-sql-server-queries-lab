-- Crear base de datos
CREATE DATABASE WebQueriesDB;
GO

-- Seleccionar la base de datos
USE WebQueriesDB;
GO

/* =====================================================
   TABLA: Clientes
   Utilizada por Consulta1 (parámetro entero)
   ===================================================== */
CREATE TABLE Clientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Edad INT NOT NULL
);
GO

INSERT INTO Clientes (Nombre, Edad)
VALUES
('Ana', 25),
('Carlos', 30),
('Maria', 25),
('Luis', 40),
('Sofia', 35);
GO

/* =====================================================
   TABLA: Productos
   Utilizada por Consulta2 (parámetro texto)
   ===================================================== */
CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Categoria NVARCHAR(50) NOT NULL
);
GO

INSERT INTO Productos (Nombre, Categoria)
VALUES
('Laptop Dell', 'Tecnologia'),
('Mouse Logitech', 'Tecnologia'),
('Monitor Samsung', 'Tecnologia'),
('Silla Ejecutiva', 'Muebles'),
('Escritorio', 'Muebles');
GO

/* =====================================================
   TABLA: Ventas
   Utilizada por Consulta3 (parámetro fecha)
   ===================================================== */
CREATE TABLE Ventas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Cliente NVARCHAR(100) NOT NULL,
    FechaVenta DATE NOT NULL,
    Monto DECIMAL(10,2) NOT NULL
);
GO

INSERT INTO Ventas (Cliente, FechaVenta, Monto)
VALUES
('Ana', '2025-01-15', 150.00),
('Carlos', '2025-02-10', 300.50),
('Maria', '2025-03-20', 220.75),
('Luis', '2025-04-05', 500.00),
('Sofia', '2025-05-12', 175.25);
GO

/* =====================================================
   CONSULTAS DE PRUEBA
   ===================================================== */

-- Consulta 1
SELECT *
FROM Clientes
WHERE Edad = 25;
GO

-- Consulta 2
SELECT *
FROM Productos
WHERE Categoria = 'Tecnologia';
GO

-- Consulta 3
SELECT *
FROM Ventas
WHERE FechaVenta = '2025-02-10';
GO