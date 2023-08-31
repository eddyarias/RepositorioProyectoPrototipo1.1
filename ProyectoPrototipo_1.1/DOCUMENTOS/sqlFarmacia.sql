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



/*TablaFactura*/


-- Crear la tabla ListaProductosFactura
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ListaProductosFactura')
BEGIN
    CREATE TABLE ListaProductosSeleccionados (
        idListaProducSelec INT PRIMARY KEY IDENTITY(1,1),

        idProducto INT,
        cantidad INT,
        precio DECIMAL(18, 2),
        subtotal DECIMAL(18, 2),
        descuentoDolares DECIMAL(18, 2),
        
    );
END

-- Crear la tabla Factura
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Factura')
BEGIN
    CREATE TABLE Factura (
        idFactura INT PRIMARY KEY IDENTITY(1,1),
        fechaEmision DATE,
        idCliente INT,
        idListaProducSelec INT,
        subtotal DECIMAL(18, 2),
        iva DECIMAL(18, 2),
        descuentoTotalDolares DECIMAL(18, 2),
        total DECIMAL(18, 2),
        formaPago NVARCHAR(50),
        estado NVARCHAR(50) CHECK (estado IN ('Anulada', 'Vigente')), -- Se añade la restricción CHECK
        FOREIGN KEY (idListaProducSelec) REFERENCES ListaProductosSeleccionados(idListaProducSelec) -- Clave foránea
    );
END


-- Insertar datos en la tabla ListaProductosSeleccionados
INSERT INTO ListaProductosSeleccionados (idProducto, cantidad, precio, subtotal, descuentoDolares)
VALUES
    (1, 3, 9.99, 29.97, 2.00),
    (2, 2, 19.99, 39.98, 0.00),
    (3, 5, 5.99, 29.95, 1.50),
    (4, 4, 14.99, 59.96, 3.00),
    (5, 1, 7.99, 7.99, 0.25);

-- Insertar datos en la tabla Factura
INSERT INTO Factura (fechaEmision, idCliente, idListaProducSelec, subtotal, iva, descuentoTotalDolares, total, formaPago, estado)
VALUES
    ('2023-08-30', 1, 1, 159.85, 28.77, 5.75, 183.87, 'Tarjeta de crédito', 'Vigente'),
    ('2023-08-31', 2, 2, 69.93, 12.59, 0.00, 82.52, 'Efectivo', 'Anulada'),
    ('2023-08-31', 3, 3, 129.75, 23.36, 7.50, 145.61, 'Transferencia bancaria', 'Vigente'),
    ('2023-09-01', 4, 4, 239.84, 43.17, 12.00, 271.01, 'Tarjeta de débito', 'Anulada'),
    ('2023-09-01', 5, 5, 7.99, 1.44, 0.25, 9.18, 'Efectivo', 'Vigente');

