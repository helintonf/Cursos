


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

--#A06 Testando IDENTITY, Auto incremento de valores em colunas
	
	USE db_Biblioteca

	CREATE TABLE tbl_teste_identidade(
		ID_Teste SMALLINT PRIMARY KEY IDENTITY,
		Valor SMALLINT NOT NULL
		)

	INSERT INTO tbl_teste_identidade (Valor) VALUES (10);
	INSERT INTO tbl_teste_identidade (Valor) VALUES (20);
	INSERT INTO tbl_teste_identidade (Valor) VALUES (30);
	INSERT INTO tbl_teste_identidade (Valor) VALUES (40);

	SELECT * FROM tbl_teste_identidade

--#A07 ALTER e DROP TABLE - Alterar e Excluir Tabelas e Colunas
	
	--DROP
		ALTER TABLE tbl_Livro
			DROP COLUMN ID_Autor

		DROP TABLE tbl_teste_identidade

	--ADD
		ALTER TABLE tbl_Livro
			ADD ID_Autor SMALLINT NOT NULL
			CONSTRAINT fk_ID_Autor FOREIGN KEY (ID_Autor)
			REFERENCES tbl_autores

		ALTER TABLE tbl_Livro
			ADD ID_Editora SMALLINT NOT NULL
			CONSTRAINT fk_id_editora FOREIGN KEY (ID_Editora)
			REFERENCES tbl_editoras

	--ALTER
		ALTER TABLE tbl_Livro
			ALTER COLUMN ID_Autor
				SMALLINT

