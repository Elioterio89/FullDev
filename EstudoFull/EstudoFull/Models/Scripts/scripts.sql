CREATE TABLE IF NOT EXISTS Pessoa (
    Id BIGINT(20) NOT NULL AUTO_INCREMENT,
    Endereco VARCHAR(255) NOT NULL,
    Genero VARCHAR(10) NOT NULL,
    PrimeiroNome VARCHAR(100) NOT NULL,
    Sobrenome VARCHAR(100)NOT NULL ,
     PRIMARY KEY(Id)
)