-- Copiando dados para a tabela fullbd.pessoa: ~2 rows (aproximadamente)
 INSERT IGNORE INTO `pessoa` (`Id`, `Endereco`, `Genero`, `PrimeiroNome`, `Sobrenome`) VALUES
	(1, 'Morro do gato', 'Feminino', 'Tania', 'Lima'),
	(2, 'Costa Azul', 'Masculino', 'Pedro', 'Elioterio'),
	(3, 'Costa Azul', 'Feminino', 'Milena', 'Barreto'),
	(4, 'patamares', 'Feminino', 'Evelin', 'Barreto'),
	(5, 'Costa Azul', 'Masculino', 'Eslei', 'Elioterio');

	INSERT IGNORE INTO `livro` (`Id`, `Titulo`, `Genero`, `Editora` ,`Autor`) VALUES
	(1, 'Codigo Danvice', 'suspense', 'Abril', 'Dam brown'),
	(2, 'Turma da monica', 'gibi', 'abril', 'mauricio de souza'),
	(3, 'Cronicas de gelo e fogo', 'fantasia', 'inter', 'Geoerge');