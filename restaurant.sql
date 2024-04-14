-- Crear secuencias
CREATE SEQUENCE seq_restaurant_restaurante START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_restaurant_empleados START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_restaurant_clientes START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_restaurant_comandas START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_restaurant_ventas START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_restaurant_proveedores START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_restaurant_inventario START WITH 1 INCREMENT BY 1;

-- Tabla Restaurantes
CREATE TABLE restaurant_restaurantes (
    id_restaurante NUMBER PRIMARY KEY,
    nombre VARCHAR2(100)
);

-- Gatillo para autoincrementar el ID de restaurant_restaurantes
CREATE OR REPLACE TRIGGER trg_restaurant_restaurante
BEFORE INSERT ON restaurant_restaurantes
FOR EACH ROW
BEGIN
    SELECT seq_restaurant_restaurante.nextval
    INTO :new.id_restaurante
    FROM dual;
END;
/

-- Tabla Empleados
CREATE TABLE restaurant_empleados (
    id_empleado NUMBER PRIMARY KEY,
    nombre VARCHAR2(100),
    apellido VARCHAR2(100),
    puesto VARCHAR2(50),
    salario NUMBER,
    fecha_contrato DATE,
    id_restaurante NUMBER REFERENCES restaurant_restaurantes(id_restaurante)
);

-- Gatillo para autoincrementar el ID de restaurant_empleados
CREATE OR REPLACE TRIGGER trg_restaurant_empleado
BEFORE INSERT ON restaurant_empleados
FOR EACH ROW
BEGIN
    SELECT seq_restaurant_empleados.nextval
    INTO :new.id_empleado
    FROM dual;
END;
/

-- Tabla Clientes
CREATE TABLE restaurant_clientes (
    id_cliente NUMBER PRIMARY KEY,
    nombre VARCHAR2(100),
    apellido VARCHAR2(100),
    direccion VARCHAR2(200),
    telefono VARCHAR2(20),
    email VARCHAR2(100),
    fecha_registro DATE
);

-- Gatillo para autoincrementar el ID de restaurant_clientes
CREATE OR REPLACE TRIGGER trg_restaurant_cliente
BEFORE INSERT ON restaurant_clientes
FOR EACH ROW
BEGIN
    SELECT seq_restaurant_clientes.nextval
    INTO :new.id_cliente
    FROM dual;
END;
/

-- Tabla Comandas
CREATE TABLE restaurant_comandas (
    id_comanda NUMBER PRIMARY KEY,
    id_cliente NUMBER REFERENCES restaurant_clientes(id_cliente),
    id_empleado NUMBER REFERENCES restaurant_empleados(id_empleado),
    fecha_comanda TIMESTAMP,
    total NUMBER,
    estado VARCHAR2(50),
    observaciones VARCHAR2(200)
);

-- Gatillo para autoincrementar el ID de restaurant_comandas
CREATE OR REPLACE TRIGGER trg_restaurant_comanda
BEFORE INSERT ON restaurant_comandas
FOR EACH ROW
BEGIN
    SELECT seq_restaurant_comandas.nextval
    INTO :new.id_comanda
    FROM dual;
END;
/

-- Tabla Ventas
CREATE TABLE restaurant_ventas (
    id_venta NUMBER PRIMARY KEY,
    id_comanda NUMBER REFERENCES restaurant_comandas(id_comanda),
    producto VARCHAR(50),
    cantidad NUMBER,
    precio_unitario NUMBER,
    subtotal NUMBER,
    descuento NUMBER
);

-- Gatillo para autoincrementar el ID de restaurant_ventas
CREATE OR REPLACE TRIGGER trg_restaurant_venta
BEFORE INSERT ON restaurant_ventas
FOR EACH ROW
BEGIN
    SELECT seq_restaurant_ventas.nextval
    INTO :new.id_venta
    FROM dual;
END;
/

-- Tabla Proveedores
CREATE TABLE restaurant_proveedores (
    id_proveedor NUMBER PRIMARY KEY,
    nombre VARCHAR2(100),
    direccion VARCHAR2(200),
    telefono VARCHAR2(20),
    contacto VARCHAR2(100),
    tipo_producto VARCHAR2(50),
    forma_pago VARCHAR2(50)
);

-- Gatillo para autoincrementar el ID de restaurant_proveedores
CREATE OR REPLACE TRIGGER trg_restaurant_proveedor
BEFORE INSERT ON restaurant_proveedores
FOR EACH ROW
BEGIN
    SELECT seq_restaurant_proveedores.nextval
    INTO :new.id_proveedor
    FROM dual;
END;
/

-- Tabla Inventario
CREATE TABLE restaurant_inventario (
    id_producto NUMBER PRIMARY KEY,
    nombre VARCHAR2(100),
    descripcion VARCHAR2(200),
    cantidad_stock NUMBER,
    precio_unitario NUMBER,
    id_proveedor NUMBER REFERENCES restaurant_proveedores(id_proveedor),
    fecha_ingreso TIMESTAMP
);

-- Gatillo para autoincrementar el ID de restaurant_inventario
CREATE OR REPLACE TRIGGER trg_restaurant_inventario
BEFORE INSERT ON restaurant_inventario
FOR EACH ROW
BEGIN
    SELECT seq_restaurant_inventario.nextval
    INTO :new.id_producto
    FROM dual;
END;
/


-- Insertar registros en la tabla restaurant_restaurantes
INSERT INTO restaurant_restaurantes (nombre) VALUES
('Restaurante A'),
('Restaurante B'),
('Restaurante C'),
('Restaurante D'),
('Restaurante E');

-- Insertar registros en la tabla restaurant_empleados
INSERT INTO restaurant_empleados (nombre, apellido, puesto, salario, fecha_contrato, id_restaurante) VALUES
('Empleado1', 'Apellido1', 'Chef', 2000, TO_DATE('2024-01-01', 'YYYY-MM-DD'), 1),
('Empleado2', 'Apellido2', 'Camarero', 1500, TO_DATE('2024-01-15', 'YYYY-MM-DD'), 1),
('Empleado3', 'Apellido3', 'Cocinero', 1800, TO_DATE('2024-02-01', 'YYYY-MM-DD'), 2),
('Empleado4', 'Apellido4', 'Camarero', 1500, TO_DATE('2024-02-15', 'YYYY-MM-DD'), 2),
('Empleado5', 'Apellido5', 'Gerente', 2500, TO_DATE('2024-03-01', 'YYYY-MM-DD'), 3);

INSERT INTO restaurant_empleados (nombre, apellido, puesto, salario, fecha_contrato, id_restaurante) VALUES
('Empleado6', 'Apellido6', 'Cocinero', 1900, TO_DATE('2024-03-15', 'YYYY-MM-DD'), 3),
('Empleado7', 'Apellido7', 'Camarero', 1600, TO_DATE('2024-04-01', 'YYYY-MM-DD'), 1),
('Empleado8', 'Apellido8', 'Chef', 2100, TO_DATE('2024-04-15', 'YYYY-MM-DD'), 2),
('Empleado9', 'Apellido9', 'Gerente', 2600, TO_DATE('2024-05-01', 'YYYY-MM-DD'), 3),
('Empleado10', 'Apellido10', 'Cocinero', 1950, TO_DATE('2024-05-15', 'YYYY-MM-DD'), 1),
('Empleado11', 'Apellido11', 'Camarero', 1650, TO_DATE('2024-06-01', 'YYYY-MM-DD'), 2),
('Empleado12', 'Apellido12', 'Chef', 2200, TO_DATE('2024-06-15', 'YYYY-MM-DD'), 3),
('Empleado13', 'Apellido13', 'Gerente', 2700, TO_DATE('2024-07-01', 'YYYY-MM-DD'), 1),
('Empleado14', 'Apellido14', 'Cocinero', 2000, TO_DATE('2024-07-15', 'YYYY-MM-DD'), 2),
('Empleado15', 'Apellido15', 'Camarero', 1700, TO_DATE('2024-08-01', 'YYYY-MM-DD'), 3),
('Empleado16', 'Apellido16', 'Chef', 2300, TO_DATE('2024-08-15', 'YYYY-MM-DD'), 1),
('Empleado17', 'Apellido17', 'Gerente', 2800, TO_DATE('2024-09-01', 'YYYY-MM-DD'), 2),
('Empleado18', 'Apellido18', 'Cocinero', 2050, TO_DATE('2024-09-15', 'YYYY-MM-DD'), 3),
('Empleado19', 'Apellido19', 'Camarero', 1750, TO_DATE('2024-10-01', 'YYYY-MM-DD'), 1),
('Empleado20', 'Apellido20', 'Chef', 2400, TO_DATE('2024-10-15', 'YYYY-MM-DD'), 2),
('Empleado21', 'Apellido21', 'Gerente', 2900, TO_DATE('2024-11-01', 'YYYY-MM-DD'), 3),
('Empleado22', 'Apellido22', 'Cocinero', 2100, TO_DATE('2024-11-15', 'YYYY-MM-DD'), 1),
('Empleado23', 'Apellido23', 'Camarero', 1800, TO_DATE('2024-12-01', 'YYYY-MM-DD'), 2),
('Empleado24', 'Apellido24', 'Chef', 2500, TO_DATE('2025-01-01', 'YYYY-MM-DD'), 3),
('Empleado25', 'Apellido25', 'Gerente', 3000, TO_DATE('2025-01-15', 'YYYY-MM-DD'), 1),
('Empleado26', 'Apellido26', 'Cocinero', 2150, TO_DATE('2025-02-01', 'YYYY-MM-DD'), 2),
('Empleado27', 'Apellido27', 'Camarero', 1850, TO_DATE('2025-02-15', 'YYYY-MM-DD'), 3),
('Empleado28', 'Apellido28', 'Chef', 2600, TO_DATE('2025-03-01', 'YYYY-MM-DD'), 1),
('Empleado29', 'Apellido29', 'Gerente', 3100, TO_DATE('2025-03-15', 'YYYY-MM-DD'), 2),
('Empleado30', 'Apellido30', 'Cocinero', 2200, TO_DATE('2025-04-01', 'YYYY-MM-DD'), 3);


-- Insertar registros en la tabla restaurant_clientes
INSERT INTO restaurant_clientes (nombre, apellido, direccion, telefono, email, fecha_registro) VALUES
('Cliente1', 'Apellido1', 'Dirección1', '123456789', 'cliente1@example.com', TO_DATE('2024-01-01', 'YYYY-MM-DD')),
('Cliente2', 'Apellido2', 'Dirección2', '987654321', 'cliente2@example.com', TO_DATE('2024-01-15', 'YYYY-MM-DD')),
('Cliente3', 'Apellido3', 'Dirección3', '456789123', 'cliente3@example.com', TO_DATE('2024-02-01', 'YYYY-MM-DD')),
('Cliente4', 'Apellido4', 'Dirección4', '321654987', 'cliente4@example.com', TO_DATE('2024-02-15', 'YYYY-MM-DD')),
('Cliente5', 'Apellido5', 'Dirección5', '789123456', 'cliente5@example.com', TO_DATE('2024-03-01', 'YYYY-MM-DD'));

INSERT INTO restaurant_clientes (nombre, apellido, direccion, telefono, email, fecha_registro) VALUES
('Cliente6', 'Apellido6', 'Dirección6', '112233445', 'cliente6@example.com', TO_DATE('2024-03-15', 'YYYY-MM-DD')),
('Cliente7', 'Apellido7', 'Dirección7', '223344556', 'cliente7@example.com', TO_DATE('2024-04-01', 'YYYY-MM-DD')),
('Cliente8', 'Apellido8', 'Dirección8', '334455667', 'cliente8@example.com', TO_DATE('2024-04-15', 'YYYY-MM-DD')),
('Cliente9', 'Apellido9', 'Dirección9', '445566778', 'cliente9@example.com', TO_DATE('2024-05-01', 'YYYY-MM-DD')),
('Cliente10', 'Apellido10', 'Dirección10', '556677889', 'cliente10@example.com', TO_DATE('2024-05-15', 'YYYY-MM-DD')),
('Cliente11', 'Apellido11', 'Dirección11', '667788990', 'cliente11@example.com', TO_DATE('2024-06-01', 'YYYY-MM-DD')),
('Cliente12', 'Apellido12', 'Dirección12', '778899011', 'cliente12@example.com', TO_DATE('2024-06-15', 'YYYY-MM-DD')),
('Cliente13', 'Apellido13', 'Dirección13', '889900112', 'cliente13@example.com', TO_DATE('2024-07-01', 'YYYY-MM-DD')),
('Cliente14', 'Apellido14', 'Dirección14', '990011223', 'cliente14@example.com', TO_DATE('2024-07-15', 'YYYY-MM-DD')),
('Cliente15', 'Apellido15', 'Dirección15', '001122334', 'cliente15@example.com', TO_DATE('2024-08-01', 'YYYY-MM-DD')),
('Cliente16', 'Apellido16', 'Dirección16', '123123123', 'cliente16@example.com', TO_DATE('2024-08-15', 'YYYY-MM-DD')),
('Cliente17', 'Apellido17', 'Dirección17', '234234234', 'cliente17@example.com', TO_DATE('2024-09-01', 'YYYY-MM-DD')),
('Cliente18', 'Apellido18', 'Dirección18', '345345345', 'cliente18@example.com', TO_DATE('2024-09-15', 'YYYY-MM-DD')),
('Cliente19', 'Apellido19', 'Dirección19', '456456456', 'cliente19@example.com', TO_DATE('2024-10-01', 'YYYY-MM-DD')),
('Cliente20', 'Apellido20', 'Dirección20', '567567567', 'cliente20@example.com', TO_DATE('2024-10-15', 'YYYY-MM-DD')),
('Cliente21', 'Apellido21', 'Dirección21', '678678678', 'cliente21@example.com', TO_DATE('2024-11-01', 'YYYY-MM-DD')),
('Cliente22', 'Apellido22', 'Dirección22', '789789789', 'cliente22@example.com', TO_DATE('2024-11-15', 'YYYY-MM-DD')),
('Cliente23', 'Apellido23', 'Dirección23', '890890890', 'cliente23@example.com', TO_DATE('2024-12-01', 'YYYY-MM-DD')),
('Cliente24', 'Apellido24', 'Dirección24', '901901901', 'cliente24@example.com', TO_DATE('2024-12-15', 'YYYY-MM-DD')),
('Cliente25', 'Apellido25', 'Dirección25', '012012012', 'cliente25@example.com', TO_DATE('2025-01-01', 'YYYY-MM-DD')),
('Cliente26', 'Apellido26', 'Dirección26', '123432123', 'cliente26@example.com', TO_DATE('2025-01-15', 'YYYY-MM-DD')),
('Cliente27', 'Apellido27', 'Dirección27', '234543234', 'cliente27@example.com', TO_DATE('2025-02-01', 'YYYY-MM-DD')),
('Cliente28', 'Apellido28', 'Dirección28', '345654345', 'cliente28@example.com', TO_DATE('2025-02-15', 'YYYY-MM-DD')),
('Cliente29', 'Apellido29', 'Dirección29', '456765456', 'cliente29@example.com', TO_DATE('2025-03-01', 'YYYY-MM-DD')),
('Cliente30', 'Apellido30', 'Dirección30', '567876567', 'cliente30@example.com', TO_DATE('2025-03-15', 'YYYY-MM-DD'));


-- Insertar registros en la tabla restaurant_comandas
INSERT INTO restaurant_comandas (id_cliente, id_empleado, fecha_comanda, total, estado, observaciones) VALUES
(1, 1, CURRENT_TIMESTAMP, 50, 'En proceso', 'Sin observaciones'),
(2, 2, CURRENT_TIMESTAMP, 45, 'Entregada', 'Con observaciones'),
(3, 3, CURRENT_TIMESTAMP, 60, 'En proceso', 'Sin observaciones'),
(4, 4, CURRENT_TIMESTAMP, 55, 'Entregada', 'Con observaciones'),
(5, 5, CURRENT_TIMESTAMP, 70, 'En proceso', 'Sin observaciones');

INSERT INTO restaurant_comandas (id_cliente, id_empleado, fecha_comanda, total, estado, observaciones) VALUES
(6, 6, CURRENT_TIMESTAMP, 75, 'En proceso', 'Sin observaciones'),
(7, 7, CURRENT_TIMESTAMP, 80, 'Entregada', 'Con observaciones'),
(8, 8, CURRENT_TIMESTAMP, 85, 'En proceso', 'Sin observaciones'),
(9, 9, CURRENT_TIMESTAMP, 90, 'Entregada', 'Con observaciones'),
(10, 10, CURRENT_TIMESTAMP, 95, 'En proceso', 'Sin observaciones'),
(11, 1, CURRENT_TIMESTAMP, 100, 'Entregada', 'Con observaciones'),
(12, 2, CURRENT_TIMESTAMP, 105, 'En proceso', 'Sin observaciones'),
(13, 3, CURRENT_TIMESTAMP, 110, 'Entregada', 'Con observaciones'),
(14, 4, CURRENT_TIMESTAMP, 115, 'En proceso', 'Sin observaciones'),
(15, 5, CURRENT_TIMESTAMP, 120, 'Entregada', 'Con observaciones'),
(16, 6, CURRENT_TIMESTAMP, 125, 'En proceso', 'Sin observaciones'),
(17, 7, CURRENT_TIMESTAMP, 130, 'Entregada', 'Con observaciones'),
(18, 8, CURRENT_TIMESTAMP, 135, 'En proceso', 'Sin observaciones'),
(19, 9, CURRENT_TIMESTAMP, 140, 'Entregada', 'Con observaciones'),
(20, 10, CURRENT_TIMESTAMP, 145, 'En proceso', 'Sin observaciones'),
(21, 1, CURRENT_TIMESTAMP, 150, 'Entregada', 'Con observaciones'),
(22, 2, CURRENT_TIMESTAMP, 155, 'En proceso', 'Sin observaciones'),
(23, 3, CURRENT_TIMESTAMP, 160, 'Entregada', 'Con observaciones'),
(24, 4, CURRENT_TIMESTAMP, 165, 'En proceso', 'Sin observaciones'),
(25, 5, CURRENT_TIMESTAMP, 170, 'Entregada', 'Con observaciones'),
(26, 6, CURRENT_TIMESTAMP, 175, 'En proceso', 'Sin observaciones'),
(27, 7, CURRENT_TIMESTAMP, 180, 'Entregada', 'Con observaciones'),
(28, 8, CURRENT_TIMESTAMP, 185, 'En proceso', 'Sin observaciones'),
(29, 9, CURRENT_TIMESTAMP, 190, 'Entregada', 'Con observaciones'),
(30, 10, CURRENT_TIMESTAMP, 195, 'En proceso', 'Sin observaciones');


-- Insertar registros en la tabla restaurant_ventas
INSERT INTO restaurant_ventas (id_comanda, producto, cantidad, precio_unitario, subtotal, descuento) VALUES
(1, 'Producto1', 2, 10, 20, 0),
(2, 'Producto2', 1, 15, 15, 0),
(3, 'Producto3', 3, 8, 24, 0),
(4, 'Producto4', 2, 12, 24, 0),
(5, 'Producto5', 4, 10, 40, 0);

INSERT INTO restaurant_ventas (id_comanda, producto, cantidad, precio_unitario, subtotal, descuento) VALUES
(6, 'Producto6', 3, 11, 33, 0),
(7, 'Producto7', 1, 20, 20, 0),
(8, 'Producto8', 2, 9, 18, 0),
(9, 'Producto9', 4, 14, 56, 0),
(10, 'Producto10', 2, 12, 24, 0),
(11, 'Producto11', 5, 10, 50, 0),
(12, 'Producto12', 3, 15, 45, 0),
(13, 'Producto13', 1, 25, 25, 0),
(14, 'Producto14', 2, 8, 16, 0),
(15, 'Producto15', 4, 12, 48, 0),
(16, 'Producto16', 3, 11, 33, 0),
(17, 'Producto17', 1, 22, 22, 0),
(18, 'Producto18', 2, 10, 20, 0),
(19, 'Producto19', 4, 15, 60, 0),
(20, 'Producto20', 2, 13, 26, 0),
(21, 'Producto21', 5, 9, 45, 0),
(22, 'Producto22', 3, 18, 54, 0),
(23, 'Producto23', 1, 30, 30, 0),
(24, 'Producto24', 2, 7, 14, 0),
(25, 'Producto25', 4, 14, 56, 0),
(26, 'Producto26', 3, 12, 36, 0),
(27, 'Producto27', 1, 18, 18, 0),
(28, 'Producto28', 2, 11, 22, 0),
(29, 'Producto29', 4, 16, 64, 0),
(30, 'Producto30', 2, 10, 20, 0);


-- Insertar registros en la tabla restaurant_proveedores
INSERT INTO restaurant_proveedores (nombre, direccion, telefono, contacto, tipo_producto, forma_pago) VALUES
('Proveedor1', 'Dirección1', '123456789', 'Contacto1', 'Tipo1', 'Pago1'),
('Proveedor2', 'Dirección2', '987654321', 'Contacto2', 'Tipo2', 'Pago2'),
('Proveedor3', 'Dirección3', '456789123', 'Contacto3', 'Tipo3', 'Pago3'),
('Proveedor4', 'Dirección4', '321654987', 'Contacto4', 'Tipo4', 'Pago4'),
('Proveedor5', 'Dirección5', '789123456', 'Contacto5', 'Tipo5', 'Pago5');

INSERT INTO restaurant_proveedores (nombre, direccion, telefono, contacto, tipo_producto, forma_pago) VALUES
('Proveedor6', 'Dirección6', '123456780', 'Contacto6', 'Tipo6', 'Pago6'),
('Proveedor7', 'Dirección7', '987654322', 'Contacto7', 'Tipo7', 'Pago7'),
('Proveedor8', 'Dirección8', '456789124', 'Contacto8', 'Tipo8', 'Pago8'),
('Proveedor9', 'Dirección9', '321654988', 'Contacto9', 'Tipo9', 'Pago9'),
('Proveedor10', 'Dirección10', '789123457', 'Contacto10', 'Tipo10', 'Pago10'),
('Proveedor11', 'Dirección11', '123456781', 'Contacto11', 'Tipo11', 'Pago11'),
('Proveedor12', 'Dirección12', '987654323', 'Contacto12', 'Tipo12', 'Pago12'),
('Proveedor13', 'Dirección13', '456789125', 'Contacto13', 'Tipo13', 'Pago13'),
('Proveedor14', 'Dirección14', '321654989', 'Contacto14', 'Tipo14', 'Pago14'),
('Proveedor15', 'Dirección15', '789123458', 'Contacto15', 'Tipo15', 'Pago15'),
('Proveedor16', 'Dirección16', '123456782', 'Contacto16', 'Tipo16', 'Pago16'),
('Proveedor17', 'Dirección17', '987654324', 'Contacto17', 'Tipo17', 'Pago17'),
('Proveedor18', 'Dirección18', '456789126', 'Contacto18', 'Tipo18', 'Pago18'),
('Proveedor19', 'Dirección19', '321654980', 'Contacto19', 'Tipo19', 'Pago19'),
('Proveedor20', 'Dirección20', '789123459', 'Contacto20', 'Tipo20', 'Pago20'),
('Proveedor21', 'Dirección21', '123456783', 'Contacto21', 'Tipo21', 'Pago21'),
('Proveedor22', 'Dirección22', '987654325', 'Contacto22', 'Tipo22', 'Pago22'),
('Proveedor23', 'Dirección23', '456789127', 'Contacto23', 'Tipo23', 'Pago23'),
('Proveedor24', 'Dirección24', '321654981', 'Contacto24', 'Tipo24', 'Pago24'),
('Proveedor25', 'Dirección25', '789123450', 'Contacto25', 'Tipo25', 'Pago25'),
('Proveedor26', 'Dirección26', '123456784', 'Contacto26', 'Tipo26', 'Pago26'),
('Proveedor27', 'Dirección27', '987654326', 'Contacto27', 'Tipo27', 'Pago27'),
('Proveedor28', 'Dirección28', '456789128', 'Contacto28', 'Tipo28', 'Pago28'),
('Proveedor29', 'Dirección29', '321654982', 'Contacto29', 'Tipo29', 'Pago29'),
('Proveedor30', 'Dirección30', '789123451', 'Contacto30', 'Tipo30', 'Pago30');


-- Insertar registros en la tabla restaurant_inventario
INSERT INTO restaurant_inventario (nombre, descripcion, cantidad_stock, precio_unitario, id_proveedor, fecha_ingreso) VALUES
('Producto1', 'Descripción1', 10, 5, 1, CURRENT_TIMESTAMP),
('Producto2', 'Descripción2', 20, 8, 2, CURRENT_TIMESTAMP),
('Producto3', 'Descripción3', 15, 7, 3, CURRENT_TIMESTAMP),
('Producto4', 'Descripción4', 25, 6, 4, CURRENT_TIMESTAMP),
('Producto5', 'Descripción5', 30, 9, 5, CURRENT_TIMESTAMP);

INSERT INTO restaurant_inventario (nombre, descripcion, cantidad_stock, precio_unitario, id_proveedor, fecha_ingreso) VALUES
('Producto6', 'Descripción6', 35, 10, 6, CURRENT_TIMESTAMP),
('Producto7', 'Descripción7', 40, 11, 7, CURRENT_TIMESTAMP),
('Producto8', 'Descripción8', 45, 12, 8, CURRENT_TIMESTAMP),
('Producto9', 'Descripción9', 50, 13, 9, CURRENT_TIMESTAMP),
('Producto10', 'Descripción10', 5, 14, 10, CURRENT_TIMESTAMP),
('Producto11', 'Descripción11', 10, 15, 11, CURRENT_TIMESTAMP),
('Producto12', 'Descripción12', 15, 5, 12, CURRENT_TIMESTAMP),
('Producto13', 'Descripción13', 20, 6, 13, CURRENT_TIMESTAMP),
('Producto14', 'Descripción14', 25, 7, 14, CURRENT_TIMESTAMP),
('Producto15', 'Descripción15', 30, 8, 15, CURRENT_TIMESTAMP),
('Producto16', 'Descripción16', 35, 9, 16, CURRENT_TIMESTAMP),
('Producto17', 'Descripción17', 40, 10, 17, CURRENT_TIMESTAMP),
('Producto18', 'Descripción18', 45, 11, 18, CURRENT_TIMESTAMP),
('Producto19', 'Descripción19', 50, 12, 19, CURRENT_TIMESTAMP),
('Producto20', 'Descripción20', 5, 13, 20, CURRENT_TIMESTAMP),
('Producto21', 'Descripción21', 10, 14, 21, CURRENT_TIMESTAMP),
('Producto22', 'Descripción22', 15, 15, 22, CURRENT_TIMESTAMP),
('Producto23', 'Descripción23', 20, 5, 23, CURRENT_TIMESTAMP),
('Producto24', 'Descripción24', 25, 6, 24, CURRENT_TIMESTAMP),
('Producto25', 'Descripción25', 30, 7, 25, CURRENT_TIMESTAMP),
('Producto26', 'Descripción26', 35, 8, 26, CURRENT_TIMESTAMP),
('Producto27', 'Descripción27', 40, 9, 27, CURRENT_TIMESTAMP),
('Producto28', 'Descripción28', 45, 10, 28, CURRENT_TIMESTAMP),
('Producto29', 'Descripción29', 50, 11, 29, CURRENT_TIMESTAMP),
('Producto30', 'Descripción30', 5, 12, 30, CURRENT_TIMESTAMP),
('Producto31', 'Descripción31', 10, 13, 1, CURRENT_TIMESTAMP),
('Producto32', 'Descripción32', 15, 14, 2, CURRENT_TIMESTAMP),
('Producto33', 'Descripción33', 20, 15, 3, CURRENT_TIMESTAMP),
('Producto34', 'Descripción34', 25, 5, 4, CURRENT_TIMESTAMP),
('Producto35', 'Descripción35', 30, 6, 5, CURRENT_TIMESTAMP);



SELECT max(LENGTH(re.email)) from restaurant_clientes re;

select * from restaurant_restaurantes;

select re.id_empleado as "No. de Empleado",re.nombre, re.apellido, re.puesto, re.salario, re.fecha_contrato as "Fecha de Contratación", rr.nombre as "Restaurante" from restaurant_empleados re inner join restaurant_restaurantes rr on rr.id_restaurante = re.id_restaurante;

select rc.id_cliente as "No. de Cliente", rc.nombre, rc.apellido, rc.direccion, rc.telefono, rc.email as "Correo Electrónico" from restaurant_clientes rc;

SELECT 
    rc.id_comanda,
    CONCAT(rcl.nombre, ' ', rcl.apellido) AS Cliente,
    CONCAT(re.nombre, ' ', re.apellido) AS Empleado,
    rc.fecha_comanda AS "Fecha de Comanda",
    rc.total,
    rc.estado,
    rc.observaciones 
FROM 
    restaurant_comandas rc 
INNER JOIN 
    restaurant_clientes rcl ON rcl.id_cliente = rc.id_cliente 
INNER JOIN 
    restaurant_empleados re ON re.id_empleado = rc.id_empleado;

select ri.id_producto, ri.nombre, ri.descripcion, ri.cantidad_stock, ri.precio_unitario, rp.nombre as Proveedor from restaurant_inventario ri inner join restaurant_proveedores rp on rp.id_proveedor = ri.id_proveedor where ri.id_producto = '';

select * from restaurant_proveedores rp;

select * from restaurant_ventas;

select re.id_empleado as "No. de Empleado",re.nombre, re.apellido, re.puesto, re.salario, re.fecha_contrato as "Fecha de Contratación", rr.nombre as "Restaurante" from restaurant_empleados re inner join restaurant_restaurantes rr on rr.id_restaurante = re.id_restaurante where re.id_empleado = '1'
