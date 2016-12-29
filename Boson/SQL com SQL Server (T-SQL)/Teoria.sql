Teoria:

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