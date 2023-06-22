--drop database db_farmacia;
--drop table Class_Proveedor
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'db_farmacia')
BEGIN
    CREATE DATABASE db_farmacia;
END

USE db_farmacia; --para usar la base de datos

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Proveedor')
BEGIN
    CREATE TABLE Proveedor (
        ruc INT PRIMARY KEY,
        razon_social VARCHAR(200),
        nombre VARCHAR(100),
        apellido VARCHAR(100),
        email VARCHAR(100),
        ciudad VARCHAR(100),
        direccion VARCHAR(200),
        telefono VARCHAR(20),
        rubro VARCHAR(100),
        observaciones VARCHAR(200),
        informacion_bancaria VARCHAR(200),
        calificacion VARCHAR(50)
    )

	INSERT INTO Proveedor (ruc, razon_social, nombre, apellido, email, ciudad, direccion, telefono, rubro, observaciones, informacion_bancaria, calificacion)
VALUES
    (1, 'Proveedor1', 'Juan', 'Pérez', 'proveedor1@example.com', 'Ciudad1', 'Dirección1', '123456789', 'Farmacia', 'Observaciones1', 'Información bancaria1', 'Buena'),
    (2, 'Proveedor2', 'María', 'Gómez', 'proveedor2@example.com', 'Ciudad2', 'Dirección2', '987654321', 'Farmacia', 'Observaciones2', 'Información bancaria2', 'Regular'),
    (3, 'Proveedor3', 'Carlos', 'López', 'proveedor3@example.com', 'Ciudad3', 'Dirección3', '555555555', 'Farmacia', 'Observaciones3', 'Información bancaria3', 'Buena'),
    (4, 'Proveedor4', 'Ana', 'Martínez', 'proveedor4@example.com', 'Ciudad4', 'Dirección4', '111111111', 'Farmacia', 'Observaciones4', 'Información bancaria4', 'Excelente'),
    (5, 'Proveedor5', 'Pedro', 'Sánchez', 'proveedor5@example.com', 'Ciudad5', 'Dirección5', '999999999', 'Farmacia', 'Observaciones5', 'Información bancaria5', 'Regular');
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Producto')
BEGIN
    CREATE TABLE Producto (
        codigo INT PRIMARY KEY,
        cantidad INT,
        descripcion NVARCHAR(255),
        lote NVARCHAR(50),
        PVP DECIMAL(18, 2),
        precio_unitario DECIMAL(18, 2),
        fecha_cad DATE,
        descuento DECIMAL(18, 2),
        iva DECIMAL(18, 2)
    );
	INSERT INTO Producto (codigo, cantidad, descripcion, lote, PVP, precio_unitario, fecha_cad, descuento, iva)
VALUES
    (1, 10, 'Producto 1', 'Lote A', 9.99, 8.99, '2023-06-30', 0.5, 0.18),
    (2, 5, 'Producto 2', 'Lote B', 19.99, 17.99, '2023-07-15', 1.0, 0.18),
    (3, 2, 'Producto 3', 'Lote C', 5.99, 4.99, '2023-06-25', 0.2, 0.18),
    (4, 8, 'Producto 4', 'Lote D', 14.99, 12.99, '2023-07-10', 0.75, 0.18),
    (5, 3, 'Producto 5', 'Lote E', 7.99, 6.99, '2023-06-28', 0.3, 0.18);
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Cliente')
BEGIN
    CREATE TABLE Cliente (
        codigo_c INT PRIMARY KEY,
        ruc_c BIGINT,
        tipo_persona NVARCHAR(50),
        nombres_c NVARCHAR(100),
        apellidos_c NVARCHAR(100),
        parroquia NVARCHAR(100),
        direccion_c NVARCHAR(100),
        email_c NVARCHAR(100),
        telefono_c NVARCHAR(40),
        fecha_nac DATE,
        observaciones_c VARCHAR(200)
    );
	INSERT INTO Cliente (codigo_c, ruc_c, tipo_persona, nombres_c, apellidos_c, parroquia, direccion_c, email_c, telefono_c, fecha_nac, observaciones_c)
VALUES
    (1, 1234567890, 'Persona Natural', 'Juan', 'Pérez', 'Parroquia 1', 'Dirección 1', 'juan@example.com', '1234567890', '1990-01-01', 'Observaciones 1'),
    (2, 9876543210, 'Persona Jurídica', 'Empresa A', 'S.A.', 'Parroquia 2', 'Dirección 2', 'empresaA@example.com', '0987654321', '1995-05-10', 'Observaciones 2'),
    (3, 5678901234, 'Persona Natural', 'María', 'Gómez', 'Parroquia 3', 'Dirección 3', 'maria@example.com', '5678901234', '1988-12-15', 'Observaciones 3'),
    (4, 4321098765, 'Persona Jurídica', 'Empresa B', 'C.A.', 'Parroquia 4', 'Dirección 4', 'empresaB@example.com', '0432109876', '2000-07-20', 'Observaciones 4'),
    (5, 9999999999, 'Persona Natural', 'Pedro', 'López', 'Parroquia 5', 'Dirección 5', 'pedro@example.com', '9999999999', '1993-06-30', 'Observaciones 5');
END



select * from Proveedor;
select * from Producto;
select * from Cliente;
