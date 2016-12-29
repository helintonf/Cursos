


--#A03 Criar Bando de Dados

	CREATE DATABASE db_Biblioteca ON PRIMARY (
				NAME = db_Biblioteca,
				FILENAME = 'C:\Users\helinton.fioramonte\Pessoal\GitHub\teste\SQL\db_Biblioteca.MDF',
				SIZE = 6MB,
				MAXSIZE = 20MB,
				FILEGROWTH = 10%
				)

--#A05 Criar Tabelas

	USE db_Biblioteca

	CREATE TABLE tbl_Livro(
		ID_Livro SMALLINT PRIMARY KEY IDENTITY(100,1),
		Nome_Livro VARCHAR(50) NOT NULL,
		ISBN VARCHAR(30) NOT NULL UNIQUE,
		ID_Autor SMALLINT NOT NULL,
		Data_Pub DATETIME NOT NULL,
		Preco_Livro MONEY NOT NULL
		)

	CREATE TABLE tbl_autores(
		ID_Autor SMALLINT PRIMARY KEY,
		Nome_Autor VARCHAR(50),
		SobreNome_Autor VARCHAR(60),
		)

	CREATE TABLE tbl_editoras(
		ID_Editora SMALLINT PRIMARY KEY IDENTITY,
		Nome_Editora VARCHAR(50) NOT NULL
		)