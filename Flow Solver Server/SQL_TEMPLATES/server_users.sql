CREATE TABLE `server_users` (
  `HASH` varchar(12) NOT NULL,
  `Username` varchar(45) NOT NULL COMMENT 'Nombre de usuario',
  `Employee` varchar(6) NOT NULL COMMENT 'Numero de empleado del empleado asignado a este usuario',
  `Password` varchar(45) NOT NULL COMMENT 'Contraseña del usuario hasheada',
  `CreationDate` datetime NOT NULL,
  `LastAccess` datetime DEFAULT NULL,
  `LastAccessAttemp` datetime DEFAULT NULL,
  `Privileges` varchar(45) NOT NULL COMMENT 'Nivel de privilegios del usuario',
  PRIMARY KEY (`HASH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

