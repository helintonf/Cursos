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
				

