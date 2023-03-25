CREATE TABLE ventas (
    id INT IDENTITY(1,1) PRIMARY KEY,
    cliente VARCHAR(50) NOT NULL,
    producto VARCHAR(50) NOT NULL,
    fecha_creacion DATETIME DEFAULT GETDATE()
);


CREATE TABLE recibido (
    id INT IDENTITY(1,1) PRIMARY KEY,
    cliente VARCHAR(50) NOT NULL,
    producto VARCHAR(50) NOT NULL,
    confirmado VARCHAR(50) NOT NULL,
    fecha_creacion DATETIME DEFAULT GETDATE()
);


truncate table ventas;

INSERT INTO ventas (cliente, producto)
VALUES 
    ('Juan Perez', 'Laptop'),
    ('Maria Gomez', 'Tablet'),
    ('Pedro Hernandez', 'Smartphone'),
    ('Laura Torres', 'Impresora'),
    ('Luisa Sanchez', 'Teclado'),
    ('Ramon Garcia', 'Mouse'),
    ('Sara Gonzalez', 'Monitor'),
    ('Ana Ramirez', 'Disco duro externo'),
    ('Jose Martinez', 'Altavoces'),
    ('Elena Flores', 'Router');


    INSERT INTO recibido (cliente, producto, confirmado)
VALUES
    ('Cliente 1', 'Producto 1', 'si'),
    ('Cliente 2', 'Producto 2', 'si'),
    ('Cliente 3', 'Producto 3', 'si'),
    ('Cliente 4', 'Producto 4', 'si'),
    ('Cliente 5', 'Producto 5', 'si'),
    ('Cliente 6', 'Producto 6', 'si'),
    ('Cliente 7', 'Producto 7', 'si'),
    ('Cliente 8', 'Producto 8', 'si'),
    ('Cliente 9', 'Producto 9', 'si'),
    ('Cliente 10', 'Producto 10', 'si');