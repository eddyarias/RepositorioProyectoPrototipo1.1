

drop database db_farmacia;
--go

--drop table Class_Proveedor
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'db_farmacia')
BEGIN
    CREATE DATABASE db_farmacia;
END
go

USE db_farmacia; --para usar la base de datos
go


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
    (1, 'Proveedor1', 'Juan', 'P�rez', 'proveedor1@example.com', 'Ciudad1', 'Direcci�n1', '123456789', 'Farmacia', 'Observaciones1', 'Informaci�n bancaria1', 'Buena'),
    (2, 'Proveedor2', 'Mar�a', 'G�mez', 'proveedor2@example.com', 'Ciudad2', 'Direcci�n2', '987654321', 'Farmacia', 'Observaciones2', 'Informaci�n bancaria2', 'Regular'),
    (3, 'Proveedor3', 'Carlos', 'L�pez', 'proveedor3@example.com', 'Ciudad3', 'Direcci�n3', '555555555', 'Farmacia', 'Observaciones3', 'Informaci�n bancaria3', 'Buena'),
    (4, 'Proveedor4', 'Ana', 'Mart�nez', 'proveedor4@example.com', 'Ciudad4', 'Direcci�n4', '111111111', 'Farmacia', 'Observaciones4', 'Informaci�n bancaria4', 'Excelente'),
    (5, 'Proveedor5', 'Pedro', 'S�nchez', 'proveedor5@example.com', 'Ciudad5', 'Direcci�n5', '999999999', 'Farmacia', 'Observaciones5', 'Informaci�n bancaria5', 'Regular');
END

go

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

go


IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Cliente')
BEGIN
    CREATE TABLE Cliente (
        cedula BIGINT PRIMARY KEY,
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
	INSERT INTO Cliente (cedula, tipo_persona, nombres_c, apellidos_c, parroquia, direccion_c, email_c, telefono_c, fecha_nac, observaciones_c)
VALUES
    ( 1717506289, 'Persona Natural', 'Juan', 'P�rez', 'Parroquia 1', 'Direcci�n 1', 'juan@example.com', '1234567890', '1990-01-01', 'Observaciones 1'),
    ( 1724246234, 'Persona Jur�dica', 'Empresa A', 'S.A.', 'Parroquia 2', 'Direcci�n 2', 'empresaA@example.com', '0987654321', '1995-05-10', 'Observaciones 2'),
    ( 1718575192, 'Persona Natural', 'Mar�a', 'G�mez', 'Parroquia 3', 'Direcci�n 3', 'maria@example.com', '5678901234', '1988-12-15', 'Observaciones 3'),
    ( 1804934808, 'Persona Jur�dica', 'Empresa B', 'C.A.', 'Parroquia 4', 'Direcci�n 4', 'empresaB@example.com', '0432109876', '2000-07-20', 'Observaciones 4'),
    ( 1900854553, 'Persona Natural', 'Pedro', 'L�pez', 'Parroquia 5', 'Direcci�n 5', 'pedro@example.com', '9999999999', '1993-06-30', 'Observaciones 5');
END


go

-- Crear la tabla Factura
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Factura')
BEGIN
    CREATE TABLE Factura (
        idFactura CHAR(15) PRIMARY KEY,
        fechaEmision DATE,
        cedula bigINT,
        subtotal DECIMAL(18, 2),
        iva DECIMAL(18, 2),
        descuentoTotalDolares DECIMAL(18, 2),
        total DECIMAL(18, 2),
        formaPago NVARCHAR(50),
        estado NVARCHAR(50) CHECK (estado IN ('Anulada', 'Vigente')), -- Se a�ade la restricci�n CHECK
        FOREIGN KEY (cedula) REFERENCES Cliente(cedula) -- Clave for�nea
    );
END
go

-- Crear la tabla ListaProductosFactura
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ListaProductosFactura')
BEGIN
    CREATE TABLE ListaProductosSeleccionados (
        idListaProducSelec INT primary key,
		idFactura CHAR(15),
        idProducto INT,
        cantidad INT,
        precio DECIMAL(18, 2),
        subtotal DECIMAL(18, 2),
        descuentoDolares DECIMAL(18, 2),
		FOREIGN KEY (idFactura) REFERENCES Factura(idFactura), -- Clave for�nea
    );
END
go



	
-- A�adir datos a la tabla Factura
INSERT INTO Factura (idFactura, fechaEmision, cedula, subtotal, iva, descuentoTotalDolares, total, formaPago, estado)
VALUES
    ('001001000000001', '2023-08-30', 1717506289,  100.00, 12.00, 5.00, 107.00, 'Tarjeta de cr�dito', 'Vigente'),
    ('001001000000002', '2023-08-31', 1804934808,  150.00, 18.00, 7.50, 160.50, 'Efectivo', 'Vigente');



-- A�adir datos a la tabla ListaProductosSeleccionados
INSERT INTO ListaProductosSeleccionados (idListaProducSelec, idFactura, idProducto, cantidad, precio, subtotal, descuentoDolares)
VALUES
    (1, '001001000000001', 101, 2, 50.00, 100.00, 0.00),
    (2, '001001000000001', 102, 3, 20.00, 60.00, 5.00),
    (3, '001001000000002', 103, 1, 80.00, 80.00, 2.50),
    (4, '001001000000002', 104, 2, 35.00, 70.00, 0.00);




	select * from Proveedor;
select * from Producto;
select * from Cliente;
select * from Factura;
select * from ListaProductosSeleccionados;

go