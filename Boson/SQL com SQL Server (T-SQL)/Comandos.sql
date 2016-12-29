--COMANDOS

--#A03
	01)CREATE DATABASE <NOME_BANCO> ON PRIMARY (<ARGUMENTOS>);
		-Argumento (NAME = <NOME_BANCO>, FILENAME = <'CAMINHO'>, SIZE = <TAMANHO_MB_KB>, MAXSIZE = <TAMANHO_MAXIMO_MB_KB>, FILEGROWTH = <TAMANHO_CRESCIMENTO_MB_%>)

	02)USE <BANCO_DE_DADOS>
		-Comando USE instrui o SGBDR a utilizar o banco de dados especificado para rodar os comandos.

	03)sp_helpdb <BANCO_DE_DADOS>
		-informa o tamanho, taxa de crescimento, e local do banco de dados.
--#A05
	04)CREATE TABLE <NOME_TABELA>(<CAMPOS_TIPOS_CONSTRAINTS>);
		-Criar tabelas

	05)sp_help <NOME_TABELA>
			-informa os índices, chaves, campos atributos, tipos de atributos de uma tabela.
			-Informa tambem as Stored procedures, comendos pré-programados de uma tabela.