CREATE TABLE IF NOT EXISTS `pessoa` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Endereco` varchar(255) NOT NULL,
  `Genero` varchar(10) NOT NULL,
  `PrimeiroNome` varchar(100) NOT NULL,
  `Sobrenome` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;