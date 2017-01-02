--Teoria

#A01

	SQL: Structured Query Language
		-Linguagem de Consulta Estruturada padrão para acesso a Banco de Dados.
		-Usada em inpumeros sistemas, como MySQL, SQL Server, Oracle, Sybase, Access, DB2, PostgreSQL, etc.
		-Cada sistema pode usar um "dialeto" do SQL, como T-SQL (SQL Server), PL/SQL (Oracle), JET SQL (Access), etc.

	Funções do SQL	
		-Permite o acesso a dados em SGBDR.
		-Permite definir os dados no banco de dados e manipulá-los.
		-Pode ser embutido em outras linguagues usando módulos SQL, bibliotecas, etc.
		-Permite criar e excluir bancos de dados e tabelas.
		-Permite a criação de Visões(exibições), Stored Procedures e Funções em um Banco de Dados.
		-Permite configurar permissões de acesso em tabelas, procedimentos e visões.

	Grupos de Comados
		-Os comandos SQL podem ser divididos em quatro grupos princiais:
			-DDL = Data Definition Language
				-CREATE
					-Criar uma nova tabela, visão, objeto no BD.
				-ALTER
					-Modifica um objeto existente no BD, como uma tabela.
				-DROP
					-Exclui uma tabela inteira, uma exibição de uma tabela, objeto no banco de dados.
			-DML = Data Manipulation Language
				-INSERT
					-Cria um registro(linha).
				-UPDATE
					-Modifica registros.
				-DELETE
					-Exclui registros.
			-DCL = Data Control Language
				-GRANT
					-Dá privilégios a um usuário
				-REVOKE
					-Retira privilégios a um usuário
			-DQL = Data Query Language
				-SELECT
					-Obtém registros especificados de uma ou mais tabelas atraves de consultas.

#A02

	SGBDR:
		-Sistema Gerenciador de Banco de Dados Relacional.
		-Trata-se de um sistema de gerenciamento de bancos de dados baseado no modelo relacional introduzido por E.F.Codd.

		Composição:
			-Tabelas(Relação).
				-Objetos onde são armazenados os dados em um banco de dados relacional.
				-Uma tabela é uma coleção de entradas de dados relacionados e consiste em linhas e colunas.
			-Campos(Colunas).
				-São enditades que representam os atributos dos dados como:
					-Nome;
					-Data de Nascimento;
					-Salário;
					-Preço, etc.
				-Um campo é uma coluna em uma tabela que mantém informações específicas sobre cada registro.
			-Registros(Linhas).
				-Linha ou Tupla.
				-Cada entrada individual em uma tabela.
				-Trata-se de um conjunto de campos relaiconados que caracterizam os dados de uma entidade única.

		Tipos de Dados:
			char(n)
				-String de caracteres de tamanho fixo, máximo de 8000 caracteres.
			varchar(n)
				-String de caracteres de tamanho variavel, máximo de 8000 caracteres.
			nchar(n)
				-Dados Unicode de tamanho fixo, máximo de 4000 caracteres.
			nvarchar(n)
				-Dados Unicode de tamanho variavel, maximo de 4000 caracteres.
			bit
				-0,1 ou null.
			tinyint
				-Números inteiros de 0 a 255.
				-1 byte.
			smallint
				-Números inteiros de -32768 a 32767.
				-2 bytes.
			int
				-Números inteiros entre -2,147,483,648 e 2,147,483,647.
				-4 bytes.
			bigint
				-Números entre -9,223,372,036,854,775,808 e 9,223,372,036,854,775,807.
				-8 bytes.
			real
				-Números de ponto flutuante entre -3.4 x 10°38 e 3.4 x 10°38
				-4 bytes.
			datetime
				-De 01/01/1753 a 31/12/9999, com uma precisão de 3.33 milisegundos.
				-8 bytes.
			smalldatetime
				-De 01/01/1900 a 06/06/2079, com uma precisão de 1 minuto.
				-4 bytes.
			date
				-Data apenas de 01/01/0001 a 31/12/9999
				-3 bytes.
			time
				-Hora apenas. Precisão de até 100 nanossegundos.
				-3 a 5 bytes
			text
				-Cadeia de caracteres de tamanho variavel. Até 2 GB de dados.
			money
				-Dados monetários de -922,337,203,685,477.5808 até 922,337,203,685,477.5807.
				-8 bytes.

#A03

	Criando Banco de Dados:
		CREATE DATABASE NOME_BANCO ON PRIMARY (
			NAME = <NOME_BANCO>,
			FILENAME = <'CAMINHO'>,
			SIZE = <TAMANHO_MB_KB>,
			MAXSIZE = <TAMANHO_MAXIMO_MB_KB>,
			FILEGROWTH = <TAMANHO_CRESCIMENTO_MB_%>
			)

	USE <BANCO_DE_DADOS>
		-Comando USE instrui o SGBDR a utilizar o banco de dados especificado para rodar os comandos.

	sp_helpdb <BANCO_DE_DADOS>
		-informa o tamanho, taxa de crescimento, e local do banco de dados.

#A04

	SQL Constraints (Restrições)
		-Restrições são regras aplicadas nas colunas de uma tabela.
		-São usadas para limitar os tipos de dados que são inseridos.
		-Podem ser especificadas no momento de criação da tabela (CREATE).
		-Ou após a tabela ter sido criada (ALTER).

		NOT NULL
			-A constraint NOT NULL impõe a uma coluna a NÃO aceitar valores NULL.
			-Obriga um campo a sempre possuir um valor.
			-Deste modo, não é possível inserir um registro (ou atualizar) sem entrar com um valor neste campo. 

		UNIQUE
			-Identifica de forma única cada registro em uma tabela.
			-As constraints UNIQUE e PRIMARY KEY garantem a unicidade em uma coluna ou conjunto de colunas.
			-Uma constraint PRIMARY KEY automaticamente possui uma restrição UNIQUE definida.
			-pode ter várias constraints UNIQUE em uma tabela, mas apenas uma PRIMARY KEY por tabela.

		PRIMARY KEY
			-Identifica de forma única cada registro em uma tabela.
			-devem conter valores únicos.
			-não pode conter valores NULL.
			-Cada tabela deve ter apenas uma PRIMARY KEY.

		FOREIGN KEY
			-É um campo que aponta para uma chave primária em outra tabela.

		CHECK
			-É usada para limitar uma faixa de valores que podem ser colocados em uma coluna.
			-Permite apenas determinados valores para a coluna.
			-Se for definida para a tabela, poderá limitar os valores em algumas colunas com base nos valores de outras colunas do registro.

		DEFAULT
			-É usada para inserir um valor padrão em uma coluna.
			-O valor padrão será adicionado a todos os novos registros caso nenhum outro valor seja especificado.

		IDENTITY(n<INICIAR_SEQUENCIA>,n<INCREMENTO>)
			-Deixa o campo com auto incremento.

#A05
	
	Criar Tabela
		CREATE TABLE NOME_TABELA(CAMPOS_TIPOS_CONSTRAINTS);

	sp_help <NOME_TABELA>
		-informa os índices, chaves, campos atributos, tipos de atributos de uma tabela.
		-Informa tambem as Stored procedures, comendos pré-programados de uma tabela.

#A06

	AUTO INCREMENT (IDENTITY)
		-Permite que um número único seja gerado quando um novo registro é inserido em uma tabela.
		-SQL SERVER é IDENTITY(identidade), cujo valor inicial padrão é 1, e se incremeta em 1.
		-Para que o valor de IDENTITY inicie em 100 e se incremente de 2 em 2, use IDENTITY(100,2).
		-SOMENTE PODE SER USADO NA CRIAÇÃO DA COLUNA!
		-SOMENTE PODE USAR UMA COLUNA IDENTITY POR TABELA.

#A07

	Alterar Tabelas
		-É possível alterar a estrutura de uma tabela após ter sido criada, acrescentando ou excluindo atributos (campos).

	ALTER TABLE - DROP
		-ALTER TABLE <nome_tabela>	--DELETAR COLUNA
			-DROP COLUMN <nome_coluna>

		Excluir uma constraint:
			-ALTER TABLE <nome_tabela>	--DELETAR CONSTRAINT
				-DROP CONSTRAINT <nome_constraint>

	ALTER TABLE - ADD 
		-ALTER TABLE <nome_tabela>	--ADICIONAR COLUNA
			-ADD <nome_coluna_tipos_constraints>
			CONSTRAINT <chaves PK, FK, etc.>
			REFERENCES <nome_tabela_referencia_chave>

		ALTER TABLE <nome_tabela>	--ADICIONAR CONSTRAINT
			-ADD PRIMARY KEY (<coluna_constraints>)

			-A coluna deve existir antes de ser transformada em chave primária.

	ALTER TABLE - ALTER --ALTERAR
		-ALTER TABLE <nome_tabela>
			-ALTER COLUMN <nome_coluna>
				-<tipo_dados> SMALLINT

		-Alterar antes de inserir dados.

	DROP TABLE 	--Excluir tabela
		-DROP TABLE <nome_tabela>

		