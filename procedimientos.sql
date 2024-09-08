create database Solicitudes;
use Solicitudes;

create table Solicitantes (
	id_Solicitante int primary key auto_increment,
    Solicitante varchar(50),
    Area varchar(50),
    Destinatario varchar(45),
    Equipo varchar(45),
    Fecha datetime,
	Detalle varchar(100)
);

DELIMITER $$
CREATE PROCEDURE MostrarSolicitantes()
BEGIN
    select * from Solicitantes;
END $$
call MostrarSolicitantes; 


DELIMITER $$
CREATE PROCEDURE INSERTAR (
	IN Solicitante varchar(50),
	IN Area VARCHAR(50),
	IN Destinatario VARCHAR(45),
	IN Equipo VARCHAR(45),
	IN Fecha DATETIME, 
	IN Detalle VARCHAR(100)
)
BEGIN
    INSERT INTO Solicitantes(Solicitante,Area,Destinatario,Equipo,Fecha,Detalle) 
    VALUES(Solicitante,Area, Destinatario,Equipo,Fecha,Detalle);
END $$
DELIMITER $$

CALL INSERTAR('jose cruz','Recursos Humanos', 'Juan Pérez', 'Laptop', '2024-08-29', 'Requiere actualización de software');
CALL INSERTAR('HH','Finanzas', 'María López', 'Impresora', '2024-08-28', 'Necesita reparación urgente');
CALL INSERTAR('Tecnología', 'Carlos Gómez', 'Servidor', '2024-08-27', 'Problema de conectividad');
CALL INSERTAR('Ventas', 'Ana Morales', 'Proyector', '2024-08-26', 'Proyector fuera de servicio');

DELIMITER $$

CREATE PROCEDURE ACTUALIZAR (
    IN p_id INT,
    IN p_Solicitante VARCHAR(50),
    IN p_Area VARCHAR(50),
    IN p_Destinatario VARCHAR(45),
    IN p_Equipo VARCHAR(45),
    IN p_Fecha DATETIME, 
    IN p_Detalle VARCHAR(100)
)
BEGIN
    UPDATE Solicitantes
    SET 
        solicitante = p_Solicitante,
        Area = p_Area,
        Destinatario = p_Destinatario,
        Equipo = p_Equipo,
        Fecha = p_Fecha,
        Detalle = p_Detalle
    WHERE id_Solicitante = p_id;
END $$

DELIMITER ;


CALL ACTUALIZAR(2,'Ventas', 'Melissa Morales', 'Proyector', '2024-08-26', 'Proyector fuera de servicio');

DELIMITER $$
CREATE PROCEDURE ELIMINAR (
    IN id INT
)
BEGIN
    DELETE FROM Solicitantes
    WHERE id_Solicitante = id;
END $$
DELIMITER ;

CALL ELIMINAR(4);


/*BEGIN
	select * from Solicitantes
   
    WHERE Solicitante LIKE CONCAT('%', nombres, '%');
END $$
DELIMiTER ;
CALL BUSCAR('jose');*/

DELIMITER $$

CREATE PROCEDURE BUSCAR(
    IN nombre VARCHAR(50)
)
BEGIN
    SELECT * FROM Solicitantes
    WHERE Solicitante LIKE CONCAT('%', nombre, '%');
END $$

DELIMITER ;

CALL BUSCAR('jose');


DELIMITER $$

CREATE PROCEDURE BuscarSolicitantes(
    IN nombre VARCHAR(50)
)
BEGIN
    SELECT * FROM Solicitantes WHERE Solicitante LIKE CONCAT('%', nombre, '%');
END $$

DELIMITER ;
